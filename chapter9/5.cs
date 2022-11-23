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
    public partial class _5 : Form
    {
        public _5() //생성자
        {
            InitializeComponent(); //초기화
        }
        private int i; // 필드 :멤버 변수
        private void _5_Load(object sender, EventArgs e) //폼 로드한 경우
        {
            i = i < 64 ? i += 16 : 0;
            this.Text = ((MessageBoxIcon)i).ToString();
            MessageBox.Show("MessageBoxIcon", "Title Bar",MessageBoxButtons.OKCancel, (MessageBoxIcon)i);
        }
    }
}
