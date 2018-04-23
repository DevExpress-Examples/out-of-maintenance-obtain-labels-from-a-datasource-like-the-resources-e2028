using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using System.Data.OleDb;

namespace DS12188
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carsDBLabelDataSet11.Labels' table. You can move, or remove it, as needed.
            this.labelsTableAdapter1.Fill(this.carsDBLabelDataSet11.Labels);
            // TODO: This line of code loads data into the 'carsDBLabelDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carsDBLabelDataSet.Cars);
            // TODO: This line of code loads data into the 'carsDBLabelDataSet.CarScheduling' table. You can move, or remove it, as needed.
            this.carSchedulingTableAdapter.Fill(this.carsDBLabelDataSet.CarScheduling);

            carSchedulingTableAdapter.Adapter.RowUpdated += new OleDbRowUpdatedEventHandler (carSchedulingTableAdapter_RowUpdated);

            InitializeLabels();
        }

        private void InitializeLabels()
        {
            this.labelsTableAdapter1.Fill(this.carsDBLabelDataSet11.Labels);

            DataTable labels = this.carsDBLabelDataSet11.Labels;

            if (labels.Rows.Count == 0)
                return;
            schedulerControl1.Storage.Appointments.Labels.Clear();

            schedulerControl1.Storage.Appointments.Labels.BeginUpdate();
            for (int i = 0; i < labels.Rows.Count; i++)
            {
                Color color = Color.FromArgb(Int32.Parse(labels.Rows[i].ItemArray[1].ToString()));
                string dislayName = labels.Rows[i].ItemArray[2].ToString();
                string menuCaption = labels.Rows[i].ItemArray[3].ToString();
                AppointmentLabel aptLabel = new AppointmentLabel(color, dislayName, menuCaption);
                schedulerControl1.Storage.Appointments.Labels.Add(aptLabel);
            }
            schedulerControl1.Storage.Appointments.Labels.EndUpdate();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            labelsTableAdapter1.Update(carsDBLabelDataSet11);
            carsDBLabelDataSet11.AcceptChanges();
            InitializeLabels();
            schedulerControl1.Refresh();
        }

        private void OnApptChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            carSchedulingTableAdapter.Update(carsDBLabelDataSet);
            carsDBLabelDataSet.AcceptChanges();
        }

        private void carSchedulingTableAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                int id = 0;
                using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", carSchedulingTableAdapter.Connection))
                {
                    id = (int)cmd.ExecuteScalar();
                }
                e.Row["ID"] = id;
            }
        }

    }
}