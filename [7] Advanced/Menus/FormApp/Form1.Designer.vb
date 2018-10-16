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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sub1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubSub1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubSub2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.Menu2ToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        resources.ApplyResources(Me.NewToolStripMenuItem, "NewToolStripMenuItem")
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        resources.ApplyResources(Me.OpenToolStripMenuItem, "OpenToolStripMenuItem")
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        resources.ApplyResources(Me.SaveToolStripMenuItem, "SaveToolStripMenuItem")
        '
        'Menu2ToolStripMenuItem
        '
        Me.Menu2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Sub1ToolStripMenuItem})
        Me.Menu2ToolStripMenuItem.Name = "Menu2ToolStripMenuItem"
        resources.ApplyResources(Me.Menu2ToolStripMenuItem, "Menu2ToolStripMenuItem")
        '
        'Sub1ToolStripMenuItem
        '
        Me.Sub1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubSub1ToolStripMenuItem, Me.SubSub2ToolStripMenuItem})
        Me.Sub1ToolStripMenuItem.Name = "Sub1ToolStripMenuItem"
        resources.ApplyResources(Me.Sub1ToolStripMenuItem, "Sub1ToolStripMenuItem")
        '
        'SubSub1ToolStripMenuItem
        '
        Me.SubSub1ToolStripMenuItem.Name = "SubSub1ToolStripMenuItem"
        resources.ApplyResources(Me.SubSub1ToolStripMenuItem, "SubSub1ToolStripMenuItem")
        '
        'SubSub2ToolStripMenuItem
        '
        Me.SubSub2ToolStripMenuItem.Name = "SubSub2ToolStripMenuItem"
        resources.ApplyResources(Me.SubSub2ToolStripMenuItem, "SubSub2ToolStripMenuItem")
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sub1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubSub1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubSub2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
