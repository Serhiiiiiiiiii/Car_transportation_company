<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Рейси
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
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim Where_zvidkuLabel As System.Windows.Forms.Label
        Dim Where_kyduLabel As System.Windows.Forms.Label
        Dim Date_of_departureLabel As System.Windows.Forms.Label
        Dim Date_of_arrivalLabel As System.Windows.Forms.Label
        Dim Cargo_codeLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim Payment_markLabel As System.Windows.Forms.Label
        Dim Return_markLabel As System.Windows.Forms.Label
        Dim Employee_codeLabel As System.Windows.Forms.Label
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
        Me.РейсиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РейсиTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.РейсиTableAdapter()
        Me.TableAdapterManager = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager()
        Me.ВантажіTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.ВантажіTableAdapter()
        Me.ПрацівникиTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.ПрацівникиTableAdapter()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.Where_zvidkuTextBox = New System.Windows.Forms.TextBox()
        Me.Where_kyduTextBox = New System.Windows.Forms.TextBox()
        Me.Cargo_codeComboBox = New System.Windows.Forms.ComboBox()
        Me.ВантажіBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Payment_markTextBox = New System.Windows.Forms.TextBox()
        Me.Return_markTextBox = New System.Windows.Forms.TextBox()
        Me.Employee_codeComboBox = New System.Windows.Forms.ComboBox()
        Me.ПрацівникиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        CustomerLabel = New System.Windows.Forms.Label()
        Where_zvidkuLabel = New System.Windows.Forms.Label()
        Where_kyduLabel = New System.Windows.Forms.Label()
        Date_of_departureLabel = New System.Windows.Forms.Label()
        Date_of_arrivalLabel = New System.Windows.Forms.Label()
        Cargo_codeLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Payment_markLabel = New System.Windows.Forms.Label()
        Return_markLabel = New System.Windows.Forms.Label()
        Employee_codeLabel = New System.Windows.Forms.Label()
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РейсиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ВантажіBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПрацівникиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerLabel
        '
        CustomerLabel.BackColor = System.Drawing.Color.Pink
        CustomerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        CustomerLabel.Location = New System.Drawing.Point(12, 75)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(175, 25)
        CustomerLabel.TabIndex = 94
        CustomerLabel.Text = "Замовник:"
        CustomerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Where_zvidkuLabel
        '
        Where_zvidkuLabel.BackColor = System.Drawing.Color.Pink
        Where_zvidkuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Where_zvidkuLabel.Location = New System.Drawing.Point(12, 110)
        Where_zvidkuLabel.Name = "Where_zvidkuLabel"
        Where_zvidkuLabel.Size = New System.Drawing.Size(175, 25)
        Where_zvidkuLabel.TabIndex = 95
        Where_zvidkuLabel.Text = "Звідки:"
        Where_zvidkuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Where_kyduLabel
        '
        Where_kyduLabel.BackColor = System.Drawing.Color.Pink
        Where_kyduLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Where_kyduLabel.Location = New System.Drawing.Point(12, 145)
        Where_kyduLabel.Name = "Where_kyduLabel"
        Where_kyduLabel.Size = New System.Drawing.Size(175, 25)
        Where_kyduLabel.TabIndex = 96
        Where_kyduLabel.Text = "Куди:"
        Where_kyduLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Date_of_departureLabel
        '
        Date_of_departureLabel.BackColor = System.Drawing.Color.Pink
        Date_of_departureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Date_of_departureLabel.Location = New System.Drawing.Point(12, 180)
        Date_of_departureLabel.Name = "Date_of_departureLabel"
        Date_of_departureLabel.Size = New System.Drawing.Size(175, 25)
        Date_of_departureLabel.TabIndex = 97
        Date_of_departureLabel.Text = "Дата відправки:"
        Date_of_departureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Date_of_arrivalLabel
        '
        Date_of_arrivalLabel.BackColor = System.Drawing.Color.Pink
        Date_of_arrivalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Date_of_arrivalLabel.Location = New System.Drawing.Point(12, 215)
        Date_of_arrivalLabel.Name = "Date_of_arrivalLabel"
        Date_of_arrivalLabel.Size = New System.Drawing.Size(175, 25)
        Date_of_arrivalLabel.TabIndex = 98
        Date_of_arrivalLabel.Text = "Дата прибуття:"
        Date_of_arrivalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cargo_codeLabel
        '
        Cargo_codeLabel.BackColor = System.Drawing.Color.Pink
        Cargo_codeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Cargo_codeLabel.Location = New System.Drawing.Point(12, 250)
        Cargo_codeLabel.Name = "Cargo_codeLabel"
        Cargo_codeLabel.Size = New System.Drawing.Size(175, 25)
        Cargo_codeLabel.TabIndex = 99
        Cargo_codeLabel.Text = "Вантаж:"
        Cargo_codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PriceLabel
        '
        PriceLabel.BackColor = System.Drawing.Color.Pink
        PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        PriceLabel.Location = New System.Drawing.Point(12, 285)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(175, 25)
        PriceLabel.TabIndex = 100
        PriceLabel.Text = "Ціна:"
        PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Payment_markLabel
        '
        Payment_markLabel.BackColor = System.Drawing.Color.Pink
        Payment_markLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Payment_markLabel.Location = New System.Drawing.Point(12, 320)
        Payment_markLabel.Name = "Payment_markLabel"
        Payment_markLabel.Size = New System.Drawing.Size(175, 25)
        Payment_markLabel.TabIndex = 101
        Payment_markLabel.Text = "Оплата:"
        Payment_markLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Return_markLabel
        '
        Return_markLabel.BackColor = System.Drawing.Color.Pink
        Return_markLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Return_markLabel.Location = New System.Drawing.Point(14, 355)
        Return_markLabel.Name = "Return_markLabel"
        Return_markLabel.Size = New System.Drawing.Size(175, 25)
        Return_markLabel.TabIndex = 102
        Return_markLabel.Text = "Повернення:"
        Return_markLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Employee_codeLabel
        '
        Employee_codeLabel.BackColor = System.Drawing.Color.Pink
        Employee_codeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Employee_codeLabel.Location = New System.Drawing.Point(14, 390)
        Employee_codeLabel.Name = "Employee_codeLabel"
        Employee_codeLabel.Size = New System.Drawing.Size(175, 25)
        Employee_codeLabel.TabIndex = 103
        Employee_codeLabel.Text = "Водій:"
        Employee_codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Pink
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 45)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Таблиця ""Рейси"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Pink
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(481, 43)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 36)
        Me.Button9.TabIndex = 88
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Pink
        Me.Button8.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button8.Location = New System.Drawing.Point(481, 1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 36)
        Me.Button8.TabIndex = 87
        Me.Button8.Text = "Закрити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Pink
        Me.Button7.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button7.Location = New System.Drawing.Point(470, 377)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 36)
        Me.Button7.TabIndex = 86
        Me.Button7.Text = "Зберегти"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Pink
        Me.Button6.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button6.Location = New System.Drawing.Point(470, 335)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 36)
        Me.Button6.TabIndex = 85
        Me.Button6.Text = "Видалити"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Pink
        Me.Button5.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Location = New System.Drawing.Point(470, 293)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 36)
        Me.Button5.TabIndex = 84
        Me.Button5.Text = "Додати"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Pink
        Me.Button4.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Location = New System.Drawing.Point(470, 251)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 36)
        Me.Button4.TabIndex = 83
        Me.Button4.Text = "Остання"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Pink
        Me.Button3.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(470, 209)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 36)
        Me.Button3.TabIndex = 82
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Pink
        Me.Button2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(470, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 36)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "Наступна"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Pink
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(463, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 36)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "Попередня"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Автотранспортне_підприємствоDataSet
        '
        Me.Автотранспортне_підприємствоDataSet.DataSetName = "Автотранспортне_підприємствоDataSet"
        Me.Автотранспортне_підприємствоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'РейсиBindingSource
        '
        Me.РейсиBindingSource.DataMember = "Рейси"
        Me.РейсиBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'РейсиTableAdapter
        '
        Me.РейсиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.АвтомобіліTableAdapter = Nothing
        Me.TableAdapterManager.ВантажіTableAdapter = Me.ВантажіTableAdapter
        Me.TableAdapterManager.Види_автомобілівTableAdapter = Nothing
        Me.TableAdapterManager.Види_вантажівTableAdapter = Nothing
        Me.TableAdapterManager.Марки_автомобілівTableAdapter = Nothing
        Me.TableAdapterManager.ПосадиTableAdapter = Nothing
        Me.TableAdapterManager.ПрацівникиTableAdapter = Me.ПрацівникиTableAdapter
        Me.TableAdapterManager.РейсиTableAdapter = Me.РейсиTableAdapter
        '
        'ВантажіTableAdapter
        '
        Me.ВантажіTableAdapter.ClearBeforeFill = True
        '
        'ПрацівникиTableAdapter
        '
        Me.ПрацівникиTableAdapter.ClearBeforeFill = True
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РейсиBindingSource, "Customer", True))
        Me.CustomerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CustomerTextBox.Location = New System.Drawing.Point(202, 74)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(250, 26)
        Me.CustomerTextBox.TabIndex = 95
        '
        'Where_zvidkuTextBox
        '
        Me.Where_zvidkuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РейсиBindingSource, "Where_zvidku", True))
        Me.Where_zvidkuTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Where_zvidkuTextBox.Location = New System.Drawing.Point(202, 109)
        Me.Where_zvidkuTextBox.Name = "Where_zvidkuTextBox"
        Me.Where_zvidkuTextBox.Size = New System.Drawing.Size(250, 26)
        Me.Where_zvidkuTextBox.TabIndex = 96
        '
        'Where_kyduTextBox
        '
        Me.Where_kyduTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РейсиBindingSource, "Where_kydu", True))
        Me.Where_kyduTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Where_kyduTextBox.Location = New System.Drawing.Point(202, 144)
        Me.Where_kyduTextBox.Name = "Where_kyduTextBox"
        Me.Where_kyduTextBox.Size = New System.Drawing.Size(250, 26)
        Me.Where_kyduTextBox.TabIndex = 97
        '
        'Cargo_codeComboBox
        '
        Me.Cargo_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РейсиBindingSource, "Cargo_code", True))
        Me.Cargo_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.РейсиBindingSource, "Cargo_code", True))
        Me.Cargo_codeComboBox.DataSource = Me.ВантажіBindingSource
        Me.Cargo_codeComboBox.DisplayMember = "Name"
        Me.Cargo_codeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Cargo_codeComboBox.FormattingEnabled = True
        Me.Cargo_codeComboBox.Location = New System.Drawing.Point(202, 247)
        Me.Cargo_codeComboBox.Name = "Cargo_codeComboBox"
        Me.Cargo_codeComboBox.Size = New System.Drawing.Size(250, 28)
        Me.Cargo_codeComboBox.TabIndex = 100
        Me.Cargo_codeComboBox.ValueMember = "Cargo_code"
        '
        'ВантажіBindingSource
        '
        Me.ВантажіBindingSource.DataMember = "Вантажі"
        Me.ВантажіBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РейсиBindingSource, "Price", True))
        Me.PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PriceTextBox.Location = New System.Drawing.Point(202, 284)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(250, 26)
        Me.PriceTextBox.TabIndex = 101
        '
        'Payment_markTextBox
        '
        Me.Payment_markTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РейсиBindingSource, "Payment_mark", True))
        Me.Payment_markTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Payment_markTextBox.Location = New System.Drawing.Point(202, 319)
        Me.Payment_markTextBox.Name = "Payment_markTextBox"
        Me.Payment_markTextBox.Size = New System.Drawing.Size(250, 26)
        Me.Payment_markTextBox.TabIndex = 102
        '
        'Return_markTextBox
        '
        Me.Return_markTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РейсиBindingSource, "Return_mark", True))
        Me.Return_markTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Return_markTextBox.Location = New System.Drawing.Point(202, 354)
        Me.Return_markTextBox.Name = "Return_markTextBox"
        Me.Return_markTextBox.Size = New System.Drawing.Size(250, 26)
        Me.Return_markTextBox.TabIndex = 103
        '
        'Employee_codeComboBox
        '
        Me.Employee_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РейсиBindingSource, "Employee_code", True))
        Me.Employee_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.РейсиBindingSource, "Employee_code", True))
        Me.Employee_codeComboBox.DataSource = Me.ПрацівникиBindingSource
        Me.Employee_codeComboBox.DisplayMember = "Name"
        Me.Employee_codeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Employee_codeComboBox.FormattingEnabled = True
        Me.Employee_codeComboBox.Location = New System.Drawing.Point(202, 387)
        Me.Employee_codeComboBox.Name = "Employee_codeComboBox"
        Me.Employee_codeComboBox.Size = New System.Drawing.Size(250, 28)
        Me.Employee_codeComboBox.TabIndex = 104
        Me.Employee_codeComboBox.ValueMember = "Employee_code"
        '
        'ПрацівникиBindingSource
        '
        Me.ПрацівникиBindingSource.DataMember = "Працівники"
        Me.ПрацівникиBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MaskedTextBox1.Location = New System.Drawing.Point(202, 179)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(250, 26)
        Me.MaskedTextBox1.TabIndex = 105
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MaskedTextBox2.Location = New System.Drawing.Point(202, 214)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(250, 26)
        Me.MaskedTextBox2.TabIndex = 106
        '
        'Рейси
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(598, 424)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Employee_codeLabel)
        Me.Controls.Add(Me.Employee_codeComboBox)
        Me.Controls.Add(Return_markLabel)
        Me.Controls.Add(Me.Return_markTextBox)
        Me.Controls.Add(Payment_markLabel)
        Me.Controls.Add(Me.Payment_markTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Cargo_codeLabel)
        Me.Controls.Add(Me.Cargo_codeComboBox)
        Me.Controls.Add(Date_of_arrivalLabel)
        Me.Controls.Add(Date_of_departureLabel)
        Me.Controls.Add(Where_kyduLabel)
        Me.Controls.Add(Me.Where_kyduTextBox)
        Me.Controls.Add(Where_zvidkuLabel)
        Me.Controls.Add(Me.Where_zvidkuTextBox)
        Me.Controls.Add(CustomerLabel)
        Me.Controls.Add(Me.CustomerTextBox)
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
        Me.Name = "Рейси"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Рейси"
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РейсиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ВантажіBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПрацівникиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents РейсиBindingSource As BindingSource
    Friend WithEvents РейсиTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.РейсиTableAdapter
    Friend WithEvents TableAdapterManager As Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerTextBox As TextBox
    Friend WithEvents Where_zvidkuTextBox As TextBox
    Friend WithEvents Where_kyduTextBox As TextBox
    Friend WithEvents Cargo_codeComboBox As ComboBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Payment_markTextBox As TextBox
    Friend WithEvents Return_markTextBox As TextBox
    Friend WithEvents Employee_codeComboBox As ComboBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents ПрацівникиTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.ПрацівникиTableAdapter
    Friend WithEvents ПрацівникиBindingSource As BindingSource
    Friend WithEvents ВантажіTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.ВантажіTableAdapter
    Friend WithEvents ВантажіBindingSource As BindingSource
End Class
