namespace MenuStrip
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ToolStripFile = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTest = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModal = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.tbPaste = new System.Windows.Forms.TextBox();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.fd = new System.Windows.Forms.FontDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.tbFour = new System.Windows.Forms.TextBox();
            this.ToolStripFile.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripFile
            // 
            this.ToolStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.ToolStripFile.Location = new System.Drawing.Point(0, 0);
            this.ToolStripFile.Name = "ToolStripFile";
            this.ToolStripFile.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStripFile.Size = new System.Drawing.Size(539, 24);
            this.ToolStripFile.TabIndex = 0;
            this.ToolStripFile.Text = "파일";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripNew,
            this.ToolStripOpen,
            this.ToolStripSave,
            this.toolStripSeparator1,
            this.ToolStripExit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // ToolStripNew
            // 
            this.ToolStripNew.Name = "ToolStripNew";
            this.ToolStripNew.Size = new System.Drawing.Size(138, 22);
            this.ToolStripNew.Text = "새로 만들기";
            this.ToolStripNew.Click += new System.EventHandler(this.ToolStripNew_Click);
            // 
            // ToolStripOpen
            // 
            this.ToolStripOpen.Name = "ToolStripOpen";
            this.ToolStripOpen.Size = new System.Drawing.Size(138, 22);
            this.ToolStripOpen.Text = "열기";
            this.ToolStripOpen.Click += new System.EventHandler(this.ToolStripOpen_Click);
            // 
            // ToolStripSave
            // 
            this.ToolStripSave.Name = "ToolStripSave";
            this.ToolStripSave.Size = new System.Drawing.Size(138, 22);
            this.ToolStripSave.Text = "저장";
            this.ToolStripSave.Click += new System.EventHandler(this.ToolStripSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // ToolStripExit
            // 
            this.ToolStripExit.Name = "ToolStripExit";
            this.ToolStripExit.Size = new System.Drawing.Size(138, 22);
            this.ToolStripExit.Text = "종료";
            this.ToolStripExit.BackColorChanged += new System.EventHandler(this.ToolStripExit_BackColorChanged);
            this.ToolStripExit.Click += new System.EventHandler(this.ToolStripExit_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("굴림", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTest.Location = new System.Drawing.Point(12, 34);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(92, 27);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripCopy,
            this.ToolStripPaste,
            this.ToolStripCut});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            // 
            // ToolStripCopy
            // 
            this.ToolStripCopy.Name = "ToolStripCopy";
            this.ToolStripCopy.Size = new System.Drawing.Size(122, 22);
            this.ToolStripCopy.Text = "복사";
            this.ToolStripCopy.Click += new System.EventHandler(this.ToolStripCopy_Click);
            // 
            // ToolStripPaste
            // 
            this.ToolStripPaste.Name = "ToolStripPaste";
            this.ToolStripPaste.Size = new System.Drawing.Size(122, 22);
            this.ToolStripPaste.Text = "붙여넣기";
            this.ToolStripPaste.Click += new System.EventHandler(this.ToolStripPaste_Click);
            // 
            // ToolStripCut
            // 
            this.ToolStripCut.Name = "ToolStripCut";
            this.ToolStripCut.Size = new System.Drawing.Size(122, 22);
            this.ToolStripCut.Text = "잘라내기";
            this.ToolStripCut.Click += new System.EventHandler(this.ToolStripCut_Click);
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(12, 189);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(96, 40);
            this.btnModal.TabIndex = 2;
            this.btnModal.Text = "모달";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(123, 189);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(96, 40);
            this.btnModaless.TabIndex = 3;
            this.btnModaless.Text = "모달리스";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
            // 
            // tbPaste
            // 
            this.tbPaste.Location = new System.Drawing.Point(12, 245);
            this.tbPaste.Multiline = true;
            this.tbPaste.Name = "tbPaste";
            this.tbPaste.Size = new System.Drawing.Size(207, 176);
            this.tbPaste.TabIndex = 4;
            // 
            // ofd
            // 
            this.ofd.FileName = "DlgOpen";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(297, 130);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(96, 40);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "열기\r\nFileDialog\r\n";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(297, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(415, 130);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(96, 40);
            this.btnFont.TabIndex = 7;
            this.btnFont.Text = "폰트설정";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(415, 189);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(96, 40);
            this.btnColor.TabIndex = 8;
            this.btnColor.Text = "색상설정";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tbFour
            // 
            this.tbFour.Location = new System.Drawing.Point(296, 245);
            this.tbFour.Multiline = true;
            this.tbFour.Name = "tbFour";
            this.tbFour.Size = new System.Drawing.Size(214, 176);
            this.tbFour.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 441);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tbFour);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbPaste);
            this.Controls.Add(this.btnModaless);
            this.Controls.Add(this.btnModal);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.ToolStripFile);
            this.MainMenuStrip = this.ToolStripFile;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MenuStrip";
            this.ToolStripFile.ResumeLayout(false);
            this.ToolStripFile.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ToolStripFile;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCopy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripPaste;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCut;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnModaless;
        private System.Windows.Forms.TextBox tbPaste;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.FontDialog fd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox tbFour;
    }
}

