Imports Npgsql

Public Class FormUser

    Private Function ChkValidate() As Boolean
        ' テキスト入力チェック

        If (String.IsNullOrEmpty(TxtID.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "登録IDを入力して下さい。"
            ' 入力チェックエラー
            Return False

        End If


        If (String.IsNullOrEmpty(TxtName.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "氏名を入力して下さい。"
            ' 入力チェックエラー
            Return False

        End If


        If (String.IsNullOrEmpty(TxtEmail.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "メールアドレスを入力して下さい。"
            ' 入力チェックエラー
            Return False

        End If


        If (String.IsNullOrEmpty(TxtPassword.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "パスワードを入力して下さい。"
            ' 入力チェックエラー
            Return False

        End If



        ' 入力チェックに問題無し
        Return True

    End Function

    Private Function ChkDuplicate() As Boolean
        ' データの重複チェックテキスト入力チェック


        Dim retcnt = 0 ' 取得したデータの件数

        Using conn As New NpgsqlConnection(FormMenu.STR_DB_CONN)

            ' データベースオープン
            conn.Open()

            Dim strSql As String
            strSql = "SELECT COUNT(*) FROM USERS"
            strSql = strSql & " WHERE ID = '" & TxtID.Text & "'"

            ' データベースからデータを取得
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(strSql, conn)

            'ExecuteScalar：クエリを実行し、そのクエリが返す結果セットの最初の行にある最初の列を返す。
            retcnt = CInt(cmd.ExecuteScalar())

            'Console.WriteLine(strSql) ' デバッグ用　コンソールに出力

            ' データベースクローズ
            conn.Close()

        End Using

        If (retcnt = 1) Then
            ' 重複するデータを取得

            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "既に登録されているデータがあります。"
            ' 入力チェックエラー
            Return False
        End If

        ' 入力チェックに問題無し
        Return True

    End Function

    Private Sub InitDataGrid()
        ' DataGridViewに、データベースから取得したデータをセット

        Using conn As New NpgsqlConnection(FormMenu.STR_DB_CONN)

            ' データベースオープン
            conn.Open()

            ' データベースからデータを取得
            Dim cmd As NpgsqlCommand = New NpgsqlCommand("SELECT ID, NAME, EMAIL, PASSWORD, UPDATED_AT FROM USERS ORDER BY ID", conn)
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            da.Fill(dt)


            'DataGridView1.AutoSizeColumnsMode は　AllCellsに設定
            DataGridView1.ReadOnly = True
            'DataGridViewコントロールの行ヘッダー（左側のグレーの部分）を非表示にする
            DataGridView1.RowHeadersVisible = False
            ' ユーザー側で行の高さを変更できないように設定。
            DataGridView1.AllowUserToResizeRows = False



            '列数を指定
            DataGridView1.ColumnCount = 6
            '取得したデータの件数を設定
            DataGridView1.RowCount = dt.Rows.Count
            '列名を指定
            DataGridView1.Columns(0).HeaderText = "No"
            DataGridView1.Columns(1).HeaderText = "登録ID"
            DataGridView1.Columns(2).HeaderText = "ユーザ名"
            DataGridView1.Columns(3).HeaderText = "email"
            DataGridView1.Columns(4).HeaderText = "password"
            DataGridView1.Columns(5).HeaderText = "更新日"

            Dim i As Integer
            i = 0

            Dim intNo As Integer
            intNo = 1

            For Each row As DataRow In dt.Rows

                DataGridView1.Rows(i).Cells(0).Value = intNo.ToString()
                DataGridView1.Rows(i).Cells(1).Value = row("ID").ToString()
                DataGridView1.Rows(i).Cells(2).Value = row("name").ToString()
                DataGridView1.Rows(i).Cells(3).Value = row("email").ToString()
                DataGridView1.Rows(i).Cells(4).Value = row("password").ToString()
                DataGridView1.Rows(i).Cells(5).Value = row("updated_at").ToString()

                i = i + 1
                intNo = i + 1
            Next

            ' グリッドでは非表示にする。
            'DataGridView1.Columns(1).Visible = False    ' ID（USER_ID）
            DataGridView1.Columns(3).Visible = False    ' email
            DataGridView1.Columns(4).Visible = False    ' password
            DataGridView1.Columns(5).Visible = False    ' 更新日

            ' コンボボックスに値を設定
            'Dim sources As List(Of Kind) = New List(Of Kind)
            'Dim k As Kind = New Kind()
            'k.KindCd = ""
            'k.KindName = "指定なし"
            'sources.Add(k)
            'For Each row As DataRow In dt.Rows
            '    k = New Kind()
            '    k.KindCd = row("KIND_CD").ToString()
            '    k.KindName = row("KIND_NAME").ToString()
            '    sources.Add(k)
            'Next

            'Me.cmbKind.DataSource = sources
            'Me.cmbKind.DisplayMember = "KindName"

            ' データベースクローズ
            conn.Close()

        End Using


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        'メッセージ表示用の変数
        '     Dim strMessageList As String

        '選択しているセルの値の取得
        '      strMessageList = "選択しているセルの値：" & DataGridView1.SelectedCells(0).Value & vbCrLf
        '選択している行番号の取得
        '       strMessageList = strMessageList & "選択しているセルの行番号：" & DataGridView1.SelectedCells(0).RowIndex & vbCrLf
        '選択している列番号の取得
        '        strMessageList = strMessageList & "選択しているセルの行番号：" & DataGridView1.SelectedCells(0).ColumnIndex & vbCrLf

        'メッセージボックスで表示
        '        MsgBox(strMessageList)


        'TxtName.Text = DataGridView1.SelectedCells(0).Value

    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' メッセージの初期化
        LblMsg.BackColor = SystemColors.ActiveCaption
        LblMsg.Text = ""

        ' DataGridViewに、データベースから取得したデータをセット
        InitDataGrid()

    End Sub

    Private Sub btnUpd_Click(sender As Object, e As EventArgs) Handles btnUpd.Click

        ' 更新ボタンを押した時

        If ChkValidate() = False Then
            '入力チェックがエラーの時は強制終了
            Return

        End If


        Using conn As New NpgsqlConnection(FormMenu.STR_DB_CONN)

            ' データベースオープン
            conn.Open()

            Dim strSql As String

            strSql = "UPDATE USERS SET"
            '            strSql = strSql & " ID = '" & TxtID.Text & "'"
            strSql = strSql & " NAME = '" & TxtName.Text & "'"
            strSql = strSql & ", EMAIL = '" & TxtEmail.Text & "'"
            strSql = strSql & ", PASSWORD = '" & TxtPassword.Text & "'"
            strSql = strSql & ", UPDATED_AT = CURRENT_TIMESTAMP"
            strSql = strSql & " WHERE ID = '" & TxtID.Text & "'"

            'Console.WriteLine(strSql) ' デバッグ用　コンソールに出力

            Dim command As NpgsqlCommand = New NpgsqlCommand(strSql, conn)
            Dim retcnt = command.ExecuteNonQuery()
            '            MessageBox.Show("count = " & CStr(retcnt))

            ' データベースクローズ
            conn.Close()

        End Using

        ' グリッドの再表示
        InitDataGrid()
        '        Me.Refresh() ' 画面の再描画

        LblMsg.BackColor = SystemColors.ActiveCaption
        LblMsg.Text = "ユーザー情報の更新が完了しました。"
        '        MessageBox.Show("ユーザー情報の更新が完了しました。")

    End Sub

    Private Sub btnIns_Click(sender As Object, e As EventArgs) Handles btnIns.Click

        ' 新規登録ボタンを押した時

        If ChkValidate() = False Then
            '入力チェックがエラーの時は強制終了
            Return

        End If

        If ChkDuplicate() = False Then
            'データの重複チェックがエラーの時は強制終了
            Return

        End If

        Using conn As New NpgsqlConnection(FormMenu.STR_DB_CONN)

            ' データベースオープン
            conn.Open()

            Dim strSql As String
            strSql = "INSERT INTO USERS (ID, NAME, EMAIL, PASSWORD) VALUES ("
            strSql = strSql & "'" & TxtID.Text & "',"
            strSql = strSql & "'" & TxtName.Text & "', '" & TxtEmail.Text & "',"
            strSql = strSql & "'" & TxtPassword.Text & "'"
            strSql = strSql & " )"

            Dim command As NpgsqlCommand = New NpgsqlCommand(strSql, conn)
            Dim retcnt = command.ExecuteNonQuery()
            '            MessageBox.Show("count = " & CStr(retcnt))


            'パラメータを設定する場合。
            '        command.CommandText = "INSERT INTO tablename (memo) VALUES (@p1)";
            '        command.Parameters.AddWithValue("p1", "Hello");

            '        Dim sResult As String = command.ExecuteScalar()


            ' データベースクローズ
            conn.Close()

        End Using

        ' グリッドの再表示
        InitDataGrid()

        LblMsg.BackColor = SystemColors.ActiveCaption
        LblMsg.Text = "ユーザー情報の新規登録が完了しました。"
        '        MessageBox.Show("ユーザー情報の新規登録が完了しました。")

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        ' データグリッドをクリックした時に、ユーザー情報を取得する。
        TxtName.Text = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(2).Value
        TxtEmail.Text = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(3).Value
        TxtPassword.Text = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(4).Value

        ' デバッグ用にIDもテキストに表示
        TxtID.Text = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(1).Value

    End Sub
End Class
