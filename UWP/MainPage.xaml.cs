﻿using Syncfusion.Data;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Parsing;
using Syncfusion.UI.Xaml.Grid;

using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Key = Windows.System.VirtualKey;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SfTreeGridDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.treeGrid.SelectionController = new GridSelectionControllerExt(this.treeGrid);
        }
    }

    public class GridSelectionControllerExt : TreeGridRowSelectionController
    {
        public GridSelectionControllerExt(SfTreeGrid treeGrid) : base(treeGrid)
        {
        }

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
      
    }

}
