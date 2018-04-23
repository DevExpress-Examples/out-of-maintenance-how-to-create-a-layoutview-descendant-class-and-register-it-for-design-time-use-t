Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Views.Base.ViewInfo

Namespace MyXtraGrid
	Public Class MyLayoutViewInfoRegistrator
		Inherits LayoutViewInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyLayoutView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyLayoutView(TryCast(grid, GridControl))
		End Function
		Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
			Return New MyLayoutViewInfo(TryCast(view, MyLayoutView))
		End Function
		Public Overrides Function CreateHandler(ByVal view As BaseView) As BaseViewHandler
			Return New MyLayoutViewHandler(TryCast(view, MyLayoutView))
		End Function
	End Class
End Namespace
