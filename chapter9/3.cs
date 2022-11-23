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
    public partial class _3 : Form
    {
        public _3() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void _3_Load(object sender, EventArgs e) //폼로드하는 경우
        {
            MessageBox.Show("MessageBox", "Title Bar");
        }
    }
}
