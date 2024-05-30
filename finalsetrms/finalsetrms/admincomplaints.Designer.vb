<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admincomplaints
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLoadComplaintsPending = New System.Windows.Forms.Button()
        Me.btnLoadComplaintsAccepted = New System.Windows.Forms.Button()
        Me.btnLoadComplaintsInProgress = New System.Windows.Forms.Button()
        Me.btnLoadComplaintsRejected = New System.Windows.Forms.Button()
        Me.btnLoadComplaintsClosed = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvComplaints = New System.Windows.Forms.DataGridView()
        CType(Me.dgvComplaints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadComplaintsPending
        '
        Me.btnLoadComplaintsPending.BackColor = System.Drawing.Color.PeachPuff
        Me.btnLoadComplaintsPending.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoadComplaintsPending.Location = New System.Drawing.Point(74, 46)
        Me.btnLoadComplaintsPending.Name = "btnLoadComplaintsPending"
        Me.btnLoadComplaintsPending.Size = New System.Drawing.Size(217, 99)
        Me.btnLoadComplaintsPending.TabIndex = 0
        Me.btnLoadComplaintsPending.Text = "Pending"
        Me.btnLoadComplaintsPending.UseVisualStyleBackColor = False
        '
        'btnLoadComplaintsAccepted
        '
        Me.btnLoadComplaintsAccepted.BackColor = System.Drawing.Color.PeachPuff
        Me.btnLoadComplaintsAccepted.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoadComplaintsAccepted.Location = New System.Drawing.Point(340, 46)
        Me.btnLoadComplaintsAccepted.Name = "btnLoadComplaintsAccepted"
        Me.btnLoadComplaintsAccepted.Size = New System.Drawing.Size(217, 99)
        Me.btnLoadComplaintsAccepted.TabIndex = 1
        Me.btnLoadComplaintsAccepted.Text = "Accepted"
        Me.btnLoadComplaintsAccepted.UseVisualStyleBackColor = False
        '
        'btnLoadComplaintsInProgress
        '
        Me.btnLoadComplaintsInProgress.BackColor = System.Drawing.Color.PeachPuff
        Me.btnLoadComplaintsInProgress.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoadComplaintsInProgress.Location = New System.Drawing.Point(598, 46)
        Me.btnLoadComplaintsInProgress.Name = "btnLoadComplaintsInProgress"
        Me.btnLoadComplaintsInProgress.Size = New System.Drawing.Size(217, 99)
        Me.btnLoadComplaintsInProgress.TabIndex = 2
        Me.btnLoadComplaintsInProgress.Text = "Inprogress"
        Me.btnLoadComplaintsInProgress.UseVisualStyleBackColor = False
        '
        'btnLoadComplaintsRejected
        '
        Me.btnLoadComplaintsRejected.BackColor = System.Drawing.Color.PeachPuff
        Me.btnLoadComplaintsRejected.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoadComplaintsRejected.Location = New System.Drawing.Point(856, 46)
        Me.btnLoadComplaintsRejected.Name = "btnLoadComplaintsRejected"
        Me.btnLoadComplaintsRejected.Size = New System.Drawing.Size(217, 99)
        Me.btnLoadComplaintsRejected.TabIndex = 3
        Me.btnLoadComplaintsRejected.Text = "Rejected"
        Me.btnLoadComplaintsRejected.UseVisualStyleBackColor = False
        '
        'btnLoadComplaintsClosed
        '
        Me.btnLoadComplaintsClosed.BackColor = System.Drawing.Color.PeachPuff
        Me.btnLoadComplaintsClosed.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoadComplaintsClosed.Location = New System.Drawing.Point(1094, 46)
        Me.btnLoadComplaintsClosed.Name = "btnLoadComplaintsClosed"
        Me.btnLoadComplaintsClosed.Size = New System.Drawing.Size(217, 99)
        Me.btnLoadComplaintsClosed.TabIndex = 4
        Me.btnLoadComplaintsClosed.Text = "Closed"
        Me.btnLoadComplaintsClosed.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SandyBrown
        Me.btnBack.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.Location = New System.Drawing.Point(1245, 1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 39)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dgvComplaints
        '
        Me.dgvComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComplaints.Location = New System.Drawing.Point(12, 184)
        Me.dgvComplaints.Name = "dgvComplaints"
        Me.dgvComplaints.RowTemplate.Height = 24
        Me.dgvComplaints.Size = New System.Drawing.Size(1352, 506)
        Me.dgvComplaints.TabIndex = 8
        '
        'admincomplaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(1376, 717)
        Me.Controls.Add(Me.dgvComplaints)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLoadComplaintsClosed)
        Me.Controls.Add(Me.btnLoadComplaintsRejected)
        Me.Controls.Add(Me.btnLoadComplaintsInProgress)
        Me.Controls.Add(Me.btnLoadComplaintsAccepted)
        Me.Controls.Add(Me.btnLoadComplaintsPending)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admincomplaints"
        Me.Text = "admincomplaints"
        CType(Me.dgvComplaints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLoadComplaintsPending As Button
    Friend WithEvents btnLoadComplaintsAccepted As Button
    Friend WithEvents btnLoadComplaintsInProgress As Button
    Friend WithEvents btnLoadComplaintsRejected As Button
    Friend WithEvents btnLoadComplaintsClosed As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvComplaints As DataGridView
End Class
