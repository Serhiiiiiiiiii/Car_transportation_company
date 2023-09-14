Public Class Марки_автомобілів
    Private Sub Марки_автомобілівBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Марки_автомобілівBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Автотранспортне_підприємствоDataSet)

    End Sub

    Private Sub Марки_автомобілів_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Марки_автомобілів". При необходимости она может быть перемещена или удалена.
        Me.Марки_автомобілівTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Марки_автомобілів)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Таблиці.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Марки_автомобілів_табл.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Марки_автомобілівBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Марки_автомобілівBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Марки_автомобілівBindingSource.MoveFirst()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Марки_автомобілівBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Марки_автомобілівBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Марки_автомобілівBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.Марки_автомобілівBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Автотранспортне_підприємствоDataSet)
    End Sub
End Class