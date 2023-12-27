using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_zenix_notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 메모장 우클릭 기능 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbox_note_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        /// <summary>
        /// 파일 > 끝내기 버튼 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 서식 > 자동 줄 바꿈 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoLineChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //autoLineChangeToolStripMenuItem.Checked = !autoLineChangeToolStripMenuItem.Checked;
            rtbox_note.WordWrap = !rtbox_note.WordWrap;

        }
        /// <summary>
        /// 보기 > 확대 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enlargementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbox_note.ZoomFactor += 0.1f;
            zoomFactortoolStripStatusLabel.Text = ((int)(rtbox_note.ZoomFactor * 100)).ToString() + '%';
        }

        private void reductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbox_note.ZoomFactor -= 0.1f;
            zoomFactortoolStripStatusLabel.Text = ((int)(rtbox_note.ZoomFactor * 100)).ToString() + '%';
        }

        /// <summary>
        /// 보기 > 상태 표시줄 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statusLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
        }
        /// <summary>
        /// 서식 > 글꼴 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
