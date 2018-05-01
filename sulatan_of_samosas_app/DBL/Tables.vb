Imports System.Data
Imports System.Data.SqlClient



'******************************************************************
'* Code Generated Automatically using GlobalCodeGen and CodeRush! 
'* AUTHOR: InterGlobal Solutions
'* SUPPORT: http://www.interglobal.ca  519-342-4881
'* ALSO: http://www.techstudio.ca  519-342-4881
'* DATE: 2018-04-30 3:00:20 PM
'* Derived from: SoS_Script_Test
'******************************************************************
NameSpace Tables

	Public Enum Sorting
		Ascending
		Descending
	End Enum 
	
	Public Enum Equals
		IsEqualTo
		NotEquals
		GreaterThan
		GreaterThanEquals
		LessThan
		LessThanEquals
        Contains
        StartsWith
        EndsWith
    End Enum

Public Enum TableList
			datAddresses
			datAssembly
			datBoxes
			datClientOrders
			datClients
			datContacts
			datEmployees
			datIngredientInventory
			datMeasurements
			datPackages
			datPeople
			datPhones
			datPurchaseOrders
			datShipments
			datTrays
			datVehicleCleaning
			datVehicles
			datVendors
			HACCPTemps
			HACCPTimes
			jncAssembly
			jncClientAddresses
			jncClientContacts
			jncEmployeeContacts
			jncOrdersAndPackages
			jncVendorAddresses
			luAssemblyTypes
			luCities
			luContactType
			luCountries
			luIngredients
			luPhoneTypes
			luPositions
			luProvinces
			luTimeTypes
			luUnits
			luVehicleTypes
End Enum

#Region " - Class datAddresses"
			Partial Public Class datAddresses
#Region "       - Variable Declarations - "
			Private _AddressID As System.Int32
			Public Property AddressID() As System.Int32
				Get
					Return _AddressID
				End Get
				Set(ByVal value As System.Int32)
					_AddressID = value
				End Set
			End Property
			Private _Address As System.String
			Public Property Address() As System.String
				Get
					Return _Address
				End Get
				Set(ByVal value As System.String)
					_Address = value
				End Set
			End Property
			Private _CityID As System.Int32
			Public Property CityID() As System.Int32
				Get
					Return _CityID
				End Get
				Set(ByVal value As System.Int32)
					_CityID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const AddressID As String = "AddressID"
				Public Const Address As String = "Address"
				Public Const CityID As String = "CityID"
		
    Public Enum ColumnNames
				AddressID
				Address
				CityID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.AddressID
					Return AddressID
					Case ColumnNames.Address
					Return Address
					Case ColumnNames.CityID
					Return CityID
                    Case Else
                        Return AddressID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared AddressID As System.Type = GetType(System.Int32)
				Public Shared Address As System.Type = GetType(System.String)
				Public Shared CityID As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(Address_In AS System.String, CityID_In AS System.Int32)
					SetDefaults
							_Address = Address_In
							_CityID = CityID_In
End Sub

#End Region
Private Sub SetDefaults()
			AddressID = 0
			Address = string.empty
			CityID = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property AddressID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [AddressID] FROM [datAddresses] WHERE [AddressID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datAddresses] SET [AddressID] = @Value WHERE [AddressID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Address(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Address] FROM [datAddresses] WHERE [AddressID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datAddresses] SET [Address] = @Value WHERE [AddressID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property CityID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [CityID] FROM [datAddresses] WHERE [AddressID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datAddresses] SET [CityID] = @Value WHERE [AddressID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datAddresses, ByVal rhs As datAddresses) As Boolean
		If lhs.Address = rhs.Address ANDALSO lhs.CityID = rhs.CityID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datAddresses, ByVal rhs As datAddresses) As Boolean
		If lhs.Address = rhs.Address ANDALSO lhs.CityID = rhs.CityID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datAssembly"
			Partial Public Class datAssembly
#Region "       - Variable Declarations - "
			Private _AssemblyID As System.Int32
			Public Property AssemblyID() As System.Int32
				Get
					Return _AssemblyID
				End Get
				Set(ByVal value As System.Int32)
					_AssemblyID = value
				End Set
			End Property
			Private _AssemblyTypeID As System.Int32
			Public Property AssemblyTypeID() As System.Int32
				Get
					Return _AssemblyTypeID
				End Get
				Set(ByVal value As System.Int32)
					_AssemblyTypeID = value
				End Set
			End Property
			Private _DateTime As System.DateTime
			Public Property DateTime() As System.DateTime
				Get
					Return _DateTime
				End Get
				Set(ByVal value As System.DateTime)
					_DateTime = value
				End Set
			End Property
			Private _Expiry As System.DateTime
			Public Property Expiry() As System.DateTime
				Get
					Return _Expiry
				End Get
				Set(ByVal value As System.DateTime)
					_Expiry = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const AssemblyID As String = "AssemblyID"
				Public Const AssemblyTypeID As String = "AssemblyTypeID"
				Public Const DateTime As String = "DateTime"
				Public Const Expiry As String = "Expiry"
		
    Public Enum ColumnNames
				AssemblyID
				AssemblyTypeID
				DateTime
				Expiry
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.AssemblyID
					Return AssemblyID
					Case ColumnNames.AssemblyTypeID
					Return AssemblyTypeID
					Case ColumnNames.DateTime
					Return DateTime
					Case ColumnNames.Expiry
					Return Expiry
                    Case Else
                        Return AssemblyID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared AssemblyID As System.Type = GetType(System.Int32)
				Public Shared AssemblyTypeID As System.Type = GetType(System.Int32)
				Public Shared DateTime As System.Type = GetType(System.DateTime)
				Public Shared Expiry As System.Type = GetType(System.DateTime)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(AssemblyTypeID_In AS System.Int32, DateTime_In AS System.DateTime, Expiry_In AS System.DateTime)
					SetDefaults
							_AssemblyTypeID = AssemblyTypeID_In
							_DateTime = DateTime_In
							_Expiry = Expiry_In
End Sub

#End Region
Private Sub SetDefaults()
			AssemblyID = 0
			AssemblyTypeID = 0
			DateTime = Nothing
			Expiry = Nothing
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property AssemblyID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [AssemblyID] FROM [datAssembly] WHERE [AssemblyID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datAssembly] SET [AssemblyID] = @Value WHERE [AssemblyID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property AssemblyTypeID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [AssemblyTypeID] FROM [datAssembly] WHERE [AssemblyID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datAssembly] SET [AssemblyTypeID] = @Value WHERE [AssemblyID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property DateTime(ByVal Key As System.Int32) As System.DateTime
				Get
					Dim Value As System.DateTime = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [DateTime] FROM [datAssembly] WHERE [AssemblyID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.DateTime)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datAssembly] SET [DateTime] = @Value WHERE [AssemblyID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Expiry(ByVal Key As System.Int32) As System.DateTime
				Get
					Dim Value As System.DateTime = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Expiry] FROM [datAssembly] WHERE [AssemblyID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.DateTime)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datAssembly] SET [Expiry] = @Value WHERE [AssemblyID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datAssembly, ByVal rhs As datAssembly) As Boolean
		If lhs.AssemblyTypeID = rhs.AssemblyTypeID ANDALSO lhs.DateTime = rhs.DateTime ANDALSO lhs.Expiry = rhs.Expiry Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datAssembly, ByVal rhs As datAssembly) As Boolean
		If lhs.AssemblyTypeID = rhs.AssemblyTypeID ANDALSO lhs.DateTime = rhs.DateTime ANDALSO lhs.Expiry = rhs.Expiry Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datBoxes"
			Partial Public Class datBoxes
#Region "       - Variable Declarations - "
			Private _BoxID As System.Int32
			Public Property BoxID() As System.Int32
				Get
					Return _BoxID
				End Get
				Set(ByVal value As System.Int32)
					_BoxID = value
				End Set
			End Property
			Private _AssemblyID As System.Int32
			Public Property AssemblyID() As System.Int32
				Get
					Return _AssemblyID
				End Get
				Set(ByVal value As System.Int32)
					_AssemblyID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const BoxID As String = "BoxID"
				Public Const AssemblyID As String = "AssemblyID"
		
    Public Enum ColumnNames
				BoxID
				AssemblyID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.BoxID
					Return BoxID
					Case ColumnNames.AssemblyID
					Return AssemblyID
                    Case Else
                        Return BoxID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared BoxID As System.Type = GetType(System.Int32)
				Public Shared AssemblyID As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(AssemblyID_In AS System.Int32)
					SetDefaults
							_AssemblyID = AssemblyID_In
End Sub

#End Region
Private Sub SetDefaults()
			BoxID = 0
			AssemblyID = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property BoxID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [BoxID] FROM [datBoxes] WHERE [BoxID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datBoxes] SET [BoxID] = @Value WHERE [BoxID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property AssemblyID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [AssemblyID] FROM [datBoxes] WHERE [BoxID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datBoxes] SET [AssemblyID] = @Value WHERE [BoxID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datBoxes, ByVal rhs As datBoxes) As Boolean
		If lhs.AssemblyID = rhs.AssemblyID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datBoxes, ByVal rhs As datBoxes) As Boolean
		If lhs.AssemblyID = rhs.AssemblyID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datClientOrders"
			Partial Public Class datClientOrders
#Region "       - Variable Declarations - "
			Private _OrderNumber As System.Int32
			Public Property OrderNumber() As System.Int32
				Get
					Return _OrderNumber
				End Get
				Set(ByVal value As System.Int32)
					_OrderNumber = value
				End Set
			End Property
			Private _ClientID As System.Int32
			Public Property ClientID() As System.Int32
				Get
					Return _ClientID
				End Get
				Set(ByVal value As System.Int32)
					_ClientID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const OrderNumber As String = "OrderNumber"
				Public Const ClientID As String = "ClientID"
		
    Public Enum ColumnNames
				OrderNumber
				ClientID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.OrderNumber
					Return OrderNumber
					Case ColumnNames.ClientID
					Return ClientID
                    Case Else
                        Return OrderNumber
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared OrderNumber As System.Type = GetType(System.Int32)
				Public Shared ClientID As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(ClientID_In AS System.Int32)
					SetDefaults
							_ClientID = ClientID_In
End Sub

#End Region
Private Sub SetDefaults()
			OrderNumber = 0
			ClientID = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property OrderNumber(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [OrderNumber] FROM [datClientOrders] WHERE [OrderNumber] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datClientOrders] SET [OrderNumber] = @Value WHERE [OrderNumber] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ClientID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ClientID] FROM [datClientOrders] WHERE [OrderNumber] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datClientOrders] SET [ClientID] = @Value WHERE [OrderNumber] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datClientOrders, ByVal rhs As datClientOrders) As Boolean
		If lhs.ClientID = rhs.ClientID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datClientOrders, ByVal rhs As datClientOrders) As Boolean
		If lhs.ClientID = rhs.ClientID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datClients"
			Partial Public Class datClients
#Region "       - Variable Declarations - "
			Private _ClientID As System.Int32
			Public Property ClientID() As System.Int32
				Get
					Return _ClientID
				End Get
				Set(ByVal value As System.Int32)
					_ClientID = value
				End Set
			End Property
			Private _ClientName As System.String
			Public Property ClientName() As System.String
				Get
					Return _ClientName
				End Get
				Set(ByVal value As System.String)
					_ClientName = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const ClientID As String = "ClientID"
				Public Const ClientName As String = "ClientName"
		
    Public Enum ColumnNames
				ClientID
				ClientName
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.ClientID
					Return ClientID
					Case ColumnNames.ClientName
					Return ClientName
                    Case Else
                        Return ClientID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared ClientID As System.Type = GetType(System.Int32)
				Public Shared ClientName As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(ClientName_In AS System.String)
					SetDefaults
							_ClientName = ClientName_In
End Sub

#End Region
Private Sub SetDefaults()
			ClientID = 0
			ClientName = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property ClientID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ClientID] FROM [datClients] WHERE [ClientID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datClients] SET [ClientID] = @Value WHERE [ClientID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ClientName(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ClientName] FROM [datClients] WHERE [ClientID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datClients] SET [ClientName] = @Value WHERE [ClientID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datClients, ByVal rhs As datClients) As Boolean
		If lhs.ClientName = rhs.ClientName Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datClients, ByVal rhs As datClients) As Boolean
		If lhs.ClientName = rhs.ClientName Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datContacts"
			Partial Public Class datContacts
