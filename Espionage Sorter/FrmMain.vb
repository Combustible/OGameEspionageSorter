Public Class FrmMain
    Public SortUp As Boolean
    Public HomeCoords As New Coords
    Public UndoList As New LinkedList

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Save_Settings()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SortUp = False
        Combo_Ship.SelectedItem = "Small Cargo"
        Combo_Sort.SelectedItem = "Weighted Resources"

        Load_Settings()
        ImageDir()
        Update_Transparency()
    End Sub

    Private Sub PictureDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureDown.Click
        SortUp = Not SortUp
        ImageDir()
        Sort_List()
    End Sub

    Private Sub PictureUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureUp.Click
        SortUp = Not SortUp
        ImageDir()
        Sort_List()
    End Sub

    Private Sub ImageDir()
        If SortUp = True Then
            PictureUp.Visible = True
            PictureDown.Visible = False
        Else
            PictureUp.Visible = False
            PictureDown.Visible = True
        End If
    End Sub

    Private Sub Update_Transparency()
        If Int(Val(Text_Transparency.Text)) > 100 Then
            Text_Transparency.Text = 100
        ElseIf Int(Val(Text_Transparency.Text)) < 20 Then
            Text_Transparency.Text = 20
        End If
        Me.Opacity = Int(Val(Text_Transparency.Text)) / 100
    End Sub

    Private Sub Text_Weight_Metal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Weight_Metal.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If (keyascii < 48 Or keyascii > 58) And keyascii <> 8 And keyascii <> 127 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub Text_Weight_Crystal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Weight_Crystal.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If (keyascii < 48 Or keyascii > 58) And keyascii <> 8 And keyascii <> 127 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub Text_Weight_Deuterium_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Weight_Deuterium.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If (keyascii < 48 Or keyascii > 58) And keyascii <> 8 And keyascii <> 127 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub Text_Transparency_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Transparency.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If (keyascii < 48 Or keyascii > 58) And keyascii <> 8 And keyascii <> 127 And keyascii <> 13 Then
            e.KeyChar = Nothing
        End If
        If keyascii = 13 Then
            Update_Transparency()
        End If
    End Sub

    Private Sub Text_Coords_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Coords.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If (keyascii < 48 Or keyascii > 58) And keyascii <> 8 And keyascii <> 127 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub Text_Crop_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Crop.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If (keyascii < 48 Or keyascii > 58) And keyascii <> 8 And keyascii <> 127 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub Text_Transparency_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Text_Transparency.LostFocus
        Update_Transparency()
    End Sub

    Private Sub Load_Settings()
        Dim fileReader As String
        Dim tempstring As String
        If (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory + "\Settings.txt")) = True Then
            fileReader = My.Computer.FileSystem.ReadAllText(System.IO.Directory.GetCurrentDirectory + "\Settings.txt")

            If InStr(LCase(fileReader), "sortup") Then
                tempstring = fileReader.Remove(0, InStr(LCase(fileReader), "sortup"))
                tempstring = tempstring.Remove(0, InStr(tempstring, "="))
                If InStr(tempstring, Chr(13)) > 0 Then
                    tempstring = tempstring.Remove(InStr(tempstring, Chr(13)))
                End If
                If Val(tempstring) = 1 Then
                    SortUp = True
                End If
            End If
            If InStr(LCase(fileReader), "transparency") Then
                tempstring = fileReader.Remove(0, InStr(LCase(fileReader), "transparency"))
                tempstring = tempstring.Remove(0, InStr(tempstring, "="))
                If InStr(tempstring, Chr(13)) > 0 Then
                    tempstring = tempstring.Remove(InStr(tempstring, Chr(13)))
                End If
                If Int(Val(tempstring)) >= 20 And Int(Val(tempstring)) <= 100 Then
                    Text_Transparency.Text = Int(Val(tempstring))
                End If
            End If
            If InStr(LCase(fileReader), "mweight") Then
                tempstring = fileReader.Remove(0, InStr(LCase(fileReader), "mweight"))
                tempstring = tempstring.Remove(0, InStr(tempstring, "="))
                If InStr(tempstring, Chr(13)) > 0 Then
                    tempstring = tempstring.Remove(InStr(tempstring, Chr(13)))
                End If
                If Val(tempstring) >= 0 And Val(tempstring <= 99) Then
                    Text_Weight_Metal.Text = Int(Val(tempstring))
                End If
            End If
            If InStr(LCase(fileReader), "cweight") Then
                tempstring = fileReader.Remove(0, InStr(LCase(fileReader), "cweight"))
                tempstring = tempstring.Remove(0, InStr(tempstring, "="))
                If InStr(tempstring, Chr(13)) > 0 Then
                    tempstring = tempstring.Remove(InStr(tempstring, Chr(13)))
                End If
                If Val(tempstring) >= 0 And Val(tempstring <= 99) Then
                    Text_Weight_Crystal.Text = Int(Val(tempstring))
                End If
            End If
            If InStr(LCase(fileReader), "dweight") Then
                tempstring = fileReader.Remove(0, InStr(LCase(fileReader), "dweight"))
                tempstring = tempstring.Remove(0, InStr(tempstring, "="))
                If InStr(tempstring, Chr(13)) > 0 Then
                    tempstring = tempstring.Remove(InStr(tempstring, Chr(13)))
                End If
                If Val(tempstring) >= 0 And Val(tempstring <= 99) Then
                    Text_Weight_Deuterium.Text = Int(Val(tempstring))
                End If
            End If
            If InStr(LCase(fileReader), "autoexp1") Then
                tempstring = fileReader.Remove(0, InStr(LCase(fileReader), "autoexp1"))
                tempstring = tempstring.Remove(0, InStr(tempstring, "="))
                If InStr(tempstring, Chr(13)) > 0 Then
                    tempstring = tempstring.Remove(InStr(tempstring, Chr(13)))
                End If
                If Val(tempstring) = 0 Then
                    Check_Expand_First.Checked = False
                End If
            End If
            If InStr(LCase(fileReader), "autoexp2") Then
                tempstring = fileReader.Remove(0, InStr(LCase(fileReader), "autoexp2"))
                tempstring = tempstring.Remove(0, InStr(tempstring, "="))
                If InStr(tempstring, Chr(13)) > 0 Then
                    tempstring = tempstring.Remove(InStr(tempstring, Chr(13)))
                End If
                If Val(tempstring) = 1 Then
                    Check_Expand_Second.Checked = True
                End If
            End If
            If InStr(LCase(fileReader), "cropcount") Then
                tempstring = fileReader.Remove(0, InStr(LCase(fileReader), "cropcount"))
                tempstring = tempstring.Remove(0, InStr(tempstring, "="))
                If InStr(tempstring, Chr(13)) > 0 Then
                    tempstring = tempstring.Remove(InStr(tempstring, Chr(13)))
                End If
                If Val(tempstring) >= 0 And Val(tempstring <= 999) Then
                    Text_Crop.Text = Int(Val(tempstring))
                End If
            End If
            If InStr(LCase(fileReader), "sortship") Then
                tempstring = fileReader.Remove(0, InStr(LCase(fileReader), "sortship"))
                tempstring = tempstring.Remove(0, InStr(tempstring, "="))
                If InStr(tempstring, Chr(13)) > 0 Then
                    tempstring = tempstring.Remove(InStr(tempstring, Chr(13)))
                End If
                tempstring = Trim(tempstring)
                tempstring = tempstring.Trim(Chr(13))
                tempstring = tempstring.Trim(Chr(14))
                tempstring = tempstring.Trim(Chr(15))
                If Len(tempstring) > 3 Then
                    Combo_Sort.SelectedItem = tempstring
                End If
            End If
            If InStr(LCase(fileReader), "cargoship") Then
                tempstring = fileReader.Remove(0, InStr(LCase(fileReader), "cargoship"))
                tempstring = tempstring.Remove(0, InStr(tempstring, "="))
                If InStr(tempstring, Chr(13)) > 0 And InStr(tempstring, Chr(13)) < Len(tempstring) Then
                    tempstring = tempstring.Remove(InStr(tempstring, Chr(13)))
                End If
                tempstring = Trim(tempstring)
                tempstring = tempstring.Trim(Chr(13))
                tempstring = tempstring.Trim(Chr(14))
                tempstring = tempstring.Trim(Chr(15))
                If Len(tempstring) > 3 Then
                    Combo_Ship.SelectedItem = tempstring
                End If
            End If
            If InStr(LCase(fileReader), "coords") Then
                tempstring = fileReader.Remove(0, InStr(LCase(fileReader), "coords"))
                tempstring = tempstring.Remove(0, InStr(tempstring, "="))
                If InStr(tempstring, Chr(13)) > 0 And InStr(tempstring, Chr(13)) < Len(tempstring) Then
                    tempstring = tempstring.Remove(InStr(tempstring, Chr(13)))
                End If
                tempstring = Trim(tempstring)
                tempstring = tempstring.Trim(Chr(13))
                tempstring = tempstring.Trim(Chr(14))
                tempstring = tempstring.Trim(Chr(15))
                If Len(tempstring) > 4 Then
                    Text_Coords.Text = tempstring
                End If
            End If
            If InStr(LCase(fileReader), "duplicates") Then
                tempstring = fileReader.Remove(0, InStr(LCase(fileReader), "duplicates"))
                tempstring = tempstring.Remove(0, InStr(tempstring, "="))
                If InStr(tempstring, Chr(13)) > 0 And InStr(tempstring, Chr(13)) < Len(tempstring) Then
                    tempstring = tempstring.Remove(InStr(tempstring, Chr(13)))
                End If
                tempstring = Trim(tempstring)
                tempstring = tempstring.Trim(Chr(13))
                tempstring = tempstring.Trim(Chr(14))
                tempstring = tempstring.Trim(Chr(15))
                If Len(tempstring) > 0 Then
                    If Val(tempstring) = 0 Then
                        RadioIgnore.Checked = True
                    ElseIf Val(tempstring) = 1 Then
                        RadioAsk.Checked = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Save_Settings()
        Dim StreamWriter As System.IO.StreamWriter

        StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(System.IO.Directory.GetCurrentDirectory + "\Settings.txt", False)

        If SortUp = True Then
            StreamWriter.WriteLine("SortUp=1")
        End If
        StreamWriter.WriteLine("Transparency=" + Text_Transparency.Text)
        StreamWriter.WriteLine("MWeight=" + Str(Int(Val(Text_Weight_Metal.Text))))
        StreamWriter.WriteLine("CWeight=" + Str(Int(Val(Text_Weight_Crystal.Text))))
        StreamWriter.WriteLine("DWeight=" + Str(Int(Val(Text_Weight_Deuterium.Text))))
        If Check_Expand_First.Checked = False Then
            StreamWriter.WriteLine("autoexp1=0")
        End If
        If Check_Expand_Second.Checked = True Then
            StreamWriter.WriteLine("autoexp2=1")
        End If
        StreamWriter.WriteLine("CropCount=" + Str(Int(Val(Text_Crop.Text))))
        StreamWriter.WriteLine("SortShip=" + Combo_Sort.SelectedItem)
        StreamWriter.WriteLine("CargoShip=" + Combo_Ship.SelectedItem)
        StreamWriter.WriteLine("Coords=" + Text_Coords.Text)
        If RadioIgnore.Checked = True Then
            StreamWriter.WriteLine("Duplicates=0")
        ElseIf RadioAsk.Checked = True Then
            StreamWriter.WriteLine("Duplicates=1")
        End If
        StreamWriter.Close()

    End Sub

    Private Sub TreeView_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub TreeView_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView.DragDrop
        Read_Data(e.Data.GetData(System.Windows.Forms.DataFormats.Text))
    End Sub

    Private Sub Read_Data(ByVal input_string As String)
        TreeView.Hide()
        Dim Tempnode As TreeNode
        Dim Checknode As TreeNode
        Dim Report As String = ""

        While InStr(input_string, "Espionage report of") > 0
            Dim Values As New Information

            'Isolate Report
            Report = input_string.Remove(0, InStr(input_string, "Espionage report of") - 1)

            If Int(InStr(Report, "%")) < Report.Length And InStr(Report, "%") <> 0 Then
                Report = Report.Remove(InStr(Report, "%"))
            End If
            Values.Report = Report

            'Remove report from string to read
            input_string = input_string.Remove(0, InStr(input_string, "Espionage report of"))

            'Coordinates
            Report = Report.Remove(0, InStr(Report, "Resources on"))
            Report = Report.Remove(0, InStr(Report, "[") - 1)
            Values.Coordinates.Str = Report.Remove(InStr(Report, "]"))

            'Name
            Report = Report.Remove(0, InStr(Report, "Player: ") + Len("Player: ") - 1)
            Values.Name = Report.Remove(InStr(Report, ")") - 1)

            'Metal
            Values.Metal = ExtractNextNumber(Report.Remove(0, InStr(Report, "Metal") + 5).Remove(InStr(Report, "Crystal") - 1))
            Values.Crystal = ExtractNextNumber(Report.Remove(0, InStr(Report, "Crystal") + 7).Remove(InStr(Report, "Deuterium") - 1))
            Values.Deuterium = ExtractNextNumber(Report.Remove(0, InStr(Report, "Deuterium") + 9).Remove(InStr(Report, "Energy") - 1))

            'Fleet
            If InStr(Report, "fleets") > 0 Then
                Values.Fleet = True
                Values.Light = ParseSubItem(Report, "Light Fighter")
                Values.Heavy = ParseSubItem(Report, "Heavy Fighter")
                Values.Small = ParseSubItem(Report, "Small Cargo")
                Values.Large = ParseSubItem(Report, "Large Cargo")
                Values.Probe = ParseSubItem(Report, "Espionage Probe")
                Values.Sat = ParseSubItem(Report, "Solar Satellite")
                Values.Recycler = ParseSubItem(Report, "Recycler")
                Values.Colony = ParseSubItem(Report, "Colony Ship")
                Values.Cruiser = ParseSubItem(Report, "Cruiser")
                Values.BShip = ParseSubItem(Report, "Battleship")
                Values.BCruiser = ParseSubItem(Report, "Battlecruiser")
                Values.Bomber = ParseSubItem(Report, "Bomber")
                Values.Destroyer = ParseSubItem(Report, "Destroyer")
                Values.RIP = ParseSubItem(Report, "RIP") + ParseSubItem(Report, "Death Star")

                If InStr(Report, "Defense") > 0 Then
                    Values.Defense = True

                    Values.Rocket = ParseSubItem(Report, "Rocket Launcher")
                    Values.LLaser = ParseSubItem(Report, "Light Laser")
                    Values.HLaser = ParseSubItem(Report, "Heavy Laser")
                    Values.Ion = ParseSubItem(Report, "Ion Cannon")
                    Values.Gauss = ParseSubItem(Report, "Gauss Cannon")
                    Values.Plasma = ParseSubItem(Report, "Plasma Turret")
                    Values.SShield = ParseSubItem(Report, "Small Shield Dome")
                    Values.LShield = ParseSubItem(Report, "Large Shield Dome")
                    Values.ABM = ParseSubItem(Report, "Anti-Ballistic Missiles")

                    If InStr(Report, "Research Lab") Then
                        Report = Report.Remove(0, InStr(Report, "Research Lab"))
                    End If
                    If InStr(Report, "Research") > 0 Then
                        Values.Research = True
                        Values.Weapon = ParseSubItem(Report, "Weapons Technology")
                        Values.Shield = ParseSubItem(Report, "Shielding Technology")
                        Values.Armor = ParseSubItem(Report, "Armour Technology")
                    End If
                End If
            End If
            Tempnode = Values.GetNode
            TreeView.Nodes.Add(Tempnode)
            If RadioIgnore.Checked = False Then
                If TreeView.Nodes.Count > 1 Then
                    Checknode = TreeView.Nodes.Item(0)
                    Do Until Checknode Is Nothing Or Tempnode Is Nothing
                        If (Not (Tempnode Is Checknode)) And Checknode.Tag.Coordinates.Str = Tempnode.Tag.Coordinates.Str Then
                            If RadioAsk.Checked = True Then
                                Dim NewForm As New FrmAsk(Tempnode, Checknode)
                                NewForm.ShowDialog()
                                Select Case NewForm.DialogResult
                                    Case Windows.Forms.DialogResult.Yes
                                        DestroyNode(Checknode)
                                    Case Windows.Forms.DialogResult.No
                                        DestroyNode(Tempnode)
                                End Select
                                NewForm.Dispose()
                            Else
                                DestroyNode(Checknode)
                            End If
                            Exit Do
                        End If
                        Checknode = Checknode.NextNode()
                    Loop
                End If
            End If
        End While
        TreeView.Show()
        Sort_List()
    End Sub

    Private Function ParseSubItem(ByVal Report As String, ByVal SearchString As String) As Integer
        If Report.Contains(SearchString) Then
            Return ExtractNextNumber(Report.Remove(0, InStr(Report, SearchString) + Len(SearchString) - 1))
        Else
            Return 0
        End If
    End Function

    Private Function ExtractNextNumber(ByVal ParseText As String)
        Dim Enumerator As IEnumerator = ParseText.GetEnumerator()
        Dim ReturnValueString As String = ""
        Do While Enumerator.MoveNext()
            If IsNumeric(Enumerator.Current) Then
                ReturnValueString = ReturnValueString + Enumerator.Current
            Else
                If Enumerator.Current <> " " And Enumerator.Current <> "." And Asc(Enumerator.Current) <> 9 Then
                    Exit Do
                End If
            End If
        Loop
        Return CInt(ReturnValueString)
    End Function

    Private Sub Refresh_Tree_Name()
        Dim TempNode As TreeNode
        If TreeView.Nodes.Count > 0 Then
            TempNode = TreeView.Nodes.Item(0)
            Do Until TempNode.NextNode Is Nothing
                TempNode.Text = TempNode.Tag.TreeName
                TempNode = TempNode.NextNode
            Loop
        End If
    End Sub

    Private Sub Combo_Sort_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Sort.TextChanged
        Sort_List()
    End Sub

    Private Sub Combo_Ship_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Ship.TextChanged
        Refresh_Tree_Name()
    End Sub

    Private Sub Text_Weight_Metal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Weight_Metal.TextChanged
        Refresh_Tree_Name()
    End Sub

    Private Sub Text_Weight_Crystal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Text_Weight_Crystal.TextChanged
        Refresh_Tree_Name()
    End Sub

    Private Sub Text_Weight_Deuterium_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Text_Weight_Deuterium.TextChanged
        Refresh_Tree_Name()
    End Sub

    Private Sub DestroyNode(ByVal Node As TreeNode)
        UndoList.Add(Node.Tag)

        Node.Tag = Nothing
        Node.Nodes.Clear()
        Node.Remove()
    End Sub

    Private Sub Sort_List()
        TreeView.Visible = False
        TreeView.TreeViewNodeSorter = New NodeSorter()
        TreeView.Visible = True
    End Sub

    Private Sub Expand_List()
        Dim TempNode As TreeNode
        Dim SubNode As TreeNode

        If TreeView.Nodes.Count > 0 Then
            TempNode = TreeView.Nodes.Item(0)
            While Not (TempNode Is Nothing)
                If Check_Expand_First.Checked = True Or Check_Expand_Second.Checked = True Then
                    TempNode.Expand()
                Else
                    TempNode.Collapse(False)
                End If
                SubNode = TempNode.FirstNode
                While Not (SubNode Is Nothing)
                    If Check_Expand_Second.Checked = True Then
                        SubNode.Expand()
                    Else
                        SubNode.Collapse(False)
                    End If
                    SubNode = SubNode.NextNode()
                End While
                TempNode = TempNode.NextNode
            End While
        End If
    End Sub

    Private Sub Check_Expand_First_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_Expand_First.CheckedChanged
        Expand_List()
    End Sub

    Private Sub Check_Expand_Second_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Check_Expand_Second.CheckedChanged
        Expand_List()
    End Sub

    Private Sub Text_Coords_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Coords.TextChanged
        HomeCoords.Str = Text_Coords.Text
        If Combo_Sort.SelectedItem = "Shortest Distance" Then
            Sort_List()
        End If
    End Sub

    Private Sub mnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopy.Click
        Clipboard.SetText(TreeView.SelectedNode.Tag.Report)
    End Sub

    Private Sub TreeView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            TreeView.SelectedNode = TreeView.GetNodeAt(e.X, e.Y)
        End If
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        If Not TreeView.SelectedNode Is Nothing Then
            DestroyNode(TreeView.SelectedNode)
        End If
    End Sub

    Private Sub TreeView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView.KeyDown
        If e.KeyCode = 46 And Not TreeView.SelectedNode Is Nothing Then
            DestroyNode(TreeView.SelectedNode)
        End If
    End Sub

    Public Function NodeLevel(ByVal Node As TreeNode) As Integer
        Dim Level As Integer = 0
        While Not Node Is Nothing
            Node = Node.Parent
            Level = Level + 1
        End While
        Return Level
    End Function

    Public Function NumString(ByVal Value As Integer) As String
        Dim ReturnString As String = ""
        Dim Tempstring As String = Reverse(Str(Value).Trim())

        Dim Enumerator As IEnumerator = Tempstring.GetEnumerator
        Dim Counter As Integer = 0

        Do While Enumerator.MoveNext()
            ReturnString = ReturnString + Enumerator.Current
            Counter += 1
            If Counter = 3 Then
                ReturnString = ReturnString + ","
                Counter = 0
            End If
        Loop
        Return Reverse(ReturnString).Trim(",")
    End Function

    Private Function Reverse(ByVal Input As String) As String
        Dim Enumerator As IEnumerator = Input.GetEnumerator
        Dim ReturnString As String = ""
        Do While Enumerator.MoveNext()
            ReturnString = Enumerator.Current + ReturnString
        Loop
        Return ReturnString
    End Function

    Private Sub CropListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CropListToolStripMenuItem.Click
        Dim Counter As Integer = 1
        Dim Node As TreeNode

        TreeView.Hide()
        If TreeView.Nodes.Count > 0 Then
            Node = TreeView.Nodes.Item(0)
            While Not (Node.NextNode Is Nothing)
                Node = Node.NextNode
                If Counter > Val(Text_Crop.Text) Then
                    DestroyNode(Node.PrevNode)
                End If
                Counter += 1
            End While
            If Counter > Val(Text_Crop.Text) Then
                DestroyNode(Node)
            End If
        End If
        TreeView.Show()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If Not UndoList.Head Is Nothing Then
            TreeView.Nodes.Add(UndoList.Head.Info.GetNode())
            UndoList.Remove()
            Sort_List()
        End If
    End Sub

    Private Sub CopyAllReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyAllReportsToolStripMenuItem.Click
        Dim TempNode As TreeNode
        Dim ResultTxt As String = ""

        If TreeView.Nodes.Count > 0 Then
            TempNode = TreeView.Nodes.Item(0)
            While Not (TempNode Is Nothing)
                ResultTxt = ResultTxt + vbCrLf + vbCrLf + TempNode.Tag.Report()
                TempNode = TempNode.NextNode
            End While

            Clipboard.SetText(ResultTxt)
        End If
    End Sub
