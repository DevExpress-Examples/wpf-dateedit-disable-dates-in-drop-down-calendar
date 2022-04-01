using System;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;

namespace WpfApplication241 {
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<DateTime> DisabledDates {
            get { return GetValue<ObservableCollection<DateTime>>(); }
            set { SetValue(value); }
        }
        public DateTime MaxDate {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }
        public DateTime MinDate {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }
        public MainViewModel() {
            MaxDate = DateTime.Today;
            MinDate = MaxDate - new TimeSpan(90, 0, 0, 0);
            DisabledDates = new ObservableCollection<DateTime>() {
                DateTime.Today.AddDays(1),
                DateTime.Today.AddDays(2),
                DateTime.Today.AddDays(3),
                DateTime.Today.AddDays(4),
            };
        }
    }
}


