Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExe.Click
        Dim sum As Integer
        sum = 0
        For i As Integer = 1 To 100
            'If i = 50 Then
            '    Continue For
            'End If
            If i >= 80 Then
                Exit For
            End If
            sum += i
        Next
        LabelNumber.Text = sum
        'Dim inputString As String
        'inputString = InputText.Text
        'If inputString = "1" Then
        '    LabelNumber.Text = "5"
        'ElseIf inputString = "2" Then
        '    LabelNumber.Text = "10"
        'Else
        '    LabelNumber.Text = "なし"
        'End If
    End Sub

End Class