End Class

Public Class Information
    Private mReport As String = ""
    Private mName As String = ""
    Private mCoordinates As New Coords

    Private mMetal As Integer = 0
    Private mCrystal As Integer = 0
    Private mDeuterium As Integer = 0

    Private mLight As Integer = 0
    Private mHeavy As Integer = 0
    Private mSmall As Integer = 0
    Private mLarge As Integer = 0
    Private mProbe As Integer = 0
    Private mSat As Integer = 0
    Private mRecycler As Integer = 0
    Private mColony As Integer = 0
    Private mCruiser As Integer = 0
    Private mBShip As Integer = 0
    Private mBCruiser As Integer = 0
    Private mBomber As Integer = 0
    Private mDestroyer As Integer = 0
    Private mRIP As Integer = 0

    Private mRocket As Integer = 0
    Private mLLaser As Integer = 0
    Private mHLaser As Integer = 0
    Private mIon As Integer = 0
    Private mGauss As Integer = 0
    Private mPlasma As Integer = 0
    Private mSShield As Integer = 0
    Private mLShield As Integer = 0
    Private mABM As Integer = 0

    Private mWeapon As Integer = 0
    Private mShield As Integer = 0
    Private mArmor As Integer = 0

    Private mFleet As Boolean = False
    Private mDefense As Boolean = False
    Private mResearch As Boolean = False

    Public Property Report() As String
        Get
            Return mReport
        End Get
        Set(ByVal Value As String)
            mReport = Value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(ByVal Value As String)
            mName = Value
        End Set
    End Property
    Public Property Coordinates() As Coords
        Get
            Return mCoordinates
        End Get
        Set(ByVal Value As Coords)
            Value = Nothing
        End Set
    End Property

    Public Property TotalResources() As Integer
        Get
            Return (Metal + Crystal + Deuterium)
        End Get
        Set(ByVal Value As Integer)
            Value = Nothing
        End Set
    End Property
    Public Property WeightedResources() As Integer
        Get
            Return (Metal * Int(Val(FrmMain.Text_Weight_Metal.Text)) + Crystal * Int(Val(FrmMain.Text_Weight_Crystal.Text)) + Deuterium * Int(Val(FrmMain.Text_Weight_Deuterium.Text)))
        End Get
        Set(ByVal Value As Integer)
            Value = Nothing
        End Set
    End Property
    Public Property Metal() As Integer
        Get
            Return mMetal
        End Get
        Set(ByVal Value As Integer)
            mMetal = Value
        End Set
    End Property
    Public Property Crystal() As Integer
        Get
            Return mCrystal
        End Get
        Set(ByVal Value As Integer)
            mCrystal = Value
        End Set
    End Property
    Public Property Deuterium() As Integer
        Get
            Return mDeuterium
        End Get
        Set(ByVal Value As Integer)
            mDeuterium = Value
        End Set
    End Property

    Public Property Light() As Integer
        Get
            Return mLight
        End Get
        Set(ByVal Value As Integer)
            mLight = Value
        End Set
    End Property
    Public Property Heavy() As Integer
        Get
            Return mHeavy
        End Get
        Set(ByVal Value As Integer)
            mHeavy = Value
        End Set
    End Property
    Public Property Small() As Integer
        Get
            Return mSmall
        End Get
        Set(ByVal Value As Integer)
            mSmall = Value
        End Set
    End Property
    Public Property Large() As Integer
        Get
            Return mLarge
        End Get
        Set(ByVal Value As Integer)
            mLarge = Value
        End Set
    End Property
    Public Property Probe() As Integer
        Get
            Return mProbe
        End Get
        Set(ByVal Value As Integer)
            mProbe = Value
        End Set
    End Property
    Public Property Sat() As Integer
        Get
            Return mSat
        End Get
        Set(ByVal Value As Integer)
            mSat = Value
        End Set
    End Property
    Public Property Recycler() As Integer
        Get
            Return mRecycler
        End Get
        Set(ByVal Value As Integer)
            mRecycler = Value
        End Set
    End Property
    Public Property Colony() As Integer
        Get
            Return mColony
        End Get
        Set(ByVal Value As Integer)
            mColony = Value
        End Set
    End Property
    Public Property Cruiser() As Integer
        Get
            Return mCruiser
        End Get
        Set(ByVal Value As Integer)
            mCruiser = Value
        End Set
    End Property
    Public Property BShip() As Integer
        Get
            Return mBShip
        End Get
        Set(ByVal Value As Integer)
            mBShip = Value
        End Set
    End Property
    Public Property BCruiser() As Integer
        Get
            Return mBCruiser
        End Get
        Set(ByVal Value As Integer)
            mBCruiser = Value
        End Set
    End Property
    Public Property Bomber() As Integer
        Get
            Return mBomber
        End Get
        Set(ByVal Value As Integer)
            mBomber = Value
        End Set
    End Property
    Public Property Destroyer() As Integer
        Get
            Return mDestroyer
        End Get
        Set(ByVal Value As Integer)
            mDestroyer = Value
        End Set
    End Property
    Public Property RIP() As Integer
        Get
            Return mRIP
        End Get
        Set(ByVal Value As Integer)
            mRIP = Value
        End Set
    End Property

    Public Property Rocket() As Integer
        Get
            Return mRocket
        End Get
        Set(ByVal Value As Integer)
            mRocket = Value
        End Set
    End Property
    Public Property LLaser() As Integer
        Get
            Return mLLaser
        End Get
        Set(ByVal Value As Integer)
            mLLaser = Value
        End Set
    End Property
    Public Property HLaser() As Integer
        Get
            Return mHLaser
        End Get
        Set(ByVal Value As Integer)
            mHLaser = Value
        End Set
    End Property
    Public Property Ion() As Integer
        Get
            Return mIon
        End Get
        Set(ByVal Value As Integer)
            mIon = Value
        End Set
    End Property
    Public Property Gauss() As Integer
        Get
            Return mGauss
        End Get
        Set(ByVal Value As Integer)
            mGauss = Value
        End Set
    End Property
    Public Property Plasma() As Integer
        Get
            Return mPlasma
        End Get
        Set(ByVal Value As Integer)
            mPlasma = Value
        End Set
    End Property
    Public Property SShield() As Integer
        Get
            Return mSShield
        End Get
        Set(ByVal Value As Integer)
            mSShield = Value
        End Set
    End Property
    Public Property LShield() As Integer
        Get
            Return mLShield
        End Get
        Set(ByVal Value As Integer)
            mLShield = Value
        End Set
    End Property
    Public Property ABM() As Integer
        Get
            Return mABM
        End Get
        Set(ByVal Value As Integer)
            mABM = Value
        End Set
    End Property

    Public Property Weapon() As Integer
        Get
            Return mWeapon
        End Get
        Set(ByVal Value As Integer)
            mWeapon = Value
        End Set
    End Property
    Public Property Shield() As Integer
        Get
            Return mShield
        End Get
        Set(ByVal Value As Integer)
            mShield = Value
        End Set
    End Property
    Public Property Armor() As Integer
        Get
            Return mArmor
        End Get
        Set(ByVal Value As Integer)
            mArmor = Value
        End Set
    End Property

    Public Property Fleet() As Boolean
        Get
            Return mFleet
        End Get
        Set(ByVal Value As Boolean)
            mFleet = Value
        End Set
    End Property
    Public Property Defense() As Boolean
        Get
            Return mDefense
        End Get
        Set(ByVal Value As Boolean)
            mDefense = Value
        End Set
    End Property
    Public Property Research() As Boolean
        Get
            Return mResearch
        End Get
        Set(ByVal Value As Boolean)
            mResearch = Value
        End Set
    End Property

    Public ReadOnly Property Color() As System.Drawing.Color
        Get
            ' 1 = Unknown = Purple
            ' 2 = Safe = Blue
            ' 3 = Defenses = Green
            ' 4 = Fleet = Orange
            ' 5 = Def + Fleet = Red
            'Unknown fleet or defense
            If mFleet = False Or mDefense = False Then
                Return System.Drawing.Color.Purple
                'Known fleet and known defense and fleet exists and defense exists
            ElseIf mFleet = True And mDefense = True And (mLight + mHeavy + mSmall + mLarge + mRecycler + mColony + mCruiser + mBShip + mBCruiser + mBomber + mDestroyer + mRIP) > 0 And _
            (mRocket + mLLaser + mHLaser + mIon + mGauss + mPlasma + mSShield + mLShield) > 0 Then
                Return System.Drawing.Color.Red
                'Known fleet and known defense and fleet exists and defense doesn't
            ElseIf mFleet = True And mDefense = True And (mLight + mHeavy + mSmall + mLarge + mRecycler + mColony + mCruiser + mBShip + mBCruiser + mBomber + mDestroyer + mRIP) > 0 And _
            (mRocket + mLLaser + mHLaser + mIon + mGauss + mPlasma + mSShield + mLShield) = 0 Then
                Return System.Drawing.Color.Orange
                'Known fleet and known defense and fleet doesn't exist and defense does
            ElseIf mFleet = True And mDefense = True And (mLight + mHeavy + mSmall + mLarge + mRecycler + mColony + mCruiser + mBShip + mBCruiser + mBomber + mDestroyer + mRIP) = 0 And _
            (mRocket + mLLaser + mHLaser + mIon + mGauss + mPlasma + mSShield + mLShield) > 0 Then
                Return System.Drawing.Color.Green
                'Known fleet and known defense and fleet doesn't exist and defense does
            ElseIf mFleet = True And mDefense = True And (mLight + mHeavy + mSmall + mLarge + mRecycler + mColony + mCruiser + mBShip + mBCruiser + mBomber + mDestroyer + mRIP) = 0 And _
            (mRocket + mLLaser + mHLaser + mIon + mGauss + mPlasma + mSShield + mLShield) = 0 Then
                Return System.Drawing.Color.Blue
            Else
                Return System.Drawing.Color.Black
            End If
        End Get
    End Property
    Public Property TreeName() As String
        Get
            Dim Storage As Integer = 5000
            Select Case FrmMain.Combo_Ship.SelectedItem
                Case "Small Cargo"
                    Storage = 5000
                Case "Large Cargo"
                    Storage = 25000
                Case "Light Fighter"
                    Storage = 50
                Case "Heavy Fighter"
                    Storage = 100
                Case "Cruiser"
                    Storage = 800
                Case "Battleship"
                    Storage = 1500
                Case "Recycler"
                    Storage = 20000
                Case "Bomber"
                    Storage = 500
                Case "Destroyer"
                    Storage = 2000
                Case "Battlecruiser"
                    Storage = 750
            End Select
            Return (Coordinates.Str + " - " + FrmMain.NumString(Metal * Val(FrmMain.Text_Weight_Metal.Text) + Crystal * Val(FrmMain.Text_Weight_Crystal.Text) + Deuterium * Val(FrmMain.Text_Weight_Deuterium.Text)) + " - " + Trim(Str(Int(TotalResources / (2 * Storage)) + 1)) + " - " + Name)
        End Get
        Set(ByVal Value As String)

        End Set
    End Property
    Public Property FleetUnits() As Integer
        Get
            Return (1000 * (Light * 4 + Heavy * 10 + Small * 4 + Large * 12 + Probe + Sat * 2 + Recycler * 16 + Colony * 30 + Cruiser * 27 + BShip * 60 + BCruiser * 70 + Bomber * 75 + Destroyer * 110 + RIP * 9000))
        End Get
        Set(ByVal Value As Integer)

        End Set
    End Property
    Public Property DefenseUnits() As Integer
        Get
            Return (1000 * (Rocket * 2 + LLaser * 2 + HLaser * 8 + Ion * 8 + Gauss * 35 + Plasma * 100 + SShield * 20 + LShield * 100))
        End Get
        Set(ByVal Value As Integer)

        End Set
    End Property

    Public ReadOnly Property GetNode() As TreeNode
        Get
            Dim Node As New TreeNode

            Node.Text = TreeName
            Node.Name = TreeName
            Node = Node.Nodes.Add(FrmMain.NumString(Metal) + "   " + FrmMain.NumString(Crystal) + "   " + FrmMain.NumString(Deuterium))

            If Fleet = True Then
                Node = Node.Nodes.Add("Fleet - " + FrmMain.NumString(FleetUnits))
                If FleetUnits > 0 Then
                    Node.ForeColor = Color.Red
                Else
                    Node.ForeColor = Color.Blue
                End If
                If Light > 0 Then
                    Node.Nodes.Add("Light Fighter - " + FrmMain.NumString(Light))
                End If
                If Heavy > 0 Then
                    Node.Nodes.Add("Heavy Fighter - " + FrmMain.NumString(Heavy))
                End If
                If Small > 0 Then
                    Node.Nodes.Add("Small Cargo - " + FrmMain.NumString(Small))
                End If
                If Large > 0 Then
                    Node.Nodes.Add("Large Cargo - " + FrmMain.NumString(Large))
                End If
                If Probe > 0 Then
                    Node.Nodes.Add("Espionage Probe - " + FrmMain.NumString(Probe))
                End If
                If Sat > 0 Then
                    Node.Nodes.Add("Solar Satellite - " + FrmMain.NumString(Sat))
                End If
                If Recycler > 0 Then
                    Node.Nodes.Add("Recycler - " + FrmMain.NumString(Recycler))
                End If
                If Colony > 0 Then
                    Node.Nodes.Add("Colony Ship - " + FrmMain.NumString(Colony))
                End If
                If Cruiser > 0 Then
                    Node.Nodes.Add("Cruiser - " + FrmMain.NumString(Cruiser))
                End If
                If BShip > 0 Then
                    Node.Nodes.Add("Battleship - " + FrmMain.NumString(BShip))
                End If
                If BCruiser > 0 Then
                    Node.Nodes.Add("Battlecruiser - " + FrmMain.NumString(BCruiser))
                End If
                If Bomber > 0 Then
                    Node.Nodes.Add("Bomber - " + FrmMain.NumString(Bomber))
                End If
                If Destroyer > 0 Then
                    Node.Nodes.Add("Destroyer - " + FrmMain.NumString(Destroyer))
                End If
                If RIP > 0 Then
                    Node.Nodes.Add("RIP - " + FrmMain.NumString(RIP))
                End If
                Node = Node.Parent

                If Defense = True Then
                    Node = Node.Nodes.Add("Defense - " + FrmMain.NumString(DefenseUnits))
                    If DefenseUnits > 0 Then
                        Node.ForeColor = Color.Red
                    Else
                        Node.ForeColor = Color.Blue
                    End If
                    If Rocket > 0 Then
                        Node.Nodes.Add("Rocket Launcher - " + FrmMain.NumString(Rocket))
                    End If
                    If LLaser > 0 Then
                        Node.Nodes.Add("Light Laser - " + FrmMain.NumString(LLaser))
                    End If
                    If HLaser > 0 Then
                        Node.Nodes.Add("Heavy Laser - " + FrmMain.NumString(HLaser))
                    End If
                    If Ion > 0 Then
                        Node.Nodes.Add("Ion - " + FrmMain.NumString(Ion))
                    End If
                    If Gauss > 0 Then
                        Node.Nodes.Add("Gauss Cannon - " + FrmMain.NumString(Gauss))
                    End If
                    If Plasma > 0 Then
                        Node.Nodes.Add("Plasma Turret - " + FrmMain.NumString(Plasma))
                    End If
                    If SShield > 0 Then
                        Node.Nodes.Add("Small Shield Dome - " + FrmMain.NumString(SShield))
                    End If
                    If LShield > 0 Then
                        Node.Nodes.Add("Large Shield Dome - " + FrmMain.NumString(LShield))
                    End If
                    If ABM > 0 Then
                        Node.Nodes.Add("Anti-Ballistic Missiles - " + FrmMain.NumString(ABM)).ForeColor = Color.Blue
                    End If
                    Node = Node.Parent

                    If Research = True Then
                        Node.Nodes.Add("Research - " + Trim(Str(Weapon)) + "/" + Trim(Str(Shield)) + "/" + Trim(Str(Armor)))
                    End If
                End If
            End If

            If FrmMain.Check_Expand_Second.Checked = True Then
                Node.Expand()
            End If
            Node = Node.Parent
            If FrmMain.Check_Expand_First.Checked = True Or FrmMain.Check_Expand_Second.Checked = True Then
                Node.Expand()
            End If
            Node.Tag = Me
            Node.ForeColor = Color
            Node.ContextMenuStrip = FrmMain.NodeMenu
            Return Node
        End Get
    End Property
