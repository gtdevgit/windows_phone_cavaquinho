
namespace Cavaquinho.Modele
{
    public enum eNoteNaturelle { C, D, E, F, G, A, B };

    public class NoteNaturelleClass
    {
        public static string NoteNaturelleToString(eNoteNaturelle value)
        {
            string S = null;
            switch (value)
            {
                case eNoteNaturelle.C:
                    S = "C";
                    break;
                case eNoteNaturelle.D:
                    S = "D";
                    break;
                case eNoteNaturelle.E:
                    S = "E";
                    break;
                case eNoteNaturelle.F:
                    S = "F";
                    break;
                case eNoteNaturelle.G:
                    S = "G";
                    break;
                case eNoteNaturelle.A:
                    S = "A";
                    break;
                case eNoteNaturelle.B:
                    S = "B";
                    break;
                default:
                    S = "";
                    break;
            }
            return S;
        }      
    }
}
