<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class typecomplaints
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
        Me.btnbelong = New System.Windows.Forms.Button()
        Me.btngadget = New System.Windows.Forms.Button()
        Me.btnidentify = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnbelong
        '
        Me.btnbelong.BackColor = System.Drawing.Color.PeachPuff
        Me.btnbelong.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnbelong.Location = New System.Drawing.Point(199, 179)
        Me.btnbelong.Name = "btnbelong"
        Me.btnbelong.Size = New System.Drawing.Size(217, 99)
        Me.btnbelong.TabIndex = 0
        Me.btnbelong.Text = "PERSONAL BELONGINGS"
        Me.btnbelong.UseVisualStyleBackColor = False
        '
        'btngadget
        '
        Me.btngadget.BackColor = System.Drawing.Color.PeachPuff
        Me.btngadget.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btngadget.Location = New System.Drawing.Point(594, 179)
        Me.btngadget.Name = "btngadget"
        Me.btngadget.Size = New System.Drawing.Size(217, 99)
        Me.btngadget.TabIndex = 1
        Me.btngadget.Text = "SMART GADGETS"
        Me.btngadget.UseVisualStyleBackColor = False
        '
        'btnidentify
        '
        Me.btnidentify.BackColor = System.Drawing.Color.PeachPuff
        Me.btnidentify.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnidentify.Location = New System.Drawing.Point(960, 179)
        Me.btnidentify.Name = "btnidentify"
        Me.btnidentify.Size = New System.Drawing.Size(217, 99)
        Me.btnidentify.TabIndex = 2
        Me.btnidentify.Text = "IDENTIFICATION"
        Me.btnidentify.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SandyBrown
        Me.btnBack.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(1203, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnBack.Size = New System.Drawing.Size(156, 53)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(562, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 31)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "TYPES OF COMPLAINTS"
        '
        'typecomplaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(1371, 713)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnidentify)
        Me.Controls.Add(Me.btngadget)
        Me.Controls.Add(Me.btnbelong)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "typecomplaints"
        Me.Text = "typecomplaints"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnbelong As Button
    Friend WithEvents btngadget As Button
    Friend WithEvents btnidentify As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
