<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582188/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E637)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Pivot Grid for WinForms - Create a Custom Summary to Display a Distinct Value Count

This example demonstrates how to count distinct values (the number of orders with equal product quantities) and display the result in the Pivot Grid.

![screenshot](./images/screenshot.png)

| Data Field | Expression |
| --- | --- |
| Count Distinct| ```DistinctCount([OrderID])``` |

Call the [CriteriaOperator.RegisterCustomFunction](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(DevExpress.Data.Filtering.ICustomFunctionOperator)) method to register a custom function in your project (see [MainWindow.xaml.cs](./CS/DXPivotGrid_CustomSummary/MainWindow.xaml.cs#L18)/[MainWindow.xaml.vb](./VB/DXPivotGrid_CustomSummary/MainWindow.xaml.vb#L18)).

## Files to Review

* [Form1.cs](./CS/CustomSummaryDistinctCountExample/Form1.cs) (VB: [Form1.vb](./VB/CustomSummaryDistinctCountExample/Form1.vb))

## Documentation 

* [Summarization](https://docs.devexpress.com/WindowsForms/11728)
* [Pivot Grid Expression Syntax](https://docs.devexpress.com/CoreLibraries/120512)
* [Unbound Fields](https://docs.devexpress.com/WindowsForms/1799)
* [Binding to Excel Data Source](https://docs.devexpress.com/WindowsForms/115529)

## More Examples
* [WPF -  How to Create a Custom Summary Type to Display the Distinct Value Count](https://github.com/DevExpress-Examples/how-to-implement-custom-summary-e2136)
