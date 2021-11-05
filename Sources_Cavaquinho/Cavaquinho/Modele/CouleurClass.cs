using System.Runtime.Serialization;

namespace Cavaquinho.Modele
{
    public enum eCouleur { majeur, sept_majeur, sept, sept9, mineur, mineur7, mineur7_5b, mineur6, mineur9, mineur7_9, mineur7_5plus, diminue, quarte, quinteplus, six, six9, sept_9moins, sept_9plus, sept_13, sept_13moins, neuf };

    [DataContractAttribute]
    public class CouleurClass
    {
        public CouleurClass(eCouleur valeur)
        {
            _Valeur = valeur;
        }

        [DataMember]
        public eCouleur Valeur
        {
            get { return _Valeur; }
            set { _Valeur = value; }
        }
        private eCouleur _Valeur;

        public string CouleurToString()
        {
            return CouleurClass.CouleurToString(this.Valeur);
        }

        public static string CouleurToString(eCouleur value)
        {
            string S = null;
            switch (value)
            {
                case eCouleur.majeur:
                    S = "maj";
                    break;
                case eCouleur.sept_majeur:
                    S = "7M";
                    break;
                case eCouleur.sept:
                    S = "7";
                    break;
                case eCouleur.sept9:
                    S = "7/9";
                    break;
                case eCouleur.mineur:
                    S = "min";
                    break;
                case eCouleur.mineur7:
                    S = "min7";
                    break;
                case eCouleur.mineur7_5b:
                    S = "m7/5b";
                    break;
                case eCouleur.mineur6:
                    S = "min6";
                    break;
                case eCouleur.mineur9:
                    S = "min9";
                    break;
                case eCouleur.mineur7_9:
                    S = "min7/9";
                    break;
                case eCouleur.mineur7_5plus:
                    S = "min7/5+";
                    break;
                case eCouleur.diminue:
                    S = "dim";
                    break;
                case eCouleur.quarte:
                    S = "4";
                    break;
                case eCouleur.quinteplus:
                    S = "5+";
                    break;
                case eCouleur.six:
                    S = "6";
                    break;
                case eCouleur.six9:
                    S = "6/9";
                    break;
                case eCouleur.sept_9moins:
                    S = "7/9-";
                    break;
                case eCouleur.sept_9plus:
                    S = "7/9+";
                    break;
                case eCouleur.sept_13:
                    S = "7/13";
                    break;
                case eCouleur.sept_13moins:
                    S = "7/13-";
                    break;
                case eCouleur.neuf:
                    S = "9";
                    break;
                default:
                    S = "";
                    break;
            }
            return S;
        }
    }
    
}
