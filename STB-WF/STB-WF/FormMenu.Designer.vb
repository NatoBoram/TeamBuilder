<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
	Inherits System.Windows.Forms.Form

	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

	'Requise par le Concepteur Windows Form
	Private components As System.ComponentModel.IContainer

	'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
	'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
	'Ne la modifiez pas à l'aide de l'éditeur de code.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
		Me.ListBoxLobby = New System.Windows.Forms.ListBox()
		Me.LabelLobby = New System.Windows.Forms.Label()
		Me.ButtonAddPlayer = New System.Windows.Forms.Button()
		Me.LabelPlayers = New System.Windows.Forms.Label()
		Me.ButtonRemovePlayer = New System.Windows.Forms.Button()
		Me.ButtonAddLobby = New System.Windows.Forms.Button()
		Me.ButtonRemoveLobby = New System.Windows.Forms.Button()
		Me.ButtonStart = New System.Windows.Forms.Button()
		Me.ListBoxPlayers = New System.Windows.Forms.ListBox()
		Me.TextBoxName = New System.Windows.Forms.TextBox()
		Me.LabelName = New System.Windows.Forms.Label()
		Me.LabelRank = New System.Windows.Forms.Label()
		Me.ComboBoxRank = New System.Windows.Forms.ComboBox()
		Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanelAddPlayer = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanelMain.SuspendLayout()
		Me.TableLayoutPanelAddPlayer.SuspendLayout()
		Me.SuspendLayout()
		'
		'ListBoxLobby
		'
		Me.TableLayoutPanelMain.SetColumnSpan(Me.ListBoxLobby, 2)
		Me.ListBoxLobby.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListBoxLobby.FormattingEnabled = True
		Me.ListBoxLobby.Location = New System.Drawing.Point(245, 16)
		Me.ListBoxLobby.Name = "ListBoxLobby"
		Me.TableLayoutPanelMain.SetRowSpan(Me.ListBoxLobby, 2)
		Me.ListBoxLobby.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
		Me.ListBoxLobby.Size = New System.Drawing.Size(236, 184)
		Me.ListBoxLobby.Sorted = True
		Me.ListBoxLobby.TabIndex = 7
		'
		'LabelLobby
		'
		Me.LabelLobby.AutoSize = True
		Me.TableLayoutPanelMain.SetColumnSpan(Me.LabelLobby, 2)
		Me.LabelLobby.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelLobby.Location = New System.Drawing.Point(245, 0)
		Me.LabelLobby.Name = "LabelLobby"
		Me.LabelLobby.Size = New System.Drawing.Size(236, 13)
		Me.LabelLobby.TabIndex = 0
		Me.LabelLobby.Text = "List of players to sort"
		'
		'ButtonAddPlayer
		'
		Me.ButtonAddPlayer.AutoSize = True
		Me.ButtonAddPlayer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ButtonAddPlayer.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ButtonAddPlayer.Location = New System.Drawing.Point(3, 206)
		Me.ButtonAddPlayer.Name = "ButtonAddPlayer"
		Me.ButtonAddPlayer.Size = New System.Drawing.Size(115, 23)
		Me.ButtonAddPlayer.TabIndex = 4
		Me.ButtonAddPlayer.Text = "Create Player"
		Me.ButtonAddPlayer.UseVisualStyleBackColor = True
		'
		'LabelPlayers
		'
		Me.LabelPlayers.AutoSize = True
		Me.TableLayoutPanelMain.SetColumnSpan(Me.LabelPlayers, 2)
		Me.LabelPlayers.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelPlayers.Location = New System.Drawing.Point(3, 0)
		Me.LabelPlayers.Name = "LabelPlayers"
		Me.LabelPlayers.Size = New System.Drawing.Size(236, 13)
		Me.LabelPlayers.TabIndex = 0
		Me.LabelPlayers.Text = "List of known players"
		'
		'ButtonRemovePlayer
		'
		Me.ButtonRemovePlayer.AutoSize = True
		Me.ButtonRemovePlayer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ButtonRemovePlayer.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ButtonRemovePlayer.Location = New System.Drawing.Point(124, 206)
		Me.ButtonRemovePlayer.Name = "ButtonRemovePlayer"
		Me.ButtonRemovePlayer.Size = New System.Drawing.Size(115, 23)
		Me.ButtonRemovePlayer.TabIndex = 5
		Me.ButtonRemovePlayer.Text = "Delete Player"
		Me.ButtonRemovePlayer.UseVisualStyleBackColor = True
		'
		'ButtonAddLobby
		'
		Me.ButtonAddLobby.AutoSize = True
		Me.ButtonAddLobby.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ButtonAddLobby.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ButtonAddLobby.Location = New System.Drawing.Point(245, 206)
		Me.ButtonAddLobby.Name = "ButtonAddLobby"
		Me.ButtonAddLobby.Size = New System.Drawing.Size(115, 23)
		Me.ButtonAddLobby.TabIndex = 6
		Me.ButtonAddLobby.Text = "Add to Lobby"
		Me.ButtonAddLobby.UseVisualStyleBackColor = True
		'
		'ButtonRemoveLobby
		'
		Me.ButtonRemoveLobby.AutoSize = True
		Me.ButtonRemoveLobby.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ButtonRemoveLobby.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ButtonRemoveLobby.Location = New System.Drawing.Point(366, 206)
		Me.ButtonRemoveLobby.Name = "ButtonRemoveLobby"
		Me.ButtonRemoveLobby.Size = New System.Drawing.Size(115, 23)
		Me.ButtonRemoveLobby.TabIndex = 8
		Me.ButtonRemoveLobby.Text = "Remove from Lobby"
		Me.ButtonRemoveLobby.UseVisualStyleBackColor = True
		'
		'ButtonStart
		'
		Me.ButtonStart.AutoSize = True
		Me.ButtonStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanelMain.SetColumnSpan(Me.ButtonStart, 2)
		Me.ButtonStart.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ButtonStart.Location = New System.Drawing.Point(124, 235)
		Me.ButtonStart.Name = "ButtonStart"
		Me.ButtonStart.Size = New System.Drawing.Size(236, 23)
		Me.ButtonStart.TabIndex = 9
		Me.ButtonStart.Text = "Start Game"
		Me.ButtonStart.UseVisualStyleBackColor = True
		'
		'ListBoxPlayers
		'
		Me.TableLayoutPanelMain.SetColumnSpan(Me.ListBoxPlayers, 2)
		Me.ListBoxPlayers.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListBoxPlayers.FormattingEnabled = True
		Me.ListBoxPlayers.Location = New System.Drawing.Point(3, 16)
		Me.ListBoxPlayers.Name = "ListBoxPlayers"
		Me.ListBoxPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
		Me.ListBoxPlayers.Size = New System.Drawing.Size(236, 125)
		Me.ListBoxPlayers.Sorted = True
		Me.ListBoxPlayers.TabIndex = 1
		'
		'TextBoxName
		'
		Me.TextBoxName.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TextBoxName.Location = New System.Drawing.Point(44, 3)
		Me.TextBoxName.Name = "TextBoxName"
		Me.TextBoxName.Size = New System.Drawing.Size(189, 20)
		Me.TextBoxName.TabIndex = 2
		'
		'LabelName
		'
		Me.LabelName.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelName.Location = New System.Drawing.Point(3, 0)
		Me.LabelName.Name = "LabelName"
		Me.LabelName.Size = New System.Drawing.Size(35, 26)
		Me.LabelName.TabIndex = 0
		Me.LabelName.Text = "Name"
		'
		'LabelRank
		'
		Me.LabelRank.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LabelRank.Location = New System.Drawing.Point(3, 26)
		Me.LabelRank.Name = "LabelRank"
		Me.LabelRank.Size = New System.Drawing.Size(35, 27)
		Me.LabelRank.TabIndex = 0
		Me.LabelRank.Text = "Rank"
		'
		'ComboBoxRank
		'
		Me.ComboBoxRank.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ComboBoxRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBoxRank.FormattingEnabled = True
		Me.ComboBoxRank.Location = New System.Drawing.Point(44, 29)
		Me.ComboBoxRank.Name = "ComboBoxRank"
		Me.ComboBoxRank.Size = New System.Drawing.Size(189, 21)
		Me.ComboBoxRank.TabIndex = 3
		'
		'TableLayoutPanelMain
		'
		Me.TableLayoutPanelMain.AutoSize = True
		Me.TableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanelMain.ColumnCount = 4
		Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanelAddPlayer, 0, 2)
		Me.TableLayoutPanelMain.Controls.Add(Me.ListBoxPlayers, 0, 1)
		Me.TableLayoutPanelMain.Controls.Add(Me.ButtonRemoveLobby, 3, 3)
		Me.TableLayoutPanelMain.Controls.Add(Me.ButtonAddLobby, 2, 3)
		Me.TableLayoutPanelMain.Controls.Add(Me.ButtonRemovePlayer, 1, 3)
		Me.TableLayoutPanelMain.Controls.Add(Me.LabelPlayers, 0, 0)
		Me.TableLayoutPanelMain.Controls.Add(Me.ButtonAddPlayer, 0, 3)
		Me.TableLayoutPanelMain.Controls.Add(Me.LabelLobby, 2, 0)
		Me.TableLayoutPanelMain.Controls.Add(Me.ListBoxLobby, 2, 1)
		Me.TableLayoutPanelMain.Controls.Add(Me.ButtonStart, 1, 4)
		Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
		Me.TableLayoutPanelMain.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TableLayoutPanelMain.RowCount = 5
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.Size = New System.Drawing.Size(484, 261)
		Me.TableLayoutPanelMain.TabIndex = 0
		'
		'TableLayoutPanelAddPlayer
		'
		Me.TableLayoutPanelAddPlayer.AutoSize = True
		Me.TableLayoutPanelAddPlayer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanelAddPlayer.ColumnCount = 2
		Me.TableLayoutPanelMain.SetColumnSpan(Me.TableLayoutPanelAddPlayer, 2)
		Me.TableLayoutPanelAddPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanelAddPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanelAddPlayer.Controls.Add(Me.TextBoxName, 1, 0)
		Me.TableLayoutPanelAddPlayer.Controls.Add(Me.LabelName, 0, 0)
		Me.TableLayoutPanelAddPlayer.Controls.Add(Me.LabelRank, 0, 1)
		Me.TableLayoutPanelAddPlayer.Controls.Add(Me.ComboBoxRank, 1, 1)
		Me.TableLayoutPanelAddPlayer.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanelAddPlayer.Location = New System.Drawing.Point(3, 147)
		Me.TableLayoutPanelAddPlayer.Name = "TableLayoutPanelAddPlayer"
		Me.TableLayoutPanelAddPlayer.RowCount = 2
		Me.TableLayoutPanelAddPlayer.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelAddPlayer.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelAddPlayer.Size = New System.Drawing.Size(236, 53)
		Me.TableLayoutPanelAddPlayer.TabIndex = 11
		'
		'FormMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(484, 261)
		Me.Controls.Add(Me.TableLayoutPanelMain)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimumSize = New System.Drawing.Size(500, 300)
		Me.Name = "FormMenu"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Smart Team Builder"
		Me.TableLayoutPanelMain.ResumeLayout(False)
		Me.TableLayoutPanelMain.PerformLayout()
		Me.TableLayoutPanelAddPlayer.ResumeLayout(False)
		Me.TableLayoutPanelAddPlayer.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ListBoxLobby As ListBox
	Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
	Friend WithEvents TableLayoutPanelAddPlayer As TableLayoutPanel
	Friend WithEvents TextBoxName As TextBox
	Friend WithEvents LabelName As Label
	Friend WithEvents LabelRank As Label
	Friend WithEvents ComboBoxRank As ComboBox
	Friend WithEvents ListBoxPlayers As ListBox
	Friend WithEvents ButtonStart As Button
	Friend WithEvents ButtonRemoveLobby As Button
	Friend WithEvents ButtonAddLobby As Button
	Friend WithEvents ButtonRemovePlayer As Button
	Friend WithEvents LabelPlayers As Label
	Friend WithEvents ButtonAddPlayer As Button
	Friend WithEvents LabelLobby As Label
End Class