#Region "       - Variable Declarations - "
			Private _ContactID As System.Int32
			Public Property ContactID() As System.Int32
				Get
					Return _ContactID
				End Get
				Set(ByVal value As System.Int32)
					_ContactID = value
				End Set
			End Property
			Private _PeopleID As System.Int32
			Public Property PeopleID() As System.Int32
				Get
					Return _PeopleID
				End Get
				Set(ByVal value As System.Int32)
					_PeopleID = value
				End Set
			End Property
			Private _PhoneID As System.Int32
			Public Property PhoneID() As System.Int32
				Get
					Return _PhoneID
				End Get
				Set(ByVal value As System.Int32)
					_PhoneID = value
				End Set
			End Property
			Private _ContactTypeID As System.Byte
			Public Property ContactTypeID() As System.Byte
				Get
					Return _ContactTypeID
				End Get
				Set(ByVal value As System.Byte)
					_ContactTypeID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const ContactID As String = "ContactID"
				Public Const PeopleID As String = "PeopleID"
				Public Const PhoneID As String = "PhoneID"
				Public Const ContactTypeID As String = "ContactTypeID"
		
    Public Enum ColumnNames
				ContactID
				PeopleID
				PhoneID
				ContactTypeID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.ContactID
					Return ContactID
					Case ColumnNames.PeopleID
					Return PeopleID
					Case ColumnNames.PhoneID
					Return PhoneID
					Case ColumnNames.ContactTypeID
					Return ContactTypeID
                    Case Else
                        Return ContactID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared ContactID As System.Type = GetType(System.Int32)
				Public Shared PeopleID As System.Type = GetType(System.Int32)
				Public Shared PhoneID As System.Type = GetType(System.Int32)
				Public Shared ContactTypeID As System.Type = GetType(System.Byte)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(PeopleID_In AS System.Int32, PhoneID_In AS System.Int32, ContactTypeID_In AS System.Byte)
					SetDefaults
							_PeopleID = PeopleID_In
							_PhoneID = PhoneID_In
							_ContactTypeID = ContactTypeID_In
End Sub

#End Region
Private Sub SetDefaults()
			ContactID = 0
			PeopleID = 0
			PhoneID = 0
			ContactTypeID = Nothing
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property ContactID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ContactID] FROM [datContacts] WHERE [ContactID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datContacts] SET [ContactID] = @Value WHERE [ContactID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property PeopleID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PeopleID] FROM [datContacts] WHERE [ContactID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datContacts] SET [PeopleID] = @Value WHERE [ContactID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property PhoneID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PhoneID] FROM [datContacts] WHERE [ContactID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datContacts] SET [PhoneID] = @Value WHERE [ContactID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ContactTypeID(ByVal Key As System.Int32) As System.Byte
				Get
					Dim Value As System.Byte = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ContactTypeID] FROM [datContacts] WHERE [ContactID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Byte)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datContacts] SET [ContactTypeID] = @Value WHERE [ContactID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datContacts, ByVal rhs As datContacts) As Boolean
		If lhs.PeopleID = rhs.PeopleID ANDALSO lhs.PhoneID = rhs.PhoneID ANDALSO lhs.ContactTypeID = rhs.ContactTypeID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datContacts, ByVal rhs As datContacts) As Boolean
		If lhs.PeopleID = rhs.PeopleID ANDALSO lhs.PhoneID = rhs.PhoneID ANDALSO lhs.ContactTypeID = rhs.ContactTypeID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datEmployees"
			Partial Public Class datEmployees
#Region "       - Variable Declarations - "
			Private _EmployeeID As System.Int32
			Public Property EmployeeID() As System.Int32
				Get
					Return _EmployeeID
				End Get
				Set(ByVal value As System.Int32)
					_EmployeeID = value
				End Set
			End Property
			Private _PositionID As System.Int32
			Public Property PositionID() As System.Int32
				Get
					Return _PositionID
				End Get
				Set(ByVal value As System.Int32)
					_PositionID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const EmployeeID As String = "EmployeeID"
				Public Const PositionID As String = "PositionID"
		
    Public Enum ColumnNames
				EmployeeID
				PositionID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.EmployeeID
					Return EmployeeID
					Case ColumnNames.PositionID
					Return PositionID
                    Case Else
                        Return EmployeeID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared EmployeeID As System.Type = GetType(System.Int32)
				Public Shared PositionID As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(PositionID_In AS System.Int32)
					SetDefaults
							_PositionID = PositionID_In
End Sub

#End Region
Private Sub SetDefaults()
			EmployeeID = 0
			PositionID = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property EmployeeID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [EmployeeID] FROM [datEmployees] WHERE [EmployeeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datEmployees] SET [EmployeeID] = @Value WHERE [EmployeeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property PositionID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PositionID] FROM [datEmployees] WHERE [EmployeeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datEmployees] SET [PositionID] = @Value WHERE [EmployeeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datEmployees, ByVal rhs As datEmployees) As Boolean
		If lhs.PositionID = rhs.PositionID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datEmployees, ByVal rhs As datEmployees) As Boolean
		If lhs.PositionID = rhs.PositionID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datIngredientInventory"
			Partial Public Class datIngredientInventory
#Region "       - Variable Declarations - "
			Private _IngInvID As System.Int32
			Public Property IngInvID() As System.Int32
				Get
					Return _IngInvID
				End Get
				Set(ByVal value As System.Int32)
					_IngInvID = value
				End Set
			End Property
			Private _PurchaseID As System.Int32
			Public Property PurchaseID() As System.Int32
				Get
					Return _PurchaseID
				End Get
				Set(ByVal value As System.Int32)
					_PurchaseID = value
				End Set
			End Property
			Private _IngredientID As System.Int32
			Public Property IngredientID() As System.Int32
				Get
					Return _IngredientID
				End Get
				Set(ByVal value As System.Int32)
					_IngredientID = value
				End Set
			End Property
			Private _Amount As System.Double
			Public Property Amount() As System.Double
				Get
					Return _Amount
				End Get
				Set(ByVal value As System.Double)
					_Amount = value
				End Set
			End Property
			Private _UnitsID As System.Int32
			Public Property UnitsID() As System.Int32
				Get
					Return _UnitsID
				End Get
				Set(ByVal value As System.Int32)
					_UnitsID = value
				End Set
			End Property
			Private _ExpDate As System.DateTime
			Public Property ExpDate() As System.DateTime
				Get
					Return _ExpDate
				End Get
				Set(ByVal value As System.DateTime)
					_ExpDate = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const IngInvID As String = "IngInvID"
				Public Const PurchaseID As String = "PurchaseID"
				Public Const IngredientID As String = "IngredientID"
				Public Const Amount As String = "Amount"
				Public Const UnitsID As String = "UnitsID"
				Public Const ExpDate As String = "ExpDate"
		
    Public Enum ColumnNames
				IngInvID
				PurchaseID
				IngredientID
				Amount
				UnitsID
				ExpDate
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.IngInvID
					Return IngInvID
					Case ColumnNames.PurchaseID
					Return PurchaseID
					Case ColumnNames.IngredientID
					Return IngredientID
					Case ColumnNames.Amount
					Return Amount
					Case ColumnNames.UnitsID
					Return UnitsID
					Case ColumnNames.ExpDate
					Return ExpDate
                    Case Else
                        Return IngInvID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared IngInvID As System.Type = GetType(System.Int32)
				Public Shared PurchaseID As System.Type = GetType(System.Int32)
				Public Shared IngredientID As System.Type = GetType(System.Int32)
				Public Shared Amount As System.Type = GetType(System.Double)
				Public Shared UnitsID As System.Type = GetType(System.Int32)
				Public Shared ExpDate As System.Type = GetType(System.DateTime)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(PurchaseID_In AS System.Int32, IngredientID_In AS System.Int32, Amount_In AS System.Double, UnitsID_In AS System.Int32, ExpDate_In AS System.DateTime)
					SetDefaults
							_PurchaseID = PurchaseID_In
							_IngredientID = IngredientID_In
							_Amount = Amount_In
							_UnitsID = UnitsID_In
							_ExpDate = ExpDate_In
End Sub

#End Region
Private Sub SetDefaults()
			IngInvID = 0
			PurchaseID = 0
			IngredientID = 0
			Amount = Nothing
			UnitsID = 0
			ExpDate = Nothing
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property IngInvID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [IngInvID] FROM [datIngredientInventory] WHERE [IngInvID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datIngredientInventory] SET [IngInvID] = @Value WHERE [IngInvID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property PurchaseID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PurchaseID] FROM [datIngredientInventory] WHERE [IngInvID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datIngredientInventory] SET [PurchaseID] = @Value WHERE [IngInvID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property IngredientID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [IngredientID] FROM [datIngredientInventory] WHERE [IngInvID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datIngredientInventory] SET [IngredientID] = @Value WHERE [IngInvID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Amount(ByVal Key As System.Int32) As System.Double
				Get
					Dim Value As System.Double = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Amount] FROM [datIngredientInventory] WHERE [IngInvID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Double)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datIngredientInventory] SET [Amount] = @Value WHERE [IngInvID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property UnitsID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [UnitsID] FROM [datIngredientInventory] WHERE [IngInvID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datIngredientInventory] SET [UnitsID] = @Value WHERE [IngInvID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ExpDate(ByVal Key As System.Int32) As System.DateTime
				Get
					Dim Value As System.DateTime = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ExpDate] FROM [datIngredientInventory] WHERE [IngInvID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.DateTime)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datIngredientInventory] SET [ExpDate] = @Value WHERE [IngInvID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datIngredientInventory, ByVal rhs As datIngredientInventory) As Boolean
		If lhs.PurchaseID = rhs.PurchaseID ANDALSO lhs.IngredientID = rhs.IngredientID ANDALSO lhs.Amount = rhs.Amount ANDALSO lhs.UnitsID = rhs.UnitsID ANDALSO lhs.ExpDate = rhs.ExpDate Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datIngredientInventory, ByVal rhs As datIngredientInventory) As Boolean
		If lhs.PurchaseID = rhs.PurchaseID ANDALSO lhs.IngredientID = rhs.IngredientID ANDALSO lhs.Amount = rhs.Amount ANDALSO lhs.UnitsID = rhs.UnitsID ANDALSO lhs.ExpDate = rhs.ExpDate Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datMeasurements"
			Partial Public Class datMeasurements
#Region "       - Variable Declarations - "
			Private _MeasurementID As System.Int32
			Public Property MeasurementID() As System.Int32
				Get
					Return _MeasurementID
				End Get
				Set(ByVal value As System.Int32)
					_MeasurementID = value
				End Set
			End Property
			Private _ParentID As System.Int32
			Public Property ParentID() As System.Int32
				Get
					Return _ParentID
				End Get
				Set(ByVal value As System.Int32)
					_ParentID = value
				End Set
			End Property
			Private _DateTime As System.DateTime
			Public Property DateTime() As System.DateTime
				Get
					Return _DateTime
				End Get
				Set(ByVal value As System.DateTime)
					_DateTime = value
				End Set
			End Property
			Private _Thickness As System.Double
			Public Property Thickness() As System.Double
				Get
					Return _Thickness
				End Get
				Set(ByVal value As System.Double)
					_Thickness = value
				End Set
			End Property
			Private _Weight As System.Double
			Public Property Weight() As System.Double
				Get
					Return _Weight
				End Get
				Set(ByVal value As System.Double)
					_Weight = value
				End Set
			End Property
			Private _Length As System.Double
			Public Property Length() As System.Double
				Get
					Return _Length
				End Get
				Set(ByVal value As System.Double)
					_Length = value
				End Set
			End Property
			Private _Width As System.Double
			Public Property Width() As System.Double
				Get
					Return _Width
				End Get
				Set(ByVal value As System.Double)
					_Width = value
				End Set
			End Property
			Private _Employee As System.Int32
			Public Property Employee() As System.Int32
				Get
					Return _Employee
				End Get
				Set(ByVal value As System.Int32)
					_Employee = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const MeasurementID As String = "MeasurementID"
				Public Const ParentID As String = "ParentID"
				Public Const DateTime As String = "DateTime"
				Public Const Thickness As String = "Thickness"
				Public Const Weight As String = "Weight"
				Public Const Length As String = "Length"
				Public Const Width As String = "Width"
				Public Const Employee As String = "Employee"
		
    Public Enum ColumnNames
				MeasurementID
				ParentID
				DateTime
				Thickness
				Weight
				Length
				Width
				Employee
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.MeasurementID
					Return MeasurementID
					Case ColumnNames.ParentID
					Return ParentID
					Case ColumnNames.DateTime
					Return DateTime
					Case ColumnNames.Thickness
					Return Thickness
					Case ColumnNames.Weight
					Return Weight
					Case ColumnNames.Length
					Return Length
					Case ColumnNames.Width
					Return Width
					Case ColumnNames.Employee
					Return Employee
                    Case Else
                        Return MeasurementID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared MeasurementID As System.Type = GetType(System.Int32)
				Public Shared ParentID As System.Type = GetType(System.Int32)
				Public Shared DateTime As System.Type = GetType(System.DateTime)
				Public Shared Thickness As System.Type = GetType(System.Double)
				Public Shared Weight As System.Type = GetType(System.Double)
				Public Shared Length As System.Type = GetType(System.Double)
				Public Shared Width As System.Type = GetType(System.Double)
				Public Shared Employee As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(ParentID_In AS System.Int32, DateTime_In AS System.DateTime, Thickness_In AS System.Double, Weight_In AS System.Double, Length_In AS System.Double, Width_In AS System.Double, Employee_In AS System.Int32)
					SetDefaults
							_ParentID = ParentID_In
							_DateTime = DateTime_In
							_Thickness = Thickness_In
							_Weight = Weight_In
							_Length = Length_In
							_Width = Width_In
							_Employee = Employee_In
