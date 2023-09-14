Public Class Види_автомобілів_звіт

    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Види_автомобілів". При необходимости она может быть перемещена или удалена.
        Me.Види_автомобілівTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Види_автомобілів)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Види_автомобілів_табл.Show()
        Me.Hide()
    End Sub
End Class