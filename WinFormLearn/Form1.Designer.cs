namespace WinFormLearn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // ── Header ──
        private Panel panelHeader;
        private Label labelTitle;

        // ── Product card ──
        private Panel panelProducts;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button buttonAdd;
        private Button buttonPrev;
        private Button buttonNext;

        // ── User card ──
        private Panel panelUser;
        private Label labelUserSection;
        private Label labelUserNameHint;
        private TextBox textBoxUserName;
        private Label labelUserEmailHint;
        private TextBox textBoxUserEmail;
        private Label labelUserName;

        // ── Worker card ──
        private Panel panelWorker;
        private Label labelWorkerSection;
        private ProgressBar progressBar1;
        private Label labelProgress;
        private Button buttonStartBackground;
        private Button buttonCancelBackground;

        // ── Footer ──
        private Button buttonOpenCrud;

        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            labelTitle = new Label();
            panelProducts = new Panel();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            buttonAdd = new Button();
            buttonPrev = new Button();
            buttonNext = new Button();
            panelUser = new Panel();
            labelUserSection = new Label();
            labelUserNameHint = new Label();
            textBoxUserName = new TextBox();
            labelUserEmailHint = new Label();
            textBoxUserEmail = new TextBox();
            labelUserName = new Label();
            panelWorker = new Panel();
            labelWorkerSection = new Label();
            progressBar1 = new ProgressBar();
            labelProgress = new Label();
            buttonStartBackground = new Button();
            buttonCancelBackground = new Button();
            buttonOpenCrud = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();

            panelHeader.SuspendLayout();
            panelProducts.SuspendLayout();
            panelUser.SuspendLayout();
            panelWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // ── Colors ──
            var accentColor = Color.FromArgb(0, 120, 212);
            var headerBg = Color.FromArgb(24, 24, 36);
            var formBg = Color.FromArgb(243, 243, 248);
            var cardBg = Color.White;
            var textPrimary = Color.FromArgb(30, 30, 30);
            var textSecondary = Color.FromArgb(100, 100, 100);
            var btnSuccess = Color.FromArgb(16, 163, 127);
            var btnNeutral = Color.FromArgb(108, 117, 125);
            var borderColor = Color.FromArgb(220, 220, 225);

            // ── backgroundWorker1 ──
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

            // ════════════════════════════════════════
            // panelHeader
            // ════════════════════════════════════════
            panelHeader.BackColor = headerBg;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 60;
            panelHeader.Padding = new Padding(24, 0, 0, 0);
            panelHeader.Controls.Add(labelTitle);

            // labelTitle
            labelTitle.AutoSize = false;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Text = "\U0001F4CA  상품 관리 대시보드";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;

            // ════════════════════════════════════════
            // panelProducts (left card)
            // ════════════════════════════════════════
            panelProducts.BackColor = cardBg;
            panelProducts.Location = new Point(24, 80);
            panelProducts.Size = new Size(480, 500);
            panelProducts.Paint += (s, e) =>
            {
                var rect = panelProducts.ClientRectangle;
                rect.Inflate(-1, -1);
                using var pen = new Pen(borderColor, 1);
                e.Graphics.DrawRectangle(pen, rect);
            };

            // labelSearch
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 10F);
            labelSearch.ForeColor = textSecondary;
            labelSearch.Location = new Point(20, 16);
            labelSearch.Text = "\U0001F50D 검색";

            // textBoxSearch
            textBoxSearch.Font = new Font("Segoe UI", 11F);
            textBoxSearch.Location = new Point(20, 42);
            textBoxSearch.Size = new Size(440, 32);
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.PlaceholderText = "상품 이름으로 검색...";
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;

            // dataGridView1
            dataGridView1.Location = new Point(20, 84);
            dataGridView1.Size = new Size(440, 260);
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.FromArgb(235, 235, 240);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = textSecondary;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = textSecondary;
            dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 6, 8, 6);
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = textPrimary;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 240, 254);
            dataGridView1.DefaultCellStyle.SelectionForeColor = textPrimary;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dataGridView1.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            dataGridView1.RowTemplate.Height = 36;

            // label1 (현재 상품 이름)
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = textSecondary;
            label1.Location = new Point(20, 358);
            label1.Text = "현재 상품 이름";

            // textBox1
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(20, 384);
            textBox1.Size = new Size(280, 32);
            textBox1.BorderStyle = BorderStyle.FixedSingle;

            // buttonAdd
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.BackColor = btnSuccess;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Font = new Font("Segoe UI Semibold", 10F);
            buttonAdd.Text = "➕ 상품 추가";
            buttonAdd.Size = new Size(140, 36);
            buttonAdd.Location = new Point(320, 382);
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.Click += buttonAdd_Click;

            // buttonPrev
            buttonPrev.FlatStyle = FlatStyle.Flat;
            buttonPrev.FlatAppearance.BorderSize = 1;
            buttonPrev.FlatAppearance.BorderColor = borderColor;
            buttonPrev.BackColor = cardBg;
            buttonPrev.ForeColor = textPrimary;
            buttonPrev.Font = new Font("Segoe UI Semibold", 10F);
            buttonPrev.Text = "◀ 이전";
            buttonPrev.Size = new Size(120, 36);
            buttonPrev.Location = new Point(20, 436);
            buttonPrev.Cursor = Cursors.Hand;
            buttonPrev.Click += buttonPrev_Click;

            // buttonNext
            buttonNext.FlatStyle = FlatStyle.Flat;
            buttonNext.FlatAppearance.BorderSize = 1;
            buttonNext.FlatAppearance.BorderColor = borderColor;
            buttonNext.BackColor = cardBg;
            buttonNext.ForeColor = textPrimary;
            buttonNext.Font = new Font("Segoe UI Semibold", 10F);
            buttonNext.Text = "다음 ▶";
            buttonNext.Size = new Size(120, 36);
            buttonNext.Location = new Point(154, 436);
            buttonNext.Cursor = Cursors.Hand;
            buttonNext.Click += buttonNext_Click;

            panelProducts.Controls.Add(labelSearch);
            panelProducts.Controls.Add(textBoxSearch);
            panelProducts.Controls.Add(dataGridView1);
            panelProducts.Controls.Add(label1);
            panelProducts.Controls.Add(textBox1);
            panelProducts.Controls.Add(buttonAdd);
            panelProducts.Controls.Add(buttonPrev);
            panelProducts.Controls.Add(buttonNext);

            // ════════════════════════════════════════
            // panelUser (right top card)
            // ════════════════════════════════════════
            panelUser.BackColor = cardBg;
            panelUser.Location = new Point(524, 80);
            panelUser.Size = new Size(310, 220);
            panelUser.Paint += (s, e) =>
            {
                var rect = panelUser.ClientRectangle;
                rect.Inflate(-1, -1);
                using var pen = new Pen(borderColor, 1);
                e.Graphics.DrawRectangle(pen, rect);
            };

            // labelUserSection
            labelUserSection.AutoSize = false;
            labelUserSection.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelUserSection.ForeColor = textPrimary;
            labelUserSection.Location = new Point(20, 14);
            labelUserSection.Size = new Size(270, 30);
            labelUserSection.Text = "\U0001F464 사용자 정보";

            // labelUserNameHint
            labelUserNameHint.AutoSize = true;
            labelUserNameHint.Font = new Font("Segoe UI", 9.5F);
            labelUserNameHint.ForeColor = textSecondary;
            labelUserNameHint.Location = new Point(20, 52);
            labelUserNameHint.Text = "이름";

            // textBoxUserName
            textBoxUserName.Font = new Font("Segoe UI", 11F);
            textBoxUserName.Location = new Point(20, 76);
            textBoxUserName.Size = new Size(270, 32);
            textBoxUserName.BorderStyle = BorderStyle.FixedSingle;

            // labelUserEmailHint
            labelUserEmailHint.AutoSize = true;
            labelUserEmailHint.Font = new Font("Segoe UI", 9.5F);
            labelUserEmailHint.ForeColor = textSecondary;
            labelUserEmailHint.Location = new Point(20, 116);
            labelUserEmailHint.Text = "이메일";

            // textBoxUserEmail
            textBoxUserEmail.Font = new Font("Segoe UI", 11F);
            textBoxUserEmail.Location = new Point(20, 140);
            textBoxUserEmail.Size = new Size(270, 32);
            textBoxUserEmail.BorderStyle = BorderStyle.FixedSingle;

            // labelUserName (바인딩으로 사용자 이름 표시)
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI Semibold", 10F);
            labelUserName.ForeColor = accentColor;
            labelUserName.Location = new Point(20, 184);
            labelUserName.Text = "";

            panelUser.Controls.Add(labelUserSection);
            panelUser.Controls.Add(labelUserNameHint);
            panelUser.Controls.Add(textBoxUserName);
            panelUser.Controls.Add(labelUserEmailHint);
            panelUser.Controls.Add(textBoxUserEmail);
            panelUser.Controls.Add(labelUserName);

            // ════════════════════════════════════════
            // panelWorker (right bottom card)
            // ════════════════════════════════════════
            panelWorker.BackColor = cardBg;
            panelWorker.Location = new Point(524, 316);
            panelWorker.Size = new Size(310, 200);
            panelWorker.Paint += (s, e) =>
            {
                var rect = panelWorker.ClientRectangle;
                rect.Inflate(-1, -1);
                using var pen = new Pen(borderColor, 1);
                e.Graphics.DrawRectangle(pen, rect);
            };

            // labelWorkerSection
            labelWorkerSection.AutoSize = false;
            labelWorkerSection.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelWorkerSection.ForeColor = textPrimary;
            labelWorkerSection.Location = new Point(20, 14);
            labelWorkerSection.Size = new Size(270, 30);
            labelWorkerSection.Text = "⚙️ 백그라운드 작업";

            // progressBar1
            progressBar1.Location = new Point(20, 56);
            progressBar1.Size = new Size(220, 24);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Style = ProgressBarStyle.Continuous;

            // labelProgress
            labelProgress.AutoSize = true;
            labelProgress.Font = new Font("Segoe UI Semibold", 11F);
            labelProgress.ForeColor = accentColor;
            labelProgress.Location = new Point(248, 54);
            labelProgress.Text = "0%";

            // buttonStartBackground
            buttonStartBackground.FlatStyle = FlatStyle.Flat;
            buttonStartBackground.FlatAppearance.BorderSize = 0;
            buttonStartBackground.BackColor = accentColor;
            buttonStartBackground.ForeColor = Color.White;
            buttonStartBackground.Font = new Font("Segoe UI Semibold", 10F);
            buttonStartBackground.Text = "▶ 스레드 시작";
            buttonStartBackground.Size = new Size(270, 38);
            buttonStartBackground.Location = new Point(20, 96);
            buttonStartBackground.Cursor = Cursors.Hand;
            buttonStartBackground.Click += button_Click;

            // buttonCancelBackground
            buttonCancelBackground.Enabled = false;
            buttonCancelBackground.FlatStyle = FlatStyle.Flat;
            buttonCancelBackground.FlatAppearance.BorderSize = 0;
            buttonCancelBackground.BackColor = Color.FromArgb(232, 65, 65);
            buttonCancelBackground.ForeColor = Color.White;
            buttonCancelBackground.Font = new Font("Segoe UI Semibold", 10F);
            buttonCancelBackground.Text = "⏹ 취소";
            buttonCancelBackground.Size = new Size(270, 38);
            buttonCancelBackground.Location = new Point(20, 146);
            buttonCancelBackground.Cursor = Cursors.Hand;
            buttonCancelBackground.Click += buttonCancelBackground_Click;

            panelWorker.Controls.Add(labelWorkerSection);
            panelWorker.Controls.Add(progressBar1);
            panelWorker.Controls.Add(labelProgress);
            panelWorker.Controls.Add(buttonStartBackground);
            panelWorker.Controls.Add(buttonCancelBackground);

            // ════════════════════════════════════════
            // buttonOpenCrud (bottom bar)
            // ════════════════════════════════════════
            buttonOpenCrud.FlatStyle = FlatStyle.Flat;
            buttonOpenCrud.FlatAppearance.BorderSize = 0;
            buttonOpenCrud.BackColor = accentColor;
            buttonOpenCrud.ForeColor = Color.White;
            buttonOpenCrud.Font = new Font("Segoe UI Semibold", 11F);
            buttonOpenCrud.Text = "\U0001F4E6  상품 DB 관리 열기";
            buttonOpenCrud.Size = new Size(810, 46);
            buttonOpenCrud.Location = new Point(24, 596);
            buttonOpenCrud.Cursor = Cursors.Hand;
            buttonOpenCrud.Click += buttonOpenCrud_Click;

            // ════════════════════════════════════════
            // Form1
            // ════════════════════════════════════════
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = formBg;
            ClientSize = new Size(860, 660);
            Controls.Add(panelHeader);
            Controls.Add(panelProducts);
            Controls.Add(panelUser);
            Controls.Add(panelWorker);
            Controls.Add(buttonOpenCrud);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "상품 관리 대시보드";
            Load += Form1_Load;

            panelHeader.ResumeLayout(false);
            panelProducts.ResumeLayout(false);
            panelProducts.PerformLayout();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            panelWorker.ResumeLayout(false);
            panelWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