End Class

Public Class NodeSorter
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Dim tx As TreeNode = CType(x, TreeNode)
        Dim ty As TreeNode = CType(y, TreeNode)
        Dim Infox As Information = tx.Tag
        Dim Infoy As Information = ty.Tag

        Dim DirModifier As Integer
        If FrmMain.SortUp = True Then
            DirModifier = 1
        Else
            DirModifier = -1
        End If

        If Not (Infox Is Nothing) And Not (Infoy Is Nothing) Then
            Select Case (FrmMain.Combo_Sort.SelectedItem)
                Case "Fleet Units"
                    If Infox.FleetUnits <> Infoy.FleetUnits Then
                        Return DirModifier * (Infoy.FleetUnits - Infox.FleetUnits)
                    ElseIf Infox.WeightedResources <> Infoy.WeightedResources Then
                        Return DirModifier * (Infoy.WeightedResources - Infox.WeightedResources)
                    End If
                Case "Defense Units"
                    If Infox.DefenseUnits <> Infoy.DefenseUnits Then
                        Return DirModifier * (Infoy.DefenseUnits - Infox.DefenseUnits)
                    ElseIf Infox.WeightedResources <> Infoy.WeightedResources Then
                        Return DirModifier * (Infoy.WeightedResources - Infox.WeightedResources)
                    End If
                Case "Coordinates"
                    If Infox.Coordinates.Str <> Infoy.Coordinates.Str Then
                        If Infox.Coordinates.Galaxy <> Infoy.Coordinates.Galaxy Then
                            Return DirModifier * (Infoy.Coordinates.Galaxy - Infox.Coordinates.Galaxy)
                        End If
                        If Infox.Coordinates.System <> Infoy.Coordinates.System Then
                            Return DirModifier * (Infoy.Coordinates.System - Infox.Coordinates.System)
                        End If
                        If Infox.Coordinates.Planet <> Infoy.Coordinates.Planet Then
                            Return DirModifier * (Infoy.Coordinates.Planet - Infox.Coordinates.Planet)
                        End If
                    End If
                Case "Shortest Distance"
                    Dim debug0 As Integer = FrmMain.HomeCoords.Galaxy
                    Dim debug1 As Integer = FrmMain.HomeCoords.System
                    Dim debug2 As Integer = FrmMain.HomeCoords.Planet
                    If Infox.Coordinates.Str <> Infoy.Coordinates.Str Then
                        'Different coordinates
                        If Math.Abs(debug0 - Infox.Coordinates.Galaxy) <> Math.Abs(debug0 - Infoy.Coordinates.Galaxy) Then
                            'Different coordinates, different galaxy distance
                            Return DirModifier * (Math.Abs(debug0 - Infox.Coordinates.Galaxy) - Math.Abs(debug0 - Infoy.Coordinates.Galaxy))
                        Else
                            'Different coordinates, same galaxy distance
                            If Infox.Coordinates.Galaxy <> debug0 Then
                                'Different coordinates, same galaxy distance, not home galaxy - sort by resources
                                If Infox.WeightedResources <> Infoy.WeightedResources Then
                                    Return DirModifier * (Infoy.WeightedResources - Infox.WeightedResources)
                                End If
                            Else
                                'Different coordinates, same galaxy, home galaxy - check system
                                If Math.Abs(debug1 - Infox.Coordinates.System) <> Math.Abs(debug1 - Infoy.Coordinates.System) Then
                                    'Different coordinates, same galaxy, home galaxy, different system distance
                                    Return DirModifier * (Math.Abs(debug1 - Infox.Coordinates.System) - Math.Abs(debug1 - Infoy.Coordinates.System))
                                Else
                                    'Different coordinates, same galaxy, home galaxy, same system distance
                                    If Infox.Coordinates.System <> debug1 Then
                                        'Different coordinates, same galaxy, home galaxy, same system, not home system - sort by resources
                                        If Infox.WeightedResources <> Infoy.WeightedResources Then
                                            Return DirModifier * (Infoy.WeightedResources - Infox.WeightedResources)
                                        End If
                                    Else
                                        'Different coordinates, same galaxy, home galaxy, same system, home system - check planet
                                        If Math.Abs(debug2 - Infox.Coordinates.Planet) <> Math.Abs(debug2 - Infoy.Coordinates.Planet) Then
                                            'Different coordinates, same galaxy, home galaxy, same system, home system, different planet distance
                                            Return DirModifier * (Math.Abs(debug2 - Infox.Coordinates.Planet) - Math.Abs(debug2 - Infoy.Coordinates.Planet))
                                        Else
                                            'Different coordinates, same galaxy, home galaxy, same system, home system, same planet distance - sort by resources
                                            Return DirModifier * (Infoy.WeightedResources - Infox.WeightedResources)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    ElseIf Infox.WeightedResources <> Infoy.WeightedResources Then
                        'Same coordinates - sort by resources
                        Return DirModifier * (Infoy.WeightedResources - Infox.WeightedResources)
                    End If
                Case "Metal"
                    If Infox.Metal <> Infoy.Metal Then
                        Return DirModifier * (Infoy.Metal - Infox.Metal)
                    ElseIf Infox.WeightedResources <> Infoy.WeightedResources Then
                        Return DirModifier * (Infoy.WeightedResources - Infox.WeightedResources)
                    End If
                Case "Crystal"
                    If Infox.Crystal <> Infoy.Crystal Then
                        Return DirModifier * (Infoy.Crystal - Infox.Crystal)
                    ElseIf Infox.WeightedResources <> Infoy.WeightedResources Then
                        Return DirModifier * (Infoy.WeightedResources - Infox.WeightedResources)
                    End If
                Case "Deuterium"
                    If Infox.Deuterium <> Infoy.Deuterium Then
                        Return DirModifier * (Infoy.Deuterium - Infox.Deuterium)
                    ElseIf Infox.WeightedResources <> Infoy.WeightedResources Then
                        Return DirModifier * (Infoy.WeightedResources - Infox.WeightedResources)
                    End If
                Case "Weighted Resources"
                    If Infox.WeightedResources <> Infoy.WeightedResources Then
                        Return DirModifier * (Infoy.WeightedResources - Infox.WeightedResources)
                    End If
                Case "Unweighted Resources"
                    If Infox.TotalResources <> Infoy.TotalResources Then
                        Return DirModifier * (Infoy.TotalResources - Infox.TotalResources)
                    End If
            End Select
        ElseIf FrmMain.NodeLevel(tx) = 3 And FrmMain.NodeLevel(ty) = 3 Then
            If tx.Text.Contains("Research") = True Then
                Return 1
            ElseIf ty.Text.Contains("Research") = True Then
                Return -1
            ElseIf tx.Text.Contains("Fleet") = True Then
                Return -1
            ElseIf ty.Text.Contains("Fleet") = True Then
                Return 1
            End If
        ElseIf FrmMain.NodeLevel(tx) = 4 And FrmMain.NodeLevel(ty) = 4 Then
            If tx.Parent.Text.Contains("Defense") Then
                If tx.Text.Contains("Rocket") Then
                    Return -1
                ElseIf ty.Text.Contains("Rocket") Then
                    Return 1
                ElseIf tx.Text.Contains("Light Laser") Then
                    Return -1
                ElseIf ty.Text.Contains("Light Laser") Then
                    Return 1
                ElseIf tx.Text.Contains("Heavy Laser") Then
                    Return -1
                ElseIf ty.Text.Contains("Heavy Laser") Then
                    Return 1
                ElseIf tx.Text.Contains("Ion") Then
                    Return -1
                ElseIf ty.Text.Contains("Ion") Then
                    Return 1
                ElseIf tx.Text.Contains("Gauss") Then
                    Return -1
                ElseIf ty.Text.Contains("Gauss") Then
                    Return 1
                ElseIf tx.Text.Contains("Plasma") Then
                    Return -1
                ElseIf ty.Text.Contains("Plasma") Then
                    Return 1
                ElseIf tx.Text.Contains("Small Shield") Then
                    Return -1
                ElseIf ty.Text.Contains("Small Shield") Then
                    Return 1
                ElseIf tx.Text.Contains("Large Shield") Then
                    Return -1
                ElseIf ty.Text.Contains("Large Shield") Then
                    Return 1
                End If
            ElseIf tx.Parent.Text.Contains("Fleet") Then
                If tx.Text.Contains("Small Cargo") Then
                    Return -1
                ElseIf ty.Text.Contains("Small Cargo") Then
                    Return 1
                ElseIf tx.Text.Contains("Large Cargo") Then
                    Return -1
                ElseIf ty.Text.Contains("Large Cargo") Then
                    Return 1
                ElseIf tx.Text.Contains("Light Fighter") Then
                    Return -1
                ElseIf ty.Text.Contains("Light Fighter") Then
                    Return 1
                ElseIf tx.Text.Contains("Heavy Fighter") Then
                    Return -1
                ElseIf ty.Text.Contains("Heavy Fighter") Then
                    Return 1
                ElseIf tx.Text.Contains("Cruiser") Then
                    Return -1
                ElseIf ty.Text.Contains("Cruiser") Then
                    Return 1
                ElseIf tx.Text.Contains("Battleship") Then
                    Return -1
                ElseIf ty.Text.Contains("Battleship") Then
                    Return 1
                ElseIf tx.Text.Contains("Colony") Then
                    Return -1
                ElseIf ty.Text.Contains("Colony") Then
                    Return 1
                ElseIf tx.Text.Contains("Recycler") Then
                    Return -1
                ElseIf ty.Text.Contains("Recycler") Then
                    Return 1
                ElseIf tx.Text.Contains("Probe") Then
                    Return -1
                ElseIf ty.Text.Contains("Prober") Then
                    Return 1
                ElseIf tx.Text.Contains("Bomber") Then
                    Return -1
                ElseIf ty.Text.Contains("Bomber") Then
                    Return 1
                ElseIf tx.Text.Contains("Sat") Then
                    Return -1
                ElseIf ty.Text.Contains("Sat") Then
                    Return 1
                ElseIf tx.Text.Contains("Destroyer") Then
                    Return -1
                ElseIf ty.Text.Contains("Destroyer") Then
                    Return 1
                ElseIf tx.Text.Contains("RIP") Then
                    Return -1
                ElseIf ty.Text.Contains("RIP") Then
                    Return 1
                End If
            End If
        End If
        Return 1
    End Function
