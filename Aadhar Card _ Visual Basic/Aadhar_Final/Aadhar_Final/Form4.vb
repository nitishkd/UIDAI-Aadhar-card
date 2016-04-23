Imports System.IO
Public Class Form4

    Dim pass As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myreader As StreamReader = New StreamReader("C:\Users\Nitish\Documents\Visual Studio 2015\Projects\Aadhar_Final\password.txt")
        pass = myreader.ReadLine()
        myreader.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If pass = TextBox1.Text Then
            Dim mywriter As StreamWriter = New StreamWriter("C:\Users\Nitish\Documents\Visual Studio 2015\Projects\Aadhar_Final\password.txt")
            mywriter.WriteLine(TextBox2.Text)
            mywriter.Close()
            MessageBox.Show("Password Changed ")
            Me.Close()

        End If
    End Sub
End Class