using System;
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
    public partial class _1 : Form
    {
        public _1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //modal버튼 이벤트 처리기
        {
            Form1 form1 = new Form1(); //모달 창 객체 생성
            form1.ShowDialog();
        }
    }
}
