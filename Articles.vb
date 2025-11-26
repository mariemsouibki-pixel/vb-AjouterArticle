Module Articles
    Public Structure art
        Dim code As Integer
        Dim designation As String
        Dim prix As Integer
        Dim quantite As Integer
    End Structure
    Public listeArticle As New List(Of art)
    Public Sub ajouterarticle(a As art)
        listeArticle.Add(a)


    End Sub








End Module
