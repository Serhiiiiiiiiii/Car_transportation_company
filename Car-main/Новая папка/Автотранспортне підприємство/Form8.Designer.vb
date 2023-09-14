<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Вантажі
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim Cargo_type_codeLabel As System.Windows.Forms.Label
        Dim Expiration_dateLabel As System.Windows.Forms.Label
        Dim FeaturesLabel As System.Windows.Forms.Label
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
        Me.ВантажіBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ВантажіTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.ВантажіTableAdapter()
        Me.TableAdapterManager = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager()
        Me.Види_вантажівTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.Види_вантажівTableAdapter()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Cargo_type_codeComboBox = New System.Windows.Forms.ComboBox()
        Me.ВидиВантажівBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Expiration_dateTextBox = New System.Windows.Forms.TextBox()
        Me.FeaturesTextBox = New System.Windows.Forms.TextBox()
        NameLabel = New System.Windows.Forms.Label()
        Cargo_type_codeLabel = New System.Windows.Forms.Label()
        Expiration_dateLabel = New System.Windows.Forms.Label()
        FeaturesLabel = New System.Windows.Forms.Label()
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ВантажіBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ВидиВантажівBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.BackColor = System.Drawing.Color.Pink
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        NameLabel.Location = New System.Drawing.Point(4, 146)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(155, 25)
        NameLabel.TabIndex = 93
        NameLabel.Text = "Назва:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cargo_type_codeLabel
        '
        Cargo_type_codeLabel.BackColor = System.Drawing.Color.Pink
        Cargo_type_codeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Cargo_type_codeLabel.Location = New System.Drawing.Point(4, 202)
        Cargo_type_codeLabel.Name = "Cargo_type_codeLabel"
        Cargo_type_codeLabel.Size = New System.Drawing.Size(155, 25)
        Cargo_type_codeLabel.TabIndex = 94
        Cargo_type_codeLabel.Text = "Вид:"
        Cargo_type_codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Expiration_dateLabel
        '
        Expiration_dateLabel.BackColor = System.Drawing.Color.Pink
        Expiration_dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Expiration_dateLabel.Location = New System.Drawing.Point(4, 249)
        Expiration_dateLabel.Name = "Expiration_dateLabel"
        Expiration_dateLabel.Size = New System.Drawing.Size(155, 50)
        Expiration_dateLabel.TabIndex = 95
        Expiration_dateLabel.Text = "Термін придатності:"
        Expiration_dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FeaturesLabel
        '
        FeaturesLabel.BackColor = System.Drawing.Color.Pink
        FeaturesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        FeaturesLabel.Location = New System.Drawing.Point(4, 326)
        FeaturesLabel.Name = "FeaturesLabel"
        FeaturesLabel.Size = New System.Drawing.Size(155, 25)
        FeaturesLabel.TabIndex = 96
        FeaturesLabel.Text = "Особливості:"
        FeaturesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Pink
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 45)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Таблиця ""Вантажі"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Pink
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(482, 43)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 36)
        Me.Button9.TabIndex = 83
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Pink
        Me.Button8.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button8.Location = New System.Drawing.Point(482, 1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 36)
        Me.Button8.TabIndex = 82
        Me.Button8.Text = "Закрити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Pink
        Me.Button7.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button7.Location = New System.Drawing.Point(471, 377)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 36)
        Me.Button7.TabIndex = 81
        Me.Button7.Text = "Зберегти"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Pink
        Me.Button6.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button6.Location = New System.Drawing.Point(471, 335)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 36)
        Me.Button6.TabIndex = 80
        Me.Button6.Text = "Видалити"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Pink
        Me.Button5.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Location = New System.Drawing.Point(471, 293)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 36)
        Me.Button5.TabIndex = 79
        Me.Button5.Text = "Додати"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Pink
        Me.Button4.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Location = New System.Drawing.Point(471, 251)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 36)
        Me.Button4.TabIndex = 78
        Me.Button4.Text = "Остання"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Pink
        Me.Button3.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(471, 209)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 36)
        Me.Button3.TabIndex = 77
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Pink
        Me.Button2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(471, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 36)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "Наступна"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Pink
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(464, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 36)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Попередня"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Автотранспортне_підприємствоDataSet
        '
        Me.Автотранспортне_підприємствоDataSet.DataSetName = "Автотранспортне_підприємствоDataSet"
        Me.Автотранспортне_підприємствоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ВантажіBindingSource
        '
        Me.ВантажіBindingSource.DataMember = "Вантажі"
        Me.ВантажіBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'ВантажіTableAdapter
        '
        Me.ВантажіTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.АвтомобіліTableAdapter = Nothing
        Me.TableAdapterManager.ВантажіTableAdapter = Me.ВантажіTableAdapter
        Me.TableAdapterManager.Види_автомобілівTableAdapter = Nothing
        Me.TableAdapterManager.Види_вантажівTableAdapter = Me.Види_вантажівTableAdapter
        Me.TableAdapterManager.Марки_автомобілівTableAdapter = Nothing
        Me.TableAdapterManager.ПосадиTableAdapter = Nothing
        Me.TableAdapterManager.ПрацівникиTableAdapter = Nothing
        Me.TableAdapterManager.РейсиTableAdapter = Nothing
        '
        'Види_вантажівTableAdapter
        '
        Me.Види_вантажівTableAdapter.ClearBeforeFill = True
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВантажіBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NameTextBox.Location = New System.Drawing.Point(165, 145)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(289, 26)
        Me.NameTextBox.TabIndex = 94
        '
        'Cargo_type_codeComboBox
        '
        Me.Cargo_type_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВантажіBindingSource, "Cargo_type_code", True))
        Me.Cargo_type_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ВантажіBindingSource, "Cargo_type_code", True))
        Me.Cargo_type_codeComboBox.DataSource = Me.ВидиВантажівBindingSource
        Me.Cargo_type_codeComboBox.DisplayMember = "Name"
        Me.Cargo_type_codeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Cargo_type_codeComboBox.FormattingEnabled = True
        Me.Cargo_type_codeComboBox.Location = New System.Drawing.Point(165, 199)
        Me.Cargo_type_codeComboBox.Name = "Cargo_type_codeComboBox"
        Me.Cargo_type_codeComboBox.Size = New System.Drawing.Size(289, 28)
        Me.Cargo_type_codeComboBox.TabIndex = 95
        Me.Cargo_type_codeComboBox.ValueMember = "Cargo_type_code"
        '
        'ВидиВантажівBindingSource
        '
        Me.ВидиВантажівBindingSource.DataMember = "Види вантажів"
        Me.ВидиВантажівBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'Expiration_dateTextBox
        '
        Me.Expiration_dateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВантажіBindingSource, "Expiration_date", True))
        Me.Expiration_dateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Expiration_dateTextBox.Location = New System.Drawing.Point(165, 261)
        Me.Expiration_dateTextBox.Name = "Expiration_dateTextBox"
        Me.Expiration_dateTextBox.Size = New System.Drawing.Size(289, 26)
        Me.Expiration_dateTextBox.TabIndex = 96
        '
        'FeaturesTextBox
        '
        Me.FeaturesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВантажіBindingSource, "Features", True))
        Me.FeaturesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FeaturesTextBox.Location = New System.Drawing.Point(165, 325)
        Me.FeaturesTextBox.Name = "FeaturesTextBox"
        Me.FeaturesTextBox.Size = New System.Drawing.Size(289, 26)
        Me.FeaturesTextBox.TabIndex = 97
        '
        'Вантажі
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(599, 422)
        Me.Controls.Add(FeaturesLabel)
        Me.Controls.Add(Me.FeaturesTextBox)
        Me.Controls.Add(Expiration_dateLabel)
        Me.Controls.Add(Me.Expiration_dateTextBox)
        Me.Controls.Add(Cargo_type_codeLabel)
        Me.Controls.Add(Me.Cargo_type_codeComboBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
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
        Me.Name = "Вантажі"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Вантажі"
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ВантажіBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ВидиВантажівBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ВантажіBindingSource As BindingSource
    Friend WithEvents ВантажіTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.ВантажіTableAdapter
    Friend WithEvents TableAdapterManager As Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Види_вантажівTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.Види_вантажівTableAdapter
    Friend WithEvents Cargo_type_codeComboBox As ComboBox
    Friend WithEvents Expiration_dateTextBox As TextBox
    Friend WithEvents FeaturesTextBox As TextBox
    Friend WithEvents ВидиВантажівBindingSource As BindingSource
End Class
