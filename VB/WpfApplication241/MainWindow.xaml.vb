Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Windows
Imports DevExpress.Mvvm

Namespace WpfApplication241
    Partial Public Class MainWindow
        Inherits Window
        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class MainViewModel
        Inherits ViewModelBase

        Public ReadOnly Property DisabledDates As ObservableCollection(Of Date)

        Public Property MaxDate As Date
            Get
                Return GetValue(Of DateTime)()
            End Get
            Set(value As Date)
                SetValue(value)
            End Set
        End Property

        Public Property MinDate As Date
            Get
                Return GetValue(Of DateTime)()
            End Get
            Set(value As Date)
                SetValue(value)
            End Set
        End Property

        Public Sub New()
            MinDate = DateTime.Today
            MaxDate = DateTime.Today.AddDays(14)
            DisabledDates = New ObservableCollection(Of DateTime)
            DisabledDates.Add(DateTime.Today.AddDays(3))
            DisabledDates.Add(DateTime.Today.AddDays(5))
            DisabledDates.Add(DateTime.Today.AddDays(7))
        End Sub
    End Class
End Namespace
