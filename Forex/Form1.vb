Imports System.Reflection
Imports System.Runtime.Serialization.Formatters
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Form1

    Private Sub CB1_SelectedIdexChanged(sender As Object, e As EventArgs) Handles CB1.SelectedIndexChanged

        Select Case CB1.SelectedIndex
            Case 0
                PicB1.Image = My.Resources.america
            Case 1
                PicB1.Image = My.Resources.hongkong
            Case 2
                PicB1.Image = My.Resources.canada
            Case 3
                PicB1.Image = My.Resources.india
            Case 4
                PicB1.Image = My.Resources.SriLanka
            Case 5
                PicB1.Image = My.Resources.UAE
            Case 6
                PicB1.Image = My.Resources.PH
            Case 7
                PicB1.Image = My.Resources.uk
            Case 8
                PicB1.Image = My.Resources.japan
            Case 9
                PicB1.Image = My.Resources.euro
        End Select

        If CB1.SelectedIndex = 0 And CB2.SelectedIndex = 0 Then
            MessageBox.Show("Unable to convert, same currency",
                      "Error")

            CB1.SelectedIndex = -1
            PicB1.Image = Nothing


        ElseIf CB1.SelectedIndex = 1 And CB2.SelectedIndex = 1 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB1.SelectedIndex = -1
            PicB1.Image = Nothing

        ElseIf CB1.SelectedIndex = 2 And CB2.SelectedIndex = 2 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB1.SelectedIndex = -1
            PicB1.Image = Nothing

        ElseIf CB1.SelectedIndex = 3 And CB2.SelectedIndex = 3 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB1.SelectedIndex = -1
            PicB1.Image = Nothing

        ElseIf CB1.SelectedIndex = 4 And CB2.SelectedIndex = 4 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB1.SelectedIndex = -1
            PicB1.Image = Nothing

        ElseIf CB1.SelectedIndex = 5 And CB2.SelectedIndex = 5 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB1.SelectedIndex = -1
            PicB1.Image = Nothing

        ElseIf CB1.SelectedIndex = 6 And CB2.SelectedIndex = 6 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB1.SelectedIndex = -1
            PicB1.Image = Nothing

        ElseIf CB1.SelectedIndex = 7 And CB2.SelectedIndex = 7 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB1.SelectedIndex = -1
            PicB1.Image = Nothing

        ElseIf CB1.SelectedIndex = 8 And CB2.SelectedIndex = 8 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB1.SelectedIndex = -1
            PicB1.Image = Nothing

        ElseIf CB1.SelectedIndex = 9 And CB2.SelectedIndex = 9 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB1.SelectedIndex = -1
            PicB1.Image = Nothing

        End If

    End Sub

    Private Sub CB2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB2.SelectedIndexChanged


        Select Case CB2.SelectedIndex

            Case 0
                PicB2.Image = My.Resources.america
            Case 1
                PicB2.Image = My.Resources.hongkong
            Case 2
                PicB2.Image = My.Resources.canada
            Case 3
                PicB2.Image = My.Resources.india
            Case 4
                PicB2.Image = My.Resources.SriLanka
            Case 5
                PicB2.Image = My.Resources.UAE
            Case 6
                PicB2.Image = My.Resources.PH
            Case 7
                PicB2.Image = My.Resources.uk
            Case 8
                PicB2.Image = My.Resources.japan
            Case 9
                PicB2.Image = My.Resources.euro

        End Select

        If CB2.SelectedIndex = 0 And CB1.SelectedIndex = 0 Then
            MessageBox.Show("Unable to convert, same currency",
                      "Error")

            CB2.SelectedIndex = -1
            PicB2.Image = Nothing


        ElseIf CB2.SelectedIndex = 1 And CB1.SelectedIndex = 1 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB2.SelectedIndex = -1
            PicB2.Image = Nothing

        ElseIf CB2.SelectedIndex = 2 And CB1.SelectedIndex = 2 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB2.SelectedIndex = -1
            PicB2.Image = Nothing

        ElseIf CB2.SelectedIndex = 3 And CB1.SelectedIndex = 3 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB2.SelectedIndex = -1
            PicB2.Image = Nothing

        ElseIf CB2.SelectedIndex = 4 And CB1.SelectedIndex = 4 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB2.SelectedIndex = -1
            PicB2.Image = Nothing

        ElseIf CB2.SelectedIndex = 5 And CB1.SelectedIndex = 5 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB2.SelectedIndex = -1
            PicB2.Image = Nothing

        ElseIf CB2.SelectedIndex = 6 And CB1.SelectedIndex = 6 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB2.SelectedIndex = -1
            PicB2.Image = Nothing

        ElseIf CB2.SelectedIndex = 7 And CB1.SelectedIndex = 7 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB2.SelectedIndex = -1
            PicB2.Image = Nothing

        ElseIf CB2.SelectedIndex = 8 And CB1.SelectedIndex = 8 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB2.SelectedIndex = -1
            PicB2.Image = Nothing

        ElseIf CB2.SelectedIndex = 9 And CB1.SelectedIndex = 9 Then
            MessageBox.Show("Unable to convert, same currency",
                          "Error")

            CB2.SelectedIndex = -1
            PicB2.Image = Nothing
        End If

    End Sub

    Private Sub AmountTextChanged(sender As Object, e As EventArgs) Handles TxtB1.TextChanged

        If Not String.IsNullOrEmpty(TxtB1.Text) Then
            Dim Amount As Decimal
            If Decimal.TryParse(TxtB1.Text, Amount) Then

            End If

            Dim convertedAmount As Double

            TxtB2.Text = convertedAmount.ToString()

            Select Case CB1.SelectedIndex

                Case 0

                    Select Case CB2.SelectedIndex

                        Case 1
                            convertedAmount = Amount * 7.83
                        Case 2
                            convertedAmount = Amount * 1.37
                        Case 3
                            convertedAmount = Amount * 83.12
                        Case 4
                            convertedAmount = Amount * 322.66
                        Case 5
                            convertedAmount = Amount * 3.67
                        Case 6
                            convertedAmount = Amount * 56.7
                        Case 7
                            convertedAmount = Amount * 0.82
                        Case 8
                            convertedAmount = Amount * 149.22
                        Case 9
                            convertedAmount = Amount * 0.94


                    End Select

                Case 1
                    Select Case CB2.SelectedIndex

                        Case 0
                            convertedAmount = Amount * 0.13
                        Case 2
                            convertedAmount = Amount * 0.17
                        Case 3
                            convertedAmount = Amount * 10.61
                        Case 4
                            convertedAmount = Amount * 41.2
                        Case 5
                            convertedAmount = Amount * 0.47
                        Case 6
                            convertedAmount = Amount * 7.21
                        Case 7
                            convertedAmount = Amount * 0.1
                        Case 8
                            convertedAmount = Amount * 19.05
                        Case 9
                            convertedAmount = Amount * 0.12
                    End Select

                Case 2
                    Select Case CB2.SelectedIndex
                        Case 0
                            convertedAmount = Amount * 0.73
                        Case 1
                            convertedAmount = Amount * 5.72
                        Case 3
                            convertedAmount = Amount * 60.74
                        Case 4
                            convertedAmount = Amount * 235.8
                        Case 5
                            convertedAmount = Amount * 2.68
                        Case 6
                            convertedAmount = Amount * 41.44
                        Case 7
                            convertedAmount = Amount * 0.6
                        Case 8
                            convertedAmount = Amount * 109.05
                        Case 9
                            convertedAmount = Amount * 0.69
                    End Select

                Case 3
                    Select Case CB2.SelectedIndex
                        Case 0
                            convertedAmount = Amount * 0.012
                        Case 1
                            convertedAmount = Amount * 0.094
                        Case 2
                            convertedAmount = Amount * 0.016
                        Case 4
                            convertedAmount = Amount * 3.88
                        Case 5
                            convertedAmount = Amount * 0.044
                        Case 6
                            convertedAmount = Amount * 0.68
                        Case 7
                            convertedAmount = Amount * 0.0098
                        Case 8
                            convertedAmount = Amount * 1.8
                        Case 9
                            convertedAmount = Amount * 0.011
                    End Select

                Case 4
                    Select Case CB2.SelectedIndex
                        Case 0
                            convertedAmount = Amount * 0.00309125
                        Case 1
                            convertedAmount = Amount * 0.0241692
                        Case 2
                            convertedAmount = Amount * 0.0042
                        Case 3
                            convertedAmount = Amount * 0.256827
                        Case 5
                            convertedAmount = Amount * 0.0113
                        Case 6
                            convertedAmount = Amount * 0.1757
                        Case 7
                            convertedAmount = Amount * 0.00252114
                        Case 8
                            convertedAmount = Amount * 0.458496
                        Case 9
                            convertedAmount = Amount * 0.0029264
                    End Select

                Case 5
                    Select Case CB2.SelectedIndex
                        Case 0
                            convertedAmount = Amount * 0.27
                        Case 1
                            convertedAmount = Amount * 2.13
                        Case 2
                            convertedAmount = Amount * 0.37
                        Case 3
                            convertedAmount = Amount * 22.63
                        Case 4
                            convertedAmount = Amount * 22.63
                        Case 6
                            convertedAmount = Amount * 15.44
                        Case 7
                            convertedAmount = Amount * 0.22
                        Case 8
                            convertedAmount = Amount * 40.63
                        Case 9
                            convertedAmount = Amount * 0.26
                    End Select

                Case 6
                    Select Case CB2.SelectedIndex
                        Case 0
                            convertedAmount = Amount * 0.018
                        Case 1
                            convertedAmount = Amount * 0.024
                        Case 2
                            convertedAmount = Amount * 0.37
                        Case 3
                            convertedAmount = Amount * 1.47
                        Case 4
                            convertedAmount = Amount * 5.69
                        Case 5
                            convertedAmount = Amount * 0.065
                        Case 7
                            convertedAmount = Amount * 0.014
                        Case 8
                            convertedAmount = Amount * 2.63
                        Case 9
                            convertedAmount = Amount * 0.017
                    End Select

                Case 7
                    Select Case CB2.SelectedIndex
                        Case 0
                            convertedAmount = Amount * 1.22
                        Case 1
                            convertedAmount = Amount * 9.59
                        Case 2
                            convertedAmount = Amount * 1.67
                        Case 3
                            convertedAmount = Amount * 101.74
                        Case 4
                            convertedAmount = Amount * 394.94
                        Case 5
                            convertedAmount = Amount * 4.5
                        Case 6
                            convertedAmount = Amount * 69.4
                        Case 8
                            convertedAmount = Amount * 182.65
                        Case 9
                            convertedAmount = Amount * 1.15
                    End Select

                Case 8
                    Select Case CB2.SelectedIndex
                        Case 0
                            convertedAmount = Amount * 0.0067
                        Case 1
                            convertedAmount = Amount * 0.052
                        Case 2
                            convertedAmount = Amount * 0.0092
                        Case 3
                            convertedAmount = Amount * 0.56
                        Case 4
                            convertedAmount = Amount * 2.16
                        Case 5
                            convertedAmount = Amount * 0.025
                        Case 6
                            convertedAmount = Amount * 0.38
                        Case 7
                            convertedAmount = Amount * 0.0055
                        Case 9
                            convertedAmount = Amount * 0.0063
                    End Select

                Case 9
                    Select Case CB2.SelectedIndex
                        Case 0
                            convertedAmount = Amount * 1.06
                        Case 1
                            convertedAmount = Amount * 8.29
                        Case 2
                            convertedAmount = Amount * 1.45
                        Case 3
                            convertedAmount = Amount * 0.56
                        Case 4
                            convertedAmount = Amount * 342.07
                        Case 5
                            convertedAmount = Amount * 3.89
                        Case 6
                            convertedAmount = Amount * 60.11
                        Case 7
                            convertedAmount = Amount * 0.87
                        Case 8
                            convertedAmount = Amount * 60.11
                    End Select

            End Select


            TxtB2.Text = convertedAmount

        Else
            TxtB2.Text = "0.00"
        End If

    End Sub


    Private Sub TxtB1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtB1.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ans As DialogResult

        ans = MessageBox.Show("Are you sure you want to exit?",
                        "Exit Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            Application.Exit()

        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        Dim ans As DialogResult

        ans = MessageBox.Show("Are you sure you want to reset?",
                        "Reset Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            TxtB1.Text = ""
            TxtB2.Text = ""

            CB1.SelectedIndex = -1
            CB2.SelectedIndex = -1

            PicB1.Image = Nothing
            PicB2.Image = Nothing

        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

    End Sub


End Class