End Class

Public Class Coords
    Public Property Galaxy As Integer = 0
    Public Property System As Integer = 0
    Public Property Planet As Integer = 0

    Public Property Str As String
        Get
            Return "[" + Galaxy.ToString + ":" + System.ToString + ":" + Planet.ToString + "]"
        End Get
        Set(ByVal Value As String)
            Dim Substrings As String() = Value.Replace("]", "").Replace("[", "").Split(":")
            If Substrings.Length = 3 Then
                Galaxy = CInt(Substrings(0))
                System = CInt(Substrings(1))
                Planet = CInt(Substrings(2))
            Else
                Galaxy = -1
                System = -1
                Planet = -1
            End If
        End Set
    End Property
End Class

Public Class LinkedListNode
    Private mNext As LinkedListNode
    Private mInformation As Information

    Public Sub New(ByVal Value As Information)
        mInformation = Value
    End Sub

    Public Property NextItem() As LinkedListNode
        Get
            Return mNext
        End Get
        Set(ByVal Value As LinkedListNode)
            mNext = Value
        End Set
    End Property

    Public ReadOnly Property Info() As Information
        Get
            Return mInformation
        End Get
    End Property
End Class

Public Class LinkedList
    Private mHead As LinkedListNode

    Public Sub Add(ByRef Value As Information)
        Dim NewNode As New LinkedListNode(Value)
        NewNode.NextItem = mHead
        mHead = NewNode
    End Sub

    Public Sub Remove()
        If Not mHead Is Nothing Then
            If Not mHead.NextItem Is Nothing Then
                mHead = mHead.NextItem
            Else
                mHead = Nothing
            End If
        End If
    End Sub

    Public ReadOnly Property Head() As LinkedListNode
        Get
            Return mHead
        End Get
    End Property
End Class
