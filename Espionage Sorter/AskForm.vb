Public Class AskForm
    Public Sub New(ByVal Node1 As TreeNode, ByVal Node2 As TreeNode)
        InitializeComponent()
        TreeView1.Nodes.Add(Node1.Clone())
        TreeView1.ExpandAll()
        TreeView2.Nodes.Add(Node2.Clone())
        TreeView2.ExpandAll()
        TreeView1.TreeViewNodeSorter = New NodeSorter()
        TreeView2.TreeViewNodeSorter = New NodeSorter()
        btnIgnore.Select()
    End Sub

    Private Sub AskForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        TreeView1.Left = 4
        TreeView1.Width = Me.Width / 2 - 14
        TreeView2.Left = Me.Width / 2 - 5
        TreeView2.Width = Me.Width / 2 - 14
        btnYes.Width = (Me.Width - 35) / 3
        btnIgnore.Width = (Me.Width - 35) / 3
        btnNo.Width = (Me.Width - 35) / 3
        btnYes.Left = 5
        btnIgnore.Left = 10 + (Me.Width - 35) / 3
        btnNo.Left = 15 + (Me.Width - 35) * 2 / 3
    End Sub

    Private Sub AskForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class