<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_triangle
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
        Me.btn_delete_reponse = New System.Windows.Forms.Label()
        Me.btn_delete_largeur = New System.Windows.Forms.Label()
        Me.btn_delete_longeur = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_aire = New System.Windows.Forms.TextBox()
        Me.tb_hauteur = New System.Windows.Forms.TextBox()
        Me.tb_base = New System.Windows.Forms.TextBox()
        Me.btn_calculer = New System.Windows.Forms.Button()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_delete_reponse
        '
        Me.btn_delete_reponse.AutoSize = True
        Me.btn_delete_reponse.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete_reponse.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_delete_reponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_reponse.Location = New System.Drawing.Point(282, 165)
        Me.btn_delete_reponse.Name = "btn_delete_reponse"
        Me.btn_delete_reponse.Size = New System.Drawing.Size(14, 17)
        Me.btn_delete_reponse.TabIndex = 31
        Me.btn_delete_reponse.Text = "x"
        '
        'btn_delete_largeur
        '
        Me.btn_delete_largeur.AutoSize = True
        Me.btn_delete_largeur.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete_largeur.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_delete_largeur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_largeur.Location = New System.Drawing.Point(282, 118)
        Me.btn_delete_largeur.Name = "btn_delete_largeur"
        Me.btn_delete_largeur.Size = New System.Drawing.Size(14, 17)
        Me.btn_delete_largeur.TabIndex = 32
        Me.btn_delete_largeur.Text = "x"
        '
        'btn_delete_longeur
        '
        Me.btn_delete_longeur.AutoSize = True
        Me.btn_delete_longeur.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete_longeur.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_delete_longeur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_longeur.Location = New System.Drawing.Point(282, 71)
        Me.btn_delete_longeur.Name = "btn_delete_longeur"
        Me.btn_delete_longeur.Size = New System.Drawing.Size(14, 17)
        Me.btn_delete_longeur.TabIndex = 33
        Me.btn_delete_longeur.Text = "x"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Aire :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Hauteur :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Base :"
        '
        'tb_aire
        '
        Me.tb_aire.Location = New System.Drawing.Point(210, 164)
        Me.tb_aire.Name = "tb_aire"
        Me.tb_aire.Size = New System.Drawing.Size(87, 20)
        Me.tb_aire.TabIndex = 23
        '
        'tb_hauteur
        '
        Me.tb_hauteur.Location = New System.Drawing.Point(210, 117)
        Me.tb_hauteur.Name = "tb_hauteur"
        Me.tb_hauteur.Size = New System.Drawing.Size(87, 20)
        Me.tb_hauteur.TabIndex = 22
        '
        'tb_base
        '
        Me.tb_base.Location = New System.Drawing.Point(210, 70)
        Me.tb_base.Name = "tb_base"
        Me.tb_base.Size = New System.Drawing.Size(87, 20)
        Me.tb_base.TabIndex = 21
        '
        'btn_calculer
        '
        Me.btn_calculer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_calculer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_calculer.Location = New System.Drawing.Point(271, 233)
        Me.btn_calculer.Name = "btn_calculer"
        Me.btn_calculer.Padding = New System.Windows.Forms.Padding(3)
        Me.btn_calculer.Size = New System.Drawing.Size(80, 35)
        Me.btn_calculer.TabIndex = 26
        Me.btn_calculer.TabStop = False
        Me.btn_calculer.Text = "Calculer"
        Me.btn_calculer.UseVisualStyleBackColor = True
        '
        'btn_retour
        '
        Me.btn_retour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_retour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_retour.Location = New System.Drawing.Point(357, 233)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Padding = New System.Windows.Forms.Padding(3)
        Me.btn_retour.Size = New System.Drawing.Size(80, 35)
        Me.btn_retour.TabIndex = 27
        Me.btn_retour.TabStop = False
        Me.btn_retour.Text = "Retour"
        Me.btn_retour.UseVisualStyleBackColor = True
        '
        'fm_triangle
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
        Me.Controls.Add(Me.tb_aire)
        Me.Controls.Add(Me.tb_hauteur)
        Me.Controls.Add(Me.tb_base)
        Me.Controls.Add(Me.btn_calculer)
        Me.Controls.Add(Me.btn_retour)
        Me.Name = "fm_triangle"
        Me.Text = "Aire du Triangle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_delete_reponse As Label
    Friend WithEvents btn_delete_largeur As Label
    Friend WithEvents btn_delete_longeur As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_aire As TextBox
    Friend WithEvents tb_hauteur As TextBox
    Friend WithEvents tb_base As TextBox
    Friend WithEvents btn_calculer As Button
    Friend WithEvents btn_retour As Button
End Class