End Sub

#End Region
Private Sub SetDefaults()
			MeasurementID = 0
			ParentID = 0
			DateTime = Nothing
			Thickness = Nothing
			Weight = Nothing
			Length = Nothing
			Width = Nothing
			Employee = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property MeasurementID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [MeasurementID] FROM [datMeasurements] WHERE [MeasurementID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datMeasurements] SET [MeasurementID] = @Value WHERE [MeasurementID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ParentID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ParentID] FROM [datMeasurements] WHERE [MeasurementID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datMeasurements] SET [ParentID] = @Value WHERE [MeasurementID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property DateTime(ByVal Key As System.Int32) As System.DateTime
				Get
					Dim Value As System.DateTime = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [DateTime] FROM [datMeasurements] WHERE [MeasurementID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.DateTime)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datMeasurements] SET [DateTime] = @Value WHERE [MeasurementID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Thickness(ByVal Key As System.Int32) As System.Double
				Get
					Dim Value As System.Double = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Thickness] FROM [datMeasurements] WHERE [MeasurementID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Double)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datMeasurements] SET [Thickness] = @Value WHERE [MeasurementID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Weight(ByVal Key As System.Int32) As System.Double
				Get
					Dim Value As System.Double = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Weight] FROM [datMeasurements] WHERE [MeasurementID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Double)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datMeasurements] SET [Weight] = @Value WHERE [MeasurementID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Length(ByVal Key As System.Int32) As System.Double
				Get
					Dim Value As System.Double = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Length] FROM [datMeasurements] WHERE [MeasurementID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Double)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datMeasurements] SET [Length] = @Value WHERE [MeasurementID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Width(ByVal Key As System.Int32) As System.Double
				Get
					Dim Value As System.Double = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Width] FROM [datMeasurements] WHERE [MeasurementID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Double)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datMeasurements] SET [Width] = @Value WHERE [MeasurementID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Employee(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Employee] FROM [datMeasurements] WHERE [MeasurementID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datMeasurements] SET [Employee] = @Value WHERE [MeasurementID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datMeasurements, ByVal rhs As datMeasurements) As Boolean
		If lhs.ParentID = rhs.ParentID ANDALSO lhs.DateTime = rhs.DateTime ANDALSO lhs.Thickness = rhs.Thickness ANDALSO lhs.Weight = rhs.Weight ANDALSO lhs.Length = rhs.Length ANDALSO lhs.Width = rhs.Width ANDALSO lhs.Employee = rhs.Employee Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datMeasurements, ByVal rhs As datMeasurements) As Boolean
		If lhs.ParentID = rhs.ParentID ANDALSO lhs.DateTime = rhs.DateTime ANDALSO lhs.Thickness = rhs.Thickness ANDALSO lhs.Weight = rhs.Weight ANDALSO lhs.Length = rhs.Length ANDALSO lhs.Width = rhs.Width ANDALSO lhs.Employee = rhs.Employee Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datPackages"
			Partial Public Class datPackages
#Region "       - Variable Declarations - "
			Private _PackageID As System.Int32
			Public Property PackageID() As System.Int32
				Get
					Return _PackageID
				End Get
				Set(ByVal value As System.Int32)
					_PackageID = value
				End Set
			End Property
			Private _PackageNumber As System.String
			Public Property PackageNumber() As System.String
				Get
					Return _PackageNumber
				End Get
				Set(ByVal value As System.String)
					_PackageNumber = value
				End Set
			End Property
			Private _TrayID As System.Int32
			Public Property TrayID() As System.Int32
				Get
					Return _TrayID
				End Get
				Set(ByVal value As System.Int32)
					_TrayID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const PackageID As String = "PackageID"
				Public Const PackageNumber As String = "PackageNumber"
				Public Const TrayID As String = "TrayID"
		
    Public Enum ColumnNames
				PackageID
				PackageNumber
				TrayID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.PackageID
					Return PackageID
					Case ColumnNames.PackageNumber
					Return PackageNumber
					Case ColumnNames.TrayID
					Return TrayID
                    Case Else
                        Return PackageID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared PackageID As System.Type = GetType(System.Int32)
				Public Shared PackageNumber As System.Type = GetType(System.String)
				Public Shared TrayID As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(PackageNumber_In AS System.String, TrayID_In AS System.Int32)
					SetDefaults
							_PackageNumber = PackageNumber_In
							_TrayID = TrayID_In
End Sub

#End Region
Private Sub SetDefaults()
			PackageID = 0
			PackageNumber = string.empty
			TrayID = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property PackageID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PackageID] FROM [datPackages] WHERE [PackageID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPackages] SET [PackageID] = @Value WHERE [PackageID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property PackageNumber(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PackageNumber] FROM [datPackages] WHERE [PackageID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPackages] SET [PackageNumber] = @Value WHERE [PackageID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property TrayID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [TrayID] FROM [datPackages] WHERE [PackageID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPackages] SET [TrayID] = @Value WHERE [PackageID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datPackages, ByVal rhs As datPackages) As Boolean
		If lhs.PackageNumber = rhs.PackageNumber ANDALSO lhs.TrayID = rhs.TrayID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datPackages, ByVal rhs As datPackages) As Boolean
		If lhs.PackageNumber = rhs.PackageNumber ANDALSO lhs.TrayID = rhs.TrayID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datPeople"
			Partial Public Class datPeople
#Region "       - Variable Declarations - "
			Private _PeopleID As System.Int32
			Public Property PeopleID() As System.Int32
				Get
					Return _PeopleID
				End Get
				Set(ByVal value As System.Int32)
					_PeopleID = value
				End Set
			End Property
			Private _Name As System.String
			Public Property Name() As System.String
				Get
					Return _Name
				End Get
				Set(ByVal value As System.String)
					_Name = value
				End Set
			End Property
			Private _Notes As System.String
			Public Property Notes() As System.String
				Get
					Return _Notes
				End Get
				Set(ByVal value As System.String)
					_Notes = value
				End Set
			End Property
			Private _Email As System.String
			Public Property Email() As System.String
				Get
					Return _Email
				End Get
				Set(ByVal value As System.String)
					_Email = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const PeopleID As String = "PeopleID"
				Public Const Name As String = "Name"
				Public Const Notes As String = "Notes"
				Public Const Email As String = "Email"
		
    Public Enum ColumnNames
				PeopleID
				Name
				Notes
				Email
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.PeopleID
					Return PeopleID
					Case ColumnNames.Name
					Return Name
					Case ColumnNames.Notes
					Return Notes
					Case ColumnNames.Email
					Return Email
                    Case Else
                        Return PeopleID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared PeopleID As System.Type = GetType(System.Int32)
				Public Shared Name As System.Type = GetType(System.String)
				Public Shared Notes As System.Type = GetType(System.String)
				Public Shared Email As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(Name_In AS System.String, Notes_In AS System.String, Email_In AS System.String)
					SetDefaults
							_Name = Name_In
							_Notes = Notes_In
							_Email = Email_In
End Sub

#End Region
Private Sub SetDefaults()
			PeopleID = 0
			Name = string.empty
			Notes = string.empty
			Email = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property PeopleID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PeopleID] FROM [datPeople] WHERE [PeopleID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPeople] SET [PeopleID] = @Value WHERE [PeopleID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Name(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Name] FROM [datPeople] WHERE [PeopleID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPeople] SET [Name] = @Value WHERE [PeopleID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Notes(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Notes] FROM [datPeople] WHERE [PeopleID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPeople] SET [Notes] = @Value WHERE [PeopleID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Email(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Email] FROM [datPeople] WHERE [PeopleID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPeople] SET [Email] = @Value WHERE [PeopleID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datPeople, ByVal rhs As datPeople) As Boolean
		If lhs.Name = rhs.Name ANDALSO lhs.Notes = rhs.Notes ANDALSO lhs.Email = rhs.Email Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datPeople, ByVal rhs As datPeople) As Boolean
		If lhs.Name = rhs.Name ANDALSO lhs.Notes = rhs.Notes ANDALSO lhs.Email = rhs.Email Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datPhones"
			Partial Public Class datPhones
#Region "       - Variable Declarations - "
			Private _PhoneID As System.Int32
			Public Property PhoneID() As System.Int32
				Get
					Return _PhoneID
				End Get
				Set(ByVal value As System.Int32)
					_PhoneID = value
				End Set
			End Property
			Private _PhoneNumber As System.String
			Public Property PhoneNumber() As System.String
				Get
					Return _PhoneNumber
				End Get
				Set(ByVal value As System.String)
					_PhoneNumber = value
				End Set
			End Property
			Private _Ext As System.String
			Public Property Ext() As System.String
				Get
					Return _Ext
				End Get
				Set(ByVal value As System.String)
					_Ext = value
				End Set
			End Property
			Private _PhoneTypeID As System.Byte
			Public Property PhoneTypeID() As System.Byte
				Get
					Return _PhoneTypeID
				End Get
				Set(ByVal value As System.Byte)
					_PhoneTypeID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const PhoneID As String = "PhoneID"
				Public Const PhoneNumber As String = "PhoneNumber"
				Public Const Ext As String = "Ext"
				Public Const PhoneTypeID As String = "PhoneTypeID"
		
    Public Enum ColumnNames
				PhoneID
				PhoneNumber
				Ext
				PhoneTypeID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.PhoneID
					Return PhoneID
					Case ColumnNames.PhoneNumber
					Return PhoneNumber
					Case ColumnNames.Ext
					Return Ext
					Case ColumnNames.PhoneTypeID
					Return PhoneTypeID
                    Case Else
                        Return PhoneID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared PhoneID As System.Type = GetType(System.Int32)
				Public Shared PhoneNumber As System.Type = GetType(System.String)
				Public Shared Ext As System.Type = GetType(System.String)
				Public Shared PhoneTypeID As System.Type = GetType(System.Byte)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(PhoneNumber_In AS System.String, Ext_In AS System.String, PhoneTypeID_In AS System.Byte)
					SetDefaults
							_PhoneNumber = PhoneNumber_In
							_Ext = Ext_In
							_PhoneTypeID = PhoneTypeID_In
End Sub

#End Region
Private Sub SetDefaults()
			PhoneID = 0
			PhoneNumber = string.empty
			Ext = string.empty
			PhoneTypeID = Nothing
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property PhoneID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PhoneID] FROM [datPhones] WHERE [PhoneID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPhones] SET [PhoneID] = @Value WHERE [PhoneID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property PhoneNumber(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PhoneNumber] FROM [datPhones] WHERE [PhoneID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPhones] SET [PhoneNumber] = @Value WHERE [PhoneID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Ext(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Ext] FROM [datPhones] WHERE [PhoneID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPhones] SET [Ext] = @Value WHERE [PhoneID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property PhoneTypeID(ByVal Key As System.Int32) As System.Byte
				Get
					Dim Value As System.Byte = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PhoneTypeID] FROM [datPhones] WHERE [PhoneID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Byte)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPhones] SET [PhoneTypeID] = @Value WHERE [PhoneID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datPhones, ByVal rhs As datPhones) As Boolean
		If lhs.PhoneNumber = rhs.PhoneNumber ANDALSO lhs.Ext = rhs.Ext ANDALSO lhs.PhoneTypeID = rhs.PhoneTypeID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datPhones, ByVal rhs As datPhones) As Boolean
		If lhs.PhoneNumber = rhs.PhoneNumber ANDALSO lhs.Ext = rhs.Ext ANDALSO lhs.PhoneTypeID = rhs.PhoneTypeID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datPurchaseOrders"
			Partial Public Class datPurchaseOrders
#Region "       - Variable Declarations - "
			Private _PurchaseID As System.Int32
			Public Property PurchaseID() As System.Int32
				Get
					Return _PurchaseID
				End Get
				Set(ByVal value As System.Int32)
					_PurchaseID = value
				End Set
			End Property
			Private _PONumber As System.Int32
			Public Property PONumber() As System.Int32
				Get
					Return _PONumber
				End Get
				Set(ByVal value As System.Int32)
					_PONumber = value
				End Set
			End Property
			Private _VendorID As System.Int32
			Public Property VendorID() As System.Int32
				Get
					Return _VendorID
				End Get
				Set(ByVal value As System.Int32)
					_VendorID = value
				End Set
			End Property
			Private _Date As System.DateTime
			Public Property Date() As System.DateTime
				Get
					Return _Date
				End Get
				Set(ByVal value As System.DateTime)
					_Date = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const PurchaseID As String = "PurchaseID"
				Public Const PONumber As String = "PONumber"
				Public Const VendorID As String = "VendorID"
            Public Const Date As String = "Date"
		
    Public Enum ColumnNames
				PurchaseID
				PONumber
				VendorID
				Date
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.PurchaseID
					Return PurchaseID
					Case ColumnNames.PONumber
					Return PONumber
					Case ColumnNames.VendorID
					Return VendorID
					Case ColumnNames.Date
					Return Date
                    Case Else
                        Return PurchaseID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared PurchaseID As System.Type = GetType(System.Int32)
				Public Shared PONumber As System.Type = GetType(System.Int32)
				Public Shared VendorID As System.Type = GetType(System.Int32)
				Public Shared Date As System.Type = GetType(System.DateTime)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(PONumber_In AS System.Int32, VendorID_In AS System.Int32, Date_In AS System.DateTime)
					SetDefaults
							_PONumber = PONumber_In
							_VendorID = VendorID_In
							_Date = Date_In
End Sub

#End Region
Private Sub SetDefaults()
			PurchaseID = 0
			PONumber = 0
			VendorID = 0
			Date = Nothing
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property PurchaseID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PurchaseID] FROM [datPurchaseOrders] WHERE [PurchaseID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPurchaseOrders] SET [PurchaseID] = @Value WHERE [PurchaseID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property PONumber(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PONumber] FROM [datPurchaseOrders] WHERE [PurchaseID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPurchaseOrders] SET [PONumber] = @Value WHERE [PurchaseID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property VendorID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [VendorID] FROM [datPurchaseOrders] WHERE [PurchaseID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPurchaseOrders] SET [VendorID] = @Value WHERE [PurchaseID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Date(ByVal Key As System.Int32) As System.DateTime
				Get
					Dim Value As System.DateTime = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Date] FROM [datPurchaseOrders] WHERE [PurchaseID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.DateTime)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datPurchaseOrders] SET [Date] = @Value WHERE [PurchaseID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datPurchaseOrders, ByVal rhs As datPurchaseOrders) As Boolean
		If lhs.PONumber = rhs.PONumber ANDALSO lhs.VendorID = rhs.VendorID ANDALSO lhs.Date = rhs.Date Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datPurchaseOrders, ByVal rhs As datPurchaseOrders) As Boolean
		If lhs.PONumber = rhs.PONumber ANDALSO lhs.VendorID = rhs.VendorID ANDALSO lhs.Date = rhs.Date Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datShipments"
			Partial Public Class datShipments
