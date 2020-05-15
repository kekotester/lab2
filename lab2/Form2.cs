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
    public partial class Form2 : Form
    {
        public Model1 db { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите данные!");
                return;
            }
            int id;
            bool b = int.TryParse(textBox1.Text, out id);
            if (b == false)
            {
                MessageBox.Show("Неверный формат id - " + textBox1.Text);
                return;
            }
            Students tr = new Students();
            tr.RoleID = id;
            tr.Name = textBox2.Text;
            db.Students.Add(tr);
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }
    }
}
