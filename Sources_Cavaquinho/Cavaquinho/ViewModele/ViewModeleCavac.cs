using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Cavaquinho.Modele;
using System.Windows;
using Microsoft.Phone.Tasks;
using System.Net.NetworkInformation;

namespace Cavaquinho.ViewModele
{
    public class ViewModeleCavacClass : INotifyPropertyChanged
    {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string valueName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(valueName));
            }
        }
        #endregion

        public string Version
        {
            get 
            {
                var asm = System.Reflection.Assembly.GetExecutingAssembly();
                var parts = asm.FullName.Split(',');
                var version = parts[1].Split('=')[1];
                return version;
            }
        }
        // Permet la présentation des positions trouvées
        public IEnumerable<EnregPresentation> ListePosition 
        {
            get {
                return _ListePosition;
            }

            set
            {
                if (value != _ListePosition)
                {
                    _ListePosition = value;
                    RaisePropertyChanged("ListePosition");
                }
            }
        }
        private IEnumerable<EnregPresentation> _ListePosition;

	    private int Position
	    {
		    get { return _Position;}
		    set {
                if (_Position != value)
                {
                    if (value < 0)
                        _Position = NbPosition - 1;
                    else
                        if (value >= NbPosition)
                            _Position = 0;
                        else
                            _Position = value;
                    // Maj de la presentation des positions
                    for (int i = 0; i < _ListePosition.Count(); i++)
                    {
                        _ListePosition.ElementAt(i).Checked = (i == _Position);
                    }
                    RaisePropertyChanged("PositionEnCours");
                }
            }
	    }
        private int _Position = 0;

        public int PositionEnCours
        {
            get {return _Position + 1;}
        }

        public int NbPosition
        {
            get
            {
                if (ListeAccords == null)
                {
                    return 0;
                }
                else
                {
                    return ListeAccords.Count();
                }
            }
        }

        private Accord _AccordEnCours = null;

        #region Recherche d'un accord

        private IEnumerable<Accord> ListeAccords
        {
            get
            {
                return _ListeAccords;
            }
            set
            {
                if (_ListeAccords != value)
                {
                    _ListeAccords = value;
                    RaisePropertyChanged("NbPosition");
                    // Maj de la liste des positions
                    List<EnregPresentation> lstpos = new List<EnregPresentation>();
                    for (int i = 0; i < _ListeAccords.Count(); i++)
                    {
                        // Crée une position
                        EnregPresentation pos = new EnregPresentation(true);
                        // la premiére est coché par défaut
                        pos.Checked = (i == 0);
                        lstpos.Add(pos);
                    };
                    ListePosition = lstpos;
                }
            }
        }
        private IEnumerable<Accord> _ListeAccords = null;

        private void ChercherAccords(NoteClass Tonalite, CouleurClass Couleur, Boolean Maj)
        {
            
            if (Tonalite == null)
            {
                // La tonalité n'est pas spécifié, on prend tout.
                ListeAccords =
                    from Accord a in Donnees.TAB_ACCORDS
                    select a;
            }
            else
            {
                // Avant de faire la recherche on test si les valeurs demandées sont autorisées.
                // exemple 1: interdit de rechercher un FA bémol car ça n'existe pas.
                // dans ce cas on supprime le bémol.

                // Utilise une variable local car Tonalite.Alteration est en lecture seul.
                eNoteNaturelle NoteNaturelleRecherche = Tonalite.NoteNaturelle;
                eAlteration AlterationRecherche = Tonalite.Alteration;
                eCouleur CouleurRecherche = Couleur.Valeur;
                // Premiére recherche, filtre tous les accords sur la notenaturelle
                IEnumerable<Accord> QueryAccord = 
                    (from Accord a in Donnees.TAB_ACCORDS
                     where a.Tonalite.NoteNaturelle == NoteNaturelleRecherche
                     select a);
                // si on ne trouve pas la note demandé on prend la premiéres qu'on trouve dans la base et on recommence
                if (QueryAccord.Count() == 0)
                {
                    NoteNaturelleRecherche = Donnees.TAB_ACCORDS[0].Tonalite.NoteNaturelle;
                    // refait la recherche
                    QueryAccord =
                        (from Accord a in Donnees.TAB_ACCORDS
                         where a.Tonalite.NoteNaturelle == NoteNaturelleRecherche
                         select a);
                }

                foreach (EnregPresentationNoteNaturelle enreg in ListeDesTonalites)
                {
                    if (enreg.NoteNaturelle == NoteNaturelleRecherche)
                    {
                        enreg.Enabled = true;
                        enreg.Checked = true;
                    }
                    else
                    {
                        enreg.Checked = false;
                    }
                }


                // Gestion de la cohérance de l'affichage des coches altérations
                // recherche dans les données les altérations disponibles pour la note naturelle demandée.
                IEnumerable<eAlteration> QueryAlteration =
                    (from Accord a in QueryAccord
                     where (a.Tonalite.NoteNaturelle == Tonalite.NoteNaturelle) &&
                       (a.Tonalite.Alteration != eAlteration.Aucun)
                     select a.Tonalite.Alteration).Distinct();
                // si on ne trouve pas l'altération demandée on l'enléve de la recherche
                if (!QueryAlteration.Contains(AlterationRecherche))
                {
                    AlterationRecherche = eAlteration.Aucun;
                    // réduit la liste de recherche
                    // QueryAccord.Where(a => a.Tonalite.Alteration == eAlteration.Aucun);
                }
                // Maj de la vue.
                foreach (EnregPresentationAlteration enreg in ListeDesAlterations)
                {
                    if (QueryAlteration.Contains(enreg.Alteration))
                    {
                        // Si l'altération est possible on l'active
                        enreg.Enabled = true;
                        // si une autre alteration que celle demandée est déjà cochée alors on la décoche. 
                        // exemple passage de C bémol à C diése.
                        if (enreg.Alteration != AlterationRecherche)
                            enreg.Checked = false;
                    }
                    else
                    {
                        // On enléve de la vue les choix qui ne sont pas possibles
                        // le Enabled décoche également si il faut.
                        enreg.Enabled = false;
                    }
                }

                // Gestion de couleur
                // On vérifie que la couleur demandé existe pour la tonalité.
                IEnumerable<eCouleur> QueryCouleur = 
                        (from Accord a in QueryAccord
                         where (a.Tonalite.Alteration == AlterationRecherche)
                         select a.Couleur.Valeur).Distinct();
                // si on ne trouve pas la couleur on prend la premiére.
                if (!QueryCouleur.Contains(CouleurRecherche))
                {
                    CouleurRecherche = QueryCouleur.FirstOrDefault();
                }

                foreach (EnregPresentationCouleur enreg in ListeDesCouleurs)
                {
                    if (QueryCouleur.Contains(enreg.Couleur.Valeur))
                    {
                        // active la couleur demandé
                        enreg.Enabled = true;
                        if (enreg.Couleur.Valeur == CouleurRecherche)
                            enreg.Checked = true;
                        else
                            enreg.Checked = false;
                    }
                    else
                    {
                        enreg.Enabled = false;
                    }
                }
                // Les 2 paramétres note et couleur sont spécifiés.
                ListeAccords =
                    from Accord a in Donnees.TAB_ACCORDS
                    where ((a.Tonalite.NoteNaturelle == Tonalite.NoteNaturelle) && (a.Tonalite.Alteration == AlterationRecherche) && (a.Couleur.Valeur == CouleurRecherche))
                    select a;
            }

            Position = 0;
            if (Maj)
                MajAccordEnCours();
        }

        #endregion

        public NoteClass Tonalite { get { if (_AccordEnCours != null) return _AccordEnCours.Tonalite; else return null; } }
        public CouleurClass Couleur { get { if (_AccordEnCours != null) return _AccordEnCours.Couleur; else return null; } }
        public string Nom { get { if (_AccordEnCours != null) return _AccordEnCours.Nom; else return null; } }
        public NotesClass Notes { get { if (_AccordEnCours != null) return _AccordEnCours.Notes; else return null; } }
        public NoteClass N1 { get { if (_AccordEnCours != null) return _AccordEnCours.Notes.N1; else return null; } }
        public NoteClass N2 { get { if (_AccordEnCours != null) return _AccordEnCours.Notes.N2; else return null; } }
        public NoteClass N3 { get { if (_AccordEnCours != null) return _AccordEnCours.Notes.N3; else return null; } }
        public NoteClass N4 { get { if (_AccordEnCours != null)  return _AccordEnCours.Notes.N4; else return null; } }
        // Les positions des notes en valeur absolue
        public CasesClass Cases { get { if (_AccordEnCours != null) return _AccordEnCours.Cases; else return null; } }
        // Les positions des notes en valeur relative
        public CasesClass CasesRelatives { get { if (_AccordEnCours != null) return _AccordEnCours.PositionRelative; else return null; } }
        public int C1 { get { if (_AccordEnCours != null) return _AccordEnCours.Cases.C1; else return 0; } }
        public int C2 { get { if (_AccordEnCours != null) return _AccordEnCours.Cases.C2; else return 0; } }
        public int C3 { get { if (_AccordEnCours != null) return _AccordEnCours.Cases.C3; else return 0; } }
        public int C4 { get { if (_AccordEnCours != null) return _AccordEnCours.Cases.C4; else return 0; } }
        
        public int NumeroCase1
        { 
            get 
            {
                if (_AccordEnCours != null)
                {
                    int Prem = _AccordEnCours.PremiereCase;
                    if (Prem == 0) Prem++;
                    return Prem;
                }
                else return 0;
            }
        }

        public int NumeroCase3
        {
            get
            {
                return NumeroCase1 + 2;
            }
        }

        private void MajAccordEnCours()
        {
            // BUG si ListeAccords est vide. A voir le traitement est pourri !
            
            if ((ListeAccords == null) || (ListeAccords.Count() == 0))
            {
                // Si la recherche précedente n'a rien donnée on retourne chez maman...
                ChercherAccords(Donnees.TAB_ACCORDS[0].Tonalite, Donnees.TAB_ACCORDS[0].Couleur, false);
            }

            
            if ((ListeAccords != null) && (ListeAccords.Count() > 0))
            {
                Accord a = ListeAccords.ElementAt(Position);
                if (_AccordEnCours == null)
                    _AccordEnCours = new Accord(a.Tonalite, a.Couleur, a.Notes, a.Cases);
                else
                    _AccordEnCours = a;
            }
            else
                // Ne doit jamais passer ici
                _AccordEnCours = null;

            RaisePropertyChanged("Tonalite");
            RaisePropertyChanged("Couleur");
            RaisePropertyChanged("Nom");

            RaisePropertyChanged("Notes");
            RaisePropertyChanged("N1");
            RaisePropertyChanged("N2");
            RaisePropertyChanged("N3");
            RaisePropertyChanged("N4");

            RaisePropertyChanged("Cases");
            RaisePropertyChanged("C1");
            RaisePropertyChanged("C2");
            RaisePropertyChanged("C3");
            RaisePropertyChanged("C4");
            RaisePropertyChanged("NumeroCase1");
            RaisePropertyChanged("NumeroCase3");
            RaisePropertyChanged("CasesRelatives");
        }

        // Constructeur. Permet de forcer le chargement de accordEnCours, déclarer = null.
        public ViewModeleCavacClass() {
            Restaurer();           
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        public void Sauvegarder()
        {
            if (_AccordEnCours != null)
            {
                Stockage.Enregistrer("SAVED_ACCORD", _AccordEnCours);
                Stockage.Enregistrer("SAVED_POSITION", _Position);
            }
        }

        public void Restaurer()
        {
                Accord savedAccord = null;
                var tmpAccord = Stockage.Lire("SAVED_ACCORD");
                if (tmpAccord is Accord)
                    savedAccord = tmpAccord as Accord;

                if (savedAccord == null)
                {
                    // Fait le chargement par défaut si rien n'a été restauré.
                    ChercherAccords(new NoteClass(eNoteNaturelle.C, eAlteration.Aucun), new CouleurClass(eCouleur.majeur), true);
                }
                else
                {
                    ChercherAccords(savedAccord.Tonalite, savedAccord.Couleur, true);
                    var tmpPosition = Stockage.Lire("SAVED_POSITION");
                    if ((tmpPosition is int) && ((int)tmpPosition > 0))
                        Position = (int)tmpPosition;
                }
                this.IsDataLoaded = true;
        }


        public void Suivant()
        {
            Position++;
            MajAccordEnCours();
        }

        public void Precedent()
        {
            Position--;
            MajAccordEnCours();
        }

        public void ChercherNoteNaturelle(eNoteNaturelle NoteNaturelle)
        {
            if ((_AccordEnCours != null) && (_AccordEnCours.Tonalite.NoteNaturelle != NoteNaturelle))
            {
                eAlteration Alteration = _AccordEnCours.Tonalite.Alteration;
                NoteClass Note = new NoteClass(NoteNaturelle, Alteration);
                ChercherAccords(Note, _AccordEnCours.Couleur, true);
            }
        }

        public void ChercherAlteration(eAlteration Alteration)
        {
            if ((Alteration != eAlteration.Aucun) && (_AccordEnCours.Tonalite.Alteration == Alteration))
                // décoche
                Alteration = eAlteration.Aucun;
            eNoteNaturelle NoteNaturelle = _AccordEnCours.Tonalite.NoteNaturelle;
            NoteClass Note = new NoteClass(NoteNaturelle, Alteration);
            ChercherAccords(Note, _AccordEnCours.Couleur, true);
        }

        public void ChercherCouleur(CouleurClass Couleur)
        {
            if ((_AccordEnCours != null) && (_AccordEnCours.Couleur.Valeur != Couleur.Valeur))
                ChercherAccords(_AccordEnCours.Tonalite, Couleur, true);
        }


        #region CommandClassSuivant
        public class CommandClassSuivant : ICommand
        {

            private ViewModeleCavacClass myGlobal;

            public CommandClassSuivant(ViewModeleCavacClass _myGlobal)
            {
                this.myGlobal = _myGlobal;
            }


            public bool CanExecute(Object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(Object parameter)
            {
                this.myGlobal.Suivant();
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(null, null);
                }
            }
        }

        // propriétée pour le binding
        public ICommand CommandSuivant
        {
            get
            {
                return new CommandClassSuivant(this);
            }
        }
        #endregion

        #region CommandClassPrecedent
        public class CommandClassPrecedent : ICommand
        {

            private ViewModeleCavacClass myGlobal;

            public CommandClassPrecedent(ViewModeleCavacClass _myGlobal)
            {
                this.myGlobal = _myGlobal;
            }


            public bool CanExecute(Object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(Object parameter)
            {
                this.myGlobal.Precedent();
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(null, null);
                }
            }
        }
        // propriétée pour le binding
        public ICommand CommandPrecedent
        {
            get
            {
                return new CommandClassPrecedent(this);
            }
        }
        #endregion

        #region CommandClassChercherNoteNaturelle
        public class CommandClassChercherNoteNaturelle : ICommand
        {

            private ViewModeleCavacClass myGlobal;

            public CommandClassChercherNoteNaturelle(ViewModeleCavacClass _myGlobal)
            {
                this.myGlobal = _myGlobal;
            }


            public bool CanExecute(Object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(Object parameter)
            {
                if (parameter != null)
                {
                    EnregPresentationNoteNaturelle enreg = (EnregPresentationNoteNaturelle)parameter;
                    this.myGlobal.ChercherNoteNaturelle(enreg.NoteNaturelle);
                    if (CanExecuteChanged != null)
                    {
                        CanExecuteChanged(null, null);
                    }
                }
            }
        }

        // propriétée pour le binding
        public ICommand CommandChercherNoteNaturelle
        {
            get
            {
                return new CommandClassChercherNoteNaturelle(this);
            }
        }
        #endregion

        #region CommandClassChercherAlteration
        public class CommandClassChercherAlteration : ICommand
        {

            private ViewModeleCavacClass myGlobal;

            public CommandClassChercherAlteration(ViewModeleCavacClass _myGlobal)
            {
                this.myGlobal = _myGlobal;
            }


            public bool CanExecute(Object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(Object parameter)
            {
                if (parameter != null)
                {
                    EnregPresentationAlteration enreg = (EnregPresentationAlteration)parameter;
                    eAlteration Alteration = enreg.Alteration;
                    this.myGlobal.ChercherAlteration(Alteration);
                    if (CanExecuteChanged != null)
                    {
                        CanExecuteChanged(null, null);
                    }
                }
            }
        }

        // propriétée pour le binding
        public ICommand CommandChercherAlteration
        {
            get
            {
                return new CommandClassChercherAlteration(this);
            }
        }
        #endregion

        #region CommandClassChercherCouleur
        public class CommandClassChercherCouleur : ICommand
        {

            private ViewModeleCavacClass myGlobal;

            public CommandClassChercherCouleur(ViewModeleCavacClass _myGlobal)
            {
                this.myGlobal = _myGlobal;
            }

            public bool CanExecute(Object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(Object parameter)
            {
                if (parameter != null)
                {
                    EnregPresentationCouleur enreg = (EnregPresentationCouleur)parameter;
                    this.myGlobal.ChercherCouleur(enreg.Couleur);
                    if (CanExecuteChanged != null)
                    {
                        CanExecuteChanged(null, null);
                    }
                }
            }
        }

        // propriétée pour le binding
        public ICommand CommandChercherCouleur
        {
            get
            {
                return new CommandClassChercherCouleur(this);
            }
        }
        #endregion

        #region Listes pour le binding des tonalitées, altérations, couleur

        public IEnumerable<EnregPresentationNoteNaturelle> ListeDesTonalites
        {
            get
            {
                return ListePresentationNoteNaturelleClass.Liste;
            }
        }

        public IEnumerable<EnregPresentationAlteration> ListeDesAlterations
        {
            get
            {
                return ListePresentationAlterationClass.Liste;
            }
        }

        public EnregPresentationAlteration AlterationBemol
        {
            get
            {
                return ListeDesAlterations.ElementAt(0);
            }
        }

        public EnregPresentationAlteration AlterationDiese
        {
            get
            {
                return ListeDesAlterations.ElementAt(1);
            }
        }

        public IEnumerable<EnregPresentationCouleur> ListeDesCouleurs
        {
            get
            {
                return ListePresentationCouleurClass.Liste;
            }
        }
        #endregion
  
        #region commande Play()


        private GestionnaireSon _GestSon = null;
        private GestionnaireSon GestSon
        {
            get
            {
                if (_GestSon == null)
                {
                    _GestSon = new GestionnaireSon();
                }
                return _GestSon;
            }
        }

        public void PlayAccord()
        {
            if (_AccordEnCours != null)
            {
                GestSon.Play(_AccordEnCours);
            }
        }

        public class CommandClassPlayAccord : ICommand
        {
            private ViewModeleCavacClass myGlobal;

            public CommandClassPlayAccord(ViewModeleCavacClass _myGlobal)
            {
                this.myGlobal = _myGlobal;
            }

            public bool CanExecute(Object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(Object parameter)
            {
                this.myGlobal.PlayAccord();
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(null, null);
                }
            }
        }
        // propriétée pour le binding
        public ICommand CommandPlayAccord
        {
            get
            {
                return new CommandClassPlayAccord(this);
            }
        }
        #endregion
                
        public void EMail(string destinataire, string body)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            emailComposeTask.Subject = "Cavaquinho - Windows Phone";
            emailComposeTask.Body = body;
            emailComposeTask.To = destinataire;
            emailComposeTask.Show();
        }

        #region commande pour l'envoye d'un email

        public class CommandClassEMail : ICommand
        {
            private ViewModeleCavacClass myGlobal;

            public CommandClassEMail(ViewModeleCavacClass _myGlobal)
            {
                this.myGlobal = _myGlobal;
            }

            public bool CanExecute(Object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(Object parameter)
            {
                this.myGlobal.EMail("", "pedaloproduction@yahoo.fr");                
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(null, null);
                }
            }
        }
        // propriétée pour le binding
        public ICommand CommandEMail
        {
            get
            {
                return new CommandClassEMail(this);
            }
        }
        #endregion

        #region commande pour l'envoye d'un partage email

        public class CommandClassPartagerParEMail : ICommand
        {
            private ViewModeleCavacClass myGlobal;

            public CommandClassPartagerParEMail(ViewModeleCavacClass _myGlobal)
            {
                this.myGlobal = _myGlobal;
            }

            public bool CanExecute(Object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(Object parameter)
            {
                string body = "http://www.windowsphone.com/s?appid=0c285399-26bf-46f0-9b4e-a20b4d5f7e9d";
                //body = "";
                this.myGlobal.EMail("", body);
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(null, null);
                }
            }
        }
        // propriétée pour le binding
        public ICommand CommandPartagerParEMail
        {
            get
            {
                return new CommandClassPartagerParEMail(this);
            }
        }
        #endregion

        #region commande MarketplaceReview()

        public void MarketplaceReview()
        {
            // a voir MarketplaceDetailTask, peut être pour diriger l'utilisateur vers une autre appli
            var task = new MarketplaceReviewTask();
            task.Show();
        }

        public class CommandClassMarketplaceReview : ICommand
        {
            private ViewModeleCavacClass myGlobal;

            public CommandClassMarketplaceReview(ViewModeleCavacClass _myGlobal)
            {
                this.myGlobal = _myGlobal;
            }

            public bool CanExecute(Object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(Object parameter)
            {
                this.myGlobal.MarketplaceReview();
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(null, null);
                }
            }
        }
        // propriétée pour le binding
        public ICommand CommandMarketplaceReview
        {
            get
            {
                return new CommandClassMarketplaceReview(this);
            }
        }
        #endregion

        #region commande CommandClassPartager()

        public void Partager()
        {
            ShareStatusTask shareStatusTask = new ShareStatusTask();
            shareStatusTask.Status = "Cavaquinho pour Windows Phone";
            shareStatusTask.Show();
        }

        public class CommandClassPartager : ICommand
        {
            private ViewModeleCavacClass myGlobal;

            public CommandClassPartager(ViewModeleCavacClass _myGlobal)
            {
                this.myGlobal = _myGlobal;
            }

            public bool CanExecute(Object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(Object parameter)
            {
                this.myGlobal.Partager();
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(null, null);
                }
            }
        }
        // propriétée pour le binding
        public ICommand CommandPartager
        {
            get
            {
                return new CommandClassPartager(this);
            }
        }

        #endregion

        #region commande MarketplaceMandoline()

        public void MarketplaceDetailApplication(string appID)
        {
            // plan comptable = 4ee3ba71-555c-4b6a-9b90-27d7358fac9e
            // cavaquinho = 0c285399-26bf-46f0-9b4e-a20b4d5f7e9d
            // mandoline = 1e53ac4b-8977-431b-b8e6-958ac18fc406
            // Pour diriger l'utilisateur vers une appli du store
            MarketplaceDetailTask task = new MarketplaceDetailTask();
            task.ContentIdentifier = appID;
            task.ContentType = MarketplaceContentType.Applications;
            task.Show();
        }

        public class CommandClassMarketplaceMandoline : ICommand
        {
            private ViewModeleCavacClass myGlobal;

            public CommandClassMarketplaceMandoline(ViewModeleCavacClass _myGlobal)
            {
                this.myGlobal = _myGlobal;
            }

            public bool CanExecute(Object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(Object parameter)
            {
                this.myGlobal.MarketplaceDetailApplication("1e53ac4b-8977-431b-b8e6-958ac18fc406");
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(null, null);
                }
            }
        }
        // propriétée pour le binding
        public ICommand CommandMarketplaceMandoline
        {
            get
            {
                return new CommandClassMarketplaceMandoline(this);
            }
        }

        #endregion
    }
}