#Region "       - Variable Declarations - "
			Private _ShipmentID As System.Int32
			Public Property ShipmentID() As System.Int32
				Get
					Return _ShipmentID
				End Get
				Set(ByVal value As System.Int32)
					_ShipmentID = value
				End Set
			End Property
			Private _AddressID As System.Int32
			Public Property AddressID() As System.Int32
				Get
					Return _AddressID
				End Get
				Set(ByVal value As System.Int32)
					_AddressID = value
				End Set
			End Property
			Private _OrderNumber As System.Int32
			Public Property OrderNumber() As System.Int32
				Get
					Return _OrderNumber
				End Get
				Set(ByVal value As System.Int32)
					_OrderNumber = value
				End Set
			End Property
			Private _VehicleID As System.Int32
			Public Property VehicleID() As System.Int32
				Get
					Return _VehicleID
				End Get
				Set(ByVal value As System.Int32)
					_VehicleID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const ShipmentID As String = "ShipmentID"
				Public Const AddressID As String = "AddressID"
				Public Const OrderNumber As String = "OrderNumber"
				Public Const VehicleID As String = "VehicleID"
		
    Public Enum ColumnNames
				ShipmentID
				AddressID
				OrderNumber
				VehicleID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.ShipmentID
					Return ShipmentID
					Case ColumnNames.AddressID
					Return AddressID
					Case ColumnNames.OrderNumber
					Return OrderNumber
					Case ColumnNames.VehicleID
					Return VehicleID
                    Case Else
                        Return ShipmentID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared ShipmentID As System.Type = GetType(System.Int32)
				Public Shared AddressID As System.Type = GetType(System.Int32)
				Public Shared OrderNumber As System.Type = GetType(System.Int32)
				Public Shared VehicleID As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(AddressID_In AS System.Int32, OrderNumber_In AS System.Int32, VehicleID_In AS System.Int32)
					SetDefaults
							_AddressID = AddressID_In
							_OrderNumber = OrderNumber_In
							_VehicleID = VehicleID_In
End Sub

