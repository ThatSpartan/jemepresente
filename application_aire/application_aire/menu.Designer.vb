<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_menu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_carre = New System.Windows.Forms.Button()
        Me.btn_cercle = New System.Windows.Forms.Button()
        Me.btn_triangle = New System.Windows.Forms.Button()
        Me.btn_rectangle = New System.Windows.Forms.Button()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btn_carre
        '
        resources.ApplyResources(Me.btn_carre, "btn_carre")
        Me.btn_carre.Name = "btn_carre"
        Me.btn_carre.TabStop = False
        Me.btn_carre.UseVisualStyleBackColor = True
        '
        'btn_cercle
        '
        resources.ApplyResources(Me.btn_cercle, "btn_cercle")
        Me.btn_cercle.Name = "btn_cercle"
        Me.btn_cercle.TabStop = False
        Me.btn_cercle.UseVisualStyleBackColor = True
        '
        'btn_triangle
        '
        resources.ApplyResources(Me.btn_triangle, "btn_triangle")
        Me.btn_triangle.Name = "btn_triangle"
        Me.btn_triangle.TabStop = False
        Me.btn_triangle.UseVisualStyleBackColor = True
        '
        'btn_rectangle
        '
        resources.ApplyResources(Me.btn_rectangle, "btn_rectangle")
        Me.btn_rectangle.Name = "btn_rectangle"
        Me.btn_rectangle.TabStop = False
        Me.btn_rectangle.UseVisualStyleBackColor = True
        '
        'btn_quitter
        '
        resources.ApplyResources(Me.btn_quitter, "btn_quitter")
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'fm_menu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.btn_rectangle)
        Me.Controls.Add(Me.btn_triangle)
        Me.Controls.Add(Me.btn_cercle)
        Me.Controls.Add(Me.btn_carre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fm_menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_carre As Button
    Friend WithEvents btn_cercle As Button
    Friend WithEvents btn_triangle As Button
    Friend WithEvents btn_rectangle As Button
    Friend WithEvents btn_quitter As Button
    Friend WithEvents Label3 As Label
End Class
