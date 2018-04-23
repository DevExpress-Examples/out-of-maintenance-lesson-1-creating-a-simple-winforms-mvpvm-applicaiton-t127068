Imports Microsoft.VisualBasic
Imports System
Namespace MyMvpvmApplication
	Public Partial Class MainForm
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.taskCollectionView1 = New MyMvpvmApplication.Views.TaskCollectionView()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light"
			' 
			' taskCollectionView1
			' 
			Me.taskCollectionView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.taskCollectionView1.Location = New System.Drawing.Point(0, 0)
			Me.taskCollectionView1.Name = "taskCollectionView1"
			Me.taskCollectionView1.Size = New System.Drawing.Size(581, 368)
			Me.taskCollectionView1.TabIndex = 0
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(581, 368)
			Me.Controls.Add(Me.taskCollectionView1)
			Me.Name = "MainForm"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private taskCollectionView1 As Views.TaskCollectionView
	End Class
End Namespace

