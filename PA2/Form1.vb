Imports System.IO

Public Class Form1
    Dim img As Graphics
    Dim cClicked As Boolean
    Dim eClicked As Boolean
    Dim cCount As Integer
    Dim eCount As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cClicked = False
        eClicked = False
        cCount = 0
        eCount = 0
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Label1.Text = "X: " + e.X.ToString
        Label2.Text = "Y: " + e.Y.ToString
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Label1.Text = "X: -"
        Label2.Text = "Y: -"
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles cButton.Click, eButton.Click, clrButton.Click, colButton.Click
        Dim button As Button = sender

        If button.Text = "Circle" Then
            If eClicked = True Then
                eClicked = False
            End If
            cClicked = True
        ElseIf button.Text = "Ellipse" Then
            If cClicked = True Then
                cClicked = False
            End If
            eClicked = True
        ElseIf button.Text = "Color" Then
            If ListBox1.SelectedIndex = -1 Then
                ColorDialog1.ShowDialog()
            Else
                ColorDialog1.ShowDialog()
                Dim newC As Color = ColorDialog1.Color
                Dim newbrush As New SolidBrush(newC)
                img = PictureBox1.CreateGraphics

                If ListBox1.SelectedItem.itemName = "Circle" Then
                    drawCircle(ListBox1.SelectedItem.cData.xc, ListBox1.SelectedItem.cData.yc, ListBox1.SelectedItem.cData.r, ListBox1.SelectedItem.cData.t, newbrush)
                    ListBox1.Items.Add(New CListItem("Circle", ListBox1.SelectedItem.itemCount, ListBox1.SelectedItem.cData.xc, ListBox1.SelectedItem.cData.yc, ListBox1.SelectedItem.cData.r, ListBox1.SelectedItem.cData.t, newC))
                    ListBox1.Items.Remove(ListBox1.SelectedItem)

                    refresh()
                    img.Dispose()
                Else
                    drawEllipse(ListBox1.SelectedItem.eData.xc, ListBox1.SelectedItem.eData.yc, ListBox1.SelectedItem.eData.a, ListBox1.SelectedItem.eData.b, ListBox1.SelectedItem.eData.t, newbrush)
                    ListBox1.Items.Add(New EListItem("Ellipse", ListBox1.SelectedItem.itemCount, ListBox1.SelectedItem.eData.xc, ListBox1.SelectedItem.eData.yc, ListBox1.SelectedItem.eData.a, ListBox1.SelectedItem.eData.b, ListBox1.SelectedItem.eData.t, newC))
                    ListBox1.Items.Remove(ListBox1.SelectedItem)

                    refresh()
                    img.Dispose()
                End If
            End If
        Else
            ListBox1.Items.Clear()
            cCount = 0
            eCount = 0
            img = PictureBox1.CreateGraphics
            img.Clear(Color.White)
            img.Dispose()
            delButton.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        img = PictureBox1.CreateGraphics
        Dim t As Integer = NumericThickness.Value
        Dim c As Color = ColorDialog1.Color
        Dim brush As New SolidBrush(c)

        Dim pBoxX As Integer = e.X
        Dim pBoxY As Integer = e.Y

        If cClicked = True Then
            Dim r As Integer = NumericRAD.Value

            drawCircle(pBoxX, pBoxY, r, t, brush)
            cCount += 1

            ListBox1.Items.Add(New CListItem("Circle", cCount, pBoxX, pBoxY, r, t, c))
        ElseIf eClicked Then
            Dim a As Long = NumericA.Value
            Dim b As Long = NumericB.Value

            drawEllipse(pBoxX, pBoxY, a, b, t, brush)
            eCount += 1

            ListBox1.Items.Add(New EListItem("Ellipse", eCount, pBoxX, pBoxY, a, b, t, c))
        End If
        img.Dispose()
    End Sub

    Private Sub drawCircle(xc As Integer, yc As Integer, r As Integer, t As Integer, brush As Brush)
        Dim x As Integer = 0
        Dim y As Integer = r
        Dim d As Integer = 1 - r

        img.FillRectangle(brush, xc - 2, yc - 2, 4, 4) 'Center
        While x <= y
            img.FillRectangle(brush, x + xc, y + yc, t, t) 'Octant 1
            img.FillRectangle(brush, y + xc, x + yc, t, t) 'Octant 2
            img.FillRectangle(brush, y + xc, yc - x, t, t) 'Octant 3
            img.FillRectangle(brush, x + xc, yc - y, t, t) 'Octant 4
            img.FillRectangle(brush, xc - x, yc - y, t, t) 'Octant 5
            img.FillRectangle(brush, xc - y, yc - x, t, t) 'Octant 6
            img.FillRectangle(brush, xc - y, x + yc, t, t) 'Octant 7
            img.FillRectangle(brush, xc - x, y + yc, t, t) 'Octant 8
            If d < 0 Then
                d += 2 * x + 3
            Else
                d += 2 * (x - y) + 5
                y -= 1
            End If
            x += 1
        End While
    End Sub

    Private Sub drawEllipse(xc As Integer, yc As Integer, a As Integer, b As Integer, t As Integer, brush As Brush)
        Dim x As Integer = 0
        Dim y As Integer = b
        Dim d As Long = 4 * b * b - 4 * a * a * b + a * a

        img.FillRectangle(brush, xc - 2, yc - 2, 4, 4) 'Center
        While 2 * b * b * (x + 1) < a * a * (2 * y - 1)
            img.FillRectangle(brush, xc + x, yc + y, t, t) 'Octant 1
            img.FillRectangle(brush, xc + x, yc - y, t, t) 'Octant 4
            img.FillRectangle(brush, xc - x, yc - y, t, t) 'Octant 5
            img.FillRectangle(brush, xc - x, yc + y, t, t) 'Octant 8
            If d > 0 Then
                y -= 1
                d += b * b * (8 * x + 12) + a * a * (8 - 8 * y)
            Else
                d += b * b * (8 * x + 12)
            End If
            x += 1
        End While

        d = b * b * (2 * x + 1) * (2 * x + 1) + 4 * a * a * (y - 1) * (y - 1) - 4 * a * a * b * b

        While y > 0
            If d < 0 Then
                x += 1
                d += b * b * (8 * x + 8) + a * a * (12 - 8 * y)
            Else
                d += a * a * (12 - 8 * y)
            End If
            y -= 1
            img.FillRectangle(brush, xc + x, yc + y, t, t) 'Octant 2
            img.FillRectangle(brush, xc + x, yc - y, t, t) 'Octant 3
            img.FillRectangle(brush, xc - x, yc - y, t, t) 'Octant 6
            img.FillRectangle(brush, xc - x, yc + y, t, t) 'Octant 7
        End While
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.Items.Count > 0 Then
            delButton.Enabled = True
        Else
            delButton.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles delButton.Click
        img = PictureBox1.CreateGraphics
        Dim brush As New SolidBrush(Color.White)
        If ListBox1.SelectedItem.itemName = "Circle" Then
            drawCircle(ListBox1.SelectedItem.cData.xc, ListBox1.SelectedItem.cData.yc, ListBox1.SelectedItem.cData.r, ListBox1.SelectedItem.cData.t, brush)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            delButton.Enabled = False
        Else
            drawEllipse(ListBox1.SelectedItem.eData.xc, ListBox1.SelectedItem.eData.yc, ListBox1.SelectedItem.eData.a, ListBox1.SelectedItem.eData.b, ListBox1.SelectedItem.eData.t, brush)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            delButton.Enabled = False
        End If
        img.Dispose()
    End Sub

    Private Sub rfshButton_Click(sender As Object, e As EventArgs) Handles rfshButton.Click
        refresh()
    End Sub

    Sub refresh()
        img = PictureBox1.CreateGraphics
        img.Clear(Color.White)

        For Each list In ListBox1.Items
            If list.itemName = "Circle" Then
                Dim brush As New SolidBrush(list.cData.c)
                drawCircle(list.cData.xc, list.cData.yc, list.cData.r, list.cData.t, brush)
            Else
                Dim brush As New SolidBrush(list.eData.c)
                drawEllipse(list.eData.xc, list.eData.yc, list.eData.a, list.eData.b, list.eData.t, brush)
            End If
        Next
    End Sub

    Private Sub NumericThickness_ValueChanged(sender As Object, e As EventArgs) Handles NumericThickness.ValueChanged
        Dim newThick As Integer = NumericThickness.Value
        img = PictureBox1.CreateGraphics

        If ListBox1.SelectedIndex = -1 Then
            'Do Nothing
        ElseIf ListBox1.SelectedItem.itemName = "Circle" Then
            Dim brush As New SolidBrush(ListBox1.SelectedItem.cData.c)
            drawCircle(ListBox1.SelectedItem.cData.xc, ListBox1.SelectedItem.cData.yc, ListBox1.SelectedItem.cData.r, newThick, brush)
            ListBox1.Items.Add(New CListItem("Circle", ListBox1.SelectedItem.itemCount, ListBox1.SelectedItem.cData.xc, ListBox1.SelectedItem.cData.yc, ListBox1.SelectedItem.cData.r, newThick, ListBox1.SelectedItem.cData.c))
            ListBox1.Items.Remove(ListBox1.SelectedItem)

            refresh()
            img.Dispose()
        Else
            Dim brush As New SolidBrush(ListBox1.SelectedItem.eData.c)
            drawEllipse(ListBox1.SelectedItem.eData.xc, ListBox1.SelectedItem.eData.yc, ListBox1.SelectedItem.eData.a, ListBox1.SelectedItem.eData.b, newThick, brush)
            ListBox1.Items.Add(New EListItem("Ellipse", ListBox1.SelectedItem.itemCount, ListBox1.SelectedItem.eData.xc, ListBox1.SelectedItem.eData.yc, ListBox1.SelectedItem.eData.a, ListBox1.SelectedItem.eData.b, newThick, ListBox1.SelectedItem.eData.c))
            ListBox1.Items.Remove(ListBox1.SelectedItem)

            refresh()
            img.Dispose()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Using sr As StreamReader = New StreamReader(OpenFileDialog1.FileName)
                Dim line As String = sr.ReadLine()
                img = PictureBox1.CreateGraphics
                img.Clear(Color.White)
                ListBox1.Items.Clear()
                While (line <> Nothing)
                    Dim list() As String
                    If line = "Circle" Then
                        ReDim list(6)
                        For i = 0 To 6
                            list(i) = line
                            line = sr.ReadLine
                        Next
                        Dim brush As New SolidBrush(Color.FromName(list(6).Replace("Color [", "").Replace("]", "")))
                        drawCircle(CInt(list(2)), CInt(list(3)), CInt(list(4)), CInt(list(5)), brush)
                        cCount += 1

                        ListBox1.Items.Add(New CListItem(list(0), list(1), CInt(list(2)), CInt(list(3)), CInt(list(4)), CInt(list(5)), Color.FromName(list(6).Replace("Color [", "").Replace("]", ""))))
                    Else
                        ReDim list(7)
                        For i = 0 To 7
                            list(i) = line
                            Console.WriteLine(list(i))
                            line = sr.ReadLine
                        Next
                        Dim brush As New SolidBrush(Color.FromName(list(7).Replace("Color [", "").Replace("]", "")))
                        drawEllipse(CInt(list(2)), CInt(list(3)), CInt(list(4)), CInt(list(5)), CInt(list(6)), brush)
                        eCount += 1

                        ListBox1.Items.Add(New EListItem(list(0), list(1), CInt(list(2)), CInt(list(3)), CInt(list(4)), CInt(list(5)), CInt(list(6)), Color.FromName(list(7).Replace("Color [", "").Replace("]", ""))))
                    End If
                End While
                img.Dispose()
            End Using
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        save()
    End Sub

    Sub save()
        If ListBox1.Items.Count > 0 Then
            If SaveFileDialog1.FileName = Nothing Then
                SaveAs()
            Else
                Using sw As New StreamWriter(SaveFileDialog1.FileName)
                    For Each list In ListBox1.Items
                        sw.WriteLine(list.itemName)
                        If list.itemName = "Circle" Then
                            sw.WriteLine(list.itemCount)
                            sw.WriteLine(list.cData.xc)
                            sw.WriteLine(list.cData.yc)
                            sw.WriteLine(list.cData.r)
                            sw.WriteLine(list.cData.t)
                            sw.WriteLine(list.cData.c)
                        Else
                            sw.WriteLine(list.itemCount)
                            sw.WriteLine(list.eData.xc)
                            sw.WriteLine(list.eData.yc)
                            sw.WriteLine(list.eData.a)
                            sw.WriteLine(list.eData.b)
                            sw.WriteLine(list.eData.t)
                            sw.WriteLine(list.eData.c)
                        End If
                    Next
                End Using
            End If
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveAs()
    End Sub

    Sub SaveAs()
        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            If ListBox1.Items.Count > 0 Then
                Using sw As New StreamWriter(SaveFileDialog1.FileName)
                    For Each list In ListBox1.Items
                        sw.WriteLine(list.itemName)
                        If list.itemName = "Circle" Then
                            sw.WriteLine(list.itemCount)
                            sw.WriteLine(list.cData.xc)
                            sw.WriteLine(list.cData.yc)
                            sw.WriteLine(list.cData.r)
                            sw.WriteLine(list.cData.t)
                            sw.WriteLine(list.cData.c)
                        Else
                            sw.WriteLine(list.itemCount)
                            sw.WriteLine(list.eData.xc)
                            sw.WriteLine(list.eData.yc)
                            sw.WriteLine(list.eData.a)
                            sw.WriteLine(list.eData.b)
                            sw.WriteLine(list.eData.t)
                            sw.WriteLine(list.eData.c)
                        End If
                    Next
                End Using
            End If
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        If ListBox1.Items.Count > 0 Then
            If MessageBox.Show("Do you want to save this work?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                save()
            Else
                Me.Close()
            End If
        End If
    End Sub
End Class

Public Class CListItem
    Structure oData
        Dim xc, yc, r, t As Integer
        Dim c As Color
    End Structure

    Public itemName As String
    Public itemCount As Integer
    Public cData As oData

    Public Sub New(s As String, n As Integer, xc As Integer, yc As Integer, r As Integer, t As Integer, c As Color)
        itemName = s
        itemCount = n
        cData.xc = xc
        cData.yc = yc
        cData.r = r
        cData.t = t
        cData.c = c
    End Sub

    Public Overrides Function ToString() As String
        Return itemName + " " + itemCount.ToString
    End Function
End Class

Public Class EListItem
    Structure oData
        Dim xc, yc, a, b, t As Integer
        Dim c As Color
    End Structure

    Public itemName As String
    Public itemCount As Integer
    Public eData As oData

    Public Sub New(s As String, n As Integer, xc As Integer, yc As Integer, a As Integer, b As Integer, t As Integer, c As Color)
        itemName = s
        itemCount = n
        eData.xc = xc
        eData.yc = yc
        eData.a = a
        eData.b = b
        eData.t = t
        eData.c = c
    End Sub

    Public Overrides Function ToString() As String
        Return itemName + " " + itemCount.ToString
    End Function
End Class