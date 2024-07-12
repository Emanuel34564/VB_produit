
Imports System.Data.SqlClient
Imports System.IO
Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Formulaire_de_creation.Show()
        Me.Hide()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Base_produitDataSet1.produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.ProduitTableAdapter.Fill(Me.Base_produitDataSet1.produit)
        Dim connectionstring As String = "Data Source=DESKTOP-9GBHR94;Initial Catalog=base produit;Integrated Security=true;"
        Using connection As New SqlConnection(connectionstring)
            connection.Open()
            Dim query As String = "select * from produit;"
            Using command As New SqlCommand(query, connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using
            End Using
            connection.Close()
        End Using
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Formulaire_de_creation.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
