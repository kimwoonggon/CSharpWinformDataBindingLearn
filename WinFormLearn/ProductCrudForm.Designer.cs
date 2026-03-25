namespace WinFormLearn
{
    partial class ProductCrudForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelInput;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonClear;
        private DataGridView dataGridViewProducts;
        private Panel panelGrid;
        private Label labelStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            labelTitle = new Label();
            panelInput = new Panel();
            labelName = new Label();
            textBoxName = new TextBox();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            panelGrid = new Panel();
            dataGridViewProducts = new DataGridView();
            labelStatus = new Label();
            panelHeader.SuspendLayout();
            panelInput.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();

            // ── Colors ──
            var accentColor = Color.FromArgb(0, 120, 212);       // Modern blue
            var headerBg = Color.FromArgb(24, 24, 36);            // Dark header
            var formBg = Color.FromArgb(243, 243, 248);           // Light gray bg
            var cardBg = Color.White;
            var textPrimary = Color.FromArgb(30, 30, 30);
            var textSecondary = Color.FromArgb(100, 100, 100);
            var btnSuccess = Color.FromArgb(16, 163, 127);        // Green
            var btnWarning = Color.FromArgb(255, 163, 26);        // Orange
            var btnDanger = Color.FromArgb(232, 65, 65);          // Red
            var btnNeutral = Color.FromArgb(108, 117, 125);       // Gray

            // ── panelHeader ──
            panelHeader.BackColor = headerBg;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 60;
            panelHeader.Padding = new Padding(24, 0, 0, 0);
            panelHeader.Controls.Add(labelTitle);

            // ── labelTitle ──
            labelTitle.AutoSize = false;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Text = "\U0001F4E6  상품 관리";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;

            // ── panelInput (card) ──
            panelInput.BackColor = cardBg;
            panelInput.Location = new Point(24, 80);
            panelInput.Size = new Size(732, 160);
            panelInput.Padding = new Padding(20);
            // rounded feel via paint
            panelInput.Paint += (s, e) =>
            {
                var rect = panelInput.ClientRectangle;
                rect.Inflate(-1, -1);
                using var pen = new Pen(Color.FromArgb(220, 220, 225), 1);
                e.Graphics.DrawRectangle(pen, rect);
            };

            // ── labelName ──
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10F);
            labelName.ForeColor = textSecondary;
            labelName.Location = new Point(24, 20);
            labelName.Text = "상품명";

            // ── textBoxName ──
            textBoxName.Font = new Font("Segoe UI", 11F);
            textBoxName.Location = new Point(24, 46);
            textBoxName.Size = new Size(300, 32);
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.PlaceholderText = "상품 이름을 입력하세요";

            // ── labelPrice ──
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 10F);
            labelPrice.ForeColor = textSecondary;
            labelPrice.Location = new Point(340, 20);
            labelPrice.Text = "가격 (₩)";

            // ── textBoxPrice ──
            textBoxPrice.Font = new Font("Segoe UI", 11F);
            textBoxPrice.Location = new Point(340, 46);
            textBoxPrice.Size = new Size(200, 32);
            textBoxPrice.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrice.PlaceholderText = "0";

            // ── Buttons ──
            var btnY = 100;
            var btnH = 38;
            var btnFont = new Font("Segoe UI Semibold", 10F);

            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.BackColor = btnSuccess;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Font = btnFont;
            buttonAdd.Text = "➕ 추가";
            buttonAdd.Size = new Size(110, btnH);
            buttonAdd.Location = new Point(24, btnY);
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.Click += buttonAdd_Click;

            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.BackColor = btnWarning;
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Font = btnFont;
            buttonUpdate.Text = "✏️ 수정";
            buttonUpdate.Size = new Size(110, btnH);
            buttonUpdate.Location = new Point(144, btnY);
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.Click += buttonUpdate_Click;

            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.BackColor = btnDanger;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Font = btnFont;
            buttonDelete.Text = "🗑️ 삭제";
            buttonDelete.Size = new Size(110, btnH);
            buttonDelete.Location = new Point(264, btnY);
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.Click += buttonDelete_Click;

            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.BackColor = btnNeutral;
            buttonClear.ForeColor = Color.White;
            buttonClear.Font = btnFont;
            buttonClear.Text = "🔄 초기화";
            buttonClear.Size = new Size(110, btnH);
            buttonClear.Location = new Point(384, btnY);
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.Click += buttonClear_Click;

            panelInput.Controls.Add(labelName);
            panelInput.Controls.Add(textBoxName);
            panelInput.Controls.Add(labelPrice);
            panelInput.Controls.Add(textBoxPrice);
            panelInput.Controls.Add(buttonAdd);
            panelInput.Controls.Add(buttonUpdate);
            panelInput.Controls.Add(buttonDelete);
            panelInput.Controls.Add(buttonClear);

            // ── panelGrid (card) ──
            panelGrid.BackColor = cardBg;
            panelGrid.Location = new Point(24, 256);
            panelGrid.Size = new Size(732, 310);
            panelGrid.Padding = new Padding(1);
            panelGrid.Paint += (s, e) =>
            {
                var rect = panelGrid.ClientRectangle;
                rect.Inflate(-1, -1);
                using var pen = new Pen(Color.FromArgb(220, 220, 225), 1);
                e.Graphics.DrawRectangle(pen, rect);
            };

            // ── dataGridViewProducts ──
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewProducts.GridColor = Color.FromArgb(235, 235, 240);
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor = textSecondary;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.SelectionForeColor = textSecondary;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 6, 8, 6);
            dataGridViewProducts.ColumnHeadersHeight = 42;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewProducts.EnableHeadersVisualStyles = false;
            dataGridViewProducts.DefaultCellStyle.BackColor = Color.White;
            dataGridViewProducts.DefaultCellStyle.ForeColor = textPrimary;
            dataGridViewProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 240, 254);
            dataGridViewProducts.DefaultCellStyle.SelectionForeColor = textPrimary;
            dataGridViewProducts.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dataGridViewProducts.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            dataGridViewProducts.RowTemplate.Height = 38;
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;

            panelGrid.Controls.Add(dataGridViewProducts);

            // ── labelStatus ──
            labelStatus.AutoSize = false;
            labelStatus.Dock = DockStyle.Bottom;
            labelStatus.Height = 32;
            labelStatus.BackColor = Color.FromArgb(248, 249, 250);
            labelStatus.ForeColor = textSecondary;
            labelStatus.Font = new Font("Segoe UI", 9F);
            labelStatus.TextAlign = ContentAlignment.MiddleLeft;
            labelStatus.Padding = new Padding(24, 0, 0, 0);
            labelStatus.Text = "준비";

            // ── Form ──
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = formBg;
            ClientSize = new Size(780, 600);
            Controls.Add(panelHeader);
            Controls.Add(panelInput);
            Controls.Add(panelGrid);
            Controls.Add(labelStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductCrudForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "상품 관리";

            panelHeader.ResumeLayout(false);
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
        }
    }
}
