using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Data;
using System.Globalization;
using Cavaquinho.Modele;

namespace Cavaquinho.ViewModele
{
    public class NoteNaturelleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is eNoteNaturelle)
                return NoteNaturelleClass.NoteNaturelleToString((eNoteNaturelle)value);
            else
                return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class AlterationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is eAlteration)
                return AlterationClass.AlterationToString((eAlteration)value);
            else
                return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    // [ValueConversion(typeof(NoteClass), typeof(String))]
    public class NoteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is NoteClass)
                return (value as NoteClass).NoteToString();
            else
                return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class NotesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is NotesClass)
            {
                NotesClass N = (NotesClass)value;
                return N.NotesToString();
            }
            else
                return "";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class CouleurConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is eCouleur)
            {
                return CouleurClass.CouleurToString((eCouleur)value);
            }
            else
                return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
    
    public class CasesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CasesClass)
            {
                CasesClass C = (CasesClass)value;
                return String.Format("{0} {1} {2} {3}", C.C1, C.C2, C.C3, C.C4);
            }
            else 
                return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class CasesRelativeToPointConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CasesClass)
            {
                CasesClass C = (CasesClass)value;
                int x = 0;
                int y = 0;
                const int origineX = 70;
                const int pasX = 46;
                int numcase = 0;
                if (parameter is String)
                {
                    String param = (string)parameter;
                    
                    if (param == "1")
                    {
                        x = origineX;
                        numcase = C.C1;
                    }
                    else
                        if (param == "2")
                        {
                            x = origineX + pasX;
                            numcase = C.C2;
                        }
                        else
                            if (param == "3")
                            {
                                x = origineX + (2 * pasX);
                                numcase = C.C3;
                            }
                            else
                                if (param == "4")
                                {
                                    x = origineX + (3 * pasX);
                                    numcase = C.C4;
                                }
                }
                // trf le numéro de case en coordonnées 
                // *60 pour être en haut de la case
                // +30 pour ce centrer dans la case
                const int origineY = 78;
                const int pasY = 50;
                if (numcase > 0)
                    //y = ((numcase - 1) * 60) + 30;
                    y = origineY + ((numcase - 1) * pasY);

                return new Point(x, y);
            }
            else 
                return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class CasesToOpacityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CasesClass)
            {
                CasesClass C = (CasesClass)value;
                int numcase = 0;
                if (parameter is String)
                {
                    String param = (string)parameter;

                    if (param == "1")
                    {
                        numcase = C.C1;
                    }
                    else
                        if (param == "2")
                        {
                            numcase = C.C2;
                        }
                        else
                            if (param == "3")
                            {
                                numcase = C.C3;
                            }
                            else
                                if (param == "4")
                                {
                                    numcase = C.C4;
                                }
                }
                // Renvoie l'opacity 0 = case en bout de manche
                if (numcase == 0)
                    return 0.0;
                else
                    return 1.0;
	        }
            else
                return 0.0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class EnregPositionToBrush : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Boolean)
            {
                Boolean Checked = (Boolean)value;
                if (Checked)
                {
                    Color c = (Color)Application.Current.Resources["PhoneAccentColor"];
                    return new SolidColorBrush(c);
                }
                else
                {
                    Color c = (Color)Application.Current.Resources["PhoneDisabledColor"];
                    return new SolidColorBrush(c);
                }
            }
            else
                return new SolidColorBrush(Colors.Transparent);

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

}
