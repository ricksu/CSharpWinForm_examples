using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            dataGridView1.DataSource = sampleData();
            dataGridView1.Columns[1].Width = 508;
            this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.EnableHeadersVisualStyles = false;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

        }

        private DataTable sampleData()
        {
            using (DataTable table = new DataTable())
            {
                //// Add columns.
                table.Columns.Add("name", typeof(string));
                table.Columns.Add("size ", typeof(string));
                table.Columns.Add("date", typeof(DateTime));
                

                // Add rows.
                table.Rows.Add("video1",  "100M", DateTime.Now);
                table.Rows.Add("video2",  "100M", DateTime.Now);
                table.Rows.Add("video3",  "100M", DateTime.Now);

                return table;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.Red;
            e.CellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
    }
}
