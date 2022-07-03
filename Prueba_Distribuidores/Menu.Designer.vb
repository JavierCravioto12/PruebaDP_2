<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PanelSubmenu = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BtnConsultaDistribuidores = New System.Windows.Forms.Button()
        Me.BtnRegistroDistribuidores = New System.Windows.Forms.Button()
        Me.BtnSubmenuDistribuidores = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelFondo = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelLateral.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSubmenu.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLateral
        '
        Me.PanelLateral.AutoScroll = True
        Me.PanelLateral.BackColor = System.Drawing.SystemColors.Desktop
        Me.PanelLateral.Controls.Add(Me.PictureBox3)
        Me.PanelLateral.Controls.Add(Me.PanelSubmenu)
        Me.PanelLateral.Controls.Add(Me.BtnSubmenuDistribuidores)
        Me.PanelLateral.Controls.Add(Me.PanelLogo)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(250, 640)
        Me.PanelLateral.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 104)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PanelSubmenu
        '
        Me.PanelSubmenu.BackColor = System.Drawing.Color.Gray
        Me.PanelSubmenu.Controls.Add(Me.PictureBox5)
        Me.PanelSubmenu.Controls.Add(Me.PictureBox4)
        Me.PanelSubmenu.Controls.Add(Me.BtnConsultaDistribuidores)
        Me.PanelSubmenu.Controls.Add(Me.BtnRegistroDistribuidores)
        Me.PanelSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubmenu.Location = New System.Drawing.Point(0, 143)
        Me.PanelSubmenu.Name = "PanelSubmenu"
        Me.PanelSubmenu.Size = New System.Drawing.Size(250, 91)
        Me.PanelSubmenu.TabIndex = 1
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(30, 42)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(30, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 31)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'BtnConsultaDistribuidores
        '
        Me.BtnConsultaDistribuidores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnConsultaDistribuidores.FlatAppearance.BorderSize = 0
        Me.BtnConsultaDistribuidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultaDistribuidores.ForeColor = System.Drawing.Color.White
        Me.BtnConsultaDistribuidores.Location = New System.Drawing.Point(0, 40)
        Me.BtnConsultaDistribuidores.Name = "BtnConsultaDistribuidores"
        Me.BtnConsultaDistribuidores.Padding = New System.Windows.Forms.Padding(65, 0, 0, 0)
        Me.BtnConsultaDistribuidores.Size = New System.Drawing.Size(250, 40)
        Me.BtnConsultaDistribuidores.TabIndex = 2
        Me.BtnConsultaDistribuidores.Text = "Consulta Distribuidores"
        Me.BtnConsultaDistribuidores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsultaDistribuidores.UseVisualStyleBackColor = True
        '
        'BtnRegistroDistribuidores
        '
        Me.BtnRegistroDistribuidores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegistroDistribuidores.FlatAppearance.BorderSize = 0
        Me.BtnRegistroDistribuidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistroDistribuidores.ForeColor = System.Drawing.Color.White
        Me.BtnRegistroDistribuidores.Location = New System.Drawing.Point(0, 0)
        Me.BtnRegistroDistribuidores.Name = "BtnRegistroDistribuidores"
        Me.BtnRegistroDistribuidores.Padding = New System.Windows.Forms.Padding(65, 0, 0, 0)
        Me.BtnRegistroDistribuidores.Size = New System.Drawing.Size(250, 40)
        Me.BtnRegistroDistribuidores.TabIndex = 1
        Me.BtnRegistroDistribuidores.Text = "Registro Distribuidores"
        Me.BtnRegistroDistribuidores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistroDistribuidores.UseVisualStyleBackColor = True
        '
        'BtnSubmenuDistribuidores
        '
        Me.BtnSubmenuDistribuidores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSubmenuDistribuidores.FlatAppearance.BorderSize = 0
        Me.BtnSubmenuDistribuidores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnSubmenuDistribuidores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSubmenuDistribuidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmenuDistribuidores.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnSubmenuDistribuidores.Location = New System.Drawing.Point(0, 98)
        Me.BtnSubmenuDistribuidores.Name = "BtnSubmenuDistribuidores"
        Me.BtnSubmenuDistribuidores.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnSubmenuDistribuidores.Size = New System.Drawing.Size(250, 45)
        Me.BtnSubmenuDistribuidores.TabIndex = 1
        Me.BtnSubmenuDistribuidores.Text = "Distribuidores"
        Me.BtnSubmenuDistribuidores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSubmenuDistribuidores.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(250, 98)
        Me.PanelLogo.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Prueba_Distribuidores.My.Resources.Resources.logo200x200
        Me.PictureBox1.Location = New System.Drawing.Point(67, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PanelFondo
        '
        Me.PanelFondo.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PanelFondo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFondo.Location = New System.Drawing.Point(250, 565)
        Me.PanelFondo.Name = "PanelFondo"
        Me.PanelFondo.Size = New System.Drawing.Size(938, 75)
        Me.PanelFondo.TabIndex = 1
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelContenedor.Controls.Add(Me.PictureBox2)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(250, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(938, 565)
        Me.PanelContenedor.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Prueba_Distribuidores.My.Resources.Resources.dportenis_logo_png_transparent
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(938, 565)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 640)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelFondo)
        Me.Controls.Add(Me.PanelLateral)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Distribuidores"
        Me.PanelLateral.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSubmenu.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLateral As Panel
    Friend WithEvents PanelSubmenu As Panel
    Friend WithEvents BtnConsultaDistribuidores As Button
    Friend WithEvents BtnRegistroDistribuidores As Button
    Friend WithEvents BtnSubmenuDistribuidores As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelFondo As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
