Imports System.IO
Imports System.Windows
Imports MySql.Data.MySqlClient

Public Class admin
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me

            Call Connect_to_DB()

            Dim mycmd As New MySqlCommand

            Dim cmd As New MySqlCommand("SELECT * FROM products", myconn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            adapter.Fill(ds, "products")

            DataGridView1.DataSource = ds.Tables("products")

            Dim anotherCmd As New MySqlCommand("SELECT COUNT(*) FROM products", myconn)
            Dim totalProducts As Integer = CInt(anotherCmd.ExecuteScalar())
            txtProducts.Text = totalProducts.ToString()

            Call Disconnect_to_DB()

        End With
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim productId As Integer = CInt(selectedRow.Cells("productid").Value)
        Dim productName As String = CStr(selectedRow.Cells("product").Value)
        Dim categoryid As Integer = CInt(selectedRow.Cells("categoryid").Value)
        Dim productPrice As Double = CDbl(selectedRow.Cells("price").Value)
        Form5.productid.Text = productId.ToString()
        Form5.product.Text = productName
        Form5.categoryid.text = categoryid.ToString()
        Form5.price.Text = productPrice.ToString()
        Form5.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Hide()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Create an OpenFileDialog to select the CSV file
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' Read the contents of the CSV file into a DataTable
            Dim dt As New DataTable()
            Using sr As New StreamReader(openFileDialog1.FileName)
                Dim headers() As String = sr.ReadLine().Split(","c)
                For Each header In headers
                    ' Check whether the column already exists
                    If Not dt.Columns.Contains(header) Then
                        dt.Columns.Add(header)
                    End If
                Next
                While Not sr.EndOfStream
                    Dim rows() As String = sr.ReadLine().Split(","c)
                    Dim dr As DataRow = dt.NewRow()
                    For i As Integer = 0 To headers.Length - 1
                        ' Check whether the column index is valid
                        If i < rows.Length Then
                            dr(i) = rows(i)
                        End If
                    Next
                    dt.Rows.Add(dr)
                End While
            End Using

            ' Bind the DataTable to the DataGridView
            DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Display a warning message asking the user if they want to proceed with the backup
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to backup your database?", "Backup Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks Yes, proceed with the backup
        If result = DialogResult.Yes Then
            ' Create a backup file name based on the current date and time
            Dim backupFileName As String = $"fooderia_backup_{DateTime.Now.ToString("yyyyMMddHHmmss")}.sql"
            Dim backupFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), backupFileName)

            ' Backup the database to the specified file
            Try
                Connect_to_DB()
                Dim cmd As New Process()
                cmd.StartInfo.FileName = "cmd.exe"
                cmd.StartInfo.RedirectStandardInput = True
                cmd.StartInfo.RedirectStandardOutput = True
                cmd.StartInfo.CreateNoWindow = True
                cmd.StartInfo.UseShellExecute = False
                cmd.Start()
                Dim backupCommand As String = $"mysqldump -u root -pAaron_889 --lock-tables=false --routines --triggers fooderia > ""{backupFilePath}"""
                cmd.StandardInput.WriteLine(backupCommand)
                cmd.StandardInput.Flush()
                cmd.StandardInput.Close()
                cmd.WaitForExit()
                Disconnect_to_DB()

                ' Display the path to the backup file in a textbox
                TextBox1.Text = backupFilePath

                ' Display a success message
                MessageBox.Show("Database backup completed successfully.", "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"An error occurred during the backup process: {ex.Message}", "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class