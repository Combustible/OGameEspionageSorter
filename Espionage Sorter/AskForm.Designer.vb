<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AskForm
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
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.TreeView2 = New System.Windows.Forms.TreeView
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnYes = New System.Windows.Forms.Button
        Me.btnIgnore = New System.Windows.Forms.Button
        Me.btnNo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(4, 25)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(186, 216)
        Me.TreeView1.TabIndex = 0
        '
        'TreeView2
        '
        Me.TreeView2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TreeView2.Location = New System.Drawing.Point(196, 25)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(186, 216)
        Me.TreeView2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Two reports with the same coordinates were loaded. Select which to keep:"
        '
        'btnYes
        '
        Me.btnYes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnYes.Location = New System.Drawing.Point(4, 247)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(106, 25)
        Me.btnYes.TabIndex = 3
        Me.btnYes.Text = "First"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnIgnore
        '
        Me.btnIgnore.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnIgnore.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.btnIgnore.Location = New System.Drawing.Point(138, 247)
        Me.btnIgnore.Name = "btnIgnore"
        Me.btnIgnore.Size = New System.Drawing.Size(106, 25)
        Me.btnIgnore.TabIndex = 4
        Me.btnIgnore.Text = "Both"
        Me.btnIgnore.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNo.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnNo.Location = New System.Drawing.Point(276, 247)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(106, 25)
        Me.btnNo.TabIndex = 5
        Me.btnNo.Text = "Second"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'AskForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(385, 277)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnIgnore)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.TreeView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(375, 175)
        Me.Name = "AskForm"
        Me.Text = "Espionage Sorter"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnIgnore As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
End Class
