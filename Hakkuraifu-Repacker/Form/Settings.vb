Public Class Settings
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Compreesion = ComboBox1.SelectedItem.ToString
        My.Settings.RF = TextBox1.Text
        My.Settings.DarkMode = CheckBox1.CheckState
        My.Settings.Save()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = My.Settings.Compreesion
        TextBox1.Text = My.Settings.RF
        CheckBox1.Checked = My.Settings.DarkMode
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sf As New FolderBrowserDialog
        sf.Description = "Choose the repack folder"
        sf.UseDescriptionForTitle = True
        If sf.ShowDialog = DialogResult.OK Then
            TextBox1.Text = sf.SelectedPath
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            Dim c As Control
            For Each c In Me.Controls
                If TypeOf c Is Button Then
                    c.BackColor = Color.Black
                End If
            Next
            For Each c In Me.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
            For Each c In Me.Controls
                If TypeOf c Is ComboBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
            Repacker.BackColor = Color.Black
            Repacker.ForeColor = Color.White
            For Each c In Repacker.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
            For Each c In Repacker.Controls
                If TypeOf c Is Button Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
            For Each c In Repacker.Controls
                If TypeOf c Is GroupBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
            For Each c In Repacker.Controls
                If TypeOf c Is RichTextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
            For Each c In Repacker.GroupBox1.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
            For Each c In Repacker.GroupBox1.Controls
                If TypeOf c Is ListBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
            For Each c In Repacker.GroupBox2.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
            For Each c In Repacker.GroupBox2.Controls
                If TypeOf c Is ComboBox Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
            For Each c In Repacker.GroupBox4.Controls
                If TypeOf c Is Button Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
            For Each c In Repacker.GroupBox4.Controls
                If TypeOf c Is Label Then
                    c.BackColor = Color.Black
                    c.ForeColor = Color.White
                End If
            Next
        Else
            Me.BackColor = Color.White
            Me.ForeColor = Color.Black
            For Each c In Repacker.Controls
                If TypeOf c Is RichTextBox Then
                    c.BackColor = Color.White
                    c.ForeColor = Color.Black
                End If
            Next
            For Each c In Me.Controls
                If TypeOf c Is Button Then
                    c.BackColor = Color.White
                End If
            Next
            For Each c In Me.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.White
                    c.ForeColor = Color.Black
                End If
            Next
            For Each c In Me.Controls
                If TypeOf c Is ComboBox Then
                    c.BackColor = Color.White
                    c.ForeColor = Color.Black
                End If
            Next
            Repacker.BackColor = Color.White
            Repacker.ForeColor = Color.Black
            For Each c In Repacker.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.White
                    c.ForeColor = Color.Black
                End If
            Next
            For Each c In Repacker.Controls
                If TypeOf c Is Button Then
                    c.BackColor = Color.White
                    c.ForeColor = Color.Black
                End If
            Next
            For Each c In Repacker.Controls
                If TypeOf c Is GroupBox Then
                    c.BackColor = Color.White
                    c.ForeColor = Color.Black
                End If
            Next
            For Each c In Repacker.GroupBox1.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.White
                    c.ForeColor = Color.Black
                End If
            Next
            For Each c In Repacker.GroupBox1.Controls
                If TypeOf c Is ListBox Then
                    c.BackColor = Color.White
                    c.ForeColor = Color.Black
                End If
            Next
            For Each c In Repacker.GroupBox2.Controls
                If TypeOf c Is TextBox Then
                    c.BackColor = Color.White
                    c.ForeColor = Color.Black
                End If
            Next
            For Each c In Repacker.GroupBox2.Controls
                If TypeOf c Is ComboBox Then
                    c.BackColor = Color.White
                    c.ForeColor = Color.Black
                End If
            Next
            For Each c In Repacker.GroupBox4.Controls
                If TypeOf c Is Button Then
                    c.BackColor = Color.White
                    c.ForeColor = Color.Black
                End If
            Next
            For Each c In Repacker.GroupBox4.Controls
                If TypeOf c Is Label Then
                    c.BackColor = Color.White
                    c.ForeColor = Color.Black
                End If
            Next
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class