Imports System.Data.OleDb
Imports System.Data.SQLite
Imports Hangman.Program


Public Class FScores


    Dim pathDB As String = Application.StartupPath + "\Hangman.mdb"
    Public dataSet As DataSet
    Dim connection As OleDbConnection
    'Dim dataAdapterList() As OleDbDataAdapter 'Si hay varias tablas en la misma BD
    Public dataAdapterScores As OleDbDataAdapter
    'Dim cbScores As OleDbCommandBuilder  'No es necesario si no voy a actualizar
    Private Sub FScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPuntuacion()

    End Sub
    Public Sub CargarPuntuacion()  'Modo desconectado
        Try
            'Creamos objeto conexión y lo definimos
            connection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & pathDB)

            dataSet = New DataSet

            'Nos conectamos
            connection.Open()

            'Recuperamos en el DataAdapter la tabla Words de la BD
            dataAdapterScores = New OleDbDataAdapter("SELECT * FROM Scores ORDER BY GameDate DESC", connection)

            'Rellenamos el DataSet con la info creando una tabla Scores
            dataAdapterScores.Fill(dataSet, "Scores")

            'Asignamos los datos a DGVSores
            DGVScores.DataSource = dataSet.Tables("Scores")
            DGVScores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

            '' Si hay datos, asignarlos al DataGridView,  - INDICAMOS SI LA TABLA ESTA VACIA
            'If dataSet.Tables.Contains("Scores") AndAlso dataSet.Tables("Scores").Rows.Count > 0 Then
            '    DGVScores.DataSource = dataSet.Tables("Scores")
            '    DGVScores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            'Else
            'MessageBox.Show("No hay registros de puntuaciones.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If

            'Nos desconectamos
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar palabras: " & ex.Message)
        End Try
    End Sub

    Private Sub BtbFailsSort_Click(sender As Object, e As EventArgs) Handles BtbFailsSort.Click
        Dim dataView As New DataView(dataSet.Tables("Scores"))
        dataView.Sort = "Fails ASC" ' Ordenar ascendente por Fallos
        DGVScores.DataSource = dataView 'Mostrar tabla
    End Sub

    Private Sub BtnTimeSort_Click(sender As Object, e As EventArgs) Handles BtnTimeSort.Click
        Dim dataView As New DataView(dataSet.Tables("Scores"))
        dataView.Sort = "GameDate ASC" ' Ordenar ascendente por tiempo
        DGVScores.DataSource = dataView 'Mostrar tabla
    End Sub

    Private Sub BtnTodaySort_Click(sender As Object, e As EventArgs) Handles BtnTodaySort.Click
        Dim dataView As New DataView(dataSet.Tables("Scores"))
        Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")
        dataView.RowFilter = "GameDate = #" & today & "#"
        DGVScores.DataSource = dataView 'Mostrar tabla
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Dim dataView As New DataView(dataSet.Tables("Scores"))
        dataView.Sort = "GameDate DESC" ' Ordenar ascendente por Fallos
        DGVScores.DataSource = dataView 'Mostrar tabla
    End Sub
End Class