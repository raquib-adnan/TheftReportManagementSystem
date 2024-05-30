<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class complaintregis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cbComplainType = New System.Windows.Forms.ComboBox()
        Me.dtpIncidentDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SandyBrown
        Me.btnBack.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(1203, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnBack.Size = New System.Drawing.Size(156, 53)
        Me.btnBack.TabIndex = 33
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.PeachPuff
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(602, 525)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(217, 99)
        Me.btnSubmit.TabIndex = 32
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'cbComplainType
        '
        Me.cbComplainType.BackColor = System.Drawing.Color.PeachPuff
        Me.cbComplainType.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbComplainType.FormattingEnabled = True
        Me.cbComplainType.Items.AddRange(New Object() {"JEWELRY", "WALLET", "PURSE", "BACKPACK OR BAGS", "KEYS", "OTHER ACCESSORIES"})
        Me.cbComplainType.Location = New System.Drawing.Point(832, 345)
        Me.cbComplainType.Name = "cbComplainType"
        Me.cbComplainType.Size = New System.Drawing.Size(249, 35)
        Me.cbComplainType.TabIndex = 31
        '
        'dtpIncidentDate
        '
        Me.dtpIncidentDate.CalendarMonthBackground = System.Drawing.Color.PeachPuff
        Me.dtpIncidentDate.CalendarTitleBackColor = System.Drawing.Color.PeachPuff
        Me.dtpIncidentDate.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dtpIncidentDate.Location = New System.Drawing.Point(832, 398)
        Me.dtpIncidentDate.Name = "dtpIncidentDate"
        Me.dtpIncidentDate.Size = New System.Drawing.Size(249, 34)
        Me.dtpIncidentDate.TabIndex = 30
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.PeachPuff
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDescription.Location = New System.Drawing.Point(832, 452)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(249, 34)
        Me.txtDescription.TabIndex = 29
        '
        'txtLocation
        '
        Me.txtLocation.BackColor = System.Drawing.Color.PeachPuff
        Me.txtLocation.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(832, 296)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(249, 34)
        Me.txtLocation.TabIndex = 28
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.PeachPuff
        Me.txtContact.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtContact.Location = New System.Drawing.Point(832, 240)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(249, 34)
        Me.txtContact.TabIndex = 27
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.PeachPuff
        Me.txtAge.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAge.Location = New System.Drawing.Point(832, 189)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(249, 34)
        Me.txtAge.TabIndex = 26
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.PeachPuff
        Me.txtName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtName.Location = New System.Drawing.Point(832, 142)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(249, 34)
        Me.txtName.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(367, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 27)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "LOCATION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(367, 459)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 27)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "DESCRIPTION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(367, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 27)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "DATE AND TIME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(367, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 27)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "COMPLAINT TYPE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(367, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 27)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CONTACT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(367, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 27)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "AGE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 27)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(575, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 37)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Details of complaint"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 119)
        Me.Panel1.TabIndex = 34
        '
        'complaintregis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(1371, 713)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cbComplainType)
        Me.Controls.Add(Me.dtpIncidentDate)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "complaintregis"
        Me.Text = "complaintregis"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cbComplainType As ComboBox
    Friend WithEvents dtpIncidentDate As DateTimePicker
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
