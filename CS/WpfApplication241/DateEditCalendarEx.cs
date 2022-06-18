using DevExpress.Xpf.Editors.Popups.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication241 {
    public class DateEditCalendarEx : DateEditCalendar {
        protected override void OnCellButtonClick(object sender, RoutedEventArgs e) {
            var button = sender as Button;
            if(button.IsEnabled) {
                base.OnCellButtonClick(sender, e);
            }

        }
    }
}
