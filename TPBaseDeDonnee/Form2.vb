Public Class Form2

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SQL.Text = "CREATE TABLE " & TextBox1.Text & " ;"
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ComboBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.Click
       
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SQL.Text = "DROP TABLE " & TextBox2.Text & " ;"
    End Sub

    Private Sub ComboBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.TextChanged
        If ComboBox2.Text = "DATE" Or ComboBox2.Text = "TIME" Or ComboBox2.Text = "BOOLEAN" Or ComboBox2.Text = "INTEGER" Then
            TextBox12.Text = ""
            TextBox12.Enabled = False
        Else
            TextBox12.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox12.Enabled = False Then
            SQL.Text = "ALTER TABLE " & TextBox4.Text & " ADD " & TextBox13.Text & " " & ComboBox2.Text & " ;"
        Else
            SQL.Text = "ALTER TABLE " & TextBox4.Text & " ADD " & TextBox13.Text & " " & ComboBox2.Text & " (" & TextBox12.Text & ");"
        End If

    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        SQL.Text = "ALTER TABLE " & TextBox20.Text & " ALTER " & TextBox19.Text & " " & ComboBox1.Text & " ;"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SQL.Text = "ALTER TABLE " & TextBox18.Text & vbNewLine & "DROP " & TextBox3.Text & vbNewLine & ";"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        SQL.Text = "INSERT INTO " & TextBox6.Text & " (" & TextBox14.Text & ")" & " VALUES " & "('" & TextBox9.Text & "') ;"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        SQL.Text = "UPDATE " & TextBox15.Text & " SET " & TextBox5.Text & "='" & TextBox10.Text & "'" & vbNewLine & "WHERE " & TextBox22.Text & "='" & TextBox23.Text & " ' ;"

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        SQL.Text = "DELETE FROM " & TextBox16.Text & " WHERE " & TextBox8.Text & "='" & TextBox21.Text & "' ;"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        SQL.Text = "SELECT * FROM " & TextBox17.Text & " WHERE " & TextBox7.Text & "='" & TextBox11.Text & "' ;"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form1.Show()
        Form1.TextBox1.Text = SQL.Text
    End Sub
End Class