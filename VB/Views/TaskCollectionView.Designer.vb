Imports Microsoft.VisualBasic
Imports System
Namespace MyMvpvmApplication.Views
	Public Partial Class TaskCollectionView
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.taskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.taskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.gridControl1.DataSource = Me.taskBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 26)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(461, 257)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' taskBindingSource
			' 
			Me.taskBindingSource.DataSource = GetType(MyMvpvmApplication.Model.Task)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colSubject, Me.colDescription})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colSubject
			' 
			Me.colSubject.FieldName = "Subject"
			Me.colSubject.Name = "colSubject"
			Me.colSubject.Visible = True
			Me.colSubject.VisibleIndex = 0
			' 
			' colDescription
			' 
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 1
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barButtonItem2})
			Me.barManager1.MaxItemId = 2
			' 
			' bar1
			' 
			Me.bar1.BarName = "Tools"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2)})
			Me.bar1.Text = "Tools"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Add Task"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "Remove Task"
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(461, 26)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 283)
			Me.barDockControlBottom.Size = New System.Drawing.Size(461, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 26)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 257)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(461, 26)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 257)
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light"
			' 
			' TaskCollectionView
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "TaskCollectionView"
			Me.Size = New System.Drawing.Size(461, 283)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.taskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private taskBindingSource As System.Windows.Forms.BindingSource
		Private colSubject As DevExpress.XtraGrid.Columns.GridColumn
		Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace
