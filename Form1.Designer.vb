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
        Me.ButtonExe = New System.Windows.Forms.Button()
        Me.LabelAnswer = New System.Windows.Forms.Label()
        Me.InputText = New System.Windows.Forms.TextBox()
        Me.LabelNumber = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonExe
        '
        Me.ButtonExe.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonExe.Location = New System.Drawing.Point(134, 225)
        Me.ButtonExe.Name = "ButtonExe"
        Me.ButtonExe.Size = New System.Drawing.Size(111, 57)
        Me.ButtonExe.TabIndex = 0
        Me.ButtonExe.Text = "答え"
        Me.ButtonExe.UseVisualStyleBackColor = True
        '
        'LabelAnswer
        '
        Me.LabelAnswer.AutoSize = True
        Me.LabelAnswer.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelAnswer.Location = New System.Drawing.Point(141, 140)
        Me.LabelAnswer.Name = "LabelAnswer"
        Me.LabelAnswer.Size = New System.Drawing.Size(101, 40)
        Me.LabelAnswer.TabIndex = 1
        Me.LabelAnswer.Text = "リンゴ"
        '
        'InputText
        '
        Me.InputText.Location = New System.Drawing.Point(339, 145)
        Me.InputText.Multiline = True
        Me.InputText.Name = "InputText"
        Me.InputText.Size = New System.Drawing.Size(300, 35)
        Me.InputText.TabIndex = 2
        '
        'LabelNumber
        '
        Me.LabelNumber.AutoSize = True
        Me.LabelNumber.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelNumber.Location = New System.Drawing.Point(480, 242)
        Me.LabelNumber.Name = "LabelNumber"
        Me.LabelNumber.Size = New System.Drawing.Size(37, 40)
        Me.LabelNumber.TabIndex = 3
        Me.LabelNumber.Text = "1"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "1"
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(115, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 57)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "前の問題"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(467, 335)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(257, 57)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "次の問題"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelNumber)
        Me.Controls.Add(Me.InputText)
        Me.Controls.Add(Me.LabelAnswer)
        Me.Controls.Add(Me.ButtonExe)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonExe As Button
    Friend WithEvents LabelAnswer As Label
    Friend WithEvents InputText As TextBox
    Friend WithEvents LabelNumber As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
