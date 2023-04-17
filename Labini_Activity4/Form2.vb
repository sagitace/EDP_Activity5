Imports MySql.Data.MySqlClient

Public Class Fooderia
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect_to_DB()
        Dim mycmd As New MySqlCommand
        mycmd.Connection = myconn

        Dim commandText As String = "SELECT product, categoryid, price FROM products"
        Dim command As MySqlCommand = New MySqlCommand(commandText, mycmd.Connection)


        Dim reader As MySqlDataReader = command.ExecuteReader()
        Dim productName As String = ""
        Dim productPrice As Decimal = 0

        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim c As Integer = 0

        While reader.Read()

            productName = reader.GetString("product")
            productPrice = reader.GetDecimal("price")
            Dim category As Integer = reader.GetInt32("categoryid")
            Dim checkBox As New CheckBox()
            checkBox.Text = productName & " - P" & productPrice.ToString()
            checkBox.Size = New Size(500, 36)
            checkBox.Font = New Font(checkBox.Font.FontFamily, 12)

            AddHandler checkBox.CheckedChanged, AddressOf CheckBox_CheckedChanged

            Select Case category
                Case 11
                    Panel1.Controls.Add(checkBox)
                    checkBox.Location = New Point(10, a * 40)
                    a += 1
                Case 12
                    Panel2.Controls.Add(checkBox)
                    checkBox.Location = New Point(10, b * 40)
                    b += 1
                Case 13
                    Panel3.Controls.Add(checkBox)
                    checkBox.Location = New Point(10, c * 40)
                    c += 1
            End Select

        End While



        reader.Close()
        Call Disconnect_to_DB()
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Dim total As Decimal = 0

        For Each control As Control In Me.Controls
            If TypeOf control Is Panel Then
                For Each checkbox As Control In control.Controls
                    If TypeOf checkbox Is CheckBox AndAlso DirectCast(checkbox, CheckBox).Checked Then
                        ' Parse the price from the checkbox text
                        Dim priceString As String = DirectCast(checkbox, CheckBox).Text.Split("-")(1).Trim().Substring(1)
                        Dim price As Decimal = Decimal.Parse(priceString)

                        ' Add the price to a running total
                        total += price
                    End If
                Next
            End If
        Next

        ' Do something with the total price, like display it in a label or textbox

        amount.Text = "₱" & total.ToString()
        AddHandler txtCashTendered.TextChanged, AddressOf txtCashTendered_TextChanged


    End Sub
    Private Sub txtCashTendered_TextChanged(sender As Object, e As EventArgs) Handles txtCashTendered.TextChanged
        Dim cashTendered As Decimal
        If Decimal.TryParse(txtCashTendered.Text.Trim(), cashTendered) Then
            Dim change As Decimal = cashTendered - Decimal.Parse(amount.Text.TrimStart("₱"))
            changetxt.Text = "₱" & change.ToString()
        Else
            changetxt.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Hide()
    End Sub


End Class