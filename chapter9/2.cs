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
    public partial class _2 : Form
    {
        public _2() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _2_1_ modaless = new _2_1_(); //모달리스폼 객체 생성
            modaless.Show();
        }
    }
}
