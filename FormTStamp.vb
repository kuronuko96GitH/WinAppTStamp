Imports Npgsql

Public Class FormTStamp

    Private Function ChkValidate() As Boolean
        ' テキスト入力チェック

        Dim strStartDate As String = ""
        Dim strEndDate As String = ""
        Dim strStartTime As String = ""
        Dim strEndTime As String = ""

        Dim chkDt As DateTime ' 日付型のチェック用


        If (String.IsNullOrEmpty(TxtWork.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "勤務内容を入力して下さい。"
            ' 入力チェックエラー
            Return False

        End If


        If (String.IsNullOrEmpty(TxtStartY.Text)) Or
            (String.IsNullOrEmpty(TxtStartM.Text)) Or
            (String.IsNullOrEmpty(TxtStartD.Text)) Or
            (String.IsNullOrEmpty(TxtStartTimeH.Text)) Or
            (String.IsNullOrEmpty(TxtStartTimeM.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "開始日時を入力して下さい。"
            ' 入力チェックエラー
            Return False

        End If

        ' 開始日を文字列で取得しておく。
        strStartDate = TxtStartY.Text & TxtStartM.Text.PadLeft(2, "0"c) & TxtStartD.Text.PadLeft(2, "0"c)

        If YYYYMMDDToDate(strStartDate) = Nothing Then
            ' 日付チェック
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "開始日時の日付が正しくありません。"
            ' 入力チェックエラー
            Return False

            'Else
            ' 戻りの日付型を使いたい場合、(例：MM/DD/YYYY HH:MI:SS AM)
            'Dim dateStart As Date
            'dateStart = YYYYMMDDToDate(TxtStartY.Text & TxtStartM.Text & TxtStartD.Text)

        End If



        If (String.IsNullOrEmpty(TxtEndY.Text)) Or
            (String.IsNullOrEmpty(TxtEndM.Text)) Or
            (String.IsNullOrEmpty(TxtEndD.Text)) Or
            (String.IsNullOrEmpty(TxtEndTimeH.Text)) Or
            (String.IsNullOrEmpty(TxtEndTimeM.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "終了日時を入力して下さい。"
            ' 入力チェックエラー
            Return False

        End If

        ' 終了日を文字列で取得しておく。
        strEndDate = TxtEndY.Text & TxtEndM.Text.PadLeft(2, "0"c) & TxtEndD.Text.PadLeft(2, "0"c)

        If YYYYMMDDToDate(strEndDate) = Nothing Then
            ' 日付チェック
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "終了日時の日付が正しくありません。"
            ' 入力チェックエラー
            Return False

        End If



        ' 開始時間を文字列で取得しておく。
        strStartTime = TxtStartTimeH.Text.PadLeft(2, "0"c) & ":" & TxtStartTimeM.Text.PadLeft(2, "0"c) & ":00"
        ' 終了時間を文字列で取得しておく。
        strEndTime = TxtEndTimeH.Text.PadLeft(2, "0"c) & ":" & TxtEndTimeM.Text.PadLeft(2, "0"c) & ":00"


        If DateTime.TryParse(strStartTime, chkDt) = False Then
            ' 時刻チェック
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "開始時刻が正しくありません。"
            ' 入力チェックエラー
            Return False

        ElseIf DateTime.TryParse(strEndTime, chkDt) = False Then
            ' 時刻チェック
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "終了時刻が正しくありません。"
            ' 入力チェックエラー
            Return False

        End If


        ' 開始時間を文字列で再取得。
        strStartTime = TxtStartTimeH.Text.PadLeft(2, "0"c) & TxtStartTimeM.Text.PadLeft(2, "0"c)
        ' 終了時間を文字列で再取得。
        strEndTime = TxtEndTimeH.Text.PadLeft(2, "0"c) & TxtEndTimeM.Text.PadLeft(2, "0"c)

        If YYYYMMDDToDate(strStartDate) > YYYYMMDDToDate(strEndDate) Then
            ' 日付チェック
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "終了日が、開始日より過去になっています。"
            ' 入力チェックエラー
            Return False

        ElseIf CInt(strStartTime) > CInt(strEndTime) Then
            ' 時刻チェック
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "終了時間が、開始時間より過去になっています。"
            ' 入力チェックエラー
            Return False

        End If


        ' 入力チェックに問題無し
        Return True

    End Function

    Function YYYYMMDDToDate(value As String) As Date
        Dim formatedValue As String

        ' 日付チェック

        '8文字でない場合は処理終了
        If value.Length <> 8 Then Return Nothing

        '/区切りの文字列に変換
        formatedValue = value.Substring(0, 4) & "/" & value.Substring(4, 2) & "/" & value.Substring(6, 2)

        '日付型に変換できない場合は処理終了
        If Not IsDate(formatedValue) Then Return Nothing

        '日付型に変換して返却
        Return CDate(formatedValue)
    End Function


    Private Sub InitDataGrid()
        ' DataGridViewに、データベースから取得したデータをセット

        Using conn As New NpgsqlConnection(FormMenu.STR_DB_CONN)

            ' データベースオープン
            conn.Open()

            Dim strSql As String

            strSql = "SELECT WORKS.* FROM USERS, WORKS WHERE USERS.ID = WORKS.USER_ID AND USERS.ID ='" & Module1.mdl_id & "'"
            strSql = strSql & " ORDER BY WORKS.START_DATE, WORKS.START_TIME, WORKS.END_DATE, WORKS.END_TIME"


            'Console.WriteLine(strSql) ' デバッグ用　コンソールに出力


            ' データベースからデータを取得
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(strSql, conn)
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                ' 該当するデータが無かった場合

                ' データベースクローズ
                conn.Close()

                Return '強制終了
            End If


            'DataGridView1.AutoSizeColumnsMode は　AllCellsに設定
            DataGridView1.ReadOnly = True
            'DataGridViewコントロールの行ヘッダー（左側のグレーの部分）を非表示にする
            DataGridView1.RowHeadersVisible = False
            ' ユーザー側で行の高さを変更できないように設定。
            DataGridView1.AllowUserToResizeRows = False



            '列数を指定
            DataGridView1.ColumnCount = 7
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

            Dim i As Integer
            i = 0

            Dim intNo As Integer
            intNo = 1

            Dim strTime As String


            For Each row As DataRow In dt.Rows

                DataGridView1.Rows(i).Cells(0).Value = intNo.ToString()
                DataGridView1.Rows(i).Cells(1).Value = row("ID").ToString()
                DataGridView1.Rows(i).Cells(2).Value = row("USER_ID").ToString()
                DataGridView1.Rows(i).Cells(3).Value = row("CONTENT").ToString()

                ' 開始日時
                '                DataGridView1.Rows(i).Cells(4).Value = row("START_DATE").ToString() & " " & row("START_TIME").ToString()
                strTime = row("START_TIME").ToString().Substring(0, 5)
                DataGridView1.Rows(i).Cells(4).Value = row("START_DATE").ToShortDateString() & " " & strTime

                ' 終了日時
                '                DataGridView1.Rows(i).Cells(5).Value = row("END_DATE").ToString() & " " & row("END_TIME").ToString()
                strTime = row("END_TIME").ToString().Substring(0, 5)
                DataGridView1.Rows(i).Cells(5).Value = row("END_DATE").ToShortDateString() & " " & strTime

                DataGridView1.Rows(i).Cells(6).Value = row("UPDATED_AT").ToString()

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


    End Sub

    Private Sub FormTStamp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtUserID.Text = Module1.mdl_id ' ユーザーIDを設定
        lblName.Text = Module1.mdl_name

        ' 開始日時
        TxtStartY.Text = ""
        TxtStartM.Text = ""
        TxtStartD.Text = ""
        TxtStartTimeH.Text = ""
        TxtStartTimeM.Text = ""

        ' 終了日時
        TxtEndY.Text = ""
        TxtEndM.Text = ""
        TxtEndD.Text = ""
        TxtEndTimeH.Text = ""
        TxtEndTimeM.Text = ""

        ' メッセージの初期化
        LblMsg.BackColor = SystemColors.ActiveCaption
        LblMsg.Text = ""

        ' DataGridViewに、データベースから取得したデータをセット
        InitDataGrid()

    End Sub

    Private Sub btnIns_Click(sender As Object, e As EventArgs) Handles btnIns.Click

        ' 新規登録ボタンを押した時

        If ChkValidate() = False Then
            '入力チェックがエラーの時は強制終了
            Return

        End If


        Dim strStartDate As String = ""
        Dim strEndDate As String = ""
        Dim strStartTime As String = ""
        Dim strEndTime As String = ""

        ' 開始日を文字列で取得しておく。
        strStartDate = TxtStartY.Text & "-" & TxtStartM.Text.PadLeft(2, "0"c) & "-" & TxtStartD.Text.PadLeft(2, "0"c)
        ' 終了日を文字列で取得しておく。
        strEndDate = TxtEndY.Text & "-" & TxtEndM.Text.PadLeft(2, "0"c) & "-" & TxtEndD.Text.PadLeft(2, "0"c)


        ' 開始時間を文字列で取得しておく。
        strStartTime = TxtStartTimeH.Text.PadLeft(2, "0"c) & ":" & TxtStartTimeM.Text.PadLeft(2, "0"c) & ":00"
        ' 終了時間を文字列で取得しておく。
        strEndTime = TxtEndTimeH.Text.PadLeft(2, "0"c) & ":" & TxtEndTimeM.Text.PadLeft(2, "0"c) & ":00"


        Using conn As New NpgsqlConnection(FormMenu.STR_DB_CONN)

            ' データベースオープン
            conn.Open()

            Dim strSql As String
            strSql = "INSERT INTO WORKS (USER_ID, CONTENT, START_DATE, START_TIME, END_DATE, END_TIME) VALUES ("
            strSql = strSql & " '" & Module1.mdl_id & "', '" & TxtWork.Text & "'"
            strSql = strSql & ",'" & strStartDate & "'"
            strSql = strSql & ",'" & strStartTime & "'"
            strSql = strSql & ",'" & strEndDate & "'"
            strSql = strSql & ",'" & strEndTime & "'"
            strSql = strSql & " )"

            'Console.WriteLine("FormTStamp Ins:" & strSql) ' デバッグ用　コンソールに出力
            Dim command As NpgsqlCommand = New NpgsqlCommand(strSql, conn)
            Dim retcnt = command.ExecuteNonQuery()
            '            MessageBox.Show("count = " & CStr(retcnt))

            ' データベースクローズ
            conn.Close()

        End Using

        ' グリッドの再表示
        InitDataGrid()

        LblMsg.BackColor = SystemColors.ActiveCaption
        LblMsg.Text = "新規登録が完了しました。"
        '        MessageBox.Show("ユーザー情報の新規登録が完了しました。")

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim strDate As String
        'Dim strTime As String

        ' データグリッドをクリックした時に、ユーザー情報を取得する。
        TxtWork.Text = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(3).Value

        ' デバッグ用　開始日時
        TxtStart.Text = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(4).Value
        strDate = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(4).Value

        ' 開始日時
        TxtStartY.Text = strDate.Substring(0, 4)
        TxtStartM.Text = strDate.Substring(5, 2)
        TxtStartD.Text = strDate.Substring(8, 2)
        TxtStartTimeH.Text = strDate.Substring(11, 2)
        TxtStartTimeM.Text = strDate.Substring(14, 2)

        ' デバッグ用　終了日時
        TxtEnd.Text = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(5).Value
        strDate = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(5).Value

        ' 終了日時
        TxtEndY.Text = strDate.Substring(0, 4)
        TxtEndM.Text = strDate.Substring(5, 2)
        TxtEndD.Text = strDate.Substring(8, 2)
        TxtEndTimeH.Text = strDate.Substring(11, 2)
        TxtEndTimeM.Text = strDate.Substring(14, 2)

        ' デバッグ用にIDもテキストに表示
        txtID.Text = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(1).Value
        TxtUserID.Text = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(2).Value

    End Sub

    Private Sub btnUpd_Click(sender As Object, e As EventArgs) Handles btnUpd.Click

        ' 更新ボタンを押した時

        If ChkValidate() = False Then
            '入力チェックがエラーの時は強制終了
            Return

        ElseIf (String.IsNullOrEmpty(txtID.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "更新対象が存在しません。"
            ' 入力チェックエラー
            Return

        End If


        Dim strStartDate As String = ""
        Dim strEndDate As String = ""
        Dim strStartTime As String = ""
        Dim strEndTime As String = ""

        ' 開始日を文字列で取得しておく。
        strStartDate = TxtStartY.Text & "-" & TxtStartM.Text.PadLeft(2, "0"c) & "-" & TxtStartD.Text.PadLeft(2, "0"c)
        ' 終了日を文字列で取得しておく。
        strEndDate = TxtEndY.Text & "-" & TxtEndM.Text.PadLeft(2, "0"c) & "-" & TxtEndD.Text.PadLeft(2, "0"c)


        ' 開始時間を文字列で取得しておく。
        strStartTime = TxtStartTimeH.Text.PadLeft(2, "0"c) & ":" & TxtStartTimeM.Text.PadLeft(2, "0"c) & ":00"
        ' 終了時間を文字列で取得しておく。
        strEndTime = TxtEndTimeH.Text.PadLeft(2, "0"c) & ":" & TxtEndTimeM.Text.PadLeft(2, "0"c) & ":00"

        Using conn As New NpgsqlConnection(FormMenu.STR_DB_CONN)

            ' データベースオープン
            conn.Open()

            Dim strSql As String
            strSql = "UPDATE WORKS SET"
            strSql = strSql & " CONTENT = '" & TxtWork.Text & "'"
            strSql = strSql & ", START_DATE = '" & strStartDate & "'"
            strSql = strSql & ", START_TIME = '" & strStartTime & "'"
            strSql = strSql & ", END_DATE = '" & strEndDate & "'"
            strSql = strSql & ", END_TIME = '" & strEndTime & "'"
            strSql = strSql & ", UPDATED_AT = CURRENT_TIMESTAMP"
            strSql = strSql & " WHERE ID = " & txtID.Text & " AND USER_ID = '" & Module1.mdl_id & "'"

            'Console.WriteLine("FormTStamp Upd:" & strSql) ' デバッグ用　コンソールに出力
            Dim command As NpgsqlCommand = New NpgsqlCommand(strSql, conn)
            Dim retcnt = command.ExecuteNonQuery()
            '            MessageBox.Show("count = " & CStr(retcnt))

            ' データベースクローズ
            conn.Close()

        End Using

        ' グリッドの再表示
        InitDataGrid()

        LblMsg.BackColor = SystemColors.ActiveCaption
        LblMsg.Text = "更新が完了しました。"
        '        MessageBox.Show("ユーザー情報の新規登録が完了しました。")

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        ' 削除ボタンを押した時

        Using conn As New NpgsqlConnection(FormMenu.STR_DB_CONN)

            ' データベースオープン
            conn.Open()

            Dim strSql As String
            strSql = "DELETE FROM WORKS"
            strSql = strSql & " WHERE ID =" & txtID.Text

            '            Console.WriteLine(strSql) ' デバッグ用　コンソールに出力
            Dim command As NpgsqlCommand = New NpgsqlCommand(strSql, conn)
            Dim retcnt = command.ExecuteNonQuery()
            '            MessageBox.Show("count = " & CStr(retcnt))

            ' データベースクローズ
            conn.Close()

        End Using

        ' グリッドの再表示
        InitDataGrid()

        LblMsg.BackColor = SystemColors.ActiveCaption
        LblMsg.Text = "削除が完了しました。"
        '        MessageBox.Show("ユーザー情報の新規登録が完了しました。")

    End Sub

    Private Sub TxtStartY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStartY.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtStartM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStartM.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtStartD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStartD.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtStartTimeH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStartTimeH.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtStartTimeM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStartTimeM.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


    Private Sub TxtEndY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEndY.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtEndM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEndM.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtEndD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEndD.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtEndTimeH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEndTimeH.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtEndTimeM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEndTimeM.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub DateTimePickerS_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerS.ValueChanged

        '開始日のカレンダーを変更した時

        Dim strDatePicker As String
        strDatePicker = DateTimePickerS.Value.ToShortDateString()

        ' 開始日を取得する
        TxtStartY.Text = strDatePicker.Substring(0, 4)
        TxtStartM.Text = strDatePicker.Substring(5, 2)
        TxtStartD.Text = strDatePicker.Substring(8, 2)

    End Sub

    Private Sub DateTimePickerE_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerE.ValueChanged

        '終了日のカレンダーを変更した時

        Dim strDatePicker As String
        strDatePicker = DateTimePickerE.Value.ToShortDateString()

        ' 終了日を取得する
        TxtEndY.Text = strDatePicker.Substring(0, 4)
        TxtEndM.Text = strDatePicker.Substring(5, 2)
        TxtEndD.Text = strDatePicker.Substring(8, 2)

    End Sub

End Class