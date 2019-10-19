using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNL_UI
{
    public partial class CNL : Form
    {
        public CNL()
        {
            InitializeComponent();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {         
            
        }

        bool DrawerOpen = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DrawerOpen = !DrawerOpen;
            PnlMenu.Visible = false;

            if (DrawerOpen)
            {
                //animated Drawer Open
                PnlMenu.Width = 233;
                pictureBox1.Image = imageList1.Images[0];
                bunifuTransition1.ShowSync(PnlMenu);
            }
            else
            {
                //Aminated Drawer close
                PnlMenu.Width = 50;
                pictureBox1.Image = imageList1.Images[1];
                bunifuTransition1.ShowSync(PnlMenu);
            }

            //if (PnlMenu.Width==250)
            //{
            //    PnlMenu.Width = 70;
            //}
            //else
            //{
            //    PnlMenu.Width = 250;   
            //}
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
        }

     
    }
}
