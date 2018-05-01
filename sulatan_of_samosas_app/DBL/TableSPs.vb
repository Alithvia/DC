Imports System.Data
Imports System.Data.SqlClient

'******************************************************************
'* Code Generated Automatically using GlobalCodeGen and CodeRush! 
'* AUTHOR: InterGlobal Solutions
'* SUPPORT: http://www.interglobal.ca  519-342-4881
'* ALSO: http://www.techstudio.ca  519-342-4881
'* DATE: 2018-04-30 3:00:22 PM
'* Derived from: SoS_Script_Test
'******************************************************************


NameSpace Tables

    Public Class SPTypes
        Public Const SelectRow As String = "Select"
        Public Const SelectBy As String = "SelectBy"
        Public Const SelectAll As String = "SelectAll"
        Public Const SelectDynamic As String = "SelectDynamic"
        Public Const SelectPaged As String = "SelectPaged"
        Public Const Delete As String = "Delete"
        Public Const DeleteBy As String = "DeleteBy"
        Public Const DeleteDynamic As String = "DeleteDynamic"
        Public Const Insert As String = "Insert"
        Public Const Update As String = "Update"
        Public Const InsertUpdate As String = "InsertUpdate"
    End Class

    Public Class SPHelpers

        Public Shared Function BuildWhereCondition(ByVal ParmArray() As SPHelpers.WhereCondition) As String
            Dim StrWhere As String = Nothing
            Dim ShowComma As Boolean = False
            For Each Parm As SPHelpers.WhereCondition In ParmArray
                If Not Parm.Column = Nothing Then
                    If ShowComma Then StrWhere &= ", "
                    Select Case Parm.Comparison
                        Case Tables.Equals.IsEqualTo
                            If TypeOf (Parm.ParmValue) Is String Then
                                StrWhere &= Parm.Column & " LIKE '" & Parm.ParmValue.ToString & "'"
                            Else
                                StrWhere &= Parm.Column & " = " & Parm.ParmValue.ToString
                            End If
                        Case Tables.Equals.NotEquals
                            If TypeOf (Parm.ParmValue) Is String Then
                                StrWhere &= "Not(" & Parm.Column & " LIKE '" & Parm.ParmValue.ToString.Replace("*", "%") & "')"
                            Else
                                StrWhere &= "Not(" & Parm.Column & " = " & Parm.ParmValue.ToString & ")"
                            End If
                        Case Tables.Equals.Contains
                            If TypeOf (Parm.ParmValue) Is String Then
                                StrWhere &= Parm.Column & " LIKE '%" & Parm.ParmValue.ToString.Replace("*", "%") & "%'"
                            Else
                                StrWhere &= Parm.Column & " IN (" & Parm.ParmValue.ToString & ")"
                            End If
                        Case Tables.Equals.EndsWith
                            If TypeOf (Parm.ParmValue) Is String Then
                                StrWhere &= Parm.Column & " LIKE '%" & Parm.ParmValue.ToString.Replace("*", "%") & "'"
                            Else
                                StrWhere &= Parm.Column & " <= " & Parm.ParmValue.ToString
                            End If
                        Case Tables.Equals.LessThanEquals
                            If TypeOf (Parm.ParmValue) Is String Then
                                StrWhere &= Parm.Column & " < '" & Parm.ParmValue.ToString.Replace("*", "%") & "'"
                            Else
                                StrWhere &= Parm.Column & " <= " & Parm.ParmValue.ToString
                            End If
                        Case Tables.Equals.LessThan
                            If TypeOf (Parm.ParmValue) Is String Then
                                StrWhere &= Parm.Column & " < '" & Parm.ParmValue.ToString.Replace("*", "%") & "'"
                            Else
                                StrWhere &= Parm.Column & " < " & Parm.ParmValue.ToString
                            End If
                        Case Tables.Equals.StartsWith
                            If TypeOf (Parm.ParmValue) Is String Then
                                StrWhere &= Parm.Column & " LIKE '" & Parm.ParmValue.ToString.Replace("*", "%") & "%'"
                            Else
                                StrWhere &= Parm.Column & " >= " & Parm.ParmValue.ToString
                            End If
                        Case Tables.Equals.GreaterThanEquals
                            If TypeOf (Parm.ParmValue) Is String Then
                                StrWhere &= Parm.Column & " > '" & Parm.ParmValue.ToString.Replace("*", "%") & "'"
                            Else
                                StrWhere &= Parm.Column & " >= " & Parm.ParmValue.ToString
                            End If
                        Case Tables.Equals.GreaterThan
                            If TypeOf (Parm.ParmValue) Is String Then
                                StrWhere &= Parm.Column & " > '" & Parm.ParmValue.ToString.Replace("*", "%") & "'"
                            Else
                                StrWhere &= Parm.Column & " > " & Parm.ParmValue.ToString
                            End If
                        Case Else
                            'DO NOTHING
                    End Select
                End If
                ShowComma = True
            Next
            Return StrWhere
        End Function

        Public Shared Function BuildOrderByExpression(ByVal ParmArray() As OrderByExpression) As String
            Dim StrOrder As String = Nothing
            Dim ShowComma As Boolean = False
            For Each Parm As OrderByExpression In ParmArray
                If Not Parm.Column = Nothing Then
                    If ShowComma Then StrOrder &= ", "
                    Select Case Parm.Direction
                        Case Sorting.Descending
                            StrOrder &= Parm.Column & " DESC"
                        Case Else
                            StrOrder &= Parm.Column & " ASC"
                    End Select
                End If
            Next
            Return StrOrder
        End Function

        Public Class WhereCondition
            Private _Column As String
            Public Property Column() As String
                Get
                    Return _Column
                End Get
                Set(ByVal value As String)
                    _Column = value
                End Set
            End Property

            Private _ParmValue As Object
            Public Property ParmValue() As Object
                Get
                    Return _ParmValue
                End Get
                Set(ByVal value As Object)
                    _ParmValue = value
                End Set
            End Property

            Private _Comparison As Equals
            Public Property Comparison() As Equals
                Get
                    Return _Comparison
                End Get
                Set(ByVal value As Equals)
                    _Comparison = value
                End Set
            End Property

            Public Sub New(ByVal Column As String, ByVal Comparison As Tables.Equals, ByVal Value As Object)
                _Column = Column
                _ParmValue = Value
                _Comparison = Comparison
            End Sub
        End Class

        Public Class OrderByExpression

            Private _Column As String
            Public Property Column() As String
                Get
                    Return _Column
                End Get
                Set(ByVal value As String)
                    _Column = value
                End Set
            End Property

            Private _Direction As Sorting
            Public Property Direction() As Sorting
                Get
                    Return _Direction
                End Get
                Set(ByVal value As Sorting)
                    _Direction = value
                End Set
            End Property

            Public Sub New(ByVal Column As String, ByVal SortDirection As Sorting)
                _Column = Column
                _Direction = SortDirection
            End Sub
        End Class

    End Class
	