#End Region
Private Sub SetDefaults()
			ShipmentID = 0
			AddressID = 0
			OrderNumber = 0
			VehicleID = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property ShipmentID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ShipmentID] FROM [datShipments] WHERE [ShipmentID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datShipments] SET [ShipmentID] = @Value WHERE [ShipmentID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property AddressID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [AddressID] FROM [datShipments] WHERE [ShipmentID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datShipments] SET [AddressID] = @Value WHERE [ShipmentID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property OrderNumber(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [OrderNumber] FROM [datShipments] WHERE [ShipmentID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datShipments] SET [OrderNumber] = @Value WHERE [ShipmentID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property VehicleID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [VehicleID] FROM [datShipments] WHERE [ShipmentID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datShipments] SET [VehicleID] = @Value WHERE [ShipmentID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datShipments, ByVal rhs As datShipments) As Boolean
		If lhs.AddressID = rhs.AddressID ANDALSO lhs.OrderNumber = rhs.OrderNumber ANDALSO lhs.VehicleID = rhs.VehicleID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datShipments, ByVal rhs As datShipments) As Boolean
		If lhs.AddressID = rhs.AddressID ANDALSO lhs.OrderNumber = rhs.OrderNumber ANDALSO lhs.VehicleID = rhs.VehicleID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datTrays"
			Partial Public Class datTrays
#Region "       - Variable Declarations - "
			Private _TrayID As System.Int32
			Public Property TrayID() As System.Int32
				Get
					Return _TrayID
				End Get
				Set(ByVal value As System.Int32)
					_TrayID = value
				End Set
			End Property
			Private _WorkStationID As System.Int32
			Public Property WorkStationID() As System.Int32
				Get
					Return _WorkStationID
				End Get
				Set(ByVal value As System.Int32)
					_WorkStationID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const TrayID As String = "TrayID"
				Public Const WorkStationID As String = "WorkStationID"
		
    Public Enum ColumnNames
				TrayID
				WorkStationID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.TrayID
					Return TrayID
					Case ColumnNames.WorkStationID
					Return WorkStationID
                    Case Else
                        Return TrayID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared TrayID As System.Type = GetType(System.Int32)
				Public Shared WorkStationID As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(WorkStationID_In AS System.Int32)
					SetDefaults
							_WorkStationID = WorkStationID_In
End Sub

#End Region
Private Sub SetDefaults()
			TrayID = 0
			WorkStationID = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property TrayID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [TrayID] FROM [datTrays] WHERE [TrayID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datTrays] SET [TrayID] = @Value WHERE [TrayID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property WorkStationID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [WorkStationID] FROM [datTrays] WHERE [TrayID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datTrays] SET [WorkStationID] = @Value WHERE [TrayID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datTrays, ByVal rhs As datTrays) As Boolean
		If lhs.WorkStationID = rhs.WorkStationID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datTrays, ByVal rhs As datTrays) As Boolean
		If lhs.WorkStationID = rhs.WorkStationID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datVehicleCleaning"
			Partial Public Class datVehicleCleaning
#Region "       - Variable Declarations - "
			Private _CleaningID As System.Int32
			Public Property CleaningID() As System.Int32
				Get
					Return _CleaningID
				End Get
				Set(ByVal value As System.Int32)
					_CleaningID = value
				End Set
			End Property
			Private _VehicleID As System.Int32
			Public Property VehicleID() As System.Int32
				Get
					Return _VehicleID
				End Get
				Set(ByVal value As System.Int32)
					_VehicleID = value
				End Set
			End Property
			Private _EmployeeID As System.Int32
			Public Property EmployeeID() As System.Int32
				Get
					Return _EmployeeID
				End Get
				Set(ByVal value As System.Int32)
					_EmployeeID = value
				End Set
			End Property
			Private _Date As System.DateTime
			Public Property Date() As System.DateTime
				Get
					Return _Date
				End Get
				Set(ByVal value As System.DateTime)
					_Date = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const CleaningID As String = "CleaningID"
				Public Const VehicleID As String = "VehicleID"
				Public Const EmployeeID As String = "EmployeeID"
				Public Const Date As String = "Date"
		
    Public Enum ColumnNames
				CleaningID
				VehicleID
				EmployeeID
				Date
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.CleaningID
					Return CleaningID
					Case ColumnNames.VehicleID
					Return VehicleID
					Case ColumnNames.EmployeeID
					Return EmployeeID
					Case ColumnNames.Date
					Return Date
                    Case Else
                        Return CleaningID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared CleaningID As System.Type = GetType(System.Int32)
				Public Shared VehicleID As System.Type = GetType(System.Int32)
				Public Shared EmployeeID As System.Type = GetType(System.Int32)
				Public Shared Date As System.Type = GetType(System.DateTime)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(VehicleID_In AS System.Int32, EmployeeID_In AS System.Int32, Date_In AS System.DateTime)
					SetDefaults
							_VehicleID = VehicleID_In
							_EmployeeID = EmployeeID_In
							_Date = Date_In
End Sub

#End Region
Private Sub SetDefaults()
			CleaningID = 0
			VehicleID = 0
			EmployeeID = 0
			Date = Nothing
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property CleaningID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [CleaningID] FROM [datVehicleCleaning] WHERE [CleaningID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datVehicleCleaning] SET [CleaningID] = @Value WHERE [CleaningID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property VehicleID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [VehicleID] FROM [datVehicleCleaning] WHERE [CleaningID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datVehicleCleaning] SET [VehicleID] = @Value WHERE [CleaningID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property EmployeeID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [EmployeeID] FROM [datVehicleCleaning] WHERE [CleaningID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datVehicleCleaning] SET [EmployeeID] = @Value WHERE [CleaningID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Date(ByVal Key As System.Int32) As System.DateTime
				Get
					Dim Value As System.DateTime = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Date] FROM [datVehicleCleaning] WHERE [CleaningID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.DateTime)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datVehicleCleaning] SET [Date] = @Value WHERE [CleaningID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datVehicleCleaning, ByVal rhs As datVehicleCleaning) As Boolean
		If lhs.VehicleID = rhs.VehicleID ANDALSO lhs.EmployeeID = rhs.EmployeeID ANDALSO lhs.Date = rhs.Date Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datVehicleCleaning, ByVal rhs As datVehicleCleaning) As Boolean
		If lhs.VehicleID = rhs.VehicleID ANDALSO lhs.EmployeeID = rhs.EmployeeID ANDALSO lhs.Date = rhs.Date Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datVehicles"
			Partial Public Class datVehicles
#Region "       - Variable Declarations - "
			Private _VehicleID As System.Int32
			Public Property VehicleID() As System.Int32
				Get
					Return _VehicleID
				End Get
				Set(ByVal value As System.Int32)
					_VehicleID = value
				End Set
			End Property
			Private _LicensePlate As System.String
			Public Property LicensePlate() As System.String
				Get
					Return _LicensePlate
				End Get
				Set(ByVal value As System.String)
					_LicensePlate = value
				End Set
			End Property
			Private _TypeID As System.Int32
			Public Property TypeID() As System.Int32
				Get
					Return _TypeID
				End Get
				Set(ByVal value As System.Int32)
					_TypeID = value
				End Set
			End Property
			Private _DatePurchased As System.DateTime
			Public Property DatePurchased() As System.DateTime
				Get
					Return _DatePurchased
				End Get
				Set(ByVal value As System.DateTime)
					_DatePurchased = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const VehicleID As String = "VehicleID"
				Public Const LicensePlate As String = "LicensePlate"
				Public Const TypeID As String = "TypeID"
				Public Const DatePurchased As String = "DatePurchased"
		
    Public Enum ColumnNames
				VehicleID
				LicensePlate
				TypeID
				DatePurchased
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.VehicleID
					Return VehicleID
					Case ColumnNames.LicensePlate
					Return LicensePlate
					Case ColumnNames.TypeID
					Return TypeID
					Case ColumnNames.DatePurchased
					Return DatePurchased
                    Case Else
                        Return VehicleID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared VehicleID As System.Type = GetType(System.Int32)
				Public Shared LicensePlate As System.Type = GetType(System.String)
				Public Shared TypeID As System.Type = GetType(System.Int32)
				Public Shared DatePurchased As System.Type = GetType(System.DateTime)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(LicensePlate_In AS System.String, TypeID_In AS System.Int32, DatePurchased_In AS System.DateTime)
					SetDefaults
							_LicensePlate = LicensePlate_In
							_TypeID = TypeID_In
							_DatePurchased = DatePurchased_In
End Sub

#End Region
Private Sub SetDefaults()
			VehicleID = 0
			LicensePlate = string.empty
			TypeID = 0
			DatePurchased = Nothing
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property VehicleID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [VehicleID] FROM [datVehicles] WHERE [VehicleID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datVehicles] SET [VehicleID] = @Value WHERE [VehicleID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property LicensePlate(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [LicensePlate] FROM [datVehicles] WHERE [VehicleID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datVehicles] SET [LicensePlate] = @Value WHERE [VehicleID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property TypeID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [TypeID] FROM [datVehicles] WHERE [VehicleID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datVehicles] SET [TypeID] = @Value WHERE [VehicleID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property DatePurchased(ByVal Key As System.Int32) As System.DateTime
				Get
					Dim Value As System.DateTime = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [DatePurchased] FROM [datVehicles] WHERE [VehicleID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.DateTime)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datVehicles] SET [DatePurchased] = @Value WHERE [VehicleID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datVehicles, ByVal rhs As datVehicles) As Boolean
		If lhs.LicensePlate = rhs.LicensePlate ANDALSO lhs.TypeID = rhs.TypeID ANDALSO lhs.DatePurchased = rhs.DatePurchased Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datVehicles, ByVal rhs As datVehicles) As Boolean
		If lhs.LicensePlate = rhs.LicensePlate ANDALSO lhs.TypeID = rhs.TypeID ANDALSO lhs.DatePurchased = rhs.DatePurchased Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class datVendors"
			Partial Public Class datVendors
#Region "       - Variable Declarations - "
			Private _VendorID As System.Int32
			Public Property VendorID() As System.Int32
				Get
					Return _VendorID
				End Get
				Set(ByVal value As System.Int32)
					_VendorID = value
				End Set
			End Property
			Private _VendorName As System.String
			Public Property VendorName() As System.String
				Get
					Return _VendorName
				End Get
				Set(ByVal value As System.String)
					_VendorName = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const VendorID As String = "VendorID"
				Public Const VendorName As String = "VendorName"
		
    Public Enum ColumnNames
				VendorID
				VendorName
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.VendorID
					Return VendorID
					Case ColumnNames.VendorName
					Return VendorName
                    Case Else
                        Return VendorID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared VendorID As System.Type = GetType(System.Int32)
				Public Shared VendorName As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(VendorName_In AS System.String)
					SetDefaults
							_VendorName = VendorName_In
End Sub

#End Region
Private Sub SetDefaults()
			VendorID = 0
			VendorName = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property VendorID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [VendorID] FROM [datVendors] WHERE [VendorID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datVendors] SET [VendorID] = @Value WHERE [VendorID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property VendorName(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [VendorName] FROM [datVendors] WHERE [VendorID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [datVendors] SET [VendorName] = @Value WHERE [VendorID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as datVendors, ByVal rhs As datVendors) As Boolean
		If lhs.VendorName = rhs.VendorName Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as datVendors, ByVal rhs As datVendors) As Boolean
		If lhs.VendorName = rhs.VendorName Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class HACCPTemps"
			Partial Public Class HACCPTemps
#Region "       - Variable Declarations - "
			Private _TempID As System.Int32
			Public Property TempID() As System.Int32
				Get
					Return _TempID
				End Get
				Set(ByVal value As System.Int32)
					_TempID = value
				End Set
			End Property
			Private _ParentID As System.Int32
			Public Property ParentID() As System.Int32
				Get
					Return _ParentID
				End Get
				Set(ByVal value As System.Int32)
					_ParentID = value
				End Set
			End Property
			Private _Temp As System.Double
			Public Property Temp() As System.Double
				Get
					Return _Temp
				End Get
				Set(ByVal value As System.Double)
					_Temp = value
				End Set
			End Property
			Private _DateTime As System.DateTime
			Public Property DateTime() As System.DateTime
				Get
					Return _DateTime
				End Get
				Set(ByVal value As System.DateTime)
					_DateTime = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const TempID As String = "TempID"
				Public Const ParentID As String = "ParentID"
				Public Const Temp As String = "Temp"
				Public Const DateTime As String = "DateTime"
		
    Public Enum ColumnNames
				TempID
				ParentID
				Temp
				DateTime
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.TempID
					Return TempID
					Case ColumnNames.ParentID
					Return ParentID
					Case ColumnNames.Temp
					Return Temp
					Case ColumnNames.DateTime
					Return DateTime
                    Case Else
                        Return TempID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared TempID As System.Type = GetType(System.Int32)
				Public Shared ParentID As System.Type = GetType(System.Int32)
				Public Shared Temp As System.Type = GetType(System.Double)
				Public Shared DateTime As System.Type = GetType(System.DateTime)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(ParentID_In AS System.Int32, Temp_In AS System.Double, DateTime_In AS System.DateTime)
					SetDefaults
							_ParentID = ParentID_In
							_Temp = Temp_In
							_DateTime = DateTime_In
End Sub

#End Region
Private Sub SetDefaults()
			TempID = 0
			ParentID = 0
			Temp = Nothing
			DateTime = Nothing
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property TempID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [TempID] FROM [HACCPTemps] WHERE [TempID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [HACCPTemps] SET [TempID] = @Value WHERE [TempID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ParentID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ParentID] FROM [HACCPTemps] WHERE [TempID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [HACCPTemps] SET [ParentID] = @Value WHERE [TempID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Temp(ByVal Key As System.Int32) As System.Double
				Get
					Dim Value As System.Double = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Temp] FROM [HACCPTemps] WHERE [TempID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Double)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [HACCPTemps] SET [Temp] = @Value WHERE [TempID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property DateTime(ByVal Key As System.Int32) As System.DateTime
				Get
					Dim Value As System.DateTime = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [DateTime] FROM [HACCPTemps] WHERE [TempID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.DateTime)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [HACCPTemps] SET [DateTime] = @Value WHERE [TempID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as HACCPTemps, ByVal rhs As HACCPTemps) As Boolean
		If lhs.ParentID = rhs.ParentID ANDALSO lhs.Temp = rhs.Temp ANDALSO lhs.DateTime = rhs.DateTime Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as HACCPTemps, ByVal rhs As HACCPTemps) As Boolean
		If lhs.ParentID = rhs.ParentID ANDALSO lhs.Temp = rhs.Temp ANDALSO lhs.DateTime = rhs.DateTime Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class HACCPTimes"
			Partial Public Class HACCPTimes
#Region "       - Variable Declarations - "
			Private _TimeID As System.Int32
			Public Property TimeID() As System.Int32
				Get
					Return _TimeID
				End Get
				Set(ByVal value As System.Int32)
					_TimeID = value
				End Set
			End Property
			Private _ParentID As System.Int32
			Public Property ParentID() As System.Int32
				Get
					Return _ParentID
				End Get
				Set(ByVal value As System.Int32)
					_ParentID = value
				End Set
			End Property
			Private _DateTime As System.DateTime
			Public Property DateTime() As System.DateTime
				Get
					Return _DateTime
				End Get
				Set(ByVal value As System.DateTime)
					_DateTime = value
				End Set
			End Property
			Private _TimeTypeID As System.Int32
			Public Property TimeTypeID() As System.Int32
				Get
					Return _TimeTypeID
				End Get
				Set(ByVal value As System.Int32)
					_TimeTypeID = value
				End Set
			End Property
			Private _EmployeeID As System.Int32
			Public Property EmployeeID() As System.Int32
				Get
					Return _EmployeeID
				End Get
				Set(ByVal value As System.Int32)
					_EmployeeID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const TimeID As String = "TimeID"
				Public Const ParentID As String = "ParentID"
				Public Const DateTime As String = "DateTime"
				Public Const TimeTypeID As String = "TimeTypeID"
				Public Const EmployeeID As String = "EmployeeID"
		
    Public Enum ColumnNames
				TimeID
				ParentID
				DateTime
				TimeTypeID
				EmployeeID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.TimeID
					Return TimeID
					Case ColumnNames.ParentID
					Return ParentID
					Case ColumnNames.DateTime
					Return DateTime
					Case ColumnNames.TimeTypeID
					Return TimeTypeID
					Case ColumnNames.EmployeeID
					Return EmployeeID
                    Case Else
                        Return TimeID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared TimeID As System.Type = GetType(System.Int32)
				Public Shared ParentID As System.Type = GetType(System.Int32)
				Public Shared DateTime As System.Type = GetType(System.DateTime)
				Public Shared TimeTypeID As System.Type = GetType(System.Int32)
				Public Shared EmployeeID As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(ParentID_In AS System.Int32, DateTime_In AS System.DateTime, TimeTypeID_In AS System.Int32, EmployeeID_In AS System.Int32)
					SetDefaults
							_ParentID = ParentID_In
							_DateTime = DateTime_In
							_TimeTypeID = TimeTypeID_In
							_EmployeeID = EmployeeID_In
End Sub

#End Region
Private Sub SetDefaults()
			TimeID = 0
			ParentID = 0
			DateTime = Nothing
			TimeTypeID = 0
			EmployeeID = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property TimeID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [TimeID] FROM [HACCPTimes] WHERE [TimeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [HACCPTimes] SET [TimeID] = @Value WHERE [TimeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ParentID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ParentID] FROM [HACCPTimes] WHERE [TimeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [HACCPTimes] SET [ParentID] = @Value WHERE [TimeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property DateTime(ByVal Key As System.Int32) As System.DateTime
				Get
					Dim Value As System.DateTime = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [DateTime] FROM [HACCPTimes] WHERE [TimeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.DateTime)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [HACCPTimes] SET [DateTime] = @Value WHERE [TimeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property TimeTypeID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [TimeTypeID] FROM [HACCPTimes] WHERE [TimeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [HACCPTimes] SET [TimeTypeID] = @Value WHERE [TimeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property EmployeeID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [EmployeeID] FROM [HACCPTimes] WHERE [TimeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [HACCPTimes] SET [EmployeeID] = @Value WHERE [TimeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as HACCPTimes, ByVal rhs As HACCPTimes) As Boolean
		If lhs.ParentID = rhs.ParentID ANDALSO lhs.DateTime = rhs.DateTime ANDALSO lhs.TimeTypeID = rhs.TimeTypeID ANDALSO lhs.EmployeeID = rhs.EmployeeID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as HACCPTimes, ByVal rhs As HACCPTimes) As Boolean
		If lhs.ParentID = rhs.ParentID ANDALSO lhs.DateTime = rhs.DateTime ANDALSO lhs.TimeTypeID = rhs.TimeTypeID ANDALSO lhs.EmployeeID = rhs.EmployeeID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class jncAssembly"
			Partial Public Class jncAssembly
#Region "       - Variable Declarations - "
			Private _IngredientAssemblyID As System.Int32
			Public Property IngredientAssemblyID() As System.Int32
				Get
					Return _IngredientAssemblyID
				End Get
				Set(ByVal value As System.Int32)
					_IngredientAssemblyID = value
				End Set
			End Property
			Private _AssemblyID As System.Int32
			Public Property AssemblyID() As System.Int32
				Get
					Return _AssemblyID
				End Get
				Set(ByVal value As System.Int32)
					_AssemblyID = value
				End Set
			End Property
			Private _Quantity As System.Double
			Public Property Quantity() As System.Double
				Get
					Return _Quantity
				End Get
				Set(ByVal value As System.Double)
					_Quantity = value
				End Set
			End Property
			Private _UnitsID As System.Int32
			Public Property UnitsID() As System.Int32
				Get
					Return _UnitsID
				End Get
				Set(ByVal value As System.Int32)
					_UnitsID = value
				End Set
			End Property
			Private _IngInvID As System.Int32
			Public Property IngInvID() As System.Int32
				Get
					Return _IngInvID
				End Get
				Set(ByVal value As System.Int32)
					_IngInvID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const IngredientAssemblyID As String = "IngredientAssemblyID"
				Public Const AssemblyID As String = "AssemblyID"
				Public Const Quantity As String = "Quantity"
				Public Const UnitsID As String = "UnitsID"
				Public Const IngInvID As String = "IngInvID"
		
    Public Enum ColumnNames
				IngredientAssemblyID
				AssemblyID
				Quantity
				UnitsID
				IngInvID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.IngredientAssemblyID
					Return IngredientAssemblyID
					Case ColumnNames.AssemblyID
					Return AssemblyID
					Case ColumnNames.Quantity
					Return Quantity
					Case ColumnNames.UnitsID
					Return UnitsID
					Case ColumnNames.IngInvID
					Return IngInvID
                    Case Else
                        Return IngredientAssemblyID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared IngredientAssemblyID As System.Type = GetType(System.Int32)
				Public Shared AssemblyID As System.Type = GetType(System.Int32)
				Public Shared Quantity As System.Type = GetType(System.Double)
				Public Shared UnitsID As System.Type = GetType(System.Int32)
				Public Shared IngInvID As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(AssemblyID_In AS System.Int32, Quantity_In AS System.Double, UnitsID_In AS System.Int32, IngInvID_In AS System.Int32)
					SetDefaults
							_AssemblyID = AssemblyID_In
							_Quantity = Quantity_In
							_UnitsID = UnitsID_In
							_IngInvID = IngInvID_In
End Sub

#End Region
Private Sub SetDefaults()
			IngredientAssemblyID = 0
			AssemblyID = 0
			Quantity = Nothing
			UnitsID = 0
			IngInvID = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property IngredientAssemblyID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [IngredientAssemblyID] FROM [jncAssembly] WHERE [IngredientAssemblyID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncAssembly] SET [IngredientAssemblyID] = @Value WHERE [IngredientAssemblyID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property AssemblyID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [AssemblyID] FROM [jncAssembly] WHERE [IngredientAssemblyID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncAssembly] SET [AssemblyID] = @Value WHERE [IngredientAssemblyID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Quantity(ByVal Key As System.Int32) As System.Double
				Get
					Dim Value As System.Double = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Quantity] FROM [jncAssembly] WHERE [IngredientAssemblyID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Double)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncAssembly] SET [Quantity] = @Value WHERE [IngredientAssemblyID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property UnitsID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [UnitsID] FROM [jncAssembly] WHERE [IngredientAssemblyID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncAssembly] SET [UnitsID] = @Value WHERE [IngredientAssemblyID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property IngInvID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [IngInvID] FROM [jncAssembly] WHERE [IngredientAssemblyID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncAssembly] SET [IngInvID] = @Value WHERE [IngredientAssemblyID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as jncAssembly, ByVal rhs As jncAssembly) As Boolean
		If lhs.AssemblyID = rhs.AssemblyID ANDALSO lhs.Quantity = rhs.Quantity ANDALSO lhs.UnitsID = rhs.UnitsID ANDALSO lhs.IngInvID = rhs.IngInvID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as jncAssembly, ByVal rhs As jncAssembly) As Boolean
		If lhs.AssemblyID = rhs.AssemblyID ANDALSO lhs.Quantity = rhs.Quantity ANDALSO lhs.UnitsID = rhs.UnitsID ANDALSO lhs.IngInvID = rhs.IngInvID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class jncClientAddresses"
			Partial Public Class jncClientAddresses
#Region "       - Variable Declarations - "
			Private _ID As System.Int32
			Public Property ID() As System.Int32
				Get
					Return _ID
				End Get
				Set(ByVal value As System.Int32)
					_ID = value
				End Set
			End Property
			Private _ClientID As System.Int32
			Public Property ClientID() As System.Int32
				Get
					Return _ClientID
				End Get
				Set(ByVal value As System.Int32)
					_ClientID = value
				End Set
			End Property
			Private _AddressID As System.Int32
			Public Property AddressID() As System.Int32
				Get
					Return _AddressID
				End Get
				Set(ByVal value As System.Int32)
					_AddressID = value
				End Set
			End Property
			Private _AddressType As System.Int32
			Public Property AddressType() As System.Int32
				Get
					Return _AddressType
				End Get
				Set(ByVal value As System.Int32)
					_AddressType = value
				End Set
			End Property
			Private _Notes As System.String
			Public Property Notes() As System.String
				Get
					Return _Notes
				End Get
				Set(ByVal value As System.String)
					_Notes = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const ID As String = "ID"
				Public Const ClientID As String = "ClientID"
				Public Const AddressID As String = "AddressID"
				Public Const AddressType As String = "AddressType"
				Public Const Notes As String = "Notes"
		
    Public Enum ColumnNames
				ID
				ClientID
				AddressID
				AddressType
				Notes
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.ID
					Return ID
					Case ColumnNames.ClientID
					Return ClientID
					Case ColumnNames.AddressID
					Return AddressID
					Case ColumnNames.AddressType
					Return AddressType
					Case ColumnNames.Notes
					Return Notes
                    Case Else
                        Return ID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared ID As System.Type = GetType(System.Int32)
				Public Shared ClientID As System.Type = GetType(System.Int32)
				Public Shared AddressID As System.Type = GetType(System.Int32)
				Public Shared AddressType As System.Type = GetType(System.Int32)
				Public Shared Notes As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(ClientID_In AS System.Int32, AddressID_In AS System.Int32, AddressType_In AS System.Int32, Notes_In AS System.String)
					SetDefaults
							_ClientID = ClientID_In
							_AddressID = AddressID_In
							_AddressType = AddressType_In
							_Notes = Notes_In
End Sub

#End Region
Private Sub SetDefaults()
			ID = 0
			ClientID = 0
			AddressID = 0
			AddressType = 0
			Notes = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property Id(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ID] FROM [jncClientAddresses] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncClientAddresses] SET [ID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ClientID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ClientID] FROM [jncClientAddresses] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncClientAddresses] SET [ClientID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property AddressID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [AddressID] FROM [jncClientAddresses] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncClientAddresses] SET [AddressID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property AddressType(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [AddressType] FROM [jncClientAddresses] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncClientAddresses] SET [AddressType] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Notes(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Notes] FROM [jncClientAddresses] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncClientAddresses] SET [Notes] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as jncClientAddresses, ByVal rhs As jncClientAddresses) As Boolean
		If lhs.ClientID = rhs.ClientID ANDALSO lhs.AddressID = rhs.AddressID ANDALSO lhs.AddressType = rhs.AddressType ANDALSO lhs.Notes = rhs.Notes Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as jncClientAddresses, ByVal rhs As jncClientAddresses) As Boolean
		If lhs.ClientID = rhs.ClientID ANDALSO lhs.AddressID = rhs.AddressID ANDALSO lhs.AddressType = rhs.AddressType ANDALSO lhs.Notes = rhs.Notes Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class jncClientContacts"
			Partial Public Class jncClientContacts
#Region "       - Variable Declarations - "
			Private _ID As System.Int32
			Public Property ID() As System.Int32
				Get
					Return _ID
				End Get
				Set(ByVal value As System.Int32)
					_ID = value
				End Set
			End Property
			Private _ClientID As System.Int32
			Public Property ClientID() As System.Int32
				Get
					Return _ClientID
				End Get
				Set(ByVal value As System.Int32)
					_ClientID = value
				End Set
			End Property
			Private _ContactID As System.Int32
			Public Property ContactID() As System.Int32
				Get
					Return _ContactID
				End Get
				Set(ByVal value As System.Int32)
					_ContactID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const ID As String = "ID"
				Public Const ClientID As String = "ClientID"
				Public Const ContactID As String = "ContactID"
		
    Public Enum ColumnNames
				ID
				ClientID
				ContactID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.ID
					Return ID
					Case ColumnNames.ClientID
					Return ClientID
					Case ColumnNames.ContactID
					Return ContactID
                    Case Else
                        Return ID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared ID As System.Type = GetType(System.Int32)
				Public Shared ClientID As System.Type = GetType(System.Int32)
				Public Shared ContactID As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(ClientID_In AS System.Int32, ContactID_In AS System.Int32)
					SetDefaults
							_ClientID = ClientID_In
							_ContactID = ContactID_In
End Sub

#End Region
Private Sub SetDefaults()
			ID = 0
			ClientID = 0
			ContactID = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property Id(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ID] FROM [jncClientContacts] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncClientContacts] SET [ID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ClientID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ClientID] FROM [jncClientContacts] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncClientContacts] SET [ClientID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ContactID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ContactID] FROM [jncClientContacts] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncClientContacts] SET [ContactID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as jncClientContacts, ByVal rhs As jncClientContacts) As Boolean
		If lhs.ClientID = rhs.ClientID ANDALSO lhs.ContactID = rhs.ContactID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as jncClientContacts, ByVal rhs As jncClientContacts) As Boolean
		If lhs.ClientID = rhs.ClientID ANDALSO lhs.ContactID = rhs.ContactID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class jncEmployeeContacts"
			Partial Public Class jncEmployeeContacts
#Region "       - Variable Declarations - "
			Private _ID As System.Int32
			Public Property ID() As System.Int32
				Get
					Return _ID
				End Get
				Set(ByVal value As System.Int32)
					_ID = value
				End Set
			End Property
			Private _EmployeeID As System.Int32
			Public Property EmployeeID() As System.Int32
				Get
					Return _EmployeeID
				End Get
				Set(ByVal value As System.Int32)
					_EmployeeID = value
				End Set
			End Property
			Private _ContactID As System.Int32
			Public Property ContactID() As System.Int32
				Get
					Return _ContactID
				End Get
				Set(ByVal value As System.Int32)
					_ContactID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const ID As String = "ID"
				Public Const EmployeeID As String = "EmployeeID"
				Public Const ContactID As String = "ContactID"
		
    Public Enum ColumnNames
				ID
				EmployeeID
				ContactID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.ID
					Return ID
					Case ColumnNames.EmployeeID
					Return EmployeeID
					Case ColumnNames.ContactID
					Return ContactID
                    Case Else
                        Return ID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared ID As System.Type = GetType(System.Int32)
				Public Shared EmployeeID As System.Type = GetType(System.Int32)
				Public Shared ContactID As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(EmployeeID_In AS System.Int32, ContactID_In AS System.Int32)
					SetDefaults
							_EmployeeID = EmployeeID_In
							_ContactID = ContactID_In
End Sub

#End Region
Private Sub SetDefaults()
			ID = 0
			EmployeeID = 0
			ContactID = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property Id(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ID] FROM [jncEmployeeContacts] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncEmployeeContacts] SET [ID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property EmployeeID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [EmployeeID] FROM [jncEmployeeContacts] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncEmployeeContacts] SET [EmployeeID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ContactID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ContactID] FROM [jncEmployeeContacts] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncEmployeeContacts] SET [ContactID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as jncEmployeeContacts, ByVal rhs As jncEmployeeContacts) As Boolean
		If lhs.EmployeeID = rhs.EmployeeID ANDALSO lhs.ContactID = rhs.ContactID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as jncEmployeeContacts, ByVal rhs As jncEmployeeContacts) As Boolean
		If lhs.EmployeeID = rhs.EmployeeID ANDALSO lhs.ContactID = rhs.ContactID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class jncOrdersAndPackages"
			Partial Public Class jncOrdersAndPackages
#Region "       - Variable Declarations - "
			Private _ID As System.Int32
			Public Property ID() As System.Int32
				Get
					Return _ID
				End Get
				Set(ByVal value As System.Int32)
					_ID = value
				End Set
			End Property
			Private _OrderNumber As System.Int32
			Public Property OrderNumber() As System.Int32
				Get
					Return _OrderNumber
				End Get
				Set(ByVal value As System.Int32)
					_OrderNumber = value
				End Set
			End Property
			Private _PackageID As System.Int32
			Public Property PackageID() As System.Int32
				Get
					Return _PackageID
				End Get
				Set(ByVal value As System.Int32)
					_PackageID = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const ID As String = "ID"
				Public Const OrderNumber As String = "OrderNumber"
				Public Const PackageID As String = "PackageID"
		
    Public Enum ColumnNames
				ID
				OrderNumber
				PackageID
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.ID
					Return ID
					Case ColumnNames.OrderNumber
					Return OrderNumber
					Case ColumnNames.PackageID
					Return PackageID
                    Case Else
                        Return ID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared ID As System.Type = GetType(System.Int32)
				Public Shared OrderNumber As System.Type = GetType(System.Int32)
				Public Shared PackageID As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(OrderNumber_In AS System.Int32, PackageID_In AS System.Int32)
					SetDefaults
							_OrderNumber = OrderNumber_In
							_PackageID = PackageID_In
End Sub

#End Region
Private Sub SetDefaults()
			ID = 0
			OrderNumber = 0
			PackageID = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property Id(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ID] FROM [jncOrdersAndPackages] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncOrdersAndPackages] SET [ID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property OrderNumber(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [OrderNumber] FROM [jncOrdersAndPackages] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncOrdersAndPackages] SET [OrderNumber] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property PackageID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PackageID] FROM [jncOrdersAndPackages] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncOrdersAndPackages] SET [PackageID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as jncOrdersAndPackages, ByVal rhs As jncOrdersAndPackages) As Boolean
		If lhs.OrderNumber = rhs.OrderNumber ANDALSO lhs.PackageID = rhs.PackageID Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as jncOrdersAndPackages, ByVal rhs As jncOrdersAndPackages) As Boolean
		If lhs.OrderNumber = rhs.OrderNumber ANDALSO lhs.PackageID = rhs.PackageID Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class jncVendorAddresses"
			Partial Public Class jncVendorAddresses
#Region "       - Variable Declarations - "
			Private _ID As System.Int32
			Public Property ID() As System.Int32
				Get
					Return _ID
				End Get
				Set(ByVal value As System.Int32)
					_ID = value
				End Set
			End Property
			Private _VendorID As System.Int32
			Public Property VendorID() As System.Int32
				Get
					Return _VendorID
				End Get
				Set(ByVal value As System.Int32)
					_VendorID = value
				End Set
			End Property
			Private _AddressID As System.Int32
			Public Property AddressID() As System.Int32
				Get
					Return _AddressID
				End Get
				Set(ByVal value As System.Int32)
					_AddressID = value
				End Set
			End Property
			Private _AddressType As System.Int32
			Public Property AddressType() As System.Int32
				Get
					Return _AddressType
				End Get
				Set(ByVal value As System.Int32)
					_AddressType = value
				End Set
			End Property
			Private _Notes As System.String
			Public Property Notes() As System.String
				Get
					Return _Notes
				End Get
				Set(ByVal value As System.String)
					_Notes = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const ID As String = "ID"
				Public Const VendorID As String = "VendorID"
				Public Const AddressID As String = "AddressID"
				Public Const AddressType As String = "AddressType"
				Public Const Notes As String = "Notes"
		
    Public Enum ColumnNames
				ID
				VendorID
				AddressID
				AddressType
				Notes
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.ID
					Return ID
					Case ColumnNames.VendorID
					Return VendorID
					Case ColumnNames.AddressID
					Return AddressID
					Case ColumnNames.AddressType
					Return AddressType
					Case ColumnNames.Notes
					Return Notes
                    Case Else
                        Return ID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared ID As System.Type = GetType(System.Int32)
				Public Shared VendorID As System.Type = GetType(System.Int32)
				Public Shared AddressID As System.Type = GetType(System.Int32)
				Public Shared AddressType As System.Type = GetType(System.Int32)
				Public Shared Notes As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(VendorID_In AS System.Int32, AddressID_In AS System.Int32, AddressType_In AS System.Int32, Notes_In AS System.String)
					SetDefaults
							_VendorID = VendorID_In
							_AddressID = AddressID_In
							_AddressType = AddressType_In
							_Notes = Notes_In
End Sub

#End Region
Private Sub SetDefaults()
			ID = 0
			VendorID = 0
			AddressID = 0
			AddressType = 0
			Notes = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property Id(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ID] FROM [jncVendorAddresses] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncVendorAddresses] SET [ID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property VendorID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [VendorID] FROM [jncVendorAddresses] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncVendorAddresses] SET [VendorID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property AddressID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [AddressID] FROM [jncVendorAddresses] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncVendorAddresses] SET [AddressID] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property AddressType(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [AddressType] FROM [jncVendorAddresses] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncVendorAddresses] SET [AddressType] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Notes(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Notes] FROM [jncVendorAddresses] WHERE [ID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [jncVendorAddresses] SET [Notes] = @Value WHERE [ID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as jncVendorAddresses, ByVal rhs As jncVendorAddresses) As Boolean
		If lhs.VendorID = rhs.VendorID ANDALSO lhs.AddressID = rhs.AddressID ANDALSO lhs.AddressType = rhs.AddressType ANDALSO lhs.Notes = rhs.Notes Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as jncVendorAddresses, ByVal rhs As jncVendorAddresses) As Boolean
		If lhs.VendorID = rhs.VendorID ANDALSO lhs.AddressID = rhs.AddressID ANDALSO lhs.AddressType = rhs.AddressType ANDALSO lhs.Notes = rhs.Notes Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class luAssemblyTypes"
			Partial Public Class luAssemblyTypes
#Region "       - Variable Declarations - "
			Private _AssemblyTypeID As System.Int32
			Public Property AssemblyTypeID() As System.Int32
				Get
					Return _AssemblyTypeID
				End Get
				Set(ByVal value As System.Int32)
					_AssemblyTypeID = value
				End Set
			End Property
			Private _AssemblyType As System.String
			Public Property AssemblyType() As System.String
				Get
					Return _AssemblyType
				End Get
				Set(ByVal value As System.String)
					_AssemblyType = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const AssemblyTypeID As String = "AssemblyTypeID"
				Public Const AssemblyType As String = "AssemblyType"
		
    Public Enum ColumnNames
				AssemblyTypeID
				AssemblyType
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.AssemblyTypeID
					Return AssemblyTypeID
					Case ColumnNames.AssemblyType
					Return AssemblyType
                    Case Else
                        Return AssemblyTypeID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared AssemblyTypeID As System.Type = GetType(System.Int32)
				Public Shared AssemblyType As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(AssemblyType_In AS System.String)
					SetDefaults
							_AssemblyType = AssemblyType_In
End Sub

#End Region
Private Sub SetDefaults()
			AssemblyTypeID = 0
			AssemblyType = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property AssemblyTypeID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [AssemblyTypeID] FROM [luAssemblyTypes] WHERE [AssemblyTypeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luAssemblyTypes] SET [AssemblyTypeID] = @Value WHERE [AssemblyTypeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property AssemblyType(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [AssemblyType] FROM [luAssemblyTypes] WHERE [AssemblyTypeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luAssemblyTypes] SET [AssemblyType] = @Value WHERE [AssemblyTypeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as luAssemblyTypes, ByVal rhs As luAssemblyTypes) As Boolean
		If lhs.AssemblyType = rhs.AssemblyType Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as luAssemblyTypes, ByVal rhs As luAssemblyTypes) As Boolean
		If lhs.AssemblyType = rhs.AssemblyType Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class luCities"
			Partial Public Class luCities
#Region "       - Variable Declarations - "
			Private _CityID As System.Int32
			Public Property CityID() As System.Int32
				Get
					Return _CityID
				End Get
				Set(ByVal value As System.Int32)
					_CityID = value
				End Set
			End Property
			Private _City As System.String
			Public Property City() As System.String
				Get
					Return _City
				End Get
				Set(ByVal value As System.String)
					_City = value
				End Set
			End Property
			Private _ProvinceCode As System.String
			Public Property ProvinceCode() As System.String
				Get
					Return _ProvinceCode
				End Get
				Set(ByVal value As System.String)
					_ProvinceCode = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const CityID As String = "CityID"
				Public Const City As String = "City"
				Public Const ProvinceCode As String = "ProvinceCode"
		
    Public Enum ColumnNames
				CityID
				City
				ProvinceCode
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.CityID
					Return CityID
					Case ColumnNames.City
					Return City
					Case ColumnNames.ProvinceCode
					Return ProvinceCode
                    Case Else
                        Return CityID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared CityID As System.Type = GetType(System.Int32)
				Public Shared City As System.Type = GetType(System.String)
				Public Shared ProvinceCode As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(City_In AS System.String, ProvinceCode_In AS System.String)
					SetDefaults
							_City = City_In
							_ProvinceCode = ProvinceCode_In
End Sub

#End Region
Private Sub SetDefaults()
			CityID = 0
			City = string.empty
			ProvinceCode = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property CityID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [CityID] FROM [luCities] WHERE [CityID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luCities] SET [CityID] = @Value WHERE [CityID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property City(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [City] FROM [luCities] WHERE [CityID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luCities] SET [City] = @Value WHERE [CityID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ProvinceCode(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ProvinceCode] FROM [luCities] WHERE [CityID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luCities] SET [ProvinceCode] = @Value WHERE [CityID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as luCities, ByVal rhs As luCities) As Boolean
		If lhs.City = rhs.City ANDALSO lhs.ProvinceCode = rhs.ProvinceCode Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as luCities, ByVal rhs As luCities) As Boolean
		If lhs.City = rhs.City ANDALSO lhs.ProvinceCode = rhs.ProvinceCode Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class luContactType"
			Partial Public Class luContactType
#Region "       - Variable Declarations - "
			Private _ContactTypeID As System.Byte
			Public Property ContactTypeID() As System.Byte
				Get
					Return _ContactTypeID
				End Get
				Set(ByVal value As System.Byte)
					_ContactTypeID = value
				End Set
			End Property
			Private _ContactType As System.String
			Public Property ContactType() As System.String
				Get
					Return _ContactType
				End Get
				Set(ByVal value As System.String)
					_ContactType = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const ContactTypeID As String = "ContactTypeID"
				Public Const ContactType As String = "ContactType"
		
    Public Enum ColumnNames
				ContactTypeID
				ContactType
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.ContactTypeID
					Return ContactTypeID
					Case ColumnNames.ContactType
					Return ContactType
                    Case Else
                        Return ContactTypeID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared ContactTypeID As System.Type = GetType(System.Byte)
				Public Shared ContactType As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(ContactType_In AS System.String)
					SetDefaults
							_ContactType = ContactType_In
End Sub

#End Region
Private Sub SetDefaults()
			ContactTypeID = Nothing
			ContactType = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property ContactTypeID(ByVal Key As System.Byte) As System.Byte
				Get
					Dim Value As System.Byte = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ContactTypeID] FROM [luContactType] WHERE [ContactTypeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Byte)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luContactType] SET [ContactTypeID] = @Value WHERE [ContactTypeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ContactType(ByVal Key As System.Byte) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ContactType] FROM [luContactType] WHERE [ContactTypeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luContactType] SET [ContactType] = @Value WHERE [ContactTypeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as luContactType, ByVal rhs As luContactType) As Boolean
		If lhs.ContactType = rhs.ContactType Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as luContactType, ByVal rhs As luContactType) As Boolean
		If lhs.ContactType = rhs.ContactType Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class luCountries"
			Partial Public Class luCountries
#Region "       - Variable Declarations - "
			Private _CountryCode As System.String
			Public Property CountryCode() As System.String
				Get
					Return _CountryCode
				End Get
				Set(ByVal value As System.String)
					_CountryCode = value
				End Set
			End Property
			Private _CountryName As System.String
			Public Property CountryName() As System.String
				Get
					Return _CountryName
				End Get
				Set(ByVal value As System.String)
					_CountryName = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const CountryCode As String = "CountryCode"
				Public Const CountryName As String = "CountryName"
		
    Public Enum ColumnNames
				CountryCode
				CountryName
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.CountryCode
					Return CountryCode
					Case ColumnNames.CountryName
					Return CountryName
                    Case Else
                        Return CountryCode
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared CountryCode As System.Type = GetType(System.String)
				Public Shared CountryName As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(CountryName_In AS System.String)
					SetDefaults
							_CountryName = CountryName_In
End Sub

#End Region
Private Sub SetDefaults()
			CountryCode = string.empty
			CountryName = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property CountryCode(ByVal Key As System.String) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [CountryCode] FROM [luCountries] WHERE [CountryCode] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luCountries] SET [CountryCode] = @Value WHERE [CountryCode] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property CountryName(ByVal Key As System.String) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [CountryName] FROM [luCountries] WHERE [CountryCode] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luCountries] SET [CountryName] = @Value WHERE [CountryCode] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as luCountries, ByVal rhs As luCountries) As Boolean
		If lhs.CountryName = rhs.CountryName Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as luCountries, ByVal rhs As luCountries) As Boolean
		If lhs.CountryName = rhs.CountryName Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class luIngredients"
			Partial Public Class luIngredients
