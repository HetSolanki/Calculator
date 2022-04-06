Imports System.Data.SqlClient

Public Class Form1
    Dim d1, d2 As Integer
    Dim ope(3) As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text &= Button1.Text
        If TextBox1.Text <> "" Then
            If ope(0) <> "" Then
                TextBox1.Text = d1 + Val(Button1.Text)
                ope(0) = ""

            ElseIf ope(1) <> ""
                TextBox1.Text = d1 - Val(Button1.Text)
                ope(1) = ""

            ElseIf ope(2) <> ""
                TextBox1.Text = d1 * Val(Button1.Text)
                ope(2) = ""

            ElseIf ope(3) <> ""
                TextBox1.Text = d1 / Val(Button1.Text)
                ope(3) = ""

            End If
        End If
        d1 = Val(Button1.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text &= Button2.Text
        If TextBox1.Text <> "" Then
            If ope(0) <> "" Then
                TextBox1.Text = d1 + Val(Button2.Text)
                ope(0) = ""
            ElseIf ope(1) <> ""
                TextBox1.Text = d1 - Val(Button2.Text)
                ope(1) = ""

            ElseIf ope(2) <> ""
                TextBox1.Text = d1 * Val(Button2.Text)
                ope(2) = ""
            ElseIf ope(3) <> ""
                TextBox1.Text = d1 / Val(Button2.Text)
                ope(3) = ""
            End If
        End If
        d1 = Val(Button2.Text)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        TextBox1.Text = d1 + d2
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        d1 = Val(TextBox1.Text)
        TextBox1.Text &= Button11.Text
        ope(0) = Button11.Text
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        d1 = Val(TextBox1.Text)
        TextBox1.Text &= Button12.Text
        ope(1) = Button12.Text
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        d1 = Val(TextBox1.Text)
        TextBox1.Text &= Button13.Text
        ope(2) = Button13.Text
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        d1 = Val(TextBox1.Text)
        TextBox1.Text &= Button14.Text
        ope(3) = Button14.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text &= Button3.Text
        If TextBox1.Text <> "" Then
            If ope(0) <> "" Then
                TextBox1.Text = d1 + Val(Button3.Text)
                ope(0) = ""
            ElseIf ope(1) <> ""
                TextBox1.Text = d1 - Val(Button3.Text)
                ope(1) = ""
            ElseIf ope(2) <> ""
                TextBox1.Text = d1 * Val(Button3.Text)
                ope(2) = ""
            ElseIf ope(3) <> ""
                TextBox1.Text = d1 / Val(Button3.Text)
                ope(3) = ""
            End If
        End If
        d1 = Val(Button3.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text &= Button4.Text
        If TextBox1.Text <> "" Then
            If ope(0) <> "" Then
                TextBox1.Text = d1 + Val(Button4.Text)
                ope(0) = ""
            ElseIf ope(1) <> ""
                TextBox1.Text = d1 - Val(Button4.Text)
                ope(1) = ""
            ElseIf ope(2) <> ""
                TextBox1.Text = d1 * Val(Button4.Text)
                ope(2) = ""
            ElseIf ope(3) <> ""
                TextBox1.Text = d1 / Val(Button4.Text)
                ope(3) = ""
            End If
        End If
        d1 = Val(Button4.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text &= Button5.Text
        If TextBox1.Text <> "" Then
            If ope(0) <> "" Then
                TextBox1.Text = d1 + Val(Button5.Text)
                ope(0) = ""
            ElseIf ope(1) <> ""
                TextBox1.Text = d1 - Val(Button5.Text)
                ope(1) = ""
            ElseIf ope(2) <> ""
                TextBox1.Text = d1 * Val(Button5.Text)
                ope(2) = ""
            ElseIf ope(3) <> ""
                TextBox1.Text = d1 / Val(Button5.Text)
                ope(3) = ""
            End If
        End If
        d1 = Val(Button5.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text &= Button6.Text
        If TextBox1.Text <> "" Then
            If ope(0) <> "" Then
                TextBox1.Text = d1 + Val(Button6.Text)
                ope(0) = ""
            ElseIf ope(1) <> ""
                TextBox1.Text = d1 - Val(Button6.Text)
                ope(1) = ""
            ElseIf ope(2) <> ""
                TextBox1.Text = d1 * Val(Button6.Text)
                ope(2) = ""
            ElseIf ope(3) <> ""
                TextBox1.Text = d1 / Val(Button6.Text)
                ope(3) = ""
            End If
        End If
        d1 = Val(Button6.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text &= Button7.Text
        If TextBox1.Text <> "" Then
            If ope(0) <> "" Then
                TextBox1.Text = d1 + Val(Button7.Text)
                ope(0) = ""
            ElseIf ope(1) <> ""
                TextBox1.Text = d1 - Val(Button7.Text)
                ope(1) = ""
            ElseIf ope(2) <> ""
                TextBox1.Text = d1 * Val(Button7.Text)
                ope(2) = ""
            ElseIf ope(3) <> ""
                TextBox1.Text = d1 / Val(Button7.Text)
                ope(3) = ""
            End If
        End If
        d1 = Val(Button7.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text &= Button8.Text
        If TextBox1.Text <> "" Then
            If ope(0) <> "" Then
                TextBox1.Text = d1 + Val(Button8.Text)
                ope(0) = ""
            ElseIf ope(1) <> ""
                TextBox1.Text = d1 - Val(Button8.Text)
                ope(1) = ""
            ElseIf ope(2) <> ""
                TextBox1.Text = d1 * Val(Button8.Text)
                ope(2) = ""
            ElseIf ope(3) <> ""
                TextBox1.Text = d1 / Val(Button8.Text)
                ope(3) = ""
            End If
        End If
        d1 = Val(Button8.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text &= Button9.Text
        If TextBox1.Text <> "" Then
            If ope(0) <> "" Then
                TextBox1.Text = d1 + Val(Button9.Text)
                ope(0) = ""
            ElseIf ope(1) <> ""
                TextBox1.Text = d1 - Val(Button9.Text)
                ope(1) = ""
            ElseIf ope(2) <> ""
                TextBox1.Text = d1 * Val(Button9.Text)
                ope(2) = ""
            ElseIf ope(3) <> ""
                TextBox1.Text = d1 / Val(Button9.Text)
                ope(3) = ""
            End If
        End If
        d1 = Val(Button9.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text &= Button10.Text
        If TextBox1.Text <> "" Then
            If ope(0) <> "" Then
                TextBox1.Text = d1 + Val(Button10.Text)
                ope(0) = ""
            ElseIf ope(1) <> ""
                TextBox1.Text = d1 - Val(Button10.Text)
                ope(1) = ""
            ElseIf ope(2) <> ""
                TextBox1.Text = d1 * Val(Button10.Text)
                ope(2) = ""
            ElseIf ope(3) <> ""
                TextBox1.Text = d1 / Val(Button10.Text)
                ope(3) = ""
            End If
        End If
        d1 = Val(Button10.Text)
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Button16.Text = "ON" Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Button10.Enabled = False
            Button11.Enabled = False
            Button12.Enabled = False
            Button13.Enabled = False
            Button14.Enabled = False
            Button15.Enabled = False
            TextBox1.Enabled = False
            Button16.Text = "OFF"
        Else
            Button16.Text = "ON"
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True
            Button1.Enabled = True
            Button9.Enabled = True
            Button10.Enabled = True
            Button11.Enabled = True
            Button12.Enabled = True
            Button13.Enabled = True
            Button14.Enabled = True
            Button15.Enabled = True
            TextBox1.Enabled = True
        End If




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
