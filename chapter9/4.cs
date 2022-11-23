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
    public partial class _4 : Form
    {
        public _4() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void _4_Load(object sender, EventArgs e) //폼로드하는 경우
        {
            MessageBox.Show("MessageBoxButtons", "Title Bar",MessageBoxButtons.OKCancel);
        }
    }
}
