Public Class main

    Dim previewNum As String = ""

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click, btnMultiple.Click, btnMinus.Click, btnDivide.Click, btnAdd.Click

        Dim tempNum As String = ""

        If sender.Equals(btn1) Then
            tempNum = 1

        ElseIf sender.Equals(btn2) Then
            tempNum = 2

        ElseIf sender.Equals(btn3) Then
            tempNum = 3

        ElseIf sender.Equals(btn4) Then
            tempNum = 4

        ElseIf sender.Equals(btn5) Then
            tempNum = 5

        ElseIf sender.Equals(btn6) Then
            tempNum = 6

        ElseIf sender.Equals(btn7) Then
            tempNum = 7

        ElseIf sender.Equals(btn8) Then
            tempNum = 8

        ElseIf sender.Equals(btn9) Then
            tempNum = 9

        ElseIf sender.Equals(btn0) Then
            tempNum = 0

        ElseIf sender.Equals(btnAdd) Then
            tempNum = "+"

        ElseIf sender.Equals(btnMinus) Then
            tempNum = "-"

        ElseIf sender.Equals(btnMultiple) Then
            tempNum = "*"

        ElseIf sender.Equals(btnDivide) Then
            tempNum = "/"

        End If

        tbDisplay.Text = previewNum & tempNum
        previewNum = tbDisplay.Text

        Debug.WriteLine("preview> " + previewNum)
        Debug.WriteLine("temp> " + tempNum.ToString)
        'tbDisplay.Focus.Equals(True)

    End Sub

End Class