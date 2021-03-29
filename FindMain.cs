using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7
{
    public partial class FindMain : Form
    {
        public FindMain()
        {
            InitializeComponent();
        }

        private void FindNumberbutton_Click(object sender, EventArgs e)
        {
            Find Win = new Find();
            Win.Show();
        }

        private void FindSculptButton_Click(object sender, EventArgs e)
        {
            FindSculp Win = new FindSculp();
            Win.Show();
        }

        private void FindMaterialButton_Click(object sender, EventArgs e)
        {
            FindMaterial Win = new FindMaterial();
            Win.Show();
        }

        private void FindSizeButton_Click(object sender, EventArgs e)
        {
            FindSize Win = new FindSize();
            Win.Show();
        }

        private void FindMasterButton_Click(object sender, EventArgs e)
        {
            FindMaster Win = new FindMaster();
            Win.Show();
        }
    }
}
