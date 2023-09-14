Public Class Марки_автомобілів_звіт

    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Марки_автомобілів". При необходимости она может быть перемещена или удалена.
        Me.Марки_автомобілівTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Марки_автомобілів)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Марки_автомобілів_табл.Show()
        Me.Hide()
    End Sub
End Class