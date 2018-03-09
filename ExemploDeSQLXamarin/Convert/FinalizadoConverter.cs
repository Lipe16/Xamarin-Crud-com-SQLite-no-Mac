using System;
using System.Globalization;
using Xamarin.Forms;

namespace ExemploDeSQLXamarin.Convert
{
    public class FinalizadoConverter : IValueConverter
    {
        public FinalizadoConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valor = (bool)value;

            if(valor == false){
                return "Aberta";
            }else{
                return "Fechada";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
