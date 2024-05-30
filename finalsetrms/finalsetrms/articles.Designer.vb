<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class articles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(articles))
        Me.picnews2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picnews1 = New System.Windows.Forms.PictureBox()
        Me.picnews3 = New System.Windows.Forms.PictureBox()
        CType(Me.picnews2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picnews1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picnews3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picnews2
        '
        Me.picnews2.Image = CType(resources.GetObject("picnews2.Image"), System.Drawing.Image)
        Me.picnews2.Location = New System.Drawing.Point(12, 316)
        Me.picnews2.Name = "picnews2"
        Me.picnews2.Size = New System.Drawing.Size(1347, 174)
        Me.picnews2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picnews2.TabIndex = 8
        Me.picnews2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(514, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "News Regarding Theft"
        '
        'picnews1
        '
        Me.picnews1.Image = CType(resources.GetObject("picnews1.Image"), System.Drawing.Image)
        Me.picnews1.Location = New System.Drawing.Point(12, 114)
        Me.picnews1.Name = "picnews1"
        Me.picnews1.Size = New System.Drawing.Size(1347, 174)
        Me.picnews1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picnews1.TabIndex = 6
        Me.picnews1.TabStop = False
        '
        'picnews3
        '
        Me.picnews3.Image = CType(resources.GetObject("picnews3.Image"), System.Drawing.Image)
        Me.picnews3.Location = New System.Drawing.Point(12, 516)
        Me.picnews3.Name = "picnews3"
        Me.picnews3.Size = New System.Drawing.Size(1347, 174)
        Me.picnews3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picnews3.TabIndex = 10
        Me.picnews3.TabStop = False
        '
        'articles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1371, 713)
        Me.Controls.Add(Me.picnews3)
        Me.Controls.Add(Me.picnews2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picnews1)
        Me.Name = "articles"
        Me.Text = "articles"
        CType(Me.picnews2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picnews1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picnews3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picnews2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picnews1 As PictureBox
    Friend WithEvents picnews3 As PictureBox
End Class
