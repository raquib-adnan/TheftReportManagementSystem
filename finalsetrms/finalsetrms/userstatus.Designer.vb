<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userstatus
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
        Me.btnGetStatus = New System.Windows.Forms.Button()
        Me.txtComplaintID = New System.Windows.Forms.TextBox()
        Me.myLabel = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
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
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnGetStatus
        '
        Me.btnGetStatus.BackColor = System.Drawing.Color.PeachPuff
        Me.btnGetStatus.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGetStatus.Location = New System.Drawing.Point(618, 190)
        Me.btnGetStatus.Name = "btnGetStatus"
        Me.btnGetStatus.Size = New System.Drawing.Size(217, 99)
        Me.btnGetStatus.TabIndex = 9
        Me.btnGetStatus.Text = "Check Status"
        Me.btnGetStatus.UseVisualStyleBackColor = False
        '
        'txtComplaintID
        '
        Me.txtComplaintID.BackColor = System.Drawing.Color.SandyBrown
        Me.txtComplaintID.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplaintID.Location = New System.Drawing.Point(758, 43)
        Me.txtComplaintID.Name = "txtComplaintID"
        Me.txtComplaintID.Size = New System.Drawing.Size(261, 34)
        Me.txtComplaintID.TabIndex = 7
        '
        'myLabel
        '
        Me.myLabel.AutoSize = True
        Me.myLabel.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myLabel.Location = New System.Drawing.Point(320, 46)
        Me.myLabel.Name = "myLabel"
        Me.myLabel.Size = New System.Drawing.Size(269, 27)
        Me.myLabel.TabIndex = 6
        Me.myLabel.Text = "Enter the Complaint ID :- "
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(230, 328)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 27)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "        "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.myLabel)
        Me.Panel1.Controls.Add(Me.txtComplaintID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 119)
        Me.Panel1.TabIndex = 12
        '
        'userstatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(1371, 713)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnGetStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userstatus"
        Me.Text = "userstatus"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnGetStatus As Button
    Friend WithEvents txtComplaintID As TextBox
    Friend WithEvents myLabel As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Panel1 As Panel
End Class