#Region " - Class datAddresses"
			Partial Public Class datAddresses

	Private Shared Function SPBaseSQL() as String
		return "sp_datAddresses_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal AddressID As System.Int32)
	SetDefaults()
	If AddressID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@AddressID", AddressID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.AddressID)) Then _AddressID = dR(Columns.AddressID)
							If Not IsDBNull(dR(Columns.Address)) Then _Address = dR(Columns.Address)
							If Not IsDBNull(dR(Columns.CityID)) Then _CityID = dR(Columns.CityID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datAddresses)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datAddresses)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datAddresses)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datAddresses)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datAddresses)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datAddresses)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datAddresses)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datAddresses)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datAddresses)
            Dim returnValue As New Generic.List(Of datAddresses)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatAddresses As New datAddresses(0)
                            If Not IsDBNull(dR(Columns.AddressID)) Then MydatAddresses.AddressID = dR(Columns.AddressID)
                            If Not IsDBNull(dR(Columns.Address)) Then MydatAddresses.Address = dR(Columns.Address)
                            If Not IsDBNull(dR(Columns.CityID)) Then MydatAddresses.CityID = dR(Columns.CityID)
                            returnValue.Add(MydatAddresses)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datAddresses)
            Dim returnValue As New Generic.List(Of datAddresses)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatAddresses As New datAddresses(0)
                            If Not IsDBNull(dR(Columns.AddressID)) Then MydatAddresses.AddressID = dR(Columns.AddressID)
                            If Not IsDBNull(dR(Columns.Address)) Then MydatAddresses.Address = dR(Columns.Address)
                            If Not IsDBNull(dR(Columns.CityID)) Then MydatAddresses.CityID = dR(Columns.CityID)
                            returnValue.Add(MydatAddresses)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("AddressID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("AddressID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datAddresses) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.AddressID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.AddressID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal AddressID AS System.Int32, byVal Address AS System.String, byVal CityID AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF AddressID = 0 THEN
		ReturnValue = Insert(Address, CityID)
	ELSE
	
		Dim MyLib as New datAddresses(0)
				MyLib.AddressID = AddressID
				MyLib.Address = Address
				MyLib.CityID = CityID
		IF Update(MyLib) Then
			ReturnValue = MyLib.AddressID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datAddresses) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datAddresses(_MyLib.AddressID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@AddressID", _MyLib.AddressID))
						command.Parameters.Add(New SqlParameter("@Address", _MyLib.Address))
						command.Parameters.Add(New SqlParameter("@CityID", _MyLib.CityID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datAddresses SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal AddressID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@AddressID", AddressID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datAddresses)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datAddresses) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@AddressID", 0))
					command.Parameters.Add(New SqlParameter("@Address", _MyLib.Address))
					command.Parameters.Add(New SqlParameter("@CityID", _MyLib.CityID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal Address AS System.String, byVal CityID AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@AddressID", 0))
					command.Parameters.Add(New SqlParameter("@Address", Address))
					command.Parameters.Add(New SqlParameter("@CityID", CityID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datAssembly"
			Partial Public Class datAssembly

	Private Shared Function SPBaseSQL() as String
		return "sp_datAssembly_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal AssemblyID As System.Int32)
	SetDefaults()
	If AssemblyID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@AssemblyID", AssemblyID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.AssemblyID)) Then _AssemblyID = dR(Columns.AssemblyID)
							If Not IsDBNull(dR(Columns.AssemblyTypeID)) Then _AssemblyTypeID = dR(Columns.AssemblyTypeID)
							If Not IsDBNull(dR(Columns.DateTime)) Then _DateTime = dR(Columns.DateTime)
							If Not IsDBNull(dR(Columns.Expiry)) Then _Expiry = dR(Columns.Expiry)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datAssembly)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datAssembly)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datAssembly)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datAssembly)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datAssembly)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datAssembly)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datAssembly)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datAssembly)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datAssembly)
            Dim returnValue As New Generic.List(Of datAssembly)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatAssembly As New datAssembly(0)
                            If Not IsDBNull(dR(Columns.AssemblyID)) Then MydatAssembly.AssemblyID = dR(Columns.AssemblyID)
                            If Not IsDBNull(dR(Columns.AssemblyTypeID)) Then MydatAssembly.AssemblyTypeID = dR(Columns.AssemblyTypeID)
                            If Not IsDBNull(dR(Columns.DateTime)) Then MydatAssembly.DateTime = dR(Columns.DateTime)
                            If Not IsDBNull(dR(Columns.Expiry)) Then MydatAssembly.Expiry = dR(Columns.Expiry)
                            returnValue.Add(MydatAssembly)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datAssembly)
            Dim returnValue As New Generic.List(Of datAssembly)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatAssembly As New datAssembly(0)
                            If Not IsDBNull(dR(Columns.AssemblyID)) Then MydatAssembly.AssemblyID = dR(Columns.AssemblyID)
                            If Not IsDBNull(dR(Columns.AssemblyTypeID)) Then MydatAssembly.AssemblyTypeID = dR(Columns.AssemblyTypeID)
                            If Not IsDBNull(dR(Columns.DateTime)) Then MydatAssembly.DateTime = dR(Columns.DateTime)
                            If Not IsDBNull(dR(Columns.Expiry)) Then MydatAssembly.Expiry = dR(Columns.Expiry)
                            returnValue.Add(MydatAssembly)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("AssemblyID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("AssemblyID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datAssembly) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.AssemblyID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.AssemblyID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal AssemblyID AS System.Int32, byVal AssemblyTypeID AS System.Int32, byVal DateTime AS System.DateTime, byVal Expiry AS System.DateTime) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF AssemblyID = 0 THEN
		ReturnValue = Insert(AssemblyTypeID, DateTime, Expiry)
	ELSE
	
		Dim MyLib as New datAssembly(0)
				MyLib.AssemblyID = AssemblyID
				MyLib.AssemblyTypeID = AssemblyTypeID
				MyLib.DateTime = DateTime
				MyLib.Expiry = Expiry
		IF Update(MyLib) Then
			ReturnValue = MyLib.AssemblyID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datAssembly) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datAssembly(_MyLib.AssemblyID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@AssemblyID", _MyLib.AssemblyID))
						command.Parameters.Add(New SqlParameter("@AssemblyTypeID", _MyLib.AssemblyTypeID))
						command.Parameters.Add(New SqlParameter("@DateTime", _MyLib.DateTime))
						command.Parameters.Add(New SqlParameter("@Expiry", _MyLib.Expiry))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datAssembly SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal AssemblyID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@AssemblyID", AssemblyID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datAssembly)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datAssembly) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@AssemblyID", 0))
					command.Parameters.Add(New SqlParameter("@AssemblyTypeID", _MyLib.AssemblyTypeID))
					command.Parameters.Add(New SqlParameter("@DateTime", _MyLib.DateTime))
					command.Parameters.Add(New SqlParameter("@Expiry", _MyLib.Expiry))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal AssemblyTypeID AS System.Int32, byVal DateTime AS System.DateTime, byVal Expiry AS System.DateTime) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@AssemblyID", 0))
					command.Parameters.Add(New SqlParameter("@AssemblyTypeID", AssemblyTypeID))
					command.Parameters.Add(New SqlParameter("@DateTime", DateTime))
					command.Parameters.Add(New SqlParameter("@Expiry", Expiry))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datBoxes"
			Partial Public Class datBoxes

	Private Shared Function SPBaseSQL() as String
		return "sp_datBoxes_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal BoxID As System.Int32)
	SetDefaults()
	If BoxID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@BoxID", BoxID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.BoxID)) Then _BoxID = dR(Columns.BoxID)
							If Not IsDBNull(dR(Columns.AssemblyID)) Then _AssemblyID = dR(Columns.AssemblyID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datBoxes)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datBoxes)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datBoxes)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datBoxes)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datBoxes)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datBoxes)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datBoxes)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datBoxes)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datBoxes)
            Dim returnValue As New Generic.List(Of datBoxes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatBoxes As New datBoxes(0)
                            If Not IsDBNull(dR(Columns.BoxID)) Then MydatBoxes.BoxID = dR(Columns.BoxID)
                            If Not IsDBNull(dR(Columns.AssemblyID)) Then MydatBoxes.AssemblyID = dR(Columns.AssemblyID)
                            returnValue.Add(MydatBoxes)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datBoxes)
            Dim returnValue As New Generic.List(Of datBoxes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatBoxes As New datBoxes(0)
                            If Not IsDBNull(dR(Columns.BoxID)) Then MydatBoxes.BoxID = dR(Columns.BoxID)
                            If Not IsDBNull(dR(Columns.AssemblyID)) Then MydatBoxes.AssemblyID = dR(Columns.AssemblyID)
                            returnValue.Add(MydatBoxes)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("BoxID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("BoxID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datBoxes) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.BoxID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.BoxID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal BoxID AS System.Int32, byVal AssemblyID AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF BoxID = 0 THEN
		ReturnValue = Insert(AssemblyID)
	ELSE
	
		Dim MyLib as New datBoxes(0)
				MyLib.BoxID = BoxID
				MyLib.AssemblyID = AssemblyID
		IF Update(MyLib) Then
			ReturnValue = MyLib.BoxID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datBoxes) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datBoxes(_MyLib.BoxID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@BoxID", _MyLib.BoxID))
						command.Parameters.Add(New SqlParameter("@AssemblyID", _MyLib.AssemblyID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datBoxes SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal BoxID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@BoxID", BoxID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datBoxes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datBoxes) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@BoxID", 0))
					command.Parameters.Add(New SqlParameter("@AssemblyID", _MyLib.AssemblyID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal AssemblyID AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@BoxID", 0))
					command.Parameters.Add(New SqlParameter("@AssemblyID", AssemblyID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datClientOrders"
			Partial Public Class datClientOrders

	Private Shared Function SPBaseSQL() as String
		return "sp_datClientOrders_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal OrderNumber As System.Int32)
	SetDefaults()
	If OrderNumber > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@OrderNumber", OrderNumber))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.OrderNumber)) Then _OrderNumber = dR(Columns.OrderNumber)
							If Not IsDBNull(dR(Columns.ClientID)) Then _ClientID = dR(Columns.ClientID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datClientOrders)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datClientOrders)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datClientOrders)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datClientOrders)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datClientOrders)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datClientOrders)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datClientOrders)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datClientOrders)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datClientOrders)
            Dim returnValue As New Generic.List(Of datClientOrders)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatClientOrders As New datClientOrders(0)
                            If Not IsDBNull(dR(Columns.OrderNumber)) Then MydatClientOrders.OrderNumber = dR(Columns.OrderNumber)
                            If Not IsDBNull(dR(Columns.ClientID)) Then MydatClientOrders.ClientID = dR(Columns.ClientID)
                            returnValue.Add(MydatClientOrders)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datClientOrders)
            Dim returnValue As New Generic.List(Of datClientOrders)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatClientOrders As New datClientOrders(0)
                            If Not IsDBNull(dR(Columns.OrderNumber)) Then MydatClientOrders.OrderNumber = dR(Columns.OrderNumber)
                            If Not IsDBNull(dR(Columns.ClientID)) Then MydatClientOrders.ClientID = dR(Columns.ClientID)
                            returnValue.Add(MydatClientOrders)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("OrderNumber"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("OrderNumber"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datClientOrders) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.OrderNumber = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.OrderNumber
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal OrderNumber AS System.Int32, byVal ClientID AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF OrderNumber = 0 THEN
		ReturnValue = Insert(ClientID)
	ELSE
	
		Dim MyLib as New datClientOrders(0)
				MyLib.OrderNumber = OrderNumber
				MyLib.ClientID = ClientID
		IF Update(MyLib) Then
			ReturnValue = MyLib.OrderNumber
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datClientOrders) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datClientOrders(_MyLib.OrderNumber)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@OrderNumber", _MyLib.OrderNumber))
						command.Parameters.Add(New SqlParameter("@ClientID", _MyLib.ClientID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datClientOrders SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal OrderNumber As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@OrderNumber", OrderNumber))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datClientOrders)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datClientOrders) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@OrderNumber", 0))
					command.Parameters.Add(New SqlParameter("@ClientID", _MyLib.ClientID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal ClientID AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@OrderNumber", 0))
					command.Parameters.Add(New SqlParameter("@ClientID", ClientID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datClients"
			Partial Public Class datClients

	Private Shared Function SPBaseSQL() as String
		return "sp_datClients_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal ClientID As System.Int32)
	SetDefaults()
	If ClientID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ClientID", ClientID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.ClientID)) Then _ClientID = dR(Columns.ClientID)
							If Not IsDBNull(dR(Columns.ClientName)) Then _ClientName = dR(Columns.ClientName)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datClients)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datClients)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datClients)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datClients)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datClients)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datClients)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datClients)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datClients)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datClients)
            Dim returnValue As New Generic.List(Of datClients)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatClients As New datClients(0)
                            If Not IsDBNull(dR(Columns.ClientID)) Then MydatClients.ClientID = dR(Columns.ClientID)
                            If Not IsDBNull(dR(Columns.ClientName)) Then MydatClients.ClientName = dR(Columns.ClientName)
                            returnValue.Add(MydatClients)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datClients)
            Dim returnValue As New Generic.List(Of datClients)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatClients As New datClients(0)
                            If Not IsDBNull(dR(Columns.ClientID)) Then MydatClients.ClientID = dR(Columns.ClientID)
                            If Not IsDBNull(dR(Columns.ClientName)) Then MydatClients.ClientName = dR(Columns.ClientName)
                            returnValue.Add(MydatClients)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("ClientID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("ClientID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datClients) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.ClientID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.ClientID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal ClientID AS System.Int32, byVal ClientName AS System.String) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF ClientID = 0 THEN
		ReturnValue = Insert(ClientName)
	ELSE
	
		Dim MyLib as New datClients(0)
				MyLib.ClientID = ClientID
				MyLib.ClientName = ClientName
		IF Update(MyLib) Then
			ReturnValue = MyLib.ClientID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datClients) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datClients(_MyLib.ClientID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ClientID", _MyLib.ClientID))
						command.Parameters.Add(New SqlParameter("@ClientName", _MyLib.ClientName))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datClients SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal ClientID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@ClientID", ClientID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datClients)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datClients) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ClientID", 0))
					command.Parameters.Add(New SqlParameter("@ClientName", _MyLib.ClientName))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal ClientName AS System.String) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ClientID", 0))
					command.Parameters.Add(New SqlParameter("@ClientName", ClientName))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datContacts"
			Partial Public Class datContacts

	Private Shared Function SPBaseSQL() as String
		return "sp_datContacts_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal ContactID As System.Int32)
	SetDefaults()
	If ContactID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ContactID", ContactID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.ContactID)) Then _ContactID = dR(Columns.ContactID)
							If Not IsDBNull(dR(Columns.PeopleID)) Then _PeopleID = dR(Columns.PeopleID)
							If Not IsDBNull(dR(Columns.PhoneID)) Then _PhoneID = dR(Columns.PhoneID)
							If Not IsDBNull(dR(Columns.ContactTypeID)) Then _ContactTypeID = dR(Columns.ContactTypeID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datContacts)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datContacts)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datContacts)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datContacts)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datContacts)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datContacts)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datContacts)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datContacts)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datContacts)
            Dim returnValue As New Generic.List(Of datContacts)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatContacts As New datContacts(0)
                            If Not IsDBNull(dR(Columns.ContactID)) Then MydatContacts.ContactID = dR(Columns.ContactID)
                            If Not IsDBNull(dR(Columns.PeopleID)) Then MydatContacts.PeopleID = dR(Columns.PeopleID)
                            If Not IsDBNull(dR(Columns.PhoneID)) Then MydatContacts.PhoneID = dR(Columns.PhoneID)
                            If Not IsDBNull(dR(Columns.ContactTypeID)) Then MydatContacts.ContactTypeID = dR(Columns.ContactTypeID)
                            returnValue.Add(MydatContacts)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datContacts)
            Dim returnValue As New Generic.List(Of datContacts)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatContacts As New datContacts(0)
                            If Not IsDBNull(dR(Columns.ContactID)) Then MydatContacts.ContactID = dR(Columns.ContactID)
                            If Not IsDBNull(dR(Columns.PeopleID)) Then MydatContacts.PeopleID = dR(Columns.PeopleID)
                            If Not IsDBNull(dR(Columns.PhoneID)) Then MydatContacts.PhoneID = dR(Columns.PhoneID)
                            If Not IsDBNull(dR(Columns.ContactTypeID)) Then MydatContacts.ContactTypeID = dR(Columns.ContactTypeID)
                            returnValue.Add(MydatContacts)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("ContactID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("ContactID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datContacts) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.ContactID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.ContactID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal ContactID AS System.Int32, byVal PeopleID AS System.Int32, byVal PhoneID AS System.Int32, byVal ContactTypeID AS System.Byte) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF ContactID = 0 THEN
		ReturnValue = Insert(PeopleID, PhoneID, ContactTypeID)
	ELSE
	
		Dim MyLib as New datContacts(0)
				MyLib.ContactID = ContactID
				MyLib.PeopleID = PeopleID
				MyLib.PhoneID = PhoneID
				MyLib.ContactTypeID = ContactTypeID
		IF Update(MyLib) Then
			ReturnValue = MyLib.ContactID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datContacts) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datContacts(_MyLib.ContactID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ContactID", _MyLib.ContactID))
						command.Parameters.Add(New SqlParameter("@PeopleID", _MyLib.PeopleID))
						command.Parameters.Add(New SqlParameter("@PhoneID", _MyLib.PhoneID))
						command.Parameters.Add(New SqlParameter("@ContactTypeID", _MyLib.ContactTypeID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datContacts SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal ContactID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@ContactID", ContactID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datContacts)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datContacts) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ContactID", 0))
					command.Parameters.Add(New SqlParameter("@PeopleID", _MyLib.PeopleID))
					command.Parameters.Add(New SqlParameter("@PhoneID", _MyLib.PhoneID))
					command.Parameters.Add(New SqlParameter("@ContactTypeID", _MyLib.ContactTypeID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal PeopleID AS System.Int32, byVal PhoneID AS System.Int32, byVal ContactTypeID AS System.Byte) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ContactID", 0))
					command.Parameters.Add(New SqlParameter("@PeopleID", PeopleID))
					command.Parameters.Add(New SqlParameter("@PhoneID", PhoneID))
					command.Parameters.Add(New SqlParameter("@ContactTypeID", ContactTypeID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datEmployees"
			Partial Public Class datEmployees

	Private Shared Function SPBaseSQL() as String
		return "sp_datEmployees_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal EmployeeID As System.Int32)
	SetDefaults()
	If EmployeeID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.EmployeeID)) Then _EmployeeID = dR(Columns.EmployeeID)
							If Not IsDBNull(dR(Columns.PositionID)) Then _PositionID = dR(Columns.PositionID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datEmployees)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datEmployees)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datEmployees)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datEmployees)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datEmployees)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datEmployees)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datEmployees)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datEmployees)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datEmployees)
            Dim returnValue As New Generic.List(Of datEmployees)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatEmployees As New datEmployees(0)
                            If Not IsDBNull(dR(Columns.EmployeeID)) Then MydatEmployees.EmployeeID = dR(Columns.EmployeeID)
                            If Not IsDBNull(dR(Columns.PositionID)) Then MydatEmployees.PositionID = dR(Columns.PositionID)
                            returnValue.Add(MydatEmployees)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datEmployees)
            Dim returnValue As New Generic.List(Of datEmployees)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatEmployees As New datEmployees(0)
                            If Not IsDBNull(dR(Columns.EmployeeID)) Then MydatEmployees.EmployeeID = dR(Columns.EmployeeID)
                            If Not IsDBNull(dR(Columns.PositionID)) Then MydatEmployees.PositionID = dR(Columns.PositionID)
                            returnValue.Add(MydatEmployees)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("EmployeeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("EmployeeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datEmployees) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.EmployeeID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.EmployeeID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal EmployeeID AS System.Int32, byVal PositionID AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF EmployeeID = 0 THEN
		ReturnValue = Insert(PositionID)
	ELSE
	
		Dim MyLib as New datEmployees(0)
				MyLib.EmployeeID = EmployeeID
				MyLib.PositionID = PositionID
		IF Update(MyLib) Then
			ReturnValue = MyLib.EmployeeID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datEmployees) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datEmployees(_MyLib.EmployeeID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@EmployeeID", _MyLib.EmployeeID))
						command.Parameters.Add(New SqlParameter("@PositionID", _MyLib.PositionID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datEmployees SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal EmployeeID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datEmployees)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datEmployees) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@EmployeeID", 0))
					command.Parameters.Add(New SqlParameter("@PositionID", _MyLib.PositionID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal PositionID AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@EmployeeID", 0))
					command.Parameters.Add(New SqlParameter("@PositionID", PositionID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datIngredientInventory"
			Partial Public Class datIngredientInventory

	Private Shared Function SPBaseSQL() as String
		return "sp_datIngredientInventory_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal IngInvID As System.Int32)
	SetDefaults()
	If IngInvID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@IngInvID", IngInvID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.IngInvID)) Then _IngInvID = dR(Columns.IngInvID)
							If Not IsDBNull(dR(Columns.PurchaseID)) Then _PurchaseID = dR(Columns.PurchaseID)
							If Not IsDBNull(dR(Columns.IngredientID)) Then _IngredientID = dR(Columns.IngredientID)
							If Not IsDBNull(dR(Columns.Amount)) Then _Amount = dR(Columns.Amount)
							If Not IsDBNull(dR(Columns.UnitsID)) Then _UnitsID = dR(Columns.UnitsID)
							If Not IsDBNull(dR(Columns.ExpDate)) Then _ExpDate = dR(Columns.ExpDate)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datIngredientInventory)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datIngredientInventory)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datIngredientInventory)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datIngredientInventory)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datIngredientInventory)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datIngredientInventory)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datIngredientInventory)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datIngredientInventory)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datIngredientInventory)
            Dim returnValue As New Generic.List(Of datIngredientInventory)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatIngredientInventory As New datIngredientInventory(0)
                            If Not IsDBNull(dR(Columns.IngInvID)) Then MydatIngredientInventory.IngInvID = dR(Columns.IngInvID)
                            If Not IsDBNull(dR(Columns.PurchaseID)) Then MydatIngredientInventory.PurchaseID = dR(Columns.PurchaseID)
                            If Not IsDBNull(dR(Columns.IngredientID)) Then MydatIngredientInventory.IngredientID = dR(Columns.IngredientID)
                            If Not IsDBNull(dR(Columns.Amount)) Then MydatIngredientInventory.Amount = dR(Columns.Amount)
                            If Not IsDBNull(dR(Columns.UnitsID)) Then MydatIngredientInventory.UnitsID = dR(Columns.UnitsID)
                            If Not IsDBNull(dR(Columns.ExpDate)) Then MydatIngredientInventory.ExpDate = dR(Columns.ExpDate)
                            returnValue.Add(MydatIngredientInventory)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datIngredientInventory)
            Dim returnValue As New Generic.List(Of datIngredientInventory)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatIngredientInventory As New datIngredientInventory(0)
                            If Not IsDBNull(dR(Columns.IngInvID)) Then MydatIngredientInventory.IngInvID = dR(Columns.IngInvID)
                            If Not IsDBNull(dR(Columns.PurchaseID)) Then MydatIngredientInventory.PurchaseID = dR(Columns.PurchaseID)
                            If Not IsDBNull(dR(Columns.IngredientID)) Then MydatIngredientInventory.IngredientID = dR(Columns.IngredientID)
                            If Not IsDBNull(dR(Columns.Amount)) Then MydatIngredientInventory.Amount = dR(Columns.Amount)
                            If Not IsDBNull(dR(Columns.UnitsID)) Then MydatIngredientInventory.UnitsID = dR(Columns.UnitsID)
                            If Not IsDBNull(dR(Columns.ExpDate)) Then MydatIngredientInventory.ExpDate = dR(Columns.ExpDate)
                            returnValue.Add(MydatIngredientInventory)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("IngInvID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("IngInvID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datIngredientInventory) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.IngInvID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.IngInvID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal IngInvID AS System.Int32, byVal PurchaseID AS System.Int32, byVal IngredientID AS System.Int32, byVal Amount AS System.Double, byVal UnitsID AS System.Int32, byVal ExpDate AS System.DateTime) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF IngInvID = 0 THEN
		ReturnValue = Insert(PurchaseID, IngredientID, Amount, UnitsID, ExpDate)
	ELSE
	
		Dim MyLib as New datIngredientInventory(0)
				MyLib.IngInvID = IngInvID
				MyLib.PurchaseID = PurchaseID
				MyLib.IngredientID = IngredientID
				MyLib.Amount = Amount
				MyLib.UnitsID = UnitsID
				MyLib.ExpDate = ExpDate
		IF Update(MyLib) Then
			ReturnValue = MyLib.IngInvID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datIngredientInventory) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datIngredientInventory(_MyLib.IngInvID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@IngInvID", _MyLib.IngInvID))
						command.Parameters.Add(New SqlParameter("@PurchaseID", _MyLib.PurchaseID))
						command.Parameters.Add(New SqlParameter("@IngredientID", _MyLib.IngredientID))
						command.Parameters.Add(New SqlParameter("@Amount", _MyLib.Amount))
						command.Parameters.Add(New SqlParameter("@UnitsID", _MyLib.UnitsID))
						command.Parameters.Add(New SqlParameter("@ExpDate", _MyLib.ExpDate))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datIngredientInventory SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal IngInvID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@IngInvID", IngInvID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datIngredientInventory)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datIngredientInventory) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@IngInvID", 0))
					command.Parameters.Add(New SqlParameter("@PurchaseID", _MyLib.PurchaseID))
					command.Parameters.Add(New SqlParameter("@IngredientID", _MyLib.IngredientID))
					command.Parameters.Add(New SqlParameter("@Amount", _MyLib.Amount))
					command.Parameters.Add(New SqlParameter("@UnitsID", _MyLib.UnitsID))
					command.Parameters.Add(New SqlParameter("@ExpDate", _MyLib.ExpDate))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal PurchaseID AS System.Int32, byVal IngredientID AS System.Int32, byVal Amount AS System.Double, byVal UnitsID AS System.Int32, byVal ExpDate AS System.DateTime) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@IngInvID", 0))
					command.Parameters.Add(New SqlParameter("@PurchaseID", PurchaseID))
					command.Parameters.Add(New SqlParameter("@IngredientID", IngredientID))
					command.Parameters.Add(New SqlParameter("@Amount", Amount))
					command.Parameters.Add(New SqlParameter("@UnitsID", UnitsID))
					command.Parameters.Add(New SqlParameter("@ExpDate", ExpDate))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datMeasurements"
			Partial Public Class datMeasurements

	Private Shared Function SPBaseSQL() as String
		return "sp_datMeasurements_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal MeasurementID As System.Int32)
	SetDefaults()
	If MeasurementID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@MeasurementID", MeasurementID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.MeasurementID)) Then _MeasurementID = dR(Columns.MeasurementID)
							If Not IsDBNull(dR(Columns.ParentID)) Then _ParentID = dR(Columns.ParentID)
							If Not IsDBNull(dR(Columns.DateTime)) Then _DateTime = dR(Columns.DateTime)
							If Not IsDBNull(dR(Columns.Thickness)) Then _Thickness = dR(Columns.Thickness)
							If Not IsDBNull(dR(Columns.Weight)) Then _Weight = dR(Columns.Weight)
							If Not IsDBNull(dR(Columns.Length)) Then _Length = dR(Columns.Length)
							If Not IsDBNull(dR(Columns.Width)) Then _Width = dR(Columns.Width)
							If Not IsDBNull(dR(Columns.Employee)) Then _Employee = dR(Columns.Employee)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datMeasurements)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datMeasurements)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datMeasurements)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datMeasurements)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datMeasurements)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datMeasurements)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datMeasurements)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datMeasurements)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datMeasurements)
            Dim returnValue As New Generic.List(Of datMeasurements)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatMeasurements As New datMeasurements(0)
                            If Not IsDBNull(dR(Columns.MeasurementID)) Then MydatMeasurements.MeasurementID = dR(Columns.MeasurementID)
                            If Not IsDBNull(dR(Columns.ParentID)) Then MydatMeasurements.ParentID = dR(Columns.ParentID)
                            If Not IsDBNull(dR(Columns.DateTime)) Then MydatMeasurements.DateTime = dR(Columns.DateTime)
                            If Not IsDBNull(dR(Columns.Thickness)) Then MydatMeasurements.Thickness = dR(Columns.Thickness)
                            If Not IsDBNull(dR(Columns.Weight)) Then MydatMeasurements.Weight = dR(Columns.Weight)
                            If Not IsDBNull(dR(Columns.Length)) Then MydatMeasurements.Length = dR(Columns.Length)
                            If Not IsDBNull(dR(Columns.Width)) Then MydatMeasurements.Width = dR(Columns.Width)
                            If Not IsDBNull(dR(Columns.Employee)) Then MydatMeasurements.Employee = dR(Columns.Employee)
                            returnValue.Add(MydatMeasurements)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datMeasurements)
            Dim returnValue As New Generic.List(Of datMeasurements)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatMeasurements As New datMeasurements(0)
                            If Not IsDBNull(dR(Columns.MeasurementID)) Then MydatMeasurements.MeasurementID = dR(Columns.MeasurementID)
                            If Not IsDBNull(dR(Columns.ParentID)) Then MydatMeasurements.ParentID = dR(Columns.ParentID)
                            If Not IsDBNull(dR(Columns.DateTime)) Then MydatMeasurements.DateTime = dR(Columns.DateTime)
                            If Not IsDBNull(dR(Columns.Thickness)) Then MydatMeasurements.Thickness = dR(Columns.Thickness)
                            If Not IsDBNull(dR(Columns.Weight)) Then MydatMeasurements.Weight = dR(Columns.Weight)
                            If Not IsDBNull(dR(Columns.Length)) Then MydatMeasurements.Length = dR(Columns.Length)
                            If Not IsDBNull(dR(Columns.Width)) Then MydatMeasurements.Width = dR(Columns.Width)
                            If Not IsDBNull(dR(Columns.Employee)) Then MydatMeasurements.Employee = dR(Columns.Employee)
                            returnValue.Add(MydatMeasurements)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("MeasurementID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("MeasurementID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datMeasurements) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.MeasurementID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.MeasurementID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal MeasurementID AS System.Int32, byVal ParentID AS System.Int32, byVal DateTime AS System.DateTime, byVal Thickness AS System.Double, byVal Weight AS System.Double, byVal Length AS System.Double, byVal Width AS System.Double, byVal Employee AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF MeasurementID = 0 THEN
		ReturnValue = Insert(ParentID, DateTime, Thickness, Weight, Length, Width, Employee)
	ELSE
	
		Dim MyLib as New datMeasurements(0)
				MyLib.MeasurementID = MeasurementID
				MyLib.ParentID = ParentID
				MyLib.DateTime = DateTime
				MyLib.Thickness = Thickness
				MyLib.Weight = Weight
				MyLib.Length = Length
				MyLib.Width = Width
				MyLib.Employee = Employee
		IF Update(MyLib) Then
			ReturnValue = MyLib.MeasurementID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datMeasurements) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datMeasurements(_MyLib.MeasurementID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@MeasurementID", _MyLib.MeasurementID))
						command.Parameters.Add(New SqlParameter("@ParentID", _MyLib.ParentID))
						command.Parameters.Add(New SqlParameter("@DateTime", _MyLib.DateTime))
						command.Parameters.Add(New SqlParameter("@Thickness", _MyLib.Thickness))
						command.Parameters.Add(New SqlParameter("@Weight", _MyLib.Weight))
						command.Parameters.Add(New SqlParameter("@Length", _MyLib.Length))
						command.Parameters.Add(New SqlParameter("@Width", _MyLib.Width))
						command.Parameters.Add(New SqlParameter("@Employee", _MyLib.Employee))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datMeasurements SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal MeasurementID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@MeasurementID", MeasurementID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datMeasurements)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datMeasurements) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@MeasurementID", 0))
					command.Parameters.Add(New SqlParameter("@ParentID", _MyLib.ParentID))
					command.Parameters.Add(New SqlParameter("@DateTime", _MyLib.DateTime))
					command.Parameters.Add(New SqlParameter("@Thickness", _MyLib.Thickness))
					command.Parameters.Add(New SqlParameter("@Weight", _MyLib.Weight))
					command.Parameters.Add(New SqlParameter("@Length", _MyLib.Length))
					command.Parameters.Add(New SqlParameter("@Width", _MyLib.Width))
					command.Parameters.Add(New SqlParameter("@Employee", _MyLib.Employee))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal ParentID AS System.Int32, byVal DateTime AS System.DateTime, byVal Thickness AS System.Double, byVal Weight AS System.Double, byVal Length AS System.Double, byVal Width AS System.Double, byVal Employee AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@MeasurementID", 0))
					command.Parameters.Add(New SqlParameter("@ParentID", ParentID))
					command.Parameters.Add(New SqlParameter("@DateTime", DateTime))
					command.Parameters.Add(New SqlParameter("@Thickness", Thickness))
					command.Parameters.Add(New SqlParameter("@Weight", Weight))
					command.Parameters.Add(New SqlParameter("@Length", Length))
					command.Parameters.Add(New SqlParameter("@Width", Width))
					command.Parameters.Add(New SqlParameter("@Employee", Employee))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datPackages"
			Partial Public Class datPackages

	Private Shared Function SPBaseSQL() as String
		return "sp_datPackages_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal PackageID As System.Int32)
	SetDefaults()
	If PackageID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@PackageID", PackageID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.PackageID)) Then _PackageID = dR(Columns.PackageID)
							If Not IsDBNull(dR(Columns.PackageNumber)) Then _PackageNumber = dR(Columns.PackageNumber)
							If Not IsDBNull(dR(Columns.TrayID)) Then _TrayID = dR(Columns.TrayID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datPackages)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datPackages)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datPackages)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datPackages)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datPackages)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datPackages)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datPackages)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datPackages)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datPackages)
            Dim returnValue As New Generic.List(Of datPackages)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatPackages As New datPackages(0)
                            If Not IsDBNull(dR(Columns.PackageID)) Then MydatPackages.PackageID = dR(Columns.PackageID)
                            If Not IsDBNull(dR(Columns.PackageNumber)) Then MydatPackages.PackageNumber = dR(Columns.PackageNumber)
                            If Not IsDBNull(dR(Columns.TrayID)) Then MydatPackages.TrayID = dR(Columns.TrayID)
                            returnValue.Add(MydatPackages)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datPackages)
            Dim returnValue As New Generic.List(Of datPackages)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatPackages As New datPackages(0)
                            If Not IsDBNull(dR(Columns.PackageID)) Then MydatPackages.PackageID = dR(Columns.PackageID)
                            If Not IsDBNull(dR(Columns.PackageNumber)) Then MydatPackages.PackageNumber = dR(Columns.PackageNumber)
                            If Not IsDBNull(dR(Columns.TrayID)) Then MydatPackages.TrayID = dR(Columns.TrayID)
                            returnValue.Add(MydatPackages)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("PackageID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("PackageID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datPackages) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.PackageID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.PackageID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal PackageID AS System.Int32, byVal PackageNumber AS System.String, byVal TrayID AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF PackageID = 0 THEN
		ReturnValue = Insert(PackageNumber, TrayID)
	ELSE
	
		Dim MyLib as New datPackages(0)
				MyLib.PackageID = PackageID
				MyLib.PackageNumber = PackageNumber
				MyLib.TrayID = TrayID
		IF Update(MyLib) Then
			ReturnValue = MyLib.PackageID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datPackages) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datPackages(_MyLib.PackageID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@PackageID", _MyLib.PackageID))
						command.Parameters.Add(New SqlParameter("@PackageNumber", _MyLib.PackageNumber))
						command.Parameters.Add(New SqlParameter("@TrayID", _MyLib.TrayID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datPackages SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal PackageID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@PackageID", PackageID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datPackages)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datPackages) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@PackageID", 0))
					command.Parameters.Add(New SqlParameter("@PackageNumber", _MyLib.PackageNumber))
					command.Parameters.Add(New SqlParameter("@TrayID", _MyLib.TrayID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal PackageNumber AS System.String, byVal TrayID AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@PackageID", 0))
					command.Parameters.Add(New SqlParameter("@PackageNumber", PackageNumber))
					command.Parameters.Add(New SqlParameter("@TrayID", TrayID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datPeople"
			Partial Public Class datPeople

	Private Shared Function SPBaseSQL() as String
		return "sp_datPeople_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal PeopleID As System.Int32)
	SetDefaults()
	If PeopleID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@PeopleID", PeopleID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.PeopleID)) Then _PeopleID = dR(Columns.PeopleID)
							If Not IsDBNull(dR(Columns.Name)) Then _Name = dR(Columns.Name)
							If Not IsDBNull(dR(Columns.Notes)) Then _Notes = dR(Columns.Notes)
							If Not IsDBNull(dR(Columns.Email)) Then _Email = dR(Columns.Email)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datPeople)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datPeople)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datPeople)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datPeople)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datPeople)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datPeople)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datPeople)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datPeople)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datPeople)
            Dim returnValue As New Generic.List(Of datPeople)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatPeople As New datPeople(0)
                            If Not IsDBNull(dR(Columns.PeopleID)) Then MydatPeople.PeopleID = dR(Columns.PeopleID)
                            If Not IsDBNull(dR(Columns.Name)) Then MydatPeople.Name = dR(Columns.Name)
                            If Not IsDBNull(dR(Columns.Notes)) Then MydatPeople.Notes = dR(Columns.Notes)
                            If Not IsDBNull(dR(Columns.Email)) Then MydatPeople.Email = dR(Columns.Email)
                            returnValue.Add(MydatPeople)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datPeople)
            Dim returnValue As New Generic.List(Of datPeople)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatPeople As New datPeople(0)
                            If Not IsDBNull(dR(Columns.PeopleID)) Then MydatPeople.PeopleID = dR(Columns.PeopleID)
                            If Not IsDBNull(dR(Columns.Name)) Then MydatPeople.Name = dR(Columns.Name)
                            If Not IsDBNull(dR(Columns.Notes)) Then MydatPeople.Notes = dR(Columns.Notes)
                            If Not IsDBNull(dR(Columns.Email)) Then MydatPeople.Email = dR(Columns.Email)
                            returnValue.Add(MydatPeople)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("PeopleID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("PeopleID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datPeople) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.PeopleID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.PeopleID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal PeopleID AS System.Int32, byVal Name AS System.String, byVal Notes AS System.String, byVal Email AS System.String) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF PeopleID = 0 THEN
		ReturnValue = Insert(Name, Notes, Email)
	ELSE
	
		Dim MyLib as New datPeople(0)
				MyLib.PeopleID = PeopleID
				MyLib.Name = Name
				MyLib.Notes = Notes
				MyLib.Email = Email
		IF Update(MyLib) Then
			ReturnValue = MyLib.PeopleID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datPeople) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datPeople(_MyLib.PeopleID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@PeopleID", _MyLib.PeopleID))
						command.Parameters.Add(New SqlParameter("@Name", _MyLib.Name))
						command.Parameters.Add(New SqlParameter("@Notes", _MyLib.Notes))
						command.Parameters.Add(New SqlParameter("@Email", _MyLib.Email))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datPeople SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal PeopleID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@PeopleID", PeopleID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datPeople)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datPeople) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@PeopleID", 0))
					command.Parameters.Add(New SqlParameter("@Name", _MyLib.Name))
					command.Parameters.Add(New SqlParameter("@Notes", _MyLib.Notes))
					command.Parameters.Add(New SqlParameter("@Email", _MyLib.Email))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal Name AS System.String, byVal Notes AS System.String, byVal Email AS System.String) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@PeopleID", 0))
					command.Parameters.Add(New SqlParameter("@Name", Name))
					command.Parameters.Add(New SqlParameter("@Notes", Notes))
					command.Parameters.Add(New SqlParameter("@Email", Email))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datPhones"
			Partial Public Class datPhones

	Private Shared Function SPBaseSQL() as String
		return "sp_datPhones_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal PhoneID As System.Int32)
	SetDefaults()
	If PhoneID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@PhoneID", PhoneID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.PhoneID)) Then _PhoneID = dR(Columns.PhoneID)
							If Not IsDBNull(dR(Columns.PhoneNumber)) Then _PhoneNumber = dR(Columns.PhoneNumber)
							If Not IsDBNull(dR(Columns.Ext)) Then _Ext = dR(Columns.Ext)
							If Not IsDBNull(dR(Columns.PhoneTypeID)) Then _PhoneTypeID = dR(Columns.PhoneTypeID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datPhones)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datPhones)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datPhones)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datPhones)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datPhones)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datPhones)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datPhones)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datPhones)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datPhones)
            Dim returnValue As New Generic.List(Of datPhones)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatPhones As New datPhones(0)
                            If Not IsDBNull(dR(Columns.PhoneID)) Then MydatPhones.PhoneID = dR(Columns.PhoneID)
                            If Not IsDBNull(dR(Columns.PhoneNumber)) Then MydatPhones.PhoneNumber = dR(Columns.PhoneNumber)
                            If Not IsDBNull(dR(Columns.Ext)) Then MydatPhones.Ext = dR(Columns.Ext)
                            If Not IsDBNull(dR(Columns.PhoneTypeID)) Then MydatPhones.PhoneTypeID = dR(Columns.PhoneTypeID)
                            returnValue.Add(MydatPhones)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datPhones)
            Dim returnValue As New Generic.List(Of datPhones)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatPhones As New datPhones(0)
                            If Not IsDBNull(dR(Columns.PhoneID)) Then MydatPhones.PhoneID = dR(Columns.PhoneID)
                            If Not IsDBNull(dR(Columns.PhoneNumber)) Then MydatPhones.PhoneNumber = dR(Columns.PhoneNumber)
                            If Not IsDBNull(dR(Columns.Ext)) Then MydatPhones.Ext = dR(Columns.Ext)
                            If Not IsDBNull(dR(Columns.PhoneTypeID)) Then MydatPhones.PhoneTypeID = dR(Columns.PhoneTypeID)
                            returnValue.Add(MydatPhones)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("PhoneID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("PhoneID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datPhones) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.PhoneID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.PhoneID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal PhoneID AS System.Int32, byVal PhoneNumber AS System.String, byVal Ext AS System.String, byVal PhoneTypeID AS System.Byte) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF PhoneID = 0 THEN
		ReturnValue = Insert(PhoneNumber, Ext, PhoneTypeID)
	ELSE
	
		Dim MyLib as New datPhones(0)
				MyLib.PhoneID = PhoneID
				MyLib.PhoneNumber = PhoneNumber
				MyLib.Ext = Ext
				MyLib.PhoneTypeID = PhoneTypeID
		IF Update(MyLib) Then
			ReturnValue = MyLib.PhoneID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datPhones) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datPhones(_MyLib.PhoneID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@PhoneID", _MyLib.PhoneID))
						command.Parameters.Add(New SqlParameter("@PhoneNumber", _MyLib.PhoneNumber))
						command.Parameters.Add(New SqlParameter("@Ext", _MyLib.Ext))
						command.Parameters.Add(New SqlParameter("@PhoneTypeID", _MyLib.PhoneTypeID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datPhones SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal PhoneID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@PhoneID", PhoneID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datPhones)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datPhones) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@PhoneID", 0))
					command.Parameters.Add(New SqlParameter("@PhoneNumber", _MyLib.PhoneNumber))
					command.Parameters.Add(New SqlParameter("@Ext", _MyLib.Ext))
					command.Parameters.Add(New SqlParameter("@PhoneTypeID", _MyLib.PhoneTypeID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal PhoneNumber AS System.String, byVal Ext AS System.String, byVal PhoneTypeID AS System.Byte) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@PhoneID", 0))
					command.Parameters.Add(New SqlParameter("@PhoneNumber", PhoneNumber))
					command.Parameters.Add(New SqlParameter("@Ext", Ext))
					command.Parameters.Add(New SqlParameter("@PhoneTypeID", PhoneTypeID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datPurchaseOrders"
			Partial Public Class datPurchaseOrders

	Private Shared Function SPBaseSQL() as String
		return "sp_datPurchaseOrders_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal PurchaseID As System.Int32)
	SetDefaults()
	If PurchaseID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@PurchaseID", PurchaseID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.PurchaseID)) Then _PurchaseID = dR(Columns.PurchaseID)
							If Not IsDBNull(dR(Columns.PONumber)) Then _PONumber = dR(Columns.PONumber)
							If Not IsDBNull(dR(Columns.VendorID)) Then _VendorID = dR(Columns.VendorID)
							If Not IsDBNull(dR(Columns.Date)) Then _Date = dR(Columns.Date)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datPurchaseOrders)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datPurchaseOrders)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datPurchaseOrders)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datPurchaseOrders)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datPurchaseOrders)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datPurchaseOrders)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datPurchaseOrders)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datPurchaseOrders)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datPurchaseOrders)
            Dim returnValue As New Generic.List(Of datPurchaseOrders)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatPurchaseOrders As New datPurchaseOrders(0)
                            If Not IsDBNull(dR(Columns.PurchaseID)) Then MydatPurchaseOrders.PurchaseID = dR(Columns.PurchaseID)
                            If Not IsDBNull(dR(Columns.PONumber)) Then MydatPurchaseOrders.PONumber = dR(Columns.PONumber)
                            If Not IsDBNull(dR(Columns.VendorID)) Then MydatPurchaseOrders.VendorID = dR(Columns.VendorID)
                            If Not IsDBNull(dR(Columns.Date)) Then MydatPurchaseOrders.Date = dR(Columns.Date)
                            returnValue.Add(MydatPurchaseOrders)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datPurchaseOrders)
            Dim returnValue As New Generic.List(Of datPurchaseOrders)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatPurchaseOrders As New datPurchaseOrders(0)
                            If Not IsDBNull(dR(Columns.PurchaseID)) Then MydatPurchaseOrders.PurchaseID = dR(Columns.PurchaseID)
                            If Not IsDBNull(dR(Columns.PONumber)) Then MydatPurchaseOrders.PONumber = dR(Columns.PONumber)
                            If Not IsDBNull(dR(Columns.VendorID)) Then MydatPurchaseOrders.VendorID = dR(Columns.VendorID)
                            If Not IsDBNull(dR(Columns.Date)) Then MydatPurchaseOrders.Date = dR(Columns.Date)
                            returnValue.Add(MydatPurchaseOrders)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("PurchaseID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("PurchaseID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datPurchaseOrders) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.PurchaseID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.PurchaseID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal PurchaseID AS System.Int32, byVal PONumber AS System.Int32, byVal VendorID AS System.Int32, byVal Date AS System.DateTime) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF PurchaseID = 0 THEN
		ReturnValue = Insert(PONumber, VendorID, Date)
	ELSE
	
		Dim MyLib as New datPurchaseOrders(0)
				MyLib.PurchaseID = PurchaseID
				MyLib.PONumber = PONumber
				MyLib.VendorID = VendorID
				MyLib.Date = Date
		IF Update(MyLib) Then
			ReturnValue = MyLib.PurchaseID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datPurchaseOrders) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datPurchaseOrders(_MyLib.PurchaseID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@PurchaseID", _MyLib.PurchaseID))
						command.Parameters.Add(New SqlParameter("@PONumber", _MyLib.PONumber))
						command.Parameters.Add(New SqlParameter("@VendorID", _MyLib.VendorID))
						command.Parameters.Add(New SqlParameter("@Date", _MyLib.Date))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datPurchaseOrders SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal PurchaseID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@PurchaseID", PurchaseID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datPurchaseOrders)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datPurchaseOrders) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@PurchaseID", 0))
					command.Parameters.Add(New SqlParameter("@PONumber", _MyLib.PONumber))
					command.Parameters.Add(New SqlParameter("@VendorID", _MyLib.VendorID))
					command.Parameters.Add(New SqlParameter("@Date", _MyLib.Date))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal PONumber AS System.Int32, byVal VendorID AS System.Int32, byVal Date AS System.DateTime) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@PurchaseID", 0))
					command.Parameters.Add(New SqlParameter("@PONumber", PONumber))
					command.Parameters.Add(New SqlParameter("@VendorID", VendorID))
					command.Parameters.Add(New SqlParameter("@Date", Date))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datShipments"
			Partial Public Class datShipments

	Private Shared Function SPBaseSQL() as String
		return "sp_datShipments_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal ShipmentID As System.Int32)
	SetDefaults()
	If ShipmentID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ShipmentID", ShipmentID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.ShipmentID)) Then _ShipmentID = dR(Columns.ShipmentID)
							If Not IsDBNull(dR(Columns.AddressID)) Then _AddressID = dR(Columns.AddressID)
							If Not IsDBNull(dR(Columns.OrderNumber)) Then _OrderNumber = dR(Columns.OrderNumber)
							If Not IsDBNull(dR(Columns.VehicleID)) Then _VehicleID = dR(Columns.VehicleID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datShipments)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datShipments)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datShipments)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datShipments)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datShipments)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datShipments)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datShipments)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datShipments)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datShipments)
            Dim returnValue As New Generic.List(Of datShipments)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatShipments As New datShipments(0)
                            If Not IsDBNull(dR(Columns.ShipmentID)) Then MydatShipments.ShipmentID = dR(Columns.ShipmentID)
                            If Not IsDBNull(dR(Columns.AddressID)) Then MydatShipments.AddressID = dR(Columns.AddressID)
                            If Not IsDBNull(dR(Columns.OrderNumber)) Then MydatShipments.OrderNumber = dR(Columns.OrderNumber)
                            If Not IsDBNull(dR(Columns.VehicleID)) Then MydatShipments.VehicleID = dR(Columns.VehicleID)
                            returnValue.Add(MydatShipments)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datShipments)
            Dim returnValue As New Generic.List(Of datShipments)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatShipments As New datShipments(0)
                            If Not IsDBNull(dR(Columns.ShipmentID)) Then MydatShipments.ShipmentID = dR(Columns.ShipmentID)
                            If Not IsDBNull(dR(Columns.AddressID)) Then MydatShipments.AddressID = dR(Columns.AddressID)
                            If Not IsDBNull(dR(Columns.OrderNumber)) Then MydatShipments.OrderNumber = dR(Columns.OrderNumber)
                            If Not IsDBNull(dR(Columns.VehicleID)) Then MydatShipments.VehicleID = dR(Columns.VehicleID)
                            returnValue.Add(MydatShipments)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("ShipmentID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("ShipmentID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datShipments) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.ShipmentID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.ShipmentID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal ShipmentID AS System.Int32, byVal AddressID AS System.Int32, byVal OrderNumber AS System.Int32, byVal VehicleID AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF ShipmentID = 0 THEN
		ReturnValue = Insert(AddressID, OrderNumber, VehicleID)
	ELSE
	
		Dim MyLib as New datShipments(0)
				MyLib.ShipmentID = ShipmentID
				MyLib.AddressID = AddressID
				MyLib.OrderNumber = OrderNumber
				MyLib.VehicleID = VehicleID
		IF Update(MyLib) Then
			ReturnValue = MyLib.ShipmentID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datShipments) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datShipments(_MyLib.ShipmentID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ShipmentID", _MyLib.ShipmentID))
						command.Parameters.Add(New SqlParameter("@AddressID", _MyLib.AddressID))
						command.Parameters.Add(New SqlParameter("@OrderNumber", _MyLib.OrderNumber))
						command.Parameters.Add(New SqlParameter("@VehicleID", _MyLib.VehicleID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datShipments SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal ShipmentID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@ShipmentID", ShipmentID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datShipments)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datShipments) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ShipmentID", 0))
					command.Parameters.Add(New SqlParameter("@AddressID", _MyLib.AddressID))
					command.Parameters.Add(New SqlParameter("@OrderNumber", _MyLib.OrderNumber))
					command.Parameters.Add(New SqlParameter("@VehicleID", _MyLib.VehicleID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal AddressID AS System.Int32, byVal OrderNumber AS System.Int32, byVal VehicleID AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ShipmentID", 0))
					command.Parameters.Add(New SqlParameter("@AddressID", AddressID))
					command.Parameters.Add(New SqlParameter("@OrderNumber", OrderNumber))
					command.Parameters.Add(New SqlParameter("@VehicleID", VehicleID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datTrays"
			Partial Public Class datTrays

	Private Shared Function SPBaseSQL() as String
		return "sp_datTrays_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal TrayID As System.Int32)
	SetDefaults()
	If TrayID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@TrayID", TrayID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.TrayID)) Then _TrayID = dR(Columns.TrayID)
							If Not IsDBNull(dR(Columns.WorkStationID)) Then _WorkStationID = dR(Columns.WorkStationID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datTrays)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datTrays)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datTrays)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datTrays)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datTrays)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datTrays)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datTrays)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datTrays)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datTrays)
            Dim returnValue As New Generic.List(Of datTrays)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatTrays As New datTrays(0)
                            If Not IsDBNull(dR(Columns.TrayID)) Then MydatTrays.TrayID = dR(Columns.TrayID)
                            If Not IsDBNull(dR(Columns.WorkStationID)) Then MydatTrays.WorkStationID = dR(Columns.WorkStationID)
                            returnValue.Add(MydatTrays)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datTrays)
            Dim returnValue As New Generic.List(Of datTrays)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatTrays As New datTrays(0)
                            If Not IsDBNull(dR(Columns.TrayID)) Then MydatTrays.TrayID = dR(Columns.TrayID)
                            If Not IsDBNull(dR(Columns.WorkStationID)) Then MydatTrays.WorkStationID = dR(Columns.WorkStationID)
                            returnValue.Add(MydatTrays)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("TrayID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("TrayID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datTrays) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.TrayID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.TrayID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal TrayID AS System.Int32, byVal WorkStationID AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF TrayID = 0 THEN
		ReturnValue = Insert(WorkStationID)
	ELSE
	
		Dim MyLib as New datTrays(0)
				MyLib.TrayID = TrayID
				MyLib.WorkStationID = WorkStationID
		IF Update(MyLib) Then
			ReturnValue = MyLib.TrayID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datTrays) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datTrays(_MyLib.TrayID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@TrayID", _MyLib.TrayID))
						command.Parameters.Add(New SqlParameter("@WorkStationID", _MyLib.WorkStationID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datTrays SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal TrayID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@TrayID", TrayID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datTrays)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datTrays) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@TrayID", 0))
					command.Parameters.Add(New SqlParameter("@WorkStationID", _MyLib.WorkStationID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal WorkStationID AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@TrayID", 0))
					command.Parameters.Add(New SqlParameter("@WorkStationID", WorkStationID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datVehicleCleaning"
			Partial Public Class datVehicleCleaning

	Private Shared Function SPBaseSQL() as String
		return "sp_datVehicleCleaning_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal CleaningID As System.Int32)
	SetDefaults()
	If CleaningID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@CleaningID", CleaningID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.CleaningID)) Then _CleaningID = dR(Columns.CleaningID)
							If Not IsDBNull(dR(Columns.VehicleID)) Then _VehicleID = dR(Columns.VehicleID)
							If Not IsDBNull(dR(Columns.EmployeeID)) Then _EmployeeID = dR(Columns.EmployeeID)
							If Not IsDBNull(dR(Columns.Date)) Then _Date = dR(Columns.Date)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datVehicleCleaning)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datVehicleCleaning)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datVehicleCleaning)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datVehicleCleaning)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datVehicleCleaning)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datVehicleCleaning)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datVehicleCleaning)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datVehicleCleaning)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datVehicleCleaning)
            Dim returnValue As New Generic.List(Of datVehicleCleaning)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatVehicleCleaning As New datVehicleCleaning(0)
                            If Not IsDBNull(dR(Columns.CleaningID)) Then MydatVehicleCleaning.CleaningID = dR(Columns.CleaningID)
                            If Not IsDBNull(dR(Columns.VehicleID)) Then MydatVehicleCleaning.VehicleID = dR(Columns.VehicleID)
                            If Not IsDBNull(dR(Columns.EmployeeID)) Then MydatVehicleCleaning.EmployeeID = dR(Columns.EmployeeID)
                            If Not IsDBNull(dR(Columns.Date)) Then MydatVehicleCleaning.Date = dR(Columns.Date)
                            returnValue.Add(MydatVehicleCleaning)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datVehicleCleaning)
            Dim returnValue As New Generic.List(Of datVehicleCleaning)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatVehicleCleaning As New datVehicleCleaning(0)
                            If Not IsDBNull(dR(Columns.CleaningID)) Then MydatVehicleCleaning.CleaningID = dR(Columns.CleaningID)
                            If Not IsDBNull(dR(Columns.VehicleID)) Then MydatVehicleCleaning.VehicleID = dR(Columns.VehicleID)
                            If Not IsDBNull(dR(Columns.EmployeeID)) Then MydatVehicleCleaning.EmployeeID = dR(Columns.EmployeeID)
                            If Not IsDBNull(dR(Columns.Date)) Then MydatVehicleCleaning.Date = dR(Columns.Date)
                            returnValue.Add(MydatVehicleCleaning)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("CleaningID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("CleaningID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datVehicleCleaning) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.CleaningID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.CleaningID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal CleaningID AS System.Int32, byVal VehicleID AS System.Int32, byVal EmployeeID AS System.Int32, byVal Date AS System.DateTime) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF CleaningID = 0 THEN
		ReturnValue = Insert(VehicleID, EmployeeID, Date)
	ELSE
	
		Dim MyLib as New datVehicleCleaning(0)
				MyLib.CleaningID = CleaningID
				MyLib.VehicleID = VehicleID
				MyLib.EmployeeID = EmployeeID
				MyLib.Date = Date
		IF Update(MyLib) Then
			ReturnValue = MyLib.CleaningID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datVehicleCleaning) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datVehicleCleaning(_MyLib.CleaningID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@CleaningID", _MyLib.CleaningID))
						command.Parameters.Add(New SqlParameter("@VehicleID", _MyLib.VehicleID))
						command.Parameters.Add(New SqlParameter("@EmployeeID", _MyLib.EmployeeID))
						command.Parameters.Add(New SqlParameter("@Date", _MyLib.Date))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datVehicleCleaning SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal CleaningID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@CleaningID", CleaningID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datVehicleCleaning)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datVehicleCleaning) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@CleaningID", 0))
					command.Parameters.Add(New SqlParameter("@VehicleID", _MyLib.VehicleID))
					command.Parameters.Add(New SqlParameter("@EmployeeID", _MyLib.EmployeeID))
					command.Parameters.Add(New SqlParameter("@Date", _MyLib.Date))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal VehicleID AS System.Int32, byVal EmployeeID AS System.Int32, byVal Date AS System.DateTime) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@CleaningID", 0))
					command.Parameters.Add(New SqlParameter("@VehicleID", VehicleID))
					command.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
					command.Parameters.Add(New SqlParameter("@Date", Date))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datVehicles"
			Partial Public Class datVehicles

	Private Shared Function SPBaseSQL() as String
		return "sp_datVehicles_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal VehicleID As System.Int32)
	SetDefaults()
	If VehicleID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@VehicleID", VehicleID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.VehicleID)) Then _VehicleID = dR(Columns.VehicleID)
							If Not IsDBNull(dR(Columns.LicensePlate)) Then _LicensePlate = dR(Columns.LicensePlate)
							If Not IsDBNull(dR(Columns.TypeID)) Then _TypeID = dR(Columns.TypeID)
							If Not IsDBNull(dR(Columns.DatePurchased)) Then _DatePurchased = dR(Columns.DatePurchased)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datVehicles)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datVehicles)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datVehicles)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datVehicles)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datVehicles)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datVehicles)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datVehicles)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datVehicles)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datVehicles)
            Dim returnValue As New Generic.List(Of datVehicles)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatVehicles As New datVehicles(0)
                            If Not IsDBNull(dR(Columns.VehicleID)) Then MydatVehicles.VehicleID = dR(Columns.VehicleID)
                            If Not IsDBNull(dR(Columns.LicensePlate)) Then MydatVehicles.LicensePlate = dR(Columns.LicensePlate)
                            If Not IsDBNull(dR(Columns.TypeID)) Then MydatVehicles.TypeID = dR(Columns.TypeID)
                            If Not IsDBNull(dR(Columns.DatePurchased)) Then MydatVehicles.DatePurchased = dR(Columns.DatePurchased)
                            returnValue.Add(MydatVehicles)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datVehicles)
            Dim returnValue As New Generic.List(Of datVehicles)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatVehicles As New datVehicles(0)
                            If Not IsDBNull(dR(Columns.VehicleID)) Then MydatVehicles.VehicleID = dR(Columns.VehicleID)
                            If Not IsDBNull(dR(Columns.LicensePlate)) Then MydatVehicles.LicensePlate = dR(Columns.LicensePlate)
                            If Not IsDBNull(dR(Columns.TypeID)) Then MydatVehicles.TypeID = dR(Columns.TypeID)
                            If Not IsDBNull(dR(Columns.DatePurchased)) Then MydatVehicles.DatePurchased = dR(Columns.DatePurchased)
                            returnValue.Add(MydatVehicles)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("VehicleID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("VehicleID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datVehicles) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.VehicleID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.VehicleID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal VehicleID AS System.Int32, byVal LicensePlate AS System.String, byVal TypeID AS System.Int32, byVal DatePurchased AS System.DateTime) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF VehicleID = 0 THEN
		ReturnValue = Insert(LicensePlate, TypeID, DatePurchased)
	ELSE
	
		Dim MyLib as New datVehicles(0)
				MyLib.VehicleID = VehicleID
				MyLib.LicensePlate = LicensePlate
				MyLib.TypeID = TypeID
				MyLib.DatePurchased = DatePurchased
		IF Update(MyLib) Then
			ReturnValue = MyLib.VehicleID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datVehicles) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datVehicles(_MyLib.VehicleID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@VehicleID", _MyLib.VehicleID))
						command.Parameters.Add(New SqlParameter("@LicensePlate", _MyLib.LicensePlate))
						command.Parameters.Add(New SqlParameter("@TypeID", _MyLib.TypeID))
						command.Parameters.Add(New SqlParameter("@DatePurchased", _MyLib.DatePurchased))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datVehicles SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal VehicleID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@VehicleID", VehicleID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datVehicles)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datVehicles) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@VehicleID", 0))
					command.Parameters.Add(New SqlParameter("@LicensePlate", _MyLib.LicensePlate))
					command.Parameters.Add(New SqlParameter("@TypeID", _MyLib.TypeID))
					command.Parameters.Add(New SqlParameter("@DatePurchased", _MyLib.DatePurchased))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal LicensePlate AS System.String, byVal TypeID AS System.Int32, byVal DatePurchased AS System.DateTime) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@VehicleID", 0))
					command.Parameters.Add(New SqlParameter("@LicensePlate", LicensePlate))
					command.Parameters.Add(New SqlParameter("@TypeID", TypeID))
					command.Parameters.Add(New SqlParameter("@DatePurchased", DatePurchased))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class datVendors"
			Partial Public Class datVendors

	Private Shared Function SPBaseSQL() as String
		return "sp_datVendors_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal VendorID As System.Int32)
	SetDefaults()
	If VendorID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@VendorID", VendorID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.VendorID)) Then _VendorID = dR(Columns.VendorID)
							If Not IsDBNull(dR(Columns.VendorName)) Then _VendorName = dR(Columns.VendorName)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of datVendors)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datVendors)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of datVendors)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datVendors)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datVendors)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datVendors)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datVendors)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of datVendors)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of datVendors)
            Dim returnValue As New Generic.List(Of datVendors)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatVendors As New datVendors(0)
                            If Not IsDBNull(dR(Columns.VendorID)) Then MydatVendors.VendorID = dR(Columns.VendorID)
                            If Not IsDBNull(dR(Columns.VendorName)) Then MydatVendors.VendorName = dR(Columns.VendorName)
                            returnValue.Add(MydatVendors)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of datVendors)
            Dim returnValue As New Generic.List(Of datVendors)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MydatVendors As New datVendors(0)
                            If Not IsDBNull(dR(Columns.VendorID)) Then MydatVendors.VendorID = dR(Columns.VendorID)
                            If Not IsDBNull(dR(Columns.VendorName)) Then MydatVendors.VendorName = dR(Columns.VendorName)
                            returnValue.Add(MydatVendors)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("VendorID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("VendorID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as datVendors) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.VendorID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.VendorID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal VendorID AS System.Int32, byVal VendorName AS System.String) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF VendorID = 0 THEN
		ReturnValue = Insert(VendorName)
	ELSE
	
		Dim MyLib as New datVendors(0)
				MyLib.VendorID = VendorID
				MyLib.VendorName = VendorName
		IF Update(MyLib) Then
			ReturnValue = MyLib.VendorID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as datVendors) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New datVendors(_MyLib.VendorID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@VendorID", _MyLib.VendorID))
						command.Parameters.Add(New SqlParameter("@VendorName", _MyLib.VendorName))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE datVendors SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal VendorID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@VendorID", VendorID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of datVendors)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as datVendors) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@VendorID", 0))
					command.Parameters.Add(New SqlParameter("@VendorName", _MyLib.VendorName))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal VendorName AS System.String) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@VendorID", 0))
					command.Parameters.Add(New SqlParameter("@VendorName", VendorName))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class HACCPTemps"
			Partial Public Class HACCPTemps

	Private Shared Function SPBaseSQL() as String
		return "sp_HACCPTemps_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal TempID As System.Int32)
	SetDefaults()
	If TempID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@TempID", TempID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.TempID)) Then _TempID = dR(Columns.TempID)
							If Not IsDBNull(dR(Columns.ParentID)) Then _ParentID = dR(Columns.ParentID)
							If Not IsDBNull(dR(Columns.Temp)) Then _Temp = dR(Columns.Temp)
							If Not IsDBNull(dR(Columns.DateTime)) Then _DateTime = dR(Columns.DateTime)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of HACCPTemps)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of HACCPTemps)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of HACCPTemps)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of HACCPTemps)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of HACCPTemps)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of HACCPTemps)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of HACCPTemps)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of HACCPTemps)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of HACCPTemps)
            Dim returnValue As New Generic.List(Of HACCPTemps)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyHACCPTemps As New HACCPTemps(0)
                            If Not IsDBNull(dR(Columns.TempID)) Then MyHACCPTemps.TempID = dR(Columns.TempID)
                            If Not IsDBNull(dR(Columns.ParentID)) Then MyHACCPTemps.ParentID = dR(Columns.ParentID)
                            If Not IsDBNull(dR(Columns.Temp)) Then MyHACCPTemps.Temp = dR(Columns.Temp)
                            If Not IsDBNull(dR(Columns.DateTime)) Then MyHACCPTemps.DateTime = dR(Columns.DateTime)
                            returnValue.Add(MyHACCPTemps)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of HACCPTemps)
            Dim returnValue As New Generic.List(Of HACCPTemps)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyHACCPTemps As New HACCPTemps(0)
                            If Not IsDBNull(dR(Columns.TempID)) Then MyHACCPTemps.TempID = dR(Columns.TempID)
                            If Not IsDBNull(dR(Columns.ParentID)) Then MyHACCPTemps.ParentID = dR(Columns.ParentID)
                            If Not IsDBNull(dR(Columns.Temp)) Then MyHACCPTemps.Temp = dR(Columns.Temp)
                            If Not IsDBNull(dR(Columns.DateTime)) Then MyHACCPTemps.DateTime = dR(Columns.DateTime)
                            returnValue.Add(MyHACCPTemps)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("TempID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("TempID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as HACCPTemps) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.TempID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.TempID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal TempID AS System.Int32, byVal ParentID AS System.Int32, byVal Temp AS System.Double, byVal DateTime AS System.DateTime) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF TempID = 0 THEN
		ReturnValue = Insert(ParentID, Temp, DateTime)
	ELSE
	
		Dim MyLib as New HACCPTemps(0)
				MyLib.TempID = TempID
				MyLib.ParentID = ParentID
				MyLib.Temp = Temp
				MyLib.DateTime = DateTime
		IF Update(MyLib) Then
			ReturnValue = MyLib.TempID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as HACCPTemps) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New HACCPTemps(_MyLib.TempID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@TempID", _MyLib.TempID))
						command.Parameters.Add(New SqlParameter("@ParentID", _MyLib.ParentID))
						command.Parameters.Add(New SqlParameter("@Temp", _MyLib.Temp))
						command.Parameters.Add(New SqlParameter("@DateTime", _MyLib.DateTime))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE HACCPTemps SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal TempID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@TempID", TempID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of HACCPTemps)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as HACCPTemps) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@TempID", 0))
					command.Parameters.Add(New SqlParameter("@ParentID", _MyLib.ParentID))
					command.Parameters.Add(New SqlParameter("@Temp", _MyLib.Temp))
					command.Parameters.Add(New SqlParameter("@DateTime", _MyLib.DateTime))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal ParentID AS System.Int32, byVal Temp AS System.Double, byVal DateTime AS System.DateTime) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@TempID", 0))
					command.Parameters.Add(New SqlParameter("@ParentID", ParentID))
					command.Parameters.Add(New SqlParameter("@Temp", Temp))
					command.Parameters.Add(New SqlParameter("@DateTime", DateTime))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class HACCPTimes"
			Partial Public Class HACCPTimes

	Private Shared Function SPBaseSQL() as String
		return "sp_HACCPTimes_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal TimeID As System.Int32)
	SetDefaults()
	If TimeID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@TimeID", TimeID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.TimeID)) Then _TimeID = dR(Columns.TimeID)
							If Not IsDBNull(dR(Columns.ParentID)) Then _ParentID = dR(Columns.ParentID)
							If Not IsDBNull(dR(Columns.DateTime)) Then _DateTime = dR(Columns.DateTime)
							If Not IsDBNull(dR(Columns.TimeTypeID)) Then _TimeTypeID = dR(Columns.TimeTypeID)
							If Not IsDBNull(dR(Columns.EmployeeID)) Then _EmployeeID = dR(Columns.EmployeeID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of HACCPTimes)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of HACCPTimes)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of HACCPTimes)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of HACCPTimes)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of HACCPTimes)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of HACCPTimes)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of HACCPTimes)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of HACCPTimes)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of HACCPTimes)
            Dim returnValue As New Generic.List(Of HACCPTimes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyHACCPTimes As New HACCPTimes(0)
                            If Not IsDBNull(dR(Columns.TimeID)) Then MyHACCPTimes.TimeID = dR(Columns.TimeID)
                            If Not IsDBNull(dR(Columns.ParentID)) Then MyHACCPTimes.ParentID = dR(Columns.ParentID)
                            If Not IsDBNull(dR(Columns.DateTime)) Then MyHACCPTimes.DateTime = dR(Columns.DateTime)
                            If Not IsDBNull(dR(Columns.TimeTypeID)) Then MyHACCPTimes.TimeTypeID = dR(Columns.TimeTypeID)
                            If Not IsDBNull(dR(Columns.EmployeeID)) Then MyHACCPTimes.EmployeeID = dR(Columns.EmployeeID)
                            returnValue.Add(MyHACCPTimes)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of HACCPTimes)
            Dim returnValue As New Generic.List(Of HACCPTimes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyHACCPTimes As New HACCPTimes(0)
                            If Not IsDBNull(dR(Columns.TimeID)) Then MyHACCPTimes.TimeID = dR(Columns.TimeID)
                            If Not IsDBNull(dR(Columns.ParentID)) Then MyHACCPTimes.ParentID = dR(Columns.ParentID)
                            If Not IsDBNull(dR(Columns.DateTime)) Then MyHACCPTimes.DateTime = dR(Columns.DateTime)
                            If Not IsDBNull(dR(Columns.TimeTypeID)) Then MyHACCPTimes.TimeTypeID = dR(Columns.TimeTypeID)
                            If Not IsDBNull(dR(Columns.EmployeeID)) Then MyHACCPTimes.EmployeeID = dR(Columns.EmployeeID)
                            returnValue.Add(MyHACCPTimes)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("TimeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("TimeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as HACCPTimes) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.TimeID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.TimeID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal TimeID AS System.Int32, byVal ParentID AS System.Int32, byVal DateTime AS System.DateTime, byVal TimeTypeID AS System.Int32, byVal EmployeeID AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF TimeID = 0 THEN
		ReturnValue = Insert(ParentID, DateTime, TimeTypeID, EmployeeID)
	ELSE
	
		Dim MyLib as New HACCPTimes(0)
				MyLib.TimeID = TimeID
				MyLib.ParentID = ParentID
				MyLib.DateTime = DateTime
				MyLib.TimeTypeID = TimeTypeID
				MyLib.EmployeeID = EmployeeID
		IF Update(MyLib) Then
			ReturnValue = MyLib.TimeID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as HACCPTimes) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New HACCPTimes(_MyLib.TimeID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@TimeID", _MyLib.TimeID))
						command.Parameters.Add(New SqlParameter("@ParentID", _MyLib.ParentID))
						command.Parameters.Add(New SqlParameter("@DateTime", _MyLib.DateTime))
						command.Parameters.Add(New SqlParameter("@TimeTypeID", _MyLib.TimeTypeID))
						command.Parameters.Add(New SqlParameter("@EmployeeID", _MyLib.EmployeeID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE HACCPTimes SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal TimeID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@TimeID", TimeID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of HACCPTimes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as HACCPTimes) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@TimeID", 0))
					command.Parameters.Add(New SqlParameter("@ParentID", _MyLib.ParentID))
					command.Parameters.Add(New SqlParameter("@DateTime", _MyLib.DateTime))
					command.Parameters.Add(New SqlParameter("@TimeTypeID", _MyLib.TimeTypeID))
					command.Parameters.Add(New SqlParameter("@EmployeeID", _MyLib.EmployeeID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal ParentID AS System.Int32, byVal DateTime AS System.DateTime, byVal TimeTypeID AS System.Int32, byVal EmployeeID AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@TimeID", 0))
					command.Parameters.Add(New SqlParameter("@ParentID", ParentID))
					command.Parameters.Add(New SqlParameter("@DateTime", DateTime))
					command.Parameters.Add(New SqlParameter("@TimeTypeID", TimeTypeID))
					command.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class jncAssembly"
			Partial Public Class jncAssembly

	Private Shared Function SPBaseSQL() as String
		return "sp_jncAssembly_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal IngredientAssemblyID As System.Int32)
	SetDefaults()
	If IngredientAssemblyID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@IngredientAssemblyID", IngredientAssemblyID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.IngredientAssemblyID)) Then _IngredientAssemblyID = dR(Columns.IngredientAssemblyID)
							If Not IsDBNull(dR(Columns.AssemblyID)) Then _AssemblyID = dR(Columns.AssemblyID)
							If Not IsDBNull(dR(Columns.Quantity)) Then _Quantity = dR(Columns.Quantity)
							If Not IsDBNull(dR(Columns.UnitsID)) Then _UnitsID = dR(Columns.UnitsID)
							If Not IsDBNull(dR(Columns.IngInvID)) Then _IngInvID = dR(Columns.IngInvID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of jncAssembly)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of jncAssembly)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of jncAssembly)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncAssembly)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncAssembly)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncAssembly)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncAssembly)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of jncAssembly)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncAssembly)
            Dim returnValue As New Generic.List(Of jncAssembly)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyjncAssembly As New jncAssembly(0)
                            If Not IsDBNull(dR(Columns.IngredientAssemblyID)) Then MyjncAssembly.IngredientAssemblyID = dR(Columns.IngredientAssemblyID)
                            If Not IsDBNull(dR(Columns.AssemblyID)) Then MyjncAssembly.AssemblyID = dR(Columns.AssemblyID)
                            If Not IsDBNull(dR(Columns.Quantity)) Then MyjncAssembly.Quantity = dR(Columns.Quantity)
                            If Not IsDBNull(dR(Columns.UnitsID)) Then MyjncAssembly.UnitsID = dR(Columns.UnitsID)
                            If Not IsDBNull(dR(Columns.IngInvID)) Then MyjncAssembly.IngInvID = dR(Columns.IngInvID)
                            returnValue.Add(MyjncAssembly)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncAssembly)
            Dim returnValue As New Generic.List(Of jncAssembly)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyjncAssembly As New jncAssembly(0)
                            If Not IsDBNull(dR(Columns.IngredientAssemblyID)) Then MyjncAssembly.IngredientAssemblyID = dR(Columns.IngredientAssemblyID)
                            If Not IsDBNull(dR(Columns.AssemblyID)) Then MyjncAssembly.AssemblyID = dR(Columns.AssemblyID)
                            If Not IsDBNull(dR(Columns.Quantity)) Then MyjncAssembly.Quantity = dR(Columns.Quantity)
                            If Not IsDBNull(dR(Columns.UnitsID)) Then MyjncAssembly.UnitsID = dR(Columns.UnitsID)
                            If Not IsDBNull(dR(Columns.IngInvID)) Then MyjncAssembly.IngInvID = dR(Columns.IngInvID)
                            returnValue.Add(MyjncAssembly)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("IngredientAssemblyID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("IngredientAssemblyID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as jncAssembly) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.IngredientAssemblyID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.IngredientAssemblyID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal IngredientAssemblyID AS System.Int32, byVal AssemblyID AS System.Int32, byVal Quantity AS System.Double, byVal UnitsID AS System.Int32, byVal IngInvID AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF IngredientAssemblyID = 0 THEN
		ReturnValue = Insert(AssemblyID, Quantity, UnitsID, IngInvID)
	ELSE
	
		Dim MyLib as New jncAssembly(0)
				MyLib.IngredientAssemblyID = IngredientAssemblyID
				MyLib.AssemblyID = AssemblyID
				MyLib.Quantity = Quantity
				MyLib.UnitsID = UnitsID
				MyLib.IngInvID = IngInvID
		IF Update(MyLib) Then
			ReturnValue = MyLib.IngredientAssemblyID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as jncAssembly) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New jncAssembly(_MyLib.IngredientAssemblyID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@IngredientAssemblyID", _MyLib.IngredientAssemblyID))
						command.Parameters.Add(New SqlParameter("@AssemblyID", _MyLib.AssemblyID))
						command.Parameters.Add(New SqlParameter("@Quantity", _MyLib.Quantity))
						command.Parameters.Add(New SqlParameter("@UnitsID", _MyLib.UnitsID))
						command.Parameters.Add(New SqlParameter("@IngInvID", _MyLib.IngInvID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE jncAssembly SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal IngredientAssemblyID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@IngredientAssemblyID", IngredientAssemblyID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of jncAssembly)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as jncAssembly) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@IngredientAssemblyID", 0))
					command.Parameters.Add(New SqlParameter("@AssemblyID", _MyLib.AssemblyID))
					command.Parameters.Add(New SqlParameter("@Quantity", _MyLib.Quantity))
					command.Parameters.Add(New SqlParameter("@UnitsID", _MyLib.UnitsID))
					command.Parameters.Add(New SqlParameter("@IngInvID", _MyLib.IngInvID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal AssemblyID AS System.Int32, byVal Quantity AS System.Double, byVal UnitsID AS System.Int32, byVal IngInvID AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@IngredientAssemblyID", 0))
					command.Parameters.Add(New SqlParameter("@AssemblyID", AssemblyID))
					command.Parameters.Add(New SqlParameter("@Quantity", Quantity))
					command.Parameters.Add(New SqlParameter("@UnitsID", UnitsID))
					command.Parameters.Add(New SqlParameter("@IngInvID", IngInvID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class jncClientAddresses"
			Partial Public Class jncClientAddresses

	Private Shared Function SPBaseSQL() as String
		return "sp_jncClientAddresses_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal ID As System.Int32)
	SetDefaults()
	If ID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ID", ID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.ID)) Then _ID = dR(Columns.ID)
							If Not IsDBNull(dR(Columns.ClientID)) Then _ClientID = dR(Columns.ClientID)
							If Not IsDBNull(dR(Columns.AddressID)) Then _AddressID = dR(Columns.AddressID)
							If Not IsDBNull(dR(Columns.AddressType)) Then _AddressType = dR(Columns.AddressType)
							If Not IsDBNull(dR(Columns.Notes)) Then _Notes = dR(Columns.Notes)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of jncClientAddresses)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of jncClientAddresses)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of jncClientAddresses)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncClientAddresses)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncClientAddresses)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncClientAddresses)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncClientAddresses)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of jncClientAddresses)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncClientAddresses)
            Dim returnValue As New Generic.List(Of jncClientAddresses)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyjncClientAddresses As New jncClientAddresses(0)
                            If Not IsDBNull(dR(Columns.ID)) Then MyjncClientAddresses.ID = dR(Columns.ID)
                            If Not IsDBNull(dR(Columns.ClientID)) Then MyjncClientAddresses.ClientID = dR(Columns.ClientID)
                            If Not IsDBNull(dR(Columns.AddressID)) Then MyjncClientAddresses.AddressID = dR(Columns.AddressID)
                            If Not IsDBNull(dR(Columns.AddressType)) Then MyjncClientAddresses.AddressType = dR(Columns.AddressType)
                            If Not IsDBNull(dR(Columns.Notes)) Then MyjncClientAddresses.Notes = dR(Columns.Notes)
                            returnValue.Add(MyjncClientAddresses)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncClientAddresses)
            Dim returnValue As New Generic.List(Of jncClientAddresses)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyjncClientAddresses As New jncClientAddresses(0)
                            If Not IsDBNull(dR(Columns.ID)) Then MyjncClientAddresses.ID = dR(Columns.ID)
                            If Not IsDBNull(dR(Columns.ClientID)) Then MyjncClientAddresses.ClientID = dR(Columns.ClientID)
                            If Not IsDBNull(dR(Columns.AddressID)) Then MyjncClientAddresses.AddressID = dR(Columns.AddressID)
                            If Not IsDBNull(dR(Columns.AddressType)) Then MyjncClientAddresses.AddressType = dR(Columns.AddressType)
                            If Not IsDBNull(dR(Columns.Notes)) Then MyjncClientAddresses.Notes = dR(Columns.Notes)
                            returnValue.Add(MyjncClientAddresses)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("ID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("ID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as jncClientAddresses) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.ID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.ID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal ID AS System.Int32, byVal ClientID AS System.Int32, byVal AddressID AS System.Int32, byVal AddressType AS System.Int32, byVal Notes AS System.String) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF ID = 0 THEN
		ReturnValue = Insert(ClientID, AddressID, AddressType, Notes)
	ELSE
	
		Dim MyLib as New jncClientAddresses(0)
				MyLib.ID = ID
				MyLib.ClientID = ClientID
				MyLib.AddressID = AddressID
				MyLib.AddressType = AddressType
				MyLib.Notes = Notes
		IF Update(MyLib) Then
			ReturnValue = MyLib.ID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as jncClientAddresses) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New jncClientAddresses(_MyLib.ID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ID", _MyLib.ID))
						command.Parameters.Add(New SqlParameter("@ClientID", _MyLib.ClientID))
						command.Parameters.Add(New SqlParameter("@AddressID", _MyLib.AddressID))
						command.Parameters.Add(New SqlParameter("@AddressType", _MyLib.AddressType))
						command.Parameters.Add(New SqlParameter("@Notes", _MyLib.Notes))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE jncClientAddresses SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal ID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@ID", ID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of jncClientAddresses)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as jncClientAddresses) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ID", 0))
					command.Parameters.Add(New SqlParameter("@ClientID", _MyLib.ClientID))
					command.Parameters.Add(New SqlParameter("@AddressID", _MyLib.AddressID))
					command.Parameters.Add(New SqlParameter("@AddressType", _MyLib.AddressType))
					command.Parameters.Add(New SqlParameter("@Notes", _MyLib.Notes))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal ClientID AS System.Int32, byVal AddressID AS System.Int32, byVal AddressType AS System.Int32, byVal Notes AS System.String) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ID", 0))
					command.Parameters.Add(New SqlParameter("@ClientID", ClientID))
					command.Parameters.Add(New SqlParameter("@AddressID", AddressID))
					command.Parameters.Add(New SqlParameter("@AddressType", AddressType))
					command.Parameters.Add(New SqlParameter("@Notes", Notes))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class jncClientContacts"
			Partial Public Class jncClientContacts

	Private Shared Function SPBaseSQL() as String
		return "sp_jncClientContacts_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal ID As System.Int32)
	SetDefaults()
	If ID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ID", ID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.ID)) Then _ID = dR(Columns.ID)
							If Not IsDBNull(dR(Columns.ClientID)) Then _ClientID = dR(Columns.ClientID)
							If Not IsDBNull(dR(Columns.ContactID)) Then _ContactID = dR(Columns.ContactID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of jncClientContacts)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of jncClientContacts)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of jncClientContacts)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncClientContacts)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncClientContacts)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncClientContacts)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncClientContacts)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of jncClientContacts)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncClientContacts)
            Dim returnValue As New Generic.List(Of jncClientContacts)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyjncClientContacts As New jncClientContacts(0)
                            If Not IsDBNull(dR(Columns.ID)) Then MyjncClientContacts.ID = dR(Columns.ID)
                            If Not IsDBNull(dR(Columns.ClientID)) Then MyjncClientContacts.ClientID = dR(Columns.ClientID)
                            If Not IsDBNull(dR(Columns.ContactID)) Then MyjncClientContacts.ContactID = dR(Columns.ContactID)
                            returnValue.Add(MyjncClientContacts)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncClientContacts)
            Dim returnValue As New Generic.List(Of jncClientContacts)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyjncClientContacts As New jncClientContacts(0)
                            If Not IsDBNull(dR(Columns.ID)) Then MyjncClientContacts.ID = dR(Columns.ID)
                            If Not IsDBNull(dR(Columns.ClientID)) Then MyjncClientContacts.ClientID = dR(Columns.ClientID)
                            If Not IsDBNull(dR(Columns.ContactID)) Then MyjncClientContacts.ContactID = dR(Columns.ContactID)
                            returnValue.Add(MyjncClientContacts)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("ID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("ID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as jncClientContacts) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.ID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.ID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal ID AS System.Int32, byVal ClientID AS System.Int32, byVal ContactID AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF ID = 0 THEN
		ReturnValue = Insert(ClientID, ContactID)
	ELSE
	
		Dim MyLib as New jncClientContacts(0)
				MyLib.ID = ID
				MyLib.ClientID = ClientID
				MyLib.ContactID = ContactID
		IF Update(MyLib) Then
			ReturnValue = MyLib.ID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as jncClientContacts) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New jncClientContacts(_MyLib.ID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ID", _MyLib.ID))
						command.Parameters.Add(New SqlParameter("@ClientID", _MyLib.ClientID))
						command.Parameters.Add(New SqlParameter("@ContactID", _MyLib.ContactID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE jncClientContacts SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal ID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@ID", ID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of jncClientContacts)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as jncClientContacts) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ID", 0))
					command.Parameters.Add(New SqlParameter("@ClientID", _MyLib.ClientID))
					command.Parameters.Add(New SqlParameter("@ContactID", _MyLib.ContactID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal ClientID AS System.Int32, byVal ContactID AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ID", 0))
					command.Parameters.Add(New SqlParameter("@ClientID", ClientID))
					command.Parameters.Add(New SqlParameter("@ContactID", ContactID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class jncEmployeeContacts"
			Partial Public Class jncEmployeeContacts

	Private Shared Function SPBaseSQL() as String
		return "sp_jncEmployeeContacts_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal ID As System.Int32)
	SetDefaults()
	If ID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ID", ID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.ID)) Then _ID = dR(Columns.ID)
							If Not IsDBNull(dR(Columns.EmployeeID)) Then _EmployeeID = dR(Columns.EmployeeID)
							If Not IsDBNull(dR(Columns.ContactID)) Then _ContactID = dR(Columns.ContactID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of jncEmployeeContacts)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of jncEmployeeContacts)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of jncEmployeeContacts)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncEmployeeContacts)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncEmployeeContacts)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncEmployeeContacts)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncEmployeeContacts)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of jncEmployeeContacts)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncEmployeeContacts)
            Dim returnValue As New Generic.List(Of jncEmployeeContacts)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyjncEmployeeContacts As New jncEmployeeContacts(0)
                            If Not IsDBNull(dR(Columns.ID)) Then MyjncEmployeeContacts.ID = dR(Columns.ID)
                            If Not IsDBNull(dR(Columns.EmployeeID)) Then MyjncEmployeeContacts.EmployeeID = dR(Columns.EmployeeID)
                            If Not IsDBNull(dR(Columns.ContactID)) Then MyjncEmployeeContacts.ContactID = dR(Columns.ContactID)
                            returnValue.Add(MyjncEmployeeContacts)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncEmployeeContacts)
            Dim returnValue As New Generic.List(Of jncEmployeeContacts)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyjncEmployeeContacts As New jncEmployeeContacts(0)
                            If Not IsDBNull(dR(Columns.ID)) Then MyjncEmployeeContacts.ID = dR(Columns.ID)
                            If Not IsDBNull(dR(Columns.EmployeeID)) Then MyjncEmployeeContacts.EmployeeID = dR(Columns.EmployeeID)
                            If Not IsDBNull(dR(Columns.ContactID)) Then MyjncEmployeeContacts.ContactID = dR(Columns.ContactID)
                            returnValue.Add(MyjncEmployeeContacts)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("ID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("ID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as jncEmployeeContacts) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.ID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.ID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal ID AS System.Int32, byVal EmployeeID AS System.Int32, byVal ContactID AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF ID = 0 THEN
		ReturnValue = Insert(EmployeeID, ContactID)
	ELSE
	
		Dim MyLib as New jncEmployeeContacts(0)
				MyLib.ID = ID
				MyLib.EmployeeID = EmployeeID
				MyLib.ContactID = ContactID
		IF Update(MyLib) Then
			ReturnValue = MyLib.ID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as jncEmployeeContacts) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New jncEmployeeContacts(_MyLib.ID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ID", _MyLib.ID))
						command.Parameters.Add(New SqlParameter("@EmployeeID", _MyLib.EmployeeID))
						command.Parameters.Add(New SqlParameter("@ContactID", _MyLib.ContactID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE jncEmployeeContacts SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal ID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@ID", ID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of jncEmployeeContacts)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as jncEmployeeContacts) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ID", 0))
					command.Parameters.Add(New SqlParameter("@EmployeeID", _MyLib.EmployeeID))
					command.Parameters.Add(New SqlParameter("@ContactID", _MyLib.ContactID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal EmployeeID AS System.Int32, byVal ContactID AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ID", 0))
					command.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
					command.Parameters.Add(New SqlParameter("@ContactID", ContactID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class jncOrdersAndPackages"
			Partial Public Class jncOrdersAndPackages

	Private Shared Function SPBaseSQL() as String
		return "sp_jncOrdersAndPackages_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal ID As System.Int32)
	SetDefaults()
	If ID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ID", ID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.ID)) Then _ID = dR(Columns.ID)
							If Not IsDBNull(dR(Columns.OrderNumber)) Then _OrderNumber = dR(Columns.OrderNumber)
							If Not IsDBNull(dR(Columns.PackageID)) Then _PackageID = dR(Columns.PackageID)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of jncOrdersAndPackages)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of jncOrdersAndPackages)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of jncOrdersAndPackages)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncOrdersAndPackages)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncOrdersAndPackages)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncOrdersAndPackages)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncOrdersAndPackages)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of jncOrdersAndPackages)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncOrdersAndPackages)
            Dim returnValue As New Generic.List(Of jncOrdersAndPackages)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyjncOrdersAndPackages As New jncOrdersAndPackages(0)
                            If Not IsDBNull(dR(Columns.ID)) Then MyjncOrdersAndPackages.ID = dR(Columns.ID)
                            If Not IsDBNull(dR(Columns.OrderNumber)) Then MyjncOrdersAndPackages.OrderNumber = dR(Columns.OrderNumber)
                            If Not IsDBNull(dR(Columns.PackageID)) Then MyjncOrdersAndPackages.PackageID = dR(Columns.PackageID)
                            returnValue.Add(MyjncOrdersAndPackages)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncOrdersAndPackages)
            Dim returnValue As New Generic.List(Of jncOrdersAndPackages)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyjncOrdersAndPackages As New jncOrdersAndPackages(0)
                            If Not IsDBNull(dR(Columns.ID)) Then MyjncOrdersAndPackages.ID = dR(Columns.ID)
                            If Not IsDBNull(dR(Columns.OrderNumber)) Then MyjncOrdersAndPackages.OrderNumber = dR(Columns.OrderNumber)
                            If Not IsDBNull(dR(Columns.PackageID)) Then MyjncOrdersAndPackages.PackageID = dR(Columns.PackageID)
                            returnValue.Add(MyjncOrdersAndPackages)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("ID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("ID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as jncOrdersAndPackages) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.ID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.ID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal ID AS System.Int32, byVal OrderNumber AS System.Int32, byVal PackageID AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF ID = 0 THEN
		ReturnValue = Insert(OrderNumber, PackageID)
	ELSE
	
		Dim MyLib as New jncOrdersAndPackages(0)
				MyLib.ID = ID
				MyLib.OrderNumber = OrderNumber
				MyLib.PackageID = PackageID
		IF Update(MyLib) Then
			ReturnValue = MyLib.ID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as jncOrdersAndPackages) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New jncOrdersAndPackages(_MyLib.ID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ID", _MyLib.ID))
						command.Parameters.Add(New SqlParameter("@OrderNumber", _MyLib.OrderNumber))
						command.Parameters.Add(New SqlParameter("@PackageID", _MyLib.PackageID))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE jncOrdersAndPackages SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal ID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@ID", ID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of jncOrdersAndPackages)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as jncOrdersAndPackages) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ID", 0))
					command.Parameters.Add(New SqlParameter("@OrderNumber", _MyLib.OrderNumber))
					command.Parameters.Add(New SqlParameter("@PackageID", _MyLib.PackageID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal OrderNumber AS System.Int32, byVal PackageID AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ID", 0))
					command.Parameters.Add(New SqlParameter("@OrderNumber", OrderNumber))
					command.Parameters.Add(New SqlParameter("@PackageID", PackageID))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class jncVendorAddresses"
			Partial Public Class jncVendorAddresses

	Private Shared Function SPBaseSQL() as String
		return "sp_jncVendorAddresses_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal ID As System.Int32)
	SetDefaults()
	If ID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ID", ID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.ID)) Then _ID = dR(Columns.ID)
							If Not IsDBNull(dR(Columns.VendorID)) Then _VendorID = dR(Columns.VendorID)
							If Not IsDBNull(dR(Columns.AddressID)) Then _AddressID = dR(Columns.AddressID)
							If Not IsDBNull(dR(Columns.AddressType)) Then _AddressType = dR(Columns.AddressType)
							If Not IsDBNull(dR(Columns.Notes)) Then _Notes = dR(Columns.Notes)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of jncVendorAddresses)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of jncVendorAddresses)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of jncVendorAddresses)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncVendorAddresses)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncVendorAddresses)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncVendorAddresses)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncVendorAddresses)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of jncVendorAddresses)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of jncVendorAddresses)
            Dim returnValue As New Generic.List(Of jncVendorAddresses)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyjncVendorAddresses As New jncVendorAddresses(0)
                            If Not IsDBNull(dR(Columns.ID)) Then MyjncVendorAddresses.ID = dR(Columns.ID)
                            If Not IsDBNull(dR(Columns.VendorID)) Then MyjncVendorAddresses.VendorID = dR(Columns.VendorID)
                            If Not IsDBNull(dR(Columns.AddressID)) Then MyjncVendorAddresses.AddressID = dR(Columns.AddressID)
                            If Not IsDBNull(dR(Columns.AddressType)) Then MyjncVendorAddresses.AddressType = dR(Columns.AddressType)
                            If Not IsDBNull(dR(Columns.Notes)) Then MyjncVendorAddresses.Notes = dR(Columns.Notes)
                            returnValue.Add(MyjncVendorAddresses)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of jncVendorAddresses)
            Dim returnValue As New Generic.List(Of jncVendorAddresses)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyjncVendorAddresses As New jncVendorAddresses(0)
                            If Not IsDBNull(dR(Columns.ID)) Then MyjncVendorAddresses.ID = dR(Columns.ID)
                            If Not IsDBNull(dR(Columns.VendorID)) Then MyjncVendorAddresses.VendorID = dR(Columns.VendorID)
                            If Not IsDBNull(dR(Columns.AddressID)) Then MyjncVendorAddresses.AddressID = dR(Columns.AddressID)
                            If Not IsDBNull(dR(Columns.AddressType)) Then MyjncVendorAddresses.AddressType = dR(Columns.AddressType)
                            If Not IsDBNull(dR(Columns.Notes)) Then MyjncVendorAddresses.Notes = dR(Columns.Notes)
                            returnValue.Add(MyjncVendorAddresses)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("ID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("ID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as jncVendorAddresses) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.ID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.ID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal ID AS System.Int32, byVal VendorID AS System.Int32, byVal AddressID AS System.Int32, byVal AddressType AS System.Int32, byVal Notes AS System.String) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF ID = 0 THEN
		ReturnValue = Insert(VendorID, AddressID, AddressType, Notes)
	ELSE
	
		Dim MyLib as New jncVendorAddresses(0)
				MyLib.ID = ID
				MyLib.VendorID = VendorID
				MyLib.AddressID = AddressID
				MyLib.AddressType = AddressType
				MyLib.Notes = Notes
		IF Update(MyLib) Then
			ReturnValue = MyLib.ID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as jncVendorAddresses) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New jncVendorAddresses(_MyLib.ID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ID", _MyLib.ID))
						command.Parameters.Add(New SqlParameter("@VendorID", _MyLib.VendorID))
						command.Parameters.Add(New SqlParameter("@AddressID", _MyLib.AddressID))
						command.Parameters.Add(New SqlParameter("@AddressType", _MyLib.AddressType))
						command.Parameters.Add(New SqlParameter("@Notes", _MyLib.Notes))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE jncVendorAddresses SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal ID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@ID", ID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of jncVendorAddresses)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as jncVendorAddresses) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ID", 0))
					command.Parameters.Add(New SqlParameter("@VendorID", _MyLib.VendorID))
					command.Parameters.Add(New SqlParameter("@AddressID", _MyLib.AddressID))
					command.Parameters.Add(New SqlParameter("@AddressType", _MyLib.AddressType))
					command.Parameters.Add(New SqlParameter("@Notes", _MyLib.Notes))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal VendorID AS System.Int32, byVal AddressID AS System.Int32, byVal AddressType AS System.Int32, byVal Notes AS System.String) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ID", 0))
					command.Parameters.Add(New SqlParameter("@VendorID", VendorID))
					command.Parameters.Add(New SqlParameter("@AddressID", AddressID))
					command.Parameters.Add(New SqlParameter("@AddressType", AddressType))
					command.Parameters.Add(New SqlParameter("@Notes", Notes))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class luAssemblyTypes"
			Partial Public Class luAssemblyTypes

	Private Shared Function SPBaseSQL() as String
		return "sp_luAssemblyTypes_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal AssemblyTypeID As System.Int32)
	SetDefaults()
	If AssemblyTypeID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@AssemblyTypeID", AssemblyTypeID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.AssemblyTypeID)) Then _AssemblyTypeID = dR(Columns.AssemblyTypeID)
							If Not IsDBNull(dR(Columns.AssemblyType)) Then _AssemblyType = dR(Columns.AssemblyType)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of luAssemblyTypes)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luAssemblyTypes)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luAssemblyTypes)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luAssemblyTypes)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luAssemblyTypes)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luAssemblyTypes)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luAssemblyTypes)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of luAssemblyTypes)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luAssemblyTypes)
            Dim returnValue As New Generic.List(Of luAssemblyTypes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluAssemblyTypes As New luAssemblyTypes(0)
                            If Not IsDBNull(dR(Columns.AssemblyTypeID)) Then MyluAssemblyTypes.AssemblyTypeID = dR(Columns.AssemblyTypeID)
                            If Not IsDBNull(dR(Columns.AssemblyType)) Then MyluAssemblyTypes.AssemblyType = dR(Columns.AssemblyType)
                            returnValue.Add(MyluAssemblyTypes)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luAssemblyTypes)
            Dim returnValue As New Generic.List(Of luAssemblyTypes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluAssemblyTypes As New luAssemblyTypes(0)
                            If Not IsDBNull(dR(Columns.AssemblyTypeID)) Then MyluAssemblyTypes.AssemblyTypeID = dR(Columns.AssemblyTypeID)
                            If Not IsDBNull(dR(Columns.AssemblyType)) Then MyluAssemblyTypes.AssemblyType = dR(Columns.AssemblyType)
                            returnValue.Add(MyluAssemblyTypes)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("AssemblyTypeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("AssemblyTypeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as luAssemblyTypes) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.AssemblyTypeID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.AssemblyTypeID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal AssemblyTypeID AS System.Int32, byVal AssemblyType AS System.String) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF AssemblyTypeID = 0 THEN
		ReturnValue = Insert(AssemblyType)
	ELSE
	
		Dim MyLib as New luAssemblyTypes(0)
				MyLib.AssemblyTypeID = AssemblyTypeID
				MyLib.AssemblyType = AssemblyType
		IF Update(MyLib) Then
			ReturnValue = MyLib.AssemblyTypeID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as luAssemblyTypes) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New luAssemblyTypes(_MyLib.AssemblyTypeID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@AssemblyTypeID", _MyLib.AssemblyTypeID))
						command.Parameters.Add(New SqlParameter("@AssemblyType", _MyLib.AssemblyType))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE luAssemblyTypes SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal AssemblyTypeID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@AssemblyTypeID", AssemblyTypeID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of luAssemblyTypes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as luAssemblyTypes) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@AssemblyTypeID", 0))
					command.Parameters.Add(New SqlParameter("@AssemblyType", _MyLib.AssemblyType))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal AssemblyType AS System.String) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@AssemblyTypeID", 0))
					command.Parameters.Add(New SqlParameter("@AssemblyType", AssemblyType))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class luCities"
			Partial Public Class luCities

	Private Shared Function SPBaseSQL() as String
		return "sp_luCities_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal CityID As System.Int32)
	SetDefaults()
	If CityID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@CityID", CityID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.CityID)) Then _CityID = dR(Columns.CityID)
							If Not IsDBNull(dR(Columns.City)) Then _City = dR(Columns.City)
							If Not IsDBNull(dR(Columns.ProvinceCode)) Then _ProvinceCode = dR(Columns.ProvinceCode)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of luCities)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luCities)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luCities)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luCities)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luCities)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luCities)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luCities)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of luCities)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luCities)
            Dim returnValue As New Generic.List(Of luCities)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluCities As New luCities(0)
                            If Not IsDBNull(dR(Columns.CityID)) Then MyluCities.CityID = dR(Columns.CityID)
                            If Not IsDBNull(dR(Columns.City)) Then MyluCities.City = dR(Columns.City)
                            If Not IsDBNull(dR(Columns.ProvinceCode)) Then MyluCities.ProvinceCode = dR(Columns.ProvinceCode)
                            returnValue.Add(MyluCities)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luCities)
            Dim returnValue As New Generic.List(Of luCities)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluCities As New luCities(0)
                            If Not IsDBNull(dR(Columns.CityID)) Then MyluCities.CityID = dR(Columns.CityID)
                            If Not IsDBNull(dR(Columns.City)) Then MyluCities.City = dR(Columns.City)
                            If Not IsDBNull(dR(Columns.ProvinceCode)) Then MyluCities.ProvinceCode = dR(Columns.ProvinceCode)
                            returnValue.Add(MyluCities)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("CityID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("CityID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as luCities) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.CityID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.CityID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal CityID AS System.Int32, byVal City AS System.String, byVal ProvinceCode AS System.String) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF CityID = 0 THEN
		ReturnValue = Insert(City, ProvinceCode)
	ELSE
	
		Dim MyLib as New luCities(0)
				MyLib.CityID = CityID
				MyLib.City = City
				MyLib.ProvinceCode = ProvinceCode
		IF Update(MyLib) Then
			ReturnValue = MyLib.CityID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as luCities) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New luCities(_MyLib.CityID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@CityID", _MyLib.CityID))
						command.Parameters.Add(New SqlParameter("@City", _MyLib.City))
						command.Parameters.Add(New SqlParameter("@ProvinceCode", _MyLib.ProvinceCode))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE luCities SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal CityID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@CityID", CityID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of luCities)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as luCities) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@CityID", 0))
					command.Parameters.Add(New SqlParameter("@City", _MyLib.City))
					command.Parameters.Add(New SqlParameter("@ProvinceCode", _MyLib.ProvinceCode))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal City AS System.String, byVal ProvinceCode AS System.String) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@CityID", 0))
					command.Parameters.Add(New SqlParameter("@City", City))
					command.Parameters.Add(New SqlParameter("@ProvinceCode", ProvinceCode))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class luContactType"
			Partial Public Class luContactType

	Private Shared Function SPBaseSQL() as String
		return "sp_luContactType_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal ContactTypeID As System.Byte)
	SetDefaults()
	If ContactTypeID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ContactTypeID", ContactTypeID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.ContactTypeID)) Then _ContactTypeID = dR(Columns.ContactTypeID)
							If Not IsDBNull(dR(Columns.ContactType)) Then _ContactType = dR(Columns.ContactType)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of luContactType)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luContactType)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luContactType)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luContactType)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luContactType)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luContactType)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luContactType)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of luContactType)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luContactType)
            Dim returnValue As New Generic.List(Of luContactType)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluContactType As New luContactType(0)
                            If Not IsDBNull(dR(Columns.ContactTypeID)) Then MyluContactType.ContactTypeID = dR(Columns.ContactTypeID)
                            If Not IsDBNull(dR(Columns.ContactType)) Then MyluContactType.ContactType = dR(Columns.ContactType)
                            returnValue.Add(MyluContactType)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luContactType)
            Dim returnValue As New Generic.List(Of luContactType)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluContactType As New luContactType(0)
                            If Not IsDBNull(dR(Columns.ContactTypeID)) Then MyluContactType.ContactTypeID = dR(Columns.ContactTypeID)
                            If Not IsDBNull(dR(Columns.ContactType)) Then MyluContactType.ContactType = dR(Columns.ContactType)
                            returnValue.Add(MyluContactType)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Byte)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Byte)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Byte)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Byte)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Byte)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Byte)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Byte)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Byte)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Byte)
            Dim returnValue As New Generic.List(Of System.Byte)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("ContactTypeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Byte)
            Dim returnValue As New Generic.List(Of System.Byte)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("ContactTypeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as luContactType) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.ContactTypeID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.ContactTypeID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal ContactTypeID AS System.Byte, byVal ContactType AS System.String) As System.Byte
 	DIM ReturnValue as Integer = 0
	IF ContactTypeID = 0 THEN
		ReturnValue = Insert(ContactType)
	ELSE
	
		Dim MyLib as New luContactType(0)
				MyLib.ContactTypeID = ContactTypeID
				MyLib.ContactType = ContactType
		IF Update(MyLib) Then
			ReturnValue = MyLib.ContactTypeID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as luContactType) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New luContactType(_MyLib.ContactTypeID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ContactTypeID", _MyLib.ContactTypeID))
						command.Parameters.Add(New SqlParameter("@ContactType", _MyLib.ContactType))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE luContactType SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal ContactTypeID As System.Byte) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@ContactTypeID", ContactTypeID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of luContactType)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as luContactType) As System.Byte
	DIM ReturnID as System.Byte
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ContactTypeID", 0))
					command.Parameters.Add(New SqlParameter("@ContactType", _MyLib.ContactType))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal ContactType AS System.String) As System.Byte
	DIM ReturnID as System.Byte
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ContactTypeID", 0))
					command.Parameters.Add(New SqlParameter("@ContactType", ContactType))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class luCountries"
			Partial Public Class luCountries

	Private Shared Function SPBaseSQL() as String
		return "sp_luCountries_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal CountryCode As System.String)
	SetDefaults()
	If CountryCode > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@CountryCode", CountryCode))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.CountryCode)) Then _CountryCode = dR(Columns.CountryCode)
							If Not IsDBNull(dR(Columns.CountryName)) Then _CountryName = dR(Columns.CountryName)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of luCountries)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luCountries)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luCountries)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luCountries)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luCountries)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luCountries)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luCountries)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of luCountries)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luCountries)
            Dim returnValue As New Generic.List(Of luCountries)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluCountries As New luCountries(0)
                            If Not IsDBNull(dR(Columns.CountryCode)) Then MyluCountries.CountryCode = dR(Columns.CountryCode)
                            If Not IsDBNull(dR(Columns.CountryName)) Then MyluCountries.CountryName = dR(Columns.CountryName)
                            returnValue.Add(MyluCountries)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luCountries)
            Dim returnValue As New Generic.List(Of luCountries)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluCountries As New luCountries(0)
                            If Not IsDBNull(dR(Columns.CountryCode)) Then MyluCountries.CountryCode = dR(Columns.CountryCode)
                            If Not IsDBNull(dR(Columns.CountryName)) Then MyluCountries.CountryName = dR(Columns.CountryName)
                            returnValue.Add(MyluCountries)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.String)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.String)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.String)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.String)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.String)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.String)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.String)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.String)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.String)
            Dim returnValue As New Generic.List(Of System.String)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("CountryCode"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.String)
            Dim returnValue As New Generic.List(Of System.String)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("CountryCode"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as luCountries) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.CountryCode = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.CountryCode
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal CountryCode AS System.String, byVal CountryName AS System.String) As System.String
 	DIM ReturnValue as Integer = 0
	IF CountryCode = 0 THEN
		ReturnValue = Insert(CountryName)
	ELSE
	
		Dim MyLib as New luCountries(0)
				MyLib.CountryCode = CountryCode
				MyLib.CountryName = CountryName
		IF Update(MyLib) Then
			ReturnValue = MyLib.CountryCode
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as luCountries) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New luCountries(_MyLib.CountryCode)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@CountryCode", _MyLib.CountryCode))
						command.Parameters.Add(New SqlParameter("@CountryName", _MyLib.CountryName))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE luCountries SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal CountryCode As System.String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@CountryCode", CountryCode))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of luCountries)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as luCountries) As System.String
	DIM ReturnID as System.String
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@CountryCode", 0))
					command.Parameters.Add(New SqlParameter("@CountryName", _MyLib.CountryName))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal CountryName AS System.String) As System.String
	DIM ReturnID as System.String
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@CountryCode", 0))
					command.Parameters.Add(New SqlParameter("@CountryName", CountryName))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class luIngredients"
			Partial Public Class luIngredients

	Private Shared Function SPBaseSQL() as String
		return "sp_luIngredients_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal IngredientID As System.Int32)
	SetDefaults()
	If IngredientID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@IngredientID", IngredientID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.IngredientID)) Then _IngredientID = dR(Columns.IngredientID)
							If Not IsDBNull(dR(Columns.Ingredient)) Then _Ingredient = dR(Columns.Ingredient)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of luIngredients)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luIngredients)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luIngredients)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luIngredients)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luIngredients)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luIngredients)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luIngredients)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of luIngredients)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luIngredients)
            Dim returnValue As New Generic.List(Of luIngredients)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluIngredients As New luIngredients(0)
                            If Not IsDBNull(dR(Columns.IngredientID)) Then MyluIngredients.IngredientID = dR(Columns.IngredientID)
                            If Not IsDBNull(dR(Columns.Ingredient)) Then MyluIngredients.Ingredient = dR(Columns.Ingredient)
                            returnValue.Add(MyluIngredients)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luIngredients)
            Dim returnValue As New Generic.List(Of luIngredients)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluIngredients As New luIngredients(0)
                            If Not IsDBNull(dR(Columns.IngredientID)) Then MyluIngredients.IngredientID = dR(Columns.IngredientID)
                            If Not IsDBNull(dR(Columns.Ingredient)) Then MyluIngredients.Ingredient = dR(Columns.Ingredient)
                            returnValue.Add(MyluIngredients)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("IngredientID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("IngredientID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as luIngredients) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.IngredientID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.IngredientID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal IngredientID AS System.Int32, byVal Ingredient AS System.String) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF IngredientID = 0 THEN
		ReturnValue = Insert(Ingredient)
	ELSE
	
		Dim MyLib as New luIngredients(0)
				MyLib.IngredientID = IngredientID
				MyLib.Ingredient = Ingredient
		IF Update(MyLib) Then
			ReturnValue = MyLib.IngredientID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as luIngredients) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New luIngredients(_MyLib.IngredientID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@IngredientID", _MyLib.IngredientID))
						command.Parameters.Add(New SqlParameter("@Ingredient", _MyLib.Ingredient))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE luIngredients SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal IngredientID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@IngredientID", IngredientID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of luIngredients)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as luIngredients) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@IngredientID", 0))
					command.Parameters.Add(New SqlParameter("@Ingredient", _MyLib.Ingredient))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal Ingredient AS System.String) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@IngredientID", 0))
					command.Parameters.Add(New SqlParameter("@Ingredient", Ingredient))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class luPhoneTypes"
			Partial Public Class luPhoneTypes

	Private Shared Function SPBaseSQL() as String
		return "sp_luPhoneTypes_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal PhoneTypeID As System.Byte)
	SetDefaults()
	If PhoneTypeID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@PhoneTypeID", PhoneTypeID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.PhoneTypeID)) Then _PhoneTypeID = dR(Columns.PhoneTypeID)
							If Not IsDBNull(dR(Columns.PhoneType)) Then _PhoneType = dR(Columns.PhoneType)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of luPhoneTypes)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luPhoneTypes)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luPhoneTypes)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luPhoneTypes)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luPhoneTypes)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luPhoneTypes)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luPhoneTypes)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of luPhoneTypes)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luPhoneTypes)
            Dim returnValue As New Generic.List(Of luPhoneTypes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluPhoneTypes As New luPhoneTypes(0)
                            If Not IsDBNull(dR(Columns.PhoneTypeID)) Then MyluPhoneTypes.PhoneTypeID = dR(Columns.PhoneTypeID)
                            If Not IsDBNull(dR(Columns.PhoneType)) Then MyluPhoneTypes.PhoneType = dR(Columns.PhoneType)
                            returnValue.Add(MyluPhoneTypes)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luPhoneTypes)
            Dim returnValue As New Generic.List(Of luPhoneTypes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluPhoneTypes As New luPhoneTypes(0)
                            If Not IsDBNull(dR(Columns.PhoneTypeID)) Then MyluPhoneTypes.PhoneTypeID = dR(Columns.PhoneTypeID)
                            If Not IsDBNull(dR(Columns.PhoneType)) Then MyluPhoneTypes.PhoneType = dR(Columns.PhoneType)
                            returnValue.Add(MyluPhoneTypes)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Byte)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Byte)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Byte)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Byte)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Byte)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Byte)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Byte)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Byte)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Byte)
            Dim returnValue As New Generic.List(Of System.Byte)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("PhoneTypeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Byte)
            Dim returnValue As New Generic.List(Of System.Byte)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("PhoneTypeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as luPhoneTypes) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.PhoneTypeID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.PhoneTypeID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal PhoneTypeID AS System.Byte, byVal PhoneType AS System.String) As System.Byte
 	DIM ReturnValue as Integer = 0
	IF PhoneTypeID = 0 THEN
		ReturnValue = Insert(PhoneType)
	ELSE
	
		Dim MyLib as New luPhoneTypes(0)
				MyLib.PhoneTypeID = PhoneTypeID
				MyLib.PhoneType = PhoneType
		IF Update(MyLib) Then
			ReturnValue = MyLib.PhoneTypeID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as luPhoneTypes) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New luPhoneTypes(_MyLib.PhoneTypeID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@PhoneTypeID", _MyLib.PhoneTypeID))
						command.Parameters.Add(New SqlParameter("@PhoneType", _MyLib.PhoneType))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE luPhoneTypes SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal PhoneTypeID As System.Byte) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@PhoneTypeID", PhoneTypeID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of luPhoneTypes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as luPhoneTypes) As System.Byte
	DIM ReturnID as System.Byte
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@PhoneTypeID", 0))
					command.Parameters.Add(New SqlParameter("@PhoneType", _MyLib.PhoneType))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal PhoneType AS System.String) As System.Byte
	DIM ReturnID as System.Byte
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@PhoneTypeID", 0))
					command.Parameters.Add(New SqlParameter("@PhoneType", PhoneType))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class luPositions"
			Partial Public Class luPositions

	Private Shared Function SPBaseSQL() as String
		return "sp_luPositions_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal PositionID As System.Int32)
	SetDefaults()
	If PositionID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@PositionID", PositionID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.PositionID)) Then _PositionID = dR(Columns.PositionID)
							If Not IsDBNull(dR(Columns.Position)) Then _Position = dR(Columns.Position)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of luPositions)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luPositions)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luPositions)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luPositions)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luPositions)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luPositions)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luPositions)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of luPositions)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luPositions)
            Dim returnValue As New Generic.List(Of luPositions)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluPositions As New luPositions(0)
                            If Not IsDBNull(dR(Columns.PositionID)) Then MyluPositions.PositionID = dR(Columns.PositionID)
                            If Not IsDBNull(dR(Columns.Position)) Then MyluPositions.Position = dR(Columns.Position)
                            returnValue.Add(MyluPositions)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luPositions)
            Dim returnValue As New Generic.List(Of luPositions)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluPositions As New luPositions(0)
                            If Not IsDBNull(dR(Columns.PositionID)) Then MyluPositions.PositionID = dR(Columns.PositionID)
                            If Not IsDBNull(dR(Columns.Position)) Then MyluPositions.Position = dR(Columns.Position)
                            returnValue.Add(MyluPositions)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("PositionID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("PositionID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as luPositions) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.PositionID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.PositionID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal PositionID AS System.Int32, byVal Position AS System.String) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF PositionID = 0 THEN
		ReturnValue = Insert(Position)
	ELSE
	
		Dim MyLib as New luPositions(0)
				MyLib.PositionID = PositionID
				MyLib.Position = Position
		IF Update(MyLib) Then
			ReturnValue = MyLib.PositionID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as luPositions) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New luPositions(_MyLib.PositionID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@PositionID", _MyLib.PositionID))
						command.Parameters.Add(New SqlParameter("@Position", _MyLib.Position))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE luPositions SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal PositionID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@PositionID", PositionID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of luPositions)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as luPositions) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@PositionID", 0))
					command.Parameters.Add(New SqlParameter("@Position", _MyLib.Position))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal Position AS System.String) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@PositionID", 0))
					command.Parameters.Add(New SqlParameter("@Position", Position))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class luProvinces"
			Partial Public Class luProvinces

	Private Shared Function SPBaseSQL() as String
		return "sp_luProvinces_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal ProvinceCode As System.String)
	SetDefaults()
	If ProvinceCode > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ProvinceCode", ProvinceCode))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.ProvinceCode)) Then _ProvinceCode = dR(Columns.ProvinceCode)
							If Not IsDBNull(dR(Columns.ProvinceName)) Then _ProvinceName = dR(Columns.ProvinceName)
							If Not IsDBNull(dR(Columns.CountryCode)) Then _CountryCode = dR(Columns.CountryCode)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of luProvinces)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luProvinces)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luProvinces)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luProvinces)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luProvinces)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luProvinces)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luProvinces)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of luProvinces)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luProvinces)
            Dim returnValue As New Generic.List(Of luProvinces)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluProvinces As New luProvinces(0)
                            If Not IsDBNull(dR(Columns.ProvinceCode)) Then MyluProvinces.ProvinceCode = dR(Columns.ProvinceCode)
                            If Not IsDBNull(dR(Columns.ProvinceName)) Then MyluProvinces.ProvinceName = dR(Columns.ProvinceName)
                            If Not IsDBNull(dR(Columns.CountryCode)) Then MyluProvinces.CountryCode = dR(Columns.CountryCode)
                            returnValue.Add(MyluProvinces)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luProvinces)
            Dim returnValue As New Generic.List(Of luProvinces)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluProvinces As New luProvinces(0)
                            If Not IsDBNull(dR(Columns.ProvinceCode)) Then MyluProvinces.ProvinceCode = dR(Columns.ProvinceCode)
                            If Not IsDBNull(dR(Columns.ProvinceName)) Then MyluProvinces.ProvinceName = dR(Columns.ProvinceName)
                            If Not IsDBNull(dR(Columns.CountryCode)) Then MyluProvinces.CountryCode = dR(Columns.CountryCode)
                            returnValue.Add(MyluProvinces)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.String)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.String)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.String)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.String)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.String)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.String)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.String)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.String)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.String)
            Dim returnValue As New Generic.List(Of System.String)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("ProvinceCode"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.String)
            Dim returnValue As New Generic.List(Of System.String)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("ProvinceCode"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as luProvinces) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.ProvinceCode = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.ProvinceCode
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal ProvinceCode AS System.String, byVal ProvinceName AS System.String, byVal CountryCode AS System.String) As System.String
 	DIM ReturnValue as Integer = 0
	IF ProvinceCode = 0 THEN
		ReturnValue = Insert(ProvinceName, CountryCode)
	ELSE
	
		Dim MyLib as New luProvinces(0)
				MyLib.ProvinceCode = ProvinceCode
				MyLib.ProvinceName = ProvinceName
				MyLib.CountryCode = CountryCode
		IF Update(MyLib) Then
			ReturnValue = MyLib.ProvinceCode
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as luProvinces) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New luProvinces(_MyLib.ProvinceCode)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@ProvinceCode", _MyLib.ProvinceCode))
						command.Parameters.Add(New SqlParameter("@ProvinceName", _MyLib.ProvinceName))
						command.Parameters.Add(New SqlParameter("@CountryCode", _MyLib.CountryCode))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE luProvinces SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal ProvinceCode As System.String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@ProvinceCode", ProvinceCode))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of luProvinces)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as luProvinces) As System.String
	DIM ReturnID as System.String
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
                    'command.parameters.add(New SQLParameter("@ProvinceCode", 0))
                    command.Parameters.Add(New SqlParameter("@ProvinceName", _MyLib.ProvinceName))
					command.Parameters.Add(New SqlParameter("@CountryCode", _MyLib.CountryCode))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal ProvinceName AS System.String, byVal CountryCode AS System.String) As System.String
	DIM ReturnID as System.String
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@ProvinceCode", 0))
					command.Parameters.Add(New SqlParameter("@ProvinceName", ProvinceName))
					command.Parameters.Add(New SqlParameter("@CountryCode", CountryCode))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class luTimeTypes"
			Partial Public Class luTimeTypes

	Private Shared Function SPBaseSQL() as String
		return "sp_luTimeTypes_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal TimeTypeID As System.Int32)
	SetDefaults()
	If TimeTypeID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@TimeTypeID", TimeTypeID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.TimeTypeID)) Then _TimeTypeID = dR(Columns.TimeTypeID)
							If Not IsDBNull(dR(Columns.TimeType)) Then _TimeType = dR(Columns.TimeType)
							If Not IsDBNull(dR(Columns.IngredientType)) Then _IngredientType = dR(Columns.IngredientType)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of luTimeTypes)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luTimeTypes)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luTimeTypes)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luTimeTypes)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luTimeTypes)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luTimeTypes)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luTimeTypes)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of luTimeTypes)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luTimeTypes)
            Dim returnValue As New Generic.List(Of luTimeTypes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluTimeTypes As New luTimeTypes(0)
                            If Not IsDBNull(dR(Columns.TimeTypeID)) Then MyluTimeTypes.TimeTypeID = dR(Columns.TimeTypeID)
                            If Not IsDBNull(dR(Columns.TimeType)) Then MyluTimeTypes.TimeType = dR(Columns.TimeType)
                            If Not IsDBNull(dR(Columns.IngredientType)) Then MyluTimeTypes.IngredientType = dR(Columns.IngredientType)
                            returnValue.Add(MyluTimeTypes)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luTimeTypes)
            Dim returnValue As New Generic.List(Of luTimeTypes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluTimeTypes As New luTimeTypes(0)
                            If Not IsDBNull(dR(Columns.TimeTypeID)) Then MyluTimeTypes.TimeTypeID = dR(Columns.TimeTypeID)
                            If Not IsDBNull(dR(Columns.TimeType)) Then MyluTimeTypes.TimeType = dR(Columns.TimeType)
                            If Not IsDBNull(dR(Columns.IngredientType)) Then MyluTimeTypes.IngredientType = dR(Columns.IngredientType)
                            returnValue.Add(MyluTimeTypes)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("TimeTypeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("TimeTypeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as luTimeTypes) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.TimeTypeID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.TimeTypeID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal TimeTypeID AS System.Int32, byVal TimeType AS System.String, byVal IngredientType AS System.Int32) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF TimeTypeID = 0 THEN
		ReturnValue = Insert(TimeType, IngredientType)
	ELSE
	
		Dim MyLib as New luTimeTypes(0)
				MyLib.TimeTypeID = TimeTypeID
				MyLib.TimeType = TimeType
				MyLib.IngredientType = IngredientType
		IF Update(MyLib) Then
			ReturnValue = MyLib.TimeTypeID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as luTimeTypes) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New luTimeTypes(_MyLib.TimeTypeID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@TimeTypeID", _MyLib.TimeTypeID))
						command.Parameters.Add(New SqlParameter("@TimeType", _MyLib.TimeType))
						command.Parameters.Add(New SqlParameter("@IngredientType", _MyLib.IngredientType))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE luTimeTypes SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal TimeTypeID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@TimeTypeID", TimeTypeID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of luTimeTypes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as luTimeTypes) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@TimeTypeID", 0))
					command.Parameters.Add(New SqlParameter("@TimeType", _MyLib.TimeType))
					command.Parameters.Add(New SqlParameter("@IngredientType", _MyLib.IngredientType))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal TimeType AS System.String, byVal IngredientType AS System.Int32) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@TimeTypeID", 0))
					command.Parameters.Add(New SqlParameter("@TimeType", TimeType))
					command.Parameters.Add(New SqlParameter("@IngredientType", IngredientType))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class luUnits"
			Partial Public Class luUnits

	Private Shared Function SPBaseSQL() as String
		return "sp_luUnits_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal UnitsID As System.Int32)
	SetDefaults()
	If UnitsID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@UnitsID", UnitsID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.UnitsID)) Then _UnitsID = dR(Columns.UnitsID)
							If Not IsDBNull(dR(Columns.Units)) Then _Units = dR(Columns.Units)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of luUnits)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luUnits)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luUnits)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luUnits)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luUnits)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luUnits)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luUnits)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of luUnits)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luUnits)
            Dim returnValue As New Generic.List(Of luUnits)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluUnits As New luUnits(0)
                            If Not IsDBNull(dR(Columns.UnitsID)) Then MyluUnits.UnitsID = dR(Columns.UnitsID)
                            If Not IsDBNull(dR(Columns.Units)) Then MyluUnits.Units = dR(Columns.Units)
                            returnValue.Add(MyluUnits)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luUnits)
            Dim returnValue As New Generic.List(Of luUnits)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluUnits As New luUnits(0)
                            If Not IsDBNull(dR(Columns.UnitsID)) Then MyluUnits.UnitsID = dR(Columns.UnitsID)
                            If Not IsDBNull(dR(Columns.Units)) Then MyluUnits.Units = dR(Columns.Units)
                            returnValue.Add(MyluUnits)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("UnitsID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("UnitsID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as luUnits) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.UnitsID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.UnitsID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal UnitsID AS System.Int32, byVal Units AS System.String) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF UnitsID = 0 THEN
		ReturnValue = Insert(Units)
	ELSE
	
		Dim MyLib as New luUnits(0)
				MyLib.UnitsID = UnitsID
				MyLib.Units = Units
		IF Update(MyLib) Then
			ReturnValue = MyLib.UnitsID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as luUnits) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New luUnits(_MyLib.UnitsID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@UnitsID", _MyLib.UnitsID))
						command.Parameters.Add(New SqlParameter("@Units", _MyLib.Units))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE luUnits SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal UnitsID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@UnitsID", UnitsID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of luUnits)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as luUnits) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@UnitsID", 0))
					command.Parameters.Add(New SqlParameter("@Units", _MyLib.Units))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal Units AS System.String) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@UnitsID", 0))
					command.Parameters.Add(New SqlParameter("@Units", Units))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
