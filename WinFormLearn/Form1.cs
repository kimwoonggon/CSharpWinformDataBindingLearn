using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormLearn
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private BindingList<Product> products;
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
            products = new BindingList<Product>
            {
                new Product { Name = "사과" },
                new Product { Name = "바나나" },
                new Product { Name = "포도" }
            };
        }

        private void InitializeBinding()
        {

            // BindingSource가 실제 목록 관리
            bindingSource1.DataSource = products;


            // DataGridView는 목록 전체 표시
            dataGridView1.DataSource = bindingSource1;


            // TextBox는 현재 선택된 항목의 Name과 연결
            textBox1.DataBindings.Add(
                "Text",
                bindingSource1,
                nameof(Product.Name),
                true,
                DataSourceUpdateMode.OnPropertyChanged
            );

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            products.Add(new Product { Name = $"새 상품 {products.Count + 1}" });

            // 새로 추가한 항목 선택
            bindingSource1.Position = bindingSource1.Count - 1;
        }


    }
}
