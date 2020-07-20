<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoatApplication
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
        Me.btnPrintBoats = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPrintBoats
        '
        Me.btnPrintBoats.Location = New System.Drawing.Point(88, 95)
        Me.btnPrintBoats.Name = "btnPrintBoats"
        Me.btnPrintBoats.Size = New System.Drawing.Size(109, 72)
        Me.btnPrintBoats.TabIndex = 0
        Me.btnPrintBoats.Text = "Print Boats"
        Me.btnPrintBoats.UseVisualStyleBackColor = True
        '
        'frmBoatApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnPrintBoats)
        Me.Name = "frmBoatApplication"
        Me.ShowIcon = False
        Me.Text = "Boat Application"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrintBoats As Button
End Class