#Region "       - Variable Declarations - "
			Private _IngredientID As System.Int32
			Public Property IngredientID() As System.Int32
				Get
					Return _IngredientID
				End Get
				Set(ByVal value As System.Int32)
					_IngredientID = value
				End Set
			End Property
			Private _Ingredient As System.String
			Public Property Ingredient() As System.String
				Get
					Return _Ingredient
				End Get
				Set(ByVal value As System.String)
					_Ingredient = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const IngredientID As String = "IngredientID"
				Public Const Ingredient As String = "Ingredient"
		
    Public Enum ColumnNames
				IngredientID
				Ingredient
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.IngredientID
					Return IngredientID
					Case ColumnNames.Ingredient
					Return Ingredient
                    Case Else
                        Return IngredientID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared IngredientID As System.Type = GetType(System.Int32)
				Public Shared Ingredient As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(Ingredient_In AS System.String)
					SetDefaults
							_Ingredient = Ingredient_In
End Sub

#End Region
Private Sub SetDefaults()
			IngredientID = 0
			Ingredient = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property IngredientID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [IngredientID] FROM [luIngredients] WHERE [IngredientID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luIngredients] SET [IngredientID] = @Value WHERE [IngredientID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Ingredient(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Ingredient] FROM [luIngredients] WHERE [IngredientID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luIngredients] SET [Ingredient] = @Value WHERE [IngredientID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as luIngredients, ByVal rhs As luIngredients) As Boolean
		If lhs.Ingredient = rhs.Ingredient Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as luIngredients, ByVal rhs As luIngredients) As Boolean
		If lhs.Ingredient = rhs.Ingredient Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class luPhoneTypes"
			Partial Public Class luPhoneTypes
