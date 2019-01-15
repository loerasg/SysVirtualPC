using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPC
{
    public partial class VirtualPC : Form
    {
        public VirtualPC()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double Var50c = Convert.ToDouble(textBox50c.Text);
            double Var1p = Convert.ToDouble(textBox1p.Text);
            double Var2p = Convert.ToDouble(textBox2p.Text);
            double Var5p = Convert.ToDouble(textBox5p.Text);
            double Var10p = Convert.ToDouble(textBox10p.Text);
            double Var20p = Convert.ToDouble(textBox20p.Text);
            double Var50p = Convert.ToDouble(textBox50p.Text);
            double Var100p = Convert.ToDouble(textBox100p.Text);
            double Var200p = Convert.ToDouble(textBox200p.Text);
            double Var500p = Convert.ToDouble(textBox500p.Text);
            double Tot_Caja = (Var50c*0.5)+Var1p+(Var2p*2) + (Var5p * 5) + (Var10p * 10) + (Var20p * 20) + (Var50p * 50) + (Var100p * 100) + (Var200p * 200) + (Var500p * 500);
            lbl_TinC.Text = Tot_Caja.ToString();
        }
    }
}
