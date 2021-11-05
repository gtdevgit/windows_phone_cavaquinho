using System;
using System.Runtime.Serialization;

namespace Cavaquinho.Modele
{
    [DataContractAttribute]
    public class Accord
    {
        private NoteClass tonalite = null;
        private CouleurClass couleur = null;
        private NotesClass notes = null;
        private CasesClass cases = null;

        [DataMember]
        public NoteClass Tonalite
        {
            get { return tonalite; }
            set { tonalite = value; }
        }

        [DataMember]
        // set uniquement pour le DataContract
        public CouleurClass Couleur 
        { 
            get { return couleur; } 
            set { couleur = value; }
        }

        [DataMember]
        public NotesClass Notes 
        { 
            get { return notes; }
            set { notes = value; }
        }
        [DataMember]
        public CasesClass Cases 
        { 
            get { return cases; }
            set { cases = value; }
        }

        public string Nom { 
            get 
            {
                return String.Format("{0} {1}", Tonalite.NoteToString(), Couleur.CouleurToString()); 
            } 
        }
                
        // on construit un accord avec sa note, sa couleur, les notes le constituant et la position des cases sur le manche.
        // Ici la positions des cases est absolut.
        public Accord(NoteClass _Tonalite, CouleurClass _Couleur, NotesClass _Notes, CasesClass _Cases)
        {
            this.tonalite = _Tonalite;
            this.couleur = _Couleur;
            this.notes = _Notes;
            this.cases = _Cases;
        }

        public int PremiereCase
        {
            get
            {
                // Cherche la plus petite des cases
                int PlusPetite = Cases.C1;
                if (Cases.C2 < PlusPetite) PlusPetite = Cases.C2;
                if (Cases.C3 < PlusPetite) PlusPetite = Cases.C3;
                if (Cases.C4 < PlusPetite) PlusPetite = Cases.C4;
                return PlusPetite;
            }
        }

        private int DerniereCase()
        {
            // Cherche la plus grande des cases
            int PlusGrande = Cases.C1;
            if (Cases.C2 > PlusGrande) PlusGrande = Cases.C2;
            if (Cases.C3 > PlusGrande) PlusGrande = Cases.C3;
            if (Cases.C4 > PlusGrande) PlusGrande = Cases.C4;
            return PlusGrande;
        }

        private bool DebutManche(int C1, int C2, int C3, int C4)
        {
            // si un des cases est en début de manche, donc = 0
            return (C1 * C2 * C3 * C4 == 0);
        }

        private bool DebutManche(CasesClass C)
        { 
            // si un des cases est en début de manche, donc = 0
            return DebutManche(C.C1, C.C2, C.C3, C.C4);
        }

        public CasesClass PositionRelative
        {
            get
            {
                if (DebutManche(Cases))
                    return Cases;
                else
                {
                    // Cherche la plus petite cases
                    int PlusPetite = PremiereCase;
                    // On décale tout
                    int C1 = (Cases.C1 - PlusPetite);
                    int C2 = (Cases.C2 - PlusPetite);
                    int C3 = (Cases.C3 - PlusPetite);
                    int C4 = (Cases.C4 - PlusPetite);
                    if (DebutManche(C1, C2, C3, C4))
                    {
                        // aprés une transposition on remet les 0 sur la cases 1
                        C1++;
                        C2++;
                        C3++;
                        C4++;
                    }
                    CasesClass R = new CasesClass(C1, C2, C3, C4);
                    return R;
                }
            }
        }
    }
}
