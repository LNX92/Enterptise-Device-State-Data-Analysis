Imports System.Data.SQLite
Imports DevExpress.XtraEditors

Public Module ModuleData
    Dim SQLiteConnectionString As SQLite.SQLiteConnection = New SQLiteConnection("Data Source=C:\Enterprise Device State Data Analysis\Data\Dataset.db;Version=3;New=False;Compress=True;")

    Public Sub Multiple_Update_Function()
        Dim sqlite_cmd As SQLiteCommand

        Form1.SplashScreenManager1.ShowWaitForm()
        Form1.SplashScreenManager1.SetWaitFormCaption("Lütfen bekleyiniz.")
        Form1.SplashScreenManager1.SetWaitFormDescription("Veriler güncelleniyor...")

        UpdateForm.GridView1.SelectAll()

        Dim selectedRowHandles As Int32() = UpdateForm.GridView1.GetSelectedRows()
        Dim I As Integer
        For I = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(I)
            If (selectedRowHandle >= 0) Then
                Dim id = CType(UpdateForm.GridView1.GetRowCellValue(selectedRowHandles(I), "id").ToString(), String)
                Dim Cihaz_ID = CType(UpdateForm.GridView1.GetRowCellValue(selectedRowHandles(I), "Cihaz_ID").ToString(), String)
                Dim Cihaz_Uretim_Tarihi = CType(UpdateForm.GridView1.GetRowCellValue(selectedRowHandles(I), "Cihaz_Uretim_Tarihi").ToString(), String)
                Dim Ariza = CType(UpdateForm.GridView1.GetRowCellValue(selectedRowHandles(I), "Ariza").ToString(), String)
                Dim Hurda_Durumu = CType(UpdateForm.GridView1.GetRowCellValue(selectedRowHandles(I), "Hurda_Durumu").ToString(), String)
                Dim Machine_Name = CType(UpdateForm.GridView1.GetRowCellValue(selectedRowHandles(I), "Machine_Name").ToString(), String)

                SQLiteConnectionString.Open()
                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                sqlite_cmd.CommandText = "UPDATE Machines SET Cihaz_Uretim_Tarihi = @Cihaz_Uretim_Tarihi, Ariza = @Ariza, Hurda_Durumu = @Hurda_Durumu, Machine_Name = @Machine_Name WHERE Cihaz_ID = " & "'" & Cihaz_ID & "'" & ";"
                sqlite_cmd.Parameters.AddWithValue("@Cihaz_Uretim_Tarihi", Cihaz_Uretim_Tarihi)
                sqlite_cmd.Parameters.AddWithValue("@Ariza", Ariza)
                sqlite_cmd.Parameters.AddWithValue("@Hurda_Durumu", Hurda_Durumu)
                sqlite_cmd.Parameters.AddWithValue("@Machine_Name", Machine_Name)
                sqlite_cmd.ExecuteNonQuery()
                SQLiteConnectionString.Close()

                SQLiteConnectionString.Open()
                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                sqlite_cmd.CommandText = "UPDATE Update_List SET Cihaz_Uretim_Tarihi = @Cihaz_Uretim_Tarihi, Ariza = @Ariza, Hurda_Durumu = @Hurda_Durumu, Machine_Name = @Machine_Name WHERE id = " & "'" & id & "'" & ";"
                sqlite_cmd.Parameters.AddWithValue("@Cihaz_Uretim_Tarihi", Cihaz_Uretim_Tarihi)
                sqlite_cmd.Parameters.AddWithValue("@Ariza", Ariza)
                sqlite_cmd.Parameters.AddWithValue("@Hurda_Durumu", Hurda_Durumu)
                sqlite_cmd.Parameters.AddWithValue("@Machine_Name", Machine_Name)
                sqlite_cmd.ExecuteNonQuery()
                SQLiteConnectionString.Close()
            End If
        Next

        Self_Login_Load_Data()
        Self_Update_List_Load()

        Form1.SplashScreenManager1.CloseWaitForm()
    End Sub
    Public Sub Self_Update_List_Load()
        Dim sqlite_cmd As SQLiteCommand
        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM Update_List;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        UpdateForm.GridControl1.DataSource = dt
        SQLiteConnectionString.Close()
    End Sub
    Public Sub Transfer_Update_List()
        Dim sqlite_cmd As SQLiteCommand

        Form1.SplashScreenManager1.ShowWaitForm()
        Form1.SplashScreenManager1.SetWaitFormCaption("Lütfen bekleyiniz.")
        Form1.SplashScreenManager1.SetWaitFormDescription("Veriler hazırlanıyor...")

        SQLiteConnectionString.Open()
        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "DELETE FROM Update_List;"
        sqlite_cmd.ExecuteNonQuery()
        SQLiteConnectionString.Close()

        Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
        Dim I As Integer
        For I = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(I)
            If (selectedRowHandle >= 0) Then
                Dim Cihaz_ID = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Cihaz_ID").ToString(), String)
                Dim Cihaz_Uretim_Tarihi = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Cihaz_Uretim_Tarihi").ToString(), String)
                Dim Ariza = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Ariza").ToString(), String)
                Dim Hurda_Durumu = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Hurda_Durumu").ToString(), String)
                Dim Machine_Name = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Machine_Name").ToString(), String)

                SQLiteConnectionString.Open()
                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                sqlite_cmd.CommandText = "INSERT INTO Update_List (Cihaz_ID, Cihaz_Uretim_Tarihi, Ariza, Hurda_Durumu, Machine_Name) VALUES (" & "'" & Cihaz_ID & "'" & "," & "'" & Cihaz_Uretim_Tarihi & "'" & "," & "'" & Ariza & "'" & "," & "'" & Hurda_Durumu & "'" & "," & "'" & Machine_Name & "'" & ");"
                sqlite_cmd.ExecuteNonQuery()
                SQLiteConnectionString.Close()
            End If
        Next

        Self_Update_List_Load()
        Form1.SplashScreenManager1.CloseWaitForm()
        UpdateForm.ShowDialog()
    End Sub
    Public Sub Add_Register()
        Form1.SplashScreenManager1.ShowWaitForm()
        Form1.SplashScreenManager1.SetWaitFormCaption("Lütfen Bekleyiniz.")
        Form1.SplashScreenManager1.SetWaitFormDescription("Veri ekleniyor...")

        Dim RowCountData As Integer = Form1.GridView1.RowCount + 1
        Dim Hurda_Durumu_String = ""

        If (Addform.ComboBoxEdit2.Text.ToString() = "Hurda") Then
            Hurda_Durumu_String = "1"
        Else
            Hurda_Durumu_String = "0"
        End If

        Dim sqlite_cmd As SQLiteCommand

        If (Addform.ComboBoxEdit3.Text <> "") And (Addform.ComboBoxEdit1.Text <> "") And (Addform.ComboBoxEdit2.Text <> "") And (Addform.ComboBoxEdit4.Text <> "") Then
            SQLiteConnectionString.Open()
            sqlite_cmd = SQLiteConnectionString.CreateCommand()
            sqlite_cmd.CommandText = "INSERT INTO Machines (Cihaz_Uretim_Tarihi, Ariza, Hurda_Durumu, Machine_Name) VALUES (" & "'" & Addform.ComboBoxEdit3.Text.ToString() & "'" & "," & "'" & Addform.ComboBoxEdit1.Text.ToString() & "'" & "," & "'" & Hurda_Durumu_String & "'" & "," & "'" & CStr(Addform.ComboBoxEdit4.Text.ToString() & RowCountData.ToString()) & "'" & ");"
            sqlite_cmd.ExecuteNonQuery()
            SQLiteConnectionString.Close()

            Self_Login_Load_Data()
            Addform.Dispose()
            Addform.Hide()
            Form1.SplashScreenManager1.CloseWaitForm()
        Else
            Form1.SplashScreenManager1.CloseWaitForm()
            If XtraMessageBox.Show("Boş alan bırakılmamalıdır.", "Uyarı", MessageBoxButtons.OK) = DialogResult.OK Then
                'Nothing
            End If
        End If

    End Sub
    Public Sub Remove_Selected_Data()
        Form1.SplashScreenManager1.ShowWaitForm()
        Form1.SplashScreenManager1.SetWaitFormCaption("Lütfen Bekleyiniz.")
        Form1.SplashScreenManager1.SetWaitFormDescription("Seçili veriler siliniyor...")

        Dim sqlite_cmd As SQLiteCommand

        Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
        Dim I As Integer
        For I = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(I)
            If (selectedRowHandle >= 0) Then
                Dim Cihaz_ID = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Cihaz_ID").ToString(), String)

                SQLiteConnectionString.Open()
                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                sqlite_cmd.CommandText = "DELETE FROM Machines WHERE Cihaz_ID = " & "'" & Cihaz_ID & "'" & ";"
                sqlite_cmd.ExecuteNonQuery()
                SQLiteConnectionString.Close()
            End If
        Next

        Self_Login_Load_Data()
        Form1.SplashScreenManager1.CloseWaitForm()
    End Sub
    Public Sub F3_Py_Function()
        Dim proc As New Process
        proc.StartInfo.FileName = "C:\Enterprise Device State Data Analysis\PyFunctions\F3.bat"
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.CreateNoWindow = True
        proc.Start()
        proc.WaitForExit()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = proc.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using

        MainOutputForm.RichTextBox_TestOrani.Text = sOutput

        Dim RLine As List(Of String) = MainOutputForm.RichTextBox_TestOrani.Lines.ToList()
        RLine.RemoveAt(0)
        MainOutputForm.RichTextBox_TestOrani.Lines = RLine.ToArray()
        MainOutputForm.RichTextBox_TestOrani.Refresh()
        RLine.RemoveAt(0)
        MainOutputForm.RichTextBox_TestOrani.Lines = RLine.ToArray()
        MainOutputForm.RichTextBox_TestOrani.Refresh()
    End Sub
    Public Sub F5_Py_Function()
        Dim proc As New Process

        proc.StartInfo.FileName = "C:\Enterprise Device State Data Analysis\PyFunctions\F5_Print.bat"
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.CreateNoWindow = True
        proc.Start()
        proc.WaitForExit()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = proc.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using

        MainOutputForm.RichTextBox_Capraz_F.Text = sOutput

        Dim RLine As List(Of String) = MainOutputForm.RichTextBox_Capraz_F.Lines.ToList()
        RLine.RemoveAt(0)
        MainOutputForm.RichTextBox_Capraz_F.Lines = RLine.ToArray()
        MainOutputForm.RichTextBox_Capraz_F.Refresh()
        RLine.RemoveAt(0)
        MainOutputForm.RichTextBox_Capraz_F.Lines = RLine.ToArray()
        MainOutputForm.RichTextBox_Capraz_F.Refresh()

        Dim proc2 As New Process

        proc2.StartInfo.FileName = "C:\Enterprise Device State Data Analysis\PyFunctions\F5.bat"
        proc2.StartInfo.UseShellExecute = False
        proc2.StartInfo.RedirectStandardOutput = True
        proc2.StartInfo.CreateNoWindow = True
        proc2.Start()
    End Sub

    Public Sub F4_Py_Function()
        Dim proc As New Process

        proc.StartInfo.FileName = "C:\Enterprise Device State Data Analysis\PyFunctions\F4_Print.bat"
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.CreateNoWindow = True
        proc.Start()
        proc.WaitForExit()


        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = proc.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using

        MainOutputForm.RichTextBox_KNN_F.Text = sOutput

        Dim RLine As List(Of String) = MainOutputForm.RichTextBox_KNN_F.Lines.ToList()
        RLine.RemoveAt(0)
        MainOutputForm.RichTextBox_KNN_F.Lines = RLine.ToArray()
        MainOutputForm.RichTextBox_KNN_F.Refresh()
        RLine.RemoveAt(0)
        MainOutputForm.RichTextBox_KNN_F.Lines = RLine.ToArray()
        MainOutputForm.RichTextBox_KNN_F.Refresh()

        Dim proc2 As New Process

        proc2.StartInfo.FileName = "C:\Enterprise Device State Data Analysis\PyFunctions\F4.bat"
        proc2.StartInfo.UseShellExecute = False
        proc2.StartInfo.RedirectStandardOutput = True
        proc2.StartInfo.CreateNoWindow = True
        proc2.Start()
    End Sub
    Public Sub Self_Login_Load_Data()
        Dim sqlite_cmd As SQLiteCommand
        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM Machines;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl1.DataSource = dt
        SQLiteConnectionString.Close()
    End Sub
End Module
