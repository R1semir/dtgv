using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dtr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbPersonelDataSet3.TBLBILGI' table. You can move, or remove it, as needed.
            this.tBLBILGITableAdapter.Fill(this.dbPersonelDataSet3.TBLBILGI);



            for (int i = 0; i<dataGridView1.Rows.Count -1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if ( Convert.ToInt16(dataGridView1.Rows[i].Cells[5].Value) >= 4600   )
                {
                    renk.BackColor = Color.Cyan;
                    renk.ForeColor = Color.White;
                }
                else
                {
                    renk.BackColor = Color.Orange;
                    renk.BackColor = Color.Black;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }
    }
}
