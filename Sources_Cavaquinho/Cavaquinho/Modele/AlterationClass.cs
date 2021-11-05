
namespace Cavaquinho.Modele
{
    public enum eAlteration { Aucun, Bemol, Diese };

    public static class AlterationClass
    {
        public static string AlterationToString(eAlteration value)
        {
            string S = null;
            switch (value)
            {
                case eAlteration.Bemol:
                    S = "b";
                    break;
                case eAlteration.Diese:
                    S = "#";
                    break;
                default:
                    S = "";
                    break;
            }
            return S;
        }
    }
}
