using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myprojeck
{
    public partial class ListViewManagmendForm : Form
    {
        public ListViewManagmendForm()
        {
            InitializeComponent();
        }

        int ID = 100;

        private void ListViewManagmendForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textName.Text) || string.IsNullOrEmpty(textEmail.Text) ||
                string.IsNullOrEmpty(textPhone.Text) || string.IsNullOrEmpty(numericUpDown1.Value.ToString()))
            {
                return;
            }

            ID++;
            

            ListViewItem item = new ListViewItem(ID.ToString());

            item.SubItems.Add(textName.Text.Trim());
            item.SubItems.Add(textEmail.Text.Trim());
            item.SubItems.Add(textPhone.Text.Trim());
            item.SubItems.Add(numericUpDown1.Value.ToString());
          
            

            if (rdoMan.Checked)
            {
                item.ImageIndex = 1;
            }
            else
            {
                item.ImageIndex = 0;
            }

            lstvData.Items.Add(item);

            textName.Clear();
            textEmail.Clear();
            textPhone.Clear();
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comBView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBView.Text == "LargeIcon")
            {
                lstvData.View = View.LargeIcon;
            }
            else if (comBView.Text == "SmallIcon")
            {
                lstvData.View = View.SmallIcon;
            }
            else if(comBView.Text == "Tidlt")
            {
                lstvData.View = View.Tile;
            }
            else if( comBView.Text == "List")
            {
                lstvData.View = View.List;
            }
            else
            {
                lstvData.View = View.Details;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lstvData.Items.Count > 0)
            {
                lstvData.Items.Remove(lstvData.SelectedItems[0]);
            }
        }

        private void lstvData_DoubleClick(object sender, EventArgs e)
        {
          
            
            

                lalID.Text = lstvData.SelectedItems[0].SubItems[0].Text;
            lalName.Text = lstvData.SelectedItems[0].SubItems[1].Text;
            lalEmail.Text = lstvData.SelectedItems[0].SubItems[2].Text;
            lalPhone.Text = lstvData.SelectedItems[0].SubItems[3].Text;
            lalAge.Text = lstvData.SelectedItems[0].SubItems[4].Text;
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textName.Text = toolStripMenuItem1.Text;
        }
    }
}
