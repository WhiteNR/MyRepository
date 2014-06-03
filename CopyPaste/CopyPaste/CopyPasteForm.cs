using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPaste
{
    public partial class CopyPasteForm : Form
    {
        OpenFileDialog dlg;
        ImageList img;
        public CopyPasteForm()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
            dlg = new OpenFileDialog();
            img = new ImageList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            if ( dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 ListViewItem item = new ListViewItem(dlg.FileName, 0);
                img.Images.Add(Icon.ExtractAssociatedIcon(dlg.FileName));
                listView1.SmallImageList = img;
               // ListViewItem.ListViewSubItem[] subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item,Icon.ExtractAssociatedIcon(dlg.FileName)) };
                listView1.Items.Add(dlg.FileName, img.Images.Count - 1);
            } 
        }
    }
}
