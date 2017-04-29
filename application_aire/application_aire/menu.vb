Public Class fm_menu
    Sub _wait()
        Threading.Thread.Sleep(300)
    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Close()
    End Sub

    Private Sub btn_carre_Click(sender As Object, e As EventArgs) Handles btn_carre.Click
        Hide()
        Call _wait()
        fm_carre.Show()
    End Sub
End Class
