Public Class fm_triangle
    Sub _wait()
        Threading.Thread.Sleep(300)
    End Sub

    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Hide()
        Call _wait()
        fm_menu.Show()
    End Sub

    Private Sub _closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Call _wait()
        fm_menu.Show()
    End Sub

    Private Sub btn_calculer_Click(sender As Object, e As EventArgs) Handles btn_calculer.Click
        Call _calculer()
    End Sub

    Sub _calculer()
        Dim base, hauteur, aire, _elements

        _elements = {{tb_base, base}, {tb_hauteur, hauteur}, {tb_aire, aire}}

        Dim _empty As New List(Of Object)

        For i As Integer = 0 To 2

            If _elements(i, 0).text = "" Then

                _empty.add(_elements(i, 0))

            End If

        Next

        Select Case _empty.Count

            Case 0
                MsgBox("all full")

            Case 1
                MsgBox("one empty")

            Case > 1
                MsgBox("more than one empty")

        End Select



    End Sub
End Class