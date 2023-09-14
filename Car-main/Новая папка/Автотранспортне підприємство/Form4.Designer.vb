<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Посади
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
        Dim Job_titleLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim ResponsibilitiesLabel As System.Windows.Forms.Label
        Dim RequirementsLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Автотранспортне_підприємствоDataSet = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSet()
        Me.ПосадиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПосадиTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.ПосадиTableAdapter()
        Me.TableAdapterManager = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager()
        Me.Job_titleTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.ResponsibilitiesTextBox = New System.Windows.Forms.TextBox()
        Me.RequirementsTextBox = New System.Windows.Forms.TextBox()
        Job_titleLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        ResponsibilitiesLabel = New System.Windows.Forms.Label()
        RequirementsLabel = New System.Windows.Forms.Label()
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПосадиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Job_titleLabel
        '
        Job_titleLabel.BackColor = System.Drawing.Color.Pink
        Job_titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Job_titleLabel.Location = New System.Drawing.Point(26, 135)
        Job_titleLabel.Name = "Job_titleLabel"
        Job_titleLabel.Size = New System.Drawing.Size(120, 25)
        Job_titleLabel.TabIndex = 70
        Job_titleLabel.Text = "Посада:"
        Job_titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SalaryLabel
        '
        SalaryLabel.BackColor = System.Drawing.Color.Pink
        SalaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        SalaryLabel.Location = New System.Drawing.Point(26, 201)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(120, 25)
        SalaryLabel.TabIndex = 71
        SalaryLabel.Text = "Оклад:"
        SalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ResponsibilitiesLabel
        '
        ResponsibilitiesLabel.BackColor = System.Drawing.Color.Pink
        ResponsibilitiesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        ResponsibilitiesLabel.Location = New System.Drawing.Point(26, 263)
        ResponsibilitiesLabel.Name = "ResponsibilitiesLabel"
        ResponsibilitiesLabel.Size = New System.Drawing.Size(120, 25)
        ResponsibilitiesLabel.TabIndex = 72
        ResponsibilitiesLabel.Text = "Обов'язки:"
        ResponsibilitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RequirementsLabel
        '
        RequirementsLabel.BackColor = System.Drawing.Color.Pink
        RequirementsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        RequirementsLabel.Location = New System.Drawing.Point(26, 337)
        RequirementsLabel.Name = "RequirementsLabel"
        RequirementsLabel.Size = New System.Drawing.Size(120, 25)
        RequirementsLabel.TabIndex = 73
        RequirementsLabel.Text = "Вимоги:"
        RequirementsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Pink
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 45)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Таблиця ""Посади"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Pink
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(482, 42)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 36)
        Me.Button9.TabIndex = 64
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Pink
        Me.Button8.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button8.Location = New System.Drawing.Point(482, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 36)
        Me.Button8.TabIndex = 63
        Me.Button8.Text = "Закрити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Pink
        Me.Button7.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button7.Location = New System.Drawing.Point(471, 376)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 36)
        Me.Button7.TabIndex = 62
        Me.Button7.Text = "Зберегти"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Pink
        Me.Button6.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button6.Location = New System.Drawing.Point(471, 334)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 36)
        Me.Button6.TabIndex = 61
        Me.Button6.Text = "Видалити"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Pink
        Me.Button5.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Location = New System.Drawing.Point(471, 292)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 36)
        Me.Button5.TabIndex = 60
        Me.Button5.Text = "Додати"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Pink
        Me.Button4.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Location = New System.Drawing.Point(471, 250)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 36)
        Me.Button4.TabIndex = 59
        Me.Button4.Text = "Остання"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Pink
        Me.Button3.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(471, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 36)
        Me.Button3.TabIndex = 58
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Pink
        Me.Button2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(471, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 36)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "Наступна"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Pink
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(464, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 36)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Попередня"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Автотранспортне_підприємствоDataSet
        '
        Me.Автотранспортне_підприємствоDataSet.DataSetName = "Автотранспортне_підприємствоDataSet"
        Me.Автотранспортне_підприємствоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПосадиBindingSource
        '
        Me.ПосадиBindingSource.DataMember = "Посади"
        Me.ПосадиBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'ПосадиTableAdapter
        '
        Me.ПосадиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.АвтомобіліTableAdapter = Nothing
        Me.TableAdapterManager.ВантажіTableAdapter = Nothing
        Me.TableAdapterManager.Види_автомобілівTableAdapter = Nothing
        Me.TableAdapterManager.Види_вантажівTableAdapter = Nothing
        Me.TableAdapterManager.Марки_автомобілівTableAdapter = Nothing
        Me.TableAdapterManager.ПосадиTableAdapter = Me.ПосадиTableAdapter
        Me.TableAdapterManager.ПрацівникиTableAdapter = Nothing
        Me.TableAdapterManager.РейсиTableAdapter = Nothing
        '
        'Job_titleTextBox
        '
        Me.Job_titleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПосадиBindingSource, "Job_title", True))
        Me.Job_titleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Job_titleTextBox.Location = New System.Drawing.Point(165, 133)
        Me.Job_titleTextBox.Name = "Job_titleTextBox"
        Me.Job_titleTextBox.Size = New System.Drawing.Size(289, 26)
        Me.Job_titleTextBox.TabIndex = 71
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПосадиBindingSource, "Salary", True))
        Me.SalaryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SalaryTextBox.Location = New System.Drawing.Point(165, 200)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(289, 26)
        Me.SalaryTextBox.TabIndex = 72
        '
        'ResponsibilitiesTextBox
        '
        Me.ResponsibilitiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПосадиBindingSource, "Responsibilities", True))
        Me.ResponsibilitiesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ResponsibilitiesTextBox.Location = New System.Drawing.Point(165, 262)
        Me.ResponsibilitiesTextBox.Name = "ResponsibilitiesTextBox"
        Me.ResponsibilitiesTextBox.Size = New System.Drawing.Size(289, 26)
        Me.ResponsibilitiesTextBox.TabIndex = 73
        '
        'RequirementsTextBox
        '
        Me.RequirementsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПосадиBindingSource, "Requirements", True))
        Me.RequirementsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RequirementsTextBox.Location = New System.Drawing.Point(165, 336)
        Me.RequirementsTextBox.Name = "RequirementsTextBox"
        Me.RequirementsTextBox.Size = New System.Drawing.Size(289, 26)
        Me.RequirementsTextBox.TabIndex = 74
        '
        'Посади
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(599, 422)
        Me.Controls.Add(RequirementsLabel)
        Me.Controls.Add(Me.RequirementsTextBox)
        Me.Controls.Add(ResponsibilitiesLabel)
        Me.Controls.Add(Me.ResponsibilitiesTextBox)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Job_titleLabel)
        Me.Controls.Add(Me.Job_titleTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Посади"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Посади"
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПосадиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Автотранспортне_підприємствоDataSet As Автотранспортне_підприємствоDataSet
    Friend WithEvents ПосадиBindingSource As BindingSource
    Friend WithEvents ПосадиTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.ПосадиTableAdapter
    Friend WithEvents TableAdapterManager As Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Job_titleTextBox As TextBox
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents ResponsibilitiesTextBox As TextBox
    Friend WithEvents RequirementsTextBox As TextBox
End Class
