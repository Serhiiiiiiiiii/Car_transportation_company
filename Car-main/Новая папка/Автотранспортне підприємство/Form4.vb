Public Class Посади
    Private Sub ПосадиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ПосадиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Автотранспортне_підприємствоDataSet)

    End Sub

    Private Sub Посади_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Посади". При необходимости она может быть перемещена или удалена.
        Me.ПосадиTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Посади)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Таблиці.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Посади_табл.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ПосадиBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ПосадиBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ПосадиBindingSource.MoveFirst()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ПосадиBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ПосадиBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ПосадиBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.ПосадиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Автотранспортне_підприємствоDataSet)
    End Sub
End Class