<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox_Uretim_Tarihi = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox_Ariza = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox_HurdaDurumu = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox_Uretim_Tarihi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox_Ariza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox_HurdaDurumu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BarButtonItem1})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 2
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.Size = New System.Drawing.Size(1108, 87)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Verleri Güncelle"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.Image = Global.Enterptise_Device_State_Data_Analysis.My.Resources.Resources.update32
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.ImageOptions.Image = Global.Enterptise_Device_State_Data_Analysis.My.Resources.Resources.tools32
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Araçlar"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(0, 91)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox_Uretim_Tarihi, Me.RepositoryItemComboBox_Ariza, Me.RepositoryItemComboBox_HurdaDurumu})
        Me.GridControl1.Size = New System.Drawing.Size(1108, 506)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplandırmak için sürükleyiniz..."
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindDelay = 250
        Me.GridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.GridView1.OptionsFind.FindNullPrompt = "Herhangi birşey arayınız..."
        Me.GridView1.OptionsFind.ParserKind = DevExpress.Data.Filtering.FindPanelParserKind.Mixed
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowShowHide = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "CIHAZ ID"
        Me.GridColumn2.FieldName = "Cihaz_ID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "CIHAZ URETIM TARIHI"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemComboBox_Uretim_Tarihi
        Me.GridColumn3.FieldName = "Cihaz_Uretim_Tarihi"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'RepositoryItemComboBox_Uretim_Tarihi
        '
        Me.RepositoryItemComboBox_Uretim_Tarihi.AutoHeight = False
        Me.RepositoryItemComboBox_Uretim_Tarihi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox_Uretim_Tarihi.Items.AddRange(New Object() {"1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050"})
        Me.RepositoryItemComboBox_Uretim_Tarihi.Name = "RepositoryItemComboBox_Uretim_Tarihi"
        Me.RepositoryItemComboBox_Uretim_Tarihi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "ARIZA"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemComboBox_Ariza
        Me.GridColumn4.FieldName = "Ariza"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'RepositoryItemComboBox_Ariza
        '
        Me.RepositoryItemComboBox_Ariza.AutoHeight = False
        Me.RepositoryItemComboBox_Ariza.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox_Ariza.Items.AddRange(New Object() {"Batarya", "LCD"})
        Me.RepositoryItemComboBox_Ariza.Name = "RepositoryItemComboBox_Ariza"
        Me.RepositoryItemComboBox_Ariza.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "HURDA DURUMU"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemComboBox_HurdaDurumu
        Me.GridColumn5.FieldName = "Hurda_Durumu"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'RepositoryItemComboBox_HurdaDurumu
        '
        Me.RepositoryItemComboBox_HurdaDurumu.AutoHeight = False
        Me.RepositoryItemComboBox_HurdaDurumu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox_HurdaDurumu.Items.AddRange(New Object() {"0", "1"})
        Me.RepositoryItemComboBox_HurdaDurumu.Name = "RepositoryItemComboBox_HurdaDurumu"
        Me.RepositoryItemComboBox_HurdaDurumu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "MAKINE TIPI"
        Me.GridColumn6.FieldName = "Machine_Name"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 597)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.IconOptions.Image = Global.Enterptise_Device_State_Data_Analysis.My.Resources.Resources.update32
        Me.Name = "UpdateForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Veri Güncelleme Ekranı"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox_Uretim_Tarihi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox_Ariza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox_HurdaDurumu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox_Uretim_Tarihi As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox_Ariza As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox_HurdaDurumu As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
