﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRubro
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
        Me.ToolStripMenu = New System.Windows.Forms.ToolStrip()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.CtlComboRubroMaestro = New Principal.CtlCustomCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ToolStripMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripMenu
        '
        Me.ToolStripMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnGuardar, Me.BtnCancelar})
        Me.ToolStripMenu.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMenu.Name = "ToolStripMenu"
        Me.ToolStripMenu.Size = New System.Drawing.Size(488, 25)
        Me.ToolStripMenu.TabIndex = 0
        Me.ToolStripMenu.Text = "ToolStrip1"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.Principal.My.Resources.Resources.disk
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(95, 22)
        Me.BtnGuardar.Text = "Guardar [F12]"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Principal.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 22)
        Me.BtnCancelar.Text = "Cancelar [Esc]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Descripción"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxId
        '
        Me.TextBoxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxId.Location = New System.Drawing.Point(105, 42)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(63, 20)
        Me.TextBoxId.TabIndex = 0
        Me.TextBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(105, 93)
        Me.TextBoxNombre.MaxLength = 80
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(371, 20)
        Me.TextBoxNombre.TabIndex = 2
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(105, 150)
        Me.TextBoxDescripcion.MaxLength = 255
        Me.TextBoxDescripcion.Multiline = True
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(371, 60)
        Me.TextBoxDescripcion.TabIndex = 4
        '
        'CtlComboRubroMaestro
        '
        Me.CtlComboRubroMaestro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CtlComboRubroMaestro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CtlComboRubroMaestro.BusquedaPorCodigobarra = False
        Me.CtlComboRubroMaestro.ColumnasExtras = Nothing
        Me.CtlComboRubroMaestro.CustomFormatArt = False
        Me.CtlComboRubroMaestro.DataSource = Nothing
        Me.CtlComboRubroMaestro.DisplayMember = Nothing
        Me.CtlComboRubroMaestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CtlComboRubroMaestro.FormularioDeAlta = Nothing
        Me.CtlComboRubroMaestro.FormularioDeBusqueda = Nothing
        Me.CtlComboRubroMaestro.Location = New System.Drawing.Point(105, 119)
        Me.CtlComboRubroMaestro.MaximumSize = New System.Drawing.Size(500, 25)
        Me.CtlComboRubroMaestro.MinimumSize = New System.Drawing.Size(200, 25)
        Me.CtlComboRubroMaestro.Name = "CtlComboRubroMaestro"
        Me.CtlComboRubroMaestro.SelectedIndex = -1
        Me.CtlComboRubroMaestro.SelectedItem = Nothing
        Me.CtlComboRubroMaestro.SelectedText = ""
        Me.CtlComboRubroMaestro.SelectedValue = Nothing
        Me.CtlComboRubroMaestro.Size = New System.Drawing.Size(371, 25)
        Me.CtlComboRubroMaestro.TabIndex = 3
        Me.CtlComboRubroMaestro.ValueMember = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Rubro Maestro"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCodigo.Location = New System.Drawing.Point(105, 67)
        Me.TextBoxCodigo.MaxLength = 3
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(63, 20)
        Me.TextBoxCodigo.TabIndex = 1
        Me.TextBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(56, 70)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Código"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormRubro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(488, 227)
        Me.Controls.Add(Me.TextBoxCodigo)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.CtlComboRubroMaestro)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStripMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FormRubro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormArticulo"
        Me.ToolStripMenu.ResumeLayout(False)
        Me.ToolStripMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxId As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents CtlComboRubroMaestro As Principal.CtlCustomCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
