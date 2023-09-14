Public Class Рейси_звіт

    Private Sub Рейси_звіт_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Рейси". При необходимости она может быть перемещена или удалена.
        Me.РейсиTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Рейси)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Рейси_табл.Show()
        Me.Hide()
    End Sub
End Class