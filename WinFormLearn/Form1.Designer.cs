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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserEmail = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            // 컨트롤 속성 많이 바꿀 테니까 그떄마다 레이아웃 계산하지 말고 좀 멈춰
            SuspendLayout();

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(300, 250);
            this.dataGridView1.TabIndex = 0;


            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "현재 상품 이름:";

            // labelUserName
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(350, 150);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(80, 12);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "사용자 이름:";

            // textBox1
            this.textBox1.Location = new System.Drawing.Point(350, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 21);
            this.textBox1.TabIndex = 2;

            // textBoxUserName
            this.textBoxUserName.Location = new System.Drawing.Point(350, 170);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(180, 21);
            this.textBoxUserName.TabIndex = 5;

            // textBoxUserEmail
            this.textBoxUserEmail.Location = new System.Drawing.Point(350, 205);
            this.textBoxUserEmail.Name = "textBoxUserEmail";
            this.textBoxUserEmail.Size = new System.Drawing.Size(180, 21);
            this.textBoxUserEmail.TabIndex = 6;

            // buttonPrev
            this.buttonPrev.Location = new System.Drawing.Point(350, 255);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(85, 30);
            this.buttonPrev.TabIndex = 7;
            this.buttonPrev.Text = "이전";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);

            // buttonNext
            this.buttonNext.Location = new System.Drawing.Point(445, 255);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(85, 30);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "다음";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);

            // buttonAdd
            this.buttonAdd.Location = new System.Drawing.Point(350, 110);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(180, 35);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "상품 추가";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxUserEmail);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);

            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            // 즉시계산하지말고 performlayout에서 계산
            ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
