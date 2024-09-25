<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager2 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.Enterptise_Device_State_Data_Analysis.SplashScreen1), True, True, True)
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains1 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains2 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FluentDesignFormContainer1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FluentFormDefaultManager1 = New DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(Me.components)
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.FluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.Enterptise_Device_State_Data_Analysis.WaitForm1), True, True, True)
        Me.XtraSaveFileDialog1 = New DevExpress.XtraEditors.XtraSaveFileDialog(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.DragDropEvents1 = New DevExpress.Utils.DragDrop.DragDropEvents(Me.components)
        Me.FluentDesignFormContainer1.SuspendLayout()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager2
        '
        SplashScreenManager2.ClosingDelay = 1000
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "HURDA DURUMU"
        Me.GridColumn4.FieldName = "Hurda_Durumu"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'FluentDesignFormContainer1
        '
        Me.FluentDesignFormContainer1.Controls.Add(Me.RibbonControl1)
        Me.FluentDesignFormContainer1.Controls.Add(Me.GridControl1)
        Me.FluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FluentDesignFormContainer1.Location = New System.Drawing.Point(48, 46)
        Me.FluentDesignFormContainer1.Name = "FluentDesignFormContainer1"
        Me.FluentDesignFormContainer1.Size = New System.Drawing.Size(1083, 529)
        Me.FluentDesignFormContainer1.TabIndex = 0
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarStaticItem1})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 5
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.PageHeaderItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.Size = New System.Drawing.Size(1083, 87)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Veriyi Analiz Et"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.Image = Global.Enterptise_Device_State_Data_Analysis.My.Resources.Resources.magnifying32
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Seçili Verileri Sil"
        Me.BarButtonItem2.Enabled = False
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.Image = Global.Enterptise_Device_State_Data_Analysis.My.Resources.Resources.trash32
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Seçili Verileri Güncelle"
        Me.BarButtonItem3.Enabled = False
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageOptions.Image = Global.Enterptise_Device_State_Data_Analysis.My.Resources.Resources.update32
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 4
        Me.BarStaticItem1.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Gold
        Me.BarStaticItem1.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.ShowImageInToolbar = False
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
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
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(0, 93)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.FluentFormDefaultManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1083, 436)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.BehaviorManager1.SetBehaviors(Me.GridView1, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.DragDrop.DragDropBehavior.Create(GetType(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), True, True, True, True, Me.DragDropEvents1), DevExpress.Utils.Behaviors.Behavior)})
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.GridColumn4
        GridFormatRule1.Name = "CheckState"
        FormatConditionRuleContains1.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleContains1.Appearance.BorderColor = System.Drawing.Color.Red
        FormatConditionRuleContains1.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleContains1.Appearance.Options.UseBackColor = True
        FormatConditionRuleContains1.Appearance.Options.UseBorderColor = True
        FormatConditionRuleContains1.Appearance.Options.UseForeColor = True
        FormatConditionRuleContains1.Values = CType(resources.GetObject("FormatConditionRuleContains1.Values"), System.Collections.IList)
        GridFormatRule1.Rule = FormatConditionRuleContains1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.GridColumn4
        GridFormatRule2.Name = "Format0"
        FormatConditionRuleContains2.Appearance.BackColor = System.Drawing.Color.DarkGreen
        FormatConditionRuleContains2.Appearance.BorderColor = System.Drawing.Color.DarkGreen
        FormatConditionRuleContains2.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleContains2.Appearance.Options.UseBackColor = True
        FormatConditionRuleContains2.Appearance.Options.UseBorderColor = True
        FormatConditionRuleContains2.Appearance.Options.UseForeColor = True
        FormatConditionRuleContains2.Values = CType(resources.GetObject("FormatConditionRuleContains2.Values"), System.Collections.IList)
        GridFormatRule2.Rule = FormatConditionRuleContains2
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.FormatRules.Add(GridFormatRule2)
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
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "CIHAZ ID"
        Me.GridColumn1.FieldName = "Cihaz_ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowShowHide = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "CIHAZ URETIM TARIHI"
        Me.GridColumn2.FieldName = "Cihaz_Uretim_Tarihi"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "ARIZA"
        Me.GridColumn3.FieldName = "Ariza"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "MAKINE TIPI"
        Me.GridColumn5.FieldName = "Machine_Name"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'FluentFormDefaultManager1
        '
        Me.FluentFormDefaultManager1.Form = Me
        Me.FluentFormDefaultManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.FluentFormDefaultManager1.MaxItemId = 4
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem4.Caption = "Verileri Excel Dosyası Olarak Dışarı Aktar"
        Me.BarButtonItem4.Id = 0
        Me.BarButtonItem4.ImageOptions.Image = Global.Enterptise_Device_State_Data_Analysis.My.Resources.Resources.excel32
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem5.Caption = "Hakkında"
        Me.BarButtonItem5.Id = 1
        Me.BarButtonItem5.ImageOptions.Image = Global.Enterptise_Device_State_Data_Analysis.My.Resources.Resources.info32
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Yazdır"
        Me.BarButtonItem6.Id = 2
        Me.BarButtonItem6.ImageOptions.Image = Global.Enterptise_Device_State_Data_Analysis.My.Resources.Resources.Print32
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Sürükleme Modu : Kapalı"
        Me.BarButtonItem7.Id = 3
        Me.BarButtonItem7.ItemAppearance.Normal.BackColor = System.Drawing.Color.RoyalBlue
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseBackColor = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement1})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 46)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized
        Me.AccordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
        Me.AccordionControl1.Size = New System.Drawing.Size(48, 529)
        Me.AccordionControl1.TabIndex = 1
        Me.AccordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.ImageOptions.Image = Global.Enterptise_Device_State_Data_Analysis.My.Resources.Resources.add32
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Text = "Veri Ekle"
        '
        'FluentDesignFormControl1
        '
        Me.FluentDesignFormControl1.FluentDesignForm = Me
        Me.FluentDesignFormControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.FluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.FluentDesignFormControl1.Manager = Me.FluentFormDefaultManager1
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(1131, 46)
        Me.FluentDesignFormControl1.TabIndex = 2
        Me.FluentDesignFormControl1.TabStop = False
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.BarButtonItem4)
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.BarButtonItem5)
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.BarButtonItem6)
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.BarButtonItem7)
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'XtraSaveFileDialog1
        '
        Me.XtraSaveFileDialog1.FileName = "XtraSaveFileDialog1"
        Me.XtraSaveFileDialog1.Filter = "Excel Dosyası (.xlsx)|*.xlsx"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 575)
        Me.ControlContainer = Me.FluentDesignFormContainer1
        Me.Controls.Add(Me.FluentDesignFormContainer1)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Controls.Add(Me.FluentDesignFormControl1)
        Me.FluentDesignFormControl = Me.FluentDesignFormControl1
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.IconOptions.Image = Global.Enterptise_Device_State_Data_Analysis.My.Resources.Resources.AI512
        Me.Name = "Form1"
        Me.NavigationControl = Me.AccordionControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enterprise Device State Data Analysis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FluentDesignFormContainer1.ResumeLayout(False)
        Me.FluentDesignFormContainer1.PerformLayout()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FluentDesignFormContainer1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents FluentDesignFormControl1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl
    Friend WithEvents FluentFormDefaultManager1 As DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraSaveFileDialog1 As DevExpress.XtraEditors.XtraSaveFileDialog
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents DragDropEvents1 As DevExpress.Utils.DragDrop.DragDropEvents
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
End Class
