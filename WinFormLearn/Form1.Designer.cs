namespace WinFormLearn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserEmail;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Button buttonStartBackground;

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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            buttonAdd = new Button();
            label1 = new Label();
            textBoxUserName = new TextBox();
            textBoxUserEmail = new TextBox();
            labelUserName = new Label();
            buttonPrev = new Button();
            buttonNext = new Button();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            labelProgress = new Label();
            buttonStartBackground = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.Size = new Size(300, 250);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(350, 110);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(180, 35);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "상품 추가";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 30);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "현재 상품 이름:";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(350, 170);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(180, 27);
            textBoxUserName.TabIndex = 5;
            // 
            // textBoxUserEmail
            // 
            textBoxUserEmail.Location = new Point(350, 205);
            textBoxUserEmail.Name = "textBoxUserEmail";
            textBoxUserEmail.Size = new Size(180, 27);
            textBoxUserEmail.TabIndex = 6;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(350, 150);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(92, 20);
            labelUserName.TabIndex = 4;
            labelUserName.Text = "사용자 이름:";
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new Point(350, 255);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(85, 30);
            buttonPrev.TabIndex = 7;
            buttonPrev.Text = "이전";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(445, 255);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(85, 30);
            buttonNext.TabIndex = 8;
            buttonNext.Text = "다음";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(20, 296);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(200, 27);
            textBoxSearch.TabIndex = 9;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(20, 273);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(39, 20);
            labelSearch.TabIndex = 12;
            labelSearch.Text = "검색";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(20, 330);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(300, 23);
            progressBar1.TabIndex = 13;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            // 
            // labelProgress
            // 
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(330, 330);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(60, 20);
            labelProgress.TabIndex = 14;
            labelProgress.Text = "0%";
            // 
            // buttonStartBackground
            // 
            buttonStartBackground.Location = new Point(330, 360);
            buttonStartBackground.Name = "buttonStartBackground";
            buttonStartBackground.Size = new Size(180, 30);
            buttonStartBackground.TabIndex = 15;
            buttonStartBackground.Text = "스레드 시작";
            buttonStartBackground.UseVisualStyleBackColor = true;
            buttonStartBackground.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdd);
            Controls.Add(buttonPrev);
            Controls.Add(buttonNext);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(textBox1);
            Controls.Add(textBoxUserEmail);
            Controls.Add(textBoxUserName);
            Controls.Add(labelUserName);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(progressBar1);
            Controls.Add(labelProgress);
            Controls.Add(buttonStartBackground);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
