Public Class Form1

    Private Sub ButtonClickMethod(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click,
        Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click

        Dim button As Button = CType(sender, Button)

        If button.Name = "Button1" Then
            TextBox1.Text = ""
        End If


        If button.Name = "Button2" Then
            TextBox1.Text = TextBox1.Text + "1"
        End If

        If button.Name = "Button3" Then
            TextBox1.Text = TextBox1.Text + "2"
        End If

        If button.Name = "Button5" Then
            TextBox1.Text = TextBox1.Text + "3"
        End If

        If button.Name = "Button4" Then
            TextBox1.Text = TextBox1.Text + "4"
        End If

        If button.Name = "Button6" Then
            TextBox1.Text = TextBox1.Text + "5"
        End If
        If button.Name = "Button7" Then
            TextBox1.Text = TextBox1.Text + "6"
        End If


        If button.Name = "Button8" Then
            TextBox1.Text = TextBox1.Text + "7"
        End If

        If button.Name = "Button9" Then
            TextBox1.Text = TextBox1.Text + "8"
        End If

        If button.Name = "Button13" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If

        If button.Name = "Button12" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If

        If button.Name = "Button11" Then
            TextBox1.Text = TextBox1.Text + "."
        End If

        If button.Name = "Button10" Then
            TextBox1.Text = TextBox1.Text + "/"
        End If

        If button.Name = "Button15" Then
            TextBox1.Text = TextBox1.Text + "*"
        End If

        If button.Name = "Button16" Then
            TextBox1.Text = TextBox1.Text + "+"
        End If

        If button.Name = "Button17" Then
            TextBox1.Text = TextBox1.Text + "-"
        End If


        If button.Name = "Button14" Then
            Dim equation As String = TextBox1.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox1.Text = result
        End If









    End Sub



End Class
