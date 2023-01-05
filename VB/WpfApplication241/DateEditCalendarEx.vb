Imports DevExpress.Xpf.Editors.Popups.Calendar
Imports System.Windows
Imports System.Windows.Controls

Namespace WpfApplication241

    Public Class DateEditCalendarEx
        Inherits DateEditCalendar

        Protected Overrides Sub OnCellButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim button = TryCast(sender, Button)
            If button.IsEnabled Then
                MyBase.OnCellButtonClick(sender, e)
            End If
        End Sub
    End Class
End Namespace
