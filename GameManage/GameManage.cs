using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManage
{
    public partial class GameManage: Form
    {
        public GameManage()
        {
            InitializeComponent();

            PlatformFilter.Items.Add("PC", true);
            PlatformFilter.Items.Add("Web Browser");
            PlatformFilter.Items.Add("Nintendo Switch", true);
            PlatformFilter.Items.Add("Play Station 5", true);
            PlatformFilter.Items.Add("Android");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InsertData(object sender, EventArgs e)
        {
            StateBar.Text = "Insert Data";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("색깔변경 주기적으로");
            label1.ForeColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
