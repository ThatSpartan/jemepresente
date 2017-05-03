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

        If longeur.Text <> "" Then
            ' trouver l'aire
            reponse.Text = Math.Round(longeur.Text * longeur.Text, 2)

        ElseIf reponse.Text <> "" Then
            ' trouver la dimension
            longeur.Text = Math.Round(Math.Sqrt(reponse.Text), 2)

        End If

        largeur.Text = longeur.Text

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

    Private Sub check_for_number(sender As Object, e As KeyPressEventArgs) Handles tb_reponse.KeyPress, tb_longeur.KeyPress


        Dim ch = e.KeyChar
        If Char.IsDigit(ch) = False And Char.IsControl(ch) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub _delete(sender As Object, e As EventArgs) Handles btn_delete_reponse.Click, btn_delete_longeur.Click
        Select Case sender.name
            Case "btn_delete_longeur"
                tb_longeur.Text = ""
            Case "btn_delete_largeur"
                tb_largeur.Text = ""
            Case "btn_delete_reponse"
                tb_reponse.Text = ""
        End Select
    End Sub

    Private Sub _closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Call _wait()
        fm_menu.Show()
    End Sub
End Class