#Region "       - Variable Declarations - "
			Private _PhoneTypeID As System.Byte
			Public Property PhoneTypeID() As System.Byte
				Get
					Return _PhoneTypeID
				End Get
				Set(ByVal value As System.Byte)
					_PhoneTypeID = value
				End Set
			End Property
			Private _PhoneType As System.String
			Public Property PhoneType() As System.String
				Get
					Return _PhoneType
				End Get
				Set(ByVal value As System.String)
					_PhoneType = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const PhoneTypeID As String = "PhoneTypeID"
				Public Const PhoneType As String = "PhoneType"
		
    Public Enum ColumnNames
				PhoneTypeID
				PhoneType
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.PhoneTypeID
					Return PhoneTypeID
					Case ColumnNames.PhoneType
					Return PhoneType
                    Case Else
                        Return PhoneTypeID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared PhoneTypeID As System.Type = GetType(System.Byte)
				Public Shared PhoneType As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(PhoneType_In AS System.String)
					SetDefaults
							_PhoneType = PhoneType_In
End Sub

#End Region
Private Sub SetDefaults()
			PhoneTypeID = Nothing
			PhoneType = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property PhoneTypeID(ByVal Key As System.Byte) As System.Byte
				Get
					Dim Value As System.Byte = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PhoneTypeID] FROM [luPhoneTypes] WHERE [PhoneTypeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Byte)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luPhoneTypes] SET [PhoneTypeID] = @Value WHERE [PhoneTypeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property PhoneType(ByVal Key As System.Byte) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PhoneType] FROM [luPhoneTypes] WHERE [PhoneTypeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luPhoneTypes] SET [PhoneType] = @Value WHERE [PhoneTypeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as luPhoneTypes, ByVal rhs As luPhoneTypes) As Boolean
		If lhs.PhoneType = rhs.PhoneType Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as luPhoneTypes, ByVal rhs As luPhoneTypes) As Boolean
		If lhs.PhoneType = rhs.PhoneType Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class luPositions"
			Partial Public Class luPositions
