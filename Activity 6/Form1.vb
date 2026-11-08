Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim Reader As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Add("ColID", "CustomerID")
        DataGridView1.Columns.Add("ColName", "CustomerName")
        DataGridView1.Columns.Add("ColGender", "Gender")
        DataGridView1.Columns.Add("ColYear", "Year")
        DataGridView1.Columns.Add("ColCourse", "Course")
        Dim imgCol As New DataGridViewImageColumn()
        imgCol.HeaderText = "Image"
        imgCol.Name = "ColImage"
        DataGridView1.Columns.Add(imgCol)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Select an Image"
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*"
            openFileDialog.FilterIndex = 1
            openFileDialog.RestoreDirectory = True

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
                Catch ex As Exception
                    MessageBox.Show("Could not load image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Public Sub SaveData()
        Dim gendervalue As String = ""
        If RadioButton1.Checked = True Then
            RadioButton2.Checked = False
            gendervalue = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            RadioButton1.Checked = False
            gendervalue = RadioButton2.Text
        End If

        Try
            con.Open()
            Dim cm As New MySqlCommand("Insert into user(CustomerID,CustomerName,Gender,Year,Course,Image) values (@ci,@cn,@g,@y,@c,@i)", con)
            With cm
                .Parameters.AddWithValue("@ci", TextBox1.Text)
                .Parameters.AddWithValue("@cn", TextBox3.Text)
                .Parameters.AddWithValue("@g", gendervalue)
                .Parameters.AddWithValue("@y", ComboBox1.Text)
                .Parameters.AddWithValue("@c", ComboBox2.Text)
                .Parameters.AddWithValue("@i", ImageToBase64(PictureBox1.Image, System.Drawing.Imaging.ImageFormat.Png))
                .ExecuteNonQuery()
            End With
            con.Close()
            MessageBox.Show("Successfully Added!", "Save!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            TextBox3.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            PictureBox1.Image = Nothing
            TextBox1.Focus()
            loadrecords()
        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub loadrecords()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            con.Open()
            Dim cm As New MySqlCommand("Select * from user order by CustomerName", con)
            Reader = cm.ExecuteReader
            While Reader.Read
                i += 1
                DataGridView1.Rows.Add(Reader.Item("CustomerID").ToString(),
                    Reader.Item("CustomerName").ToString(), Reader.Item("Gender").ToString(),
                    Reader.Item("Year").ToString(), Reader.Item("Course").ToString().ToUpper(),
                    Base64ToImage(Reader.Item("Image").ToString()))
            End While
            Reader.Close()
            con.Close()
        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchRecords()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        con.Open()
        Dim cm As New MySqlCommand("Select * from user where CustomerID like '%" & TextBox2.Text & "%' or Course like '%" & TextBox2.Text & "%' or Year like '%" & TextBox2.Text & "%' order by CustomerName", con)
        Reader = cm.ExecuteReader
        While Reader.Read
            i += 1
            DataGridView1.Rows.Add(Reader.Item("CustomerID").ToString(),
                Reader.Item("CustomerName").ToString(),
                Reader.Item("Gender").ToString(), Reader.Item("Year").ToString(),
                Reader.Item("Course").ToString(), Base64ToImage(Reader.Item("Image").ToString()))
        End While
        Reader.Close()
        con.Close()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SearchRecords()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        TextBox1.Enabled = True
        TextBox1.Clear()
        TextBox1.Focus()
        TextBox2.Enabled = True
        TextBox2.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        Button1.Enabled = True
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If MsgBox("Update this Record?, Click Yes To Confirm.", vbYesNo + vbQuestion, "Update Record") = vbYes Then
                con.Open()
                Dim cm As New MySqlCommand("update user set CustomerName=@cn,Gender=@g,Year=@y,Course=@c,Image=@i where CustomerID=@id", con)
                Dim gender As String = ""
                If RadioButton1.Checked = True Then
                    RadioButton2.Checked = False
                    gender = RadioButton1.Text
                ElseIf RadioButton2.Checked = True Then
                    RadioButton1.Checked = False
                    gender = RadioButton2.Text
                End If

                With cm
                    .Parameters.AddWithValue("@cn", TextBox2.Text)
                    .Parameters.AddWithValue("@g", gender)
                    .Parameters.AddWithValue("@y", ComboBox1.Text)
                    .Parameters.AddWithValue("@c", ComboBox2.Text)
                    .Parameters.AddWithValue("@i", ImageToBase64(PictureBox1.Image, System.Drawing.Imaging.ImageFormat.Png))
                    .Parameters.AddWithValue("@id", TextBox1.Text)
                    .ExecuteNonQuery()
                End With
                con.Close()
                MessageBox.Show("Updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadrecords()
                TextBox1.Clear()
                TextBox1.Focus()
                TextBox3.Clear()
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                PictureBox1.Image = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Function ImageToBase64(img As Image, fmt As System.Drawing.Imaging.ImageFormat) As String
        If img Is Nothing Then Return ""
        Using ms As New MemoryStream()
            img.Save(ms, fmt)
            Return Convert.ToBase64String(ms.ToArray())
        End Using
    End Function

    Function Base64ToImage(b64 As String) As Image
        If String.IsNullOrEmpty(b64) Then Return Nothing
        Dim bytes() As Byte = Convert.FromBase64String(b64)
        Using ms As New MemoryStream(bytes)
            Return Image.FromStream(ms)
        End Using
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loadrecords()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                If MsgBox("Delete this Record?, Click Yes To Confirm.", vbYesNo + vbQuestion, "Delete Record") = vbYes Then
                    Dim customerID As String = DataGridView1.SelectedRows(0).Cells("ColID").Value.ToString()
                    con.Open()
                    Dim cm As New MySqlCommand("DELETE FROM user WHERE CustomerID = @id", con)
                    cm.Parameters.AddWithValue("@id", customerID)
                    cm.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadrecords()
                End If
            Else
                MessageBox.Show("Please select a record to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class