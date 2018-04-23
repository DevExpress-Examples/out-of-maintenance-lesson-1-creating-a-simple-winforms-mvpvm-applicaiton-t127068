Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports MyMvpvmApplication.ViewModels
Imports DevExpress.Mvvm.POCO

Namespace MyMvpvmApplication.Views
	Public Partial Class TaskCollectionView
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			viewModelCore = ViewModelSource.Create(Of TaskCollectionViewModel)()
		End Sub
		Private viewModelCore As TaskCollectionViewModel
		Public ReadOnly Property ViewModel() As TaskCollectionViewModel
			Get
				Return viewModelCore
			End Get
		End Property

		Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
			MyBase.OnLoad(e)
			taskBindingSource.DataSource = ViewModel.Tasks
		End Sub
	End Class
End Namespace
