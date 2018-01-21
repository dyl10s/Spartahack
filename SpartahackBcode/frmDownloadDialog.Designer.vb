<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDownloadDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDownloadDialog))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnBack = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblAddContact = New System.Windows.Forms.Label()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.pnlDLButt = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDLButt.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'pnlTop
        '
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.btnBack)
        Me.pnlTop.Controls.Add(Me.lblAddContact)
        Me.pnlTop.Controls.Add(Me.btnExit)
        Me.pnlTop.Controls.Add(Me.lblFullName)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(427, 48)
        Me.pnlTop.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageActive = Nothing
        Me.btnBack.Location = New System.Drawing.Point(6, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(30, 31)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBack.TabIndex = 41
        Me.btnBack.TabStop = False
        Me.btnBack.Zoom = 10
        '
        'lblAddContact
        '
        Me.lblAddContact.AutoSize = True
        Me.lblAddContact.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddContact.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAddContact.Location = New System.Drawing.Point(162, 31)
        Me.lblAddContact.Name = "lblAddContact"
        Me.lblAddContact.Size = New System.Drawing.Size(77, 13)
        Me.lblAddContact.TabIndex = 1
        Me.lblAddContact.Text = "Add Contact"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(387, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 35)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 40
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(81, 6)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(253, 21)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "FIRSTNAME LASTNAME"
        '
        'pnlDLButt
        '
        Me.pnlDLButt.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlDLButt.Controls.Add(Me.BunifuFlatButton2)
        Me.pnlDLButt.Controls.Add(Me.BunifuFlatButton1)
        Me.pnlDLButt.Controls.Add(Me.btnSave)
        Me.pnlDLButt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlDLButt.Location = New System.Drawing.Point(0, 423)
        Me.pnlDLButt.Name = "pnlDLButt"
        Me.pnlDLButt.Size = New System.Drawing.Size(427, 76)
        Me.pnlDLButt.TabIndex = 3
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 7
        Me.BunifuFlatButton2.ButtonText = "Open"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 50.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(305, 19)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(103, 43)
        Me.BunifuFlatButton2.TabIndex = 41
        Me.BunifuFlatButton2.Text = "Open"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "Download All"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 40.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(126, 19)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(171, 43)
        Me.BunifuFlatButton1.TabIndex = 40
        Me.BunifuFlatButton1.Text = "Download All"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSave
        '
        Me.btnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.BorderRadius = 7
        Me.btnSave.ButtonText = "Save"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledColor = System.Drawing.Color.Gray
        Me.btnSave.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSave.Iconimage = CType(resources.GetObject("btnSave.Iconimage"), System.Drawing.Image)
        Me.btnSave.Iconimage_right = Nothing
        Me.btnSave.Iconimage_right_Selected = Nothing
        Me.btnSave.Iconimage_Selected = Nothing
        Me.btnSave.IconMarginLeft = 0
        Me.btnSave.IconMarginRight = 0
        Me.btnSave.IconRightVisible = True
        Me.btnSave.IconRightZoom = 0R
        Me.btnSave.IconVisible = True
        Me.btnSave.IconZoom = 50.0R
        Me.btnSave.IsTab = False
        Me.btnSave.Location = New System.Drawing.Point(15, 19)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Normalcolor = System.Drawing.Color.White
        Me.btnSave.OnHovercolor = System.Drawing.Color.Silver
        Me.btnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSave.selected = False
        Me.btnSave.Size = New System.Drawing.Size(103, 43)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSave.Textcolor = System.Drawing.Color.Black
        Me.btnSave.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 48)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(55, 30, 30, 30)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(427, 375)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'frmDownloadDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 499)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.pnlDLButt)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDownloadDialog"
        Me.Text = "frmDownloadDialog"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDLButt.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblAddContact As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents pnlDLButt As Panel
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuImageButton
End Class
