<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLobby
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLobby))
		Me.ListBoxTeam1 = New System.Windows.Forms.ListBox()
		Me.ListBoxTeam2 = New System.Windows.Forms.ListBox()
		Me.ButtonTeam1 = New System.Windows.Forms.Button()
		Me.ButtonTeam2 = New System.Windows.Forms.Button()
		Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanelMain.SuspendLayout()
		Me.SuspendLayout()
		'
		'ListBoxTeam1
		'
		Me.ListBoxTeam1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListBoxTeam1.FormattingEnabled = True
		Me.ListBoxTeam1.Location = New System.Drawing.Point(3, 3)
		Me.ListBoxTeam1.Name = "ListBoxTeam1"
		Me.ListBoxTeam1.Size = New System.Drawing.Size(136, 126)
		Me.ListBoxTeam1.Sorted = True
		Me.ListBoxTeam1.TabIndex = 0
		'
		'ListBoxTeam2
		'
		Me.ListBoxTeam2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListBoxTeam2.FormattingEnabled = True
		Me.ListBoxTeam2.Location = New System.Drawing.Point(145, 3)
		Me.ListBoxTeam2.Name = "ListBoxTeam2"
		Me.ListBoxTeam2.Size = New System.Drawing.Size(136, 126)
		Me.ListBoxTeam2.Sorted = True
		Me.ListBoxTeam2.TabIndex = 0
		'
		'ButtonTeam1
		'
		Me.ButtonTeam1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ButtonTeam1.Location = New System.Drawing.Point(3, 135)
		Me.ButtonTeam1.Name = "ButtonTeam1"
		Me.ButtonTeam1.Size = New System.Drawing.Size(136, 23)
		Me.ButtonTeam1.TabIndex = 1
		Me.ButtonTeam1.Text = "Team 1"
		Me.ButtonTeam1.UseVisualStyleBackColor = True
		'
		'ButtonTeam2
		'
		Me.ButtonTeam2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ButtonTeam2.Location = New System.Drawing.Point(145, 135)
		Me.ButtonTeam2.Name = "ButtonTeam2"
		Me.ButtonTeam2.Size = New System.Drawing.Size(136, 23)
		Me.ButtonTeam2.TabIndex = 2
		Me.ButtonTeam2.Text = "Team 2"
		Me.ButtonTeam2.UseVisualStyleBackColor = True
		'
		'TableLayoutPanelMain
		'
		Me.TableLayoutPanelMain.ColumnCount = 2
		Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanelMain.Controls.Add(Me.ListBoxTeam1, 0, 0)
		Me.TableLayoutPanelMain.Controls.Add(Me.ButtonTeam2, 1, 1)
		Me.TableLayoutPanelMain.Controls.Add(Me.ListBoxTeam2, 1, 0)
		Me.TableLayoutPanelMain.Controls.Add(Me.ButtonTeam1, 0, 1)
		Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
		Me.TableLayoutPanelMain.RowCount = 2
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.Size = New System.Drawing.Size(284, 161)
		Me.TableLayoutPanelMain.TabIndex = 0
		'
		'FormLobby
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 161)
		Me.Controls.Add(Me.TableLayoutPanelMain)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimumSize = New System.Drawing.Size(300, 200)
		Me.Name = "FormLobby"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Lobby"
		Me.TableLayoutPanelMain.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents ListBoxTeam1 As ListBox
	Friend WithEvents ListBoxTeam2 As ListBox
	Friend WithEvents ButtonTeam1 As Button
	Friend WithEvents ButtonTeam2 As Button
	Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
End Class
