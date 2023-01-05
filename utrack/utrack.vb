Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Threading
Imports System.Management
Imports System.Runtime.InteropServices

Namespace utrack
	Partial Public Class utrack
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub utrack_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			startMonitorThread()
			updateValue()
		End Sub

		Private Sub startMonitorThread()
			CType(New Thread(AddressOf Monitor) With {.IsBackground = True}, Thread).Start()
		End Sub

		Private Shared quit As Boolean = False
		Private Sub Monitor()
			Try

				Dim cpuCounter As New PerformanceCounter("Processor", "% Processor Time", "_Total")

				Do While Not quit
					Dim cpu As Double = Math.Round(cpuCounter.NextValue(), 2)
					Dim ram As Double = 0

					Dim objectQuery As New ObjectQuery("SELECT * FROM Win32_OperatingSystem")
					Dim managementObjectSearcher As New ManagementObjectSearcher(objectQuery)
					Dim managementObjectCollection As ManagementObjectCollection = managementObjectSearcher.Get()
					For Each managementObject As ManagementObject In managementObjectCollection
						Dim tot As Double = Double.Parse(managementObject("TotalVisibleMemorySize").ToString()) * 1024
						Dim free As Double = Double.Parse(managementObject("FreePhysicalMemory").ToString()) * 1024
						Dim virttot As Double = Double.Parse(managementObject("TotalVirtualMemorySize").ToString()) * 1024
						Dim virtfree As Double = Double.Parse(managementObject("FreeVirtualMemory").ToString()) * 1024

						ram = Math.Round(100 - free / tot * 100, 2)

						show_ram_usage.Text = "RAM USAGE: " & ram & "%" & Environment.NewLine & "|- Total Visible Memory.: " & ROund(tot) & " (" & tot & "B)" & Environment.NewLine & "|- Free Physical Memory.: " & ROund(free) & " (" & free & " B)" & Environment.NewLine & "|- Total Virtual Memory.: " & ROund(virttot) & " (" & virttot & " B)" & Environment.NewLine & "+- Free Virtual Memory..: " & ROund(virtfree) & " (" & virtfree & " B)"
					Next managementObject

					'print
					show_cpu_usage.Text = "CPU USAGE: " & cpu & "%"
					'show_ram_usage.Text = "RAM: " + Math.Round(ram, 2) + "MB";
					SystemTrayIcon.Text = "CPU: " & cpu.ToString() & "%" & Environment.NewLine & "RAM: " & ram.ToString() & "%"

					Dim bmp As Bitmap = draw_image(cpu, ram)

					'convert and show on icon
					SystemTrayIcon.Icon = Icon.FromHandle(bmp.GetHicon())

					pictureBox.Image = bmp

					Thread.Sleep(trackBar.Value)
				Loop
			Catch e As Exception
				Console.Error.WriteLine(e.Message)
				startMonitorThread()
			End Try
		End Sub

		Private Function draw_image(ByVal cpu_usage As Double, ByVal ram_usage As Double) As Bitmap
			Dim image As New Bitmap(100, 100)

			Using g As Graphics = Graphics.FromImage(image)
				g.Clear(Color.FromArgb(10, 10, 10))
				g.FillRectangle(Brushes.Cyan, New Rectangle(0, 0, image.Width \ 2 - 5, CInt(Math.Truncate(cpu_usage))))
				g.FillRectangle(Brushes.Lime, New Rectangle(image.Width \ 2 + 5, 0, image.Width \ 2 + 5, CInt(Math.Truncate(ram_usage))))

				Dim rect As New Rectangle(0, 0, 100, 100)
				Dim penWidth As Integer = 5
				Using pen As New Pen(Color.Red, penWidth)
					Dim shrinkAmount As Single = pen.Width \ 2
					g.DrawRectangle(pen, rect.X + shrinkAmount, rect.Y + shrinkAmount, rect.Width - penWidth, rect.Height - penWidth) ' shrink height with one pen-width -  shrink width with one pen-width -  move half a pen-width to the down -  move half a pen-width to the right
				End Using
			End Using
			'flip vert
			image.RotateFlip(RotateFlipType.Rotate180FlipX)
			Return image
		End Function

		Private Sub SystemTrayIcon_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles SystemTrayIcon.MouseClick
			Select Case e.Button
				Case MouseButtons.Left
					Me.Visible = Not Me.Visible
				Case MouseButtons.Right
					Environment.Exit(0)
			End Select
		End Sub

		Private Sub trackBar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar.ValueChanged
			updateValue()
		End Sub

		Private Sub updateValue()
			label_delay.Text = "Delay: " & trackBar.Value & " ms"
		End Sub

		Public Shared Function ROund(ByVal len As Double) As String
			Dim sizes() As String = { "B", "KB", "MB", "GB", "TB" }
			Dim order As Integer = 0
			Do While len >= 1024 AndAlso order < sizes.Length - 1
				order += 1
				len = len / 1024
			Loop
			Return String.Format("{0:0.##} {1}", len, sizes(order))
		End Function
	End Class
End Namespace
