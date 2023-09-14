<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Марки_автомобілів
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
        Dim NameLabel1 As System.Windows.Forms.Label
        Dim SpecificationsLabel As System.Windows.Forms.Label
        Dim DescriptionLabel1 As System.Windows.Forms.Label
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
        Me.Марки_автомобілівBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Марки_автомобілівTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.Марки_автомобілівTableAdapter()
        Me.TableAdapterManager = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.SpecificationsTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox1 = New System.Windows.Forms.TextBox()
        NameLabel1 = New System.Windows.Forms.Label()
        SpecificationsLabel = New System.Windows.Forms.Label()
        DescriptionLabel1 = New System.Windows.Forms.Label()
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Марки_автомобілівBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel1
        '
        NameLabel1.BackColor = System.Drawing.Color.Pink
        NameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        NameLabel1.Location = New System.Drawing.Point(14, 167)
        NameLabel1.Name = "NameLabel1"
        NameLabel1.Size = New System.Drawing.Size(190, 25)
        NameLabel1.TabIndex = 110
        NameLabel1.Text = "Назва:"
        NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpecificationsLabel
        '
        SpecificationsLabel.BackColor = System.Drawing.Color.Pink
        SpecificationsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        SpecificationsLabel.Location = New System.Drawing.Point(14, 232)
        SpecificationsLabel.Name = "SpecificationsLabel"
        SpecificationsLabel.Size = New System.Drawing.Size(190, 52)
        SpecificationsLabel.TabIndex = 111
        SpecificationsLabel.Text = "Технічні характеристики:"
        SpecificationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DescriptionLabel1
        '
        DescriptionLabel1.BackColor = System.Drawing.Color.Pink
        DescriptionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        DescriptionLabel1.Location = New System.Drawing.Point(14, 324)
        DescriptionLabel1.Name = "DescriptionLabel1"
        DescriptionLabel1.Size = New System.Drawing.Size(190, 25)
        DescriptionLabel1.TabIndex = 112
        DescriptionLabel1.Text = "Опис:"
        DescriptionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Pink
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 103)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Таблиця ""Марки_автомобілів"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Pink
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(481, 43)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 36)
        Me.Button9.TabIndex = 100
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
        Me.Button8.TabIndex = 99
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
        Me.Button7.TabIndex = 98
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
        Me.Button6.TabIndex = 97
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
        Me.Button5.TabIndex = 96
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
        Me.Button4.TabIndex = 95
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
        Me.Button3.TabIndex = 94
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
        Me.Button2.TabIndex = 93
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
        Me.Button1.TabIndex = 92
        Me.Button1.Text = "Попередня"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Автотранспортне_підприємствоDataSet
        '
        Me.Автотранспортне_підприємствоDataSet.DataSetName = "Автотранспортне_підприємствоDataSet"
        Me.Автотранспортне_підприємствоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Марки_автомобілівBindingSource
        '
        Me.Марки_автомобілівBindingSource.DataMember = "Марки автомобілів"
        Me.Марки_автомобілівBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'Марки_автомобілівTableAdapter
        '
        Me.Марки_автомобілівTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.АвтомобіліTableAdapter = Nothing
        Me.TableAdapterManager.ВантажіTableAdapter = Nothing
        Me.TableAdapterManager.Види_автомобілівTableAdapter = Nothing
        Me.TableAdapterManager.Види_вантажівTableAdapter = Nothing
        Me.TableAdapterManager.Марки_автомобілівTableAdapter = Me.Марки_автомобілівTableAdapter
        Me.TableAdapterManager.ПосадиTableAdapter = Nothing
        Me.TableAdapterManager.ПрацівникиTableAdapter = Nothing
        Me.TableAdapterManager.РейсиTableAdapter = Nothing
        '
        'NameTextBox1
        '
        Me.NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Марки_автомобілівBindingSource, "Name", True))
        Me.NameTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NameTextBox1.Location = New System.Drawing.Point(210, 166)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(243, 26)
        Me.NameTextBox1.TabIndex = 111
        '
        'SpecificationsTextBox
        '
        Me.SpecificationsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Марки_автомобілівBindingSource, "Specifications", True))
        Me.SpecificationsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SpecificationsTextBox.Location = New System.Drawing.Point(210, 247)
        Me.SpecificationsTextBox.Name = "SpecificationsTextBox"
        Me.SpecificationsTextBox.Size = New System.Drawing.Size(243, 26)
        Me.SpecificationsTextBox.TabIndex = 112
        '
        'DescriptionTextBox1
        '
        Me.DescriptionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Марки_автомобілівBindingSource, "Description", True))
        Me.DescriptionTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DescriptionTextBox1.Location = New System.Drawing.Point(210, 325)
        Me.DescriptionTextBox1.Name = "DescriptionTextBox1"
        Me.DescriptionTextBox1.Size = New System.Drawing.Size(243, 26)
        Me.DescriptionTextBox1.TabIndex = 113
        '
        'Марки_автомобілів
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(599, 422)
        Me.Controls.Add(DescriptionLabel1)
        Me.Controls.Add(Me.DescriptionTextBox1)
        Me.Controls.Add(SpecificationsLabel)
        Me.Controls.Add(Me.SpecificationsTextBox)
        Me.Controls.Add(NameLabel1)
        Me.Controls.Add(Me.NameTextBox1)
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
        Me.Name = "Марки_автомобілів"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Марки автомобілів"
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Марки_автомобілівBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Марки_автомобілівBindingSource As BindingSource
    Friend WithEvents Марки_автомобілівTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.Марки_автомобілівTableAdapter
    Friend WithEvents TableAdapterManager As Автотранспортне_підприємствоDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox1 As TextBox
    Friend WithEvents SpecificationsTextBox As TextBox
    Friend WithEvents DescriptionTextBox1 As TextBox
End Class
