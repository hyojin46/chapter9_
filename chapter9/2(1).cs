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
    public partial class _2_1_ : Form
    {
        public _2_1_() //생성자
        {
            InitializeComponent();//초기화
        }

        private void button1_Click(object sender, EventArgs e) //닫기 버튼 이벤트 처리기
        {
            this.Close(); //모달리스폼 닫기
        }
    }
}
