<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class complaintgadget
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
        Me.txtmodelname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmodelid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.btnBack.TabIndex = 50
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.PeachPuff
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.Location = New System.Drawing.Point(566, 578)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(217, 99)
        Me.btnSubmit.TabIndex = 49
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'cbComplainType
        '
        Me.cbComplainType.BackColor = System.Drawing.Color.PeachPuff
        Me.cbComplainType.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbComplainType.FormattingEnabled = True
        Me.cbComplainType.Items.AddRange(New Object() {"MOBILE", "LAPTOP ", "SMART WATCH", "BIKE", "CAR", "CAMERA", "OTHER ACCESSORIES"})
        Me.cbComplainType.Location = New System.Drawing.Point(783, 323)
        Me.cbComplainType.Name = "cbComplainType"
        Me.cbComplainType.Size = New System.Drawing.Size(314, 35)
        Me.cbComplainType.TabIndex = 48
        '
        'dtpIncidentDate
        '
        Me.dtpIncidentDate.CalendarFont = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpIncidentDate.CalendarMonthBackground = System.Drawing.Color.PeachPuff
        Me.dtpIncidentDate.CalendarTitleBackColor = System.Drawing.Color.PeachPuff
        Me.dtpIncidentDate.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dtpIncidentDate.Location = New System.Drawing.Point(783, 466)
        Me.dtpIncidentDate.Name = "dtpIncidentDate"
        Me.dtpIncidentDate.Size = New System.Drawing.Size(314, 34)
        Me.dtpIncidentDate.TabIndex = 47
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.PeachPuff
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDescription.Location = New System.Drawing.Point(783, 517)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(314, 34)
        Me.txtDescription.TabIndex = 46
        '
        'txtLocation
        '
        Me.txtLocation.BackColor = System.Drawing.Color.PeachPuff
        Me.txtLocation.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtLocation.Location = New System.Drawing.Point(783, 277)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(314, 34)
        Me.txtLocation.TabIndex = 45
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.PeachPuff
        Me.txtContact.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtContact.Location = New System.Drawing.Point(783, 228)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(314, 34)
        Me.txtContact.TabIndex = 44
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.PeachPuff
        Me.txtAge.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAge.Location = New System.Drawing.Point(783, 181)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(314, 34)
        Me.txtAge.TabIndex = 43
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.PeachPuff
        Me.txtName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtName.Location = New System.Drawing.Point(783, 136)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(314, 34)
        Me.txtName.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(330, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 27)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "LOCATION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(330, 520)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 27)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "DESCRIPTION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(330, 473)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 27)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "DATE AND TIME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(330, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 27)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "COMPLAINT TYPE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(330, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 27)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "CONTACT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(330, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 27)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "AGE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(330, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 27)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(575, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 37)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Details of complaint"
        '
        'txtmodelname
        '
        Me.txtmodelname.BackColor = System.Drawing.Color.PeachPuff
        Me.txtmodelname.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtmodelname.Location = New System.Drawing.Point(783, 371)
        Me.txtmodelname.Name = "txtmodelname"
        Me.txtmodelname.Size = New System.Drawing.Size(314, 34)
        Me.txtmodelname.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(330, 374)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 27)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "MODEL NAME"
        '
        'txtmodelid
        '
        Me.txtmodelid.BackColor = System.Drawing.Color.PeachPuff
        Me.txtmodelid.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtmodelid.Location = New System.Drawing.Point(783, 418)
        Me.txtmodelid.Name = "txtmodelid"
        Me.txtmodelid.Size = New System.Drawing.Size(314, 34)
        Me.txtmodelid.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(330, 421)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 27)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "MODEL ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 119)
        Me.Panel1.TabIndex = 55
        '
        'complaintgadget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(1371, 713)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtmodelid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtmodelname)
        Me.Controls.Add(Me.Label9)
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
        Me.Name = "complaintgadget"
        Me.Text = "complaintgadget"
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
    Friend WithEvents txtmodelname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtmodelid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
End Class
