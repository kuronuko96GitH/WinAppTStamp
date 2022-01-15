Imports Npgsql

Public Class FormLogin

    Private Function ChkValidate() As Boolean
        ' テキスト入力チェック

        If (String.IsNullOrEmpty(TxtID.Text)) Then
            ' Nothing、もしくは空文字列である
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "会員登録IDを入力して下さい。"
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


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' 更新ボタンを押した時

        If ChkValidate() = False Then
            '入力チェックがエラーの時は強制終了
            Return

        End If

        Dim retcnt = 0 ' 取得したデータの件数

        Using conn As New NpgsqlConnection(FormMenu.STR_DB_CONN)

            ' データベースオープン
            conn.Open()

            Dim strSql As String


            'strSql = "SELECT COUNT(*) FROM USERS"
            'strSql = strSql & " WHERE ID = '" & TxtID.Text & "' AND PASSWORD ='" & TxtPassword.Text & "'"

            '' データベースからデータを取得
            'Dim cmd As NpgsqlCommand = New NpgsqlCommand(strSql, conn)

            ''ExecuteScalar：クエリを実行し、そのクエリが返す結果セットの最初の行にある最初の列を返す。
            'retcnt = CInt(cmd.ExecuteScalar())



            strSql = "SELECT ID, NAME, ADMIN_CODE FROM USERS"
            strSql = strSql & " WHERE ID = '" & TxtID.Text & "' AND PASSWORD ='" & TxtPassword.Text & "'"

            'Console.WriteLine("FormLogin:" & strSql) ' デバッグ用　コンソールに出力


            ' データベースからデータを取得
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(strSql, conn)
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            da.Fill(dt)

            If dt.Rows.Count = 1 Then
                ' 該当するデータがあった場合
                retcnt = 1

                For Each row As DataRow In dt.Rows
                    TxtName.Text = row("NAME").ToString()
                    TxtAdminCode.Text = row("ADMIN_CODE").ToString()
                Next

            End If


            ' データベースクローズ
            conn.Close()

        End Using

        ' グリッドの再表示
        'InitDataGrid()

        If (retcnt = 1) Then
            ' ログイン可能なデータを取得できた

            LblMsg.BackColor = SystemColors.ActiveCaption
            LblMsg.Text = "ログインが完了しました。"
            '            MessageBox.Show("ログインが完了しました。")

            Dim f As New FormMenu
            f.Show()
            My.Application.ApplicationContext.MainForm = f
            Me.Close()

        Else
            LblMsg.BackColor = Color.Crimson ' エラー系の背景色を設定
            LblMsg.Text = "該当する会員情報はありません。"
        End If




    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' メッセージの初期化
        LblMsg.BackColor = SystemColors.ActiveCaption
        LblMsg.Text = ""

    End Sub
End Class