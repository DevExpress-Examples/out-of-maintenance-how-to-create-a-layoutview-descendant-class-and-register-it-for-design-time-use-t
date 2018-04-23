Imports Microsoft.VisualBasic
Imports System
Namespace MyXtraGrid
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.myGridControl1 = New MyGridControl()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.myLayoutView1 = New MyLayoutView()
			Me.colColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			' 
			' myGridControl1
			' 
			Me.myGridControl1.DataSource = Me.bindingSource1
			Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myGridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
			Me.myGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.myGridControl1.MainView = Me.myLayoutView1
			Me.myGridControl1.Name = "myGridControl1"
			Me.myGridControl1.Size = New System.Drawing.Size(437, 306)
			Me.myGridControl1.TabIndex = 1
			Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myLayoutView1})
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Table1"
			Me.bindingSource1.DataSource = Me.dataSet1
			' 
			' myLayoutView1
			' 
			Me.myLayoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colColumn1})
			Me.myLayoutView1.GridControl = Me.myGridControl1
			Me.myLayoutView1.Name = "myLayoutView1"
			Me.myLayoutView1.TemplateCard = Me.layoutViewCard1
			' 
			' colColumn1
			' 
			Me.colColumn1.Caption = "Column1"
			Me.colColumn1.FieldName = "Column1"
			Me.colColumn1.LayoutViewField = Me.layoutViewField_colColumn1
			Me.colColumn1.Name = "colColumn1"
			' 
			' layoutViewField_colColumn1
			' 
			Me.layoutViewField_colColumn1.EditorPreferredWidth = 150
			Me.layoutViewField_colColumn1.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colColumn1.Name = "layoutViewField_colColumn1"
			Me.layoutViewField_colColumn1.Size = New System.Drawing.Size(200, 26)
			Me.layoutViewField_colColumn1.TextSize = New System.Drawing.Size(45, 13)
			Me.layoutViewField_colColumn1.TextToControlDistance = 5
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colColumn1})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(437, 306)
			Me.Controls.Add(Me.myGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colColumn1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
#End Region
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private myGridControl1 As MyGridControl
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private myLayoutView1 As MyLayoutView
		Private colColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
	End Class
End Namespace

