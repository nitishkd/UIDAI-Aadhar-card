Imports System.IO

Public Class Form5
    Dim previousid As String
    Dim currentid As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(AadharDataSet.Table1)
        currentid = currentid + 1
        Dim mywriter As StreamWriter = New StreamWriter("C:\Users\Nitish\Documents\Visual Studio 2015\Projects\Aadhar_Final\CurrentID.txt")
        mywriter.WriteLine(currentid)
        mywriter.Close()
        MessageBox.Show("Entry Added . Please NOTE Down Your Aadhar ID for next Stage")
        MessageBox.Show("Your Aadhar ID is : " & currentid)
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AadharDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.AadharDataSet.Table1)
        Table1BindingSource.AddNew()
        Dim myreader As StreamReader = New StreamReader("C:\Users\Nitish\Documents\Visual Studio 2015\Projects\Aadhar_Final\CurrentID.txt")
        previousid = myreader.ReadLine()
        myreader.Close()
        currentid = Integer.Parse(previousid)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()

        Me.Close()

    End Sub
End Class