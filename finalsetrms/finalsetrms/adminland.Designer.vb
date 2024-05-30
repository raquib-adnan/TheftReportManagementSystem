<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminland
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
        Me.btnadcompl = New System.Windows.Forms.Button()
        Me.btnupStatus = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnadcompl
        '
        Me.btnadcompl.BackColor = System.Drawing.Color.PeachPuff
        Me.btnadcompl.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnadcompl.Location = New System.Drawing.Point(45, 145)
        Me.btnadcompl.Name = "btnadcompl"
        Me.btnadcompl.Size = New System.Drawing.Size(217, 99)
        Me.btnadcompl.TabIndex = 0
        Me.btnadcompl.Text = "view complaints"
        Me.btnadcompl.UseVisualStyleBackColor = False
        '
        'btnupStatus
        '
        Me.btnupStatus.BackColor = System.Drawing.Color.PeachPuff
        Me.btnupStatus.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnupStatus.Location = New System.Drawing.Point(45, 274)
        Me.btnupStatus.Name = "btnupStatus"
        Me.btnupStatus.Size = New System.Drawing.Size(217, 99)
        Me.btnupStatus.TabIndex = 1
        Me.btnupStatus.Text = "update status"
        Me.btnupStatus.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PeachPuff
        Me.btnBack.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.Location = New System.Drawing.Point(45, 401)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(217, 99)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "logout"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 119)
        Me.Panel1.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(575, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(318, 37)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "ADMIN DASHBOARD"
        '
        'adminland
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(1371, 713)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnupStatus)
        Me.Controls.Add(Me.btnadcompl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminland"
        Me.Text = "adminland"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnadcompl As Button
    Friend WithEvents btnupStatus As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
End Class
