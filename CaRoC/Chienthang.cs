﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaRoC
{
    public partial class Chienthang : Form
    {
        public Chienthang()
        {
            InitializeComponent();
        }

        //thoát form ct
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
