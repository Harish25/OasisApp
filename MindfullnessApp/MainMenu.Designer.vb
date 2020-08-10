<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.btnJournal = New System.Windows.Forms.Button()
        Me.btnEating = New System.Windows.Forms.Button()
        Me.btnMeditation = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.lblQuote = New System.Windows.Forms.Label()
        Me.Sky = New System.Windows.Forms.PictureBox()
        CType(Me.Sky, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnJournal
        '
        Me.btnJournal.BackColor = System.Drawing.Color.Tan
        Me.btnJournal.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.btnJournal.FlatAppearance.BorderSize = 0
        Me.btnJournal.Font = New System.Drawing.Font("Tw Cen MT Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJournal.Location = New System.Drawing.Point(470, 368)
        Me.btnJournal.Name = "btnJournal"
        Me.btnJournal.Size = New System.Drawing.Size(105, 35)
        Me.btnJournal.TabIndex = 1
        Me.btnJournal.Text = "Journal"
        Me.btnJournal.UseVisualStyleBackColor = False
        '
        'btnEating
        '
        Me.btnEating.BackColor = System.Drawing.Color.LightGreen
        Me.btnEating.FlatAppearance.BorderSize = 0
        Me.btnEating.Font = New System.Drawing.Font("Tw Cen MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEating.Location = New System.Drawing.Point(576, 511)
        Me.btnEating.Name = "btnEating"
        Me.btnEating.Size = New System.Drawing.Size(133, 52)
        Me.btnEating.TabIndex = 2
        Me.btnEating.Text = "Healthy Eating"
        Me.btnEating.UseVisualStyleBackColor = False
        '
        'btnMeditation
        '
        Me.btnMeditation.BackColor = System.Drawing.Color.Gold
        Me.btnMeditation.FlatAppearance.BorderSize = 0
        Me.btnMeditation.Font = New System.Drawing.Font("Tw Cen MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMeditation.Location = New System.Drawing.Point(15, 34)
        Me.btnMeditation.Name = "btnMeditation"
        Me.btnMeditation.Size = New System.Drawing.Size(105, 35)
        Me.btnMeditation.TabIndex = 3
        Me.btnMeditation.Text = "Meditation"
        Me.btnMeditation.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnHelp.Font = New System.Drawing.Font("Tw Cen MT Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(12, 529)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(105, 35)
        Me.btnHelp.TabIndex = 4
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 306)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(106, 39)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Hello, "
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.BackColor = System.Drawing.Color.Transparent
        Me.lblIntro.Font = New System.Drawing.Font("Tw Cen MT Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.Location = New System.Drawing.Point(50, 379)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(280, 44)
        Me.lblIntro.TabIndex = 6
        Me.lblIntro.Text = "Welcome to your oasis!"
        '
        'lblQuote
        '
        Me.lblQuote.AutoSize = True
        Me.lblQuote.BackColor = System.Drawing.Color.Transparent
        Me.lblQuote.Font = New System.Drawing.Font("Tw Cen MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuote.ForeColor = System.Drawing.Color.White
        Me.lblQuote.Location = New System.Drawing.Point(753, 50)
        Me.lblQuote.Name = "lblQuote"
        Me.lblQuote.Size = New System.Drawing.Size(50, 28)
        Me.lblQuote.TabIndex = 7
        Me.lblQuote.Text = "testy"
        '
        'Sky
        '
        Me.Sky.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sky.Image = Global.MindfullnessApp.My.Resources.Resource1.MindfullnessTree
        Me.Sky.InitialImage = CType(resources.GetObject("Sky.InitialImage"), System.Drawing.Image)
        Me.Sky.Location = New System.Drawing.Point(0, 0)
        Me.Sky.Name = "Sky"
        Me.Sky.Size = New System.Drawing.Size(1024, 576)
        Me.Sky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Sky.TabIndex = 0
        Me.Sky.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.lblQuote)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnMeditation)
        Me.Controls.Add(Me.btnEating)
        Me.Controls.Add(Me.btnJournal)
        Me.Controls.Add(Me.Sky)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.Text = "Oasis"
        CType(Me.Sky, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sky As PictureBox
    Friend WithEvents btnJournal As Button
    Friend WithEvents btnEating As Button
    Friend WithEvents btnMeditation As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblIntro As Label
    Friend WithEvents lblQuote As Label
End Class
