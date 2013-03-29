<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button_Undo = New System.Windows.Forms.Button()
        Me.Button_Crop = New System.Windows.Forms.Button()
        Me.PictureDown = New System.Windows.Forms.PictureBox()
        Me.PictureUp = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.Combo_Sort = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioDelete = New System.Windows.Forms.RadioButton()
        Me.RadioAsk = New System.Windows.Forms.RadioButton()
        Me.RadioIgnore = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Text_Crop = New System.Windows.Forms.TextBox()
        Me.Text_Coords = New System.Windows.Forms.TextBox()
        Me.Combo_Ship = New System.Windows.Forms.ComboBox()
        Me.Check_Expand_Second = New System.Windows.Forms.CheckBox()
        Me.Check_Expand_First = New System.Windows.Forms.CheckBox()
        Me.Text_Transparency = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.asdf = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Text_Weight_Deuterium = New System.Windows.Forms.TextBox()
        Me.Text_Weight_Crystal = New System.Windows.Forms.TextBox()
        Me.Text_Weight_Metal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NodeMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.NodeMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.AllowDrop = True
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(244, 359)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button_Undo)
        Me.TabPage1.Controls.Add(Me.Button_Crop)
        Me.TabPage1.Controls.Add(Me.PictureDown)
        Me.TabPage1.Controls.Add(Me.PictureUp)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TreeView)
        Me.TabPage1.Controls.Add(Me.Combo_Sort)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(236, 333)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reports"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button_Undo
        '
        Me.Button_Undo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_Undo.Location = New System.Drawing.Point(3, 308)
        Me.Button_Undo.Name = "Button_Undo"
        Me.Button_Undo.Size = New System.Drawing.Size(57, 22)
        Me.Button_Undo.TabIndex = 6
        Me.Button_Undo.Text = "Undo"
        Me.Button_Undo.UseVisualStyleBackColor = True
        '
        'Button_Crop
        '
        Me.Button_Crop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_Crop.Location = New System.Drawing.Point(3, 280)
        Me.Button_Crop.Name = "Button_Crop"
        Me.Button_Crop.Size = New System.Drawing.Size(57, 22)
        Me.Button_Crop.TabIndex = 5
        Me.Button_Crop.Text = "Crop List"
        Me.Button_Crop.UseVisualStyleBackColor = True
        '
        'PictureDown
        '
        Me.PictureDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureDown.Image = Global.Espionage_Sorter.My.Resources.Resources.Arrowdown
        Me.PictureDown.Location = New System.Drawing.Point(210, 285)
        Me.PictureDown.Name = "PictureDown"
        Me.PictureDown.Size = New System.Drawing.Size(20, 37)
        Me.PictureDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureDown.TabIndex = 4
        Me.PictureDown.TabStop = False
        Me.PictureDown.Visible = False
        '
        'PictureUp
        '
        Me.PictureUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureUp.Image = Global.Espionage_Sorter.My.Resources.Resources.Arrowup
        Me.PictureUp.Location = New System.Drawing.Point(210, 285)
        Me.PictureUp.Name = "PictureUp"
        Me.PictureUp.Size = New System.Drawing.Size(20, 37)
        Me.PictureUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureUp.TabIndex = 3
        Me.PictureUp.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sort By:"
        '
        'TreeView
        '
        Me.TreeView.AllowDrop = True
        Me.TreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView.Location = New System.Drawing.Point(0, 0)
        Me.TreeView.Name = "TreeView"
        Me.TreeView.Size = New System.Drawing.Size(236, 274)
        Me.TreeView.TabIndex = 1
        '
        'Combo_Sort
        '
        Me.Combo_Sort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Combo_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Sort.FormattingEnabled = True
        Me.Combo_Sort.Items.AddRange(New Object() {"Fleet Units", "Defense Units", "Coordinates", "Shortest Distance", "Metal", "Crystal ", "Deuterium", "Weighted Resources", "Unweighted Resources"})
        Me.Combo_Sort.Location = New System.Drawing.Point(69, 301)
        Me.Combo_Sort.Name = "Combo_Sort"
        Me.Combo_Sort.Size = New System.Drawing.Size(135, 21)
        Me.Combo_Sort.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Text_Crop)
        Me.TabPage2.Controls.Add(Me.Text_Coords)
        Me.TabPage2.Controls.Add(Me.Combo_Ship)
        Me.TabPage2.Controls.Add(Me.Check_Expand_Second)
        Me.TabPage2.Controls.Add(Me.Check_Expand_First)
        Me.TabPage2.Controls.Add(Me.Text_Transparency)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.asdf)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(236, 333)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "General Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioDelete)
        Me.GroupBox2.Controls.Add(Me.RadioAsk)
        Me.GroupBox2.Controls.Add(Me.RadioIgnore)
        Me.GroupBox2.Location = New System.Drawing.Point(130, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(100, 99)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Duplicates"
        '
        'RadioDelete
        '
        Me.RadioDelete.AutoSize = True
        Me.RadioDelete.Checked = True
        Me.RadioDelete.Location = New System.Drawing.Point(6, 72)
        Me.RadioDelete.Name = "RadioDelete"
        Me.RadioDelete.Size = New System.Drawing.Size(56, 17)
        Me.RadioDelete.TabIndex = 2
        Me.RadioDelete.TabStop = True
        Me.RadioDelete.Text = "Delete"
        Me.RadioDelete.UseVisualStyleBackColor = True
        '
        'RadioAsk
        '
        Me.RadioAsk.AutoSize = True
        Me.RadioAsk.Location = New System.Drawing.Point(6, 46)
        Me.RadioAsk.Name = "RadioAsk"
        Me.RadioAsk.Size = New System.Drawing.Size(43, 17)
        Me.RadioAsk.TabIndex = 1
        Me.RadioAsk.Text = "Ask"
        Me.RadioAsk.UseVisualStyleBackColor = True
        '
        'RadioIgnore
        '
        Me.RadioIgnore.AutoSize = True
        Me.RadioIgnore.Location = New System.Drawing.Point(6, 20)
        Me.RadioIgnore.Name = "RadioIgnore"
        Me.RadioIgnore.Size = New System.Drawing.Size(55, 17)
        Me.RadioIgnore.TabIndex = 0
        Me.RadioIgnore.Text = "Ignore"
        Me.RadioIgnore.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Default Ship:"
        '
        'Text_Crop
        '
        Me.Text_Crop.Location = New System.Drawing.Point(141, 209)
        Me.Text_Crop.MaxLength = 3
        Me.Text_Crop.Name = "Text_Crop"
        Me.Text_Crop.Size = New System.Drawing.Size(25, 20)
        Me.Text_Crop.TabIndex = 12
        Me.Text_Crop.Text = "15"
        '
        'Text_Coords
        '
        Me.Text_Coords.Location = New System.Drawing.Point(141, 183)
        Me.Text_Coords.MaxLength = 9
        Me.Text_Coords.Name = "Text_Coords"
        Me.Text_Coords.Size = New System.Drawing.Size(55, 20)
        Me.Text_Coords.TabIndex = 11
        '
        'Combo_Ship
        '
        Me.Combo_Ship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Ship.FormattingEnabled = True
        Me.Combo_Ship.Items.AddRange(New Object() {"Small Cargo", "Large Cargo", "Light Fighter", "Heavy Fighter", "Cruiser", "Battleship", "Recycler", "Bomber", "Destroyer", "Battlecruiser"})
        Me.Combo_Ship.Location = New System.Drawing.Point(96, 235)
        Me.Combo_Ship.Name = "Combo_Ship"
        Me.Combo_Ship.Size = New System.Drawing.Size(100, 21)
        Me.Combo_Ship.TabIndex = 10
        '
        'Check_Expand_Second
        '
        Me.Check_Expand_Second.AutoSize = True
        Me.Check_Expand_Second.Location = New System.Drawing.Point(6, 134)
        Me.Check_Expand_Second.Name = "Check_Expand_Second"
        Me.Check_Expand_Second.Size = New System.Drawing.Size(171, 17)
        Me.Check_Expand_Second.TabIndex = 9
        Me.Check_Expand_Second.Text = "Auto Expand Secondary Trees"
        Me.Check_Expand_Second.UseVisualStyleBackColor = True
        '
        'Check_Expand_First
        '
        Me.Check_Expand_First.AutoSize = True
        Me.Check_Expand_First.Checked = True
        Me.Check_Expand_First.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Check_Expand_First.Location = New System.Drawing.Point(6, 111)
        Me.Check_Expand_First.Name = "Check_Expand_First"
        Me.Check_Expand_First.Size = New System.Drawing.Size(134, 17)
        Me.Check_Expand_First.TabIndex = 8
        Me.Check_Expand_First.Text = "Auto Expand First Tree"
        Me.Check_Expand_First.UseVisualStyleBackColor = True
        '
        'Text_Transparency
        '
        Me.Text_Transparency.Location = New System.Drawing.Point(141, 157)
        Me.Text_Transparency.MaxLength = 3
        Me.Text_Transparency.Name = "Text_Transparency"
        Me.Text_Transparency.Size = New System.Drawing.Size(25, 20)
        Me.Text_Transparency.TabIndex = 7
        Me.Text_Transparency.Text = "80"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Crop List Count:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Planet Coordinates:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 2
        '
        'asdf
        '
        Me.asdf.AutoSize = True
        Me.asdf.Location = New System.Drawing.Point(3, 160)
        Me.asdf.Name = "asdf"
        Me.asdf.Size = New System.Drawing.Size(101, 13)
        Me.asdf.TabIndex = 1
        Me.asdf.Text = "Form Transparency:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Text_Weight_Deuterium)
        Me.GroupBox1.Controls.Add(Me.Text_Weight_Crystal)
        Me.GroupBox1.Controls.Add(Me.Text_Weight_Metal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 99)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resource Weighting"
        '
        'Text_Weight_Deuterium
        '
        Me.Text_Weight_Deuterium.Location = New System.Drawing.Point(74, 71)
        Me.Text_Weight_Deuterium.MaxLength = 2
        Me.Text_Weight_Deuterium.Name = "Text_Weight_Deuterium"
        Me.Text_Weight_Deuterium.Size = New System.Drawing.Size(24, 20)
        Me.Text_Weight_Deuterium.TabIndex = 5
        Me.Text_Weight_Deuterium.Text = "1"
        Me.Text_Weight_Deuterium.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Text_Weight_Crystal
        '
        Me.Text_Weight_Crystal.Location = New System.Drawing.Point(74, 45)
        Me.Text_Weight_Crystal.MaxLength = 2
        Me.Text_Weight_Crystal.Name = "Text_Weight_Crystal"
        Me.Text_Weight_Crystal.Size = New System.Drawing.Size(24, 20)
        Me.Text_Weight_Crystal.TabIndex = 4
        Me.Text_Weight_Crystal.Text = "1"
        Me.Text_Weight_Crystal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Text_Weight_Metal
        '
        Me.Text_Weight_Metal.Location = New System.Drawing.Point(74, 19)
        Me.Text_Weight_Metal.MaxLength = 2
        Me.Text_Weight_Metal.Name = "Text_Weight_Metal"
        Me.Text_Weight_Metal.Size = New System.Drawing.Size(24, 20)
        Me.Text_Weight_Metal.TabIndex = 3
        Me.Text_Weight_Metal.Text = "1"
        Me.Text_Weight_Metal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Deuterium"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Crystal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Metal"
        '
        'NodeMenu
        '
        Me.NodeMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuDelete})
        Me.NodeMenu.Name = "NodeMenu"
        Me.NodeMenu.Size = New System.Drawing.Size(141, 48)
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.Size = New System.Drawing.Size(140, 22)
        Me.mnuCopy.Text = "Copy Report"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(140, 22)
        Me.mnuDelete.Text = "Delete"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 385)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(284, 419)
        Me.Name = "Form1"
        Me.Text = "Espionage Sorter"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.NodeMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents asdf As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Text_Weight_Metal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Text_Weight_Deuterium As System.Windows.Forms.TextBox
    Friend WithEvents Text_Weight_Crystal As System.Windows.Forms.TextBox
    Friend WithEvents Combo_Ship As System.Windows.Forms.ComboBox
    Friend WithEvents Check_Expand_Second As System.Windows.Forms.CheckBox
    Friend WithEvents Check_Expand_First As System.Windows.Forms.CheckBox
    Friend WithEvents Text_Transparency As System.Windows.Forms.TextBox
    Friend WithEvents Text_Coords As System.Windows.Forms.TextBox
    Friend WithEvents Text_Crop As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Combo_Sort As System.Windows.Forms.ComboBox
    Friend WithEvents TreeView As System.Windows.Forms.TreeView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureDown As System.Windows.Forms.PictureBox
    Friend WithEvents PictureUp As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Undo As System.Windows.Forms.Button
    Friend WithEvents Button_Crop As System.Windows.Forms.Button
    Friend WithEvents NodeMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioDelete As System.Windows.Forms.RadioButton
    Friend WithEvents RadioAsk As System.Windows.Forms.RadioButton
    Friend WithEvents RadioIgnore As System.Windows.Forms.RadioButton

End Class
