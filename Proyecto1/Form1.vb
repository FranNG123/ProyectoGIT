Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Form2.Show()
    End Sub

    Private Sub Btn1_Click_1(sender As Object, e As EventArgs) Handles Btn1.Click
        Close()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Me.Hide()
    End Sub

End Class
