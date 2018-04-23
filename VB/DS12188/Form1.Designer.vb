Imports Microsoft.VisualBasic
Imports System
Namespace DS12188
	Partial Public Class Form1
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
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.carSchedulingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carsDBLabelDataSet = New DS12188.CarsDBLabelDataSet()
			Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carSchedulingTableAdapter = New DS12188.CarsDBLabelDataSetTableAdapters.CarSchedulingTableAdapter()
			Me.carsTableAdapter = New DS12188.CarsDBLabelDataSetTableAdapters.CarsTableAdapter()
			Me.carsDBLabelDataSet11 = New DS12188.CarsDBLabelDataSet1()
			Me.labelsTableAdapter1 = New DS12188.CarsDBLabelDataSet1TableAdapters.LabelsTableAdapter()
			Me.labelsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
			Me.colDisplayName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colMenuCaption = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBLabelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBLabelDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(468, 446)
			Me.schedulerControl1.Start = New System.DateTime(2010, 2, 8, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			' 
			' schedulerStorage1
			' 
			Me.schedulerStorage1.Appointments.DataSource = Me.carSchedulingBindingSource
			Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
			Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
			Me.schedulerStorage1.Appointments.Mappings.End = "EndTime"
			Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
			Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
			Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
			Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
			Me.schedulerStorage1.Appointments.Mappings.ResourceId = "CarId"
			Me.schedulerStorage1.Appointments.Mappings.Start = "StartTime"
			Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
			Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
			Me.schedulerStorage1.Appointments.Mappings.Type = "EventType"
			Me.schedulerStorage1.Resources.DataSource = Me.carsBindingSource
			Me.schedulerStorage1.Resources.Mappings.Caption = "Model"
			Me.schedulerStorage1.Resources.Mappings.Id = "ID"
'			Me.schedulerStorage1.AppointmentsChanged += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnApptChangedInsertedDeleted);
'			Me.schedulerStorage1.AppointmentsInserted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnApptChangedInsertedDeleted);
'			Me.schedulerStorage1.AppointmentsDeleted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnApptChangedInsertedDeleted);
			' 
			' carSchedulingBindingSource
			' 
			Me.carSchedulingBindingSource.DataMember = "CarScheduling"
			Me.carSchedulingBindingSource.DataSource = Me.carsDBLabelDataSet
			' 
			' carsDBLabelDataSet
			' 
			Me.carsDBLabelDataSet.DataSetName = "CarsDBLabelDataSet"
			Me.carsDBLabelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.carsDBLabelDataSet
			' 
			' carSchedulingTableAdapter
			' 
			Me.carSchedulingTableAdapter.ClearBeforeFill = True
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' carsDBLabelDataSet11
			' 
			Me.carsDBLabelDataSet11.DataSetName = "CarsDBLabelDataSet1"
			Me.carsDBLabelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' labelsTableAdapter1
			' 
			Me.labelsTableAdapter1.ClearBeforeFill = True
			' 
			' labelsBindingSource
			' 
			Me.labelsBindingSource.DataMember = "Labels"
			Me.labelsBindingSource.DataSource = Me.carsDBLabelDataSet11
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.labelsBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.gridControl1.Location = New System.Drawing.Point(468, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemColorEdit1, Me.repositoryItemTextEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(401, 446)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colId, Me.colColor, Me.colDisplayName, Me.colMenuCaption})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupPanelText = " "
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ShowViewCaption = True
			Me.gridView1.ViewCaption = "Label Details"
'			Me.gridView1.RowUpdated += New DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(Me.gridView1_RowUpdated);
			' 
			' colId
			' 
			Me.colId.ColumnEdit = Me.repositoryItemTextEdit1
			Me.colId.FieldName = "Id"
			Me.colId.Name = "colId"
			Me.colId.Visible = True
			Me.colId.VisibleIndex = 0
			Me.colId.Width = 41
			' 
			' colColor
			' 
			Me.colColor.ColumnEdit = Me.repositoryItemColorEdit1
			Me.colColor.FieldName = "Color"
			Me.colColor.Name = "colColor"
			Me.colColor.Visible = True
			Me.colColor.VisibleIndex = 1
			Me.colColor.Width = 131
			' 
			' repositoryItemColorEdit1
			' 
			Me.repositoryItemColorEdit1.AutoHeight = False
			Me.repositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1"
			Me.repositoryItemColorEdit1.StoreColorAsInteger = True
			' 
			' colDisplayName
			' 
			Me.colDisplayName.FieldName = "DisplayName"
			Me.colDisplayName.Name = "colDisplayName"
			Me.colDisplayName.Visible = True
			Me.colDisplayName.VisibleIndex = 2
			Me.colDisplayName.Width = 101
			' 
			' colMenuCaption
			' 
			Me.colMenuCaption.FieldName = "MenuCaption"
			Me.colMenuCaption.Name = "colMenuCaption"
			Me.colMenuCaption.Visible = True
			Me.colMenuCaption.VisibleIndex = 3
			Me.colMenuCaption.Width = 107
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			Me.repositoryItemTextEdit1.ReadOnly = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(869, 446)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBLabelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBLabelDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private WithEvents schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private carsDBLabelDataSet As CarsDBLabelDataSet
		Private carSchedulingBindingSource As System.Windows.Forms.BindingSource
		Private carSchedulingTableAdapter As DS12188.CarsDBLabelDataSetTableAdapters.CarSchedulingTableAdapter
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As DS12188.CarsDBLabelDataSetTableAdapters.CarsTableAdapter
		Private carsDBLabelDataSet11 As CarsDBLabelDataSet1
		Private labelsTableAdapter1 As DS12188.CarsDBLabelDataSet1TableAdapters.LabelsTableAdapter
		Private labelsBindingSource As System.Windows.Forms.BindingSource
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colId As DevExpress.XtraGrid.Columns.GridColumn
		Private colColor As DevExpress.XtraGrid.Columns.GridColumn
		Private colDisplayName As DevExpress.XtraGrid.Columns.GridColumn
		Private colMenuCaption As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
	End Class
End Namespace

