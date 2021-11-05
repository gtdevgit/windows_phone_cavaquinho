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

                    // Charge la liste de toute les notes que l'on veut afficher. 
                    // Le deuxiéme paramétres permet de spécifier si son utilisation sera autorisé. (si présent dans les données)
                    _Items = new EnregPresentationNoteNaturelle [] {
                        new EnregPresentationNoteNaturelle(eNoteNaturelle.C, Query.Contains(eNoteNaturelle.C)),
                        new EnregPresentationNoteNaturelle(eNoteNaturelle.D, Query.Contains(eNoteNaturelle.D)),
                        new EnregPresentationNoteNaturelle(eNoteNaturelle.E, Query.Contains(eNoteNaturelle.E)),
                        new EnregPresentationNoteNaturelle(eNoteNaturelle.F, Query.Contains(eNoteNaturelle.F)),
                        new EnregPresentationNoteNaturelle(eNoteNaturelle.G, Query.Contains(eNoteNaturelle.G)),
                        new EnregPresentationNoteNaturelle(eNoteNaturelle.A, Query.Contains(eNoteNaturelle.A)),
                        new EnregPresentationNoteNaturelle(eNoteNaturelle.B, Query.Contains(eNoteNaturelle.B)) };
                }
                return _Items; 
            }
        }
        private static IEnumerable<EnregPresentationNoteNaturelle> _Items = null;
    }
}
