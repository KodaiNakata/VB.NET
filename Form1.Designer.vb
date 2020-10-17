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
        Me.SuspendLayout()
        '
        'ButtonExe
        '
        Me.ButtonExe.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonExe.Location = New System.Drawing.Point(337, 238)
        Me.ButtonExe.Name = "ButtonExe"
        Me.ButtonExe.Size = New System.Drawing.Size(111, 57)
        Me.ButtonExe.TabIndex = 0
        Me.ButtonExe.Text = "実行"
        Me.ButtonExe.UseVisualStyleBackColor = True
        '
        'LabelAnswer
        '
        Me.LabelAnswer.AutoSize = True
        Me.LabelAnswer.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelAnswer.Location = New System.Drawing.Point(476, 255)
        Me.LabelAnswer.Name = "LabelAnswer"
        Me.LabelAnswer.Size = New System.Drawing.Size(88, 40)
        Me.LabelAnswer.TabIndex = 1
        Me.LabelAnswer.Text = "答え"
        '
        'InputText
        '
        Me.InputText.Location = New System.Drawing.Point(127, 264)
        Me.InputText.Name = "InputText"
        Me.InputText.Size = New System.Drawing.Size(102, 22)
        Me.InputText.TabIndex = 2
        '
        'LabelNumber
        '
        Me.LabelNumber.AutoSize = True
        Me.LabelNumber.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelNumber.Location = New System.Drawing.Point(602, 255)
        Me.LabelNumber.Name = "LabelNumber"
        Me.LabelNumber.Size = New System.Drawing.Size(37, 40)
        Me.LabelNumber.TabIndex = 3
        Me.LabelNumber.Text = "1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
