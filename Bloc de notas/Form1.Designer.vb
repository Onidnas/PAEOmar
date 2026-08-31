<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        mnuPrincipal = New MenuStrip()
        GuardarToolStripMenuItem = New ToolStripMenuItem()
        mnuNuevo = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        mnuAjusteDeLinea = New ToolStripMenuItem()
        tlsCortar = New ToolStripMenuItem()
        tlsCopiar = New ToolStripMenuItem()
        tlsPegar = New ToolStripMenuItem()
        tsPrincipal = New ToolStrip()
        tsbNuevo = New ToolStripButton()
        tsbAbrir = New ToolStripButton()
        tsbGuardar = New ToolStripButton()
        tsbNegrita = New ToolStripButton()
        tsbCursiva = New ToolStripButton()
        tsbSub = New ToolStripButton()
        mnuCut = New ToolStripButton()
        mnuPegamento = New ToolStripButton()
        mnuCopiar = New ToolStripButton()
        tsbcTamanio = New ToolStripComboBox()
        tsbcFuente = New ToolStripComboBox()
        rtbDocumento = New RichTextBox()
        cmsTexto = New ContextMenuStrip(components)
        cmsCortar = New ToolStripMenuItem()
        cmsCopiar = New ToolStripMenuItem()
        cmsPegar = New ToolStripMenuItem()
        cmsFuente = New ToolStripMenuItem()
        cmsSeleccionarTodo = New ToolStripMenuItem()
        stsInferior = New StatusStrip()
        stsEstado = New ToolStripStatusLabel()
        stsPosicion = New ToolStripStatusLabel()
        stsCaracteres = New ToolStripStatusLabel()
        stsFechaHora = New ToolStripStatusLabel()
        stsZoom = New ToolStripStatusLabel()
        dlgAbrir = New OpenFileDialog()
        dlgGuardar = New SaveFileDialog()
        dlgFuente = New FontDialog()
        dlgColor = New ColorDialog()
        tmrRelog = New Timer(components)
        mnuPrincipal.SuspendLayout()
        tsPrincipal.SuspendLayout()
        cmsTexto.SuspendLayout()
        stsInferior.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuPrincipal
        ' 
        mnuPrincipal.BackColor = SystemColors.AppWorkspace
        mnuPrincipal.ImageScalingSize = New Size(24, 24)
        mnuPrincipal.Items.AddRange(New ToolStripItem() {GuardarToolStripMenuItem, mnuNuevo, SalirToolStripMenuItem, mnuAjusteDeLinea, tlsCortar, tlsCopiar, tlsPegar})
        mnuPrincipal.Location = New Point(0, 0)
        mnuPrincipal.Name = "mnuPrincipal"
        mnuPrincipal.Size = New Size(1087, 33)
        mnuPrincipal.TabIndex = 0
        mnuPrincipal.Text = "MenuStrip1"
        ' 
        ' GuardarToolStripMenuItem
        ' 
        GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        GuardarToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        GuardarToolStripMenuItem.Size = New Size(91, 29)
        GuardarToolStripMenuItem.Text = "&Guardar"
        ' 
        ' mnuNuevo
        ' 
        mnuNuevo.Name = "mnuNuevo"
        mnuNuevo.ShortcutKeys = Keys.Control Or Keys.N
        mnuNuevo.Size = New Size(80, 29)
        mnuNuevo.Text = "&Nuevo"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        SalirToolStripMenuItem.Size = New Size(61, 29)
        SalirToolStripMenuItem.Text = "&Salir"
        ' 
        ' mnuAjusteDeLinea
        ' 
        mnuAjusteDeLinea.Name = "mnuAjusteDeLinea"
        mnuAjusteDeLinea.Size = New Size(147, 29)
        mnuAjusteDeLinea.Text = "Ajuste de Linea"
        ' 
        ' tlsCortar
        ' 
        tlsCortar.Name = "tlsCortar"
        tlsCortar.ShortcutKeys = Keys.Control Or Keys.X
        tlsCortar.Size = New Size(77, 29)
        tlsCortar.Text = "Co&rtar"
        ' 
        ' tlsCopiar
        ' 
        tlsCopiar.Name = "tlsCopiar"
        tlsCopiar.ShortcutKeys = Keys.Control Or Keys.C
        tlsCopiar.Size = New Size(80, 29)
        tlsCopiar.Text = "&Copiar"
        ' 
        ' tlsPegar
        ' 
        tlsPegar.Name = "tlsPegar"
        tlsPegar.ShortcutKeys = Keys.Control Or Keys.V
        tlsPegar.Size = New Size(72, 29)
        tlsPegar.Text = "&Pegar"
        ' 
        ' tsPrincipal
        ' 
        tsPrincipal.BackColor = Color.Silver
        tsPrincipal.BackgroundImageLayout = ImageLayout.Zoom
        tsPrincipal.Dock = DockStyle.Bottom
        tsPrincipal.GripMargin = New Padding(5)
        tsPrincipal.GripStyle = ToolStripGripStyle.Hidden
        tsPrincipal.ImageScalingSize = New Size(24, 24)
        tsPrincipal.Items.AddRange(New ToolStripItem() {tsbNuevo, tsbAbrir, tsbGuardar, tsbNegrita, tsbCursiva, tsbSub, mnuCut, mnuPegamento, mnuCopiar, tsbcTamanio, tsbcFuente})
        tsPrincipal.Location = New Point(0, 414)
        tsPrincipal.Margin = New Padding(10)
        tsPrincipal.Name = "tsPrincipal"
        tsPrincipal.Size = New Size(1087, 36)
        tsPrincipal.TabIndex = 1
        ' 
        ' tsbNuevo
        ' 
        tsbNuevo.BackColor = Color.LightGray
        tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNuevo.Font = New Font("Sitka Display Semibold", 10.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        tsbNuevo.ForeColor = Color.Yellow
        tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), Image)
        tsbNuevo.ImageAlign = ContentAlignment.TopCenter
        tsbNuevo.ImageTransparentColor = Color.Magenta
        tsbNuevo.MergeAction = MergeAction.MatchOnly
        tsbNuevo.Name = "tsbNuevo"
        tsbNuevo.Size = New Size(34, 31)
        tsbNuevo.Text = "Nuevo"
        ' 
        ' tsbAbrir
        ' 
        tsbAbrir.BackColor = Color.Red
        tsbAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbAbrir.Image = CType(resources.GetObject("tsbAbrir.Image"), Image)
        tsbAbrir.ImageTransparentColor = Color.Magenta
        tsbAbrir.Name = "tsbAbrir"
        tsbAbrir.Size = New Size(34, 31)
        tsbAbrir.Text = "Abrir"
        ' 
        ' tsbGuardar
        ' 
        tsbGuardar.BackColor = Color.Yellow
        tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbGuardar.Font = New Font("Yu Gothic UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), Image)
        tsbGuardar.ImageTransparentColor = Color.Magenta
        tsbGuardar.Name = "tsbGuardar"
        tsbGuardar.Size = New Size(34, 31)
        tsbGuardar.Text = "Guardar"
        ' 
        ' tsbNegrita
        ' 
        tsbNegrita.BackColor = Color.Yellow
        tsbNegrita.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbNegrita.Font = New Font("Segoe UI Black", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tsbNegrita.Image = CType(resources.GetObject("tsbNegrita.Image"), Image)
        tsbNegrita.ImageTransparentColor = Color.Magenta
        tsbNegrita.Name = "tsbNegrita"
        tsbNegrita.Size = New Size(34, 31)
        tsbNegrita.Text = "B"
        ' 
        ' tsbCursiva
        ' 
        tsbCursiva.BackColor = Color.Yellow
        tsbCursiva.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbCursiva.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        tsbCursiva.Image = CType(resources.GetObject("tsbCursiva.Image"), Image)
        tsbCursiva.ImageTransparentColor = Color.Magenta
        tsbCursiva.Name = "tsbCursiva"
        tsbCursiva.Size = New Size(34, 31)
        tsbCursiva.Text = "T"
        ' 
        ' tsbSub
        ' 
        tsbSub.BackColor = Color.Yellow
        tsbSub.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbSub.Font = New Font("Arial", 9.0F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        tsbSub.Image = CType(resources.GetObject("tsbSub.Image"), Image)
        tsbSub.ImageTransparentColor = Color.Magenta
        tsbSub.Name = "tsbSub"
        tsbSub.Size = New Size(34, 31)
        tsbSub.Text = "S"
        ' 
        ' mnuCut
        ' 
        mnuCut.DisplayStyle = ToolStripItemDisplayStyle.Image
        mnuCut.Image = CType(resources.GetObject("mnuCut.Image"), Image)
        mnuCut.ImageTransparentColor = Color.Magenta
        mnuCut.Name = "mnuCut"
        mnuCut.Size = New Size(34, 31)
        mnuCut.Text = "ToolStripButton1"
        ' 
        ' mnuPegamento
        ' 
        mnuPegamento.DisplayStyle = ToolStripItemDisplayStyle.Image
        mnuPegamento.Image = CType(resources.GetObject("mnuPegamento.Image"), Image)
        mnuPegamento.ImageTransparentColor = Color.Magenta
        mnuPegamento.Name = "mnuPegamento"
        mnuPegamento.Size = New Size(34, 31)
        mnuPegamento.Text = "ToolStripButton3"
        ' 
        ' mnuCopiar
        ' 
        mnuCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image
        mnuCopiar.Image = CType(resources.GetObject("mnuCopiar.Image"), Image)
        mnuCopiar.ImageTransparentColor = Color.Magenta
        mnuCopiar.Name = "mnuCopiar"
        mnuCopiar.Size = New Size(34, 31)
        mnuCopiar.Text = "ToolStripButton2"
        ' 
        ' tsbcTamanio
        ' 
        tsbcTamanio.BackColor = SystemColors.Info
        tsbcTamanio.FlatStyle = FlatStyle.System
        tsbcTamanio.Font = New Font("Segoe UI", 10.0F)
        tsbcTamanio.Name = "tsbcTamanio"
        tsbcTamanio.Size = New Size(81, 36)
        tsbcTamanio.Text = "Size"
        ' 
        ' tsbcFuente
        ' 
        tsbcFuente.BackColor = SystemColors.Info
        tsbcFuente.FlatStyle = FlatStyle.System
        tsbcFuente.Font = New Font("Segoe UI", 10.0F)
        tsbcFuente.Name = "tsbcFuente"
        tsbcFuente.Size = New Size(81, 36)
        tsbcFuente.Text = "Fuente"
        ' 
        ' rtbDocumento
        ' 
        rtbDocumento.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        rtbDocumento.BorderStyle = BorderStyle.None
        rtbDocumento.ContextMenuStrip = cmsTexto
        rtbDocumento.Font = New Font("Consolas", 11.0F)
        rtbDocumento.Location = New Point(0, 36)
        rtbDocumento.Name = "rtbDocumento"
        rtbDocumento.Size = New Size(1087, 339)
        rtbDocumento.TabIndex = 3
        rtbDocumento.Text = ""
        ' 
        ' cmsTexto
        ' 
        cmsTexto.ImageScalingSize = New Size(24, 24)
        cmsTexto.Items.AddRange(New ToolStripItem() {cmsCortar, cmsCopiar, cmsPegar, cmsFuente, cmsSeleccionarTodo})
        cmsTexto.Name = "cmsTexto"
        cmsTexto.Size = New Size(218, 164)
        ' 
        ' cmsCortar
        ' 
        cmsCortar.Name = "cmsCortar"
        cmsCortar.Size = New Size(217, 32)
        cmsCortar.Text = "Cortar"
        ' 
        ' cmsCopiar
        ' 
        cmsCopiar.Name = "cmsCopiar"
        cmsCopiar.Size = New Size(217, 32)
        cmsCopiar.Text = "Copiar"
        ' 
        ' cmsPegar
        ' 
        cmsPegar.Name = "cmsPegar"
        cmsPegar.Size = New Size(217, 32)
        cmsPegar.Text = "Pegar"
        ' 
        ' cmsFuente
        ' 
        cmsFuente.Name = "cmsFuente"
        cmsFuente.Size = New Size(217, 32)
        cmsFuente.Text = "Fuente"
        ' 
        ' cmsSeleccionarTodo
        ' 
        cmsSeleccionarTodo.Name = "cmsSeleccionarTodo"
        cmsSeleccionarTodo.Size = New Size(217, 32)
        cmsSeleccionarTodo.Text = "Seleccionar Todo"
        ' 
        ' stsInferior
        ' 
        stsInferior.ImageScalingSize = New Size(24, 24)
        stsInferior.Items.AddRange(New ToolStripItem() {stsEstado, stsPosicion, stsCaracteres, stsFechaHora, stsZoom})
        stsInferior.Location = New Point(0, 378)
        stsInferior.Name = "stsInferior"
        stsInferior.Size = New Size(1087, 36)
        stsInferior.TabIndex = 4
        stsInferior.Text = "StatusStrip1"
        ' 
        ' stsEstado
        ' 
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(66, 29)
        stsEstado.Text = "Estado"
        ' 
        ' stsPosicion
        ' 
        stsPosicion.BackgroundImage = CType(resources.GetObject("stsPosicion.BackgroundImage"), Image)
        stsPosicion.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        stsPosicion.BorderStyle = Border3DStyle.Adjust
        stsPosicion.Name = "stsPosicion"
        stsPosicion.Size = New Size(135, 29)
        stsPosicion.Text = "Cursor Column"
        ' 
        ' stsCaracteres
        ' 
        stsCaracteres.Name = "stsCaracteres"
        stsCaracteres.Size = New Size(93, 29)
        stsCaracteres.Text = "Caracteres"
        ' 
        ' stsFechaHora
        ' 
        stsFechaHora.Name = "stsFechaHora"
        stsFechaHora.Size = New Size(57, 29)
        stsFechaHora.Text = "Fecha"
        ' 
        ' stsZoom
        ' 
        stsZoom.Name = "stsZoom"
        stsZoom.Size = New Size(180, 29)
        stsZoom.Text = "ToolStripStatusLabel1"
        ' 
        ' dlgAbrir
        ' 
        dlgAbrir.FileName = "OpenFileDialog1"
        dlgAbrir.Filter = """Archivos de texto (*.txt)|*.txt|Todos (*.*)|*.*"""
        ' 
        ' dlgGuardar
        ' 
        dlgGuardar.DefaultExt = """txt"""
        dlgGuardar.FileName = "OpenFileDialog2"
        ' 
        ' dlgFuente
        ' 
        dlgFuente.ShowColor = True
        ' 
        ' dlgColor
        ' 
        dlgColor.FullOpen = True
        ' 
        ' tmrRelog
        ' 
        tmrRelog.Enabled = True
        tmrRelog.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1087, 450)
        Controls.Add(stsInferior)
        Controls.Add(tsPrincipal)
        Controls.Add(mnuPrincipal)
        Controls.Add(rtbDocumento)
        MainMenuStrip = mnuPrincipal
        MinimumSize = New Size(600, 400)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bloc de Notas -Visual.NET"
        WindowState = FormWindowState.Maximized
        mnuPrincipal.ResumeLayout(False)
        mnuPrincipal.PerformLayout()
        tsPrincipal.ResumeLayout(False)
        tsPrincipal.PerformLayout()
        cmsTexto.ResumeLayout(False)
        stsInferior.ResumeLayout(False)
        stsInferior.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents tsPrincipal As ToolStrip
    Friend WithEvents rtbDocumento As RichTextBox
    Friend WithEvents cmsTexto As ContextMenuStrip
    Friend WithEvents stsInferior As StatusStrip
    Friend WithEvents dlgAbrir As OpenFileDialog
    Friend WithEvents dlgGuardar As SaveFileDialog
    Friend WithEvents dlgFuente As FontDialog
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents tmrRelog As Timer
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbAbrir As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbNegrita As ToolStripButton
    Friend WithEvents tsbCursiva As ToolStripButton
    Friend WithEvents tsbSub As ToolStripButton
    Friend WithEvents tsbcTamanio As ToolStripComboBox
    Friend WithEvents tsbcFuente As ToolStripComboBox
    Friend WithEvents stsEstado As ToolStripStatusLabel
    Friend WithEvents stsPosicion As ToolStripStatusLabel
    Friend WithEvents stsCaracteres As ToolStripStatusLabel
    Friend WithEvents stsFechaHora As ToolStripStatusLabel
    Friend WithEvents stsZoom As ToolStripStatusLabel
    Friend WithEvents mnuNuevo As ToolStripMenuItem
    Friend WithEvents mnuCut As ToolStripButton
    Friend WithEvents mnuCopiar As ToolStripButton
    Friend WithEvents mnuPegamento As ToolStripButton
    Friend WithEvents tlsCortar As ToolStripMenuItem
    Friend WithEvents tlsCopiar As ToolStripMenuItem
    Friend WithEvents tlsPegar As ToolStripMenuItem
    Friend WithEvents cmsCortar As ToolStripMenuItem
    Friend WithEvents cmsCopiar As ToolStripMenuItem
    Friend WithEvents cmsPegar As ToolStripMenuItem
    Friend WithEvents cmsFuente As ToolStripMenuItem
    Friend WithEvents cmsSeleccionarTodo As ToolStripMenuItem
    Private WithEvents mnuAjusteDeLinea As ToolStripMenuItem

End Class
