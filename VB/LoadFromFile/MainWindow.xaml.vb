Imports System.Windows

Namespace LoadFromFile

    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Viewer.OpenDocument("..\..\Demo.pdf")
        End Sub
    End Class
End Namespace
