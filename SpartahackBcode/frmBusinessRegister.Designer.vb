<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusinessRegister
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusinessRegister))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnRegister = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblBCODE = New System.Windows.Forms.Label()
        Me.txtBCODE = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblRptPass = New System.Windows.Forms.Label()
        Me.txtRetryPass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnBack = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnRegister
        '
        Me.btnRegister.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRegister.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegister.BorderRadius = 7
        Me.btnRegister.ButtonText = "Register"
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.DisabledColor = System.Drawing.Color.Gray
        Me.btnRegister.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRegister.Iconimage = Nothing
        Me.btnRegister.Iconimage_right = Nothing
        Me.btnRegister.Iconimage_right_Selected = Nothing
        Me.btnRegister.Iconimage_Selected = Nothing
        Me.btnRegister.IconMarginLeft = 0
        Me.btnRegister.IconMarginRight = 0
        Me.btnRegister.IconRightVisible = True
        Me.btnRegister.IconRightZoom = 0R
        Me.btnRegister.IconVisible = True
        Me.btnRegister.IconZoom = 90.0R
        Me.btnRegister.IsTab = False
        Me.btnRegister.Location = New System.Drawing.Point(141, 396)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Normalcolor = System.Drawing.SystemColors.HotTrack
        Me.btnRegister.OnHovercolor = System.Drawing.SystemColors.Highlight
        Me.btnRegister.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRegister.selected = False
        Me.btnRegister.Size = New System.Drawing.Size(241, 48)
        Me.btnRegister.TabIndex = 38
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegister.Textcolor = System.Drawing.Color.White
        Me.btnRegister.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblBCODE
        '
        Me.lblBCODE.AutoSize = True
        Me.lblBCODE.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCODE.ForeColor = System.Drawing.Color.Gray
        Me.lblBCODE.Location = New System.Drawing.Point(183, 275)
        Me.lblBCODE.Name = "lblBCODE"
        Me.lblBCODE.Size = New System.Drawing.Size(129, 19)
        Me.lblBCODE.TabIndex = 37
        Me.lblBCODE.Text = "Business Name"
        '
        'txtBCODE
        '
        Me.txtBCODE.BorderColorFocused = System.Drawing.SystemColors.HotTrack
        Me.txtBCODE.BorderColorIdle = System.Drawing.SystemColors.HotTrack
        Me.txtBCODE.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack
        Me.txtBCODE.BorderThickness = 3
        Me.txtBCODE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBCODE.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBCODE.ForeColor = System.Drawing.Color.Black
        Me.txtBCODE.isPassword = False
        Me.txtBCODE.Location = New System.Drawing.Point(82, 299)
        Me.txtBCODE.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtBCODE.Name = "txtBCODE"
        Me.txtBCODE.Size = New System.Drawing.Size(342, 75)
        Me.txtBCODE.TabIndex = 36
        Me.txtBCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.Gray
        Me.lblLastName.Location = New System.Drawing.Point(352, 201)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(92, 19)
        Me.lblLastName.TabIndex = 35
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.BorderColorFocused = System.Drawing.SystemColors.HotTrack
        Me.txtLastName.BorderColorIdle = System.Drawing.SystemColors.HotTrack
        Me.txtLastName.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack
        Me.txtLastName.BorderThickness = 3
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.isPassword = False
        Me.txtLastName.Location = New System.Drawing.Point(274, 221)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(235, 30)
        Me.txtLastName.TabIndex = 34
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.Gray
        Me.lblFirstName.Location = New System.Drawing.Point(93, 201)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(99, 19)
        Me.lblFirstName.TabIndex = 33
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderColorFocused = System.Drawing.SystemColors.HotTrack
        Me.txtFirstName.BorderColorIdle = System.Drawing.SystemColors.HotTrack
        Me.txtFirstName.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack
        Me.txtFirstName.BorderThickness = 3
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtFirstName.isPassword = False
        Me.txtFirstName.Location = New System.Drawing.Point(25, 221)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(235, 30)
        Me.txtFirstName.TabIndex = 32
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblRptPass
        '
        Me.lblRptPass.AutoSize = True
        Me.lblRptPass.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRptPass.ForeColor = System.Drawing.Color.Gray
        Me.lblRptPass.Location = New System.Drawing.Point(323, 136)
        Me.lblRptPass.Name = "lblRptPass"
        Me.lblRptPass.Size = New System.Drawing.Size(149, 19)
        Me.lblRptPass.TabIndex = 31
        Me.lblRptPass.Text = "Repeat Password"
        '
        'txtRetryPass
        '
        Me.txtRetryPass.BorderColorFocused = System.Drawing.SystemColors.HotTrack
        Me.txtRetryPass.BorderColorIdle = System.Drawing.SystemColors.HotTrack
        Me.txtRetryPass.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack
        Me.txtRetryPass.BorderThickness = 3
        Me.txtRetryPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRetryPass.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetryPass.ForeColor = System.Drawing.Color.Black
        Me.txtRetryPass.isPassword = True
        Me.txtRetryPass.Location = New System.Drawing.Point(274, 156)
        Me.txtRetryPass.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtRetryPass.Name = "txtRetryPass"
        Me.txtRetryPass.Size = New System.Drawing.Size(235, 30)
        Me.txtRetryPass.TabIndex = 30
        Me.txtRetryPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Gray
        Me.lblPassword.Location = New System.Drawing.Point(97, 136)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(90, 19)
        Me.lblPassword.TabIndex = 29
        Me.lblPassword.Text = "Password"
        '
        'txtPass
        '
        Me.txtPass.BorderColorFocused = System.Drawing.SystemColors.HotTrack
        Me.txtPass.BorderColorIdle = System.Drawing.SystemColors.HotTrack
        Me.txtPass.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack
        Me.txtPass.BorderThickness = 3
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.isPassword = True
        Me.txtPass.Location = New System.Drawing.Point(25, 156)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(235, 30)
        Me.txtPass.TabIndex = 28
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Gray
        Me.lblEmail.Location = New System.Drawing.Point(221, 78)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 19)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.BorderColorFocused = System.Drawing.SystemColors.HotTrack
        Me.txtEmail.BorderColorIdle = System.Drawing.SystemColors.HotTrack
        Me.txtEmail.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack
        Me.txtEmail.BorderThickness = 3
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.isPassword = False
        Me.txtEmail.Location = New System.Drawing.Point(141, 101)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(235, 30)
        Me.txtEmail.TabIndex = 26
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.ImageActive = Nothing
        Me.btnMin.Location = New System.Drawing.Point(451, 3)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(30, 30)
        Me.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMin.TabIndex = 40
        Me.btnMin.TabStop = False
        Me.btnMin.Zoom = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(490, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 35)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 39
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageActive = Nothing
        Me.btnBack.Location = New System.Drawing.Point(6, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(30, 31)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBack.TabIndex = 25
        Me.btnBack.TabStop = False
        Me.btnBack.Zoom = 10
        '
        'frmBusinessRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(528, 462)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblBCODE)
        Me.Controls.Add(Me.txtBCODE)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblRptPass)
        Me.Controls.Add(Me.txtRetryPass)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBusinessRegister"
        Me.Text = "frmBusinessRegister"
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnMin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnRegister As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblBCODE As Label
    Friend WithEvents txtBCODE As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblRptPass As Label
    Friend WithEvents txtRetryPass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuImageButton
End Class
