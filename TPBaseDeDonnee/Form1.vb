
Imports System.IO
Imports System.Data.OleDb

Public Class Form1
    Dim db As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim d As New DataSet
    Dim ConStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
"Data Source =" & Application.StartupPath & "\dll\ac.dll"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button3.Enabled = True
        Button1.Enabled = False
        If File.Exists(Application.StartupPath & "\dll\ac.dll") Then
            MsgBox("Connection Réussie", MsgBoxStyle.Information)
        Else
            MsgBox("Erreur de connection", MsgBoxStyle.Critical)

        End If
        'Conn.Open()
        'db.Provider = "Microsoft.Jet.Oledb.4.0"
        'db.Open("e:/Projet Bdd/Bdd.mdb")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error GoTo aa

        If rs.State = 1 Then rs.Close()


        rs.Open(TextBox1.Text, ConStr, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
        MsgBox("Instruction existe , opération bien exécutée", MsgBoxStyle.Information)
        Exit Sub
aa:
        MsgBox("Erreur dans l'exécution !" & vbCrLf & _
               Err.Description, MsgBoxStyle.Critical)


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conn.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error GoTo aa
        DataSet1.Clear()


        Dim DataAdapter1 As New OleDbDataAdapter("select * from " & TextBox2.Text, Conn)
        DataAdapter1.Fill(DataSet1, textbox2.Text )

        DataGridView1.DataSource = DataSet1
        DataGridView1.DataMember = TextBox2.Text
        Exit Sub
aa:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form2.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        On Error GoTo aa
        DataSet1.Clear()


        Dim DataAdapter1 As New OleDbDataAdapter(TextBox2.Text, Conn)
        DataAdapter1.Fill(DataSet1, TextBox2.Text)

        DataGridView1.DataSource = DataSet1
        DataGridView1.DataMember = TextBox2.Text
        Exit Sub
aa:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo aa

        Dim a
        a = MsgBox("Vous allez perdre vos données dans la base de données actuelle êtes-vous sûre ?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Initialisation")
        If a = vbYes Then
            File.Copy(Application.StartupPath & "\dll\ty.dll", Application.StartupPath & "\dll\ac.dll", True)
            MsgBox("Initialisation terminée avec succés", MsgBoxStyle.Information)
        End If
        Exit Sub
aa:
        MsgBox("Il y a une erreur lors de l'initialisation !", MsgBoxStyle.Critical)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub
End Class
