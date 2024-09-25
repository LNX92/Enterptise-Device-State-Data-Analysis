<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutForm
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(274, 42)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(51, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(145, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Ad ve Soyad : Mustafa Sonkur"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl3)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 76)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(274, 42)
        Me.PanelControl3.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(45, 14)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(179, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "E-mail : mustafa.sonkur00@gmail.com"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.AllowFocus = False
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SimpleButton1.Location = New System.Drawing.Point(83, 200)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(136, 28)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Lisans"
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 266)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Image = Global.Enterptise_Device_State_Data_Analysis.My.Resources.Resources.info32
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hakkında"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
