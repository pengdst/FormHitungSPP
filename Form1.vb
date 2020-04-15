Public Class Form1
    Dim KELAS_REGULAR = "Regular", KELAS_INTERNASIONAL = "Internasional"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Form Hitung SKS Mahasiswa"
        CB_Jurusan.Text = "Pilih Jurusan..."
        CB_Jurusan.Items.Add("S2 - Teknik Informatika")
        CB_Jurusan.Items.Add("S1 - Sistem Informasi")
        CB_Jurusan.Items.Add("S1 - Informatika")
        CB_Jurusan.Items.Add("S1 - Teknologi Informasi")
        CB_Jurusan.Items.Add("S1 - Teknik Komputer")
        CB_Jurusan.Items.Add("D3 - Manajemen Informatika")
        CB_Jurusan.Items.Add("D3 - Teknik Informatika")
    End Sub

    Private Sub BTN_Tutup_Click(sender As Object, e As EventArgs) Handles BTN_Tutup.Click
        If (MsgBox("Apakah anda yakin akan keluar aplikasi?", vbOKCancel) = MsgBoxResult.Ok) Then
            Me.Close()
        End If
    End Sub

    Private Sub BTN_Hitung_Click(sender As Object, e As EventArgs) Handles BTN_Hitung.Click
        If TB_NIM.Text = "" Then
            MsgBox("Silahkan Isi NIM!!!", vbOKOnly)
            TB_NIM.Focus()
        ElseIf TB_Nama.Text = "" Then
            MsgBox("Silahkan Isi Nama!!!", vbOKOnly)
            TB_Nama.Focus()
        ElseIf CB_Jurusan.Text = "Pilih Jurusan..." Then
            MsgBox("Silahkan Pilih Jurusan !!!" + CB_Jurusan.Text, vbOKOnly)
            CB_Jurusan.Focus()
        ElseIf Not (RB_Regular.Checked Or RB_Internasional.Checked) Then
            MsgBox("Silahkan Pilih Kelas !!!", vbOKOnly)
            RB_Regular.Focus()
        ElseIf TB_SKS.Text = "" Then
            MsgBox("Silahkan Isi KRS!!!", vbOKOnly)
            TB_SKS.Focus()
        Else
            BayarSPP()
        End If

    End Sub

    Private Sub BayarSPP()

        Dim SPPTetap As Double
        Dim SPPVariable As Double
        Dim totalSPP As Double

        Dim Jml_SKS As Integer

        Jml_SKS = TB_SKS.Text

        Dim Kelas = FindKelas()
        Dim Jurusan = CB_Jurusan.SelectedIndex
        Dim Jenjang = FindJenjangByJurusan(Jurusan)

        SPPTetap = GetSPPTetapWith(Jurusan)
        SPPVariable = GetSPPVariableWith(Jenjang)

        totalSPP = HitungBayar(SPPTetap, SPPVariable, Jml_SKS)

        RTB_OutputMahasiswa.Text = "

                NIM           :   " + TB_NIM.Text + "
                Nama        :   " + TB_Nama.Text + "
                Jurusan     :   " + CB_Jurusan.Text + "
                Kelas         :   " + Kelas + "
            
            ---------- Rincian Biaya SPP ----------
            
                SPP Tetap       : " + SPPTetap.ToString + " 
                SPP Variable    : " + SPPVariable.ToString + "
                Total SPP         : " + totalSPP.ToString + "
                
        "
    End Sub

    Private Function HitungBayar(SPPTetap As Double, SPPVariabel As Double, SKS As Integer)
        Dim totalVariable As Double = SPPVariabel * SKS

        Return SPPTetap + totalVariable
    End Function

    Private Function GetSPPTetapWith(Jurusan As Integer)
        Dim SPPTetap As Double
        Dim Kelas = FindKelas()

        Dim firstJurusan = 0
        Dim lastJurusan = CB_Jurusan.Items.Count - 1

        If Jurusan >= firstJurusan And Jurusan <= lastJurusan Then
            SPPTetap = FindSPPTetapByJurusan(Jurusan)
        Else
            MsgBox("Pilih jurusan sesuai yang disediakan", vbOKOnly)
            Return False
        End If

        Return SPPTetap

    End Function

    Private Function GetSPPVariableWith(Strata As String)
        Dim SPPVariable As Double
        Dim S2 = 0, S1 = 1, D3 = 2

        If Strata = "S2" Then
            SPPVariable = FindSPPVariableByJenjang(S2)
        ElseIf Strata = "S1" Then
            SPPVariable = FindSPPVariableByJenjang(S1)
        ElseIf Strata = "D3" Then
            SPPVariable = FindSPPVariableByJenjang(D3)
        Else Return False

        End If

        Return SPPVariable
    End Function

    Private Function FindSPPVariableByJenjang(Jenjang As Integer)

        Dim Kelas = FindKelas()

        Dim ListSPPReguler = {1000000, 800000, 500000}
        Dim ListSPPInternasional = {2500000, 2000000, 1500000}

        If Kelas = KELAS_INTERNASIONAL Then
            Return ListSPPInternasional.ElementAt(Jenjang)
        ElseIf Kelas = KELAS_REGULAR Then
            Return ListSPPReguler.ElementAt(Jenjang)
        Else
            MsgBox("Pilih dengan Benar", vbOKOnly)
            Return False
        End If
    End Function

    Private Function FindSPPTetapByJurusan(Jurusan As Integer)
        Dim ListSPPInternasional = {100000000, 2500000, 2800000, 2600000, 2700000, 2200000, 23000000}
        Dim ListSPPReguler = {3000000, 1500000, 1800000, 1600000, 1700000, 1200000, 13000000}

        Dim SPPTetap As Double

        Dim Kelas = FindKelas()

        If Kelas = KELAS_REGULAR Then
            SPPTetap = ListSPPReguler.ElementAt(Jurusan)
        ElseIf Kelas = KELAS_INTERNASIONAL Then
            SPPTetap = ListSPPInternasional.ElementAt(Jurusan)
        Else
            MsgBox("Pilih dengan Benar", vbOKOnly)
            Return False
        End If

        Return SPPTetap
    End Function

    Private Function FindJenjangByJurusan(Jurusan As Integer)
        Dim Jenjang As String

        Dim firstJurusan = 0
        Dim secondJurusan = firstJurusan + 1
        Dim sixthJurusan = 5
        Dim lastJurusan = CB_Jurusan.Items.Count - 1

        If Jurusan = firstJurusan Then
            Jenjang = "S2"
        ElseIf (Jurusan >= secondJurusan And Jurusan < sixthJurusan) And Jurusan < lastJurusan Then
            Jenjang = "S1"
        ElseIf Jurusan >= sixthJurusan And Jurusan < lastJurusan Then
            Jenjang = "D3"
        Else
            Jenjang = "Out OF Range"
        End If

        Return Jenjang

    End Function
    Private Function FindKelas()
        Dim Kelas As String

        If RB_Regular.Checked Then
            Kelas = KELAS_REGULAR
        ElseIf RB_Internasional.Checked Then
            Kelas = KELAS_INTERNASIONAL
        Else
            Return False
        End If

        Return Kelas
    End Function
End Class
