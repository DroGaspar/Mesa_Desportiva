Imports System.Data.SqlClient
Public Class Inicio
    'Este codigo contém um erro que ainda não foi resolvido
    Dim con As SqlConnection = New SqlConnection
    Dim active_user = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const caminho As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\armamucdpsmetesmail\source\repos\Mesa_Desportiva\mesadesportiva01.mdf;Integrated Security=True;Connect Timeout=30"
        Dim con As New SqlConnection(caminho)
        con.Open()
        Dim sql As SqlCommand = New SqlCommand("Select* from elementomesa where nome='" & login.Text & "' and password= '" & password.Text & "'", con)

        Dim dr As SqlDataReader = sql.ExecuteReader
        Dim encontrou = False
        Dim strnome As String
        While dr.Read
            encontrou = True
            active_user = dr("id_mesa").ToString
            strnome = dr("nome").ToString
        End While
        Me.Close()
        If encontrou = True Then
            Me.Close()
            CriarPartida.Show()


        Else
            MessageBox.Show("O utilizador não existe ou a password está errada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub
End Class
