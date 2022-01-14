<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUser
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpd = New System.Windows.Forms.Button()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "登録者管理画面"
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(704, 45)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(149, 54)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "詳細"
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(104, 181)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(253, 449)
        Me.DataGridView1.TabIndex = 2
        Me.DataGridView1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(405, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 34)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "氏名："
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtName.Location = New System.Drawing.Point(411, 282)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(430, 41)
        Me.TxtName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(405, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 34)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "メールアドレス："
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtEmail.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtEmail.Location = New System.Drawing.Point(411, 384)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(430, 41)
        Me.TxtEmail.TabIndex = 3
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtPassword.Location = New System.Drawing.Point(411, 496)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(430, 41)
        Me.TxtPassword.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(405, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 34)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "パスワード："
        '
        'btnUpd
        '
        Me.btnUpd.AutoSize = True
        Me.btnUpd.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnUpd.Location = New System.Drawing.Point(603, 576)
        Me.btnUpd.Name = "btnUpd"
        Me.btnUpd.Size = New System.Drawing.Size(149, 54)
        Me.btnUpd.TabIndex = 6
        Me.btnUpd.Text = "更新"
        Me.btnUpd.UseVisualStyleBackColor = True
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtID.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtID.Location = New System.Drawing.Point(414, 181)
        Me.TxtID.MaxLength = 4
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(206, 41)
        Me.TxtID.TabIndex = 1
        '
        'btnIns
        '
        Me.btnIns.AutoSize = True
        Me.btnIns.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIns.Location = New System.Drawing.Point(413, 576)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(149, 54)
        Me.btnIns.TabIndex = 5
        Me.btnIns.Text = "新規登録"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'LblMsg
        '
        Me.LblMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMsg.BackColor = System.Drawing.Color.Crimson
        Me.LblMsg.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblMsg.Location = New System.Drawing.Point(-1, 654)
        Me.LblMsg.Margin = New System.Windows.Forms.Padding(0)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(951, 46)
        Me.LblMsg.TabIndex = 13
        Me.LblMsg.Text = "エラーメッセージも含む"
        Me.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(407, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 34)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "登録ID："
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 144)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 34)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "登録者一覧"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 699)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblMsg)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.btnUpd)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUser"
        Me.Text = "会員登録"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUpd As Button
    Friend WithEvents TxtID As TextBox
    Friend WithEvents btnIns As Button
    Friend WithEvents LblMsg As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
