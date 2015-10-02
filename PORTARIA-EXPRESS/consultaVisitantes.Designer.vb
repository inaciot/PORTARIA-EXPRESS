<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultaVisitantes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.USUARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblplacaconsulta = New System.Windows.Forms.Label()
        Me.lblcarroconsulta = New System.Windows.Forms.Label()
        Me.lblapartamentoconsulta = New System.Windows.Forms.Label()
        Me.lblsobrenomeconsulta = New System.Windows.Forms.Label()
        Me.lblnomeconsulta = New System.Windows.Forms.Label()
        Me.lblcpfconsulta = New System.Windows.Forms.Label()
        Me.txtcpfconsulta = New System.Windows.Forms.TextBox()
        Me.txtnomeconsulta = New System.Windows.Forms.TextBox()
        Me.txtsobrenomeconsulta = New System.Windows.Forms.TextBox()
        Me.txtplacaconsulta = New System.Windows.Forms.TextBox()
        Me.txtapartamentoconsulta = New System.Windows.Forms.TextBox()
        Me.txtcarroconsulta = New System.Windows.Forms.TextBox()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USUARIOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(360, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USUARIOToolStripMenuItem
        '
        Me.USUARIOToolStripMenuItem.Name = "USUARIOToolStripMenuItem"
        Me.USUARIOToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.USUARIOToolStripMenuItem.Text = "VOLTAR"
        '
        'lblplacaconsulta
        '
        Me.lblplacaconsulta.AutoSize = True
        Me.lblplacaconsulta.Location = New System.Drawing.Point(1, 174)
        Me.lblplacaconsulta.Name = "lblplacaconsulta"
        Me.lblplacaconsulta.Size = New System.Drawing.Size(37, 13)
        Me.lblplacaconsulta.TabIndex = 14
        Me.lblplacaconsulta.Text = "Placa:"
        Me.lblplacaconsulta.Visible = False
        '
        'lblcarroconsulta
        '
        Me.lblcarroconsulta.AutoSize = True
        Me.lblcarroconsulta.Location = New System.Drawing.Point(1, 246)
        Me.lblcarroconsulta.Name = "lblcarroconsulta"
        Me.lblcarroconsulta.Size = New System.Drawing.Size(88, 13)
        Me.lblcarroconsulta.TabIndex = 13
        Me.lblcarroconsulta.Text = "Modelo do Carro:"
        Me.lblcarroconsulta.Visible = False
        '
        'lblapartamentoconsulta
        '
        Me.lblapartamentoconsulta.AutoSize = True
        Me.lblapartamentoconsulta.Location = New System.Drawing.Point(1, 210)
        Me.lblapartamentoconsulta.Name = "lblapartamentoconsulta"
        Me.lblapartamentoconsulta.Size = New System.Drawing.Size(70, 13)
        Me.lblapartamentoconsulta.TabIndex = 12
        Me.lblapartamentoconsulta.Text = "Apartamento:"
        Me.lblapartamentoconsulta.Visible = False
        '
        'lblsobrenomeconsulta
        '
        Me.lblsobrenomeconsulta.AutoSize = True
        Me.lblsobrenomeconsulta.Location = New System.Drawing.Point(1, 133)
        Me.lblsobrenomeconsulta.Name = "lblsobrenomeconsulta"
        Me.lblsobrenomeconsulta.Size = New System.Drawing.Size(61, 13)
        Me.lblsobrenomeconsulta.TabIndex = 10
        Me.lblsobrenomeconsulta.Text = "Sobrenome"
        Me.lblsobrenomeconsulta.Visible = False
        '
        'lblnomeconsulta
        '
        Me.lblnomeconsulta.AutoSize = True
        Me.lblnomeconsulta.Location = New System.Drawing.Point(1, 99)
        Me.lblnomeconsulta.Name = "lblnomeconsulta"
        Me.lblnomeconsulta.Size = New System.Drawing.Size(38, 13)
        Me.lblnomeconsulta.TabIndex = 9
        Me.lblnomeconsulta.Text = "Nome:"
        Me.lblnomeconsulta.Visible = False
        '
        'lblcpfconsulta
        '
        Me.lblcpfconsulta.AutoSize = True
        Me.lblcpfconsulta.Location = New System.Drawing.Point(55, 41)
        Me.lblcpfconsulta.Name = "lblcpfconsulta"
        Me.lblcpfconsulta.Size = New System.Drawing.Size(51, 13)
        Me.lblcpfconsulta.TabIndex = 15
        Me.lblcpfconsulta.Text = "RG/CPF:"
        '
        'txtcpfconsulta
        '
        Me.txtcpfconsulta.Location = New System.Drawing.Point(112, 41)
        Me.txtcpfconsulta.Name = "txtcpfconsulta"
        Me.txtcpfconsulta.Size = New System.Drawing.Size(122, 20)
        Me.txtcpfconsulta.TabIndex = 16
        '
        'txtnomeconsulta
        '
        Me.txtnomeconsulta.Location = New System.Drawing.Point(93, 99)
        Me.txtnomeconsulta.Name = "txtnomeconsulta"
        Me.txtnomeconsulta.Size = New System.Drawing.Size(155, 20)
        Me.txtnomeconsulta.TabIndex = 17
        Me.txtnomeconsulta.Visible = False
        '
        'txtsobrenomeconsulta
        '
        Me.txtsobrenomeconsulta.Location = New System.Drawing.Point(93, 130)
        Me.txtsobrenomeconsulta.Name = "txtsobrenomeconsulta"
        Me.txtsobrenomeconsulta.Size = New System.Drawing.Size(155, 20)
        Me.txtsobrenomeconsulta.TabIndex = 18
        Me.txtsobrenomeconsulta.Visible = False
        '
        'txtplacaconsulta
        '
        Me.txtplacaconsulta.Location = New System.Drawing.Point(93, 167)
        Me.txtplacaconsulta.Name = "txtplacaconsulta"
        Me.txtplacaconsulta.Size = New System.Drawing.Size(155, 20)
        Me.txtplacaconsulta.TabIndex = 19
        Me.txtplacaconsulta.Visible = False
        '
        'txtapartamentoconsulta
        '
        Me.txtapartamentoconsulta.Location = New System.Drawing.Point(93, 203)
        Me.txtapartamentoconsulta.Name = "txtapartamentoconsulta"
        Me.txtapartamentoconsulta.Size = New System.Drawing.Size(155, 20)
        Me.txtapartamentoconsulta.TabIndex = 20
        Me.txtapartamentoconsulta.Visible = False
        '
        'txtcarroconsulta
        '
        Me.txtcarroconsulta.Location = New System.Drawing.Point(93, 239)
        Me.txtcarroconsulta.Name = "txtcarroconsulta"
        Me.txtcarroconsulta.Size = New System.Drawing.Size(155, 20)
        Me.txtcarroconsulta.TabIndex = 21
        Me.txtcarroconsulta.Visible = False
        '
        'btnconsultar
        '
        Me.btnconsultar.Location = New System.Drawing.Point(249, 39)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(92, 23)
        Me.btnconsultar.TabIndex = 22
        Me.btnconsultar.Text = "PESQUSIAR:"
        Me.btnconsultar.UseVisualStyleBackColor = True
        '
        'consultaVisitantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 277)
        Me.Controls.Add(Me.btnconsultar)
        Me.Controls.Add(Me.txtcarroconsulta)
        Me.Controls.Add(Me.txtapartamentoconsulta)
        Me.Controls.Add(Me.txtplacaconsulta)
        Me.Controls.Add(Me.txtsobrenomeconsulta)
        Me.Controls.Add(Me.txtnomeconsulta)
        Me.Controls.Add(Me.txtcpfconsulta)
        Me.Controls.Add(Me.lblcpfconsulta)
        Me.Controls.Add(Me.lblplacaconsulta)
        Me.Controls.Add(Me.lblcarroconsulta)
        Me.Controls.Add(Me.lblapartamentoconsulta)
        Me.Controls.Add(Me.lblsobrenomeconsulta)
        Me.Controls.Add(Me.lblnomeconsulta)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "consultaVisitantes"
        Me.Text = "CONSULTAR VISITANTES"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents USUARIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblplacaconsulta As System.Windows.Forms.Label
    Friend WithEvents lblcarroconsulta As System.Windows.Forms.Label
    Friend WithEvents lblapartamentoconsulta As System.Windows.Forms.Label
    Friend WithEvents lblsobrenomeconsulta As System.Windows.Forms.Label
    Friend WithEvents lblnomeconsulta As System.Windows.Forms.Label
    Friend WithEvents lblcpfconsulta As System.Windows.Forms.Label
    Friend WithEvents txtcpfconsulta As System.Windows.Forms.TextBox
    Friend WithEvents txtnomeconsulta As System.Windows.Forms.TextBox
    Friend WithEvents txtsobrenomeconsulta As System.Windows.Forms.TextBox
    Friend WithEvents txtplacaconsulta As System.Windows.Forms.TextBox
    Friend WithEvents txtapartamentoconsulta As System.Windows.Forms.TextBox
    Friend WithEvents txtcarroconsulta As System.Windows.Forms.TextBox
    Friend WithEvents btnconsultar As System.Windows.Forms.Button
End Class
