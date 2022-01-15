Public Class FormMenu

    Public Const STR_DB_CONN As String = "Server=localhost; Port=5432; User Id=user1;Password=pass;Database=testdb"

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click

        Dim frmUser As New FormUser ' 会員登録画面を開く

        '通常表示（モードレスフォーム）の場合
        'frmUser.Show()

        '今回はモーダルダイアログボックスとして表示する
        'オーナーウィンドウにMeを指定する
        frmUser.ShowDialog(Me)
        'フォームが必要なくなったところで、Disposeを呼び出す
        frmUser.Dispose()

    End Sub

    Private Sub BtnTStamp_Click(sender As Object, e As EventArgs) Handles BtnTStamp.Click

        Dim frmTStamp As New FormTStamp ' 打刻画面を開く

        '通常表示（モードレスフォーム）の場合
        'frmTStamp.Show()

        '今回はモーダルダイアログボックスとして表示する
        'オーナーウィンドウにMeを指定する
        frmTStamp.ShowDialog(Me)
        'フォームが必要なくなったところで、Disposeを呼び出す
        frmTStamp.Dispose()

    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ログイン画面で入力した登録IDを設定
        lblLoginID.Text = Module1.mdl_id
        ' ログイン画面で取得した氏名を設定
        lblName.Text = Module1.mdl_name

        If FormLogin.TxtAdminCode.Text = "1" Then
            ' ログインユーザーが管理者の場合
            BtnUser.Enabled = True
        Else
            ' ログインユーザーが管理者以外の場合

            ' 会員登録画面のボタンは触らせない
            BtnUser.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim frmLogin As New FormLogin ' ログイン画面を開く
        'frmLogin.Show()
    End Sub

    Private Sub BtnReward_Click(sender As Object, e As EventArgs) Handles BtnReward.Click

        Dim frmReward As New FormReward ' 打刻画面を開く

        '通常表示（モードレスフォーム）の場合
        'frmTStamp.Show()

        '今回はモーダルダイアログボックスとして表示する
        'オーナーウィンドウにMeを指定する
        frmReward.ShowDialog(Me)
        'フォームが必要なくなったところで、Disposeを呼び出す
        frmReward.Dispose()

    End Sub
End Class