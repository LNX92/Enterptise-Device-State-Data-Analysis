Imports DevExpress.Utils.DragDrop
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class Form1

    Public DragDropMode As String = "0"

    Public Sub New()
        InitializeComponent()
        HandleBehaviorDragDropEvents()
    End Sub
    Public Sub HandleBehaviorDragDropEvents()
        Dim gridControlBehavior As DragDropBehavior = BehaviorManager1.GetBehavior(Of DragDropBehavior)(GridView1)
        AddHandler gridControlBehavior.DragDrop, AddressOf Behavior_DragDrop
        AddHandler gridControlBehavior.DragOver, AddressOf Behavior_DragOver
    End Sub

    Private Sub Behavior_DragOver(ByVal sender As Object, ByVal e As DragOverEventArgs)
        Dim args As DragOverGridEventArgs = DragOverGridEventArgs.GetDragOverGridEventArgs(e)
        e.InsertType = args.InsertType
        e.InsertIndicatorLocation = args.InsertIndicatorLocation
        e.Action = args.Action
        Cursor.Current = args.Cursor
        args.Handled = True
    End Sub

    Private Sub Behavior_DragDrop(ByVal sender As Object, ByVal e As DragDropEventArgs)
        Dim targetGrid As GridView = TryCast(e.Target, GridView)
        Dim sourceGrid As GridView = TryCast(e.Source, GridView)
        If e.Action = DragDropActions.None OrElse targetGrid IsNot sourceGrid Then Return
        Dim sourceTable As DataTable = TryCast(sourceGrid.GridControl.DataSource, DataTable)
        Dim hitPoint As Point = targetGrid.GridControl.PointToClient(Cursor.Position)
        Dim hitInfo As GridHitInfo = targetGrid.CalcHitInfo(hitPoint)
        Dim sourceHandles As Integer() = e.GetData(Of Integer())()
        Dim targetRowHandle As Integer = hitInfo.RowHandle
        Dim targetRowIndex As Integer = targetGrid.GetDataSourceRowIndex(targetRowHandle)
        Dim draggedRows As List(Of DataRow) = New List(Of DataRow)()
        For Each sourceHandle As Integer In sourceHandles
            Dim oldRowIndex As Integer = sourceGrid.GetDataSourceRowIndex(sourceHandle)
            Dim oldRow As DataRow = sourceTable.Rows(oldRowIndex)
            draggedRows.Add(oldRow)
        Next

        Dim newRowIndex As Integer
        Select Case e.InsertType
            Case InsertType.Before
                newRowIndex = If(targetRowIndex > sourceHandles(sourceHandles.Length - 1), targetRowIndex - 1, targetRowIndex)
                For i As Integer = draggedRows.Count - 1 To 0 Step -1
                    Dim oldRow As DataRow = draggedRows(i)
                    Dim newRow As DataRow = sourceTable.NewRow()
                    newRow.ItemArray = oldRow.ItemArray
                    sourceTable.Rows.Remove(oldRow)
                    sourceTable.Rows.InsertAt(newRow, newRowIndex)
                Next

            Case InsertType.After
                newRowIndex = If(targetRowIndex < sourceHandles(0), targetRowIndex + 1, targetRowIndex)
                For i As Integer = 0 To draggedRows.Count - 1
                    Dim oldRow As DataRow = draggedRows(i)
                    Dim newRow As DataRow = sourceTable.NewRow()
                    newRow.ItemArray = oldRow.ItemArray
                    sourceTable.Rows.Remove(oldRow)
                    sourceTable.Rows.InsertAt(newRow, newRowIndex)
                Next

            Case Else
                newRowIndex = -1
        End Select

        Dim insertedIndex As Integer = targetGrid.GetRowHandle(newRowIndex)
        targetGrid.FocusedRowHandle = insertedIndex
        targetGrid.SelectRow(targetGrid.FocusedRowHandle)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleData.Self_Login_Load_Data()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        SplashScreenManager1.ShowWaitForm()
        SplashScreenManager1.SetWaitFormCaption("Lütfen bekleyiniz.")
        SplashScreenManager1.SetWaitFormDescription("Veriler analiz ediliyor...")

        DenemeForm.RichTextBox1.Clear()

        System.IO.File.Delete("C:\Enterprise Device State Data Analysis\Data\Dataset\Machines.csv")
        DenemeForm.RichTextBox1.Text = CStr("Cihaz_ID,Cihaz_Uretim_Tarihi,Ariza,Hurda_Durumu") & vbNewLine
        GridView1.SelectAll()

        Dim selectedRowHandles As Int32() = GridView1.GetSelectedRows()
        Dim I As Integer
        For I = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(I)
            If (selectedRowHandle >= 0) Then
                Dim Cihaz_ID = CType(GridView1.GetRowCellValue(selectedRowHandles(I), "Cihaz_ID").ToString(), String)
                Dim Cihaz_Uretim_Tarihi = CType(GridView1.GetRowCellValue(selectedRowHandles(I), "Cihaz_Uretim_Tarihi").ToString(), String)
                Dim Ariza = CType(GridView1.GetRowCellValue(selectedRowHandles(I), "Ariza").ToString(), String)
                Dim Hurda_Durumu = CType(GridView1.GetRowCellValue(selectedRowHandles(I), "Hurda_Durumu").ToString(), String)

                DenemeForm.RichTextBox1.Text += CStr(Cihaz_ID & "," & Cihaz_Uretim_Tarihi & "," & Ariza & "," & Hurda_Durumu) & vbNewLine
            End If
        Next

        System.IO.File.WriteAllLines("C:\Enterprise Device State Data Analysis\Data\Dataset\Machines.csv", DenemeForm.RichTextBox1.Text.Split({"\n"}, StringSplitOptions.None))
        Self_Login_Load_Data()

        System.Threading.Thread.Sleep(2000)

        ModuleData.F3_Py_Function()
        ModuleData.F4_Py_Function()
        ModuleData.F5_Py_Function()

        MainOutputForm.Show()
        System.Threading.Thread.Sleep(15000)
        SplashScreenManager1.CloseWaitForm()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = False

        For Each prog As Process In Process.GetProcesses
            If prog.ProcessName = "python" Then
                prog.Kill()
            End If
        Next

        For Each prog As Process In Process.GetProcesses
            If prog.ProcessName = "pythonw" Then
                prog.Kill()
            End If
        Next
    End Sub

    Private Sub GridView1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If (GridView1.SelectedRowsCount < 1) Then
            BarButtonItem2.Enabled = False
            BarButtonItem3.Enabled = False
        Else
            BarButtonItem2.Enabled = True
            BarButtonItem3.Enabled = True
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ModuleData.Remove_Selected_Data()
    End Sub

    Private Sub GridControl1_DataSourceChanged(sender As Object, e As EventArgs) Handles GridControl1.DataSourceChanged
        BarButtonItem2.Enabled = False
        BarButtonItem3.Enabled = False
    End Sub

    Private Sub AccordionControlElement1_Click(sender As Object, e As EventArgs) Handles AccordionControlElement1.Click
        Addform.ShowDialog()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        ModuleData.Transfer_Update_List()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If (XtraSaveFileDialog1.ShowDialog() = DialogResult.OK) Then
            GridView1.ExportToXlsx(XtraSaveFileDialog1.FileName.ToString())
        Else
            'Nothing
        End If
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        AboutForm.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BarStaticItem1.Caption = CStr("Veri Sayısı : " & GridView1.RowCount.ToString())
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If (DragDropMode = "0") Then
            DragDropMode = "1"
            BarButtonItem7.Caption = "Sürükleme Modu : Açık"

            GridView1.OptionsSelection.UseIndicatorForSelection = True
            GridView1.OptionsView.ShowIndicator = True
            GridView1.OptionsSelection.MultiSelect = False
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
        ElseIf (DragDropMode = "1") Then
            DragDropMode = "0"
            BarButtonItem7.Caption = "Sürükleme Modu : Kapalı"

            GridView1.OptionsSelection.UseIndicatorForSelection = False
            GridView1.OptionsView.ShowIndicator = False
            GridView1.OptionsSelection.MultiSelect = True
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
        End If
    End Sub
End Class
