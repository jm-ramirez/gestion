﻿
Public Class FormABMPersonal

    Private _repositorio As New CapaLogica.PersonalCLog
    Private _editForm As FormPersonal

    Private Sub MenuClick(ByVal sender As Object, ByVal e As EventArgs)
        Select Case DirectCast(sender, ToolStripButton).Name
            Case "BtnNuevo" : Nuevo()
            Case "BtnSalir" : Salir()
            Case "BtnImprimir" : Imprimir()
            Case "BtnEliminar" : Eliminar()
            Case "BtnEditar" : Editar()
            Case "BtnFiltrar" : Filtrar()
            Case "BtnBorrarFiltro" : BorrarFiltros()
        End Select
    End Sub

    Private Sub BorrarFiltros()
        Me.FOLVRegistros.ResetColumnFiltering()
    End Sub

    Private Sub Nuevo()
        _editForm = New FormPersonal
        _editForm.Entidad = Nothing

        If _editForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            PoblarGrilla()
            'Me.FOLVRegistros.RefreshObject(_editForm.Entidad)
            'ActualizarEstados()
        End If

    End Sub

    Private Sub Editar()
        If Not FOLVRegistros.SelectedObject Is Nothing Then

            _editForm = New FormPersonal
            _editForm.Entidad = DirectCast(Me.FOLVRegistros.SelectedObject, Entidades.Personal)

            If _editForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                PoblarGrilla()
                'Me.FOLVRegistros.RefreshObject(_editForm.Entidad)
                'ActualizarEstados()
            End If

        Else

            MessageBox.Show("Debe seleccionar un registro", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub

    Private Sub Eliminar()

        If Not FOLVRegistros.SelectedObject Is Nothing Then

            If MessageBox.Show("Desea eliminar el registro seleccionado?", "Eliminar registro", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                               MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                'Elimino el objeto seleccionado
                _repositorio.Delete(DirectCast(FOLVRegistros.SelectedObject, Entidades.Personal).Id)

                If _repositorio.HasError Then

                    MessageBox.Show(_repositorio.mensajes.ToString, "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else

                    FOLVRegistros.RemoveObject(FOLVRegistros.SelectedObject)

                    ActualizarEstados()

                    MessageBox.Show("El registro se ha eliminado", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If

        Else

            MessageBox.Show("Debe seleccionar un registro", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub

    Private Sub Salir()
        Me.Close()
    End Sub

    Private Sub Imprimir()
        Dim r As New GeneradorReportes.Reporte
        r.SourceFile = My.Settings.RutaReportes & "\lstPersonal.rdl"
        r.Nombre = "Listado de Personal"
        r.Parametros.Add(New GeneradorReportes.Parametro("titulo", "Listado de Personal"))
        r.ShowReport()
    End Sub

    Private Sub Filtrar()
        If Me.TextBoxFilter.TextLength = 0 Then
            Me.TextBoxFilter.Focus()
        Else
            'aplico el filtro
            Dim filter As BrightIdeasSoftware.TextMatchFilter = BrightIdeasSoftware.TextMatchFilter.Contains(FOLVRegistros, TextBoxFilter.Text)
            FOLVRegistros.ModelFilter = filter
            FOLVRegistros.DefaultRenderer = New BrightIdeasSoftware.HighlightTextRenderer(filter)
            ActualizarEstados()
        End If
    End Sub


    Private Sub InicializarFormulario()
        ConfigurarGrilla()
        PoblarGrilla()
    End Sub

    Private Sub ConfigurarGrilla()
        CrearColumnas()

        With FOLVRegistros
            .FullRowSelect = True
            .UseFiltering = True
        End With

    End Sub

    Private Sub PoblarGrilla()
        Me.FOLVRegistros.Objects = _repositorio.GetAll.OrderBy(Function(x) x.Nombre).ToList()
        Me.FOLVRegistros.AutoResizeColumns()
        ActualizarEstados()
    End Sub

    Private Sub ActualizarEstados()
        Me.StatusLabelRegistros.Text = "Nº de Registros: " & Me.FOLVRegistros.Items.Count
    End Sub

    Private Sub CrearColumnas()

        Dim c As BrightIdeasSoftware.OLVColumn

        With FOLVRegistros

            .Columns.Clear()

            c = New BrightIdeasSoftware.OLVColumn
            c.Text = "Id"
            c.AspectName = "Id"
            c.MinimumWidth = 35
            c.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
            .Columns.Add(c)

            c = New BrightIdeasSoftware.OLVColumn
            c.Text = "Nombre"
            c.AspectName = "Nombre"
            c.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
            .Columns.Add(c)

            c = New BrightIdeasSoftware.OLVColumn
            c.Text = "Teléfono"
            c.AspectName = "Telefono"
            c.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
            .Columns.Add(c)

            c = New BrightIdeasSoftware.OLVColumn
            c.Text = "Domicilio"
            c.AspectName = "Domicilio"
            c.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
            .Columns.Add(c)

            c = New BrightIdeasSoftware.OLVColumn
            c.Text = "Email"
            c.AspectName = "Email"
            c.FillsFreeSpace = True
            .Columns.Add(c)

        End With
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        AddHandler Me.BtnNuevo.Click, AddressOf MenuClick
        AddHandler Me.BtnSalir.Click, AddressOf MenuClick
        AddHandler Me.BtnImprimir.Click, AddressOf MenuClick
        AddHandler Me.BtnEliminar.Click, AddressOf MenuClick
        AddHandler Me.BtnEditar.Click, AddressOf MenuClick
        AddHandler Me.BtnBorrarFiltro.Click, AddressOf MenuClick
        AddHandler Me.BtnFiltrar.Click, AddressOf MenuClick
        AddHandler Me.Activated, AddressOf FormularioActivo
        AddHandler Me.KeyDown, AddressOf FormularioKeyDown
    End Sub

    Private Sub FormularioKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.F2 : Nuevo()
            Case Keys.Escape : Salir()
                'Case Keys.F5 : Imprimir()
            Case Keys.Delete : Eliminar()
            Case Keys.F3 : Editar()
            Case Keys.Return : SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub FormABMPersonal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InicializarFormulario()
    End Sub

    Private Sub FOLVRegistros_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FOLVRegistros.DoubleClick
        Editar()
    End Sub

    Private Sub FormularioActivo(ByVal sender As Object, ByVal e As EventArgs)
        Me.TextBoxFilter.Focus()
    End Sub

    Private Sub TextBoxFilter_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBoxFilter.TextChanged
        If Len(Trim(TextBoxFilter.Text)) = 0 Then
            BorrarFiltros()
        Else
            Filtrar()
        End If
        TextBoxFilter.Focus()
    End Sub

End Class