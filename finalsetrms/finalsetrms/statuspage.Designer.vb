<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class statuspage
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
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtComplaintID = New System.Windows.Forms.TextBox()
        Me.myLabel = New System.Windows.Forms.Label()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.btStatus = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLocation
        '
        Me.txtLocation.BackColor = System.Drawing.Color.PeachPuff
        Me.txtLocation.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtLocation.Location = New System.Drawing.Point(713, 266)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(314, 34)
        Me.txtLocation.TabIndex = 36
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.PeachPuff
        Me.txtContact.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtContact.Location = New System.Drawing.Point(713, 216)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(314, 34)
        Me.txtContact.TabIndex = 35
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.PeachPuff
        Me.txtName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtName.Location = New System.Drawing.Point(713, 167)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(314, 34)
        Me.txtName.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(430, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 27)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "LOCATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(430, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 27)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "CONTACT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(429, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 27)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "NAME"
        '
        'txtComplaintID
        '
        Me.txtComplaintID.BackColor = System.Drawing.Color.SandyBrown
        Me.txtComplaintID.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtComplaintID.Location = New System.Drawing.Point(797, 36)
        Me.txtComplaintID.Name = "txtComplaintID"
        Me.txtComplaintID.Size = New System.Drawing.Size(314, 34)
        Me.txtComplaintID.TabIndex = 38
        '
        'myLabel
        '
        Me.myLabel.AutoSize = True
        Me.myLabel.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.myLabel.Location = New System.Drawing.Point(419, 39)
        Me.myLabel.Name = "myLabel"
        Me.myLabel.Size = New System.Drawing.Size(242, 27)
        Me.myLabel.TabIndex = 37
        Me.myLabel.Text = "Enter the Complaint ID"
        '
        'btnRetrieve
        '
        Me.btnRetrieve.BackColor = System.Drawing.Color.PeachPuff
        Me.btnRetrieve.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRetrieve.Location = New System.Drawing.Point(1142, 159)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(217, 99)
        Me.btnRetrieve.TabIndex = 39
        Me.btnRetrieve.Text = "Retrieve Information "
        Me.btnRetrieve.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.PeachPuff
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDescription.Location = New System.Drawing.Point(713, 316)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(314, 34)
        Me.txtDescription.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(430, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 27)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Description"
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.PeachPuff
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtStatus.Location = New System.Drawing.Point(713, 372)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(314, 34)
        Me.txtStatus.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(430, 375)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 27)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.PeachPuff
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"PENDING", "ACCEPTED", "INPROGRESS", "REJECTED", "CLOSED"})
        Me.cmbStatus.Location = New System.Drawing.Point(383, 527)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(314, 35)
        Me.cmbStatus.TabIndex = 46
        '
        'btStatus
        '
        Me.btStatus.BackColor = System.Drawing.Color.PeachPuff
        Me.btStatus.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btStatus.Location = New System.Drawing.Point(907, 480)
        Me.btStatus.Name = "btStatus"
        Me.btStatus.Size = New System.Drawing.Size(217, 99)
        Me.btStatus.TabIndex = 47
        Me.btStatus.Text = "UPDATE STATUS"
        Me.btStatus.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SandyBrown
        Me.btnBack.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.Location = New System.Drawing.Point(1203, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(156, 53)
        Me.btnBack.TabIndex = 48
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.txtComplaintID)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.myLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 119)
        Me.Panel1.TabIndex = 49
        '
        'statuspage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(1371, 713)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btStatus)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "statuspage"
        Me.Text = "statuspage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtComplaintID As TextBox
    Friend WithEvents myLabel As Label
    Friend WithEvents btnRetrieve As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btStatus As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
End Class
