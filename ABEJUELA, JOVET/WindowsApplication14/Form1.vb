Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.LoadCount < 0 Then
            Form2.ShowDialog()

        End If

        Me.Text = My.Settings.Appstat & " : Count = >" &
        My.Settings.LoadCount
        My.Settings.LoadCount -= 1
        My.Settings.Save()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(" ABEJUELA,JOVET M.")

    End Sub
End Class
