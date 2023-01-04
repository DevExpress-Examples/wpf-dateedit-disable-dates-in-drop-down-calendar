Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel
Imports System.Windows

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
            MinDate = Date.Today
            MaxDate = Date.Today.AddDays(14)
            DisabledDates = New ObservableCollection(Of Date) From {Date.Today.AddDays(3), Date.Today.AddDays(5), Date.Today.AddDays(7)}
        End Sub
    End Class
End Namespace