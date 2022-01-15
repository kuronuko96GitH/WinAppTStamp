<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReward
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
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtUserID = New System.Windows.Forms.TextBox()
        Me.btnReward = New System.Windows.Forms.Button()
        Me.btnUpd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtRewM = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtRewY = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Chk30min = New System.Windows.Forms.CheckBox()
        Me.ChkBreakTime = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTanka = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblWorkHours = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblReward = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCom = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDel
        '
        Me.btnDel.AutoSize = True
        Me.btnDel.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDel.Location = New System.Drawing.Point(832, 546)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(112, 43)
        Me.btnDel.TabIndex = 105
        Me.btnDel.Text = "削除"
        Me.btnDel.UseVisualStyleBackColor = True
        Me.btnDel.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.Location = New System.Drawing.Point(794, 46)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(139, 27)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "ユーザーID："
        Me.Label18.Visible = False
        '
        'TxtUserID
        '
        Me.TxtUserID.Enabled = False
        Me.TxtUserID.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtUserID.Location = New System.Drawing.Point(937, 40)
        Me.TxtUserID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(64, 34)
        Me.TxtUserID.TabIndex = 103
        Me.TxtUserID.Visible = False
        '
        'btnReward
        '
        Me.btnReward.AutoSize = True
        Me.btnReward.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnReward.Location = New System.Drawing.Point(556, 546)
        Me.btnReward.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReward.Name = "btnReward"
        Me.btnReward.Size = New System.Drawing.Size(112, 43)
        Me.btnReward.TabIndex = 78
        Me.btnReward.Text = "再計算"
        Me.btnReward.UseVisualStyleBackColor = True
        '
        'btnUpd
        '
        Me.btnUpd.AutoSize = True
        Me.btnUpd.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnUpd.Location = New System.Drawing.Point(702, 546)
        Me.btnUpd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpd.Name = "btnUpd"
        Me.btnUpd.Size = New System.Drawing.Size(112, 43)
        Me.btnUpd.TabIndex = 79
        Me.btnUpd.Text = "更新"
        Me.btnUpd.UseVisualStyleBackColor = True
        Me.btnUpd.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(549, 496)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 27)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "報酬金額（予想）："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(794, 5)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 27)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "WorksID："
        Me.Label7.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblName.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblName.Location = New System.Drawing.Point(626, 72)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(127, 27)
        Me.lblName.TabIndex = 86
        Me.lblName.Text = "てすと太郎"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(551, 72)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 27)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "氏名："
        '
        'LblMsg
        '
        Me.LblMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMsg.BackColor = System.Drawing.Color.Crimson
        Me.LblMsg.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblMsg.Location = New System.Drawing.Point(-2, 603)
        Me.LblMsg.Margin = New System.Windows.Forms.Padding(0)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(1046, 37)
        Me.LblMsg.TabIndex = 84
        Me.LblMsg.Text = "エラーメッセージも含む"
        Me.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtID.Location = New System.Drawing.Point(937, 2)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(64, 34)
        Me.txtID.TabIndex = 83
        Me.txtID.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(431, 27)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "打刻実績一覧"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(78, 88)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(431, 501)
        Me.DataGridView1.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1042, 27)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "報酬計算画面（フリーランス版）"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtRewM
        '
        Me.TxtRewM.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtRewM.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtRewM.Location = New System.Drawing.Point(832, 125)
        Me.TxtRewM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtRewM.MaxLength = 2
        Me.TxtRewM.Name = "TxtRewM"
        Me.TxtRewM.Size = New System.Drawing.Size(32, 34)
        Me.TxtRewM.TabIndex = 109
        Me.TxtRewM.Text = "02"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label19.Location = New System.Drawing.Point(862, 127)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 27)
        Me.Label19.TabIndex = 112
        Me.Label19.Text = "月"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label20.Location = New System.Drawing.Point(796, 127)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 27)
        Me.Label20.TabIndex = 111
        Me.Label20.Text = "年"
        '
        'TxtRewY
        '
        Me.TxtRewY.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtRewY.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtRewY.Location = New System.Drawing.Point(733, 125)
        Me.TxtRewY.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtRewY.MaxLength = 4
        Me.TxtRewY.Name = "TxtRewY"
        Me.TxtRewY.Size = New System.Drawing.Size(62, 34)
        Me.TxtRewY.TabIndex = 108
        Me.TxtRewY.Text = "2020"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.Location = New System.Drawing.Point(551, 130)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(188, 27)
        Me.Label21.TabIndex = 110
        Me.Label21.Text = "計算対象年月："
        '
        'Chk30min
        '
        Me.Chk30min.AutoSize = True
        Me.Chk30min.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Chk30min.Location = New System.Drawing.Point(556, 240)
        Me.Chk30min.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Chk30min.Name = "Chk30min"
        Me.Chk30min.Size = New System.Drawing.Size(240, 31)
        Me.Chk30min.TabIndex = 114
        Me.Chk30min.Text = "３０分未満切り捨て"
        Me.Chk30min.UseVisualStyleBackColor = True
        Me.Chk30min.Visible = False
        '
        'ChkBreakTime
        '
        Me.ChkBreakTime.AutoSize = True
        Me.ChkBreakTime.Checked = True
        Me.ChkBreakTime.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkBreakTime.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ChkBreakTime.Location = New System.Drawing.Point(556, 196)
        Me.ChkBreakTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChkBreakTime.Name = "ChkBreakTime"
        Me.ChkBreakTime.Size = New System.Drawing.Size(476, 31)
        Me.ChkBreakTime.TabIndex = 115
        Me.ChkBreakTime.Text = "昼休憩分を、稼働時間から一時間減らす"
        Me.ChkBreakTime.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(553, 293)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 27)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "実労働時間："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(828, 293)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 27)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "時間"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(806, 384)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 27)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "円"
        '
        'TxtTanka
        '
        Me.TxtTanka.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtTanka.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtTanka.Location = New System.Drawing.Point(689, 381)
        Me.TxtTanka.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtTanka.MaxLength = 5
        Me.TxtTanka.Name = "TxtTanka"
        Me.TxtTanka.Size = New System.Drawing.Size(117, 34)
        Me.TxtTanka.TabIndex = 119
        Me.TxtTanka.Text = "2188"
        Me.TxtTanka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(551, 384)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 27)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "時間単価："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(553, 328)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(432, 27)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "（※参考：８時間×２０日＝１６０時間）"
        '
        'lblWorkHours
        '
        Me.lblWorkHours.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblWorkHours.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblWorkHours.Location = New System.Drawing.Point(707, 293)
        Me.lblWorkHours.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWorkHours.Name = "lblWorkHours"
        Me.lblWorkHours.Size = New System.Drawing.Size(116, 27)
        Me.lblWorkHours.TabIndex = 123
        Me.lblWorkHours.Text = "0"
        Me.lblWorkHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(946, 496)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 27)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "円"
        '
        'LblReward
        '
        Me.LblReward.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblReward.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblReward.Location = New System.Drawing.Point(769, 496)
        Me.LblReward.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblReward.Name = "LblReward"
        Me.LblReward.Size = New System.Drawing.Size(173, 27)
        Me.LblReward.TabIndex = 125
        Me.LblReward.Text = "0"
        Me.LblReward.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(846, 441)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 27)
        Me.Label12.TabIndex = 128
        Me.Label12.Text = "％"
        '
        'TxtCom
        '
        Me.TxtCom.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtCom.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtCom.Location = New System.Drawing.Point(774, 438)
        Me.TxtCom.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCom.MaxLength = 3
        Me.TxtCom.Name = "TxtCom"
        Me.TxtCom.Size = New System.Drawing.Size(71, 34)
        Me.TxtCom.TabIndex = 126
        Me.TxtCom.Text = "20"
        Me.TxtCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(553, 441)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(226, 27)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "エージェント紹介料："
        '
        'FormReward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 643)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtCom)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LblReward)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblWorkHours)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTanka)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChkBreakTime)
        Me.Controls.Add(Me.Chk30min)
        Me.Controls.Add(Me.TxtRewM)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TxtRewY)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtUserID)
        Me.Controls.Add(Me.btnReward)
        Me.Controls.Add(Me.btnUpd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblMsg)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormReward"
        Me.Text = "報酬計算画面"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDel As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtUserID As TextBox
    Friend WithEvents btnReward As Button
    Friend WithEvents btnUpd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblMsg As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRewM As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtRewY As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Chk30min As CheckBox
    Friend WithEvents ChkBreakTime As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTanka As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblWorkHours As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblReward As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtCom As TextBox
    Friend WithEvents Label13 As Label
End Class
