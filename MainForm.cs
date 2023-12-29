using System;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace _01_zenix_notepad
{

    public partial class MainForm : Form
    {
        bool coverFlag;
        string coverTitle;
        string coverText;

        PageSettings ps = new PageSettings();
        PrinterSettings pts = new PrinterSettings();

        private void MainForm_Load(object sender, EventArgs e)
        {
            coverFlag = false;
            coverText = "";
            coverTitle = "";
        }

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

        #region 상단 메뉴 "파일"

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
        /// 파일 > 다른 이름으로 저장 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "텍스트 파일|*.txt|모든 파일|*.*";
            saveFileDialog1.FilterIndex = 1;

            // 대화상자를 닫기 전에 디렉토리를 이전에 선택한 디렉토리로
            // 복원한지의 여부를 나타납니다.
            saveFileDialog1.RestoreDirectory = true;

            // 확장명을 입력하지 않을 때, 자동으로 확장자를 추가할 수 있습니다.
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "txt";

            // 파일이 이미 존재하면 덮어쓰기 할지를 묻는 대화상자를 표시합니다.
            // 기본값: true
            saveFileDialog1.OverwritePrompt = true;

            // 저장할 위치의 초기 디렉토리를 설정합니다.
            // Environment.CurrentDirectory: 현재 디렉토리를 나타냅니다.
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Text = saveFileDialog1.FileName;
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(rtbox_note.Text);
                    coverFlag = true;
                    coverTitle = saveFileDialog1.FileName;
                    coverText = rtbox_note.Text;
                }
            }
        }

        /// <summary>
        /// 파일 > 저장 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void coverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (coverFlag)
            {
                using (StreamWriter sw = new StreamWriter(coverTitle))
                {
                    sw.Write(rtbox_note.Text);
                }
            }
            else
            {
                SaveToolStripMenuItem_Click(sender, e);
            }
        }

        /// <summary>
        /// 파일 > 열기 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "텍스트 파일|*.txt|모든 파일|*.*";
            ofd.DefaultExt = "txt";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.Text = ofd.FileName;   // 폼의 타이틀
                string[] textvalue = System.IO.File.ReadAllLines(ofd.FileName);
                rtbox_note.Lines = textvalue;
            }

        }

        #endregion

        #region 상단 메뉴 "편집"

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

        /// <summary>
        /// 편집 > 잘라내기 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbox_note.Cut();
        }

        /// <summary>
        /// 편집 > 복사 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbox_note.Copy();
        }

        /// <summary>
        /// 편집 > 삭제 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 편집 > 찾기 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 상단 메뉴 "서식"
        /// <summary>
        /// 서식 > 글꼴 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();   
            fd.ShowDialog();
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
        #endregion

        #region 상단 메뉴 "보기"
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
        #endregion



        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbox_note.Clear();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            newForm.Show();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PageSetupDialog psg = new PageSetupDialog();
            psg.PageSettings = ps;
            psg.PrinterSettings = pts;
            psg.ShowDialog();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bing.com/search?q=windows%EC%9D%98+%EB%A9%94%EB%AA%A8%EC%9E%A5%EC%97%90+%EB%8C%80%ED%95%9C+%EB%8F%84%EC%9B%80%EB%A7%90+%EB%B3%B4%EA%B8%B0");
        }
    }
}
