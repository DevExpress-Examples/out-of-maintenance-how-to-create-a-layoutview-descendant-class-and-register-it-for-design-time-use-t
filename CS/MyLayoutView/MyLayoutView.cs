using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid;

namespace MyXtraGrid
{
    public class MyLayoutView : LayoutView
    {
        public MyLayoutView()
        {
            
        }
        public MyLayoutView(DevExpress.XtraGrid.GridControl ownerGrid)
            : base(ownerGrid)
        {
            // put your initialization code here
        }
        protected override string ViewName { get { return "MyLayoutView"; } }
    }
}
