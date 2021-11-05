using System;
using System.ComponentModel;

namespace Cavaquinho.ViewModele
{
    public class EnregPresentation : INotifyPropertyChanged
    {
        // Cette note est-elle presente dans la base de données ?
        private Boolean Autorise
        {
            get { return _Autorise; }
        }
        private Boolean _Autorise;

        // on ne peut l'activer (grisé ou pas) que si elle est présente.
        public Boolean Enabled
        {
            get
            {
                return _Enabled;
            }
            set
            {
                value = (value && Autorise);
                if (_Enabled != value)
                {
                    if ((value == false) && (Checked == true))
                        // quand on grise on décoche
                        Checked = false;
                    _Enabled = value;
                    RaisePropertyChanged("Enabled");
                }
            }
        }
        private Boolean _Enabled;

        // on ne peut la chocher que si elle est présente.
        public Boolean Checked
        {
            get
            {
                return _Checked;
            }
            set
            {
                if (_Checked != value)
                {
                    _Checked = (value && Autorise && Enabled);
                    RaisePropertyChanged("Checked");
                }
            }
        }
        private Boolean _Checked;

        public EnregPresentation(Boolean autorise)
        {
            _Autorise = autorise;
            Enabled = autorise;
            Checked = false;
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string valueName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(valueName));
            }
        }
        #endregion
    }
}
