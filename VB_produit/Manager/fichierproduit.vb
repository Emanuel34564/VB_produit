Public Class fichierproduit
#Region "Author"
	'Class created with Luna 3.4.6.11
	'Author: Diego Lunadei
	'Date: 12/07/2024
#End Region

	Public Class Produit

#Region "Logic Field"

#End Region

#Region "Method"

		Protected Friend Function IsValid() As Boolean
			'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
			'RETURN FALSE IF LOGIC CONTROL FAIL
			'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
			Dim Ris As Boolean = InternalIsValid
			'PUT YOUR LOGIC VALIDATION CODE HERE
			Return Ris
		End Function

		Private Function InternalIsValid() As Boolean
			Throw New NotImplementedException()
		End Function

#End Region

	End Class
End Class
