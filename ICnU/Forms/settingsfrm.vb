Public Class settingsfrm

    Private Sub closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub

    Private Sub savbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savbtn.Click
        My.Settings.SI = CrystalClearCheckBox4.Checked
        My.Settings.Ui = CrystalClearCheckBox3.Checked
        My.Settings.Im = CrystalClearCheckBox2.Checked
        My.Settings.Ic = CrystalClearCheckBox1.Checked
        Me.Close()
    End Sub

   
    Private Sub settingsfrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CrystalClearCheckBox4.Checked = My.Settings.SI
        CrystalClearCheckBox3.Checked = My.Settings.Ui
        CrystalClearCheckBox2.Checked = My.Settings.Im
        CrystalClearCheckBox1.Checked = My.Settings.Ic
    End Sub
End Class