Public Class Вантажі_звіт

    Private Sub Form24_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Вантажі". При необходимости она может быть перемещена или удалена.
        Me.ВантажіTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Вантажі)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Вантажі_табл.Show()
        Me.Hide()
    End Sub
End Class