
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'awd.SelectionMode = SelectionMode.MultiExtended
        'awd.SelectedItem = awd.Items(0)
        For i As Integer = 0 To awd.Items.Count + 1
            Label2.Text = i
        Next i

        ' awd.SelectedItem = awd.Items(1)

        'Label2.Text = "11"
        ' awd.SelectedItems.Clear()

        'Label1.Text = Microsoft.VisualBasic.Left(awd.Items(0), 3)
        'Label2.Text = awd.Items(0)
        'Label2.Text = awd.Items(4)



    End Sub
End Class
