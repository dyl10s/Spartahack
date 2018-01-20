<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pFile = New System.Windows.Forms.Panel()
        Me.lblType = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pLink = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmitLink = New System.Windows.Forms.Button()
        Me.txtInfoLink = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnDeleteLink = New System.Windows.Forms.Button()
        Me.btnLink = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pFile.SuspendLayout()
        Me.pLink.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSignOut
        '
        Me.btnSignOut.Location = New System.Drawing.Point(12, 21)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(75, 23)
        Me.btnSignOut.TabIndex = 0
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(93, 21)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(114, 23)
        Me.btnFile.TabIndex = 1
        Me.btnFile.Text = "Add File"
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 68)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(893, 280)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLink)
        Me.Panel1.Controls.Add(Me.btnFile)
        Me.Panel1.Controls.Add(Me.btnSignOut)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(893, 68)
        Me.Panel1.TabIndex = 3
        '
        'pFile
        '
        Me.pFile.Controls.Add(Me.btnDelete)
        Me.pFile.Controls.Add(Me.btnBrowse)
        Me.pFile.Controls.Add(Me.lblType)
        Me.pFile.Controls.Add(Me.btnSave)
        Me.pFile.Controls.Add(Me.txtInfo)
        Me.pFile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pFile.Location = New System.Drawing.Point(0, 348)
        Me.pFile.Name = "pFile"
        Me.pFile.Size = New System.Drawing.Size(893, 46)
        Me.pFile.TabIndex = 4
        Me.pFile.Visible = False
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(36, 17)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(26, 13)
        Me.lblType.TabIndex = 2
        Me.lblType.Text = "File:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(659, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Submit"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(93, 14)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(515, 20)
        Me.txtInfo.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(614, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(39, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pLink
        '
        Me.pLink.Controls.Add(Me.btnDeleteLink)
        Me.pLink.Controls.Add(Me.Label1)
        Me.pLink.Controls.Add(Me.btnSubmitLink)
        Me.pLink.Controls.Add(Me.txtInfoLink)
        Me.pLink.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pLink.Location = New System.Drawing.Point(0, 394)
        Me.pLink.Name = "pLink"
        Me.pLink.Size = New System.Drawing.Size(893, 49)
        Me.pLink.TabIndex = 5
        Me.pLink.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Link:"
        '
        'btnSubmitLink
        '
        Me.btnSubmitLink.Location = New System.Drawing.Point(659, 15)
        Me.btnSubmitLink.Name = "btnSubmitLink"
        Me.btnSubmitLink.Size = New System.Drawing.Size(111, 23)
        Me.btnSubmitLink.TabIndex = 5
        Me.btnSubmitLink.Text = "Submit"
        Me.btnSubmitLink.UseVisualStyleBackColor = True
        '
        'txtInfoLink
        '
        Me.txtInfoLink.Location = New System.Drawing.Point(93, 17)
        Me.txtInfoLink.Name = "txtInfoLink"
        Me.txtInfoLink.Size = New System.Drawing.Size(560, 20)
        Me.txtInfoLink.TabIndex = 4
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(776, 11)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnDeleteLink
        '
        Me.btnDeleteLink.Location = New System.Drawing.Point(776, 15)
        Me.btnDeleteLink.Name = "btnDeleteLink"
        Me.btnDeleteLink.Size = New System.Drawing.Size(111, 23)
        Me.btnDeleteLink.TabIndex = 7
        Me.btnDeleteLink.Text = "Delete"
        Me.btnDeleteLink.UseVisualStyleBackColor = True
        '
        'btnLink
        '
        Me.btnLink.Location = New System.Drawing.Point(213, 21)
        Me.btnLink.Name = "btnLink"
        Me.btnLink.Size = New System.Drawing.Size(114, 23)
        Me.btnLink.TabIndex = 2
        Me.btnLink.Text = "Add Link"
        Me.btnLink.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 443)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pFile)
        Me.Controls.Add(Me.pLink)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.Panel1.ResumeLayout(False)
        Me.pFile.ResumeLayout(False)
        Me.pFile.PerformLayout()
        Me.pLink.ResumeLayout(False)
        Me.pLink.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSignOut As Button
    Friend WithEvents btnFile As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pFile As Panel
    Friend WithEvents lblType As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pLink As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnDeleteLink As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmitLink As Button
    Friend WithEvents txtInfoLink As TextBox
    Friend WithEvents btnLink As Button
End Class
