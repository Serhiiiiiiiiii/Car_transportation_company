Public Class Види_вантажів_табл
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Види_вантажів". При необходимости она может быть перемещена или удалена.
        Me.Види_вантажівTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Види_вантажів)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn1
            Case 1
                Col = DataGridViewTextBoxColumn2
        End Select
        If RadioButton1.Checked Then
            ВидиВантажівDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            ВидиВантажівDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ВидиВантажівBindingSource.Filter = "Name='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ВидиВантажівBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To ВидиВантажівDataGridView.ColumnCount - 1
            For j = 0 To ВидиВантажівDataGridView.RowCount - 1
                ВидиВантажівDataGridView.Item(i, j).Style.BackColor = Color.White
                ВидиВантажівDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To ВидиВантажівDataGridView.ColumnCount - 1
            For j = 0 To ВидиВантажівDataGridView.RowCount - 1
                If InStr(ВидиВантажівDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    ВидиВантажівDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    ВидиВантажівDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Види_вантажів.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Види_вантажів_звіт.Show()
        Me.Hide()
    End Sub
End Class