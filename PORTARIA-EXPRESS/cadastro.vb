Public Class cadastro


    Private Sub CRIARUSUARIOToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub FAZERLOToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

   
    Private Sub CADASTRARVISITANTESToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CADASTRARVISITANTESToolStripMenuItem.Click
        Me.Visible = False

        consultaVisitantes.Show()
        
    End Sub

    Private Sub CONSULTAMORADORESToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CONSULTAMORADORESToolStripMenuItem.Click
        Me.Visible = False
        moradores.Show()
    End Sub

    Private Sub btnsaircadastro_Click(sender As System.Object, e As System.EventArgs) Handles btnsaircadastro.Click
        If MessageBox.Show("Deseja mesmo sair?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class