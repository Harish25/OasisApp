<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodTracker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FoodTracker))
        Me.Sky = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.txtFeedback = New System.Windows.Forms.TextBox()
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.Sky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sky
        '
        Me.Sky.BackColor = System.Drawing.Color.Transparent
        Me.Sky.BackgroundImage = CType(resources.GetObject("Sky.BackgroundImage"), System.Drawing.Image)
        Me.Sky.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sky.Location = New System.Drawing.Point(0, 0)
        Me.Sky.Name = "Sky"
        Me.Sky.Size = New System.Drawing.Size(748, 406)
        Me.Sky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Sky.TabIndex = 0
        Me.Sky.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Tw Cen MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(142, 72)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(343, 74)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "My Food Tracker"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(21, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(86, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Tw Cen MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(22, 259)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(49, 28)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age: "
        '
        'lblCalories
        '
        Me.lblCalories.AutoSize = True
        Me.lblCalories.BackColor = System.Drawing.Color.Transparent
        Me.lblCalories.Font = New System.Drawing.Font("Tw Cen MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalories.Location = New System.Drawing.Point(286, 257)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(77, 28)
        Me.lblCalories.TabIndex = 4
        Me.lblCalories.Text = "Calories:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Tw Cen MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(17, 172)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(718, 56)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "Keep track of what you are eating and gain insight on your habits. When your body" &
    " is strong and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "healthy, your ability to respond to stress and avoid negative e" &
    "ffects such as anxiety increases. "
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(84, 255)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(180, 33)
        Me.txtAge.TabIndex = 6
        '
        'txtCalories
        '
        Me.txtCalories.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalories.Location = New System.Drawing.Point(381, 255)
        Me.txtCalories.Multiline = True
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(180, 33)
        Me.txtCalories.TabIndex = 7
        '
        'txtFeedback
        '
        Me.txtFeedback.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeedback.Location = New System.Drawing.Point(21, 351)
        Me.txtFeedback.Multiline = True
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.Size = New System.Drawing.Size(692, 35)
        Me.txtFeedback.TabIndex = 8
        '
        'lblFeedback
        '
        Me.lblFeedback.AutoSize = True
        Me.lblFeedback.BackColor = System.Drawing.Color.Transparent
        Me.lblFeedback.Font = New System.Drawing.Font("Tw Cen MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedback.Location = New System.Drawing.Point(25, 313)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(90, 28)
        Me.lblFeedback.TabIndex = 9
        Me.lblFeedback.Text = "Feedback: "
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(581, 257)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(132, 30)
        Me.btnEnter.TabIndex = 10
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 42)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FoodTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 406)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblFeedback)
        Me.Controls.Add(Me.txtFeedback)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Sky)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FoodTracker"
        Me.Text = "Food Tracker"
        CType(Me.Sky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sky As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblCalories As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtCalories As TextBox
    Friend WithEvents txtFeedback As TextBox
    Friend WithEvents lblFeedback As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnBack As Button
End Class
