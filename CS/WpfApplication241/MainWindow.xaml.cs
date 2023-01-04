using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApplication241 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    public class MainViewModel : ViewModelBase {
        public ObservableCollection<DateTime> DisabledDates { get; }
        public DateTime MaxDate {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }
        public DateTime MinDate {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }
        public MainViewModel() {
            MinDate = DateTime.Today;
            MaxDate = DateTime.Today.AddDays(14);
            DisabledDates = new ObservableCollection<DateTime> {
                DateTime.Today.AddDays(3),
                DateTime.Today.AddDays(5),
                DateTime.Today.AddDays(7)
            };
        }
    }
}