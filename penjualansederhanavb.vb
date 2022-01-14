Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbokode.Items.Add("B001")
        cbokode.Items.Add("B002")
        cbokode.Items.Add("B003")
        cbokode.Items.Add("B004")
    End Sub

    Private Sub cbokode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbokode.SelectedIndexChanged
        If cbokode.Text = "B001" Then
            Txtnamabarang.Text = "AQUA 600ML BOTOL"
            Txtharga.Text = 4500
        ElseIf cbokode.Text = "B002" Then
            Txtnamabarang.Text = "Clenq 600ML BOTOL"
            Txtharga.Text = 1000
        ElseIf cbokode.Text = "B003" Then
            Txtnamabarang.Text = "cleo 600ML BOTOL"
            Txtharga.Text = 4000
        ElseIf cbokode.Text = "B004" Then
            Txtnamabarang.Text = "Lee Mineral 600ML BOTOL"
            Txtharga.Text = 6000
        End If
    End Sub

    Private Sub Txtjumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtjumlah.TextChanged
        Txttotal.Text = Val(Txtharga.Text) * Val(Txtjumlah.Text)
    End Sub

    Private Sub btnkosongkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkosongkan.Click
        cbokode.Text = ""
        Txtharga.Text = ""
        Txtjumlah.Text = ""
        Txtnamabarang.Text = ""
        Txttotal.Text = ""
    End Sub
End Class
