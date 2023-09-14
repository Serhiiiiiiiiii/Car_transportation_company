<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Види_вантажів
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
        Dim Code_of_the_type_of_car_for_transportationLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
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
        Me.Види_вантажівBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Види_вантажівTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.Види_вантажівTableAdapter()
        Me.TableAdapterManager = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager()
        Me.Види_автомобілівTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.Види_автомобілівTableAdapter()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Code_of_the_type_of_car_for_transportationComboBox = New System.Windows.Forms.ComboBox()
        Me.ВидиАвтомобілівBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        NameLabel = New System.Windows.Forms.Label()
        Code_of_the_type_of_car_for_transportationLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Види_вантажівBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ВидиАвтомобілівBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.BackColor = System.Drawing.Color.Pink
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        NameLabel.Location = New System.Drawing.Point(12, 168)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(190, 25)
        NameLabel.TabIndex = 130
        NameLabel.Text = "Назва:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Code_of_the_type_of_car_for_transportationLabel
        '
        Code_of_the_type_of_car_for_transportationLabel.BackColor = System.Drawing.Color.Pink
        Code_of_the_type_of_car_for_transportationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Code_of_the_type_of_car_for_transportationLabel.Location = New System.Drawing.Point(12, 249)
        Code_of_the_type_of_car_for_transportationLabel.Name = "Code_of_the_type_of_car_for_transportationLabel"
        Code_of_the_type_of_car_for_transportationLabel.Size = New System.Drawing.Size(190, 25)
        Code_of_the_type_of_car_for_transportationLabel.TabIndex = 131
        Code_of_the_type_of_car_for_transportationLabel.Text = "Вид автомобіля:"
        Code_of_the_type_of_car_for_transportationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DescriptionLabel
        '
        DescriptionLabel.BackColor = System.Drawing.Color.Pink
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        DescriptionLabel.Location = New System.Drawing.Point(12, 327)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(190, 25)
        DescriptionLabel.TabIndex = 132
        DescriptionLabel.Text = "Опис:"
        DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Pink
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 103)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Таблиця ""Види_вантажів"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Pink
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(481, 44)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 36)
        Me.Button9.TabIndex = 122
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Pink
        Me.Button8.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button8.Location = New System.Drawing.Point(481, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 36)
        Me.Button8.TabIndex = 121
        Me.Button8.Text = "Закрити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Pink
        Me.Button7.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button7.Location = New System.Drawing.Point(470, 378)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 36)
        Me.Button7.TabIndex = 120
        Me.Button7.Text = "Зберегти"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Pink
        Me.Button6.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button6.Location = New System.Drawing.Point(470, 336)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 36)
        Me.Button6.TabIndex = 119
        Me.Button6.Text = "Видалити"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Pink
        Me.Button5.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Location = New System.Drawing.Point(470, 294)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 36)
        Me.Button5.TabIndex = 118
        Me.Button5.Text = "Додати"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Pink
        Me.Button4.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Location = New System.Drawing.Point(470, 252)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 36)
        Me.Button4.TabIndex = 117
        Me.Button4.Text = "Остання"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Pink
        Me.Button3.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(470, 210)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 36)
        Me.Button3.TabIndex = 116
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Pink
        Me.Button2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(470, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 36)
        Me.Button2.TabIndex = 115
        Me.Button2.Text = "Наступна"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Pink
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(463, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 36)
        Me.Button1.TabIndex = 114
        Me.Button1.Text = "Попередня"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Автотранспортне_підприємствоDataSet
        '
        Me.Автотранспортне_підприємствоDataSet.DataSetName = "Автотранспортне_підприємствоDataSet"
        Me.Автотранспортне_підприємствоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Види_вантажівBindingSource
        '
        Me.Види_вантажівBindingSource.DataMember = "Види вантажів"
        Me.Види_вантажівBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'Види_вантажівTableAdapter
        '
        Me.Види_вантажівTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.АвтомобіліTableAdapter = Nothing
        Me.TableAdapterManager.ВантажіTableAdapter = Nothing
        Me.TableAdapterManager.Види_автомобілівTableAdapter = Me.Види_автомобілівTableAdapter
        Me.TableAdapterManager.Види_вантажівTableAdapter = Me.Види_вантажівTableAdapter
        Me.TableAdapterManager.Марки_автомобілівTableAdapter = Nothing
        Me.TableAdapterManager.ПосадиTableAdapter = Nothing
        Me.TableAdapterManager.ПрацівникиTableAdapter = Nothing
        Me.TableAdapterManager.РейсиTableAdapter = Nothing
        '
        'Види_автомобілівTableAdapter
        '
        Me.Види_автомобілівTableAdapter.ClearBeforeFill = True
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Види_вантажівBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NameTextBox.Location = New System.Drawing.Point(210, 167)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(243, 26)
        Me.NameTextBox.TabIndex = 131
        '
        'Code_of_the_type_of_car_for_transportationComboBox
        '
        Me.Code_of_the_type_of_car_for_transportationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Види_вантажівBindingSource, "Code_of_the_type_of_car_for_transportation", True))
        Me.Code_of_the_type_of_car_for_transportationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Види_вантажівBindingSource, "Code_of_the_type_of_car_for_transportation", True))
        Me.Code_of_the_type_of_car_for_transportationComboBox.DataSource = Me.ВидиАвтомобілівBindingSource
        Me.Code_of_the_type_of_car_for_transportationComboBox.DisplayMember = "Name"
        Me.Code_of_the_type_of_car_for_transportationComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Code_of_the_type_of_car_for_transportationComboBox.FormattingEnabled = True
        Me.Code_of_the_type_of_car_for_transportationComboBox.Location = New System.Drawing.Point(210, 246)
        Me.Code_of_the_type_of_car_for_transportationComboBox.Name = "Code_of_the_type_of_car_for_transportationComboBox"
        Me.Code_of_the_type_of_car_for_transportationComboBox.Size = New System.Drawing.Size(243, 28)
        Me.Code_of_the_type_of_car_for_transportationComboBox.TabIndex = 132
        Me.Code_of_the_type_of_car_for_transportationComboBox.ValueMember = "Car_view_code"
        '
        'ВидиАвтомобілівBindingSource
        '
        Me.ВидиАвтомобілівBindingSource.DataMember = "Види автомобілів"
        Me.ВидиАвтомобілівBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Види_вантажівBindingSource, "Description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DescriptionTextBox.Location = New System.Drawing.Point(210, 326)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(243, 26)
        Me.DescriptionTextBox.TabIndex = 133
        '
        'Види_вантажів
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(599, 425)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Code_of_the_type_of_car_for_transportationLabel)
        Me.Controls.Add(Me.Code_of_the_type_of_car_for_transportationComboBox)
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
        Me.Name = "Види_вантажів"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Види вантажів"
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Види_вантажівBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ВидиАвтомобілівBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Види_вантажівBindingSource As BindingSource
    Friend WithEvents Види_вантажівTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.Види_вантажівTableAdapter
    Friend WithEvents TableAdapterManager As Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Code_of_the_type_of_car_for_transportationComboBox As ComboBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents Види_автомобілівTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.Види_автомобілівTableAdapter
    Friend WithEvents ВидиАвтомобілівBindingSource As BindingSource
End Class
