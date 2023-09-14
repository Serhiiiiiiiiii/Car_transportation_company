Public Class Автомобілі_звіт

    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Автомобілі". При необходимости она может быть перемещена или удалена.
        Me.АвтомобіліTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Автомобілі)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Автомобілі_табл.Show()
        Me.Hide()
    End Sub
End Class