#Region " - Class luVehicleTypes"
			Partial Public Class luVehicleTypes

	Private Shared Function SPBaseSQL() as String
		return "sp_luVehicleTypes_"
	End Function

#Region " - Sub NEW -"
Public Sub New(ByVal TypeID As System.Int32)
	SetDefaults()
	If TypeID > 0 Then
		Using connection As New SqlConnection(Lookups.GetConnString)
			Using command As New SqlCommand(SPBaseSQL & spTypes.SelectRow, connection)
				command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@TypeID", TypeID))
				connection.Open()
				Dim dR As IDataReader = command.ExecuteReader
				If dR.Read Then
							If Not IsDBNull(dR(Columns.TypeID)) Then _TypeID = dR(Columns.TypeID)
							If Not IsDBNull(dR(Columns.Description)) Then _Description = dR(Columns.Description)
				End If
				dR.Close()
				dR = Nothing
				connection.Close()
			End Using
		End Using
	End If
End Sub

#End Region

#Region "- SELECTS - "
        Public Shared Function SelectWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of luVehicleTypes)
            Return SelectAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luVehicleTypes)
            Return SelectAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of luVehicleTypes)
            Return SelectAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luVehicleTypes)
            Return SelectAll(WhereCondition, OrderByExpression)
        End Function
		
        Public Shared Function SelectWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luVehicleTypes)
            Return SelectAll(WhereCondition, OrderByExpression, NumRows)
        End Function
		
        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luVehicleTypes)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luVehicleTypes)
			if NumRows is nothing then
				If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
					Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
				Else
					Return SelectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
				End If
			Else
				return selectRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
			End if
        End Function

		Public Shared Function SelectAll() As Generic.List(Of luVehicleTypes)
            Return SelectRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of luVehicleTypes)
            Dim returnValue As New Generic.List(Of luVehicleTypes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluVehicleTypes As New luVehicleTypes(0)
                            If Not IsDBNull(dR(Columns.TypeID)) Then MyluVehicleTypes.TypeID = dR(Columns.TypeID)
                            If Not IsDBNull(dR(Columns.Description)) Then MyluVehicleTypes.Description = dR(Columns.Description)
                            returnValue.Add(MyluVehicleTypes)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

        Private Shared Function SelectRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, NumRows as string) As Generic.List(Of luVehicleTypes)
            Dim returnValue As New Generic.List(Of luVehicleTypes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
					If Not NumRows Is Nothing Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            Dim MyluVehicleTypes As New luVehicleTypes(0)
                            If Not IsDBNull(dR(Columns.TypeID)) Then MyluVehicleTypes.TypeID = dR(Columns.TypeID)
                            If Not IsDBNull(dR(Columns.Description)) Then MyluVehicleTypes.Description = dR(Columns.Description)
                            returnValue.Add(MyluVehicleTypes)
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
					    Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
            			Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
            			DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Public Shared Function SelectKeysWhere(ByVal ParmArray() As SPHelpers.WhereCondition) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(ParmArray), Nothing)
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition, ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(SPHelpers.BuildWhereCondition(WhereConditionArray), SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal OrderByExpressionArray() As SPHelpers.OrderByExpression) As Generic.List(Of System.Int32)
            Return SelectKeysAll(Nothing, SPHelpers.BuildOrderByExpression(OrderByExpressionArray))
        End Function

        Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression)
        End Function
		
	    Public Shared Function SelectKeysWhere(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Return SelectKeysAll(WhereCondition, OrderByExpression, NumRows)
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
            Else
                Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
            End If
        End Function

        Private Shared Function SelectKeysAll(ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            If NumRows = 0 Then
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
                Else
                    Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression)
                End If
            Else
                If WhereCondition Is Nothing AndAlso OrderByExpression Is Nothing Then
                	Return SelectKeysRows(SPBaseSQL() & SPTypes.selectall, nothing, nothing, NumRows)
				else
					Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectDynamic, WhereCondition, OrderByExpression, NumRows)
				end if
            End If
        End Function
		
        Public Shared Function SelectKeysAll() As Generic.List(Of System.Int32)
            Return SelectKeysRows(SPBaseSQL() & SPTypes.SelectAll, Nothing, Nothing)
        End Function

        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP, connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dr("TypeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function
		
        Private Shared Function SelectKeysRows(ByVal SP As String, ByVal WhereCondition As String, ByVal OrderByExpression As String, ByVal NumRows As integer) As Generic.List(Of System.Int32)
            Dim returnValue As New Generic.List(Of System.Int32)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SP & "_TopN", connection)
                    command.CommandType = CommandType.StoredProcedure
                    If Not WhereCondition Is Nothing Then command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    If Not OrderByExpression Is Nothing Then command.Parameters.Add(New SqlParameter("@OrderByExpression", OrderByExpression))
                    If Not NumRows = 0 Then command.Parameters.Add(New SqlParameter("@NumRows", NumRows))
                    connection.Open()
                    Try
                        Dim dR As IDataReader = command.ExecuteReader
                        Do While dR.Read
                            returnValue.Add(dR("TypeID"))
                        Loop
                        dR.Close()
                        dR = Nothing
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                    End Try
                End Using
            End Using
            Return returnValue
        End Function

