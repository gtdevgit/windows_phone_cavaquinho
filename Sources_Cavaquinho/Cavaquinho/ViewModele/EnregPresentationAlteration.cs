using System;
using Cavaquinho.Modele;
using System.Collections.Generic;

namespace Cavaquinho.ViewModele
{
    //public enum eAlteration { Aucun, Bemol, Diese };
    public class EnregPresentationAlteration : EnregPresentation
    {
        public eAlteration Alteration
        {
            get
            {
                return _Alteration;
            }
        }
        private eAlteration _Alteration;

        public EnregPresentationAlteration(eAlteration alteration, Boolean autorise)
            : base(autorise)
        {
            _Alteration = alteration;
        }
    }

    public static class ListePresentationAlterationClass
    {
        public static IEnumerable<EnregPresentationAlteration> Liste
        {
            get
            {
                if (_Items == null)
                {
                    //_Items = new List<EnregPresentationAlteration>();
                    //// Charge la liste # et b
                    //_Items.Add(new EnregPresentationAlteration(eAlteration.Bemol, true));
                    //_Items.Add(new EnregPresentationAlteration(eAlteration.Diese, true));
                    _Items = new EnregPresentationAlteration[] {
                        new EnregPresentationAlteration(eAlteration.Bemol, true),
                        new EnregPresentationAlteration(eAlteration.Diese, true) };
                }
                return _Items;
            }
        }
        private static IEnumerable<EnregPresentationAlteration> _Items = null;
    }

}
