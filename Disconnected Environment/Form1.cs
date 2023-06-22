using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class Form1 : Form
    {
        private string stringConnection = "Data Source=LAPTOP-1JRJB77C\\HMMPRYT;" + "database=prodi_mahasiswa;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();
        private string kstr;

        public Form1()
        {
            InitializeComponent();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormDataMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormDataProdi().Show();           
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
           
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        
        }
        private void refreshform()
        {
        }

    }
}
