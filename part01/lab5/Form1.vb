Public Class Form1
    Dim listOfEmployee As List(Of Employee) = New List(Of Employee)()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empl As Employee = New Employee
        empl.firstName = TextBox1.Text
        empl.lastName = TextBox2.Text
        empl.standing = TextBox3.Text
        empl.salary = TextBox4.Text
        listOfEmployee.Add(empl)
        showEmployees()
    End Sub

    Public Sub clearGrid()
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
    End Sub

    Public Sub showEmployees()
        clearGrid()
        For i As Integer = 0 To listOfEmployee.Count - 1
            DataGridView1.Rows.Add()
            DataGridView1.Rows(i).Cells(0).Value = listOfEmployee(i).firstName.ToString
            DataGridView1.Rows(i).Cells(1).Value = listOfEmployee(i).lastName.ToString
            DataGridView1.Rows(i).Cells(2).Value = listOfEmployee(i).standing
            DataGridView1.Rows(i).Cells(3).Value = listOfEmployee(i).salary
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 0 To listOfEmployee.Count - 1
            If listOfEmployee(i).check = False Then
                If listOfEmployee(i).standing >= 5 Or listOfEmployee(i).standing <= 10 Then
                    Dim result As Double = ((listOfEmployee(i).salary * 5) / 100) + listOfEmployee(i).salary
                    listOfEmployee(i).salary = result
                    listOfEmployee(i).check = True
                ElseIf listOfEmployee(i).standing > 10 Then
                    Dim result As Double = ((listOfEmployee(i).salary * 10) / 100) + listOfEmployee(i).salary
                    listOfEmployee(i).salary = result
                    listOfEmployee(i).check = True
                End If
            End If
        Next
        showEmployees()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        Form2.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
