Imports System.Data.SQLite

Module Program

    Sub Main()
        Dim connectionString As String = "Data Source=miBD.sqlite;Version=3;"
        Dim conexion As New SQLiteConnection(connectionString)
        conexion.Open()
        MessageBox.Show("Conexion SQLite exitosa")
        ' Console.WriteLine("Conexión exitosa.")
        conexion.Close()
    End Sub
End Module

