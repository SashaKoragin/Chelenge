using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestChelenje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] bases = { 3,6,7,9,13,18,20 };

        private int[] spliters = { 1,4,9,15};

        private int[] mass;
        private List<int[]> result = new List<int[]>();

        private List<List<int>> List =new List<List<int>>();
        private List<int> Contener = new List<int>();
        private void Челендж_Click(object sender, EventArgs e)
        {
            var border_basese = 0;
            for (int i = 0; i < spliters.Length; i++)
            {

                mass = bases.Where(val => val<= spliters[i]&&val> border_basese).ToArray();
                border_basese = spliters[i];
                if (mass.Length > 0)
                {
                    result.Add(mass);
                    mass = null;
                }
                //Обработка остатков если есть
                if (spliters.Max() == spliters[i] && bases.Max()> border_basese)
                {
                    mass = bases.Where(val => val > border_basese).ToArray();
                    result.Add(mass);
                }
            }
            var е = result;
        }
    }
}