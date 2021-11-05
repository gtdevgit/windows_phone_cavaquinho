using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Threading;

namespace Cavaquinho.Modele
{
    class GestionnaireSon
    {
        private Son corde1, corde2, corde3, corde4 = null;
        // Intervale de temps entre les notes (accords plaqué ou égrainé = 200ms)
        private int egrenageVitesse;
        // Compteur pour le nombre de notes à jouer
        int egrenageCptNote;
        private DispatcherTimer egrenageTimer;

        public GestionnaireSon()
        {
            // Cré les 4 cordes;
            // D, corde du bas, ré aigue
            corde1 = new Son("Sons/Corde1.wav");
            // B
            corde2 = new Son("Sons/Corde2.wav");
            // G
            corde3 = new Son("Sons/Corde3.wav");
            // D, corde du haut, ré grave
            corde4 = new Son("Sons/Corde4.wav");

            // required for xna sound effects to work
            Microsoft.Xna.Framework.FrameworkDispatcher.Update();

            egrenageVitesse = 120;
            egrenageCptNote = 0;
            egrenageTimer = new DispatcherTimer();
            egrenageTimer.Tick += egrenageTimer_Tick;
            egrenageTimer.Interval = new TimeSpan(0, 0, 0, 0, egrenageVitesse);

        }

        private bool PreparerPitch(Son corde, int NumCase)
        {
            if ((NumCase >= 0) && (NumCase <= 11))
            {
                float[] tabPitch = { 0, 0.0833f, 0.1666f, 0.25f, 0.3333f, 0.4166f, 0.5f, 0.5833f, 0.6666f, 0.75f, 0.8333f, 0.9166f };
                corde.Pitch = tabPitch[NumCase];
                return true;
            }
            else
                return false;
        }

        private bool PreparerPitchs(int c1, int c2, int c3, int c4)
        {
            // attention le N° des cases est inversé par rapport au N° des cordes
            // case1 = en haut case 4 = en bas
            // corde 1 = en bas corde 4 = en haut.
            return (PreparerPitch(corde4, c1) &&
                PreparerPitch(corde3, c2) &&
                PreparerPitch(corde2, c3) &&
                PreparerPitch(corde1, c4));
        }

        void egrenageTimer_Tick(object sender, EventArgs e)
        {
            egrenageCptNote++;
            if (egrenageCptNote >= 5)
            {
                egrenageTimer.Stop();
                egrenageCptNote = 0;
            }

            if (egrenageCptNote == 1)
                corde4.Play();
            else
                if (egrenageCptNote == 2)
                    corde3.Play();
                else
                    if (egrenageCptNote == 3)
                        corde2.Play();
                    else
                        if (egrenageCptNote == 4)
                            corde1.Play();
        }

        public void Play(Accord accord)
        {
            egrenageTimer.Stop();
            Stop();
            egrenageCptNote = 0;

            // Prepare les notes. Si une des notes est trop loin du début du manche on ne joue rien
            if (PreparerPitchs(accord.Cases.C1, accord.Cases.C2, accord.Cases.C3, accord.Cases.C4))
            {
                //corde4.Play();
                egrenageTimer.Start();
            }
        }

        public void Stop()
        {
            corde4.Stop();
            corde3.Stop();
            corde2.Stop();
            corde1.Stop();
        }

        public int EgrenageVitesse
        {
            get { return egrenageVitesse; }

            set
            {
                if (egrenageVitesse != value)
                {
                    egrenageVitesse = value;
                    egrenageTimer.Stop();
                    egrenageTimer.Interval = new TimeSpan(0, 0, 0, 0, egrenageVitesse);
                }
            }
        }

        public void ModifierPitchAbsolue(float pitchCorde1, float pitchCorde2, float pitchCorde3, float pitchCorde4)
        {
            corde1.Pitch = pitchCorde1;
            corde2.Pitch = pitchCorde2;
            corde3.Pitch = pitchCorde3;
            corde4.Pitch = pitchCorde4;
        }
    }
}
