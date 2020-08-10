<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Meditation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Meditation))
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtTutorial = New System.Windows.Forms.TextBox()
        Me.lblMeditation = New System.Windows.Forms.Label()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBody = New System.Windows.Forms.Button()
        Me.btnMantra = New System.Windows.Forms.Button()
        Me.btnFocus = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Sky = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sky, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Tw Cen MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(26, 143)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(970, 84)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTutorial
        '
        Me.txtTutorial.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtTutorial.Font = New System.Drawing.Font("Tw Cen MT Condensed", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTutorial.Location = New System.Drawing.Point(37, 418)
        Me.txtTutorial.Multiline = True
        Me.txtTutorial.Name = "txtTutorial"
        Me.txtTutorial.Size = New System.Drawing.Size(927, 88)
        Me.txtTutorial.TabIndex = 6
        Me.txtTutorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMeditation
        '
        Me.lblMeditation.AutoSize = True
        Me.lblMeditation.BackColor = System.Drawing.Color.Transparent
        Me.lblMeditation.Font = New System.Drawing.Font("Tw Cen MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeditation.Location = New System.Drawing.Point(307, 28)
        Me.lblMeditation.Name = "lblMeditation"
        Me.lblMeditation.Size = New System.Drawing.Size(302, 74)
        Me.lblMeditation.TabIndex = 7
        Me.lblMeditation.Text = "My Meditation"
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.BackColor = System.Drawing.Color.Transparent
        Me.lblInstruction.Font = New System.Drawing.Font("Tw Cen MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.Location = New System.Drawing.Point(39, 375)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(105, 28)
        Me.lblInstruction.TabIndex = 9
        Me.lblInstruction.Text = "Instructions:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(172, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnBody
        '
        Me.btnBody.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBody.Image = CType(resources.GetObject("btnBody.Image"), System.Drawing.Image)
        Me.btnBody.Location = New System.Drawing.Point(807, 244)
        Me.btnBody.Name = "btnBody"
        Me.btnBody.Size = New System.Drawing.Size(200, 79)
        Me.btnBody.TabIndex = 5
        Me.btnBody.Text = "Body Scan"
        Me.btnBody.UseVisualStyleBackColor = True
        '
        'btnMantra
        '
        Me.btnMantra.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantra.Image = CType(resources.GetObject("btnMantra.Image"), System.Drawing.Image)
        Me.btnMantra.Location = New System.Drawing.Point(414, 244)
        Me.btnMantra.Name = "btnMantra"
        Me.btnMantra.Size = New System.Drawing.Size(200, 79)
        Me.btnMantra.TabIndex = 4
        Me.btnMantra.Text = "Mantra Meditation"
        Me.btnMantra.UseVisualStyleBackColor = True
        '
        'btnFocus
        '
        Me.btnFocus.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFocus.Image = CType(resources.GetObject("btnFocus.Image"), System.Drawing.Image)
        Me.btnFocus.Location = New System.Drawing.Point(17, 244)
        Me.btnFocus.Name = "btnFocus"
        Me.btnFocus.Size = New System.Drawing.Size(200, 79)
        Me.btnFocus.TabIndex = 3
        Me.btnFocus.Text = "Focused Meditation"
        Me.btnFocus.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.Font = New System.Drawing.Font("Tw Cen MT Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 10)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 42)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Sky
        '
        Me.Sky.BackgroundImage = CType(resources.GetObject("Sky.BackgroundImage"), System.Drawing.Image)
        Me.Sky.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sky.Location = New System.Drawing.Point(0, 0)
        Me.Sky.Name = "Sky"
        Me.Sky.Size = New System.Drawing.Size(1018, 540)
        Me.Sky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Sky.TabIndex = 0
        Me.Sky.TabStop = False
        '
        'Meditation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 540)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblMeditation)
        Me.Controls.Add(Me.txtTutorial)
        Me.Controls.Add(Me.btnBody)
        Me.Controls.Add(Me.btnMantra)
        Me.Controls.Add(Me.btnFocus)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Sky)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Meditation"
        Me.Text = "Meditation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sky, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sky As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnFocus As Button
    Friend WithEvents btnMantra As Button
    Friend WithEvents btnBody As Button
    Friend WithEvents txtTutorial As TextBox
    Friend WithEvents lblMeditation As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblInstruction As Label
End Class
