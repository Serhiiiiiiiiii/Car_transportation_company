Public Class Вантажі
    Private Sub ВантажіBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ВантажіBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Автотранспортне_підприємствоDataSet)

    End Sub

    Private Sub Вантажі_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Види_вантажів". При необходимости она может быть перемещена или удалена.
        Me.Види_вантажівTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Види_вантажів)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Вантажі". При необходимости она может быть перемещена или удалена.
        Me.ВантажіTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Вантажі)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Таблиці.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Вантажі_табл.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ВантажіBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ВантажіBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ВантажіBindingSource.MoveFirst()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ВантажіBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ВантажіBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ВантажіBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.ВантажіBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Автотранспортне_підприємствоDataSet)
    End Sub
End Class