<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonAnswer = New System.Windows.Forms.Button()
        Me.LabelQuestion = New System.Windows.Forms.Label()
        Me.InputText = New System.Windows.Forms.TextBox()
        Me.LabelCorrectAnswer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelQuestionNo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonBeforeQ = New System.Windows.Forms.Button()
        Me.ButtonNextQ = New System.Windows.Forms.Button()
        Me.LabelCorrect = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonAnswer
        '
        Me.ButtonAnswer.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonAnswer.Location = New System.Drawing.Point(134, 225)
        Me.ButtonAnswer.Name = "ButtonAnswer"
        Me.ButtonAnswer.Size = New System.Drawing.Size(111, 57)
        Me.ButtonAnswer.TabIndex = 0
        Me.ButtonAnswer.Text = "答え"
        Me.ButtonAnswer.UseVisualStyleBackColor = True
        '
        'LabelQuestion
        '
        Me.LabelQuestion.AutoSize = True
        Me.LabelQuestion.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelQuestion.Location = New System.Drawing.Point(141, 140)
        Me.LabelQuestion.Name = "LabelQuestion"
        Me.LabelQuestion.Size = New System.Drawing.Size(101, 40)
        Me.LabelQuestion.TabIndex = 1
        Me.LabelQuestion.Text = "リンゴ"
        '
        'InputText
        '
        Me.InputText.Location = New System.Drawing.Point(339, 145)
        Me.InputText.Multiline = True
        Me.InputText.Name = "InputText"
        Me.InputText.Size = New System.Drawing.Size(300, 35)
        Me.InputText.TabIndex = 2
        '
        'LabelCorrectAnswer
        '
        Me.LabelCorrectAnswer.AutoSize = True
        Me.LabelCorrectAnswer.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelCorrectAnswer.Location = New System.Drawing.Point(388, 242)
        Me.LabelCorrectAnswer.Name = "LabelCorrectAnswer"
        Me.LabelCorrectAnswer.Size = New System.Drawing.Size(37, 40)
        Me.LabelCorrectAnswer.TabIndex = 3
        Me.LabelCorrectAnswer.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "第"
        '
        'LabelQuestionNo
        '
        Me.LabelQuestionNo.AutoSize = True
        Me.LabelQuestionNo.Font = New System.Drawing.Font("MS UI Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelQuestionNo.Location = New System.Drawing.Point(173, 59)
        Me.LabelQuestionNo.Name = "LabelQuestionNo"
        Me.LabelQuestionNo.Size = New System.Drawing.Size(26, 28)
        Me.LabelQuestionNo.TabIndex = 5
        Me.LabelQuestionNo.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(205, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "問"
        '
        'ButtonBeforeQ
        '
        Me.ButtonBeforeQ.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonBeforeQ.Location = New System.Drawing.Point(115, 335)
        Me.ButtonBeforeQ.Name = "ButtonBeforeQ"
        Me.ButtonBeforeQ.Size = New System.Drawing.Size(252, 57)
        Me.ButtonBeforeQ.TabIndex = 7
        Me.ButtonBeforeQ.Text = "前の問題"
        Me.ButtonBeforeQ.UseVisualStyleBackColor = True
        '
        'ButtonNextQ
        '
        Me.ButtonNextQ.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonNextQ.Location = New System.Drawing.Point(467, 335)
        Me.ButtonNextQ.Name = "ButtonNextQ"
        Me.ButtonNextQ.Size = New System.Drawing.Size(257, 57)
        Me.ButtonNextQ.TabIndex = 8
        Me.ButtonNextQ.Text = "次の問題"
        Me.ButtonNextQ.UseVisualStyleBackColor = True
        '
        'LabelCorrect
        '
        Me.LabelCorrect.AutoSize = True
        Me.LabelCorrect.Font = New System.Drawing.Font("MS UI Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelCorrect.Location = New System.Drawing.Point(523, 234)
        Me.LabelCorrect.Name = "LabelCorrect"
        Me.LabelCorrect.Size = New System.Drawing.Size(68, 48)
        Me.LabelCorrect.TabIndex = 9
        Me.LabelCorrect.Text = "〇"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelCorrect)
        Me.Controls.Add(Me.ButtonNextQ)
        Me.Controls.Add(Me.ButtonBeforeQ)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelQuestionNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelCorrectAnswer)
        Me.Controls.Add(Me.InputText)
        Me.Controls.Add(Me.LabelQuestion)
        Me.Controls.Add(Me.ButtonAnswer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAnswer As Button
    Friend WithEvents LabelQuestion As Label
    Friend WithEvents InputText As TextBox
    Friend WithEvents LabelCorrectAnswer As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelQuestionNo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonBeforeQ As Button
    Friend WithEvents ButtonNextQ As Button
    Friend WithEvents LabelCorrect As Label
End Class
