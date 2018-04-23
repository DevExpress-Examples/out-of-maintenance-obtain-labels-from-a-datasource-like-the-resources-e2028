Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports System.Data.OleDb

Namespace DS12188
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'carsDBLabelDataSet11.Labels' table. You can move, or remove it, as needed.
			Me.labelsTableAdapter1.Fill(Me.carsDBLabelDataSet11.Labels)
			' TODO: This line of code loads data into the 'carsDBLabelDataSet.Cars' table. You can move, or remove it, as needed.
			Me.carsTableAdapter.Fill(Me.carsDBLabelDataSet.Cars)
			' TODO: This line of code loads data into the 'carsDBLabelDataSet.CarScheduling' table. You can move, or remove it, as needed.
			Me.carSchedulingTableAdapter.Fill(Me.carsDBLabelDataSet.CarScheduling)

			AddHandler carSchedulingTableAdapter.Adapter.RowUpdated, AddressOf carSchedulingTableAdapter_RowUpdated

			InitializeLabels()
		End Sub

		Private Sub InitializeLabels()
			Me.labelsTableAdapter1.Fill(Me.carsDBLabelDataSet11.Labels)

			Dim labels As DataTable = Me.carsDBLabelDataSet11.Labels

			If labels.Rows.Count = 0 Then
				Return
			End If
			schedulerControl1.Storage.Appointments.Labels.Clear()

			schedulerControl1.Storage.Appointments.Labels.BeginUpdate()
			For i As Integer = 0 To labels.Rows.Count - 1
				Dim color As Color = Color.FromArgb(Int32.Parse(labels.Rows(i).ItemArray(1).ToString()))
				Dim dislayName As String = labels.Rows(i).ItemArray(2).ToString()
				Dim menuCaption As String = labels.Rows(i).ItemArray(3).ToString()
				Dim aptLabel As New AppointmentLabel(color, dislayName, menuCaption)
				schedulerControl1.Storage.Appointments.Labels.Add(aptLabel)
			Next i
			schedulerControl1.Storage.Appointments.Labels.EndUpdate()
		End Sub

		Private Sub gridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gridView1.RowUpdated
			labelsTableAdapter1.Update(carsDBLabelDataSet11)
			carsDBLabelDataSet11.AcceptChanges()
			InitializeLabels()
			schedulerControl1.Refresh()
		End Sub

		Private Sub OnApptChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsChanged, schedulerStorage1.AppointmentsInserted, schedulerStorage1.AppointmentsDeleted
			carSchedulingTableAdapter.Update(carsDBLabelDataSet)
			carsDBLabelDataSet.AcceptChanges()
		End Sub

		Private Sub carSchedulingTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
			If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
				Dim id As Integer = 0
				Using cmd As New OleDbCommand("SELECT @@IDENTITY", carSchedulingTableAdapter.Connection)
					id = CInt(Fix(cmd.ExecuteScalar()))
				End Using
				e.Row("ID") = id
			End If
		End Sub

	End Class
End Namespace