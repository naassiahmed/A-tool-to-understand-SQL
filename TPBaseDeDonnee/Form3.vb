Public Class Form3

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Text = "CREATE : " & vbNewLine & _
        "Fonction : Ajouter une table à la base de données , (ou peut ajouter au même temps les attributs) " & vbNewLine & _
        "-------------------------------------------------------" & vbNewLine & _
        "Syntaxe 1 :  CREATE TABLE nom_table ;" & vbNewLine & _
        "-------------------------------------------------------" & vbNewLine & _
        "Syntaxe 2 :  CREATE TABLE nom_table" & vbNewLine & _
        "         (" & vbNewLine & _
        "               COLUMN_NAME1   DATA_TYPE1  [CONSTRAINT]," & vbNewLine & _
        "               COLUMN_NAME2   DATA_TYPE2  [CONSTRAINT]" & vbNewLine & _
        "         ) ;" & vbNewLine & _
        "-------------------------------------------------------" & vbNewLine & _
        "Exemple : On veux créer une table Etudiants " & vbNewLine & _
        "   CREATE TABLE Etudiants" & vbNewLine & _
        "         (" & vbNewLine & _
        "               Matriclue   INTEGER  NOT NULL," & vbNewLine & _
        "               Nom         VARCHAR(50) " & vbNewLine & _
        "         );" & vbNewLine & _
        "--------------------------------------------------------" & vbNewLine & _
        "On peut aussi spécifier les clés , en rajoutant une instruction " & vbNewLine & _
        "-------------------------------------------------------" & vbNewLine & _
        "Syntaxe : CONSTRAINT   pk_etudiant   PRIMARY KEY   (Matricule)" & vbNewLine & _
        "pk_etudinat : n'est pas une mot clé mais il est possible de le changer " & vbNewLine & _
        "PRIMARY KEY : le type de l'attribut mais il y a autre type de clés" & vbNewLine & _
        "-------------------------------------------------------" & vbNewLine & _
        "Remarque : Dans SQL SERVER , MSACCESS on ne doit pas écrire ; , par contre ORACLE  " & vbNewLine & _
        "demande ;"
    End Sub

    Private Sub RadioButton3_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Text = "DROP :" & vbNewLine & _
        "Fonction : Supprimer une table dans la base de données" & vbNewLine & _
        "--------------------------------------------------------------------" & vbNewLine & _
        "Syntaxe : DROP nom_table ;" & vbNewLine & _
        "--------------------------------------------------------------------" & vbNewLine & _
        "Exemple : On reprend l'exemple1 On veut supprimer la table Etudiants" & vbNewLine & _
        "    DROP TABLE  Etudiant ;" & vbNewLine & _
        "--------------------------------------------------------------------" & vbNewLine & _
        "Remarque : Cette instruction supprime les attributs et leurs données !"

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        TextBox1.Text = "ALTER :" & vbNewLine & _
        "Fonction : cette fonction a plusieurs utilisation (Ajouter/Modifier attribut,Modifier nom de la table" & vbNewLine & _
        "--------------------------------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 1 :   ALTER TABLE  nom_table   ADD nom_attribut  type_attribut ;" & vbNewLine & _
        "--------------------------------------------------------------------------------------" & vbNewLine & _
        "Exemple :      ALTER  TABLE   Etudiant " & vbNewLine & _
        "                     ADD   Prenom   VARCHAR(50) ;" & vbNewLine & _
        "--------------------------------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 2 :   ALTER   TABLE   nom_table    DROP    nom_attribut  ;" & vbNewLine & _
        "--------------------------------------------------------------------------------------" & vbNewLine & _
        "Exmeple :     ALTER   TABLE    Etudiant " & vbNewLine & _
        "                    DROP   Prenom  ;"

    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        TextBox1.Text = "INSERT INTO :" & vbNewLine & _
        "Fonction : Ajouter des informations dans la base de données, cette fonction a deux formes" & vbNewLine & _
        "-----------------------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 1 : INSERT INTO nom_table " & vbNewLine & _
        "                    VALUES (Val1,Val2,....,Val(n)  ) ; " & vbNewLine & _
        "-----------------------------------------------------------------------------" & vbNewLine & _
        "Remarque : Syntaxe 1  , on remplit tous les champs dans notre table" & vbNewLine & _
        "-----------------------------------------------------------------------------" & vbNewLine & _
        "Important : Dans ce cas if faut respecter l'ordre d'attributs dans votre BD " & vbNewLine & _
        "            et destinger le format numérique et la chaine de caractères" & vbNewLine & _
        "----------------------------------------------------------------------------" & vbNewLine & _
        "Exemple :  INSERT INTO  Etudiant " & vbNewLine & _
        "                   VALUES (201200009999,'Naas','Si Ahmed' ) ;" & vbNewLine & _
        "----------------------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 2 :  INSERT INTO  nom_table  (Attr1,Attr2,....,Attr(n) " & vbNewLine & _
        "                    VALUES (Val1,Val2,.....,Val(n))    ;" & vbNewLine & _
        "----------------------------------------------------------------------------" & vbNewLine & _
        "Exemple :  INSERT INTO  Etudiant (Matricule , Nom) " & vbNewLine & _
        "                   VALUES (201200009999,'Naas' ) ;" & vbNewLine & _
        "----------------------------------------------------------------------------" & vbNewLine & _
        "Remarque : dans ce cas on a spécifier les champs à remplir mais il faut toujours" & vbNewLine & _
        "respercter l'ordre de champs !"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(TextBox1.Text)
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        TextBox1.Text = "DELETE :" & vbNewLine & _
        "Fonction : Supprimer une colonne ou plusieur colonnes dans une table" & vbNewLine & _
        "--------------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 1 : DELETE   FROM  nom_table " & vbNewLine & _
        "                   WHERE   [Conditions]  ;" & vbNewLine & _
        "--------------------------------------------------------------------" & vbNewLine & _
        "Exemple :  DELETE  FROM  ETUDIANT " & vbNewLine & _
        "                  WHERE Nom='Naas'   ;" & vbNewLine & _
        "--------------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 2 : DELETE  *  FROM  nom_table " & vbNewLine & _
        "--------------------------------------------------------------------" & vbNewLine & _
        "Exemple :  DELETE  *  FROM  ETUDIANT " & vbNewLine & _
        "--------------------------------------------------------------------" & vbNewLine & _
        "Important  :  * supprimer toutes les informations dans une table "
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        TextBox1.Text = "UPDATE : " & vbNewLine & _
        "Fonction :  Modifier un champs ou plus dans la base de données " & vbNewLine & _
        "---------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 1: UPDATE   nom_table" & vbNewLine & _
        "         SET  Attr1 = Val1 , Attr1 = Val2 , Attr(n) = Val(n)" & vbNewLine & _
        "         WHERE   [conditions]   ; " & vbNewLine & _
        "---------------------------------------------------------------" & vbNewLine & _
        "Exemple : UPDATE   Etudiant" & vbNewLine & _
        "         SET  Matricule = 201200001111 , Nom = 'Zohra' , Prenom = 'Zohra'" & vbNewLine & _
        "         WHERE   Matricule = 201200009999   ; " & vbNewLine & _
        "---------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 2: UPDATE   nom_table" & vbNewLine & _
        "         SET  Attr1 = Val1 " & vbNewLine & _
        "         WHERE   [conditions]   ; " & vbNewLine & _
        "---------------------------------------------------------------" & vbNewLine & _
        "Exemple : UPDATE   Etudiant" & vbNewLine & _
        "         SET  Matricule = 201200001111 " & vbNewLine & _
        "         WHERE   Matricule = 201200009999   ; " & vbNewLine & _
        "---------------------------------------------------------------" & vbNewLine & _
        "Remarque : La condition peut prendre des comparaisons enres les " & vbNewLine & _
        "champs ou bien entre champs et une valeur ....!"


    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        TextBox1.Text = "SELECT :" & vbNewLine & _
        "Fonction : sélectionner une colonne ou plusieur, SELECT a plusieur formes " & vbNewLine & _
        "-----------------------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 1:  SELECT attr1,attr2,...,attr(n) FROM  nom_table" & vbNewLine & _
        "-----------------------------------------------------------------------------" & vbNewLine & _
        "Exmeple :  SELECT  Matricule   FROM  Etudiant " & vbNewLine & _
        "-----------------------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 2:  SELECT *  FROM  nom_table" & vbNewLine & _
        "-----------------------------------------------------------------------------" & vbNewLine & _
        "Remarque : *  signifie toutes les données " & vbNewLine & _
        "Exemple  :  SELECT *  FROM  Etudiant " & vbNewLine & _
        "-----------------------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 3 : SELECT attr1,attr2  FROM  nom_table " & vbNewLine & _
        "                  WHERE  [conditions]" & vbNewLine & _
        "-----------------------------------------------------------------------------" & vbNewLine & _
        "Exemple : SELECT  *  FROM  Etudiant WHERE Age > 20 " & vbNewLine & _
        "-----------------------------------------------------------------------------" & vbNewLine & _
        "Important : * Il y a aussi SELECT DISTINCT qui a les même syntaxes que SELECT"



    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        TextBox1.Text = "CREATE : " & vbNewLine & _
        "Fonction : Créer index qui optimise la recherche dans les grandes BD" & vbNewLine & _
        "--------------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 1 : CREATE INDEX   nom_index   ON  table_name (nom_attr) ;" & vbNewLine & _
        "--------------------------------------------------------------------" & vbNewLine & _
        "Exmeple :  CREATE  INDEX EtudiantIndex  On  Etudiant(Nom)  ;" & vbNewLine & _
        "--------------------------------------------------------------------" & vbNewLine & _
        "Syntaxe 2 : CREATE UNIQUE INDEX   nom_index   ON  table_name (nom_attr) ;" & vbNewLine & _
        "--------------------------------------------------------------------" & vbNewLine & _
        "Exmeple :  CREATE UNIQUE INDEX EtudiantIndex  On  Etudiant(Matricule)  ;"
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        TextBox1.Text = "DROP :" & vbNewLine & _
        "Fonction : Supprimer un index, il y a plusieur formes" & vbNewLine & _
        "-----------------------------------------------------" & vbNewLine & _
        "Syntaxe 1 : Pour SQL Jet :" & vbNewLine & _
        "DROP INDEX nom_index ON nom_table" & vbNewLine & _
        "-----------------------------------------------------" & vbNewLine & _
        "Syntaxe 2 : Pour SQL Server :" & vbNewLine & _
        "DROP INDEX nom_table.nom_index" & vbNewLine & _
        "-----------------------------------------------------" & vbNewLine & _
        "Syntaxe 3 : IBM DB2 et Oracle: :" & vbNewLine & _
        "DROP INDEX index_name" & vbNewLine & _
        "-----------------------------------------------------" & vbNewLine & _
        "Syntaxe 4 : Pour MySQL Jet :" & vbNewLine & _
        "ALTER TABLE nom_table DROP INDEX nom_index"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox2.Enabled = True
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox2.Enabled = False
        GroupBox3.Enabled = True
        GroupBox4.Enabled = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = True
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Selon SQL 2008 : " & vbNewLine & "bigInet" & vbNewLine & "binary()" & vbNewLine & "bit" & vbNewLine & "char()" & vbNewLine & "datetime" & vbNewLine & "decimal(,)" & vbNewLine & "float" & vbNewLine & "image" & vbNewLine & "int" & vbNewLine & "money" & vbNewLine & "nchar()" & vbNewLine & "ntext" & vbNewLine & "numeric(,)" & vbNewLine & "varchar()" & vbNewLine & "real" & vbNewLine & "tinyint" & vbNewLine & "text" & vbNewLine & "xml ...", MsgBoxStyle.Information)

    End Sub
End Class