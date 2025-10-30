# How to Prevent the Selection While Pressing Right Click in WPF / UWP TreeGrid?

This example illustrates how to prevent the selection while pressing right click in [WPF TreeGrid](https://www.syncfusion.com/wpf-controls/treegrid) and [UWP TreeGrid](https://www.syncfusion.com/uwp-ui-controls/treegrid) (SfTreeGrid).

## For WPF:

You can prevent the selection when right-clicking in TreeGrid by customizing the [SelectionController](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.TreeGrid.SfTreeGrid.html#Syncfusion_UI_Xaml_TreeGrid_SfTreeGrid_SelectionController) and overriding the [ProcessPointerPressed](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.TreeGrid.TreeGridRowSelectionController.html#Syncfusion_UI_Xaml_TreeGrid_TreeGridRowSelectionController_ProcessPointerPressed_System_Windows_Input_MouseButtonEventArgs_Syncfusion_UI_Xaml_ScrollAxis_RowColumnIndex_).

``` csharp
protected override void ProcessPointerPressed(MouseButtonEventArgs args, RowColumnIndex rowColumnIndex)
{
    if (args.ChangedButton == MouseButton.Right)
    {
        args.Handled = true;
    }
    else
        base.ProcessPointerPressed(args, rowColumnIndex);
}
```

## For UWP:

You can prevent the selection when right-clicking in TreeGrid by customizing the [SelectionController](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.TreeGrid.TreeGridRowSelectionController.html) and overriding the [ProcessPointerPressed](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.TreeGrid.TreeGridRowSelectionController.html#Syncfusion_UI_Xaml_TreeGrid_TreeGridRowSelectionController_ProcessPointerPressed_Windows_UI_Xaml_Input_PointerRoutedEventArgs_Syncfusion_UI_Xaml_ScrollAxis_RowColumnIndex_).

``` csharp
protected override void ProcessPointerPressed(PointerRoutedEventArgs args, RowColumnIndex rowColumnIndex)
{
    var properties = args.GetCurrentPoint(TreeGrid).Properties;
    if (properties.IsRightButtonPressed)
    {
        args.Handled = true;
    }
    else
        base.ProcessPointerPressed(args, rowColumnIndex);
}
```