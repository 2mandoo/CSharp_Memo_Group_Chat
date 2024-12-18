namespace ChatClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblChat = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblDisconnect = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새탭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새창ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대축ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상태표시줄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바꿈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClientList = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChat.Location = new System.Drawing.Point(13, 71);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(692, 305);
            this.txtChat.TabIndex = 0;
            this.txtChat.TextChanged += new System.EventHandler(this.txtChat_TextChanged);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInput.Location = new System.Drawing.Point(13, 382);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(692, 56);
            this.txtInput.TabIndex = 1;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Location = new System.Drawing.Point(13, 32);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(29, 12);
            this.lblChat.TabIndex = 2;
            this.lblChat.Text = "chat";
            this.lblChat.Click += new System.EventHandler(this.lblChat_Click);
            // 
            // txtNick
            // 
            this.txtNick.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNick.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNick.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNick.Location = new System.Drawing.Point(47, 33);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(159, 13);
            this.txtNick.TabIndex = 3;
            this.txtNick.Text = "닉네임 입력 후 chat 클릭";
            this.txtNick.Click += new System.EventHandler(this.txtNick_Click);
            this.txtNick.Enter += new System.EventHandler(this.txtNick_Enter);
            // 
            // lblDisconnect
            // 
            this.lblDisconnect.AutoSize = true;
            this.lblDisconnect.Location = new System.Drawing.Point(638, 32);
            this.lblDisconnect.Name = "lblDisconnect";
            this.lblDisconnect.Size = new System.Drawing.Size(67, 12);
            this.lblDisconnect.TabIndex = 4;
            this.lblDisconnect.Text = "disconnect";
            this.lblDisconnect.Click += new System.EventHandler(this.lblDisconnect_Click);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Location = new System.Drawing.Point(594, 32);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(33, 12);
            this.lblClear.TabIndex = 5;
            this.lblClear.Text = "clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편지ToolStripMenuItem,
            this.보기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새탭ToolStripMenuItem,
            this.새창ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새탭ToolStripMenuItem
            // 
            this.새탭ToolStripMenuItem.Name = "새탭ToolStripMenuItem";
            this.새탭ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.새탭ToolStripMenuItem.Text = "새 탭";
            // 
            // 새창ToolStripMenuItem
            // 
            this.새창ToolStripMenuItem.Name = "새창ToolStripMenuItem";
            this.새창ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.새창ToolStripMenuItem.Text = "새 창";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            // 
            // 편지ToolStripMenuItem
            // 
            this.편지ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실ToolStripMenuItem,
            this.toolStripSeparator1,
            this.잘라내ToolStripMenuItem,
            this.복사ToolStripMenuItem,
            this.붙여넣기ToolStripMenuItem,
            this.삭ToolStripMenuItem});
            this.편지ToolStripMenuItem.Name = "편지ToolStripMenuItem";
            this.편지ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편지ToolStripMenuItem.Text = "편집";
            // 
            // 실ToolStripMenuItem
            // 
            this.실ToolStripMenuItem.Name = "실ToolStripMenuItem";
            this.실ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.실ToolStripMenuItem.Text = "실행 취소";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 잘라내ToolStripMenuItem
            // 
            this.잘라내ToolStripMenuItem.Name = "잘라내ToolStripMenuItem";
            this.잘라내ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.잘라내ToolStripMenuItem.Text = "잘라내기";
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.복사ToolStripMenuItem.Text = "복사";
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.붙여넣기ToolStripMenuItem.Text = "붙여넣기";
            // 
            // 삭ToolStripMenuItem
            // 
            this.삭ToolStripMenuItem.Name = "삭ToolStripMenuItem";
            this.삭ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.삭ToolStripMenuItem.Text = "삭제";
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대축ToolStripMenuItem,
            this.상태표시줄ToolStripMenuItem,
            this.자동줄바꿈ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 확대축ToolStripMenuItem
            // 
            this.확대축ToolStripMenuItem.Name = "확대축ToolStripMenuItem";
            this.확대축ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.확대축ToolStripMenuItem.Text = "확대/축";
            // 
            // 상태표시줄ToolStripMenuItem
            // 
            this.상태표시줄ToolStripMenuItem.Name = "상태표시줄ToolStripMenuItem";
            this.상태표시줄ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.상태표시줄ToolStripMenuItem.Text = "상태 표시줄";
            // 
            // 자동줄바꿈ToolStripMenuItem
            // 
            this.자동줄바꿈ToolStripMenuItem.Name = "자동줄바꿈ToolStripMenuItem";
            this.자동줄바꿈ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.자동줄바꿈ToolStripMenuItem.Text = "자동 줄 바꿈";
            // 
            // lblClientList
            // 
            this.lblClientList.AutoSize = true;
            this.lblClientList.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblClientList.Location = new System.Drawing.Point(12, 51);
            this.lblClientList.Name = "lblClientList";
            this.lblClientList.Size = new System.Drawing.Size(0, 12);
            this.lblClientList.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.lblClientList);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.lblDisconnect);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "메모장";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label lblDisconnect;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새탭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새창ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 잘라내ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대축ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상태표시줄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈ToolStripMenuItem;
        private System.Windows.Forms.Label lblClientList;
    }
}

