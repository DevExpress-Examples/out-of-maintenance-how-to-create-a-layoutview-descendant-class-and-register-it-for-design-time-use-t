using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using DevExpress.XtraGrid.Views.Layout;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace MyXtraGrid
{
    public class MyLayoutViewInfo : LayoutViewInfo
    {
        public MyLayoutViewInfo(DevExpress.XtraGrid.Views.Layout.LayoutView view)
            : base(view)
        {
            
        }
    }
}
