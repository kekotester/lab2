using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentsBindingSource.DataSource = db.Students.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.db = db;
            DialogResult dr = f.ShowDialog();
            if (dr == DialogResult.OK)
            {
                studentsBindingSource.DataSource = db.Students.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
