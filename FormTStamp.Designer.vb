<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTStamp
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
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.btnUpd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtStartY = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtWork = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtStart = New System.Windows.Forms.TextBox()
        Me.TxtEnd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtStartD = New System.Windows.Forms.TextBox()
        Me.TxtStartM = New System.Windows.Forms.TextBox()
        Me.TxtStartTimeH = New System.Windows.Forms.TextBox()
        Me.TxtStartTimeM = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtEndTimeH = New System.Windows.Forms.TextBox()
        Me.TxtEndTimeM = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtEndM = New System.Windows.Forms.TextBox()
        Me.TxtEndD = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtEndY = New System.Windows.Forms.TextBox()
        Me.TxtUserID = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.DateTimePickerS = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerE = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblMsg
        '
        Me.LblMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMsg.BackColor = System.Drawing.Color.Crimson
        Me.LblMsg.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblMsg.Location = New System.Drawing.Point(-1, 539)
        Me.LblMsg.Margin = New System.Windows.Forms.Padding(0)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(1028, 37)
        Me.LblMsg.TabIndex = 27
        Me.LblMsg.Text = "エラーメッセージも含む"
        Me.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtID.Location = New System.Drawing.Point(931, 6)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(64, 34)
        Me.txtID.TabIndex = 25
        Me.txtID.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(431, 27)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "打刻一覧"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(80, 138)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(431, 376)
        Me.DataGridView1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1011, 27)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "勤怠管理（打刻）画面"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(553, 109)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 27)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "氏名："
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblName.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblName.Location = New System.Drawing.Point(628, 109)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(127, 27)
        Me.lblName.TabIndex = 29
        Me.lblName.Text = "てすと太郎"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(796, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 27)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "WorksID："
        Me.Label7.Visible = False
        '
        'btnIns
        '
        Me.btnIns.AutoSize = True
        Me.btnIns.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIns.Location = New System.Drawing.Point(557, 471)
        Me.btnIns.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(112, 43)
        Me.btnIns.TabIndex = 12
        Me.btnIns.Text = "新規登録"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'btnUpd
        '
        Me.btnUpd.AutoSize = True
        Me.btnUpd.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnUpd.Location = New System.Drawing.Point(704, 471)
        Me.btnUpd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpd.Name = "btnUpd"
        Me.btnUpd.Size = New System.Drawing.Size(112, 43)
        Me.btnUpd.TabIndex = 13
        Me.btnUpd.Text = "更新"
        Me.btnUpd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(551, 378)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 27)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "終了日時："
        '
        'TxtStartY
        '
        Me.TxtStartY.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtStartY.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtStartY.Location = New System.Drawing.Point(557, 305)
        Me.TxtStartY.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtStartY.MaxLength = 4
        Me.TxtStartY.Name = "TxtStartY"
        Me.TxtStartY.Size = New System.Drawing.Size(62, 34)
        Me.TxtStartY.TabIndex = 2
        Me.TxtStartY.Text = "2022"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(551, 264)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 27)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "開始日時："
        '
        'TxtWork
        '
        Me.TxtWork.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtWork.Location = New System.Drawing.Point(556, 194)
        Me.TxtWork.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtWork.MaxLength = 255
        Me.TxtWork.Name = "TxtWork"
        Me.TxtWork.Size = New System.Drawing.Size(391, 34)
        Me.TxtWork.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(551, 164)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 27)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "勤務内容："
        '
        'TxtStart
        '
        Me.TxtStart.Enabled = False
        Me.TxtStart.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtStart.Location = New System.Drawing.Point(668, 222)
        Me.TxtStart.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtStart.Name = "TxtStart"
        Me.TxtStart.Size = New System.Drawing.Size(260, 34)
        Me.TxtStart.TabIndex = 39
        Me.TxtStart.Visible = False
        '
        'TxtEnd
        '
        Me.TxtEnd.Enabled = False
        Me.TxtEnd.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtEnd.Location = New System.Drawing.Point(673, 354)
        Me.TxtEnd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtEnd.Name = "TxtEnd"
        Me.TxtEnd.Size = New System.Drawing.Size(260, 34)
        Me.TxtEnd.TabIndex = 40
        Me.TxtEnd.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(620, 307)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 27)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "年"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(687, 307)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 27)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "月"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(752, 307)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 27)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "日"
        '
        'TxtStartD
        '
        Me.TxtStartD.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtStartD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtStartD.Location = New System.Drawing.Point(724, 305)
        Me.TxtStartD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtStartD.MaxLength = 2
        Me.TxtStartD.Name = "TxtStartD"
        Me.TxtStartD.Size = New System.Drawing.Size(32, 34)
        Me.TxtStartD.TabIndex = 4
        Me.TxtStartD.Text = "02"
        '
        'TxtStartM
        '
        Me.TxtStartM.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtStartM.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtStartM.Location = New System.Drawing.Point(656, 305)
        Me.TxtStartM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtStartM.MaxLength = 2
        Me.TxtStartM.Name = "TxtStartM"
        Me.TxtStartM.Size = New System.Drawing.Size(32, 34)
        Me.TxtStartM.TabIndex = 3
        Me.TxtStartM.Text = "01"
        '
        'TxtStartTimeH
        '
        Me.TxtStartTimeH.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtStartTimeH.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtStartTimeH.Location = New System.Drawing.Point(794, 305)
        Me.TxtStartTimeH.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtStartTimeH.MaxLength = 2
        Me.TxtStartTimeH.Name = "TxtStartTimeH"
        Me.TxtStartTimeH.Size = New System.Drawing.Size(32, 34)
        Me.TxtStartTimeH.TabIndex = 5
        Me.TxtStartTimeH.Text = "01"
        '
        'TxtStartTimeM
        '
        Me.TxtStartTimeM.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtStartTimeM.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtStartTimeM.Location = New System.Drawing.Point(862, 305)
        Me.TxtStartTimeM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtStartTimeM.MaxLength = 2
        Me.TxtStartTimeM.Name = "TxtStartTimeM"
        Me.TxtStartTimeM.Size = New System.Drawing.Size(32, 34)
        Me.TxtStartTimeM.TabIndex = 6
        Me.TxtStartTimeM.Text = "02"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(890, 307)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 27)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "分"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(825, 307)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 27)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "時"
        '
        'TxtEndTimeH
        '
        Me.TxtEndTimeH.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtEndTimeH.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtEndTimeH.Location = New System.Drawing.Point(794, 418)
        Me.TxtEndTimeH.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtEndTimeH.MaxLength = 2
        Me.TxtEndTimeH.Name = "TxtEndTimeH"
        Me.TxtEndTimeH.Size = New System.Drawing.Size(32, 34)
        Me.TxtEndTimeH.TabIndex = 10
        Me.TxtEndTimeH.Text = "01"
        '
        'TxtEndTimeM
        '
        Me.TxtEndTimeM.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtEndTimeM.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtEndTimeM.Location = New System.Drawing.Point(862, 418)
        Me.TxtEndTimeM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtEndTimeM.MaxLength = 2
        Me.TxtEndTimeM.Name = "TxtEndTimeM"
        Me.TxtEndTimeM.Size = New System.Drawing.Size(32, 34)
        Me.TxtEndTimeM.TabIndex = 11
        Me.TxtEndTimeM.Text = "02"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(890, 420)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 27)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "分"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(825, 420)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 27)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "時"
        '
        'TxtEndM
        '
        Me.TxtEndM.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtEndM.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtEndM.Location = New System.Drawing.Point(656, 418)
        Me.TxtEndM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtEndM.MaxLength = 2
        Me.TxtEndM.Name = "TxtEndM"
        Me.TxtEndM.Size = New System.Drawing.Size(32, 34)
        Me.TxtEndM.TabIndex = 8
        Me.TxtEndM.Text = "01"
        '
        'TxtEndD
        '
        Me.TxtEndD.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtEndD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtEndD.Location = New System.Drawing.Point(724, 418)
        Me.TxtEndD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtEndD.MaxLength = 2
        Me.TxtEndD.Name = "TxtEndD"
        Me.TxtEndD.Size = New System.Drawing.Size(32, 34)
        Me.TxtEndD.TabIndex = 9
        Me.TxtEndD.Text = "02"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(752, 420)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 27)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "日"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label16.Location = New System.Drawing.Point(687, 420)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 27)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "月"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Location = New System.Drawing.Point(620, 420)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 27)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "年"
        '
        'TxtEndY
        '
        Me.TxtEndY.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtEndY.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtEndY.Location = New System.Drawing.Point(557, 418)
        Me.TxtEndY.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtEndY.MaxLength = 4
        Me.TxtEndY.Name = "TxtEndY"
        Me.TxtEndY.Size = New System.Drawing.Size(62, 34)
        Me.TxtEndY.TabIndex = 7
        Me.TxtEndY.Text = "2022"
        '
        'TxtUserID
        '
        Me.TxtUserID.Enabled = False
        Me.TxtUserID.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtUserID.Location = New System.Drawing.Point(931, 44)
        Me.TxtUserID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(64, 34)
        Me.TxtUserID.TabIndex = 62
        Me.TxtUserID.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.Location = New System.Drawing.Point(796, 50)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(139, 27)
        Me.Label18.TabIndex = 63
        Me.Label18.Text = "ユーザーID："
        Me.Label18.Visible = False
        '
        'btnDel
        '
        Me.btnDel.AutoSize = True
        Me.btnDel.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDel.Location = New System.Drawing.Point(834, 471)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(112, 43)
        Me.btnDel.TabIndex = 64
        Me.btnDel.Text = "削除"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'DateTimePickerS
        '
        Me.DateTimePickerS.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePickerS.Location = New System.Drawing.Point(704, 259)
        Me.DateTimePickerS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePickerS.Name = "DateTimePickerS"
        Me.DateTimePickerS.Size = New System.Drawing.Size(243, 34)
        Me.DateTimePickerS.TabIndex = 65
        '
        'DateTimePickerE
        '
        Me.DateTimePickerE.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePickerE.Location = New System.Drawing.Point(704, 372)
        Me.DateTimePickerE.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePickerE.Name = "DateTimePickerE"
        Me.DateTimePickerE.Size = New System.Drawing.Size(243, 34)
        Me.DateTimePickerE.TabIndex = 66
        '
        'FormTStamp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1024, 575)
        Me.Controls.Add(Me.DateTimePickerE)
        Me.Controls.Add(Me.DateTimePickerS)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtUserID)
        Me.Controls.Add(Me.TxtEndTimeH)
        Me.Controls.Add(Me.TxtEndTimeM)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtEndM)
        Me.Controls.Add(Me.TxtEndD)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtEndY)
        Me.Controls.Add(Me.TxtStartTimeH)
        Me.Controls.Add(Me.TxtStartTimeM)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtStartM)
        Me.Controls.Add(Me.TxtStartD)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtEnd)
        Me.Controls.Add(Me.TxtStart)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.btnUpd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtStartY)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtWork)
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
        Me.Name = "FormTStamp"
        Me.Text = "勤怠管理（打刻）"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblMsg As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnIns As Button
    Friend WithEvents btnUpd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtStartY As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtWork As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtStart As TextBox
    Friend WithEvents TxtEnd As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtStartD As TextBox
    Friend WithEvents TxtStartM As TextBox
    Friend WithEvents TxtStartTimeH As TextBox
    Friend WithEvents TxtStartTimeM As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtEndTimeH As TextBox
    Friend WithEvents TxtEndTimeM As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtEndM As TextBox
    Friend WithEvents TxtEndD As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtEndY As TextBox
    Friend WithEvents TxtUserID As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnDel As Button
    Friend WithEvents DateTimePickerS As DateTimePicker
    Friend WithEvents DateTimePickerE As DateTimePicker
End Class
