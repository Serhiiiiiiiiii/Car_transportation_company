Public Class Працівники
    Private Sub ПрацівникиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ПрацівникиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Автотранспортне_підприємствоDataSet)

    End Sub

    Private Sub Працівники_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet1.Працівники". При необходимости она может быть перемещена или удалена.
        Me.ПрацівникиTableAdapter1.Fill(Me.Автотранспортне_підприємствоDataSet1.Працівники)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Посади". При необходимости она может быть перемещена или удалена.
        Me.ПосадиTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Посади)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Працівники". При необходимости она может быть перемещена или удалена.
        Me.ПрацівникиTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Працівники)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Таблиці.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Працівники_табл.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ПрацівникиBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ПрацівникиBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ПрацівникиBindingSource.MoveFirst()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ПрацівникиBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ПрацівникиBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ПрацівникиBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.ПрацівникиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Автотранспортне_підприємствоDataSet)
    End Sub
End Class