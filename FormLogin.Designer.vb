<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.TxtAdminCode = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.AutoSize = True
        Me.btnLogin.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(334, 364)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(149, 54)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "ログイン"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtPassword.Location = New System.Drawing.Point(194, 255)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(430, 41)
        Me.TxtPassword.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(188, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 34)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "パスワード："
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtID.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtID.Location = New System.Drawing.Point(194, 150)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(430, 41)
        Me.TxtID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 34)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "会員登録ID："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, -42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 34)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "登録者管理画面"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(879, 34)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "ログイン画面"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMsg
        '
        Me.LblMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMsg.BackColor = System.Drawing.Color.Crimson
        Me.LblMsg.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblMsg.Location = New System.Drawing.Point(-2, 461)
        Me.LblMsg.Margin = New System.Windows.Forms.Padding(0)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(885, 46)
        Me.LblMsg.TabIndex = 28
        Me.LblMsg.Text = "エラーメッセージも含む"
        Me.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtAdminCode
        '
        Me.TxtAdminCode.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtAdminCode.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtAdminCode.Location = New System.Drawing.Point(724, 369)
        Me.TxtAdminCode.Name = "TxtAdminCode"
        Me.TxtAdminCode.Size = New System.Drawing.Size(159, 41)
        Me.TxtAdminCode.TabIndex = 29
        Me.TxtAdminCode.Visible = False
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtName.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtName.Location = New System.Drawing.Point(724, 416)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(159, 41)
        Me.TxtName.TabIndex = 30
        Me.TxtName.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(672, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 34)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "管理者コード："
        Me.Label4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(618, 416)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 34)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "氏名："
        Me.Label6.Visible = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 504)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtAdminCode)
        Me.Controls.Add(Me.LblMsg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLogin"
        Me.Text = "ログイン画面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblMsg As Label
    Friend WithEvents TxtAdminCode As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
