<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Journal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Journal))
        Me.txtDiary = New System.Windows.Forms.TextBox()
        Me.lblExplain = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Sky = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sky, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDiary
        '
        Me.txtDiary.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiary.Location = New System.Drawing.Point(203, 186)
        Me.txtDiary.Multiline = True
        Me.txtDiary.Name = "txtDiary"
        Me.txtDiary.Size = New System.Drawing.Size(757, 371)
        Me.txtDiary.TabIndex = 1
        '
        'lblExplain
        '
        Me.lblExplain.AutoSize = True
        Me.lblExplain.BackColor = System.Drawing.Color.Transparent
        Me.lblExplain.Font = New System.Drawing.Font("Tw Cen MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplain.Location = New System.Drawing.Point(206, 108)
        Me.lblExplain.Name = "lblExplain"
        Me.lblExplain.Size = New System.Drawing.Size(732, 68)
        Me.lblExplain.TabIndex = 2
        Me.lblExplain.Text = "Organize your thoughts, improve your mood and manage your stress by keeping " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tra" &
    "ck of how you feel! "
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Tw Cen MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(325, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(202, 74)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "My Diary"
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.Font = New System.Drawing.Font("Tw Cen MT Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(31, 281)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(139, 64)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox.BackgroundImage = CType(resources.GetObject("PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(203, 7)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(95, 82)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 4
        Me.PictureBox.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.Font = New System.Drawing.Font("Tw Cen MT Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 10)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 42)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Sky
        '
        Me.Sky.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sky.Image = CType(resources.GetObject("Sky.Image"), System.Drawing.Image)
        Me.Sky.Location = New System.Drawing.Point(0, 0)
        Me.Sky.Name = "Sky"
        Me.Sky.Size = New System.Drawing.Size(1013, 572)
        Me.Sky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Sky.TabIndex = 0
        Me.Sky.TabStop = False
        '
        'Journal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 572)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblExplain)
        Me.Controls.Add(Me.txtDiary)
        Me.Controls.Add(Me.Sky)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Journal"
        Me.Text = "Diary"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sky, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sky As PictureBox
    Friend WithEvents txtDiary As TextBox
    Friend WithEvents lblExplain As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSave As Button
End Class
