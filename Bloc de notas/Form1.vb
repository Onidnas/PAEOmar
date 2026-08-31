Imports System.IO


Public Class Form1

    Private rutaActual As String = String.Empty
    Private documentoModificado As Boolean = False


    Private Sub tmrRelog_Tick(sender As Object, e As EventArgs) Handles tmrRelog.Tick
        stsFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss")
    End Sub

    Private Sub ActualizarBarraEstado()
        Dim linea As Integer = rtbDocumento.GetLineFromCharIndex(rtbDocumento.SelectionStart) + 1
        Dim inicioLinea As Integer = rtbDocumento.GetFirstCharIndexOfCurrentLine()
        Dim columna As Integer = rtbDocumento.SelectionStart - inicioLinea + 1

        stsPosicion.Text = $"Linea: {linea} Columna: {columna}"
        stsCaracteres.Text = $"Caracteres: {rtbDocumento.TextLength}"
        stsZoom.Text = $"Zoom: {CInt(rtbDocumento.ZoomFactor * 100)}%"
        stsEstado.Text = If(documentoModificado, "Modificado", "Listo")
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Configuracion inicial del Rich Text Box

        rtbDocumento.Font = New Font("Consolas", 11)
        rtbDocumento.WordWrap = True
        mnuAjusteDeLinea.Checked = True
        'Cbciguracion de La combo box de Consolas
        tsbcFuente.Items.AddRange(New String() {"Segoe UI", "Consolas", "Arial", "Times New Roman"})
        tsbcFuente.SelectedIndex = 1
        tsbcTamanio.Items.AddRange(New String() {"8", "10", "12", "14", "18", "24"})
        tsbcTamanio.SelectedIndex = 2

        ActualizarBarraEstado()
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
    End Sub
    Private Sub rtbDocumento_TextChanged(sender As Object, e As EventArgs) Handles rtbDocumento.TextChanged
        documentoModificado = True
        ActualizarBarraEstado()
    End Sub

    Private Sub rtbDocumento_SelectionChanged(sender As Object, e As EventArgs) Handles rtbDocumento.SelectionChanged
        ActualizarBarraEstado()
    End Sub
    'Funciones Auxiliares

    Private Sub NuevoDocumento()
        If documentoModificado Then
            Dim r = MessageBox.Show("Desea guardar los cambios antes de continuar?",
                            "Bloc de Notas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If r = DialogResult.Cancel Then Exit Sub
            If r = DialogResult.Yes Then GuardarDocumento(False)
        End If
        rtbDocumento.Clear()
        rutaActual = String.Empty
        documentoModificado = False
        Me.Text = "Bloc de Notas VB.NET - [Nuevo Documento]"
        ActualizarBarraEstado()
    End Sub

    Private Sub AbrirDocumento()
        If dlgAbrir.ShowDialog() = DialogResult.OK Then
            rtbDocumento.LoadFile(dlgAbrir.FileName, RichTextBoxStreamType.PlainText)
            rutaActual = dlgAbrir.FileName
            documentoModificado = False
            Me.Text = $"Bloc de Notas VB.NET - [{Path.GetFileName(rutaActual)}]"
            ActualizarBarraEstado()
        End If
    End Sub

    Private Sub GuardarDocumento(forzarDialogo As Boolean)
        If String.IsNullOrEmpty(rutaActual) OrElse forzarDialogo Then
            If dlgGuardar.ShowDialog() = DialogResult.OK Then
                rutaActual = dlgGuardar.FileName
            Else
                Exit Sub
            End If
        End If

        rtbDocumento.SaveFile(rutaActual, RichTextBoxStreamType.PlainText)
        documentoModificado = False
        Me.Text = $"Bloc de Notas VB.NET - [{Path.GetFileName(rutaActual)}]"
        stsEstado.Text = "Guardado correctamente"
    End Sub
    'Context MenuStrip
    Private Sub cmsTexto_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsTexto.Opening
        Dim haySeleccion As Boolean = rtbDocumento.SelectionLength > 0
        cmsCopiar.Enabled = haySeleccion
        cmsCortar.Enabled = haySeleccion
        cmsPegar.Enabled = Clipboard.ContainsText()

    End Sub

    Private Sub cmsCortar_Click(sender As Object, e As EventArgs) Handles cmsCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub cmsCopiar_Click(sender As Object, e As EventArgs) Handles cmsCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub cmsPegar_Click(sender As Object, e As EventArgs) Handles cmsPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub cmsSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles cmsSeleccionarTodo.Click
        rtbDocumento.SelectAll()
    End Sub

    Private Sub cmsFuente_Click(sender As Object, e As EventArgs) Handles cmsFuente.Click
        dlgFuente.Font = rtbDocumento.SelectionFont
        If dlgFuente.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionFont = dlgFuente.Font
        End If
    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub tsbAbrir_Click(sender As Object, e As EventArgs) Handles tsbAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        GuardarDocumento(False)
    End Sub

    Private Sub MnuCortar_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub MnuCopiar_Click(sender As Object, e As EventArgs) Handles mnuCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub MnuPegar_Click(sender As Object, e As EventArgs) Handles mnuPegamento.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub tsbCortar_Click(sender As Object, e As EventArgs) Handles tlsCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub tsbCopiar_Click(sender As Object, e As EventArgs) Handles tlsCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub tsbPegar_Click(sender As Object, e As EventArgs) Handles tlsPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub tsbNegrita_Click(sender As Object, e As EventArgs) Handles tsbNegrita.Click
        AplicarEstiloFuente(FontStyle.Bold)
    End Sub

    Private Sub tsbCursiva_Click(sender As Object, e As EventArgs) Handles tsbCursiva.Click
        AplicarEstiloFuente(FontStyle.Italic)
    End Sub

    Private Sub tsbSubrayado_Click(sender As Object, e As EventArgs) Handles tsbSub.Click
        AplicarEstiloFuente(FontStyle.Underline)
    End Sub

    Private Sub tscbFuente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tsbcFuente.SelectedIndexChanged
        Dim tamano As Single = rtbDocumento.SelectionFont.Size
        rtbDocumento.SelectionFont = New Font(tsbcFuente.Text, tamano, rtbDocumento.SelectionFont.Style)
    End Sub

    Private Sub tscbTamano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tsbcTamanio.SelectedIndexChanged
        Dim tam As Single = Convert.ToSingle(tsbcTamanio.Text)
        rtbDocumento.SelectionFont = New Font(rtbDocumento.SelectionFont.FontFamily, tam, rtbDocumento.SelectionFont.Style)
    End Sub

    ' Combina o quita un estilo de fuente sobre el texto seleccionado
    Private Sub AplicarEstiloFuente(estilo As FontStyle)
        Dim fuenteActual As Font = rtbDocumento.SelectionFont
        If fuenteActual Is Nothing Then Exit Sub
        Dim nuevoEstilo As FontStyle
        If fuenteActual.Style.HasFlag(estilo) Then
            nuevoEstilo = fuenteActual.Style And Not estilo
        Else
            nuevoEstilo = fuenteActual.Style Or estilo
        End If
        rtbDocumento.SelectionFont = New Font(fuenteActual, nuevoEstilo)
    End Sub

    Private Sub mnuPrincipal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuPrincipal.ItemClicked
        mnuPrincipal.Visible = True
    End Sub
End Class