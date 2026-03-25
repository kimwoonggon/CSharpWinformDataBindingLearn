using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormLearn
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource userBindingSource = new BindingSource();
        private User user;
        private List<Product> allProducts; // 원본 전체 목록 보관 (검색용)
        public Form1()
        {
            InitializeComponent();
            InitializeData();
            InitializeBinding();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializeData()
        {
            allProducts = new List<Product>
    {
        new Product { Name = "사과" },
        new Product { Name = "바나나" },
        new Product { Name = "포도" }
    };

            user = new User { Name = "홍길동", Email = "hong@example.com" };
        }

        private void InitializeBinding()
        {
            RefreshView(allProducts);
            dataGridView1.DataSource = bindingSource1;

            textBox1.DataBindings.Add(
                "Text",
                bindingSource1,
                nameof(Product.Name),
                true,
                DataSourceUpdateMode.OnPropertyChanged
            );

            userBindingSource.DataSource = user;

            textBoxUserName.DataBindings.Add("Text", userBindingSource, nameof(User.Name), true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxUserEmail.DataBindings.Add("Text", userBindingSource, nameof(User.Email), true, DataSourceUpdateMode.OnPropertyChanged);
            labelUserName.DataBindings.Add("Text", userBindingSource, nameof(User.Name), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var newProduct = new Product { Name = $"새 상품 {allProducts.Count + 1}" };
            allProducts.Add(newProduct);

            textBoxSearch_TextChanged(null, EventArgs.Empty);
            bindingSource1.Position = bindingSource1.Count - 1;
        }

        private void RefreshView(IEnumerable<Product> items)
        {
            bindingSource1.DataSource = new BindingList<Product>(items.ToList());
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            // 이전 항목으로 이동
            if (bindingSource1.Position > 0)
                bindingSource1.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // 다음 항목으로 이동
            if (bindingSource1.Position < bindingSource1.Count - 1)
                bindingSource1.MoveNext();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var keyword = textBoxSearch.Text.Trim();

            var result = string.IsNullOrEmpty(keyword)
                ? allProducts
                : allProducts.Where(p => p.Name != null && p.Name.Contains(keyword));

            RefreshView(result);
        }

        private void button_Click(object sender, EventArgs e)
        {
            // Start background work when button is clicked
            if (backgroundWorker1 != null && !backgroundWorker1.IsBusy)
            {
                progressBar1.Value = 0;
                labelProgress.Text = "0%";
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Runs on background thread
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Runs on UI thread
            if (progressBar1 != null)
                progressBar1.Value = Math.Max(progressBar1.Minimum, Math.Min(progressBar1.Maximum, e.ProgressPercentage));

            if (labelProgress != null)
                labelProgress.Text = $"{e.ProgressPercentage}%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("백그라운드 작업이 완료되었습니다!");
        }

    }
}
