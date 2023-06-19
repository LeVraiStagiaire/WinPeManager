Imports System.IO

Public Class Form1

    Private ProjectPath As String

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            ProjectPath = FolderBrowserDialog1.SelectedPath
            ProjectPathText.Text = ProjectPath
        End If
    End Sub

    Private Sub ProjectPathText_TextChanged(sender As Object, e As EventArgs) Handles ProjectPathText.TextChanged
        ProjectPath = ProjectPathText.Text
        If IO.Directory.Exists(ProjectPath) Then
            ProjectPathText.ForeColor = Color.Green
            If IO.File.Exists(ProjectPath + "\Media\sources\boot.wim") Then
                MountImage.Enabled = True
                Export.Enabled = True
                CreateProjectButton.Enabled = False
            Else
                MountImage.Enabled = False
                Export.Enabled = False
                CreateProjectButton.Enabled = True
            End If
        Else
            ProjectPathText.ForeColor = Color.Red
        End If
    End Sub

    Private Sub MountImage_Click(sender As Object, e As EventArgs) Handles MountImage.Click
        MountImage.Text = "Montage..."
        Cursor = Cursors.WaitCursor
        Dim StartInfo As New ProcessStartInfo With {
            .FileName = "cmd.exe",
            .Arguments = "/k DISM /Mount-Image /ImageFile:" + ProjectPath + "\Media\sources\boot.wim /index:1 /MountDir:" + ProjectPath + "\mount",
            .Verb = "runas",
            .RedirectStandardInput = True,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }
        Dim Process As Process = Process.Start(StartInfo)
        Process.StandardInput.WriteLine("exit")
        Debug.WriteLine("Command: " + StartInfo.Arguments)
        Debug.WriteLine(Process.StandardOutput.ReadToEnd)
        Process.WaitForExit()
        Process.Close()
        MessageBox.Show("Image montée dans " + ProjectPath + "\mount !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        MountImage.Enabled = False
        MountImage.Text = "Monter"
        CommitImage.Enabled = True
        UnmountImage.Enabled = True
        Export.Enabled = True
    End Sub

    Private Sub CommitImage_Click(sender As Object, e As EventArgs) Handles CommitImage.Click
        CommitImage.Text = "Sauvegarde..."
        Dim StartInfo As New ProcessStartInfo With {
            .FileName = "cmd.exe",
            .Arguments = "/k DISM /Commit-Image /MountDir:" + ProjectPath + "\mount /CheckIntegrity",
            .Verb = "runas",
            .RedirectStandardInput = True,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }
        Dim Process As Process = Process.Start(StartInfo)
        Process.StandardInput.WriteLine("exit")
        Debug.WriteLine("Command: " + StartInfo.Arguments)
        Debug.WriteLine(Process.StandardOutput.ReadToEnd)
        Process.WaitForExit()
        Process.Close()
        MessageBox.Show("Image enregistrée !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        CommitImage.Text = "Sauvegarder"
    End Sub

    Private Sub UnmountImage_Click(sender As Object, e As EventArgs) Handles UnmountImage.Click
        UnmountImage.Text = "Démontage..."
        Dim Discard As Boolean = MessageBox.Show("Voulez-vous enregistrer les modifications apportées à l'image ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim StartInfo As New ProcessStartInfo With {
            .FileName = "cmd.exe",
            .Arguments = "/k DISM /Unmount-Image /MountDir:" + ProjectPath + "\mount " + If(Discard, "/Discard", " /Commit"),
            .Verb = "runas",
            .RedirectStandardInput = True,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }
        Dim Process As Process = Process.Start(StartInfo)
        Process.StandardInput.WriteLine("exit")
        Debug.WriteLine("Command: " + StartInfo.Arguments)
        Debug.WriteLine(Process.StandardOutput.ReadToEnd)
        Process.WaitForExit()
        Process.Close()
        MessageBox.Show("Image démontée !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        MountImage.Enabled = True
        CommitImage.Enabled = False
        UnmountImage.Enabled = False
        UnmountImage.Text = "Démonter"
        Export.Enabled = True
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Export.Text = "Exportation..."
        Dim StartInfo As New ProcessStartInfo With {
            .FileName = "cmd.exe",
            .WorkingDirectory = "C:\Program Files (x86)\Windows Kits\10\Assessment and Deployment Kit\Deployment Tools\",
            .Arguments = "/k C:\Program Files (x86)\Windows Kits\10\Assessment and Deployment Kit\Deployment Tools\DandISetEnv.bat",
            .Verb = "runas",
            .RedirectStandardInput = True,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }
        Dim Process As Process = Process.Start(StartInfo)
        Process.StandardInput.WriteLine("Makewinpemedia /iso /f " + ProjectPath + "\Media " + SaveFileDialog1.FileName)
        Process.StandardInput.WriteLine("exit")
        Debug.WriteLine("Command: " + StartInfo.Arguments)
        Debug.WriteLine(Process.StandardOutput.ReadToEnd)
        Process.WaitForExit()
        Process.Close()
        MessageBox.Show("Image exportée !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Export.Text = "Exporter"
    End Sub

    Private Sub CreateProjectButton_Click(sender As Object, e As EventArgs) Handles CreateProjectButton.Click
        If CreateProject.ShowDialog() = DialogResult.OK Then
            Dim StartInfo As New ProcessStartInfo With {
                .FileName = "cmd.exe",
                .WorkingDirectory = Directory.GetCurrentDirectory(),
                .Verb = "runas",
                .RedirectStandardInput = True,
                .RedirectStandardOutput = True,
                .RedirectStandardError = True,
                .UseShellExecute = False,
                .CreateNoWindow = True
            }
            Dim Process As Process = Process.Start(StartInfo)
            MessageBox.Show(CreateProject.ComboBox1.SelectedItem)
            Process.StandardInput.WriteLine("copype " + CreateProject.ComboBox1.SelectedItem + " " + ProjectPath)
            Process.StandardInput.WriteLine("exit")
            Debug.WriteLine("Command: " + StartInfo.Arguments)
            Debug.WriteLine(Process.StandardOutput.ReadToEnd)
            Process.WaitForExit()
            Process.Close()
            MessageBox.Show("Image exportée !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
