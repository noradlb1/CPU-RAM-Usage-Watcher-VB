Namespace utrack
	Partial Public Class utrack
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(utrack))
			Me.show_cpu_usage = New System.Windows.Forms.Label()
			Me.show_ram_usage = New System.Windows.Forms.Label()
			Me.SystemTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
			Me.pictureBox = New System.Windows.Forms.PictureBox()
			Me.label_cpu = New System.Windows.Forms.Label()
			Me.label_ram = New System.Windows.Forms.Label()
			Me.label_delay = New System.Windows.Forms.Label()
			Me.trackBar = New System.Windows.Forms.TrackBar()
			DirectCast(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.trackBar, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' show_cpu_usage
			' 
			Me.show_cpu_usage.AutoSize = True
			Me.show_cpu_usage.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(238)))
			Me.show_cpu_usage.ForeColor = System.Drawing.Color.Cyan
			Me.show_cpu_usage.Location = New System.Drawing.Point(121, 27)
			Me.show_cpu_usage.Name = "show_cpu_usage"
			Me.show_cpu_usage.Size = New System.Drawing.Size(28, 15)
			Me.show_cpu_usage.TabIndex = 0
			Me.show_cpu_usage.Text = "..."
			' 
			' show_ram_usage
			' 
			Me.show_ram_usage.AutoSize = True
			Me.show_ram_usage.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(238)))
			Me.show_ram_usage.ForeColor = System.Drawing.Color.Lime
			Me.show_ram_usage.Location = New System.Drawing.Point(121, 42)
			Me.show_ram_usage.Name = "show_ram_usage"
			Me.show_ram_usage.Size = New System.Drawing.Size(28, 15)
			Me.show_ram_usage.TabIndex = 1
			Me.show_ram_usage.Text = "..."
			' 
			' SystemTrayIcon
			' 
			Me.SystemTrayIcon.Text = "..."
			Me.SystemTrayIcon.Visible = True
'			Me.SystemTrayIcon.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.SystemTrayIcon_MouseClick)
			' 
			' pictureBox
			' 
			Me.pictureBox.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(10)))), (CInt((CByte(10)))), (CInt((CByte(10)))))
			Me.pictureBox.Location = New System.Drawing.Point(15, 27)
			Me.pictureBox.Name = "pictureBox"
			Me.pictureBox.Size = New System.Drawing.Size(100, 100)
			Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
			Me.pictureBox.TabIndex = 6
			Me.pictureBox.TabStop = False
			' 
			' label_cpu
			' 
			Me.label_cpu.AutoSize = True
			Me.label_cpu.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(238)))
			Me.label_cpu.ForeColor = System.Drawing.Color.Cyan
			Me.label_cpu.Location = New System.Drawing.Point(12, 9)
			Me.label_cpu.Name = "label_cpu"
			Me.label_cpu.Size = New System.Drawing.Size(28, 15)
			Me.label_cpu.TabIndex = 7
			Me.label_cpu.Text = "CPU"
			' 
			' label_ram
			' 
			Me.label_ram.AutoSize = True
			Me.label_ram.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(238)))
			Me.label_ram.ForeColor = System.Drawing.Color.Lime
			Me.label_ram.Location = New System.Drawing.Point(87, 9)
			Me.label_ram.Name = "label_ram"
			Me.label_ram.Size = New System.Drawing.Size(28, 15)
			Me.label_ram.TabIndex = 8
			Me.label_ram.Text = "RAM"
			' 
			' label_delay
			' 
			Me.label_delay.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.label_delay.AutoSize = True
			Me.label_delay.Location = New System.Drawing.Point(12, 189)
			Me.label_delay.Name = "label_delay"
			Me.label_delay.Size = New System.Drawing.Size(85, 13)
			Me.label_delay.TabIndex = 10
			Me.label_delay.Text = "Delay: ... ms"
			' 
			' trackBar
			' 
			Me.trackBar.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.trackBar.LargeChange = 100
			Me.trackBar.Location = New System.Drawing.Point(15, 141)
			Me.trackBar.Maximum = 3000
			Me.trackBar.Minimum = 50
			Me.trackBar.Name = "trackBar"
			Me.trackBar.Size = New System.Drawing.Size(457, 45)
			Me.trackBar.TabIndex = 14
			Me.trackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
			Me.trackBar.Value = 200
'			Me.trackBar.ValueChanged += New System.EventHandler(Me.trackBar_ValueChanged)
			' 
			' utrack
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(15)))), (CInt((CByte(15)))), (CInt((CByte(15)))))
			Me.ClientSize = New System.Drawing.Size(484, 211)
			Me.Controls.Add(Me.trackBar)
			Me.Controls.Add(Me.label_delay)
			Me.Controls.Add(Me.label_ram)
			Me.Controls.Add(Me.label_cpu)
			Me.Controls.Add(Me.pictureBox)
			Me.Controls.Add(Me.show_ram_usage)
			Me.Controls.Add(Me.show_cpu_usage)
			Me.Font = New System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(238)))
			Me.ForeColor = System.Drawing.Color.DimGray
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MinimumSize = New System.Drawing.Size(500, 250)
			Me.Name = "utrack"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "CPU & RAM Watcher"
'			Me.Load += New System.EventHandler(Me.utrack_Load)
			DirectCast(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.trackBar, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private show_cpu_usage As System.Windows.Forms.Label
		Private show_ram_usage As System.Windows.Forms.Label
		Private WithEvents SystemTrayIcon As System.Windows.Forms.NotifyIcon
		Private pictureBox As System.Windows.Forms.PictureBox
		Private label_cpu As System.Windows.Forms.Label
		Private label_ram As System.Windows.Forms.Label
		Private label_delay As System.Windows.Forms.Label
		Private WithEvents trackBar As System.Windows.Forms.TrackBar
	End Class
End Namespace