#End Region

#Region " - Update, Insert, Delete, Save - "
Public shared Function Save(byVal MyLib as luVehicleTypes) As Integer
 	DIM ReturnValue as Integer = 0
	IF MyLib.TypeID = 0 THEN
		ReturnValue = insert(MyLib)
	ELSE
		IF Update(MyLib) Then
			ReturnValue = MyLib.TypeID
		Else
			ReturnValue = 0
		END IF
	END IF
	Return ReturnValue
End Function

Public Shared Function Save(byVal TypeID AS System.Int32, byVal Description AS System.String) As System.Int32
 	DIM ReturnValue as Integer = 0
	IF TypeID = 0 THEN
		ReturnValue = Insert(Description)
	ELSE
	
		Dim MyLib as New luVehicleTypes(0)
				MyLib.TypeID = TypeID
				MyLib.Description = Description
		IF Update(MyLib) Then
			ReturnValue = MyLib.TypeID
		Else
			ReturnValue = 0
		END IF
	END IF		
	Return ReturnValue		
End Function

#Region "           - Update - "
	Public Shared Function Update(byVal _MyLib as luVehicleTypes) As Boolean
		Using connection As New SqlConnection(Lookups.GetConnString)
			
			Dim Old As New luVehicleTypes(_MyLib.TypeID)
            Using command As New SqlCommand(SPBaseSQL() & SPTypes.Update, connection)
                command.CommandType = CommandType.StoredProcedure
				command.Parameters.Add(New SqlParameter("@TypeID", _MyLib.TypeID))
						command.Parameters.Add(New SqlParameter("@Description", _MyLib.Description))
				connection.Open()
				Try
					Command.ExecuteNonquery
					Update = True
				Catch ex As Exception
					Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                    Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                    DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					throw ex
					Update = False
				End Try
			end using
			Old = nothing
		end using
		Return Update
	End Function
    
            Public Shared Function MassUpdate(UpdateCriteria As String, ByVal WhereClause As String) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)

                Dim UpdateString As String = "UPDATE luVehicleTypes SET " & UpdateCriteria 
                if not WhereClause is nothing andalso whereclause.Length > 2 THEN updatestring &= " WHERE " & WhereClause
                Using MyCommand As New SqlCommand(UpdateString, connection)
                    MyCommand.CommandType = CommandType.Text
                    connection.Open()
                    Try
                        MyCommand.ExecuteNonQuery()
                        MassUpdate = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
                        Throw ex
                        MassUpdate = False
                    End Try
                End Using
            End Using
            Return MassUpdate
        End Function

