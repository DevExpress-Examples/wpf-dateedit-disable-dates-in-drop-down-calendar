Imports DevExpress.Xpf.Editors.Popups.Calendar
Imports System
Imports System.Collections.Generic
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Markup

Namespace WpfApplication241
	Public Class CellEnabledConverter
		Inherits MarkupExtension
		Implements IMultiValueConverter

		Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
			Dim disabledDates As List(Of DateTime) = TryCast(values(0), List(Of DateTime))
			Dim cellButton As Button = DirectCast(values(1), Button)
			Dim dt As DateTime = CDate(DateEditCalendar.GetDateTime(cellButton))
			If disabledDates IsNot Nothing Then
				Return disabledDates.Contains(dt)
			Else
				Return False
			End If
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function

		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function
	End Class
End Namespace
