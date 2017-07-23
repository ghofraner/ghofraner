Public Class Form1
    Dim pos_addition, pos_soustraction, pos_multiplication, pos_division, longu, nb1, nb2 As Integer
    Dim ch1, ch2 As String


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
      



        pos_multiplication = InStr(TextBox1.Text, "*")

        If pos_addition <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_addition - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_addition, longu - pos_addition)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 + nb2
        ElseIf pos_soustraction <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_soustraction - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_soustraction, longu - pos_soustraction)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 - nb2
        ElseIf pos_multiplication <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_multiplication - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_multiplication, longu - pos_addition)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 * nb2
        ElseIf pos_division <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_division - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_division, longu - pos_division)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 / nb2


        End If


        pos_addition = InStr(TextBox1.Text, "+")
        pos_soustraction = InStr(TextBox1.Text, "-")
        pos_division = InStr(TextBox1.Text, "/")
        pos_multiplication = InStr(TextBox1.Text, "*")
        If pos_division <> 0 Then
            ch1 = TextBox1.Text
            ch1 = Replace(ch1, "/", "")
            TextBox1.Text = ch1 + "*"


        ElseIf pos_soustraction <> 0 Then
            ch1 = TextBox1.Text
            ch1 = Replace(ch1, "-", "")
            TextBox1.Text = ch1 + "*"



        ElseIf pos_addition <> 0 Then
            ch1 = TextBox1.Text
            ch1 = Replace(ch1, "+", "")
            TextBox1.Text = ch1 + "*"
        Else


            TextBox1.Text = TextBox1.Text + "*"


        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        pos_addition = InStr(TextBox1.Text, "+")
        pos_soustraction = InStr(TextBox1.Text, "-")
        pos_division = InStr(TextBox1.Text, "/")
        pos_multiplication = InStr(TextBox1.Text, "*")
        'test - au debut 
        If pos_soustraction = 1 Then


            TextBox1.Text = "-" + TextBox1.Text + "/"
        End If

        If pos_addition <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_addition - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_addition, longu - pos_addition)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 + nb2
        ElseIf pos_soustraction <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_soustraction - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_soustraction, longu - pos_soustraction)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 - nb2
        ElseIf pos_multiplication <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_multiplication - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_multiplication, longu - pos_multiplication)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 * nb2
        ElseIf pos_division <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_division - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_division, longu - pos_division)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 / nb2


        End If
        If pos_addition <> 0 Then
            ch1 = TextBox1.Text
            ch1 = Replace(ch1, "+", "")
            TextBox1.Text = ch1 + "/"




        ElseIf pos_multiplication <> 0 Then
            ch1 = TextBox1.Text
            ch1 = Replace(ch1, "*", "")
            TextBox1.Text = ch1 + "/"





        ElseIf pos_soustraction <> 0 Then
            ch1 = TextBox1.Text
            ch1 = Replace(ch1, "-", "")
            TextBox1.Text = ch1 + "/"


        Else


            TextBox1.Text = TextBox1.Text + "/"
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        TextBox1.Text = TextBox1.Text + "8"

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        pos_addition = InStr(TextBox1.Text, "+")
        pos_soustraction = InStr(TextBox1.Text, "-")
        pos_division = InStr(TextBox1.Text, "/")
        pos_multiplication = InStr(TextBox1.Text, "*")
        'autre signe 
        If pos_addition <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_addition - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_addition, longu - pos_addition)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 + nb2
        ElseIf pos_soustraction <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_soustraction - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_soustraction, longu - pos_soustraction)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 - nb2
        ElseIf pos_multiplication <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_multiplication - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_multiplication, longu - pos_multiplication)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 * nb2
        ElseIf pos_division <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_division - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_division, longu - pos_division)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 / nb2


        End If

        If pos_division <> 0 Then
            ch1 = TextBox1.Text
            ch1 = Replace(ch1, "/", "")
            TextBox1.Text = ch1 + "+"




        ElseIf pos_multiplication <> 0 Then
            ch1 = TextBox1.Text
            ch1 = Replace(ch1, "*", "")
            TextBox1.Text = ch1 + "+"



        ElseIf pos_soustraction <> 0 Then
            ch1 = TextBox1.Text
            ch1 = Replace(ch1, "-", "")
            TextBox1.Text = ch1 + "+"




        Else


            TextBox1.Text = TextBox1.Text + "+"
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        pos_soustraction = InStr(TextBox1.Text, "-")
        pos_addition = InStr(TextBox1.Text, "+")
        pos_soustraction = InStr(TextBox1.Text, "-")
        pos_division = InStr(TextBox1.Text, "/")
        pos_multiplication = InStr(TextBox1.Text, "*")
        'je verifie s il y a  deja - exp 9-8 
        If pos_addition <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_addition - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_addition, longu - pos_addition)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 + nb2
        ElseIf pos_soustraction <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_soustraction - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_soustraction, longu - pos_soustraction)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 - nb2
        ElseIf pos_multiplication <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_multiplication - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_multiplication, longu - pos_multiplication)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 * nb2
        ElseIf pos_division <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_division - 1) '
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_division, longu - pos_division)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 / nb2


        End If


        ' je verifie s il y a deja un  autre symbole  */+ je le remplace par - 
        If pos_division <> 0 Then
            ch1 = TextBox1.Text
            ch1 = Replace(ch1, "/", "")
            TextBox1.Text = ch1 + "-"




        ElseIf pos_multiplication <> 0 Then
            ch1 = TextBox1.Text
            ch1 = Replace(ch1, "*", "")
            TextBox1.Text = ch1 + "-"



        ElseIf pos_addition <> 0 Then
            ch1 = TextBox1.Text
            ch1 = Replace(ch1, "+", "")
            TextBox1.Text = ch1 + "-"


        Else












            TextBox1.Text = TextBox1.Text + "-"
        End If


    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        pos_addition = InStr(TextBox1.Text, "+")
        pos_multiplication = InStr(TextBox1.Text, "*")
        pos_soustraction = InStr(TextBox1.Text, "-")
        pos_division = InStr(TextBox1.Text, "/")



        If pos_addition <> 0 Then
            ch1 = TextBox1.Text.Substring(0, pos_addition - 1)
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_addition, longu - pos_addition)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 + nb2
        ElseIf pos_multiplication <> 0 Then

            ch1 = TextBox1.Text.Substring(0, pos_multiplication - 1)
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_multiplication, longu - pos_multiplication)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 * nb2
        ElseIf pos_soustraction <> 0 Then

            ch1 = TextBox1.Text.Substring(0, pos_soustraction - 1)
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_soustraction, longu - pos_soustraction)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 - nb2
        ElseIf pos_division <> 0 Then

            ch1 = TextBox1.Text.Substring(0, pos_division - 1)
            nb1 = Val(ch1)
            longu = TextBox1.Text.Length
            ch2 = TextBox1.Text.Substring(pos_division, longu - pos_division)
            nb2 = Val(ch2)
            TextBox1.Text = nb1 / nb2

        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = ""
    End Sub
End Class
