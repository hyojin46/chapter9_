﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter9
{
    public partial class _6 : Form
    {
        public _6() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void _6_Load(object sender, EventArgs e) //폼로드한 경우
        {
            MessageBox.Show("MessageBoxDefaultButton", "Title Bar",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
        }
    }
}
