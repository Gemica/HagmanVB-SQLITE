Imports System.Data.OleDb

Public Class FDictionary
    Dim pathDB As String = Application.StartupPath + "\Hangman.mdb"
    Dim dataSet As DataSet
    Dim connection As OleDbConnection
    Dim dataAdapterList() As OleDbDataAdapter
    Dim dataAdapterWords As OleDbDataAdapter
    Dim cbWords As OleDbCommandBuilder
    Private Sub FDictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    'Modo desconectado
    Public Sub CargarDatos()
        Try
            'Creamos objeto conexión y lo definimos
            connection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & pathDB)

            dataSet = New DataSet

            'Nos conectamos
            connection.Open()

            'Recuperamos en el DataAdapter la tabla Words de la BD
            dataAdapterWords = New OleDbDataAdapter("SELECT Word FROM Words", connection)

            'Rellenamos el DataSet con la info creando una tabla Words
            dataAdapterWords.Fill(dataSet, "Words")

            'Usamos CommandBuilder para hacer actualizaciones automáticas
            cbWords = New OleDbCommandBuilder(dataAdapterWords)

            'Guardamos los DataAdapter para usarlos despues en un bucle para actualizarlos
            dataAdapterList = New OleDbDataAdapter() {dataAdapterWords}

            ' Asignar el DataSet al DataGridView
            DGVWords.DataSource = dataSet.Tables("Words")

            'Nos desconectamos
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar palabras: " & ex.Message)
        End Try
    End Sub

    'Método para actualizar los datos de la tabla, que llamamos en botón
    Private Sub UploadData()
        Try
            'Abrimos conexion.
            connection.Open()
            'Actualizamos en el servidor la informacion de todos los adaptadores.
            For i = 0 To dataAdapterList.Length - 1
                dataAdapterList(i).Update(dataSet.Tables(i))
            Next
            'Cerramos conexion.
            connection.Close()

            MsgBox("Datos actualizados.")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            connection.Close()
        End Try
    End Sub

    'Al pulsar botón guardar, actualizamos la tabla
    Private Sub BtnSaveDB_Click(sender As Object, e As EventArgs) Handles BtnSaveDB.Click
        UploadData()
    End Sub

End Class

