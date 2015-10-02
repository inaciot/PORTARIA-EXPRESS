<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro
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
        Me.CADASTRARVISITANTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAMORADORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnsalvarcadastro = New System.Windows.Forms.Button()
        Me.btnsaircadastro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtcpf = New System.Windows.Forms.TextBox()
        Me.txtcarro = New System.Windows.Forms.TextBox()
        Me.txtxsobrenome = New System.Windows.Forms.TextBox()
        Me.txtapartamento = New System.Windows.Forms.TextBox()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CADASTRARVISITANTESToolStripMenuItem, Me.CONSULTAMORADORESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CADASTRARVISITANTESToolStripMenuItem
        '
        Me.CADASTRARVISITANTESToolStripMenuItem.Name = "CADASTRARVISITANTESToolStripMenuItem"
        Me.CADASTRARVISITANTESToolStripMenuItem.Size = New System.Drawing.Size(152, 20)
        Me.CADASTRARVISITANTESToolStripMenuItem.Text = "CONSULTAR VISITANTES"
        '
        'CONSULTAMORADORESToolStripMenuItem
        '
        Me.CONSULTAMORADORESToolStripMenuItem.Name = "CONSULTAMORADORESToolStripMenuItem"
        Me.CONSULTAMORADORESToolStripMenuItem.Size = New System.Drawing.Size(161, 20)
        Me.CONSULTAMORADORESToolStripMenuItem.Text = "CONSULTAR MORADORES"
        '
        'btnsalvarcadastro
        '
        Me.btnsalvarcadastro.Location = New System.Drawing.Point(96, 212)
        Me.btnsalvarcadastro.Name = "btnsalvarcadastro"
        Me.btnsalvarcadastro.Size = New System.Drawing.Size(75, 23)
        Me.btnsalvarcadastro.TabIndex = 1
        Me.btnsalvarcadastro.Text = "SALVAR"
        Me.btnsalvarcadastro.UseVisualStyleBackColor = True
        '
        'btnsaircadastro
        '
        Me.btnsaircadastro.Location = New System.Drawing.Point(393, 212)
        Me.btnsaircadastro.Name = "btnsaircadastro"
        Me.btnsaircadastro.Size = New System.Drawing.Size(75, 23)
        Me.btnsaircadastro.TabIndex = 2
        Me.btnsaircadastro.Text = "SAIR"
        Me.btnsaircadastro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sobrenome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RG/CPF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Apartamento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Modelo do Carro:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(257, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Placa:"
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(96, 90)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(139, 20)
        Me.txtnome.TabIndex = 9
        '
        'txtcpf
        '
        Me.txtcpf.Location = New System.Drawing.Point(96, 125)
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.Size = New System.Drawing.Size(139, 20)
        Me.txtcpf.TabIndex = 10
        '
        'txtcarro
        '
        Me.txtcarro.Location = New System.Drawing.Point(96, 163)
        Me.txtcarro.Name = "txtcarro"
        Me.txtcarro.Size = New System.Drawing.Size(139, 20)
        Me.txtcarro.TabIndex = 11
        '
        'txtxsobrenome
        '
        Me.txtxsobrenome.Location = New System.Drawing.Point(324, 90)
        Me.txtxsobrenome.Name = "txtxsobrenome"
        Me.txtxsobrenome.Size = New System.Drawing.Size(144, 20)
        Me.txtxsobrenome.TabIndex = 12
        '
        'txtapartamento
        '
        Me.txtapartamento.Location = New System.Drawing.Point(324, 129)
        Me.txtapartamento.Name = "txtapartamento"
        Me.txtapartamento.Size = New System.Drawing.Size(144, 20)
        Me.txtapartamento.TabIndex = 13
        '
        'txtplaca
        '
        Me.txtplaca.Location = New System.Drawing.Point(324, 163)
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(144, 20)
        Me.txtplaca.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(422, 33)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "CADASTRO DE VISITANTES"
        '
        'cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 255)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtplaca)
        Me.Controls.Add(Me.txtapartamento)
        Me.Controls.Add(Me.txtxsobrenome)
        Me.Controls.Add(Me.txtcarro)
        Me.Controls.Add(Me.txtcpf)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsaircadastro)
        Me.Controls.Add(Me.btnsalvarcadastro)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "cadastro"
        Me.Text = "CADASTRO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CADASTRARVISITANTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTAMORADORESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnsalvarcadastro As System.Windows.Forms.Button
    Friend WithEvents btnsaircadastro As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents txtcpf As System.Windows.Forms.TextBox
    Friend WithEvents txtcarro As System.Windows.Forms.TextBox
    Friend WithEvents txtxsobrenome As System.Windows.Forms.TextBox
    Friend WithEvents txtapartamento As System.Windows.Forms.TextBox
    Friend WithEvents txtplaca As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
