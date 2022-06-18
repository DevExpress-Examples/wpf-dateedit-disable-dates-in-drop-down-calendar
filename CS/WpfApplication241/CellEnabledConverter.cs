using DevExpress.Xpf.Editors.Popups.Calendar;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfApplication241 {
    public class CellEnabledConverter : MarkupExtension, IMultiValueConverter {

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            List<DateTime> disabledDates = values[0] as List<DateTime>;
            Button cellButton = (Button)values[1];
            DateTime dt = (DateTime)DateEditCalendar.GetDateTime(cellButton);
            if(disabledDates != null)
                return disabledDates.Contains(dt);
            else
                return false;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}
