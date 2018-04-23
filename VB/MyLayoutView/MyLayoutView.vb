Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid

Namespace MyXtraGrid
	Public Class MyLayoutView
		Inherits LayoutView
		Public Sub New()

		End Sub
		Public Sub New(ByVal ownerGrid As DevExpress.XtraGrid.GridControl)
			MyBase.New(ownerGrid)
			' put your initialization code here
		End Sub
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyLayoutView"
			End Get
		End Property
	End Class
End Namespace
