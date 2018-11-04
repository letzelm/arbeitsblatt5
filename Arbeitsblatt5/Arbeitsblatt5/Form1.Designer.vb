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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fahrpreis = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.einfachfahrt = New System.Windows.Forms.RadioButton()
        Me.hinundruck = New System.Windows.Forms.RadioButton()
        Me.tageskarte = New System.Windows.Forms.RadioButton()
        Me.gruppenkarte = New System.Windows.Forms.RadioButton()
        Me.wochenkarte = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.kind = New System.Windows.Forms.RadioButton()
        Me.erwachsener = New System.Windows.Forms.RadioButton()
        Me.azubi = New System.Windows.Forms.RadioButton()
        Me.behindert = New System.Windows.Forms.RadioButton()
        Me.fahrrad = New System.Windows.Forms.RadioButton()
        Me.hund = New System.Windows.Forms.RadioButton()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(293, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "zu zahlen"
        '
        'fahrpreis
        '
        Me.fahrpreis.Location = New System.Drawing.Point(352, 78)
        Me.fahrpreis.Name = "fahrpreis"
        Me.fahrpreis.Size = New System.Drawing.Size(100, 20)
        Me.fahrpreis.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.wochenkarte)
        Me.GroupBox1.Controls.Add(Me.gruppenkarte)
        Me.GroupBox1.Controls.Add(Me.tageskarte)
        Me.GroupBox1.Controls.Add(Me.hinundruck)
        Me.GroupBox1.Controls.Add(Me.einfachfahrt)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 148)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fahrkarte"
        '
        'einfachfahrt
        '
        Me.einfachfahrt.AutoSize = True
        Me.einfachfahrt.Location = New System.Drawing.Point(15, 20)
        Me.einfachfahrt.Name = "einfachfahrt"
        Me.einfachfahrt.Size = New System.Drawing.Size(93, 17)
        Me.einfachfahrt.TabIndex = 0
        Me.einfachfahrt.TabStop = True
        Me.einfachfahrt.Text = "einfache Fahrt"
        Me.einfachfahrt.UseVisualStyleBackColor = True
        '
        'hinundruck
        '
        Me.hinundruck.AutoSize = True
        Me.hinundruck.Location = New System.Drawing.Point(15, 44)
        Me.hinundruck.Name = "hinundruck"
        Me.hinundruck.Size = New System.Drawing.Size(115, 17)
        Me.hinundruck.TabIndex = 1
        Me.hinundruck.TabStop = True
        Me.hinundruck.Text = "Hin- und Rückfahrt"
        Me.hinundruck.UseVisualStyleBackColor = True
        '
        'tageskarte
        '
        Me.tageskarte.AutoSize = True
        Me.tageskarte.Location = New System.Drawing.Point(15, 68)
        Me.tageskarte.Name = "tageskarte"
        Me.tageskarte.Size = New System.Drawing.Size(79, 17)
        Me.tageskarte.TabIndex = 2
        Me.tageskarte.TabStop = True
        Me.tageskarte.Text = "Tageskarte"
        Me.tageskarte.UseVisualStyleBackColor = True
        '
        'gruppenkarte
        '
        Me.gruppenkarte.AutoSize = True
        Me.gruppenkarte.Location = New System.Drawing.Point(15, 92)
        Me.gruppenkarte.Name = "gruppenkarte"
        Me.gruppenkarte.Size = New System.Drawing.Size(90, 17)
        Me.gruppenkarte.TabIndex = 3
        Me.gruppenkarte.TabStop = True
        Me.gruppenkarte.Text = "Gruppenkarte"
        Me.gruppenkarte.UseVisualStyleBackColor = True
        '
        'wochenkarte
        '
        Me.wochenkarte.AutoSize = True
        Me.wochenkarte.Location = New System.Drawing.Point(15, 116)
        Me.wochenkarte.Name = "wochenkarte"
        Me.wochenkarte.Size = New System.Drawing.Size(90, 17)
        Me.wochenkarte.TabIndex = 4
        Me.wochenkarte.TabStop = True
        Me.wochenkarte.Text = "Wochenkarte"
        Me.wochenkarte.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.hund)
        Me.GroupBox2.Controls.Add(Me.fahrrad)
        Me.GroupBox2.Controls.Add(Me.behindert)
        Me.GroupBox2.Controls.Add(Me.azubi)
        Me.GroupBox2.Controls.Add(Me.erwachsener)
        Me.GroupBox2.Controls.Add(Me.kind)
        Me.GroupBox2.Location = New System.Drawing.Point(264, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(140, 171)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'kind
        '
        Me.kind.AutoSize = True
        Me.kind.Location = New System.Drawing.Point(7, 20)
        Me.kind.Name = "kind"
        Me.kind.Size = New System.Drawing.Size(46, 17)
        Me.kind.TabIndex = 0
        Me.kind.TabStop = True
        Me.kind.Text = "Kind"
        Me.kind.UseVisualStyleBackColor = True
        '
        'erwachsener
        '
        Me.erwachsener.AutoSize = True
        Me.erwachsener.Location = New System.Drawing.Point(7, 44)
        Me.erwachsener.Name = "erwachsener"
        Me.erwachsener.Size = New System.Drawing.Size(87, 17)
        Me.erwachsener.TabIndex = 1
        Me.erwachsener.TabStop = True
        Me.erwachsener.Text = "Erwachsener"
        Me.erwachsener.UseVisualStyleBackColor = True
        '
        'azubi
        '
        Me.azubi.AutoSize = True
        Me.azubi.Location = New System.Drawing.Point(7, 68)
        Me.azubi.Name = "azubi"
        Me.azubi.Size = New System.Drawing.Size(97, 17)
        Me.azubi.TabIndex = 2
        Me.azubi.TabStop = True
        Me.azubi.Text = "Auszubildender"
        Me.azubi.UseVisualStyleBackColor = True
        '
        'behindert
        '
        Me.behindert.AutoSize = True
        Me.behindert.Location = New System.Drawing.Point(7, 92)
        Me.behindert.Name = "behindert"
        Me.behindert.Size = New System.Drawing.Size(114, 17)
        Me.behindert.TabIndex = 3
        Me.behindert.TabStop = True
        Me.behindert.Text = "Schwerbehinderter"
        Me.behindert.UseVisualStyleBackColor = True
        '
        'fahrrad
        '
        Me.fahrrad.AutoSize = True
        Me.fahrrad.Location = New System.Drawing.Point(7, 116)
        Me.fahrrad.Name = "fahrrad"
        Me.fahrrad.Size = New System.Drawing.Size(61, 17)
        Me.fahrrad.TabIndex = 4
        Me.fahrrad.TabStop = True
        Me.fahrrad.Text = "Fahrrad"
        Me.fahrrad.UseVisualStyleBackColor = True
        '
        'hund
        '
        Me.hund.AutoSize = True
        Me.hund.Location = New System.Drawing.Point(7, 140)
        Me.hund.Name = "hund"
        Me.hund.Size = New System.Drawing.Size(51, 17)
        Me.hund.TabIndex = 5
        Me.hund.TabStop = True
        Me.hund.Text = "Hund"
        Me.hund.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 505)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fahrpreis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.alleziele)
        Me.Controls.Add(Me.ortcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Fahrkartenautomat"
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents fahrpreis As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents wochenkarte As RadioButton
    Friend WithEvents gruppenkarte As RadioButton
    Friend WithEvents tageskarte As RadioButton
    Friend WithEvents hinundruck As RadioButton
    Friend WithEvents einfachfahrt As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents hund As RadioButton
    Friend WithEvents fahrrad As RadioButton
    Friend WithEvents behindert As RadioButton
    Friend WithEvents azubi As RadioButton
    Friend WithEvents erwachsener As RadioButton
    Friend WithEvents kind As RadioButton
End Class
