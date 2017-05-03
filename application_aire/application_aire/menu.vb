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

    Private Sub btn_rectangle_Click(sender As Object, e As EventArgs) Handles btn_rectangle.Click
        Hide()
        Call _wait()
        fm_rectangle.Show()
    End Sub

    Private Sub btn_triangle_Click(sender As Object, e As EventArgs) Handles btn_triangle.Click
        Hide()
        Call _wait()
        fm_triangle.Show()
    End Sub
End Class
