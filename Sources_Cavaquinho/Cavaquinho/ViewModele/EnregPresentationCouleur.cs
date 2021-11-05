using System;
using Cavaquinho.Modele;
using System.Collections.Generic;
using System.Linq;

namespace Cavaquinho.ViewModele
{
    public class EnregPresentationCouleur : EnregPresentation
    {
        public CouleurClass Couleur 
        { 
            get
            {
                return _Couleur;
            }
        }
        private CouleurClass _Couleur;

        public EnregPresentationCouleur(eCouleur valeur, Boolean autorise) :
            base(autorise)
        {
            _Couleur = new CouleurClass(valeur);
        }
    }

    public static class ListePresentationCouleurClass
    {
        public static IEnumerable<EnregPresentationCouleur> Liste
        {
            get
            {
                if (_Items == null)
                {
                    IEnumerable<eCouleur> Query = (from Accord a in Donnees.TAB_ACCORDS
                        select a.Couleur.Valeur).Distinct();
                    //majeur, , , , , , , , , , , , , , , , , , , ,  };
                    _Items = new EnregPresentationCouleur[] { 
                        new EnregPresentationCouleur(eCouleur.majeur, Query.Contains(eCouleur.majeur)),  
                        new EnregPresentationCouleur(eCouleur.sept_majeur, Query.Contains(eCouleur.sept_majeur)),  
                        new EnregPresentationCouleur(eCouleur.sept, Query.Contains(eCouleur.sept)),  
                        new EnregPresentationCouleur(eCouleur.sept9, Query.Contains(eCouleur.sept9)),  
                        new EnregPresentationCouleur(eCouleur.mineur, Query.Contains(eCouleur.mineur)),  
                        new EnregPresentationCouleur(eCouleur.mineur7, Query.Contains(eCouleur.mineur7)),  
                        new EnregPresentationCouleur(eCouleur.mineur7_5b, Query.Contains(eCouleur.mineur7_5b)),  
                        new EnregPresentationCouleur(eCouleur.mineur6, Query.Contains(eCouleur.mineur6)),  
                        new EnregPresentationCouleur(eCouleur.mineur9, Query.Contains(eCouleur.mineur9)),  
                        new EnregPresentationCouleur(eCouleur.mineur7_9, Query.Contains(eCouleur.mineur7_9)),  
                        new EnregPresentationCouleur(eCouleur.mineur7_5plus, Query.Contains(eCouleur.mineur7_5plus)),  
                        new EnregPresentationCouleur(eCouleur.diminue, Query.Contains(eCouleur.diminue)),  
                        new EnregPresentationCouleur(eCouleur.quarte, Query.Contains(eCouleur.quarte)),  
                        new EnregPresentationCouleur(eCouleur.quinteplus, Query.Contains(eCouleur.quinteplus)),  
                        new EnregPresentationCouleur(eCouleur.six, Query.Contains(eCouleur.six)),  
                        new EnregPresentationCouleur(eCouleur.six9, Query.Contains(eCouleur.six9)),  
                        new EnregPresentationCouleur(eCouleur.sept_9moins, Query.Contains(eCouleur.sept_9moins)),
                        new EnregPresentationCouleur(eCouleur.sept_9plus, Query.Contains(eCouleur.sept_9plus)),
                        new EnregPresentationCouleur(eCouleur.sept_13, Query.Contains(eCouleur.sept_13)),
                        new EnregPresentationCouleur(eCouleur.sept_13moins, Query.Contains(eCouleur.sept_13moins)),
                        new EnregPresentationCouleur(eCouleur.neuf, Query.Contains(eCouleur.neuf))};
                }
                return _Items;
            }
        }
        private static IEnumerable<EnregPresentationCouleur> _Items = null;
    }
}
