using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void splitContainer1_SplitterMoving(object sender, SplitterCancelEventArgs e)
        {
            

            //if (splitter.Panel2.Width < listView1.Width)
            //{
            //    splitter.Panel2.Width = listView1.Width;
            //}
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            var splitter = sender as SplitContainer;
            if (splitter.Panel2.Width < listView1.Width)
            {
                
               // splitter = listView1.MaximumSize.Width;
                splitter.SplitterDistance =this.Width - listView1.MaximumSize.Width;
            }
        }
    }
}
