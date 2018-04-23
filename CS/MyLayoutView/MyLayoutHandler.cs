using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Layout.Handler;
using DevExpress.XtraGrid.Views.Layout;
using System.Windows.Forms;

namespace MyXtraGrid
{
    public class MyLayoutViewHandler : LayoutViewHandler
    {
        public MyLayoutViewHandler(DevExpress.XtraGrid.Views.Layout.LayoutView view)
            : base(view)
        {
            
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyData == Keys.Delete && View.State == LayoutViewState.Normal)
                View.DeleteRow(View.FocusedRowHandle);
        }
    }
}
