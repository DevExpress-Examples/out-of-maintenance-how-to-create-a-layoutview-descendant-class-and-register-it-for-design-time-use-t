Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid.Views.Layout.Handler
Imports DevExpress.XtraGrid.Views.Layout
Imports System.Windows.Forms

Namespace MyXtraGrid
	Public Class MyLayoutViewHandler
		Inherits LayoutViewHandler
		Public Sub New(ByVal view As DevExpress.XtraGrid.Views.Layout.LayoutView)
			MyBase.New(view)

		End Sub
		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			MyBase.OnKeyDown(e)
			If e.KeyData = Keys.Delete AndAlso View.State = LayoutViewState.Normal Then
				View.DeleteRow(View.FocusedRowHandle)
			End If
		End Sub
	End Class
End Namespace
