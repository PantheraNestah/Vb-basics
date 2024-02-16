Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub ColorRadioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)
        If radioButton.Checked Then
            Select Case radioButton.Name
                Case "RadioButton4"
                    TextBox1.ForeColor = Color.Green
                Case "RadioButton5"
                    TextBox1.ForeColor = Color.Blue
                Case "RadioButton6"
                    TextBox1.ForeColor = Color.Red
            End Select
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New Form1
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|All Files (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub FontRadioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)
        If radioButton.Checked Then
            Select Case radioButton.Name
                Case "RadioButton1"
                    TextBox1.Font = New Font("Garamond", TextBox1.Font.Size, TextBox1.Font.Style)
                Case "RadioButton2"
                    TextBox1.Font = New Font("Magneto", TextBox1.Font.Size, TextBox1.Font.Style)
                Case "RadioButton3"
                    TextBox1.Font = New Font("Tahoma", TextBox1.Font.Size, TextBox1.Font.Style)
            End Select
        End If
    End Sub

    Private Sub StyleCheckBoxs_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged
        Dim checkBox As CheckBox = DirectCast(sender, CheckBox)
        If checkBox.Checked Then
            Select Case checkBox.Name
                Case "CheckBox1"
                    TextBox1.Font = New Font(TextBox1.Font, FontStyle.Italic)
                Case "CheckBox2"
                    TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold)
                Case "CheckBox3"
                    TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold Or FontStyle.Italic)
            End Select
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class