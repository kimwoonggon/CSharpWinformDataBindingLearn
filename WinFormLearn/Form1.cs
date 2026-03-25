using System.ComponentModel;
using System.Windows.Forms;
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
        private BindingList<Product> products;
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
            // 기존 코드: BindingList<Product> 직접 초기화
            // products = new BindingList<Product>
            // {
            //     new Product { Name = "사과" },
            //     new Product { Name = "바나나" },
            //     new Product { Name = "포도" }
            // };

            // 변경: 전체 원본 목록을 따로 보관하고 BindingList는 바인딩에 사용
            allProducts = new List<Product>
            {
                new Product { Name = "사과" },
                new Product { Name = "바나나" },
                new Product { Name = "포도" }
            };

            products = new BindingList<Product>(allProducts);

            // 간단한 User 초기 데이터
            user = new User { Name = "홍길동", Email = "hong@example.com" };
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

            // User 바인딩: 별도의 BindingSource를 사용하여 양방향 바인딩 설정
            userBindingSource.DataSource = user;

            textBoxUserName.DataBindings.Add(
                "Text",
                userBindingSource,
                nameof(User.Name),
                true,
                DataSourceUpdateMode.OnPropertyChanged
            );

            textBoxUserEmail.DataBindings.Add(
                "Text",
                userBindingSource,
                nameof(User.Email),
                true,
                DataSourceUpdateMode.OnPropertyChanged
            );

            // Label은 User.Name을 실시간으로 따라감
            labelUserName.DataBindings.Add(
                "Text",
                userBindingSource,
                nameof(User.Name),
                true,
                DataSourceUpdateMode.OnPropertyChanged
            );

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // 원본 목록과 바인딩 리스트에 항목 추가
            var newProduct = new Product { Name = $"새 상품 {allProducts.Count + 1}" };
            allProducts.Add(newProduct);
            products.Add(newProduct);

            // 새로 추가한 항목 선택
            // 만약 검색으로 bindingSource1.DataSource가 대체된 상태라면 전체 목록으로 되돌립니다.
            bindingSource1.DataSource = products;
            bindingSource1.Position = bindingSource1.Count - 1;
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
                ? allProducts.ToList()
                : allProducts.Where(p => p.Name != null && p.Name.Contains(keyword)).ToList();

            // 기존 바인딩을 유지하지 않고, 검색 결과로 새로운 BindingList를 바인딩
            bindingSource1.DataSource = new BindingList<Product>(result);
        }


    }
}
