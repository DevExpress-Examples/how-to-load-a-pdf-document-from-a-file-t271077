Imports System.Windows

Namespace LoadFromFile

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.Viewer.OpenDocument("..\..\Demo.pdf")
        End Sub
    End Class
End Namespace
