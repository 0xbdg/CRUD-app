using System;
using System.Windows.Forms;

namespace CRUD_app
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            listView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lItem = new ListViewItem(new string[] {textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text });
            listView1.Items.Add(lItem);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) 
            {
                ListViewItem selected = listView1.SelectedItems[0];
                Edit edit = new Edit(selected.SubItems[1].Text, selected.SubItems[2].Text, selected.SubItems[3].Text);

                if (edit.ShowDialog() == DialogResult.OK)
                {
                    selected.SubItems[1].Text = edit.Name;
                    selected.SubItems[2].Text = edit.Major;
                    selected.SubItems[3].Text = edit.Class;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();
            }
        }
    }
}
