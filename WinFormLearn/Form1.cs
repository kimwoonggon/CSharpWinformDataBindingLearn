using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormLearn
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource userBindingSource = new BindingSource();
        private User user;
        private List<Product> products;
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
            products = new List<Product>
            {
                new Product { Name = "사과" },
                new Product { Name = "바나나" },
                new Product { Name = "포도" }
            };

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
            products.Add(new Product { Name = $"새 상품 {products.Count + 1}" });

            // 새로 추가한 항목 선택
            // List는 변경 알림이 자동으로 가지 않으므로 바인딩을 갱신
            bindingSource1.ResetBindings(false);
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


    }
}
