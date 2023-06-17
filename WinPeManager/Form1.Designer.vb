<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ProjectPathText = New System.Windows.Forms.TextBox()
        Me.ProjectPathHint = New System.Windows.Forms.Label()
        Me.Browse = New System.Windows.Forms.Button()
        Me.CreateProject = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MountImage = New System.Windows.Forms.Button()
        Me.CommitImage = New System.Windows.Forms.Button()
        Me.UnmountImage = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Export = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'ProjectPathText
        '
        Me.ProjectPathText.Location = New System.Drawing.Point(62, 66)
        Me.ProjectPathText.Name = "ProjectPathText"
        Me.ProjectPathText.Size = New System.Drawing.Size(598, 20)
        Me.ProjectPathText.TabIndex = 0
        '
        'ProjectPathHint
        '
        Me.ProjectPathHint.AutoSize = True
        Me.ProjectPathHint.Location = New System.Drawing.Point(59, 50)
        Me.ProjectPathHint.Name = "ProjectPathHint"
        Me.ProjectPathHint.Size = New System.Drawing.Size(92, 13)
        Me.ProjectPathHint.TabIndex = 1
        Me.ProjectPathHint.Text = "Dossier du projet :"
        '
        'Browse
        '
        Me.Browse.Location = New System.Drawing.Point(584, 93)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(75, 23)
        Me.Browse.TabIndex = 2
        Me.Browse.Text = "Parcourir..."
        Me.Browse.UseVisualStyleBackColor = True
        '
        'CreateProject
        '
        Me.CreateProject.Enabled = False
        Me.CreateProject.Location = New System.Drawing.Point(503, 93)
        Me.CreateProject.Name = "CreateProject"
        Me.CreateProject.Size = New System.Drawing.Size(75, 23)
        Me.CreateProject.TabIndex = 3
        Me.CreateProject.Text = "Créer"
        Me.CreateProject.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Sélectionnez le dossier dans lequel se trouvze "
        '
        'MountImage
        '
        Me.MountImage.Enabled = False
        Me.MountImage.Location = New System.Drawing.Point(62, 168)
        Me.MountImage.Name = "MountImage"
        Me.MountImage.Size = New System.Drawing.Size(89, 66)
        Me.MountImage.TabIndex = 4
        Me.MountImage.Text = "Monter"
        Me.MountImage.UseVisualStyleBackColor = True
        '
        'CommitImage
        '
        Me.CommitImage.Enabled = False
        Me.CommitImage.Location = New System.Drawing.Point(62, 241)
        Me.CommitImage.Name = "CommitImage"
        Me.CommitImage.Size = New System.Drawing.Size(89, 66)
        Me.CommitImage.TabIndex = 5
        Me.CommitImage.Text = "Sauvegarder"
        Me.CommitImage.UseVisualStyleBackColor = True
        '
        'UnmountImage
        '
        Me.UnmountImage.Enabled = False
        Me.UnmountImage.Location = New System.Drawing.Point(62, 313)
        Me.UnmountImage.Name = "UnmountImage"
        Me.UnmountImage.Size = New System.Drawing.Size(89, 66)
        Me.UnmountImage.TabIndex = 5
        Me.UnmountImage.Text = "Démonter"
        Me.UnmountImage.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(162, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 66)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Monter l'image WIM dans le dossier du projet"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(162, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 66)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sauvegarder les modifications apportées à l'image WIM"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(162, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 66)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Démonter l'image WIM du dossier du projet"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Export
        '
        Me.Export.Enabled = False
        Me.Export.Location = New System.Drawing.Point(370, 241)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(89, 66)
        Me.Export.TabIndex = 5
        Me.Export.Text = "Exporter"
        Me.Export.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(465, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 66)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Exporter l'image WIM en image ISO gravable"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Images ISO (*.iso)|*.iso"
        Me.SaveFileDialog1.Title = "Exporter"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 454)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UnmountImage)
        Me.Controls.Add(Me.Export)
        Me.Controls.Add(Me.CommitImage)
        Me.Controls.Add(Me.MountImage)
        Me.Controls.Add(Me.CreateProject)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.ProjectPathHint)
        Me.Controls.Add(Me.ProjectPathText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WinPEManager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProjectPathText As TextBox
    Friend WithEvents ProjectPathHint As Label
    Friend WithEvents Browse As Button
    Friend WithEvents CreateProject As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents MountImage As Button
    Friend WithEvents CommitImage As Button
    Friend WithEvents UnmountImage As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Export As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
