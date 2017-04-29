Public Class Form1
    Private Sub btn_yeux_Click(sender As Object, e As EventArgs) Handles btn_yeux.Click
        lbl_yeux.Visible = True
    End Sub

    Private Sub btn_cheveux_Click(sender As Object, e As EventArgs) Handles btn_cheveux.Click
        lbl_cheveux.Visible = True
    End Sub

    Private Sub btn_photo_Click(sender As Object, e As EventArgs) Handles btn_photo.Click
        pb_photo.Visible = True
    End Sub

    Private Sub btn_effacer_Click(sender As Object, e As EventArgs) Handles btn_effacer.Click
        lbl_yeux.Visible = False
        lbl_cheveux.Visible = False
        pb_photo.Visible = False
    End Sub
End Class
