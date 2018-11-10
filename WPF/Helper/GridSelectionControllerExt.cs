using Syncfusion.UI.Xaml.TreeGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.UI.Xaml.ScrollAxis;
using System.Windows.Input;

namespace SelectionDemo
{
    class GridSelectionControllerExt:TreeGridRowSelectionController
    {
        public GridSelectionControllerExt(SfTreeGrid treeGrid) : base(treeGrid)
        {

        }

        protected override void ProcessPointerPressed(MouseButtonEventArgs args, RowColumnIndex rowColumnIndex)
        {
            if (args.ChangedButton == MouseButton.Right)
            {
                args.Handled = true;
            }
            else
                base.ProcessPointerPressed(args, rowColumnIndex);
        }

    }
}
