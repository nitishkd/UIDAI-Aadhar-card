Imports System.IO
Public Class Form3
    Dim pass As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myreader As StreamReader = New StreamReader("C:\Users\Nitish\Documents\Visual Studio 2015\Projects\Aadhar_Final\password.txt")
        pass = myreader.ReadLine()
        myreader.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = pass Then
            Form2.Show()
            Me.Close()
        Else
            TextBox1.Clear()
            TextBox2.Clear()
            MessageBox.Show("Incorrect Username or password. Please try again")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class