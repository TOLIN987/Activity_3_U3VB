Friend Class Student
    Inherits Person

    Private student_id As Integer
    Public Property _student_id As Integer
        Get
            Return student_id
        End Get
        Set(value As Integer)
            student_id = value
        End Set
    End Property
    Public Sub New(ByVal name As String, ByVal age As Integer, ByVal student_id As Integer)
        MyBase.New(name, age)
        Me.student_id = student_id
    End Sub
    Protected Overrides Sub Finalize()
        System.Diagnostics.Trace.WriteLine("The Student destructor worked successfully")
    End Sub

End Class
