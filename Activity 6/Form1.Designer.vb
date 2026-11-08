<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        TextBox3 = New TextBox()
        Label7 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        btnUploadImage = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(153, 59)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(247, 26)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(177, 114)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(223, 26)
        TextBox2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 20)
        Label1.TabIndex = 6
        Label1.Text = "Customer Information:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(61, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 7
        Label2.Text = "Customer ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(62, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 20)
        Label3.TabIndex = 8
        Label3.Text = "Customer Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(62, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 20)
        Label4.TabIndex = 9
        Label4.Text = "Gender:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(489, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 20)
        Label5.TabIndex = 10
        Label5.Text = "Year:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(61, 218)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 23)
        Button1.TabIndex = 12
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(153, 156)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(56, 24)
        RadioButton1.TabIndex = 13
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(215, 156)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(72, 24)
        RadioButton2.TabIndex = 14
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4"})
        ComboBox1.Location = New Point(536, 56)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 28)
        ComboBox1.TabIndex = 15
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"BSIT", "BSHM", "BSED", "Crimonology"})
        ComboBox2.Location = New Point(536, 114)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 28)
        ComboBox2.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(474, 117)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 17
        Label6.Text = "Course:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DarkTurquoise
        PictureBox1.Location = New Point(843, 16)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 148)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(883, 218)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(120, 23)
        TextBox3.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(821, 221)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 20)
        Label7.TabIndex = 20
        Label7.Text = "Search:"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(153, 217)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 23)
        Button2.TabIndex = 21
        Button2.Text = "Load Records"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(245, 217)
        Button3.Name = "Button3"
        Button3.Size = New Size(86, 23)
        Button3.TabIndex = 22
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(337, 217)
        Button4.Name = "Button4"
        Button4.Size = New Size(86, 23)
        Button4.TabIndex = 23
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(22, 247)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1167, 297)
        DataGridView1.TabIndex = 24
        ' 
        ' btnUploadImage
        ' 
        btnUploadImage.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnUploadImage.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUploadImage.Location = New Point(843, 170)
        btnUploadImage.Name = "btnUploadImage"
        btnUploadImage.Size = New Size(160, 33)
        btnUploadImage.TabIndex = 25
        btnUploadImage.Text = "Upload Image"
        btnUploadImage.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1201, 556)
        Controls.Add(btnUploadImage)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label7)
        Controls.Add(TextBox3)
        Controls.Add(PictureBox1)
        Controls.Add(Label6)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnUploadImage As Button

End Class
