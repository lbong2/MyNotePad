namespace _01_zenix_notepad
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bing으로검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다음찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이전찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바꾸기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간날짜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoLineChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대하기축소하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enlargementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refactorZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.피드백보내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메모장정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbox_note = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rowColtoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.zoomFactortoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.서식OToolStripMenuItem,
            this.보기VToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1469, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.openToolStripMenuItem,
            this.coverToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.pageSetupToolStripMenuItem,
            this.printToolStripMenuItem,
            this.finishToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newToolStripMenuItem.Text = "새로 만들기(N)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newWindowToolStripMenuItem.Text = "새 창(W)";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openToolStripMenuItem.Text = "열기(O)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // coverToolStripMenuItem
            // 
            this.coverToolStripMenuItem.Name = "coverToolStripMenuItem";
            this.coverToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.coverToolStripMenuItem.Text = "저장(S)";
            this.coverToolStripMenuItem.Click += new System.EventHandler(this.coverToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.SaveToolStripMenuItem.Text = "다른 이름으로 저장(A)";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pageSetupToolStripMenuItem.Text = "페이지 설정(U)";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.printToolStripMenuItem.Text = "인쇄(P)";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // finishToolStripMenuItem
            // 
            this.finishToolStripMenuItem.Name = "finishToolStripMenuItem";
            this.finishToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.finishToolStripMenuItem.Text = "끝내기(X)";
            this.finishToolStripMenuItem.Click += new System.EventHandler(this.finishToolStripMenuItem_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.bing으로검색ToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.다음찾기ToolStripMenuItem,
            this.이전찾기ToolStripMenuItem,
            this.바꾸기ToolStripMenuItem,
            this.이동ToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.시간날짜ToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집EToolStripMenuItem.Text = "편집(E)";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.undoToolStripMenuItem.Text = "실행 취소(U)";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cutToolStripMenuItem.Text = "잘라내기(T)";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.copyToolStripMenuItem.Text = "복사(C)";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.pasteToolStripMenuItem.Text = "붙여넣기(P)";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deleteToolStripMenuItem.Text = "삭제(L)";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // bing으로검색ToolStripMenuItem
            // 
            this.bing으로검색ToolStripMenuItem.Name = "bing으로검색ToolStripMenuItem";
            this.bing으로검색ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.bing으로검색ToolStripMenuItem.Text = "Bing으로 검색(S)";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.searchToolStripMenuItem.Text = "찾기(F)";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // 다음찾기ToolStripMenuItem
            // 
            this.다음찾기ToolStripMenuItem.Name = "다음찾기ToolStripMenuItem";
            this.다음찾기ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.다음찾기ToolStripMenuItem.Text = "다음 찾기(N)";
            // 
            // 이전찾기ToolStripMenuItem
            // 
            this.이전찾기ToolStripMenuItem.Name = "이전찾기ToolStripMenuItem";
            this.이전찾기ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.이전찾기ToolStripMenuItem.Text = "이전 찾기(V)";
            // 
            // 바꾸기ToolStripMenuItem
            // 
            this.바꾸기ToolStripMenuItem.Name = "바꾸기ToolStripMenuItem";
            this.바꾸기ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.바꾸기ToolStripMenuItem.Text = "바꾸기(R)";
            // 
            // 이동ToolStripMenuItem
            // 
            this.이동ToolStripMenuItem.Name = "이동ToolStripMenuItem";
            this.이동ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.이동ToolStripMenuItem.Text = "이동(G)";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.selectAllToolStripMenuItem.Text = "모두 선택(A)";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // 시간날짜ToolStripMenuItem
            // 
            this.시간날짜ToolStripMenuItem.Name = "시간날짜ToolStripMenuItem";
            this.시간날짜ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.시간날짜ToolStripMenuItem.Text = "시간/날짜(D)";
            // 
            // 서식OToolStripMenuItem
            // 
            this.서식OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoLineChangeToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.서식OToolStripMenuItem.Name = "서식OToolStripMenuItem";
            this.서식OToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.서식OToolStripMenuItem.Text = "서식(O)";
            // 
            // autoLineChangeToolStripMenuItem
            // 
            this.autoLineChangeToolStripMenuItem.CheckOnClick = true;
            this.autoLineChangeToolStripMenuItem.Name = "autoLineChangeToolStripMenuItem";
            this.autoLineChangeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.autoLineChangeToolStripMenuItem.Text = "자동 줄 바꿈(W)";
            this.autoLineChangeToolStripMenuItem.Click += new System.EventHandler(this.autoLineChangeToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fontToolStripMenuItem.Text = "글꼴(F)";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // 보기VToolStripMenuItem
            // 
            this.보기VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대하기축소하기ToolStripMenuItem,
            this.statusLineToolStripMenuItem});
            this.보기VToolStripMenuItem.Name = "보기VToolStripMenuItem";
            this.보기VToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.보기VToolStripMenuItem.Text = "보기(V)";
            // 
            // 확대하기축소하기ToolStripMenuItem
            // 
            this.확대하기축소하기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enlargementToolStripMenuItem,
            this.reductionToolStripMenuItem,
            this.refactorZoomToolStripMenuItem});
            this.확대하기축소하기ToolStripMenuItem.Name = "확대하기축소하기ToolStripMenuItem";
            this.확대하기축소하기ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.확대하기축소하기ToolStripMenuItem.Text = "확대하기/축소하기";
            // 
            // enlargementToolStripMenuItem
            // 
            this.enlargementToolStripMenuItem.Name = "enlargementToolStripMenuItem";
            this.enlargementToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.enlargementToolStripMenuItem.Text = "확대(I)";
            this.enlargementToolStripMenuItem.Click += new System.EventHandler(this.enlargementToolStripMenuItem_Click);
            // 
            // reductionToolStripMenuItem
            // 
            this.reductionToolStripMenuItem.Name = "reductionToolStripMenuItem";
            this.reductionToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.reductionToolStripMenuItem.Text = "축소(O)";
            this.reductionToolStripMenuItem.Click += new System.EventHandler(this.reductionToolStripMenuItem_Click);
            // 
            // refactorZoomToolStripMenuItem
            // 
            this.refactorZoomToolStripMenuItem.Name = "refactorZoomToolStripMenuItem";
            this.refactorZoomToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.refactorZoomToolStripMenuItem.Text = "확대하기/축소하기 기본값 복원";
            this.refactorZoomToolStripMenuItem.Click += new System.EventHandler(this.refactorZoomToolStripMenuItem_Click);
            // 
            // statusLineToolStripMenuItem
            // 
            this.statusLineToolStripMenuItem.Checked = true;
            this.statusLineToolStripMenuItem.CheckOnClick = true;
            this.statusLineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusLineToolStripMenuItem.Name = "statusLineToolStripMenuItem";
            this.statusLineToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.statusLineToolStripMenuItem.Text = "상태 표시줄(S)";
            this.statusLineToolStripMenuItem.Click += new System.EventHandler(this.statusLineToolStripMenuItem_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.피드백보내기ToolStripMenuItem,
            this.메모장정보ToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(H)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.helpToolStripMenuItem.Text = "도움말 보기(H)";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // 피드백보내기ToolStripMenuItem
            // 
            this.피드백보내기ToolStripMenuItem.Name = "피드백보내기ToolStripMenuItem";
            this.피드백보내기ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.피드백보내기ToolStripMenuItem.Text = "피드백 보내기(F)";
            // 
            // 메모장정보ToolStripMenuItem
            // 
            this.메모장정보ToolStripMenuItem.Name = "메모장정보ToolStripMenuItem";
            this.메모장정보ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.메모장정보ToolStripMenuItem.Text = "메모장 정보(A)";
            // 
            // rtbox_note
            // 
            this.rtbox_note.BackColor = System.Drawing.Color.White;
            this.rtbox_note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbox_note.DetectUrls = false;
            this.rtbox_note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbox_note.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbox_note.Location = new System.Drawing.Point(0, 24);
            this.rtbox_note.Name = "rtbox_note";
            this.rtbox_note.Size = new System.Drawing.Size(1469, 622);
            this.rtbox_note.TabIndex = 1;
            this.rtbox_note.Text = "";
            this.rtbox_note.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbox_note_MouseClick);
            this.rtbox_note.TextChanged += new System.EventHandler(this.rtbox_note_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel5,
            this.rowColtoolStripStatusLabel,
            this.zoomFactortoolStripStatusLabel,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1469, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(1224, 17);
            this.toolStripStatusLabel5.Spring = true;
            // 
            // rowColtoolStripStatusLabel
            // 
            this.rowColtoolStripStatusLabel.Name = "rowColtoolStripStatusLabel";
            this.rowColtoolStripStatusLabel.Size = new System.Drawing.Size(67, 17);
            this.rowColtoolStripStatusLabel.Text = "Ln 1, Col 1";
            this.rowColtoolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zoomFactortoolStripStatusLabel
            // 
            this.zoomFactortoolStripStatusLabel.Name = "zoomFactortoolStripStatusLabel";
            this.zoomFactortoolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.zoomFactortoolStripStatusLabel.Text = "100%";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel3.Text = "Window(CRLF)";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel4.Text = "UTF-8";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 646);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtbox_note);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "제목 없음 - zenix 메모장";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bing으로검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다음찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이전찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바꾸기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시간날짜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoLineChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대하기축소하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 피드백보내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메모장정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enlargementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refactorZoomToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbox_note;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel rowColtoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel zoomFactortoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}