#Region "       - Variable Declarations - "
			Private _PositionID As System.Int32
			Public Property PositionID() As System.Int32
				Get
					Return _PositionID
				End Get
				Set(ByVal value As System.Int32)
					_PositionID = value
				End Set
			End Property
			Private _Position As System.String
			Public Property Position() As System.String
				Get
					Return _Position
				End Get
				Set(ByVal value As System.String)
					_Position = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const PositionID As String = "PositionID"
				Public Const Position As String = "Position"
		
    Public Enum ColumnNames
				PositionID
				Position
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.PositionID
					Return PositionID
					Case ColumnNames.Position
					Return Position
                    Case Else
                        Return PositionID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared PositionID As System.Type = GetType(System.Int32)
				Public Shared Position As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(Position_In AS System.String)
					SetDefaults
							_Position = Position_In
End Sub

#End Region
Private Sub SetDefaults()
			PositionID = 0
			Position = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property PositionID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [PositionID] FROM [luPositions] WHERE [PositionID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luPositions] SET [PositionID] = @Value WHERE [PositionID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Position(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Position] FROM [luPositions] WHERE [PositionID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luPositions] SET [Position] = @Value WHERE [PositionID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as luPositions, ByVal rhs As luPositions) As Boolean
		If lhs.Position = rhs.Position Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as luPositions, ByVal rhs As luPositions) As Boolean
		If lhs.Position = rhs.Position Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class luProvinces"
			Partial Public Class luProvinces
#Region "       - Variable Declarations - "
			Private _ProvinceCode As System.String
			Public Property ProvinceCode() As System.String
				Get
					Return _ProvinceCode
				End Get
				Set(ByVal value As System.String)
					_ProvinceCode = value
				End Set
			End Property
			Private _ProvinceName As System.String
			Public Property ProvinceName() As System.String
				Get
					Return _ProvinceName
				End Get
				Set(ByVal value As System.String)
					_ProvinceName = value
				End Set
			End Property
			Private _CountryCode As System.String
			Public Property CountryCode() As System.String
				Get
					Return _CountryCode
				End Get
				Set(ByVal value As System.String)
					_CountryCode = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const ProvinceCode As String = "ProvinceCode"
				Public Const ProvinceName As String = "ProvinceName"
				Public Const CountryCode As String = "CountryCode"
		
    Public Enum ColumnNames
				ProvinceCode
				ProvinceName
				CountryCode
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.ProvinceCode
					Return ProvinceCode
					Case ColumnNames.ProvinceName
					Return ProvinceName
					Case ColumnNames.CountryCode
					Return CountryCode
                    Case Else
                        Return ProvinceCode
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared ProvinceCode As System.Type = GetType(System.String)
				Public Shared ProvinceName As System.Type = GetType(System.String)
				Public Shared CountryCode As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(ProvinceName_In AS System.String, CountryCode_In AS System.String)
					SetDefaults
							_ProvinceName = ProvinceName_In
							_CountryCode = CountryCode_In
End Sub

#End Region
Private Sub SetDefaults()
			ProvinceCode = string.empty
			ProvinceName = string.empty
			CountryCode = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property ProvinceCode(ByVal Key As System.String) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ProvinceCode] FROM [luProvinces] WHERE [ProvinceCode] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luProvinces] SET [ProvinceCode] = @Value WHERE [ProvinceCode] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property ProvinceName(ByVal Key As System.String) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [ProvinceName] FROM [luProvinces] WHERE [ProvinceCode] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luProvinces] SET [ProvinceName] = @Value WHERE [ProvinceCode] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property CountryCode(ByVal Key As System.String) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [CountryCode] FROM [luProvinces] WHERE [ProvinceCode] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luProvinces] SET [CountryCode] = @Value WHERE [ProvinceCode] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as luProvinces, ByVal rhs As luProvinces) As Boolean
		If lhs.ProvinceName = rhs.ProvinceName ANDALSO lhs.CountryCode = rhs.CountryCode Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as luProvinces, ByVal rhs As luProvinces) As Boolean
		If lhs.ProvinceName = rhs.ProvinceName ANDALSO lhs.CountryCode = rhs.CountryCode Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class luTimeTypes"
			Partial Public Class luTimeTypes
#Region "       - Variable Declarations - "
			Private _TimeTypeID As System.Int32
			Public Property TimeTypeID() As System.Int32
				Get
					Return _TimeTypeID
				End Get
				Set(ByVal value As System.Int32)
					_TimeTypeID = value
				End Set
			End Property
			Private _TimeType As System.String
			Public Property TimeType() As System.String
				Get
					Return _TimeType
				End Get
				Set(ByVal value As System.String)
					_TimeType = value
				End Set
			End Property
			Private _IngredientType As System.Int32
			Public Property IngredientType() As System.Int32
				Get
					Return _IngredientType
				End Get
				Set(ByVal value As System.Int32)
					_IngredientType = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const TimeTypeID As String = "TimeTypeID"
				Public Const TimeType As String = "TimeType"
				Public Const IngredientType As String = "IngredientType"
		
    Public Enum ColumnNames
				TimeTypeID
				TimeType
				IngredientType
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.TimeTypeID
					Return TimeTypeID
					Case ColumnNames.TimeType
					Return TimeType
					Case ColumnNames.IngredientType
					Return IngredientType
                    Case Else
                        Return TimeTypeID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared TimeTypeID As System.Type = GetType(System.Int32)
				Public Shared TimeType As System.Type = GetType(System.String)
				Public Shared IngredientType As System.Type = GetType(System.Int32)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(TimeType_In AS System.String, IngredientType_In AS System.Int32)
					SetDefaults
							_TimeType = TimeType_In
							_IngredientType = IngredientType_In
End Sub

#End Region
Private Sub SetDefaults()
			TimeTypeID = 0
			TimeType = string.empty
			IngredientType = 0
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property TimeTypeID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [TimeTypeID] FROM [luTimeTypes] WHERE [TimeTypeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luTimeTypes] SET [TimeTypeID] = @Value WHERE [TimeTypeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property TimeType(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [TimeType] FROM [luTimeTypes] WHERE [TimeTypeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luTimeTypes] SET [TimeType] = @Value WHERE [TimeTypeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property IngredientType(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [IngredientType] FROM [luTimeTypes] WHERE [TimeTypeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luTimeTypes] SET [IngredientType] = @Value WHERE [TimeTypeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as luTimeTypes, ByVal rhs As luTimeTypes) As Boolean
		If lhs.TimeType = rhs.TimeType ANDALSO lhs.IngredientType = rhs.IngredientType Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as luTimeTypes, ByVal rhs As luTimeTypes) As Boolean
		If lhs.TimeType = rhs.TimeType ANDALSO lhs.IngredientType = rhs.IngredientType Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class luUnits"
			Partial Public Class luUnits
#Region "       - Variable Declarations - "
			Private _UnitsID As System.Int32
			Public Property UnitsID() As System.Int32
				Get
					Return _UnitsID
				End Get
				Set(ByVal value As System.Int32)
					_UnitsID = value
				End Set
			End Property
			Private _Units As System.String
			Public Property Units() As System.String
				Get
					Return _Units
				End Get
				Set(ByVal value As System.String)
					_Units = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const UnitsID As String = "UnitsID"
				Public Const Units As String = "Units"
		
    Public Enum ColumnNames
				UnitsID
				Units
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.UnitsID
					Return UnitsID
					Case ColumnNames.Units
					Return Units
                    Case Else
                        Return UnitsID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared UnitsID As System.Type = GetType(System.Int32)
				Public Shared Units As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(Units_In AS System.String)
					SetDefaults
							_Units = Units_In
End Sub

#End Region
Private Sub SetDefaults()
			UnitsID = 0
			Units = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property UnitsID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [UnitsID] FROM [luUnits] WHERE [UnitsID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luUnits] SET [UnitsID] = @Value WHERE [UnitsID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Units(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Units] FROM [luUnits] WHERE [UnitsID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luUnits] SET [Units] = @Value WHERE [UnitsID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as luUnits, ByVal rhs As luUnits) As Boolean
		If lhs.Units = rhs.Units Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as luUnits, ByVal rhs As luUnits) As Boolean
		If lhs.Units = rhs.Units Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
#Region " - Class luVehicleTypes"
			Partial Public Class luVehicleTypes
#Region "       - Variable Declarations - "
			Private _TypeID As System.Int32
			Public Property TypeID() As System.Int32
				Get
					Return _TypeID
				End Get
				Set(ByVal value As System.Int32)
					_TypeID = value
				End Set
			End Property
			Private _Description As System.String
			Public Property Description() As System.String
				Get
					Return _Description
				End Get
				Set(ByVal value As System.String)
					_Description = value
				End Set
			End Property
#End Region

#Region "           - Column Definitions - "
	Class Columns
				Public Const TypeID As String = "TypeID"
				Public Const Description As String = "Description"
		
    Public Enum ColumnNames
				TypeID
				Description
    End Enum

    Public Shared Function GetColumnName(ByVal ColumnEnum As ColumnNames) As String
                Select Case ColumnEnum
					Case ColumnNames.TypeID
					Return TypeID
					Case ColumnNames.Description
					Return Description
                    Case Else
                        Return TypeID
                End Select
            End Function
						
	End Class
#End Region

#Region "           - Type Definitions - "
		Class Types
				Public Shared TypeID As System.Type = GetType(System.Int32)
				Public Shared Description As System.Type = GetType(System.String)
		End Class
#End Region

#Region " - Sub NEW -"
Public Sub New(Description_In AS System.String)
					SetDefaults
							_Description = Description_In
End Sub

#End Region
Private Sub SetDefaults()
			TypeID = 0
			Description = string.empty
End Sub

#Region "           - ReadWrites - "
	Class ReadWrite
	
			Public Shared Property TypeID(ByVal Key As System.Int32) As System.Int32
				Get
					Dim Value As System.Int32 = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [TypeID] FROM [luVehicleTypes] WHERE [TypeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.Int32)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luVehicleTypes] SET [TypeID] = @Value WHERE [TypeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
			Public Shared Property Description(ByVal Key As System.Int32) As System.String
				Get
					Dim Value As System.String = nothing
					Using connection As New SqlConnection(Lookups.GetConnString)
						Dim strSQL As String = "SELECT TOP 1 [Description] FROM [luVehicleTypes] WHERE [TypeID] = @Key"
						Using command As New SqlCommand(strSQL, connection)
							command.CommandType = CommandType.Text
							command.Parameters.Add(New SqlParameter("@Key", Key))
							connection.Open()
							Try
								Value = command.ExecuteScalar
							Catch ex As Exception
								Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
								Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
								DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
							End Try
						End Using
					End Using
					Return Value
				End Get
				
					Set(ByVal Value As System.String)
						Using connection As New SqlConnection(Lookups.GetConnString)
							Dim strSQL As String = "UPDATE [luVehicleTypes] SET [Description] = @Value WHERE [TypeID] = @Key"
							Using command As New SqlCommand(strSQL, connection)
								command.CommandType = CommandType.Text
								connection.Open()
								command.Parameters.Add(New SqlParameter("@Key", Key))
								command.Parameters.Add(New SqlParameter("@Value", Value))
								Try
									command.ExecuteNonQuery()
								Catch
									Dim ST As System.Diagnostics.StackTrace = New System.Diagnostics.StackTrace()
									Dim SF As System.Diagnostics.StackFrame = ST.GetFrame(0) 'Current Method
									DBL.Errors.LogError(SF.GetMethod().ReflectedType.Name & ":" & SF.GetMethod().Name, Err.Description)
								End Try
							End Using
						End Using
					End Set
			End Property
	End Class	
#End Region

#Region "           - BitSwitches - "
		Class Switches
		End Class
#End Region
#Region "           - Operators - "
	Public Shared Operator =(ByVal lhs as luVehicleTypes, ByVal rhs As luVehicleTypes) As Boolean
		If lhs.Description = rhs.Description Then
			Return True
		Else
			Return False
		End If
	End Operator
	
	Public Shared Operator <>(ByVal lhs as luVehicleTypes, ByVal rhs As luVehicleTypes) As Boolean
		If lhs.Description = rhs.Description Then
			Return False
		Else
			Return True
		End If
	End Operator
#End Region
	End Class
#End Region
End Namespace


