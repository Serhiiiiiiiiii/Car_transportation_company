Public Class Види_вантажів_звіт

    Private Sub Form25_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Види_вантажів". При необходимости она может быть перемещена или удалена.
        Me.Види_вантажівTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Види_вантажів)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Види_вантажів_табл.Show()
        Me.Hide()
    End Sub
End Class