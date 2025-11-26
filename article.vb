Public Class article
    Private Sub article_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = Date.Today.ToString

    End Sub

    Private Sub txtajouter_Click(sender As Object, e As EventArgs) Handles txtajouter.Click
        Dim code1 As Integer
        Dim prix1 As Integer
        Dim quantite1 As Integer
        If (String.IsNullOrWhiteSpace(txtcode.Text) Or Not (Integer.TryParse(txtcode.Text, code1))) Then
            ErrorProvider1.SetError(txtcode, "tapez le code")
            Return
        End If
        ErrorProvider1.Clear()
        If String.IsNullOrWhiteSpace(txtdes.Text) Then
            ErrorProvider1.SetError(txtdes, "tapez la designation")
            Return
        End If
        ErrorProvider1.Clear()
        If (String.IsNullOrWhiteSpace(txtprix.Text) Or Not (Integer.TryParse(txtprix.Text, prix1))) Then
            ErrorProvider1.SetError(txtprix, "vous devez taper le prix")
            Return
        End If
        ErrorProvider1.Clear()
        If (String.IsNullOrWhiteSpace(txtquantite.Text) Or Not (Integer.TryParse(txtquantite.Text, quantite1))) Then
            ErrorProvider1.SetError(txtquantite, "quantité obligatoire")
            Return
        End If
        ErrorProvider1.Clear()
        Dim a As art
        a.code = code1
        a.designation = txtdes.Text
        a.prix = prix1
        a.quantite = quantite1
        ajouterarticle(a)
        DGVArticle.Rows.Clear()

        For Each i As art In listeArticle
            DGVArticle.Rows.Add(i.code, i.designation, i.prix, i.quantite)
        Next




    End Sub

    Private Sub txtcalculer_Click(sender As Object, e As EventArgs) Handles txtcalculer.Click
        Dim prix1 As Integer
        Dim quantite1 As Integer
        If (String.IsNullOrWhiteSpace(txtprix.Text) Or Not (Integer.TryParse(txtprix.Text, prix1))) Then
            ErrorProvider1.SetError(txtprix, "vous devez taper le prix")
            Return
        End If
        ErrorProvider1.Clear()
        If (String.IsNullOrWhiteSpace(txtquantite.Text) Or Not (Integer.TryParse(txtquantite.Text, quantite1))) Then
            ErrorProvider1.SetError(txtquantite, "quantité obligatoire")
            Return
        End If
        ErrorProvider1.Clear()
        Label7.Text = prix1 * quantite1
    End Sub

    Private Sub txtannuler_Click(sender As Object, e As EventArgs) Handles txtannuler.Click
        txtcode.Clear()
        txtdes.Clear()
        txtquantite.Clear()
        txtprix.Clear()
        DGVArticle.Rows.Clear()
        Label7.Text = "total "
    End Sub
End Class
