using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_app
{
    public partial class Edit : Form
    {
        public string Name { get; set; }
        public string Major { get; set; }
        public string Class { get; set; }
        public Edit(string name, string major, string classes)
        {
            InitializeComponent();

            textBox1.Text = name;
            textBox2.Text = major;
            textBox3.Text = classes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            Major = textBox2.Text;
            Class = textBox3.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
