using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;

namespace WpfApplication241 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            //DateTime maxDate = DateTime.Today;
            //DateTime minDate = maxDate - new TimeSpan(90, 0, 0, 0);
            //List<DateTime> allDates = Enumerable.Range(0, 1 + 90).Select(offset => minDate.AddDays(offset)).ToList();
            //List<DateTime> weekendDates = allDates.Where(x => x.DayOfWeek == DayOfWeek.Saturday || x.DayOfWeek == DayOfWeek.Sunday).ToList();
            //dateEdit1.MinValue = minDate;
            //dateEdit1.MaxValue = maxDate;
            //dateEdit1.SetValue(DateEdit.TagProperty, weekendDates);
            MyViewModel vm = new MyViewModel();
            DataContext = vm;
        }
    }

    public class MyViewModel {
        public List<DateTime> DisabledDates { get; set; }
        public DateTime MaxDate { get; set; }
        public DateTime MinDate { get; set; }
        public MyViewModel() {
            DisabledDates = new List<DateTime>();
            MaxDate = DateTime.Today;
            MinDate = MaxDate - new TimeSpan(90, 0, 0, 0);
            List<DateTime> allDates = Enumerable.Range(0, 1 + 90).Select(offset => MinDate.AddDays(offset)).ToList();
            DisabledDates = allDates.Where(x => x.DayOfWeek == DayOfWeek.Saturday || x.DayOfWeek == DayOfWeek.Sunday).ToList();


        }
    }
}
   

