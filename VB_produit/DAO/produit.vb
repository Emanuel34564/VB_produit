

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data

Partial Public Class Produit
    Inherits LUNA.LunaBaseClassEntity
    '******IMPORTANT: Don't write your code here. Write your code in the Class object that use this Partial Class.
    '******So you can replace DAOClass and EntityClass without lost your code

    Public Sub New()

    End Sub

#Region "Database Field Map"

    Protected _ID As Integer = 0

    <XmlElementAttribute("ID")>
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            If _ID <> value Then
                IsChanged = True
                _ID = value
            End If
        End Set
    End Property

    Protected _Code As String = ""

    <XmlElementAttribute("Code")>
    Public Property Code() As String
        Get
            Return _Code
        End Get
        Set(ByVal value As String)
            If _Code <> value Then
                IsChanged = True
                _Code = value
            End If
        End Set
    End Property

    Protected _Designation As String = ""

    <XmlElementAttribute("Designation")>
    Public Property Designation() As String
        Get
            Return _Designation
        End Get
        Set(ByVal value As String)
            If _Designation <> value Then
                IsChanged = True
                _Designation = value
            End If
        End Set
    End Property

    Protected _Prix As Double = 0

    <XmlElementAttribute("Prix")>
    Public Property Prix() As Double
        Get
            Return _Prix
        End Get
        Set(ByVal value As Double)
            If _Prix <> value Then
                IsChanged = True
                _Prix = value
            End If
        End Set
    End Property

    Protected _Date_de_Creation As DateTime = Nothing

    <XmlElementAttribute("Date_de_Creation")>
    Public Property Date_de_Creation() As DateTime
        Get
            Return _Date_de_Creation
        End Get
        Set(ByVal value As DateTime)
            If _Date_de_Creation <> value Then
                IsChanged = True
                _Date_de_Creation = value
            End If
        End Set
    End Property
#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Produit from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Dim Mgr As New ProduitDAO
            Dim int As Produit = Mgr.Read(Id)
            _ID = int.ID
            _Code = int.Code
            _Designation = int.Designation
            _Prix = int.Prix
            _Date_de_Creation = int.Date_de_Creation
            Mgr.Dispose()
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    Public Overridable Function Save() As Integer
        'Return the id Inserted
        Dim Ris As Integer = 0
        Try
            Dim Mgr As New ProduitDAO
            Ris = Mgr.Save(Me)
            Mgr.Dispose()
        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ris
    End Function

    Private Function InternalIsValid() As Boolean
        Dim Ris As Boolean = True
        If _Code.Length > 50 Then Ris = False
        If _Designation.Length > 2147483647 Then Ris = False
        Return Ris
    End Function

#End Region

#Region "Embedded Class"

#End Region

End Class


