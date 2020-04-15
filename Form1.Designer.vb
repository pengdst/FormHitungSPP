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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBID = New System.Windows.Forms.GroupBox()
        Me.BTN_Tutup = New System.Windows.Forms.Button()
        Me.BTN_Hitung = New System.Windows.Forms.Button()
        Me.CB_Jurusan = New System.Windows.Forms.ComboBox()
        Me.TB_SKS = New System.Windows.Forms.TextBox()
        Me.RB_Internasional = New System.Windows.Forms.RadioButton()
        Me.RB_Regular = New System.Windows.Forms.RadioButton()
        Me.TB_Nama = New System.Windows.Forms.TextBox()
        Me.TB_NIM = New System.Windows.Forms.TextBox()
        Me.TXTSKS = New System.Windows.Forms.Label()
        Me.TXTKLS = New System.Windows.Forms.Label()
        Me.TXTJRSN = New System.Windows.Forms.Label()
        Me.TXTNM = New System.Windows.Forms.Label()
        Me.TXTNIM = New System.Windows.Forms.Label()
        Me.RTB_OutputMahasiswa = New System.Windows.Forms.RichTextBox()
        Me.PB_Logo = New System.Windows.Forms.PictureBox()
        Me.GBID.SuspendLayout()
        CType(Me.PB_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FORM HITUNG SPP"
        '
        'GBID
        '
        Me.GBID.Controls.Add(Me.BTN_Tutup)
        Me.GBID.Controls.Add(Me.BTN_Hitung)
        Me.GBID.Controls.Add(Me.CB_Jurusan)
        Me.GBID.Controls.Add(Me.TB_SKS)
        Me.GBID.Controls.Add(Me.RB_Internasional)
        Me.GBID.Controls.Add(Me.RB_Regular)
        Me.GBID.Controls.Add(Me.TB_Nama)
        Me.GBID.Controls.Add(Me.TB_NIM)
        Me.GBID.Controls.Add(Me.TXTSKS)
        Me.GBID.Controls.Add(Me.TXTKLS)
        Me.GBID.Controls.Add(Me.TXTJRSN)
        Me.GBID.Controls.Add(Me.TXTNM)
        Me.GBID.Controls.Add(Me.TXTNIM)
        Me.GBID.Location = New System.Drawing.Point(28, 158)
        Me.GBID.Name = "GBID"
        Me.GBID.Size = New System.Drawing.Size(456, 212)
        Me.GBID.TabIndex = 2
        Me.GBID.TabStop = False
        Me.GBID.Text = "INPUTDATA"
        '
        'BTN_Tutup
        '
        Me.BTN_Tutup.Location = New System.Drawing.Point(278, 171)
        Me.BTN_Tutup.Name = "BTN_Tutup"
        Me.BTN_Tutup.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Tutup.TabIndex = 7
        Me.BTN_Tutup.Text = "TUTUP"
        Me.BTN_Tutup.UseVisualStyleBackColor = True
        '
        'BTN_Hitung
        '
        Me.BTN_Hitung.Location = New System.Drawing.Point(148, 171)
        Me.BTN_Hitung.Name = "BTN_Hitung"
        Me.BTN_Hitung.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Hitung.TabIndex = 6
        Me.BTN_Hitung.Text = "HITUNG"
        Me.BTN_Hitung.UseVisualStyleBackColor = True
        '
        'CB_Jurusan
        '
        Me.CB_Jurusan.FormattingEnabled = True
        Me.CB_Jurusan.Location = New System.Drawing.Point(148, 80)
        Me.CB_Jurusan.Name = "CB_Jurusan"
        Me.CB_Jurusan.Size = New System.Drawing.Size(205, 21)
        Me.CB_Jurusan.TabIndex = 2
        '
        'TB_SKS
        '
        Me.TB_SKS.Location = New System.Drawing.Point(148, 133)
        Me.TB_SKS.Name = "TB_SKS"
        Me.TB_SKS.Size = New System.Drawing.Size(46, 20)
        Me.TB_SKS.TabIndex = 5
        '
        'RB_Internasional
        '
        Me.RB_Internasional.AutoSize = True
        Me.RB_Internasional.Location = New System.Drawing.Point(241, 108)
        Me.RB_Internasional.Name = "RB_Internasional"
        Me.RB_Internasional.Size = New System.Drawing.Size(112, 17)
        Me.RB_Internasional.TabIndex = 4
        Me.RB_Internasional.TabStop = True
        Me.RB_Internasional.Text = "INTERNASIONAL"
        Me.RB_Internasional.UseVisualStyleBackColor = True
        '
        'RB_Regular
        '
        Me.RB_Regular.AutoSize = True
        Me.RB_Regular.Location = New System.Drawing.Point(148, 108)
        Me.RB_Regular.Name = "RB_Regular"
        Me.RB_Regular.Size = New System.Drawing.Size(77, 17)
        Me.RB_Regular.TabIndex = 3
        Me.RB_Regular.TabStop = True
        Me.RB_Regular.Text = "REGULER"
        Me.RB_Regular.UseVisualStyleBackColor = True
        '
        'TB_Nama
        '
        Me.TB_Nama.Location = New System.Drawing.Point(148, 51)
        Me.TB_Nama.Name = "TB_Nama"
        Me.TB_Nama.Size = New System.Drawing.Size(229, 20)
        Me.TB_Nama.TabIndex = 1
        '
        'TB_NIM
        '
        Me.TB_NIM.Location = New System.Drawing.Point(148, 24)
        Me.TB_NIM.Name = "TB_NIM"
        Me.TB_NIM.Size = New System.Drawing.Size(158, 20)
        Me.TB_NIM.TabIndex = 0
        '
        'TXTSKS
        '
        Me.TXTSKS.AutoSize = True
        Me.TXTSKS.Location = New System.Drawing.Point(45, 136)
        Me.TXTSKS.Name = "TXTSKS"
        Me.TXTSKS.Size = New System.Drawing.Size(28, 13)
        Me.TXTSKS.TabIndex = 4
        Me.TXTSKS.Text = "SKS"
        '
        'TXTKLS
        '
        Me.TXTKLS.AutoSize = True
        Me.TXTKLS.Location = New System.Drawing.Point(45, 108)
        Me.TXTKLS.Name = "TXTKLS"
        Me.TXTKLS.Size = New System.Drawing.Size(41, 13)
        Me.TXTKLS.TabIndex = 3
        Me.TXTKLS.Text = "KELAS"
        '
        'TXTJRSN
        '
        Me.TXTJRSN.AutoSize = True
        Me.TXTJRSN.Location = New System.Drawing.Point(46, 83)
        Me.TXTJRSN.Name = "TXTJRSN"
        Me.TXTJRSN.Size = New System.Drawing.Size(58, 13)
        Me.TXTJRSN.TabIndex = 2
        Me.TXTJRSN.Text = "JURUSAN"
        '
        'TXTNM
        '
        Me.TXTNM.AutoSize = True
        Me.TXTNM.Location = New System.Drawing.Point(46, 54)
        Me.TXTNM.Name = "TXTNM"
        Me.TXTNM.Size = New System.Drawing.Size(38, 13)
        Me.TXTNM.TabIndex = 1
        Me.TXTNM.Text = "NAMA"
        '
        'TXTNIM
        '
        Me.TXTNIM.AutoSize = True
        Me.TXTNIM.Location = New System.Drawing.Point(46, 27)
        Me.TXTNIM.Name = "TXTNIM"
        Me.TXTNIM.Size = New System.Drawing.Size(27, 13)
        Me.TXTNIM.TabIndex = 0
        Me.TXTNIM.Text = "NIM"
        '
        'RTB_OutputMahasiswa
        '
        Me.RTB_OutputMahasiswa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RTB_OutputMahasiswa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RTB_OutputMahasiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_OutputMahasiswa.Location = New System.Drawing.Point(32, 376)
        Me.RTB_OutputMahasiswa.Name = "RTB_OutputMahasiswa"
        Me.RTB_OutputMahasiswa.ReadOnly = True
        Me.RTB_OutputMahasiswa.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_OutputMahasiswa.ShortcutsEnabled = False
        Me.RTB_OutputMahasiswa.Size = New System.Drawing.Size(452, 199)
        Me.RTB_OutputMahasiswa.TabIndex = 14
        Me.RTB_OutputMahasiswa.Text = ""
        '
        'PB_Logo
        '
        Me.PB_Logo.Image = Global.formhitungspp.My.Resources.Resources._1_DRnlWieKxi36OG5IgjTDog
        Me.PB_Logo.Location = New System.Drawing.Point(32, 30)
        Me.PB_Logo.Name = "PB_Logo"
        Me.PB_Logo.Size = New System.Drawing.Size(113, 101)
        Me.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_Logo.TabIndex = 15
        Me.PB_Logo.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 587)
        Me.Controls.Add(Me.PB_Logo)
        Me.Controls.Add(Me.RTB_OutputMahasiswa)
        Me.Controls.Add(Me.GBID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form Hitung"
        Me.GBID.ResumeLayout(False)
        Me.GBID.PerformLayout()
        CType(Me.PB_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_Tutup As Button
    Friend WithEvents BTN_Hitung As Button
    Friend WithEvents CB_Jurusan As ComboBox
    Friend WithEvents TB_SKS As TextBox
    Friend WithEvents RB_Internasional As RadioButton
    Friend WithEvents RB_Regular As RadioButton
    Friend WithEvents TB_Nama As TextBox
    Friend WithEvents TB_NIM As TextBox
    Friend WithEvents TXTSKS As Label
    Friend WithEvents TXTKLS As Label
    Friend WithEvents TXTJRSN As Label
    Friend WithEvents TXTNM As Label
    Friend WithEvents TXTNIM As Label
    Protected WithEvents GBID As GroupBox
    Friend WithEvents RTB_OutputMahasiswa As RichTextBox
    Friend WithEvents PB_Logo As PictureBox
End Class