#End Region

#Region "           - Delete - "
        Public Shared Function Delete(ByVal TypeID As System.Int32) As Boolean
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.Delete, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@TypeID", TypeID))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        Delete = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
					
                        throw ex
						Delete = False
                    End Try
                End Using
            End Using
            Return Delete
        End Function

        Public Shared Function DeleteWhere(ByVal WhereConditionArray() As SPHelpers.WhereCondition) As Boolean
            Return DeleteWhere(SPHelpers.BuildWhereCondition(WhereConditionArray))
        End Function

        Public Shared Function DeleteWhere(ByVal WhereCondition As String) As Boolean
            Dim returnValue As New Generic.List(Of luVehicleTypes)
            Using connection As New SqlConnection(Lookups.GetConnString)
                Using command As New SqlCommand(SPBaseSQL() & SPTypes.DeleteDynamic, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@WhereCondition", WhereCondition))
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        DeleteWhere = True
                    Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

						throw ex
                        DeleteWhere = False
                    End Try
                End Using
            End Using
            Return DeleteWhere
        End Function
#End Region

#Region "           - Insert - "
Public Shared Function Insert(ByVal _MyLib as luVehicleTypes) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection) 'EDIT WAS HERE
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@TypeID", 0))
					command.Parameters.Add(New SqlParameter("@Description", _MyLib.Description))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function

Public Shared Function Insert(byVal Description AS System.String) As System.Int32
	DIM ReturnID as System.Int32
	Using connection As New SqlConnection(Lookups.GetConnString)
		Using command As New SqlCommand(SPBaseSQL() & SPTypes.Insert, connection)
			command.CommandType = CommandType.StoredProcedure
				'command.parameters.add(New SQLParameter("@TypeID", 0))
					command.Parameters.Add(New SqlParameter("@Description", Description))
			Try
				connection.Open()
				returnID = Command.ExecuteScalar
			Catch ex As Exception
                        Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
                        Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
                        DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)

				throw ex
				returnid = Nothing
			End Try
		end using
	end using
	Return returnID
End Function
#End Region

#End Region

	End Class
#End Region
End Namespace

