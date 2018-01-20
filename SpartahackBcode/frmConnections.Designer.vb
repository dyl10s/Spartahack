<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnections
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lbConnections = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(83, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lbConnections
        '
        Me.lbConnections.FormattingEnabled = True
        Me.lbConnections.Items.AddRange(New Object() {"Resume", "Business Card", "Linked-In"})
        Me.lbConnections.Location = New System.Drawing.Point(12, 41)
        Me.lbConnections.Name = "lbConnections"
        Me.lbConnections.Size = New System.Drawing.Size(220, 277)
        Me.lbConnections.TabIndex = 1
        '
        'frmConnections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 333)
        Me.Controls.Add(Me.lbConnections)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmConnections"
        Me.Text = "Connections"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents lbConnections As ListBox
End Class
