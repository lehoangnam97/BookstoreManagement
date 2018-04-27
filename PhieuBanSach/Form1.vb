Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.CheckState = CheckState.Checked) Then
            txtNgayLap.ReadOnly = True
            txtNgayLap.Enabled = True
        Else
            txtNgayLap.ReadOnly = False
            txtNgayLap.Enabled = False
        End If
    End Sub

    Private Sub btnAddKH_Click(sender As Object, e As EventArgs) Handles btnAddKH.Click
        txtHoTen.ReadOnly = True
        txtEmail.ReadOnly = True
        txtDiaChi.ReadOnly = True
        txtSDT.ReadOnly = True
        txtTienNo.Text = "0"

    End Sub

    Private Sub txtTienNo_TextChanged(sender As Object, e As EventArgs) Handles txtTienNo.TextChanged
        If (txtTienNo.Text = "") Then
            txtTienNo.ForeColor = Color.White
        Else
            If (Int32.Parse(txtTienNo.Text) < 20000) Then
                txtTienNo.ForeColor = Color.Green
            Else
                txtTienNo.ForeColor = Color.Red

            End If
        End If

    End Sub



    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtHoTen.ReadOnly = False
        txtHoTen.Text = ""
        txtEmail.ReadOnly = False
        txtEmail.Text = ""
        txtDiaChi.ReadOnly = False
        txtDiaChi.Text = ""
        txtSDT.ReadOnly = False
        txtSDT.Text = ""
        txtTienNo.Text = "0"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'add Data


        btnRefresh_Click(sender, e)

    End Sub
End Class
