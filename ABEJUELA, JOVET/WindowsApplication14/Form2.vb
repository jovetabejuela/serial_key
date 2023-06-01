Imports System.ComponentModel

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '121198
        If My.Settings.Serialkey = TextBox1.Text Then
            My.Settings.Appstat = " Full Version"
            My.Settings.Save()
            Close()
        Else
            MsgBox(" Invalid Serial Key")
        End If

    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End

    End Sub
End Class