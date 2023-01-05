<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128644715/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T237950)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF DateEdit - Disable Dates in the Drop-down Calendar

This example prevents users from selecting specific dates in the [DateEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateEdit)'s drop-down calendar. The [DateEdit.MinValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateEdit.MinValue) and [DateEdit.MaxValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateEdit.MaxValue) properties allow you to specify the available date range.

![image](https://user-images.githubusercontent.com/65009440/210504092-67f8906c-3fe6-4b06-82a9-e8040d87c3c4.png)

Follow the steps below to disable specific dates in the popup:

1. Create a `ControlTemplate` for the `DateEdit`'s popup. The popup's default content is the [DateNavigator](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateNavigator.DateNavigator) control.
2. Bind the [DateNavigator.DisabledDates](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateNavigator.DateNavigator.DisabledDates) property to a collection of disabled dates:

   ```xaml
   <dxe:DateNavigator DisabledDates="{Binding RelativeSource={RelativeSource Self}, 
                                              Path=(dxe:PopupBaseEdit.PopupOwnerEdit).DataContext.DisabledDates}" ... />
   ```
   
   The `dxe:PopupBaseEdit.PopupOwnerEdit` attached property returns the `DateEdit`. The editor's `DataContext` is the **MainViewModel** class that contains the **DisabledDates** collection. Modify this binding if your **DisabledDates** collection is not located in the `DateEdit`'s `DataContext`.

3. Assign this template to the `DateEdit`'s [PopupContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate) property.

## Files to Review

* [MainWindow.xaml](./CS/WpfApplication241/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication241/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication241/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication241/MainWindow.xaml.vb))

## Documentation

* [DateEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateEdit)
* [DateEdit.MaxValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateEdit.MaxValue)
* [DateEdit.MinValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateEdit.MinValue)
* [PopupBaseEdit.PopupContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate)
* [DateNavigator.DisabledDates](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateNavigator.DateNavigator.DisabledDates)

## More Examples

* [How to highlight certain dates in DateEdit](https://github.com/DevExpress-Examples/how-to-make-dateedit-highlight-certain-dates-like-in-datenavigator-e4231)
* [WPF LookUpEdit - Customize the Embedded Data Grid](https://github.com/DevExpress-Examples/wpf-lookupedit-customize-the-embedded-data-grid)
