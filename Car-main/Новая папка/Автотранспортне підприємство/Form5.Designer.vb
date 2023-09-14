<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Автомобілі
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Brand_codeLabel As System.Windows.Forms.Label
        Dim Car_type__codeLabel As System.Windows.Forms.Label
        Dim Registration_numberLabel As System.Windows.Forms.Label
        Dim Body_numberLabel As System.Windows.Forms.Label
        Dim Engine_numberLabel As System.Windows.Forms.Label
        Dim Graduation_yearLabel As System.Windows.Forms.Label
        Dim Employee_driver_codeLabel As System.Windows.Forms.Label
        Dim Date_of_last_serviceLabel As System.Windows.Forms.Label
        Dim Mechanic_employee_codeLabel As System.Windows.Forms.Label
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
        Me.АвтомобіліBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.АвтомобіліTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.АвтомобіліTableAdapter()
        Me.TableAdapterManager = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager()
        Me.Brand_codeComboBox = New System.Windows.Forms.ComboBox()
        Me.МаркиАвтомобілівBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Car_type__codeComboBox = New System.Windows.Forms.ComboBox()
        Me.ВидиАвтомобілівBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registration_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Body_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Engine_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Employee_driver_codeComboBox = New System.Windows.Forms.ComboBox()
        Me.ПрацівникиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mechanic_employee_codeComboBox = New System.Windows.Forms.ComboBox()
        Me.Марки_автомобілівTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.Марки_автомобілівTableAdapter()
        Me.Види_автомобілівTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.Види_автомобілівTableAdapter()
        Me.ПрацівникиTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.ПрацівникиTableAdapter()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Brand_codeLabel = New System.Windows.Forms.Label()
        Car_type__codeLabel = New System.Windows.Forms.Label()
        Registration_numberLabel = New System.Windows.Forms.Label()
        Body_numberLabel = New System.Windows.Forms.Label()
        Engine_numberLabel = New System.Windows.Forms.Label()
        Graduation_yearLabel = New System.Windows.Forms.Label()
        Employee_driver_codeLabel = New System.Windows.Forms.Label()
        Date_of_last_serviceLabel = New System.Windows.Forms.Label()
        Mechanic_employee_codeLabel = New System.Windows.Forms.Label()
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АвтомобіліBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.МаркиАвтомобілівBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ВидиАвтомобілівBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПрацівникиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Brand_codeLabel
        '
        Brand_codeLabel.BackColor = System.Drawing.Color.Pink
        Brand_codeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Brand_codeLabel.Location = New System.Drawing.Point(12, 75)
        Brand_codeLabel.Name = "Brand_codeLabel"
        Brand_codeLabel.Size = New System.Drawing.Size(175, 25)
        Brand_codeLabel.TabIndex = 68
        Brand_codeLabel.Text = "Марка:"
        Brand_codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Car_type__codeLabel
        '
        Car_type__codeLabel.BackColor = System.Drawing.Color.Pink
        Car_type__codeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Car_type__codeLabel.Location = New System.Drawing.Point(12, 110)
        Car_type__codeLabel.Name = "Car_type__codeLabel"
        Car_type__codeLabel.Size = New System.Drawing.Size(175, 25)
        Car_type__codeLabel.TabIndex = 69
        Car_type__codeLabel.Text = "Вид авто:"
        Car_type__codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Registration_numberLabel
        '
        Registration_numberLabel.BackColor = System.Drawing.Color.Pink
        Registration_numberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Registration_numberLabel.Location = New System.Drawing.Point(12, 145)
        Registration_numberLabel.Name = "Registration_numberLabel"
        Registration_numberLabel.Size = New System.Drawing.Size(175, 50)
        Registration_numberLabel.TabIndex = 70
        Registration_numberLabel.Text = "Реєстраційний номер:"
        Registration_numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Body_numberLabel
        '
        Body_numberLabel.BackColor = System.Drawing.Color.Pink
        Body_numberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Body_numberLabel.Location = New System.Drawing.Point(12, 205)
        Body_numberLabel.Name = "Body_numberLabel"
        Body_numberLabel.Size = New System.Drawing.Size(175, 25)
        Body_numberLabel.TabIndex = 71
        Body_numberLabel.Text = "Номер кузова:"
        Body_numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Engine_numberLabel
        '
        Engine_numberLabel.BackColor = System.Drawing.Color.Pink
        Engine_numberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Engine_numberLabel.Location = New System.Drawing.Point(12, 240)
        Engine_numberLabel.Name = "Engine_numberLabel"
        Engine_numberLabel.Size = New System.Drawing.Size(175, 25)
        Engine_numberLabel.TabIndex = 72
        Engine_numberLabel.Text = "Номер двигуна:"
        Engine_numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Graduation_yearLabel
        '
        Graduation_yearLabel.BackColor = System.Drawing.Color.Pink
        Graduation_yearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Graduation_yearLabel.Location = New System.Drawing.Point(12, 275)
        Graduation_yearLabel.Name = "Graduation_yearLabel"
        Graduation_yearLabel.Size = New System.Drawing.Size(175, 25)
        Graduation_yearLabel.TabIndex = 73
        Graduation_yearLabel.Text = "Рік випуску:"
        Graduation_yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Employee_driver_codeLabel
        '
        Employee_driver_codeLabel.BackColor = System.Drawing.Color.Pink
        Employee_driver_codeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Employee_driver_codeLabel.Location = New System.Drawing.Point(12, 310)
        Employee_driver_codeLabel.Name = "Employee_driver_codeLabel"
        Employee_driver_codeLabel.Size = New System.Drawing.Size(175, 25)
        Employee_driver_codeLabel.TabIndex = 74
        Employee_driver_codeLabel.Text = "Водій:"
        Employee_driver_codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Date_of_last_serviceLabel
        '
        Date_of_last_serviceLabel.BackColor = System.Drawing.Color.Pink
        Date_of_last_serviceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Date_of_last_serviceLabel.Location = New System.Drawing.Point(12, 345)
        Date_of_last_serviceLabel.Name = "Date_of_last_serviceLabel"
        Date_of_last_serviceLabel.Size = New System.Drawing.Size(175, 50)
        Date_of_last_serviceLabel.TabIndex = 75
        Date_of_last_serviceLabel.Text = "Дата останнього ТО:"
        Date_of_last_serviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Mechanic_employee_codeLabel
        '
        Mechanic_employee_codeLabel.BackColor = System.Drawing.Color.Pink
        Mechanic_employee_codeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Mechanic_employee_codeLabel.Location = New System.Drawing.Point(12, 405)
        Mechanic_employee_codeLabel.Name = "Mechanic_employee_codeLabel"
        Mechanic_employee_codeLabel.Size = New System.Drawing.Size(175, 25)
        Mechanic_employee_codeLabel.TabIndex = 76
        Mechanic_employee_codeLabel.Text = "Механік:"
        Mechanic_employee_codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Pink
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 45)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Таблиця ""Автомобілі"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Pink
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(481, 43)
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
        Me.Button8.Location = New System.Drawing.Point(481, 1)
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
        Me.Button7.Location = New System.Drawing.Point(470, 377)
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
        Me.Button6.Location = New System.Drawing.Point(470, 335)
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
        Me.Button5.Location = New System.Drawing.Point(470, 293)
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
        Me.Button4.Location = New System.Drawing.Point(470, 251)
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
        Me.Button3.Location = New System.Drawing.Point(470, 209)
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
        Me.Button2.Location = New System.Drawing.Point(470, 167)
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
        Me.Button1.Location = New System.Drawing.Point(463, 125)
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
        'АвтомобіліBindingSource
        '
        Me.АвтомобіліBindingSource.DataMember = "Автомобілі"
        Me.АвтомобіліBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'АвтомобіліTableAdapter
        '
        Me.АвтомобіліTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.АвтомобіліTableAdapter = Me.АвтомобіліTableAdapter
        Me.TableAdapterManager.ВантажіTableAdapter = Nothing
        Me.TableAdapterManager.Види_автомобілівTableAdapter = Nothing
        Me.TableAdapterManager.Види_вантажівTableAdapter = Nothing
        Me.TableAdapterManager.Марки_автомобілівTableAdapter = Nothing
        Me.TableAdapterManager.ПосадиTableAdapter = Nothing
        Me.TableAdapterManager.ПрацівникиTableAdapter = Nothing
        Me.TableAdapterManager.РейсиTableAdapter = Nothing
        '
        'Brand_codeComboBox
        '
        Me.Brand_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АвтомобіліBindingSource, "Brand_code", True))
        Me.Brand_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.АвтомобіліBindingSource, "Brand_code", True))
        Me.Brand_codeComboBox.DataSource = Me.МаркиАвтомобілівBindingSource
        Me.Brand_codeComboBox.DisplayMember = "Name"
        Me.Brand_codeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Brand_codeComboBox.FormattingEnabled = True
        Me.Brand_codeComboBox.Location = New System.Drawing.Point(202, 72)
        Me.Brand_codeComboBox.Name = "Brand_codeComboBox"
        Me.Brand_codeComboBox.Size = New System.Drawing.Size(250, 28)
        Me.Brand_codeComboBox.TabIndex = 69
        Me.Brand_codeComboBox.ValueMember = "Brand_code"
        '
        'МаркиАвтомобілівBindingSource
        '
        Me.МаркиАвтомобілівBindingSource.DataMember = "Марки автомобілів"
        Me.МаркиАвтомобілівBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'Car_type__codeComboBox
        '
        Me.Car_type__codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АвтомобіліBindingSource, "Car_type__code", True))
        Me.Car_type__codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.АвтомобіліBindingSource, "Car_type__code", True))
        Me.Car_type__codeComboBox.DataSource = Me.ВидиАвтомобілівBindingSource
        Me.Car_type__codeComboBox.DisplayMember = "Name"
        Me.Car_type__codeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Car_type__codeComboBox.FormattingEnabled = True
        Me.Car_type__codeComboBox.Location = New System.Drawing.Point(202, 107)
        Me.Car_type__codeComboBox.Name = "Car_type__codeComboBox"
        Me.Car_type__codeComboBox.Size = New System.Drawing.Size(250, 28)
        Me.Car_type__codeComboBox.TabIndex = 70
        Me.Car_type__codeComboBox.ValueMember = "Car_view_code"
        '
        'ВидиАвтомобілівBindingSource
        '
        Me.ВидиАвтомобілівBindingSource.DataMember = "Види автомобілів"
        Me.ВидиАвтомобілівBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'Registration_numberTextBox
        '
        Me.Registration_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АвтомобіліBindingSource, "Registration_number", True))
        Me.Registration_numberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Registration_numberTextBox.Location = New System.Drawing.Point(202, 159)
        Me.Registration_numberTextBox.Name = "Registration_numberTextBox"
        Me.Registration_numberTextBox.Size = New System.Drawing.Size(250, 26)
        Me.Registration_numberTextBox.TabIndex = 71
        '
        'Body_numberTextBox
        '
        Me.Body_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АвтомобіліBindingSource, "Body_number", True))
        Me.Body_numberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Body_numberTextBox.Location = New System.Drawing.Point(202, 204)
        Me.Body_numberTextBox.Name = "Body_numberTextBox"
        Me.Body_numberTextBox.Size = New System.Drawing.Size(250, 26)
        Me.Body_numberTextBox.TabIndex = 72
        '
        'Engine_numberTextBox
        '
        Me.Engine_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АвтомобіліBindingSource, "Engine_number", True))
        Me.Engine_numberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Engine_numberTextBox.Location = New System.Drawing.Point(202, 239)
        Me.Engine_numberTextBox.Name = "Engine_numberTextBox"
        Me.Engine_numberTextBox.Size = New System.Drawing.Size(250, 26)
        Me.Engine_numberTextBox.TabIndex = 73
        '
        'Employee_driver_codeComboBox
        '
        Me.Employee_driver_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АвтомобіліBindingSource, "Employee_driver_code", True))
        Me.Employee_driver_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.АвтомобіліBindingSource, "Employee_driver_code", True))
        Me.Employee_driver_codeComboBox.DataSource = Me.ПрацівникиBindingSource
        Me.Employee_driver_codeComboBox.DisplayMember = "Name"
        Me.Employee_driver_codeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Employee_driver_codeComboBox.FormattingEnabled = True
        Me.Employee_driver_codeComboBox.Location = New System.Drawing.Point(202, 307)
        Me.Employee_driver_codeComboBox.Name = "Employee_driver_codeComboBox"
        Me.Employee_driver_codeComboBox.Size = New System.Drawing.Size(250, 28)
        Me.Employee_driver_codeComboBox.TabIndex = 75
        Me.Employee_driver_codeComboBox.ValueMember = "Employee_code"
        '
        'ПрацівникиBindingSource
        '
        Me.ПрацівникиBindingSource.DataMember = "Працівники"
        Me.ПрацівникиBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'Mechanic_employee_codeComboBox
        '
        Me.Mechanic_employee_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АвтомобіліBindingSource, "Mechanic_employee_code", True))
        Me.Mechanic_employee_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.АвтомобіліBindingSource, "Mechanic_employee_code", True))
        Me.Mechanic_employee_codeComboBox.DataSource = Me.ПрацівникиBindingSource
        Me.Mechanic_employee_codeComboBox.DisplayMember = "Name"
        Me.Mechanic_employee_codeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Mechanic_employee_codeComboBox.FormattingEnabled = True
        Me.Mechanic_employee_codeComboBox.Location = New System.Drawing.Point(202, 402)
        Me.Mechanic_employee_codeComboBox.Name = "Mechanic_employee_codeComboBox"
        Me.Mechanic_employee_codeComboBox.Size = New System.Drawing.Size(250, 28)
        Me.Mechanic_employee_codeComboBox.TabIndex = 77
        Me.Mechanic_employee_codeComboBox.ValueMember = "Employee_code"
        '
        'Марки_автомобілівTableAdapter
        '
        Me.Марки_автомобілівTableAdapter.ClearBeforeFill = True
        '
        'Види_автомобілівTableAdapter
        '
        Me.Види_автомобілівTableAdapter.ClearBeforeFill = True
        '
        'ПрацівникиTableAdapter
        '
        Me.ПрацівникиTableAdapter.ClearBeforeFill = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АвтомобіліBindingSource, "Graduation_year", True))
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MaskedTextBox1.Location = New System.Drawing.Point(202, 274)
        Me.MaskedTextBox1.Mask = "0000-00-00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(250, 26)
        Me.MaskedTextBox1.TabIndex = 78
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АвтомобіліBindingSource, "Date_of_last_service", True))
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MaskedTextBox2.Location = New System.Drawing.Point(202, 359)
        Me.MaskedTextBox2.Mask = "0000-00-00"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(250, 26)
        Me.MaskedTextBox2.TabIndex = 79
        '
        'Автомобілі
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(598, 440)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Mechanic_employee_codeLabel)
        Me.Controls.Add(Me.Mechanic_employee_codeComboBox)
        Me.Controls.Add(Date_of_last_serviceLabel)
        Me.Controls.Add(Employee_driver_codeLabel)
        Me.Controls.Add(Me.Employee_driver_codeComboBox)
        Me.Controls.Add(Graduation_yearLabel)
        Me.Controls.Add(Engine_numberLabel)
        Me.Controls.Add(Me.Engine_numberTextBox)
        Me.Controls.Add(Body_numberLabel)
        Me.Controls.Add(Me.Body_numberTextBox)
        Me.Controls.Add(Registration_numberLabel)
        Me.Controls.Add(Me.Registration_numberTextBox)
        Me.Controls.Add(Car_type__codeLabel)
        Me.Controls.Add(Me.Car_type__codeComboBox)
        Me.Controls.Add(Brand_codeLabel)
        Me.Controls.Add(Me.Brand_codeComboBox)
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
        Me.Name = "Автомобілі"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Автомобілі"
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АвтомобіліBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.МаркиАвтомобілівBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ВидиАвтомобілівBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents АвтомобіліBindingSource As BindingSource
    Friend WithEvents АвтомобіліTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.АвтомобіліTableAdapter
    Friend WithEvents TableAdapterManager As Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Brand_codeComboBox As ComboBox
    Friend WithEvents Car_type__codeComboBox As ComboBox
    Friend WithEvents Registration_numberTextBox As TextBox
    Friend WithEvents Body_numberTextBox As TextBox
    Friend WithEvents Engine_numberTextBox As TextBox
    Friend WithEvents Employee_driver_codeComboBox As ComboBox
    Friend WithEvents Mechanic_employee_codeComboBox As ComboBox
    Friend WithEvents МаркиАвтомобілівBindingSource As BindingSource
    Friend WithEvents Марки_автомобілівTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.Марки_автомобілівTableAdapter
    Friend WithEvents ВидиАвтомобілівBindingSource As BindingSource
    Friend WithEvents Види_автомобілівTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.Види_автомобілівTableAdapter
    Friend WithEvents ПрацівникиBindingSource As BindingSource
    Friend WithEvents ПрацівникиTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.ПрацівникиTableAdapter
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
End Class
