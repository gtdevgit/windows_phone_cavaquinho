using System;
using Cavaquinho.Modele;
using System.Collections.Generic;
using System.Linq;

namespace Cavaquinho.ViewModele
{
    public class EnregPresentationNoteNaturelle: EnregPresentation
    {
        public eNoteNaturelle NoteNaturelle 
        { 
            get { return _NoteNaturelle; }
        }
        private eNoteNaturelle _NoteNaturelle;

        public EnregPresentationNoteNaturelle(eNoteNaturelle noteNaturelle, Boolean autorise) 
            : base (autorise)
        {
            _NoteNaturelle = noteNaturelle;
        }
    }

    public static class ListePresentationNoteNaturelleClass 
    {
        public static IEnumerable<EnregPresentationNoteNaturelle> Liste
        {
            get {
                if (_Items == null)
                {
                    IEnumerable<eNoteNaturelle> Query = null;
                    Query = (from Accord a in Donnees.TAB_ACCORDS
                            select a.Tonalite.NoteNaturelle).Distinct();
                    _Items = new List<EnregPresentationNoteNaturelle>();

                    // Charge la liste de toute les notes que l'on veut afficher. 
                    // Le deuxiéme paramétres permet de spécifier si son utilisation sera autorisé. (si présent dans les données)
                    _Items.Add(new EnregPresentationNoteNaturelle(eNoteNaturelle.C, Query.Contains(eNoteNaturelle.C)));
                    _Items.Add(new EnregPresentationNoteNaturelle(eNoteNaturelle.D, Query.Contains(eNoteNaturelle.D)));
                    _Items.Add(new EnregPresentationNoteNaturelle(eNoteNaturelle.E, Query.Contains(eNoteNaturelle.E)));
                    _Items.Add(new EnregPresentationNoteNaturelle(eNoteNaturelle.F, Query.Contains(eNoteNaturelle.F)));
                    _Items.Add(new EnregPresentationNoteNaturelle(eNoteNaturelle.G, Query.Contains(eNoteNaturelle.G)));
                    _Items.Add(new EnregPresentationNoteNaturelle(eNoteNaturelle.A, Query.Contains(eNoteNaturelle.A)));
                    _Items.Add(new EnregPresentationNoteNaturelle(eNoteNaturelle.B, Query.Contains(eNoteNaturelle.B)));
                }
                return _Items as IEnumerable<EnregPresentationNoteNaturelle>; 
            }
        }
        private static List<EnregPresentationNoteNaturelle> _Items = null;
    }
}
