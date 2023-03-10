Public Class Person
    Private name As String
    Private age As Integer
    Public Property _Name As String
        Get
            Return name

        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property
    Public Property _age As Integer
        Get
            Return age
        End Get
        Set(value As Integer)
            age = value
        End Set
    End Property
    Public Sub New(ByVal name As String, ByVal age As Integer)
        Me.name = name
        Me.age = age
    End Sub
    Protected Overrides Sub finalize()
        System.Diagnostics.Trace.WriteLine("The destructor worked succesfully")
    End Sub
End Class
