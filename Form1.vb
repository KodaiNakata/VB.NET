Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExe.Click
        Dim inputString As String
        inputString = InputText.Text
        If inputString = "1" Then
            LabelNumber.Text = "5"
        ElseIf inputString = "2" Then
            LabelNumber.Text = "10"
        Else
            LabelNumber.Text = "なし"
        End If
    End Sub
End Class
