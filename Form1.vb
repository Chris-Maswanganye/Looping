Imports System.Reflection

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim counter As Integer
        For counter = 1 To 10
            ListBox1.Items.Add(counter)
        Next
        ListBox1.Items.Add("**************")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim counter, sum As Integer
        sum = 1000
        For counter = 100 To 5 Step -5
            sum -= counter
            ListBox1.Items.Add(sum)
        Next
        ListBox1.Items.Add("**************")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim counter, sum As Integer
        For counter = 1 To 100 Step 10
            sum += counter
            ListBox1.Items.Add(sum)
        Next
        ListBox1.Items.Add("**************")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class
