Imports System
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm

Namespace WpfApplication241

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property DisabledDates As ObservableCollection(Of Date)
            Get
                Return GetValue(Of ObservableCollection(Of Date))()
            End Get

            Set(ByVal value As ObservableCollection(Of Date))
                SetValue(value)
            End Set
        End Property

        Public Property MaxDate As Date
            Get
                Return GetValue(Of Date)()
            End Get

            Set(ByVal value As Date)
                SetValue(value)
            End Set
        End Property

        Public Property MinDate As Date
            Get
                Return GetValue(Of Date)()
            End Get

            Set(ByVal value As Date)
                SetValue(value)
            End Set
        End Property

        Public Sub New()
            MaxDate = Date.Today
            MinDate = MaxDate - New TimeSpan(90, 0, 0, 0)
            DisabledDates = New ObservableCollection(Of Date)() From {Date.Today.AddDays(1), Date.Today.AddDays(2), Date.Today.AddDays(3), Date.Today.AddDays(4)}
        End Sub
    End Class
End Namespace
