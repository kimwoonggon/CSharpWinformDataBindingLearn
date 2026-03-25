using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormLearn
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource userBindingSource = new BindingSource();
        private User user = null!;
        private List<Product> allProducts = new List<Product>(); // 원본 전체 목록 보관 (검색용)
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

            textBoxSearch_TextChanged(textBoxSearch, EventArgs.Empty);
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
            if (backgroundWorker1 != null && !backgroundWorker1.IsBusy)
            {
                progressBar1.Value = 0;
                labelProgress.Text = "0%";
                buttonStartBackground.Enabled = false;
                buttonCancelBackground.Enabled = true;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void buttonCancelBackground_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1 != null && backgroundWorker1.IsBusy && backgroundWorker1.WorkerSupportsCancellation)
            {
                backgroundWorker1.CancelAsync();
                buttonCancelBackground.Enabled = false;
                labelProgress.Text = "취소 요청 중...";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            long total = 0;
            var partialResults = new List<long>();

            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);

                long partial = 0;
                for (int j = 1; j <= 50000; j++)
                {
                    partial += (long)i * j;
                }

                partialResults.Add(partial);
                total += partial;

                if (worker != null && worker.WorkerSupportsCancellation && worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                worker?.ReportProgress(i * 10);
            }

            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine("복잡한 계산이 완료되었습니다.");
            resultBuilder.AppendLine($"총합: {total:N0}");
            resultBuilder.AppendLine();
            resultBuilder.AppendLine("구간별 계산 결과:");

            for (int i = 0; i < partialResults.Count; i++)
            {
                resultBuilder.AppendLine($"단계 {i + 1}: {partialResults[i]:N0}");
            }

            e.Result = resultBuilder.ToString();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Runs on UI thread
            if (progressBar1 != null)
                progressBar1.Value = Math.Max(progressBar1.Minimum, Math.Min(progressBar1.Maximum, e.ProgressPercentage));

            if (labelProgress != null)
                labelProgress.Text = $"{e.ProgressPercentage}%";
        }

        private void buttonOpenCrud_Click(object sender, EventArgs e)
        {
            using var crudForm = new ProductCrudForm();
            crudForm.ShowDialog(this);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonStartBackground.Enabled = true;
            buttonCancelBackground.Enabled = false;
            progressBar1.Value = e.Cancelled || e.Error != null ? 0 : progressBar1.Maximum;

            if (e.Cancelled)
            {
                MessageBox.Show("백그라운드 작업이 취소되었습니다!");
                return;
            }

            if (e.Error != null)
            {
                MessageBox.Show($"작업 중 오류가 발생했습니다: {e.Error.Message}");
                return;
            }

            var resultMessage = e.Result as string ?? "계산 결과를 가져오지 못했습니다.";
            MessageBox.Show(resultMessage, "계산 결과", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
