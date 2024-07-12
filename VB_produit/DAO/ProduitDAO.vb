Imports System.Data.SqlClient

Partial Public Class ProduitDAO
    Inherits LUNA.LunaBaseClassDAO(Of Produit)

    Public Property OrderByField As Object

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As Data.SqlClient.SqlConnection)
        MyBase.New(Connection)
    End Sub


    Public Sub New(ByVal ConnectionString As String)
        MyBase.New(ConnectionString)
    End Sub

    Public Sub New(orderByField As Object)
        If orderByField Is Nothing Then
            Throw New ArgumentNullException(NameOf(orderByField))
        End If

        Me.OrderByField = orderByField
    End Sub

    ''' <summary>
    '''Read from DB table Produit
    ''' </summary>
    ''' <returns>
    '''Return an Produit object
    ''' </returns>
    Public Overrides Function Read(Id As Integer) As Produit
        Dim cls As New Produit

        Try
            Dim myCommand As SqlCommand = _cn.CreateCommand()
            myCommand.CommandText = "SELECT * FROM Produit where ID = " & Id
            If Not DbTransaction Is Nothing Then myCommand.Transaction = DbTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            myReader.Read()
            If myReader.HasRows Then
                cls.ID = myReader("ID")
                If Not myReader("Code") Is DBNull.Value Then
                    cls.Code = myReader("Code")
                End If
                If Not myReader("Designation") Is DBNull.Value Then
                    cls.Designation = myReader("Designation")
                End If
                If Not myReader("Prix") Is DBNull.Value Then
                    cls.Prix = myReader("Prix")
                End If
                If Not myReader("Date_de_Creation") Is DBNull.Value Then
                    cls.Date_de_Creation = myReader("Date_de_Creation")
                End If
            End If
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return cls
    End Function

    Public Overrides Function Save(ByRef cls As Produit) As Integer

        Dim Ris As Integer = 0 'in Ris return Insert Id

        If cls.IsValid Then
            If cls.IsChanged Then
                Dim DbCommand As SqlCommand = New SqlCommand()
                Try
                    Dim sql As String
                    DbCommand.Connection = _cn
                    If Not DbTransaction Is Nothing Then DbCommand.Transaction = DbTransaction
                    If cls.ID = 0 Then
                        sql = "INSERT INTO Produit ("
                        sql &= "Code,"
                        sql &= "Designation,"
                        sql &= "Prix,"
                        sql &= "Date_de_Creation"
                        sql &= ") VALUES ("
                        sql &= "@Code,"
                        sql &= "@Designation,"
                        sql &= "@Prix,"
                        sql &= "@Date_de_Creation"
                        sql &= ")"
                    Else
                        sql = "UPDATE Produit SET "
                        sql &= "Code = @Code,"
                        sql &= "Designation = @Designation,"
                        sql &= "Prix = @Prix,"
                        sql &= "Date_de_Creation = @Date_de_Creation"
                        sql &= " WHERE ID= " & cls.ID
                    End If
                    DbCommand.Parameters.Add(New SqlClient.SqlParameter("@Code", cls.Code))
                    DbCommand.Parameters.Add(New SqlClient.SqlParameter("@Designation", cls.Designation))
                    DbCommand.Parameters.Add(New SqlClient.SqlParameter("@Prix", cls.Prix))
                    If cls.Date_de_Creation <> Date.MinValue Then
                        Dim DataPar As New SqlClient.SqlParameter("@Date_de_Creation", OleDb.OleDbType.Date)
                        DataPar.Value = cls.Date_de_Creation
                        DbCommand.Parameters.Add(DataPar)
                    Else
                        DbCommand.Parameters.Add(New SqlClient.SqlParameter("@Date_de_Creation", DBNull.Value))
                    End If
                    DbCommand.CommandType = CommandType.Text
                    DbCommand.CommandText = sql
                    DbCommand.ExecuteNonQuery()

                    If cls.ID = 0 Then
                        Dim IdInserito As Integer = 0
                        sql = "select @@identity"
                        DbCommand.CommandText = sql
                        IdInserito = DbCommand.ExecuteScalar()
                        cls.ID = IdInserito
                        Ris = IdInserito
                    Else
                        Ris = cls.ID
                    End If

                    DbCommand.Dispose()

                Catch ex As Exception
                    ManageError(ex)
                End Try
            Else
                Ris = cls.ID
            End If

        Else
            Err.Raise(602, "Object data is not valid")
        End If
        Return Ris
    End Function

    Private Sub DestroyPermanently(Id As Integer)
        Try

            Dim UpdateCommand As SqlCommand = New SqlCommand()
            UpdateCommand.Connection = _cn


            Dim Sql As String = "DELETE FROM Produit"
            Sql &= " Where ID = " & Id

            UpdateCommand.CommandText = Sql
            If Not DbTransaction Is Nothing Then UpdateCommand.Transaction = DbTransaction
            UpdateCommand.ExecuteNonQuery()
            UpdateCommand.Dispose()
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub

    Public Overrides Sub Delete(Id As Integer)

        DestroyPermanently(Id)

    End Sub

    Public Overrides Sub Delete(ByRef obj As Produit, Optional ByRef ListaObj As List(Of Produit) = Nothing)

        DestroyPermanently(obj.ID)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Produit)
        Return FindReal(0, OrderBy, Parameter)
    End Function

    Public Overloads Function Find(ByVal Top As Integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Produit)
        Return FindReal(Top, OrderBy, Parameter)
    End Function

    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Produit)
        Return FindReal(0, "", Parameter)
    End Function

    Private Function FindReal(ByVal Top As Integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Produit)
        Dim Ls As New List(Of Produit)
        Try

            Dim sql As String = "

Dim sql As String = "
            sql = "SELECT ID," &
    "Code," &
    "Designation," &
    "Prix," &
    "Date_de_Creation"
            sql &= " from Produit"
            If OrderByField.Length Then
                sql &= " ORDER BY " & OrderByField
            End If

            Ls = GetData(sql, AddEmptyItem)

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    Private Function AddEmptyItem() As Boolean
        Throw New NotImplementedException()
    End Function

    Private Function GetData(sql As String, Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of Produit)
        Dim Ls As New List(Of Produit)
        Try
            Dim myCommand As SqlCommand = _cn.CreateCommand()
            myCommand.CommandText = sql
            If Not DbTransaction Is Nothing Then myCommand.Transaction = DbTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            If AddEmptyItem Then Ls.Add(New Produit() With {.ID = 0, .Code = "", .Designation = "", .Prix = 0, .Date_de_Creation = Nothing})
            While myReader.Read
                Dim classe As New Produit
                If Not myReader("ID") Is DBNull.Value Then classe.ID = myReader("ID")
                If Not myReader("Code") Is DBNull.Value Then classe.Code = myReader("Code")
                If Not myReader("Designation") Is DBNull.Value Then classe.Designation = myReader("Designation")
                If Not myReader("Prix") Is DBNull.Value Then classe.Prix = myReader("Prix")
                If Not myReader("Date_de_Creation") Is DBNull.Value Then classe.Date_de_Creation = myReader("Date_de_Creation")
                Ls.Add(classe)
            End While
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional AddEmptyItem As Boolean = False) As IEnumerable(Of Produit)
        Throw New NotImplementedException()
    End Function
End Class


