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
    public partial class _7 : Form
    {
        public _7() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void button1_Click(object sender, EventArgs e) //파일찾기 버튼 이벤트 처리기
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1; // 텍스트 파일(*.txt)|*.txt 선택한 경우
            openFileDialog1.RestoreDirectory = true; //Filter프로퍼티의 현재 index
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }
    }
}
