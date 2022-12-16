Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows

Namespace WpfApplication241

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            'DateTime maxDate = DateTime.Today;
            'DateTime minDate = maxDate - new TimeSpan(90, 0, 0, 0);
            'List<DateTime> allDates = Enumerable.Range(0, 1 + 90).Select(offset => minDate.AddDays(offset)).ToList();
            'List<DateTime> weekendDates = allDates.Where(x => x.DayOfWeek == DayOfWeek.Saturday || x.DayOfWeek == DayOfWeek.Sunday).ToList();
            'dateEdit1.MinValue = minDate;
            'dateEdit1.MaxValue = maxDate;
            'dateEdit1.SetValue(DateEdit.TagProperty, weekendDates);
            Dim vm As MyViewModel = New MyViewModel()
            DataContext = vm
        End Sub
    End Class

    Public Class MyViewModel

        Public Property DisabledDates As List(Of Date)

        Public Property MaxDate As Date

        Public Property MinDate As Date

        Public Sub New()
            DisabledDates = New List(Of Date)()
            MaxDate = Date.Today
            MinDate = MaxDate - New TimeSpan(90, 0, 0, 0)
            Dim allDates As List(Of Date) = Enumerable.Range(0, 1 + 90).[Select](Function(offset) MinDate.AddDays(offset)).ToList()
            DisabledDates = allDates.Where(Function(x) x.DayOfWeek = DayOfWeek.Saturday OrElse x.DayOfWeek = DayOfWeek.Sunday).ToList()
        End Sub
    End Class
End Namespace
