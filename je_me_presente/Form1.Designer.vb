<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_cheveux = New System.Windows.Forms.Button()
        Me.btn_yeux = New System.Windows.Forms.Button()
        Me.btn_photo = New System.Windows.Forms.Button()
        Me.btn_effacer = New System.Windows.Forms.Button()
        Me.lbl_texte = New System.Windows.Forms.Label()
        Me.lbl_yeux = New System.Windows.Forms.Label()
        Me.lbl_cheveux = New System.Windows.Forms.Label()
        Me.pb_photo = New System.Windows.Forms.PictureBox()
        CType(Me.pb_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cheveux
        '
        Me.btn_cheveux.AutoSize = True
        Me.btn_cheveux.Location = New System.Drawing.Point(204, 144)
        Me.btn_cheveux.Name = "btn_cheveux"
        Me.btn_cheveux.Size = New System.Drawing.Size(134, 23)
        Me.btn_cheveux.TabIndex = 0
        Me.btn_cheveux.Text = "Couleur de mes cheveux"
        Me.btn_cheveux.UseVisualStyleBackColor = True
        '
        'btn_yeux
        '
        Me.btn_yeux.AutoSize = True
        Me.btn_yeux.Location = New System.Drawing.Point(49, 144)
        Me.btn_yeux.Name = "btn_yeux"
        Me.btn_yeux.Size = New System.Drawing.Size(115, 23)
        Me.btn_yeux.TabIndex = 0
        Me.btn_yeux.Text = "Couleur de mes yeus"
        Me.btn_yeux.UseVisualStyleBackColor = True
        '
        'btn_photo
        '
        Me.btn_photo.AutoSize = True
        Me.btn_photo.Location = New System.Drawing.Point(369, 144)
        Me.btn_photo.Name = "btn_photo"
        Me.btn_photo.Size = New System.Drawing.Size(75, 23)
        Me.btn_photo.TabIndex = 0
        Me.btn_photo.Text = "Ma photo"
        Me.btn_photo.UseVisualStyleBackColor = True
        '
        'btn_effacer
        '
        Me.btn_effacer.AutoSize = True
        Me.btn_effacer.Location = New System.Drawing.Point(231, 185)
        Me.btn_effacer.Name = "btn_effacer"
        Me.btn_effacer.Size = New System.Drawing.Size(75, 23)
        Me.btn_effacer.TabIndex = 0
        Me.btn_effacer.Text = "Effacer"
        Me.btn_effacer.UseVisualStyleBackColor = True
        '
        'lbl_texte
        '
        Me.lbl_texte.AutoSize = True
        Me.lbl_texte.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_texte.Location = New System.Drawing.Point(70, 22)
        Me.lbl_texte.Name = "lbl_texte"
        Me.lbl_texte.Size = New System.Drawing.Size(75, 22)
        Me.lbl_texte.TabIndex = 1
        Me.lbl_texte.Text = "Me voici"
        '
        'lbl_yeux
        '
        Me.lbl_yeux.AutoSize = True
        Me.lbl_yeux.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_yeux.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_yeux.Location = New System.Drawing.Point(70, 89)
        Me.lbl_yeux.Name = "lbl_yeux"
        Me.lbl_yeux.Size = New System.Drawing.Size(46, 22)
        Me.lbl_yeux.TabIndex = 1
        Me.lbl_yeux.Text = "Bleu"
        Me.lbl_yeux.Visible = False
        '
        'lbl_cheveux
        '
        Me.lbl_cheveux.AutoSize = True
        Me.lbl_cheveux.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cheveux.ForeColor = System.Drawing.Color.Gold
        Me.lbl_cheveux.Location = New System.Drawing.Point(236, 89)
        Me.lbl_cheveux.Name = "lbl_cheveux"
        Me.lbl_cheveux.Size = New System.Drawing.Size(56, 22)
        Me.lbl_cheveux.TabIndex = 1
        Me.lbl_cheveux.Text = "Blond"
        Me.lbl_cheveux.Visible = False
        '
        'pb_photo
        '
        Me.pb_photo.ErrorImage = CType(resources.GetObject("pb_photo.ErrorImage"), System.Drawing.Image)
        Me.pb_photo.ImageLocation = "center"
        Me.pb_photo.Location = New System.Drawing.Point(369, 72)
        Me.pb_photo.Name = "pb_photo"
        Me.pb_photo.Size = New System.Drawing.Size(75, 66)
        Me.pb_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_photo.TabIndex = 2
        Me.pb_photo.TabStop = False
        Me.pb_photo.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 238)
        Me.Controls.Add(Me.pb_photo)
        Me.Controls.Add(Me.lbl_cheveux)
        Me.Controls.Add(Me.lbl_yeux)
        Me.Controls.Add(Me.lbl_texte)
        Me.Controls.Add(Me.btn_yeux)
        Me.Controls.Add(Me.btn_photo)
        Me.Controls.Add(Me.btn_effacer)
        Me.Controls.Add(Me.btn_cheveux)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cheveux As Button
    Friend WithEvents btn_yeux As Button
    Friend WithEvents btn_photo As Button
    Friend WithEvents btn_effacer As Button
    Friend WithEvents lbl_texte As Label
    Friend WithEvents lbl_yeux As Label
    Friend WithEvents lbl_cheveux As Label
    Friend WithEvents pb_photo As PictureBox
End Class
