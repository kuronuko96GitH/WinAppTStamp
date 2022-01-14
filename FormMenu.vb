Public Class FormMenu

    Public Const STR_DB_CONN As String = "Server=localhost; Port=5432; User Id=user1;Password=pass;Database=testdb"

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click

        Dim frmUser As New FormUser ' 会員登録画面を開く
        frmUser.Show()

    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click

        'Me.Close() ' 会員登録画面は閉じる


        Dim frmTStamp As New FormTStamp ' 打刻画面を開く

        '通常表示（モードレスフォーム）の場合
        '        frmTStamp.Show()

        'ここではモーダルダイアログボックスとして表示する
        'オーナーウィンドウにMeを指定する
        frmTStamp.ShowDialog(Me)
        'フォームが必要なくなったところで、Disposeを呼び出す
        frmTStamp.Dispose()


    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ログイン画面で入力した登録IDを取得
        Me.lblLoginID.Text = FormLogin.TxtID.Text
        Module1.mdl_member_id = FormLogin.TxtID.Text

        If Module1.mdl_member_id = "0001" Then
            ' ログインユーザーが管理者の場合
            BtnUser.Enabled = True
        Else
            ' ログインユーザーが管理者以外の場合

            ' 会員登録画面のボタンは触らせない
            BtnUser.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim frmLogin As New FormLogin ' ログイン画面を開く
        frmLogin.Show()
    End Sub
End Class