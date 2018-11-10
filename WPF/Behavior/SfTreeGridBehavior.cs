using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interactivity;

namespace SelectionDemo
{
    class SfTreeGridBehavior:Behavior<SfTreeGrid>
    {
        SfTreeGrid treegrid = null;
        protected override void OnAttached()
        {
            treegrid = this.AssociatedObject as SfTreeGrid;
            this.treegrid.SelectionController = new GridSelectionControllerExt(treegrid);
            base.OnAttached();
        }

    }
}
