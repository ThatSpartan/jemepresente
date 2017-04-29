<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_carre
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
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.btn_calculer = New System.Windows.Forms.Button()
        Me.tb_longeur = New System.Windows.Forms.TextBox()
        Me.tb_largeur = New System.Windows.Forms.TextBox()
        Me.tb_reponse = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_delete_longeur = New System.Windows.Forms.Label()
        Me.btn_delete_largeur = New System.Windows.Forms.Label()
        Me.btn_delete_reponse = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_retour
        '
        Me.btn_retour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_retour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_retour.Location = New System.Drawing.Point(357, 233)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Padding = New System.Windows.Forms.Padding(3)
        Me.btn_retour.Size = New System.Drawing.Size(80, 35)
        Me.btn_retour.TabIndex = 5
        Me.btn_retour.TabStop = False
        Me.btn_retour.Text = "Retour"
        Me.btn_retour.UseVisualStyleBackColor = True
        '
        'btn_calculer
        '
        Me.btn_calculer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_calculer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_calculer.Location = New System.Drawing.Point(271, 233)
        Me.btn_calculer.Name = "btn_calculer"
        Me.btn_calculer.Padding = New System.Windows.Forms.Padding(3)
        Me.btn_calculer.Size = New System.Drawing.Size(80, 35)
        Me.btn_calculer.TabIndex = 4
        Me.btn_calculer.TabStop = False
        Me.btn_calculer.Text = "Calculer"
        Me.btn_calculer.UseVisualStyleBackColor = True
        '
        'tb_longeur
        '
        Me.tb_longeur.Location = New System.Drawing.Point(241, 70)
        Me.tb_longeur.Name = "tb_longeur"
        Me.tb_longeur.Size = New System.Drawing.Size(66, 20)
        Me.tb_longeur.TabIndex = 1
        '
        'tb_largeur
        '
        Me.tb_largeur.Location = New System.Drawing.Point(241, 117)
        Me.tb_largeur.Name = "tb_largeur"
        Me.tb_largeur.Size = New System.Drawing.Size(66, 20)
        Me.tb_largeur.TabIndex = 2
        '
        'tb_reponse
        '
        Me.tb_reponse.Location = New System.Drawing.Point(241, 164)
        Me.tb_reponse.Name = "tb_reponse"
        Me.tb_reponse.Size = New System.Drawing.Size(66, 20)
        Me.tb_reponse.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Longeur :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Largeur :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(161, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Égale :"
        '
        'btn_delete_longeur
        '
        Me.btn_delete_longeur.AutoSize = True
        Me.btn_delete_longeur.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete_longeur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_longeur.Location = New System.Drawing.Point(313, 71)
        Me.btn_delete_longeur.Name = "btn_delete_longeur"
        Me.btn_delete_longeur.Size = New System.Drawing.Size(14, 17)
        Me.btn_delete_longeur.TabIndex = 7
        Me.btn_delete_longeur.Text = "x"
        '
        'btn_delete_largeur
        '
        Me.btn_delete_largeur.AutoSize = True
        Me.btn_delete_largeur.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete_largeur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_largeur.Location = New System.Drawing.Point(313, 118)
        Me.btn_delete_largeur.Name = "btn_delete_largeur"
        Me.btn_delete_largeur.Size = New System.Drawing.Size(14, 17)
        Me.btn_delete_largeur.TabIndex = 7
        Me.btn_delete_largeur.Text = "x"
        '
        'btn_delete_reponse
        '
        Me.btn_delete_reponse.AutoSize = True
        Me.btn_delete_reponse.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete_reponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_reponse.Location = New System.Drawing.Point(313, 165)
        Me.btn_delete_reponse.Name = "btn_delete_reponse"
        Me.btn_delete_reponse.Size = New System.Drawing.Size(14, 17)
        Me.btn_delete_reponse.TabIndex = 7
        Me.btn_delete_reponse.Text = "x"
        '
        'fm_carre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 280)
        Me.Controls.Add(Me.btn_delete_reponse)
        Me.Controls.Add(Me.btn_delete_largeur)
        Me.Controls.Add(Me.btn_delete_longeur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_reponse)
        Me.Controls.Add(Me.tb_largeur)
        Me.Controls.Add(Me.tb_longeur)
        Me.Controls.Add(Me.btn_calculer)
        Me.Controls.Add(Me.btn_retour)
        Me.Name = "fm_carre"
        Me.Text = "Aire du carré"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_retour As Button
    Friend WithEvents btn_calculer As Button
    Friend WithEvents tb_longeur As TextBox
    Friend WithEvents tb_largeur As TextBox
    Friend WithEvents tb_reponse As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_delete_longeur As Label
    Friend WithEvents btn_delete_largeur As Label
    Friend WithEvents btn_delete_reponse As Label
End Class
