Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace MyXtraGrid
	Public Class MyLayoutViewInfo
		Inherits LayoutViewInfo
		Public Sub New(ByVal view As DevExpress.XtraGrid.Views.Layout.LayoutView)
			MyBase.New(view)

		End Sub
	End Class
End Namespace
