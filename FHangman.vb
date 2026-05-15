Imports System.Data.OleDb

Public Class FHangman
    ' Variables principales del juego
    Private PalabraAdivinar As String ' La palabra a adivinar, seleccionada aleatoriamente
    Private IntentosFallidos As Integer = 0 ' Contador de intentos fallidos
    Public MaxIntentos As Integer = 10 ' Intentos máximos permitidos
    Private LetrasDescubiertas As New List(Of Char) ' Lista de letras ya adivinadas correctamente
    Private fDictionary As New FDictionary()
    Private TiempoRestante As Integer = 60 ' Por ejemplo, 60 segundos
    Private FScores As New FScores
    'Ruta de la base de datos
    Dim pathDB As String = Application.StartupPath + "\Hangman.mdb"
    Dim ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathDB
    Private Sub FHangman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fDictionary.CargarDatos()
        FScores.CargarPuntuacion() 'Llama a la función para que haga la conexión
        ConfigurarBotonesLetras()
        ActualizarContador()

    End Sub

    'Configuración de botones de letras en el FlowLayoutPanel (FLPAbecedario)
    Private Sub ConfigurarBotonesLetras()
        Dim abecedario As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        For Each letra As Char In abecedario
            Dim btnLetra As New Button()
            btnLetra.Text = letra.ToString()

            btnLetra.Width = 30
            btnLetra.Height = 30
            btnLetra.Tag = letra ' Guardar la letra como Tag
            btnLetra.Enabled = True
            AddHandler btnLetra.Click, AddressOf BtnLetra_Click 'event
            FLPAbecedario.Controls.Add(btnLetra)
        Next
    End Sub

    ' Evento clic de las letras
    Private Sub BtnLetra_Click(sender As Object, e As EventArgs)
        Dim btnLetra As Button = DirectCast(sender, Button)  'DirectCast convierte sender en botón para acceso a propiedades
        Dim letra As String = btnLetra.Text
        btnLetra.Enabled = False ' Deshabilitar el botón al ser usado

        ' Verificar si la letra está en la palabra
        If PalabraContieneLetra(letra) Then
            MostrarLetraEnPalabra(letra) ' Mostrar la letra en la palabra en pantalla
            LetrasDescubiertas.Add(Convert.ToChar(letra)) ' Agregar a letras descubiertas
        Else
            ProcesarIntentoFallido() 'Verifica si se ha ganado o perdido
        End If
        VerificarEstadoJuego() ' Verificar si se ha ganado o perdido
    End Sub

    ' Función para verificar si la palabra contiene la letra
    Private Function PalabraContieneLetra(letra As String) As Boolean
        Return PalabraAdivinar.Contains(letra)
    End Function

    'Mostrar letra en la palabra (reemplaza "_" con la letra correspondiente)
    Private Sub MostrarLetraEnPalabra(letra As String)
        ' Recorrer todos los labels en pnlPalabras para actualizar las letras correctas
        For i As Integer = 0 To PalabraAdivinar.Length - 1
            If PalabraAdivinar(i).ToString() = letra Then
                ' Actualizar el texto del Label en la posición correspondiente
                Dim lblLetra As Label = CType(FLPPalabras.Controls(i), Label)
                lblLetra.Text = letra
            End If
        Next
    End Sub

    'Actualizar la imagen del ahorcado
    Private Sub ActualizarImagenAhorcado()
        Dim imagenIndex As Integer = CInt((IntentosFallidos / MaxIntentos) * 10)
        Select Case imagenIndex
            Case 0
                PBHangman.Image = My.Resources.AHOR1
            Case 1
                PBHangman.Image = My.Resources.AHOR2
            Case 2
                PBHangman.Image = My.Resources.AHOR3
            Case 3
                PBHangman.Image = My.Resources.AHOR4
            Case 4
                PBHangman.Image = My.Resources.AHOR5
            Case 5
                PBHangman.Image = My.Resources.AHOR6
            Case 6
                PBHangman.Image = My.Resources.AHOR7
            Case 7
                PBHangman.Image = My.Resources.AHOR8
            Case 8
                PBHangman.Image = My.Resources.AHOR9
            Case Else
                PBHangman.Image = My.Resources.AHOR10
        End Select
    End Sub

    'Verificar el final de partida, gana o pierde 
    Private Sub VerificarEstadoJuego()
        If IntentosFallidos >= MaxIntentos Or TiempoRestante <= 0 Then
            TimerJuego.Stop()
            MessageBox.Show("Has perdido. La palabra era: " & PalabraAdivinar)
            GuardarPuntuacion()
            'ReiniciarJuego()
        ElseIf TodasLetrasDescubiertas() Then
            TimerJuego.Stop()
            MessageBox.Show("¡Has ganado!")
            GuardarPuntuacion()
            'ReiniciarJuego()
        End If
    End Sub

    'Comprobar si todas las letras han sido descubiertas
    Private Function TodasLetrasDescubiertas() As Boolean
        For Each letra In PalabraAdivinar
            If Not LetrasDescubiertas.Contains(letra) Then
                Return False
            End If
        Next
        Return True
    End Function

    'Iniciar un nuevo juego, carga las tablas de la BD, para obtener palabra aleatoria
    Public Sub IniciarNuevoJuego()
        fDictionary.CargarDatos()
        PalabraAdivinar = ObtenerPalabraAleatoria()
        If PalabraAdivinar = "Error" Then
            MessageBox.Show("No se pudo cargar una palabra. Revisa la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        TiempoRestante = 60
        lblTiempo.Text = "Tiempo: " & TiempoRestante & " s"
        IntentosFallidos = 0
        LetrasDescubiertas.Clear()

        ' Reiniciar botones de letras
        For Each control As Control In FLPAbecedario.Controls
            If TypeOf control Is Button Then
                Dim btn As Button = CType(control, Button)
                btn.Enabled = True
                btn.BackColor = SystemColors.Control
            End If
        Next
        MostrarPalabraOculta()
        ActualizarContador()
        ActualizarImagenAhorcado()
        TimerJuego.Start()
    End Sub

    ' Mostrar la palabra oculta con guiones bajos
    Private Sub MostrarPalabraOculta()
        ' Limpiar el Panel antes de agregar nuevos Labels
        FLPPalabras.Controls.Clear()

        ' SALIDA: PalabraAdivinar 
        Debug.Print("Palabra a adivinar: " & PalabraAdivinar & " (Longitud: " & PalabraAdivinar.Length & ")")

        ' Crear un Label por cada letra de la palabra
        For Each letra As Char In PalabraAdivinar
            Dim lblLetra As New Label()
            lblLetra.Text = "_"
            lblLetra.Font = New Font("Arial", 18, FontStyle.Bold)
            lblLetra.Width = 30
            lblLetra.Height = 30
            lblLetra.TextAlign = ContentAlignment.MiddleCenter
            lblLetra.Margin = New Padding(2)
            lblLetra.Tag = letra ' Guarda la letra real en el Tag para después verificarla
            FLPPalabras.Controls.Add(lblLetra)

            ' SALIDA: confirmar que se está creando cada Label
            Debug.Print("Label creado para letra: " & letra)
        Next
    End Sub

    ' Actualizar el contador de intentos restantes
    Private Sub ActualizarContador()
        lblContador.Text = MaxIntentos - IntentosFallidos
    End Sub

    'Posición donde nos colola la imagen de la pista
    Private Sub MostrarPista()
        If Me.Controls.ContainsKey("PBTip") Then Exit Sub

        Dim PBTip As New PictureBox()
        PBTip.Name = "PBTip"
        PBTip.Size = New Size(50, 50)
        PBTip.Image = My.Resources.tip
        PBTip.SizeMode = PictureBoxSizeMode.StretchImage
        Dim x As Integer = PBHangman.Right + 20 ' A la derecha del ahorcado
        Dim y As Integer = lblContador.Top + 10 'Vertical de lblContador y 10 pix debajo
        PBTip.Location = New Point(x, y)

        AddHandler PBTip.Click, AddressOf PBTip_Click
        Me.Controls.Add(PBTip)
    End Sub

    'Event del PBTip nos muestra de pista la primera letra oculta y desaparece logo
    Private Sub PBTip_Click(sender As Object, e As EventArgs)
        ' Buscar la primera letra oculta en la palabra y revelarla
        For i As Integer = 0 To PalabraAdivinar.Length - 1
            Dim lblLetra As Label = CType(FLPPalabras.Controls(i), Label)

            ' Si el Label aún muestra un guion bajo, revela la letra
            If lblLetra.Text = "_" Then
                Dim letraOculta As Char = PalabraAdivinar(i)
                lblLetra.Text = letraOculta.ToString()
                LetrasDescubiertas.Add(letraOculta) ' Agregar la letra revelada a la lista de letras descubiertas
                Exit For
            End If
        Next

        ' Eliminar el PictureBox después de usar la pista
        Dim PBTip As PictureBox = CType(sender, PictureBox)
        Me.Controls.Remove(PBTip)
        PBTip.Dispose()
    End Sub

    'Cada fallo, actualiza el contador y la imagen.
    'Cuando los quedan 5 intentos nos muestra pista, para utilizarla cuando queramos 
    Public Sub ProcesarIntentoFallido()
        IntentosFallidos += 1
        ActualizarContador() ' Llama al contador para actualizar los intentos restantes
        ActualizarImagenAhorcado() ' Actualiza la imagen del ahorcado
        If IntentosFallidos = 5 Then
            MessageBox.Show("Puedes pedir una pista, pulsando 'TIP'")
            MostrarPista()
        End If

    End Sub

    'Obtiene la palabra aleatoria de la tabla Words, de Dictionary
    Private Function ObtenerPalabraAleatoria() As String
        Dim palabra As String = ""
        Try
            ' Verificar si el DataGridView y la tabla tienen datos
            If fDictionary Is Nothing OrElse fDictionary.DGVWords Is Nothing OrElse fDictionary.DGVWords.Rows.Count = 0 Then
                MessageBox.Show("No hay palabras en el diccionario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return "ERROR"
            End If
            ' Generar un índice aleatorio basado en el número de filas disponibles
            Dim rand As New Random()
            Dim index As Integer = rand.Next(0, fDictionary.DGVWords.Rows.Count)

            ' Obtener la palabra aleatoria desde la celda correcta y que no sea Nothing
            Dim cellValue As Object = fDictionary.DGVWords.Rows(index).Cells("Word").Value
            If cellValue IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cellValue.ToString()) Then
                palabra = cellValue.ToString().ToUpper()
            Else
                MessageBox.Show("Error: La celda seleccionada está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                palabra = "ERROR"
            End If

        Catch ex As Exception
            MessageBox.Show("Error al obtener palabra aleatoria: " & ex.Message)
            palabra = "ERROR"
        End Try

        Return palabra
    End Function

    'Guardar puntuación en la tabla Scores de la BD, en MODO CONECTADO
    'Private Sub GuardarPuntuacion()
    '    Dim con As New OleDbConnection(ConnectionString)
    '    Try
    '        ' Pedir el nombre del jugador
    '        Dim playerName As String = InputBox("Ingresa tu nombre:", "Guardar Puntuación", "Jugador")
    '        con.Open()
    '        Dim cmd As New OleDbCommand("INSERT INTO Scores (PlayerName, GameDate, Fails, GameTime) VALUES (?,?,?,?)", con)
    '        cmd.Parameters.AddWithValue("@PlayerName", playerName)
    '        cmd.Parameters.AddWithValue("@GameDate", DateTime.Now.ToString("yyyy-MM-dd"))
    '        cmd.Parameters.AddWithValue("@Fails", CInt(IntentosFallidos))
    '        cmd.Parameters.AddWithValue("@GameTime", CInt(60 - TiempoRestante))
    '        cmd.ExecuteNonQuery()
    '        con.Close()
    '        MessageBox.Show("Puntuación guardada correctamente")
    '        FScores.CargarPuntuacion()
    '    Catch ex As Exception
    '        MessageBox.Show("Error al guardar puntuación: " & ex.Message)
    '    End Try
    'End Sub

    Private Sub GuardarPuntuacion()  'En MODO DESCONECTADO utilizando FScores
        Try
            ' Pedir el nombre del jugador
            Dim playerName As String = InputBox("Ingresa tu nombre:", "Guardar Puntuación", "Jugador")

            ' Crear una nueva fila en el DataSet
            Dim nuevaFila As DataRow = FScores.dataSet.Tables("Scores").NewRow()
            nuevaFila("PlayerName") = playerName
            nuevaFila("GameDate") = DateTime.Now.ToString("yyyy-MM-dd")
            nuevaFila("Fails") = CInt(IntentosFallidos)
            nuevaFila("GameTime") = CInt(60 - TiempoRestante)

            ' Agregar la fila al DataSet
            FScores.dataSet.Tables("Scores").Rows.Add(nuevaFila)

            ' Aplicar los cambios en la base de datos
            Dim cbScores As New OleDbCommandBuilder(FScores.dataAdapterScores)
            FScores.dataAdapterScores.Update(FScores.dataSet, "Scores")

            MessageBox.Show("Puntuación guardada correctamente")

            ' Refrescar DataGridView
            FScores.DGVScores.DataSource = FScores.dataSet.Tables("Scores")

        Catch ex As Exception
            MessageBox.Show("Error al guardar puntuación: " & ex.Message)
        End Try
    End Sub

    '' Reiniciar el juego (no lo utlizamos porque iniciamos desde NewGame)
    'Private Sub ReiniciarJuego()
    '    ' IniciarNuevoJuego()
    'End Sub

    'Salir del juego
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    'Accede a Level 
    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        FLevel.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FName.ShowDialog()
    End Sub

    Private Sub HowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToolStripMenuItem.Click
        FHowToPlay.ShowDialog()
    End Sub

    'Tiempo de inicio juego, que va descontando y muestra el restante
    Private Sub TimerJuego_Tick(sender As Object, e As EventArgs) Handles TimerJuego.Tick
        TiempoRestante -= 1
        ' Actualiza una etiqueta para mostrar el tiempo restante
        lblTiempo.Text = "Tiempo: " & TiempoRestante & " s"
        VerificarEstadoJuego()
    End Sub

    Private Sub ScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScoresToolStripMenuItem.Click
        FScores.ShowDialog()
    End Sub

    Private Sub DictionaryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DictionaryToolStripMenuItem1.Click
        fDictionary.ShowDialog()
    End Sub
End Class





