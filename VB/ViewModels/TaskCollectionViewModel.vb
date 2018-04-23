Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports MyMvpvmApplication.Model
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace MyMvpvmApplication.ViewModels
	Public Class TaskCollectionViewModel
		Private tasksCore As IList(Of Task)

        Public Sub New()
            tasksCore = New BindingList(Of Task)() From { _
                New Task() With { _
                    .Subject = "Test Task", _
                    .Description = "Test Description" _
                } _
            }
        End Sub
		Public ReadOnly Property Tasks() As IList(Of Task)
			Get
				Return tasksCore
			End Get
		End Property
	End Class
End Namespace
