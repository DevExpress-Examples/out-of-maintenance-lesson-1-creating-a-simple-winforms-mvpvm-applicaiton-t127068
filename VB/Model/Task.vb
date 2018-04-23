Imports Microsoft.VisualBasic
Imports System
Namespace MyMvpvmApplication.Model
    Public Class Task
        Public Property Subject() As String
            Get
                Return m_Subject
            End Get
            Set(value As String)
                m_Subject = Value
            End Set
        End Property
        Private m_Subject As String
        Public Property Description() As String
            Get
                Return m_Description
            End Get
            Set(value As String)
                m_Description = Value
            End Set
        End Property
        Private m_Description As String
    End Class
End Namespace
