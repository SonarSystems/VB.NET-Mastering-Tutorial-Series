<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtAwesome = New System.Windows.Forms.TextBox()
        Me.lblAwesome = New System.Windows.Forms.Label()
        Me.btnAwesome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAwesome
        '
        resources.ApplyResources(Me.txtAwesome, "txtAwesome")
        Me.txtAwesome.Name = "txtAwesome"
        '
        'lblAwesome
        '
        resources.ApplyResources(Me.lblAwesome, "lblAwesome")
        Me.lblAwesome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAwesome.Name = "lblAwesome"
        '
        'btnAwesome
        '
        resources.ApplyResources(Me.btnAwesome, "btnAwesome")
        Me.btnAwesome.Name = "btnAwesome"
        Me.btnAwesome.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.btnAwesome)
        Me.Controls.Add(Me.lblAwesome)
        Me.Controls.Add(Me.txtAwesome)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAwesome As TextBox
    Friend WithEvents lblAwesome As Label
    Friend WithEvents btnAwesome As Button
End Class
