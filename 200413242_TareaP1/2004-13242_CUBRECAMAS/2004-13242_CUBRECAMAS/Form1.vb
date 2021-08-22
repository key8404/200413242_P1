Public Class Form1
    Dim contadorCosto, contadorMaterial, contadorTotal, contadorCantMat As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtAlgodon.Clear()
        TxtHilo.Clear()
        TxtLino.Clear()
        TxtSeda.Clear()
        CBAlgodon.CheckState = CheckState.Unchecked
        CBLino.CheckState = CheckState.Unchecked
        CBHilo.CheckState = CheckState.Unchecked
        CBSeda.CheckState = CheckState.Unchecked
        LblSalida.Text = "El costo final del producto será de Q"
        LblCubreCama.Text = "Para el cubrecama"
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        If RBImperial.Checked = True Then
            contadorCosto = 65.5
            If CBLino.Checked = True Then
                contadorMaterial += 15 * Val(TxtLino.Text)
            End If
            If CBAlgodon.Checked = True Then
                contadorMaterial += 23.99 * Val(TxtAlgodon.Text)
            End If
            If CBSeda.Checked = True Then
                contadorMaterial += 30.99 * Val(TxtSeda.Text)
            End If
            If CBHilo.Checked = True Then
                contadorMaterial += 39.99 * Val(TxtHilo.Text)

            End If
            contadorTotal = contadorMaterial + contadorCosto
            contadorCantMat = Val(TxtSeda.Text) + Val(TxtLino.Text) + Val(TxtHilo.Text) + Val(TxtAlgodon.Text)
            If contadorCantMat <> 3 Then
                MsgBox("La cantidad de material debe ser exactamente 3")
                TxtAlgodon.Text = ""
                TxtHilo.Text = ""
                TxtLino.Text = ""
                TxtSeda.Text = ""
                contadorTotal = 0
                LblSalida.Text = "El costo final del producto será de Q"
                LblCubreCama.Text = "Para el cubrecama"

            ElseIf (CBAlgodon.Checked Or CBHilo.Checked Or CBLino.Checked Or CBSeda.Checked) = False Then

                contadorMaterial = 0
                MsgBox("Debe marcar el material")
                LblSalida.Text = "El costo final del producto será de Q"
                LblCubreCama.Text = "Para el cubrecama"
            Else
                LblSalida.Text = LblSalida.Text + " " + Str(contadorTotal)
                LblCubreCama.Text = LblCubreCama.Text + " Imperial"
            End If

        End If
        contadorMaterial = 0
        If RBMatri.Checked = True Then
            contadorCosto = 85.99
            If CBLino.Checked = True Then
                contadorMaterial += 15 * Val(TxtLino.Text)

            End If
            If CBAlgodon.Checked = True Then
                contadorMaterial += 23.99 * Val(TxtAlgodon.Text)


            End If
            If CBSeda.Checked = True Then
                contadorMaterial += 30.99 * Val(TxtSeda.Text)

            End If
            If CBHilo.Checked = True Then
                contadorMaterial += 39.99 * Val(TxtHilo.Text)

            End If
            contadorTotal = contadorMaterial + contadorCosto
            contadorCantMat = Val(TxtSeda.Text) + Val(TxtLino.Text) + Val(TxtHilo.Text) + Val(TxtAlgodon.Text)
            If contadorCantMat <> 5 Then
                MsgBox("La cantidad de material debe ser exactamente 5")
                TxtAlgodon.Text = ""
                TxtHilo.Text = ""
                TxtLino.Text = ""
                TxtSeda.Text = ""
                contadorTotal = 0
                LblSalida.Text = "El costo final del producto será de Q"
                LblCubreCama.Text = "Para el cubrecama"

            ElseIf (CBAlgodon.Checked Or CBHilo.Checked Or CBLino.Checked Or CBSeda.Checked) = False Then

                contadorMaterial = 0
                MsgBox("Debe marcar el material")
                LblSalida.Text = "El costo final del producto será de Q"
                LblCubreCama.Text = "Para el cubrecama"
            Else
                LblSalida.Text = LblSalida.Text + " " + Str(contadorTotal)
                LblCubreCama.Text = LblCubreCama.Text + " Matrimonial"
            End If

        End If
        contadorMaterial = 0
        If RBQueen.Checked = True Then
            contadorCosto = 99.99
            If CBLino.Checked = True Then
                contadorMaterial += 15 * Val(TxtLino.Text)

            End If
            If CBAlgodon.Checked = True Then
                contadorMaterial += 23.99 * Val(TxtAlgodon.Text)


            End If
            If CBSeda.Checked = True Then
                contadorMaterial += 30.99 * Val(TxtSeda.Text)

            End If
            If CBHilo.Checked = True Then
                contadorMaterial += 39.99 * Val(TxtHilo.Text)

            End If
            contadorTotal = contadorMaterial + contadorCosto
            contadorCantMat = Val(TxtSeda.Text) + Val(TxtLino.Text) + Val(TxtHilo.Text) + Val(TxtAlgodon.Text)
            If contadorCantMat <> 6 Then
                MsgBox("La cantidad de material debe ser exactamente 6")
                TxtAlgodon.Text = ""
                TxtHilo.Text = ""
                TxtLino.Text = ""
                TxtSeda.Text = ""
                contadorTotal = 0
                LblSalida.Text = "El costo final del producto será de Q"
                LblCubreCama.Text = "Para el cubrecama"

            ElseIf (CBAlgodon.Checked Or CBHilo.Checked Or CBLino.Checked Or CBSeda.Checked) = False Then

                contadorMaterial = 0
                MsgBox("Debe marcar el material")
                LblSalida.Text = "El costo final del producto será de Q"
                LblCubreCama.Text = "Para el cubrecama"
            Else
                LblSalida.Text = LblSalida.Text + " " + Str(contadorTotal)
                LblCubreCama.Text = LblCubreCama.Text + " Queen"
            End If

        End If
        contadorMaterial = 0
        If RBKing.Checked = True Then
            contadorCosto = 105.99
            If CBLino.Checked = True Then
                contadorMaterial += 15 * Val(TxtLino.Text)

            End If
            If CBAlgodon.Checked = True Then
                contadorMaterial += 23.99 * Val(TxtAlgodon.Text)


            End If
            If CBSeda.Checked = True Then
                contadorMaterial += 30.99 * Val(TxtSeda.Text)

            End If
            If CBHilo.Checked = True Then
                contadorMaterial += 39.99 * Val(TxtHilo.Text)

            End If
            contadorTotal = contadorMaterial + contadorCosto
            contadorCantMat = Val(TxtSeda.Text) + Val(TxtLino.Text) + Val(TxtHilo.Text) + Val(TxtAlgodon.Text)
            If contadorCantMat <> 7 Then
                MsgBox("La cantidad de material debe ser exactamente 7")
                TxtAlgodon.Text = ""
                TxtHilo.Text = ""
                TxtLino.Text = ""
                TxtSeda.Text = ""
                contadorTotal = 0
                LblSalida.Text = "El costo final del producto será de Q"
                LblCubreCama.Text = "Para el cubrecama"

            ElseIf (CBAlgodon.Checked Or CBHilo.Checked Or CBLino.Checked Or CBSeda.Checked) = False Then

                contadorMaterial = 0
                MsgBox("Debe marcar el material")
                LblSalida.Text = "El costo final del producto será de Q"
                LblCubreCama.Text = "Para el cubrecama"
            Else
                LblSalida.Text = LblSalida.Text + " " + Str(contadorTotal)
                LblCubreCama.Text = LblCubreCama.Text + " King"
            End If

        End If
        contadorMaterial = 0
    End Sub
End Class
