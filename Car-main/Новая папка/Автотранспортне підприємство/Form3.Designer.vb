<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Працівники
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
        Dim AgeLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Passport_dataLabel As System.Windows.Forms.Label
        Dim Position_codeLabel As System.Windows.Forms.Label
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
        Me.ПрацівникиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПрацівникиTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.ПрацівникиTableAdapter()
        Me.TableAdapterManager = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Position_codeComboBox = New System.Windows.Forms.ComboBox()
        Me.ПосадиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПосадиTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.ПосадиTableAdapter()
        Me.Автотранспортне_підприємствоDataSet1 = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSet1()
        Me.ПрацівникиBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПрацівникиTableAdapter1 = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSet1TableAdapters.ПрацівникиTableAdapter()
        Me.TableAdapterManager1 = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSet1TableAdapters.TableAdapterManager()
        NameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Passport_dataLabel = New System.Windows.Forms.Label()
        Position_codeLabel = New System.Windows.Forms.Label()
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПрацівникиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПосадиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Автотранспортне_підприємствоDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПрацівникиBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.BackColor = System.Drawing.Color.Pink
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        NameLabel.Location = New System.Drawing.Point(25, 109)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(110, 25)
        NameLabel.TabIndex = 44
        NameLabel.Text = "ПІБ:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AgeLabel
        '
        AgeLabel.BackColor = System.Drawing.Color.Pink
        AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        AgeLabel.Location = New System.Drawing.Point(25, 145)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(110, 25)
        AgeLabel.TabIndex = 45
        AgeLabel.Text = "Вік:"
        AgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GenderLabel
        '
        GenderLabel.BackColor = System.Drawing.Color.Pink
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        GenderLabel.Location = New System.Drawing.Point(25, 184)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(110, 25)
        GenderLabel.TabIndex = 46
        GenderLabel.Text = "Стать:"
        GenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddressLabel
        '
        AddressLabel.BackColor = System.Drawing.Color.Pink
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        AddressLabel.Location = New System.Drawing.Point(25, 223)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(110, 25)
        AddressLabel.TabIndex = 47
        AddressLabel.Text = "Адреса:"
        AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PhoneLabel
        '
        PhoneLabel.BackColor = System.Drawing.Color.Pink
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        PhoneLabel.Location = New System.Drawing.Point(25, 262)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(110, 25)
        PhoneLabel.TabIndex = 48
        PhoneLabel.Text = "Телефон:"
        PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Passport_dataLabel
        '
        Passport_dataLabel.BackColor = System.Drawing.Color.Pink
        Passport_dataLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Passport_dataLabel.Location = New System.Drawing.Point(22, 340)
        Passport_dataLabel.Name = "Passport_dataLabel"
        Passport_dataLabel.Size = New System.Drawing.Size(113, 50)
        Passport_dataLabel.TabIndex = 49
        Passport_dataLabel.Text = "Паспортні дані:"
        Passport_dataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Position_codeLabel
        '
        Position_codeLabel.BackColor = System.Drawing.Color.Pink
        Position_codeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Position_codeLabel.Location = New System.Drawing.Point(25, 300)
        Position_codeLabel.Name = "Position_codeLabel"
        Position_codeLabel.Size = New System.Drawing.Size(110, 25)
        Position_codeLabel.TabIndex = 50
        Position_codeLabel.Text = "Посада:"
        Position_codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Pink
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 45)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Таблиця ""Працівники"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Pink
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(481, 42)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 36)
        Me.Button9.TabIndex = 42
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Pink
        Me.Button8.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button8.Location = New System.Drawing.Point(481, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 36)
        Me.Button8.TabIndex = 41
        Me.Button8.Text = "Закрити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Pink
        Me.Button7.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button7.Location = New System.Drawing.Point(470, 376)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 36)
        Me.Button7.TabIndex = 40
        Me.Button7.Text = "Зберегти"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Pink
        Me.Button6.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button6.Location = New System.Drawing.Point(470, 334)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 36)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "Видалити"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Pink
        Me.Button5.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Location = New System.Drawing.Point(470, 292)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 36)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Додати"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Pink
        Me.Button4.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Location = New System.Drawing.Point(470, 250)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 36)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Остання"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Pink
        Me.Button3.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(470, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 36)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Pink
        Me.Button2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(470, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 36)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Наступна"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Pink
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(463, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 36)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Попередня"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Автотранспортне_підприємствоDataSet
        '
        Me.Автотранспортне_підприємствоDataSet.DataSetName = "Автотранспортне_підприємствоDataSet"
        Me.Автотранспортне_підприємствоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПрацівникиBindingSource
        '
        Me.ПрацівникиBindingSource.DataMember = "Працівники"
        Me.ПрацівникиBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'ПрацівникиTableAdapter
        '
        Me.ПрацівникиTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ПосадиTableAdapter = Nothing
        Me.TableAdapterManager.ПрацівникиTableAdapter = Me.ПрацівникиTableAdapter
        Me.TableAdapterManager.РейсиTableAdapter = Nothing
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NameTextBox.Location = New System.Drawing.Point(153, 108)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(289, 26)
        Me.NameTextBox.TabIndex = 45
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "Age", True))
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AgeTextBox.Location = New System.Drawing.Point(153, 144)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(289, 26)
        Me.AgeTextBox.TabIndex = 46
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(153, 222)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(289, 26)
        Me.AddressTextBox.TabIndex = 48
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "Gender", True))
        Me.GenderComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Чоловік", "Жінка"})
        Me.GenderComboBox.Location = New System.Drawing.Point(153, 181)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(289, 28)
        Me.GenderComboBox.TabIndex = 52
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "Phone", True))
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MaskedTextBox1.Location = New System.Drawing.Point(153, 261)
        Me.MaskedTextBox1.Mask = "+00(000)00-000-00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(289, 26)
        Me.MaskedTextBox1.TabIndex = 53
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "Passport_data", True))
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MaskedTextBox2.Location = New System.Drawing.Point(153, 354)
        Me.MaskedTextBox2.Mask = "0000-0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(289, 26)
        Me.MaskedTextBox2.TabIndex = 54
        '
        'Position_codeComboBox
        '
        Me.Position_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "Position_code", True))
        Me.Position_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ПрацівникиBindingSource, "Position_code", True))
        Me.Position_codeComboBox.DataSource = Me.ПосадиBindingSource
        Me.Position_codeComboBox.DisplayMember = "Job_title"
        Me.Position_codeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Position_codeComboBox.FormattingEnabled = True
        Me.Position_codeComboBox.Location = New System.Drawing.Point(153, 297)
        Me.Position_codeComboBox.Name = "Position_codeComboBox"
        Me.Position_codeComboBox.Size = New System.Drawing.Size(289, 28)
        Me.Position_codeComboBox.TabIndex = 55
        Me.Position_codeComboBox.ValueMember = "Position_code"
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
        'Автотранспортне_підприємствоDataSet1
        '
        Me.Автотранспортне_підприємствоDataSet1.DataSetName = "Автотранспортне_підприємствоDataSet1"
        Me.Автотранспортне_підприємствоDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПрацівникиBindingSource1
        '
        Me.ПрацівникиBindingSource1.DataMember = "Працівники"
        Me.ПрацівникиBindingSource1.DataSource = Me.Автотранспортне_підприємствоDataSet1
        '
        'ПрацівникиTableAdapter1
        '
        Me.ПрацівникиTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = Автотранспортне_підприємство.Автотранспортне_підприємствоDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.АвтомобіліTableAdapter = Nothing
        Me.TableAdapterManager1.ВантажіTableAdapter = Nothing
        Me.TableAdapterManager1.Види_автомобілівTableAdapter = Nothing
        Me.TableAdapterManager1.Види_вантажівTableAdapter = Nothing
        Me.TableAdapterManager1.Марки_автомобілівTableAdapter = Nothing
        Me.TableAdapterManager1.ПосадиTableAdapter = Nothing
        Me.TableAdapterManager1.ПрацівникиTableAdapter = Me.ПрацівникиTableAdapter1
        Me.TableAdapterManager1.РейсиTableAdapter = Nothing
        '
        'Працівники
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(598, 425)
        Me.Controls.Add(Me.Position_codeComboBox)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Position_codeLabel)
        Me.Controls.Add(Passport_dataLabel)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
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
        Me.Name = "Працівники"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Працівники"
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПрацівникиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПосадиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Автотранспортне_підприємствоDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПрацівникиBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ПрацівникиBindingSource As BindingSource
    Friend WithEvents ПрацівникиTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.ПрацівникиTableAdapter
    Friend WithEvents TableAdapterManager As Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Position_codeComboBox As ComboBox
    Friend WithEvents ПосадиBindingSource As BindingSource
    Friend WithEvents ПосадиTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.ПосадиTableAdapter
    Friend WithEvents Автотранспортне_підприємствоDataSet1 As Автотранспортне_підприємство.Автотранспортне_підприємствоDataSet1
    Friend WithEvents ПрацівникиBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ПрацівникиTableAdapter1 As Автотранспортне_підприємство.Автотранспортне_підприємствоDataSet1TableAdapters.ПрацівникиTableAdapter
    Friend WithEvents TableAdapterManager1 As Автотранспортне_підприємство.Автотранспортне_підприємствоDataSet1TableAdapters.TableAdapterManager
End Class
