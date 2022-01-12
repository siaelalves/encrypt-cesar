<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRP
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
        Me.cmdCr = New System.Windows.Forms.Button()
        Me.cmdDc = New System.Windows.Forms.Button()
        Me.cmdSvDr = New System.Windows.Forms.Button()
        Me.cmdSvCr = New System.Windows.Forms.Button()
        Me.cmdIpCr = New System.Windows.Forms.Button()
        Me.cmdIpDr = New System.Windows.Forms.Button()
        Me.cmdLmDr = New System.Windows.Forms.Button()
        Me.cmdLmCr = New System.Windows.Forms.Button()
        Me.lblTxDr = New System.Windows.Forms.Label()
        Me.lblTxCr = New System.Windows.Forms.Label()
        Me.txtCr = New System.Windows.Forms.RichTextBox()
        Me.txtDr = New System.Windows.Forms.RichTextBox()
        Me.st = New System.Windows.Forms.StatusStrip()
        Me.prgSt = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblPrVl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdCn = New System.Windows.Forms.Button()
        Me.dlgSv = New System.Windows.Forms.SaveFileDialog()
        Me.cmdAb = New System.Windows.Forms.Button()
        Me.dlgAb = New System.Windows.Forms.OpenFileDialog()
        Me.st.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCr
        '
        Me.cmdCr.Location = New System.Drawing.Point(255, 41)
        Me.cmdCr.Name = "cmdCr"
        Me.cmdCr.Size = New System.Drawing.Size(75, 23)
        Me.cmdCr.TabIndex = 2
        Me.cmdCr.Text = "&Cript >"
        Me.cmdCr.UseVisualStyleBackColor = True
        '
        'cmdDc
        '
        Me.cmdDc.Location = New System.Drawing.Point(255, 70)
        Me.cmdDc.Name = "cmdDc"
        Me.cmdDc.Size = New System.Drawing.Size(75, 23)
        Me.cmdDc.TabIndex = 3
        Me.cmdDc.Text = "< &Decript"
        Me.cmdDc.UseVisualStyleBackColor = True
        '
        'cmdSvDr
        '
        Me.cmdSvDr.Location = New System.Drawing.Point(12, 364)
        Me.cmdSvDr.Name = "cmdSvDr"
        Me.cmdSvDr.Size = New System.Drawing.Size(75, 23)
        Me.cmdSvDr.TabIndex = 4
        Me.cmdSvDr.Text = "&Salvar"
        Me.cmdSvDr.UseVisualStyleBackColor = True
        '
        'cmdSvCr
        '
        Me.cmdSvCr.Location = New System.Drawing.Point(498, 364)
        Me.cmdSvCr.Name = "cmdSvCr"
        Me.cmdSvCr.Size = New System.Drawing.Size(75, 23)
        Me.cmdSvCr.TabIndex = 5
        Me.cmdSvCr.Text = "Sal&var"
        Me.cmdSvCr.UseVisualStyleBackColor = True
        '
        'cmdIpCr
        '
        Me.cmdIpCr.Location = New System.Drawing.Point(417, 364)
        Me.cmdIpCr.Name = "cmdIpCr"
        Me.cmdIpCr.Size = New System.Drawing.Size(75, 23)
        Me.cmdIpCr.TabIndex = 6
        Me.cmdIpCr.Text = "Im&primir"
        Me.cmdIpCr.UseVisualStyleBackColor = True
        '
        'cmdIpDr
        '
        Me.cmdIpDr.Location = New System.Drawing.Point(93, 364)
        Me.cmdIpDr.Name = "cmdIpDr"
        Me.cmdIpDr.Size = New System.Drawing.Size(75, 23)
        Me.cmdIpDr.TabIndex = 7
        Me.cmdIpDr.Text = "&Imprimir"
        Me.cmdIpDr.UseVisualStyleBackColor = True
        '
        'cmdLmDr
        '
        Me.cmdLmDr.Location = New System.Drawing.Point(174, 364)
        Me.cmdLmDr.Name = "cmdLmDr"
        Me.cmdLmDr.Size = New System.Drawing.Size(75, 23)
        Me.cmdLmDr.TabIndex = 8
        Me.cmdLmDr.Text = "&Limpar"
        Me.cmdLmDr.UseVisualStyleBackColor = True
        '
        'cmdLmCr
        '
        Me.cmdLmCr.Location = New System.Drawing.Point(336, 364)
        Me.cmdLmCr.Name = "cmdLmCr"
        Me.cmdLmCr.Size = New System.Drawing.Size(75, 23)
        Me.cmdLmCr.TabIndex = 9
        Me.cmdLmCr.Text = "Li&mpar"
        Me.cmdLmCr.UseVisualStyleBackColor = True
        '
        'lblTxDr
        '
        Me.lblTxDr.AutoSize = True
        Me.lblTxDr.Location = New System.Drawing.Point(12, 25)
        Me.lblTxDr.Name = "lblTxDr"
        Me.lblTxDr.Size = New System.Drawing.Size(119, 13)
        Me.lblTxDr.TabIndex = 10
        Me.lblTxDr.Text = "Texto descriptografado:"
        '
        'lblTxCr
        '
        Me.lblTxCr.AutoSize = True
        Me.lblTxCr.Location = New System.Drawing.Point(333, 25)
        Me.lblTxCr.Name = "lblTxCr"
        Me.lblTxCr.Size = New System.Drawing.Size(102, 13)
        Me.lblTxCr.TabIndex = 11
        Me.lblTxCr.Text = "Texto criptografado:"
        '
        'txtCr
        '
        Me.txtCr.Location = New System.Drawing.Point(336, 41)
        Me.txtCr.Name = "txtCr"
        Me.txtCr.Size = New System.Drawing.Size(237, 317)
        Me.txtCr.TabIndex = 1
        Me.txtCr.Text = ""
        '
        'txtDr
        '
        Me.txtDr.Location = New System.Drawing.Point(12, 41)
        Me.txtDr.Name = "txtDr"
        Me.txtDr.Size = New System.Drawing.Size(237, 317)
        Me.txtDr.TabIndex = 0
        Me.txtDr.Text = ""
        '
        'st
        '
        Me.st.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.prgSt, Me.lblPrVl})
        Me.st.Location = New System.Drawing.Point(0, 402)
        Me.st.Name = "st"
        Me.st.Size = New System.Drawing.Size(587, 22)
        Me.st.TabIndex = 12
        Me.st.Text = "StatusStrip1"
        '
        'prgSt
        '
        Me.prgSt.Name = "prgSt"
        Me.prgSt.Size = New System.Drawing.Size(100, 16)
        Me.prgSt.Step = 1
        '
        'lblPrVl
        '
        Me.lblPrVl.Name = "lblPrVl"
        Me.lblPrVl.Size = New System.Drawing.Size(23, 17)
        Me.lblPrVl.Text = "0%"
        '
        'cmdCn
        '
        Me.cmdCn.Location = New System.Drawing.Point(255, 99)
        Me.cmdCn.Name = "cmdCn"
        Me.cmdCn.Size = New System.Drawing.Size(75, 23)
        Me.cmdCn.TabIndex = 13
        Me.cmdCn.Text = "Ca&ncelar"
        Me.cmdCn.UseVisualStyleBackColor = True
        '
        'dlgSv
        '
        Me.dlgSv.DefaultExt = "crp"
        Me.dlgSv.FileName = "Encrypted file"
        Me.dlgSv.Filter = "SAK Encryption (*.crp)|*.crp"
        Me.dlgSv.RestoreDirectory = True
        Me.dlgSv.Title = "Salvar texto"
        '
        'cmdAb
        '
        Me.cmdAb.Location = New System.Drawing.Point(255, 128)
        Me.cmdAb.Name = "cmdAb"
        Me.cmdAb.Size = New System.Drawing.Size(75, 23)
        Me.cmdAb.TabIndex = 14
        Me.cmdAb.Text = "&Abrir"
        Me.cmdAb.UseVisualStyleBackColor = True
        '
        'dlgAb
        '
        Me.dlgAb.DefaultExt = "crp"
        Me.dlgAb.FileName = "Encrypted file"
        Me.dlgAb.Filter = "SAK Encryption (*.crp)|*.crp"
        Me.dlgAb.RestoreDirectory = True
        '
        'CRP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 424)
        Me.Controls.Add(Me.cmdAb)
        Me.Controls.Add(Me.cmdCn)
        Me.Controls.Add(Me.st)
        Me.Controls.Add(Me.lblTxCr)
        Me.Controls.Add(Me.lblTxDr)
        Me.Controls.Add(Me.cmdLmCr)
        Me.Controls.Add(Me.cmdLmDr)
        Me.Controls.Add(Me.cmdIpDr)
        Me.Controls.Add(Me.cmdIpCr)
        Me.Controls.Add(Me.cmdSvCr)
        Me.Controls.Add(Me.cmdSvDr)
        Me.Controls.Add(Me.cmdDc)
        Me.Controls.Add(Me.cmdCr)
        Me.Controls.Add(Me.txtCr)
        Me.Controls.Add(Me.txtDr)
        Me.Name = "CRP"
        Me.Text = "SAK Cript"
        Me.st.ResumeLayout(False)
        Me.st.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCr As System.Windows.Forms.Button
    Friend WithEvents cmdDc As System.Windows.Forms.Button
    Friend WithEvents cmdSvDr As System.Windows.Forms.Button
    Friend WithEvents cmdSvCr As System.Windows.Forms.Button
    Friend WithEvents cmdIpCr As System.Windows.Forms.Button
    Friend WithEvents cmdIpDr As System.Windows.Forms.Button
    Friend WithEvents cmdLmDr As System.Windows.Forms.Button
    Friend WithEvents cmdLmCr As System.Windows.Forms.Button
    Friend WithEvents lblTxDr As System.Windows.Forms.Label
    Friend WithEvents lblTxCr As System.Windows.Forms.Label
    Friend WithEvents txtCr As System.Windows.Forms.RichTextBox
    Friend WithEvents txtDr As System.Windows.Forms.RichTextBox
    Friend WithEvents st As System.Windows.Forms.StatusStrip
    Friend WithEvents prgSt As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblPrVl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdCn As System.Windows.Forms.Button
    Friend WithEvents dlgSv As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdAb As System.Windows.Forms.Button
    Friend WithEvents dlgAb As System.Windows.Forms.OpenFileDialog

End Class
