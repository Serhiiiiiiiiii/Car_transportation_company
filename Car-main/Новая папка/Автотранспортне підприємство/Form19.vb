Public Class Працівники_звіт

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Працівники". При необходимости она может быть перемещена или удалена.
        Me.ПрацівникиTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Працівники)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Працівники_табл.Show()
        Me.Hide()
    End Sub
End Class