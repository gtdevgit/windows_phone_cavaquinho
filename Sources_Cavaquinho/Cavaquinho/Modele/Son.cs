using Microsoft.Xna.Framework.Audio;
using System;
using System.Windows;
using System.Windows.Resources;

namespace Cavaquinho.Modele
{
    class Son
    {
        private string Fichier = String.Empty;
        SoundEffect se = null;
        SoundEffectInstance sei = null;

        public Son(string fichier)
        {
            Fichier = fichier;
            // chargement du son
            StreamResourceInfo sri1 = Application.GetResourceStream(new Uri(fichier, UriKind.Relative));

            se = SoundEffect.FromStream(sri1.Stream);
            sei = se.CreateInstance();               
        }

        public void Play()
        {
            sei.Play();
        }

        public void Stop()
        {
            sei.Stop();
        }

        public float Pitch
        {
            get
            {
                return sei.Pitch;
            }
            set 
            {
                // taquets sur les valeur + et -
                if (value < -1.0f) 
                    value = -1.0f;
                else
	                if (value > 1.0f)
                        value = 1.0f;

                if (sei.Pitch != value)
                {
                    sei.Pitch = value;
                }
            }
        }
    }
}
