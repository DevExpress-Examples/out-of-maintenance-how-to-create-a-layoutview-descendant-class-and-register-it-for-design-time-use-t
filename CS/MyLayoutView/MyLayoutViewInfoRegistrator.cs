using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace MyXtraGrid
{
    public class MyLayoutViewInfoRegistrator : LayoutViewInfoRegistrator
    {
        public override string ViewName { get { return "MyLayoutView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyLayoutView(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new MyLayoutViewInfo(view as MyLayoutView); }
        public override BaseViewHandler CreateHandler(BaseView view) { return new MyLayoutViewHandler(view as MyLayoutView); }
    }
}
