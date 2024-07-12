
Imports System.Data.SqlClient
Imports System.IO


Public Class Formulaire_de_creation


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



    End Sub


    Private Sub Formulaire_de_creation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Base_produitDataSet.produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.ProduitTableAdapter.Fill(Me.Base_produitDataSet.produit)


    End Sub
End Class