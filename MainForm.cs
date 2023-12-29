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
    public partial class MainForm : Form
    {
        public MainForm()
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

        /// <summary>
        /// 보기 > 축소 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbox_note.ZoomFactor -= 0.1f;
            zoomFactortoolStripStatusLabel.Text = ((int)(rtbox_note.ZoomFactor * 100)).ToString() + '%';
        }

        /// <summary>
        /// 보기 > 기본값 복원 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refactorZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbox_note.ZoomFactor = 1.0f;
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
            FontForm form2 = new FontForm();
            form2.Show();
        }

        private void rtbox_note_MouseDown(object sender, MouseEventArgs e)
        {

        }
        /// <summary>
        /// 편집 > 실행 취소 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbox_note.CanUndo)
                rtbox_note.Undo();
            else rtbox_note.Redo();
        }
        /// <summary>
        /// 편집 > 붙여넣기 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbox_note.Paste();
        }
        /// <summary>
        /// 편집 > 모두 선택 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbox_note.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbox_note.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbox_note.Copy();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #region 여기서 부터 묶을 거임
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">이것은 무슨 파라미터 입니다 </param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        #endregion

    }
}
