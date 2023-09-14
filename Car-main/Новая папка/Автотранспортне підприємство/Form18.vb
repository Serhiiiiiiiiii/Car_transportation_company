Public Class Рейси_табл
    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Рейси". При необходимости она может быть перемещена или удалена.
        Me.РейсиTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Рейси)

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
            Case 2
                Col = DataGridViewTextBoxColumn3
            Case 3
                Col = DataGridViewTextBoxColumn4
            Case 4
                Col = DataGridViewTextBoxColumn5
            Case 5
                Col = DataGridViewTextBoxColumn6
            Case 6
                Col = DataGridViewTextBoxColumn7
            Case 7
                Col = DataGridViewTextBoxColumn8
        End Select
        If RadioButton1.Checked Then
            РейсиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            РейсиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        РейсиBindingSource.Filter = "Customer='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        РейсиBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To РейсиDataGridView.ColumnCount - 1
            For j = 0 To РейсиDataGridView.RowCount - 1
                РейсиDataGridView.Item(i, j).Style.BackColor = Color.White
                РейсиDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To РейсиDataGridView.ColumnCount - 1
            For j = 0 To РейсиDataGridView.RowCount - 1
                If InStr(РейсиDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    РейсиDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    РейсиDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Рейси.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Рейси_звіт.Show()
        Me.Hide()
    End Sub
End Class