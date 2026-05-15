Public Class FLevel
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If RbBegginer.Checked Then
            FHangman.MaxIntentos = 10
        End If
        If RbIntermediate.Checked Then
            FHangman.MaxIntentos = 8
        End If
        If RbExpert.Checked Then
            FHangman.MaxIntentos = 6
        End If

        Me.Close()
        FHangman.IniciarNuevoJuego()

    End Sub
End Class