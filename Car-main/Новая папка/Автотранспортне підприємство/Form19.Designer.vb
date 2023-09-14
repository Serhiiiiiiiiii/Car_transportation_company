<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Працівники_звіт
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ПрацівникиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Автотранспортне_підприємствоDataSet = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ПрацівникиTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.ПрацівникиTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ПрацівникиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ПрацівникиBindingSource
        '
        Me.ПрацівникиBindingSource.DataMember = "Працівники"
        Me.ПрацівникиBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'Автотранспортне_підприємствоDataSet
        '
        Me.Автотранспортне_підприємствоDataSet.DataSetName = "Автотранспортне_підприємствоDataSet"
        Me.Автотранспортне_підприємствоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ПрацівникиBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Автотранспортне_підприємство.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 51)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(533, 397)
        Me.ReportViewer1.TabIndex = 0
        '
        'ПрацівникиTableAdapter
        '
        Me.ПрацівникиTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Pink
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(533, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "З а к р и т и"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Працівники_звіт
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Працівники_звіт"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Звіт ""Працівники"""
        CType(Me.ПрацівникиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ПрацівникиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Автотранспортне_підприємствоDataSet As Автотранспортне_підприємство.Автотранспортне_підприємствоDataSet
    Friend WithEvents ПрацівникиTableAdapter As Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.ПрацівникиTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
