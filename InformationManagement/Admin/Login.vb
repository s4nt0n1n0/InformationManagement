Public Class Login
    Private Sub AdminBot_Click(sender As Object, e As EventArgs) Handles AdminBot.Click
        ' Show the Admin login form
        Dim adminForm As New Adminlogin()

        ' Match the current Login form's state and size
        adminForm.WindowState = Me.WindowState
        adminForm.Size = Me.Size
        adminForm.Location = Me.Location

        adminForm.Show()
        Me.Hide()
    End Sub

    Private Sub Staff1_Click(sender As Object, e As EventArgs) Handles Staff1.Click
        ' Show the StaffLogin form
        Dim staffForm As New Stafflogin()

        ' Match the current Login form's state and size
        staffForm.WindowState = Me.WindowState
        staffForm.Size = Me.Size
        staffForm.Location = Me.Location

        staffForm.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: open Login in normal state (not forced fullscreen)
        ' You can leave this empty or force fullscreen if you want:
        ' Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' You can leave this empty
    End Sub
End Class