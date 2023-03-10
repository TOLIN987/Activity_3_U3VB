Module Module1

    Sub Main()
        Dim p As Person
        p = New Person("Marcosias", 19)
        Console.WriteLine("Name: {0}" & vbNewLine & "Age: {1}", p._Name, p._age)

        Dim s As Student
        s = New Student("Mayoneise", 20, 2121)
        Console.WriteLine("Name: {0}" & vbNewLine & "Age: {1}" & vbNewLine & "Student_ID: {2}", s._Name, s._age, s._student_id)


    End Sub

End Module
