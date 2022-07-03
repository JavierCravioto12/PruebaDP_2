<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroDistribuidores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidoPaterno = New System.Windows.Forms.Label()
        Me.lblApellidoMaterno = New System.Windows.Forms.Label()
        Me.GrpNombre = New System.Windows.Forms.GroupBox()
        Me.txtApellidoM = New System.Windows.Forms.TextBox()
        Me.txtApellidoP = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GrpDireccion = New System.Windows.Forms.GroupBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpNombre.SuspendLayout()
        Me.GrpDireccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(938, 53)
        Me.Panel1.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitulo.Location = New System.Drawing.Point(309, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(332, 41)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Regitro Distribuidores"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Prueba_Distribuidores.My.Resources.Resources.dportenis_logo_png_transparent
        Me.PictureBox1.Location = New System.Drawing.Point(364, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(62, 47)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(74, 20)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre: "
        '
        'lblApellidoPaterno
        '
        Me.lblApellidoPaterno.AutoSize = True
        Me.lblApellidoPaterno.Location = New System.Drawing.Point(6, 133)
        Me.lblApellidoPaterno.Name = "lblApellidoPaterno"
        Me.lblApellidoPaterno.Size = New System.Drawing.Size(132, 20)
        Me.lblApellidoPaterno.TabIndex = 3
        Me.lblApellidoPaterno.Text = "Apellido Paterno: "
        '
        'lblApellidoMaterno
        '
        Me.lblApellidoMaterno.AutoSize = True
        Me.lblApellidoMaterno.Location = New System.Drawing.Point(6, 230)
        Me.lblApellidoMaterno.Name = "lblApellidoMaterno"
        Me.lblApellidoMaterno.Size = New System.Drawing.Size(137, 20)
        Me.lblApellidoMaterno.TabIndex = 4
        Me.lblApellidoMaterno.Text = "Apellido Materno: "
        '
        'GrpNombre
        '
        Me.GrpNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrpNombre.Controls.Add(Me.txtApellidoM)
        Me.GrpNombre.Controls.Add(Me.txtApellidoP)
        Me.GrpNombre.Controls.Add(Me.txtNombre)
        Me.GrpNombre.Controls.Add(Me.lblNombre)
        Me.GrpNombre.Controls.Add(Me.lblApellidoMaterno)
        Me.GrpNombre.Controls.Add(Me.lblApellidoPaterno)
        Me.GrpNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GrpNombre.ForeColor = System.Drawing.Color.White
        Me.GrpNombre.Location = New System.Drawing.Point(12, 173)
        Me.GrpNombre.Name = "GrpNombre"
        Me.GrpNombre.Size = New System.Drawing.Size(448, 297)
        Me.GrpNombre.TabIndex = 5
        Me.GrpNombre.TabStop = False
        Me.GrpNombre.Text = "Nombre"
        '
        'txtApellidoM
        '
        Me.txtApellidoM.Location = New System.Drawing.Point(139, 223)
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(281, 27)
        Me.txtApellidoM.TabIndex = 7
        '
        'txtApellidoP
        '
        Me.txtApellidoP.Location = New System.Drawing.Point(139, 126)
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(281, 27)
        Me.txtApellidoP.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(139, 44)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(281, 27)
        Me.txtNombre.TabIndex = 5
        '
        'GrpDireccion
        '
        Me.GrpDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpDireccion.Controls.Add(Me.txtColonia)
        Me.GrpDireccion.Controls.Add(Me.txtNumero)
        Me.GrpDireccion.Controls.Add(Me.txtCalle)
        Me.GrpDireccion.Controls.Add(Me.lblCalle)
        Me.GrpDireccion.Controls.Add(Me.lblColonia)
        Me.GrpDireccion.Controls.Add(Me.lblNumero)
        Me.GrpDireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GrpDireccion.ForeColor = System.Drawing.Color.White
        Me.GrpDireccion.Location = New System.Drawing.Point(478, 173)
        Me.GrpDireccion.Name = "GrpDireccion"
        Me.GrpDireccion.Size = New System.Drawing.Size(448, 297)
        Me.GrpDireccion.TabIndex = 6
        Me.GrpDireccion.TabStop = False
        Me.GrpDireccion.Text = "Dirección"
        '
        'txtColonia
        '
        Me.txtColonia.Location = New System.Drawing.Point(105, 223)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(281, 27)
        Me.txtColonia.TabIndex = 8
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(105, 130)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(97, 27)
        Me.txtNumero.TabIndex = 7
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(105, 44)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(281, 27)
        Me.txtCalle.TabIndex = 6
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(50, 47)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(50, 20)
        Me.lblCalle.TabIndex = 2
        Me.lblCalle.Text = "Calle: "
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(32, 230)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(69, 20)
        Me.lblColonia.TabIndex = 4
        Me.lblColonia.Text = "Colonia: "
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(29, 133)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(74, 20)
        Me.lblNumero.TabIndex = 3
        Me.lblNumero.Text = "Número: "
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(208, 488)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(171, 65)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(625, 488)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(171, 65)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'RegistroDistribuidores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(938, 565)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.GrpDireccion)
        Me.Controls.Add(Me.GrpNombre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistroDistribuidores"
        Me.Text = "RegistroDistribuidores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpNombre.ResumeLayout(False)
        Me.GrpNombre.PerformLayout()
        Me.GrpDireccion.ResumeLayout(False)
        Me.GrpDireccion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellidoPaterno As Label
    Friend WithEvents lblApellidoMaterno As Label
    Friend WithEvents GrpNombre As GroupBox
    Friend WithEvents txtApellidoM As TextBox
    Friend WithEvents txtApellidoP As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents GrpDireccion As GroupBox
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents lblCalle As Label
    Friend WithEvents lblColonia As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnLimpiar As Button
End Class
