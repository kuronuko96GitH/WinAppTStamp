Imports Npgsql

Public Class FormReward

    Private Function ChkValidate() As Boolean
        ' テキスト入力チェック

        If (String.IsNullOrEmpty(TxtRewY.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "計算対象の年を入力して下さい。"
            ' 入力チェックエラー
            Return False

        End If

        If (String.IsNullOrEmpty(TxtRewM.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "計算対象の月を入力して下さい。"
            ' 入力チェックエラー
            Return False

        End If

        If (String.IsNullOrEmpty(TxtTanka.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "時間単価を入力して下さい。"
            ' 入力チェックエラー
            Return False

        End If

        If (String.IsNullOrEmpty(TxtCom.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "紹介料（％）を入力して下さい。"
            ' 入力チェックエラー
            Return False

        End If



        ' 入力チェックに問題無し
        Return True

    End Function

    Private Function InitDataGrid() As Boolean
        ' DataGridViewに、データベースから取得したデータをセット

        ' 実労働時間の計算用
        Dim decWorkCnt As Decimal = 0
        Dim decWorkSum As Decimal = 0 ' 合計値

        Dim dtStart As DateTime
        Dim dtEnd As DateTime

        Using conn As New NpgsqlConnection(FormMenu.STR_DB_CONN)

            ' データベースオープン
            conn.Open()

            Dim strSql As String

            strSql = "SELECT WORKS.* FROM USERS, WORKS WHERE USERS.ID = WORKS.USER_ID AND USERS.ID ='" & Module1.mdl_id & "'"
            strSql = strSql & " AND TO_CHAR(WORKS.START_DATE,'YYYYMM') = '" & TxtRewY.Text.PadLeft(2, "0"c) & TxtRewM.Text.PadLeft(2, "0"c) & "'"
            strSql = strSql & " ORDER BY WORKS.START_DATE, WORKS.START_TIME, WORKS.END_DATE, WORKS.END_TIME"


            'Console.WriteLine("FormReward.InitDataGrid:" & strSql) ' デバッグ用　コンソールに出力


            ' データベースからデータを取得
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(strSql, conn)
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                ' 該当するデータが無かった場合
                LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
                LblMsg.Text = "該当する実績データがありません。"

                ' データベースクローズ
                conn.Close()

                Return False '強制終了
            End If


            'DataGridView1.AutoSizeColumnsMode は　AllCellsに設定
            DataGridView1.ReadOnly = True
            'DataGridViewコントロールの行ヘッダー（左側のグレーの部分）を非表示にする
            DataGridView1.RowHeadersVisible = False
            ' ユーザー側で行の高さを変更できないように設定。
            DataGridView1.AllowUserToResizeRows = False



            '列数を指定
            DataGridView1.ColumnCount = 8
            '取得したデータの件数を設定
            DataGridView1.RowCount = dt.Rows.Count
            '列名を指定
            DataGridView1.Columns(0).HeaderText = "No"
            DataGridView1.Columns(1).HeaderText = "id"
            DataGridView1.Columns(2).HeaderText = "ユーザID"
            DataGridView1.Columns(3).HeaderText = "勤務先など"
            DataGridView1.Columns(4).HeaderText = "開始日時"
            DataGridView1.Columns(5).HeaderText = "終了日時"
            DataGridView1.Columns(6).HeaderText = "更新日"
            DataGridView1.Columns(7).HeaderText = "実績時間"

            Dim i As Integer
            i = 0

            Dim intNo As Integer
            intNo = 1

            Dim strTimeS As String
            Dim strTimeE As String


            For Each row As DataRow In dt.Rows

                DataGridView1.Rows(i).Cells(0).Value = intNo.ToString()
                DataGridView1.Rows(i).Cells(1).Value = row("ID").ToString()
                DataGridView1.Rows(i).Cells(2).Value = row("USER_ID").ToString()
                DataGridView1.Rows(i).Cells(3).Value = row("CONTENT").ToString()

                ' 開始日時
                '                DataGridView1.Rows(i).Cells(4).Value = row("START_DATE").ToString() & " " & row("START_TIME").ToString()
                strTimeS = row("START_TIME").ToString().Substring(0, 5)
                DataGridView1.Rows(i).Cells(4).Value = row("START_DATE").ToShortDateString() & " " & strTimeS

                ' 終了日時
                '                DataGridView1.Rows(i).Cells(5).Value = row("END_DATE").ToString() & " " & row("END_TIME").ToString()
                strTimeE = row("END_TIME").ToString().Substring(0, 5)
                DataGridView1.Rows(i).Cells(5).Value = row("END_DATE").ToShortDateString() & " " & strTimeE

                DataGridView1.Rows(i).Cells(6).Value = row("UPDATED_AT").ToString()


                ' 実績時間
                dtStart = CDate(row("START_DATE").ToShortDateString() & " " & strTimeS)
                dtEnd = CDate(row("END_DATE").ToShortDateString() & " " & strTimeE)

                decWorkCnt = ChangeTime(dtStart, dtEnd)
                DataGridView1.Rows(i).Cells(7).Value = decWorkCnt.ToString()

                ' 合計値
                decWorkSum += decWorkCnt
                'DataGridView1.Rows(i).Cells(7).Value = ChangeTime(dtStart, dtEnd)

                i = i + 1
                intNo = i + 1
            Next

            ' グリッドでは非表示にする。
            DataGridView1.Columns(1).Visible = False    ' ID
            DataGridView1.Columns(2).Visible = False    ' USER_ID
            DataGridView1.Columns(6).Visible = False    ' 更新日

            ' データベースクローズ
            conn.Close()

        End Using

        ' 合計値を実労働時間に設定。
        lblWorkHours.Text = decWorkSum


        Dim decMoney As Decimal = 0 ' 報酬金額

        ' 報酬金額 = 実労働時間 * 時間単価 * 仲介手数料(％)
        decMoney = CDec(TxtTanka.Text) * CDec(lblWorkHours.Text)
        ' 仲介手数料がある場合、その割合を計算
        decMoney = decMoney * (1 - (CDec(TxtCom.Text) / 100))

        ' 報酬金額を表示
        LblReward.Text = CInt(decMoney).ToString("##,#")


        Return True '正常終了

    End Function

    Private Function ChangeTime(dtStart As DateTime, dtEnd As DateTime) As Decimal
        ' 引数の型：HH:MI 

        ' 計算後の時間数（戻り値）
        Dim decWorkHours As Decimal = 0
        Dim strWorkHours As String = ""
        Dim intTime As Integer = 0

        'Console.WriteLine(dtEnd.Subtract(dtStart)) ' デバッグ用


        Dim diff As TimeSpan = dtEnd.Subtract(dtStart)

        ' 『HH:MI』形式で時間数を取得。
        strWorkHours = diff.ToString().Substring(0, 5)

        decWorkHours = CDec(strWorkHours.ToString().Substring(0, 2))
        intTime = CInt(strWorkHours.ToString().Substring(3, 2))

        ' 時間（分）を、３０分単位で０．５時間に再計算。
        If (intTime > 0 And intTime < 30) Then
            ' 時間（分）が３０分未満の時は０．５時間で加算する。
            decWorkHours += 0.5
        ElseIf (intTime >= 30) Then
            ' 時間（分）が３０分以上の時は１時間で加算する。
            decWorkHours += 1
        End If



        If (ChkBreakTime.Checked = True) Then
            ' 昼休憩時間を実績時間から一時間減らす。（Break time）
            decWorkHours -= 1
        End If


        ' 時間数を戻り値に設定
        Return decWorkHours

    End Function

    Private Sub FormReward_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtUserID.Text = Module1.mdl_id ' ユーザーIDを設定
        lblName.Text = Module1.mdl_name

        ' 今日の日付を取得する。
        Dim strNowDate As String = System.DateTime.Now.ToString()

        TxtRewY.Text = strNowDate.Substring(0, 4)
        TxtRewM.Text = strNowDate.Substring(5, 2)

        ' メッセージの初期化
        LblMsg.BackColor = SystemColors.ActiveCaption
        LblMsg.Text = ""

        ' DataGridViewに、データベースから取得したデータをセット
        InitDataGrid()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub btnReward_Click(sender As Object, e As EventArgs) Handles btnReward.Click

        ' 報酬計算処理

        ' 再計算ボタンを押した時

        ' メッセージの初期化
        LblMsg.BackColor = SystemColors.ActiveCaption
        LblMsg.Text = ""

        If ChkValidate() = False Then
            '入力チェックがエラーの時は強制終了
            Return

        End If

        ' DataGridViewに、データベースから取得したデータをセット
        If InitDataGrid() = True Then
            '正常終了した場合

            LblMsg.BackColor = SystemColors.ActiveCaption
            LblMsg.Text = "再計算が完了しました。"

        End If

    End Sub

End Class