<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ortcode = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FrankfurtHbf10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrankfurtNiederrad11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.alleziele = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fahrkartenautomat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ziel"
        '
        'ortcode
        '
        Me.ortcode.AutoCompleteCustomSource.AddRange(New String() {"Frankfurt Hbf (10)", "Frankfurt Niederrad (11)", "Frankfurt Süd (12)", "Gustavsburg (103)", "Mainz-Kastel (33)", "Mainz-Nord (32)", "Mainz Hbf(30)", "Mainz Römisches Theater (31)", "Offenbach Hbf (20)", "Wiesbaden Hbf (40)", "Rüsselsheim (101)", "Bischofsheim (102)", "10 Frankfurt Hbf", "11 Frankfurt Niederrad", "12 Frankfurt Süd", "103 Gustavsburg", "33 Mainz-Kastel", "32 Mainz-Nord", "30 Mainz Hbf", "31 Mainz Römisches Theater", "20 Offenbach Hbf", "40 Wiesbaden Hbf", "101 Rüsselsheim", "102 Bischofsheim"})
        Me.ortcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ortcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ortcode.Location = New System.Drawing.Point(86, 75)
        Me.ortcode.Name = "ortcode"
        Me.ortcode.Size = New System.Drawing.Size(100, 20)
        Me.ortcode.TabIndex = 2
        Me.ortcode.Text = "Ort / Code"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FrankfurtHbf10ToolStripMenuItem, Me.FrankfurtNiederrad11ToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(201, 48)
        '
        'FrankfurtHbf10ToolStripMenuItem
        '
        Me.FrankfurtHbf10ToolStripMenuItem.Name = "FrankfurtHbf10ToolStripMenuItem"
        Me.FrankfurtHbf10ToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.FrankfurtHbf10ToolStripMenuItem.Text = "Frankfurt Hbf (10)"
        '
        'FrankfurtNiederrad11ToolStripMenuItem
        '
        Me.FrankfurtNiederrad11ToolStripMenuItem.Name = "FrankfurtNiederrad11ToolStripMenuItem"
        Me.FrankfurtNiederrad11ToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.FrankfurtNiederrad11ToolStripMenuItem.Text = "Frankfurt Niederrad (11)"
        '
        'alleziele
        '
        Me.alleziele.AutoCompleteCustomSource.AddRange(New String() {""})
        Me.alleziele.FormattingEnabled = True
        Me.alleziele.Items.AddRange(New Object() {"Frankfurt Hbf (10)", "Frankfurt Niederrad (11)", "Frankfurt Süd (12)", "Gustavsburg (103)", "Mainz-Kastel (33)", "Mainz-Nord (32)", "Mainz Hbf(30)", "Mainz Römisches Theater (31)", "Offenbach Hbf (20)", "Wiesbaden Hbf (40)", "Rüsselsheim (101)", "Bischofsheim (102)"})
        Me.alleziele.Location = New System.Drawing.Point(86, 101)
        Me.alleziele.Name = "alleziele"
        Me.alleziele.Size = New System.Drawing.Size(121, 21)
        Me.alleziele.TabIndex = 6
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 505)
        Me.Controls.Add(Me.alleziele)
        Me.Controls.Add(Me.ortcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Fahrkartenautomat"
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ortcode As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents FrankfurtHbf10ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FrankfurtNiederrad11ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents alleziele As ComboBox
End Class
