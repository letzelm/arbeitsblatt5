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
        Me.wochenkarte = New System.Windows.Forms.RadioButton()
        Me.gruppenkarte = New System.Windows.Forms.RadioButton()
        Me.tageskarte = New System.Windows.Forms.RadioButton()
        Me.hinundruck = New System.Windows.Forms.RadioButton()
        Me.einfachfahrt = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.hund = New System.Windows.Forms.RadioButton()
        Me.fahrrad = New System.Windows.Forms.RadioButton()
        Me.behindert = New System.Windows.Forms.RadioButton()
        Me.azubi = New System.Windows.Forms.RadioButton()
        Me.erwachsener = New System.Windows.Forms.RadioButton()
        Me.kind = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.kontonummer = New System.Windows.Forms.TextBox()
        Me.prufziffer = New System.Windows.Forms.TextBox()
        Me.paypaluser = New System.Windows.Forms.TextBox()
        Me.pppasswort = New System.Windows.Forms.TextBox()
        Me.buchen = New System.Windows.Forms.Button()
        Me.calc = New System.Windows.Forms.GroupBox()
        Me.b1 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.b4 = New System.Windows.Forms.Button()
        Me.b5 = New System.Windows.Forms.Button()
        Me.b6 = New System.Windows.Forms.Button()
        Me.b7 = New System.Windows.Forms.Button()
        Me.b8 = New System.Windows.Forms.Button()
        Me.b9 = New System.Windows.Forms.Button()
        Me.bdel = New System.Windows.Forms.Button()
        Me.b0 = New System.Windows.Forms.Button()
        Me.bkom = New System.Windows.Forms.Button()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.calc.SuspendLayout()
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
        Me.ortcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.hund)
        Me.GroupBox2.Controls.Add(Me.fahrrad)
        Me.GroupBox2.Controls.Add(Me.behindert)
        Me.GroupBox2.Controls.Add(Me.azubi)
        Me.GroupBox2.Controls.Add(Me.erwachsener)
        Me.GroupBox2.Controls.Add(Me.kind)
        Me.GroupBox2.Location = New System.Drawing.Point(258, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(140, 171)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(454, 167)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'kontonummer
        '
        Me.kontonummer.Location = New System.Drawing.Point(454, 195)
        Me.kontonummer.Name = "kontonummer"
        Me.kontonummer.Size = New System.Drawing.Size(100, 20)
        Me.kontonummer.TabIndex = 12
        Me.kontonummer.Text = "Kontonummer"
        '
        'prufziffer
        '
        Me.prufziffer.Location = New System.Drawing.Point(454, 222)
        Me.prufziffer.Name = "prufziffer"
        Me.prufziffer.Size = New System.Drawing.Size(100, 20)
        Me.prufziffer.TabIndex = 13
        Me.prufziffer.Text = "Prüfziffer"
        '
        'paypaluser
        '
        Me.paypaluser.Location = New System.Drawing.Point(454, 259)
        Me.paypaluser.Name = "paypaluser"
        Me.paypaluser.Size = New System.Drawing.Size(100, 20)
        Me.paypaluser.TabIndex = 14
        Me.paypaluser.Text = "PayPal E-mail"
        '
        'pppasswort
        '
        Me.pppasswort.Location = New System.Drawing.Point(454, 283)
        Me.pppasswort.Name = "pppasswort"
        Me.pppasswort.Size = New System.Drawing.Size(100, 20)
        Me.pppasswort.TabIndex = 15
        Me.pppasswort.Text = "Passwort"
        '
        'buchen
        '
        Me.buchen.Location = New System.Drawing.Point(454, 314)
        Me.buchen.Name = "buchen"
        Me.buchen.Size = New System.Drawing.Size(100, 24)
        Me.buchen.TabIndex = 16
        Me.buchen.Text = "Buchen / OK"
        Me.buchen.UseVisualStyleBackColor = True
        '
        'calc
        '
        Me.calc.Controls.Add(Me.bkom)
        Me.calc.Controls.Add(Me.b0)
        Me.calc.Controls.Add(Me.bdel)
        Me.calc.Controls.Add(Me.b9)
        Me.calc.Controls.Add(Me.b8)
        Me.calc.Controls.Add(Me.b7)
        Me.calc.Controls.Add(Me.b6)
        Me.calc.Controls.Add(Me.b5)
        Me.calc.Controls.Add(Me.b4)
        Me.calc.Controls.Add(Me.b3)
        Me.calc.Controls.Add(Me.b2)
        Me.calc.Controls.Add(Me.b1)
        Me.calc.Location = New System.Drawing.Point(354, 371)
        Me.calc.Name = "calc"
        Me.calc.Size = New System.Drawing.Size(98, 135)
        Me.calc.TabIndex = 17
        Me.calc.TabStop = False
        Me.calc.Text = "Geldeingabe"
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(6, 19)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(21, 21)
        Me.b1.TabIndex = 0
        Me.b1.Text = "1"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(33, 19)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(21, 21)
        Me.b2.TabIndex = 1
        Me.b2.Text = "2"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(60, 19)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(21, 21)
        Me.b3.TabIndex = 2
        Me.b3.Text = "3"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.Location = New System.Drawing.Point(6, 46)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(21, 21)
        Me.b4.TabIndex = 3
        Me.b4.Text = "4"
        Me.b4.UseVisualStyleBackColor = True
        '
        'b5
        '
        Me.b5.Location = New System.Drawing.Point(33, 46)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(21, 21)
        Me.b5.TabIndex = 4
        Me.b5.Text = "5"
        Me.b5.UseVisualStyleBackColor = True
        '
        'b6
        '
        Me.b6.Location = New System.Drawing.Point(60, 46)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(21, 21)
        Me.b6.TabIndex = 5
        Me.b6.Text = "6"
        Me.b6.UseVisualStyleBackColor = True
        '
        'b7
        '
        Me.b7.Location = New System.Drawing.Point(6, 73)
        Me.b7.Name = "b7"
        Me.b7.Size = New System.Drawing.Size(21, 21)
        Me.b7.TabIndex = 6
        Me.b7.Text = "7"
        Me.b7.UseVisualStyleBackColor = True
        '
        'b8
        '
        Me.b8.Location = New System.Drawing.Point(33, 73)
        Me.b8.Name = "b8"
        Me.b8.Size = New System.Drawing.Size(21, 21)
        Me.b8.TabIndex = 7
        Me.b8.Text = "8"
        Me.b8.UseVisualStyleBackColor = True
        '
        'b9
        '
        Me.b9.Location = New System.Drawing.Point(60, 73)
        Me.b9.Name = "b9"
        Me.b9.Size = New System.Drawing.Size(21, 21)
        Me.b9.TabIndex = 8
        Me.b9.Text = "9"
        Me.b9.UseVisualStyleBackColor = True
        '
        'bdel
        '
        Me.bdel.Location = New System.Drawing.Point(6, 100)
        Me.bdel.Name = "bdel"
        Me.bdel.Size = New System.Drawing.Size(21, 21)
        Me.bdel.TabIndex = 9
        Me.bdel.Text = "d"
        Me.bdel.UseVisualStyleBackColor = True
        '
        'b0
        '
        Me.b0.Location = New System.Drawing.Point(33, 100)
        Me.b0.Name = "b0"
        Me.b0.Size = New System.Drawing.Size(21, 21)
        Me.b0.TabIndex = 10
        Me.b0.Text = "0"
        Me.b0.UseVisualStyleBackColor = True
        '
        'bkom
        '
        Me.bkom.Location = New System.Drawing.Point(60, 100)
        Me.bkom.Name = "bkom"
        Me.bkom.Size = New System.Drawing.Size(21, 21)
        Me.bkom.TabIndex = 11
        Me.bkom.Text = ","
        Me.bkom.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 552)
        Me.Controls.Add(Me.calc)
        Me.Controls.Add(Me.buchen)
        Me.Controls.Add(Me.pppasswort)
        Me.Controls.Add(Me.paypaluser)
        Me.Controls.Add(Me.prufziffer)
        Me.Controls.Add(Me.kontonummer)
        Me.Controls.Add(Me.ComboBox1)
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
        Me.calc.ResumeLayout(False)
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents kontonummer As TextBox
    Friend WithEvents prufziffer As TextBox
    Friend WithEvents paypaluser As TextBox
    Friend WithEvents pppasswort As TextBox
    Friend WithEvents buchen As Button
    Friend WithEvents calc As GroupBox
    Friend WithEvents bkom As Button
    Friend WithEvents b0 As Button
    Friend WithEvents bdel As Button
    Friend WithEvents b9 As Button
    Friend WithEvents b8 As Button
    Friend WithEvents b7 As Button
    Friend WithEvents b6 As Button
    Friend WithEvents b5 As Button
    Friend WithEvents b4 As Button
    Friend WithEvents b3 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b1 As Button
End Class
