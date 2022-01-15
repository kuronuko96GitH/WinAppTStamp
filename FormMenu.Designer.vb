<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.BtnTStamp = New System.Windows.Forms.Button()
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblLoginID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.BtnReward = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnTStamp
        '
        Me.BtnTStamp.AutoSize = True
        Me.BtnTStamp.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnTStamp.Location = New System.Drawing.Point(67, 233)
        Me.BtnTStamp.Name = "BtnTStamp"
        Me.BtnTStamp.Size = New System.Drawing.Size(192, 54)
        Me.BtnTStamp.TabIndex = 15
        Me.BtnTStamp.Text = "打刻登録"
        Me.BtnTStamp.UseVisualStyleBackColor = True
        '
        'BtnUser
        '
        Me.BtnUser.AutoSize = True
        Me.BtnUser.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnUser.Location = New System.Drawing.Point(67, 157)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(192, 54)
        Me.BtnUser.TabIndex = 16
        Me.BtnUser.Text = "会員登録"
        Me.BtnUser.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(596, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 54)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "ログイン"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lblLoginID
        '
        Me.lblLoginID.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblLoginID.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblLoginID.Location = New System.Drawing.Point(363, 41)
        Me.lblLoginID.Name = "lblLoginID"
        Me.lblLoginID.Size = New System.Drawing.Size(198, 34)
        Me.lblLoginID.TabIndex = 18
        Me.lblLoginID.Text = "9999"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 34)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "会員登録ID："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 34)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "氏名："
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblName.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblName.Location = New System.Drawing.Point(256, 84)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(339, 34)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "やまだたろう"
        '
        'BtnReward
        '
        Me.BtnReward.AutoSize = True
        Me.BtnReward.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnReward.Location = New System.Drawing.Point(67, 307)
        Me.BtnReward.Name = "BtnReward"
        Me.BtnReward.Size = New System.Drawing.Size(192, 54)
        Me.BtnReward.TabIndex = 22
        Me.BtnReward.Text = "報酬計算"
        Me.BtnReward.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnReward)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLoginID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnUser)
        Me.Controls.Add(Me.BtnTStamp)
        Me.Name = "FormMenu"
        Me.Text = "メニュー画面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTStamp As Button
    Friend WithEvents BtnUser As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblLoginID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents BtnReward As Button
End Class
