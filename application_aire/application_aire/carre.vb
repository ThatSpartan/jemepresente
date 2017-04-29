Public Class fm_carre
    Sub _wait()
        Threading.Thread.Sleep(300)
    End Sub

    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Hide()
        Call _wait()
        fm_menu.Show()
    End Sub

    Private Sub btn_calculer_Click(sender As Object, e As EventArgs) Handles btn_calculer.Click

        Dim longeur = tb_longeur
        Dim largeur = tb_largeur
        Dim reponse = tb_reponse

        If longeur.Text = "" Then
            Call _error(1, "longeur empty")
        End If

        If largeur.Text = "" Then
            Call _error(2, "largeur empty")
        End If

        If reponse.Text = "" Then
            Call _error(3, "reponse empty")
        End If

        If _checkForEmpty(longeur) Then
            If _checkForEmpty(largeur) Then
                ' longeur x largeur
                reponse.Text = "reponse"
            End If
            If _checkForEmpty(reponse) Then

            End If
        End If

    End Sub

    Function _checkForEmpty(_textbox As Object)
        If _textbox.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub _error(code As Integer, msg As String)
        MsgBox("Error " & code & vbNewLine & msg)
    End Sub
End Class