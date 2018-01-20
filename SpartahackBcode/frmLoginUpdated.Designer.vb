<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginUpdated
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtUser = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'txtUser
        '
        Me.txtUser.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUser.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUser.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtUser.BorderThickness = 3
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUser.isPassword = False
        Me.txtUser.Location = New System.Drawing.Point(23, 167)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(370, 44)
        Me.txtUser.TabIndex = 0
        Me.txtUser.Text = "BunifuMetroTextbox1"
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'frmLoginUpdated
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 511)
        Me.Controls.Add(Me.txtUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoginUpdated"
        Me.Text = "frmLoginUpdated"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
