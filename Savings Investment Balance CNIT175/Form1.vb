Public Class Form1

    Public Const euler As Decimal = 2.71828183

    Dim ttlInvestments As Integer

    Dim ttlPrincipal As Integer

    Dim properCaseValue As String

    Dim valPrincipal As Decimal

    Dim valInterest As Decimal

    Dim cleanString As String

    Dim okToCalculate As Boolean

    Dim ttlBalance As Decimal

    Dim getTheTotal As String

    Dim ttlYears As Integer

    Dim finalBalance As Decimal

    Dim valPrincipadlCHK As String

    Dim valInterestCHK As String
    Public Function RemoveSpecialChars(DirtyString As String, CharacterToRemove As String)

        Try

            'Remove a character from a string. Stripping any stray $ or % that may be entered into the fields

            cleanString = Replace(DirtyString, CharacterToRemove, "")

            Return cleanString

        Catch ex As Exception

            Err.Clear()

            Return False

        End Try

    End Function
    Public Function ToProperCase(ProperStringVal As String)

        Try

            'Input any string and output a string in Proper Case

            properCaseValue = StrConv(ProperStringVal, vbProperCase)

            Return properCaseValue

        Catch ex As Exception

            Err.Clear()

            Return False

        End Try

    End Function

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Time to close

        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setting the stats variables to 0 on session load

        ttlInvestments = 0

        ttlPrincipal = 0

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Try

            'Clearing all entered values

            radFive.Checked = False

            radTen.Checked = False

            radFifteen.Checked = False

            radTwenty.Checked = False

            txtFname.Text = vbNullString

            txtLname.Text = vbNullString

            txtInterest.Text = vbNullString

            txtPrincipal.Text = vbNullString

            txtOutput.Text = vbNullString

            txtFname.Focus()

        Catch ex As Exception

            Err.Clear()

        End Try

    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click

        Try

            'Displaying the sessions stats

            txtOutput.Text = "Number of clients processed: " & ttlInvestments.ToString & vbNewLine & "Total money invested: " & ttlPrincipal.ToString

        Catch ex As Exception

            Err.Clear()

        End Try

    End Sub

    Public Sub DisplayMessageOK(msgToDisplay As String)

        Try

            'Displaying whatever message is passed to the Sub

            MessageBox.Show(msgToDisplay, "Display Message Handler", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            Err.Clear()

        End Try

    End Sub
    Public Function ValidateInput()

        'Validating each input item 

        Try

            'Trimming textboxes so that the value cannot be blank or a space. If it is blank it will fail validation

            txtFname.Text = Trim(txtFname.Text)

            If txtFname.Text = "" Then

                DisplayMessageOK("You Must Enter A First Name")

                txtFname.Focus()

                Return False

            End If

            txtLname.Text = Trim(txtLname.Text)

            If txtLname.Text = "" Then

                DisplayMessageOK("You Must Enter A Last Name")

                txtLname.Focus()

                Return False

            End If

            txtPrincipal.Text = Trim(txtPrincipal.Text)

            If txtPrincipal.Text = "" Then

                DisplayMessageOK("You Must Enter A Principal Value")

                txtPrincipal.Focus()

                Return False

            End If

            txtInterest.Text = Trim(txtInterest.Text)

            If txtInterest.Text = "" Then

                DisplayMessageOK("You Must Enter An Interest Value")

                txtInterest.Focus()

                Return False

            End If

            'Removing any $ from the field

            txtPrincipal.Text = RemoveSpecialChars(txtPrincipal.Text, "$")

            'Validating Principal Is Numberic

            If Not Decimal.TryParse(txtPrincipal.Text, valPrincipadlCHK) Then

                DisplayMessageOK("The Principal Amount Must Be A Numeric Value Between 500 And 25000")

                Return False

            End If

            'Converting the value to a decimal

            valPrincipal = Convert.ToDecimal(txtPrincipal.Text)

            'Validating the value agains tthe criteria (Between 500 and 25000)

            If valPrincipal <= 499 Or valPrincipal >= 25001 Then

                DisplayMessageOK("The Principal Value Must Be A Number Between 500 And 25000")

                txtPrincipal.Focus()

                Return False

            End If

            'Removing any % from the field

            txtInterest.Text = RemoveSpecialChars(txtInterest.Text, "%")

            If Not Decimal.TryParse(txtInterest.Text, valInterestCHK) Then

                DisplayMessageOK("The Interest Amount Must Be A Numeric Value Between .50 And 5.25")

                Return False

            End If

            'Converting the value to a decimal

            valInterest = Convert.ToDecimal(txtInterest.Text)

            'Validating Interest Is Numeric

            'Validating the value against the criteria (Between .5 and 5.25)

            If valInterest <= 0.49 Or valInterest >= 5.26 Then

                DisplayMessageOK("The Interest Value Must Be A Number Between .50 And 5.25")

                txtInterest.Focus()

                Return False

            End If

            'Validating that ONE radio button is pressed

            If radFive.Checked = False And radTen.Checked = False And radFifteen.Checked = False And radTwenty.Checked = False Then

                DisplayMessageOK("You Must Select A Year Option")

                Return False

            End If

            'Setting the years variable based on which radio button is selected

            If radFive.Checked = True Then

                ttlYears = 5

            End If

            If radTen.Checked = True Then

                ttlYears = 10

            End If

            If radFifteen.Checked = True Then

                ttlYears = 15

            End If

            If radTwenty.Checked = True Then

                ttlYears = 20

            End If

            Return True

        Catch ex As Exception

            DisplayMessageOK("ERR")

            Return False

        End Try

    End Function
    Public Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        'Button to begin validation and computation

        Try

            okToCalculate = ValidateInput()

            If okToCalculate = True Then

                'Setting the name fields to Proper Case'

                txtFname.Text = ToProperCase(txtFname.Text)

                txtLname.Text = ToProperCase(txtLname.Text)

                'Incrementing the investments and principal variables for the stats

                ttlInvestments = ttlInvestments + 1

                ttlPrincipal = ttlPrincipal + valPrincipal

                'Performing the main computation and outputting the values to the txtbox

                getTheTotal = ComputeBalance(valPrincipal, ttlYears, valInterest)

                txtOutput.Text = "Client Name: " & txtFname.Text & " " & txtLname.Text & vbNewLine & "Principal Invested: $" & txtPrincipal.Text & vbNewLine &
                    "Annual Interest Rate: " & txtInterest.Text & "%" & vbNewLine & "Duration In Years: " & ttlYears.ToString & vbNewLine & "Balance Of Investment: $" & getTheTotal

            Else

                'Do Nothing

            End If

        Catch ex As Exception

            Err.Clear()

        End Try

    End Sub

    Public Function ComputeBalance(investAmount As Decimal, yearAmount As Decimal, interestAmount As Decimal)

        'Do the compute function now that all of the validation has completed successfully

        Try

            'finalBalance variable will be the value of the ----->  balance = principal * e^(rate * y)   <------ formula

            'Converting percent to decimal for equation

            'USE one of the following to convert the percent to decimal by dividing the percentage value by 100

            '-------> interestAmount = interestAmount / 100

            'OR'

            interestAmount /= 100

            finalBalance = investAmount * euler ^ (interestAmount * yearAmount)

            'Rounding the final value to 2 decimal places for display as a currency value

            finalBalance = Math.Round(finalBalance, 2)

            Return finalBalance

        Catch ex As Exception

            Return False

        End Try

    End Function

End Class
