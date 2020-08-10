<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.Sky = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.linklblUrl = New System.Windows.Forms.LinkLabel()
        Me.linklblOasis = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        CType(Me.Sky, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sky
        '
        Me.Sky.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sky.Image = CType(resources.GetObject("Sky.Image"), System.Drawing.Image)
        Me.Sky.Location = New System.Drawing.Point(0, 0)
        Me.Sky.Name = "Sky"
        Me.Sky.Size = New System.Drawing.Size(670, 311)
        Me.Sky.TabIndex = 0
        Me.Sky.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 42)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Tw Cen MT Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 69)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(316, 41)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Helpful Websites/Resources:"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.AliceBlue
        Me.lblInfo.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(15, 139)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(648, 162)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = resources.GetString("lblInfo.Text")
        '
        'linklblUrl
        '
        Me.linklblUrl.AutoSize = True
        Me.linklblUrl.BackColor = System.Drawing.Color.AliceBlue
        Me.linklblUrl.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linklblUrl.Location = New System.Drawing.Point(250, 172)
        Me.linklblUrl.Name = "linklblUrl"
        Me.linklblUrl.Size = New System.Drawing.Size(205, 18)
        Me.linklblUrl.TabIndex = 4
        Me.linklblUrl.TabStop = True
        Me.linklblUrl.Text = "https://mindyourmind.ca/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'linklblOasis
        '
        Me.linklblOasis.AutoSize = True
        Me.linklblOasis.BackColor = System.Drawing.Color.AliceBlue
        Me.linklblOasis.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linklblOasis.Location = New System.Drawing.Point(250, 283)
        Me.linklblOasis.Name = "linklblOasis"
        Me.linklblOasis.Size = New System.Drawing.Size(348, 18)
        Me.linklblOasis.TabIndex = 5
        Me.linklblOasis.TabStop = True
        Me.linklblOasis.Text = "https://oasismindfulness.wixsite.com/mysite"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.AliceBlue
        Me.LinkLabel1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(250, 192)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(209, 18)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://kidshelpphone.ca/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.AliceBlue
        Me.LinkLabel2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(250, 210)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(180, 18)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "https://jack.org/Home"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.AliceBlue
        Me.LinkLabel3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(250, 228)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(405, 18)
        Me.LinkLabel3.TabIndex = 8
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "https://www.heretohelp.bc.ca/managing-depression" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.AliceBlue
        Me.LinkLabel4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(250, 247)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(323, 18)
        Me.LinkLabel4.TabIndex = 9
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "https://www.crisisservicescanada.ca/en/"
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 311)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.linklblOasis)
        Me.Controls.Add(Me.linklblUrl)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Sky)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Help"
        Me.Text = "Help"
        CType(Me.Sky, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sky As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents linklblUrl As LinkLabel
    Friend WithEvents linklblOasis As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
End Class
