using System.IO.IsolatedStorage;

namespace Cavaquinho
{
    public static class Stockage
    {
        public static void Enregistrer(string Cle, object Valeur)
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            if (!settings.Contains(Cle))
            {
               settings.Add(Cle, Valeur);
            }
            else
            {
                settings[Cle] = Valeur;
            }
            settings.Save();
        }

        public static object Lire(string Cle)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains(Cle))
            {
                return IsolatedStorageSettings.ApplicationSettings[Cle] as object;
            }
            else
            {
                return null;
            }
        }
    }
}
