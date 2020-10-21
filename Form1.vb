Public Class Form1

    Private japanese As String()
    Private english As String()
    Private questionNo As Integer

    'ロード関数
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        japanese = {"リンゴ", "学校", "鉛筆", "机", "鞄", "本", "部屋", "コップ", "椅子", "頭"}
        english = {"apple", "school", "pencil", "desk", "bag", "book", "room", "cup", "chair", "head"}
        questionNo = 1
        CreateQuestion(questionNo)
        LabelQuestionNo.Text = questionNo
        LabelQuestion.Text = japanese(0)
        InputText.Text = ""
        LabelCorrectAnswer.Text = ""
        LabelCorrect.Text = ""
        ButtonBeforeQ.Enabled = False
    End Sub

    '答えボタンクリック時の処理
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAnswer.Click
        Dim answer As String = InputText.Text
        LabelCorrectAnswer.Text = english(questionNo - 1)

        If answer.Equals(english(questionNo - 1)) Then
            LabelCorrect.Text = "〇"
            LabelCorrect.ForeColor = Color.Red
        Else
            LabelCorrect.Text = "×"
            LabelCorrect.ForeColor = Color.Blue
        End If
        'Dim sum As Integer
        'sum = 0
        'For i As Integer = 1 To 100
        '    'If i = 50 Then
        '    '    Continue For
        '    'End If
        '    If i >= 80 Then
        '        Exit For
        '    End If
        '    sum += i
        'Next
        'LabelNumber.Text = sum
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

    '前の問題のボタンクリック時の処理
    Private Sub ButtonBeforeQ_Click(sender As Object, e As EventArgs) Handles ButtonBeforeQ.Click
        questionNo -= 1
        CreateQuestion(questionNo)
    End Sub

    '次の問題のボタンクリック時の処理
    Private Sub ButtonNextQ_Click(sender As Object, e As EventArgs) Handles ButtonNextQ.Click
        questionNo += 1
        CreateQuestion(questionNo)
    End Sub

    '問題作成処理
    Private Sub CreateQuestion(num As Integer)
        LabelQuestionNo.Text = num
        LabelQuestion.Text = japanese(num - 1)
        InputText.Text = ""
        LabelCorrectAnswer.Text = ""
        LabelCorrect.Text = ""

        If num <= 1 Then '最初の問題の時は
            ButtonBeforeQ.Enabled = False '前の問題ボタンを無効
        ElseIf num >= 10 Then '最後の問題の時は
            ButtonNextQ.Enabled = False '次の問題ボタンを無効
        Else
            ButtonBeforeQ.Enabled = True '前の問題ボタンを有効
            ButtonNextQ.Enabled = True '次の問題ボタンを有効
        End If
    End Sub
End Class
