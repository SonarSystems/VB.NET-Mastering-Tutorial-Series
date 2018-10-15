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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WebBrowser1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'WebBrowser1
        '
        resources.ApplyResources(Me.WebBrowser1, "WebBrowser1")
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Url = New System.Uri("https://sonarsystems.co.uk", System.UriKind.Absolute)
        '
        'btnBack
        '
        resources.ApplyResources(Me.btnBack, "btnBack")
        Me.btnBack.Name = "btnBack"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnForward
        '
        resources.ApplyResources(Me.btnForward, "btnForward")
        Me.btnForward.Name = "btnForward"
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        resources.ApplyResources(Me.btnRefresh, "btnRefresh")
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtURL
        '
        resources.ApplyResources(Me.txtURL, "txtURL")
        Me.txtURL.Name = "txtURL"
        '
        'btnGo
        '
        resources.ApplyResources(Me.btnGo, "btnGo")
        Me.btnGo.Name = "btnGo"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnForward)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btnBack As Button
    Friend WithEvents btnForward As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtURL As TextBox
    Friend WithEvents btnGo As Button
End Class
