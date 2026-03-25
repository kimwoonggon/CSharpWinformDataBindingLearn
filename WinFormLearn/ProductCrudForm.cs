using WinFormLearn.Dtos;
using WinFormLearn.Services;

namespace WinFormLearn
{
    public partial class ProductCrudForm : Form
    {
        private readonly ProductService _productService = new();
        private int? _selectedProductId = null;

        public ProductCrudForm()
        {
            InitializeComponent();
            _productService.EnsureDatabase();
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = _productService.GetAll();
            dataGridViewProducts.DataSource = products;

            if (dataGridViewProducts.Columns.Count > 0)
            {
                dataGridViewProducts.Columns[nameof(ProductDto.Id)].HeaderText = "ID";
                dataGridViewProducts.Columns[nameof(ProductDto.Id)].FillWeight = 15;
                dataGridViewProducts.Columns[nameof(ProductDto.Name)].HeaderText = "상품명";
                dataGridViewProducts.Columns[nameof(ProductDto.Name)].FillWeight = 50;
                dataGridViewProducts.Columns[nameof(ProductDto.Price)].HeaderText = "가격 (₩)";
                dataGridViewProducts.Columns[nameof(ProductDto.Price)].FillWeight = 35;
                dataGridViewProducts.Columns[nameof(ProductDto.Price)].DefaultCellStyle.Format = "N0";
                dataGridViewProducts.Columns[nameof(ProductDto.Price)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            labelStatus.Text = $"총 {products.Count}개 상품";
            ClearInputs();
        }

        private void ClearInputs()
        {
            _selectedProductId = null;
            textBoxName.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxName.Focus();
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("상품명을 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                return;
            }

            if (!decimal.TryParse(textBoxPrice.Text.Trim(), out var price) || price < 0)
            {
                MessageBox.Show("올바른 가격을 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPrice.Focus();
                return;
            }

            _productService.Add(new ProductDto { Name = name, Price = price });
            labelStatus.Text = $"'{name}' 상품이 추가되었습니다.";
            LoadProducts();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == null)
            {
                MessageBox.Show("수정할 상품을 선택하세요.", "선택 필요", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var name = textBoxName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("상품명을 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                return;
            }

            if (!decimal.TryParse(textBoxPrice.Text.Trim(), out var price) || price < 0)
            {
                MessageBox.Show("올바른 가격을 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPrice.Focus();
                return;
            }

            var updated = _productService.Update(new ProductDto
            {
                Id = _selectedProductId.Value,
                Name = name,
                Price = price
            });

            labelStatus.Text = updated
                ? $"'{name}' 상품이 수정되었습니다."
                : "수정에 실패했습니다.";

            LoadProducts();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == null)
            {
                MessageBox.Show("삭제할 상품을 선택하세요.", "선택 필요", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                $"'{textBoxName.Text}' 상품을 삭제하시겠습니까?",
                "삭제 확인",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            var deleted = _productService.Delete(_selectedProductId.Value);
            labelStatus.Text = deleted ? "상품이 삭제되었습니다." : "삭제에 실패했습니다.";
            LoadProducts();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            labelStatus.Text = "입력이 초기화되었습니다.";
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridViewProducts.Rows[e.RowIndex];
            _selectedProductId = Convert.ToInt32(row.Cells[nameof(ProductDto.Id)].Value);
            textBoxName.Text = row.Cells[nameof(ProductDto.Name)].Value?.ToString() ?? "";
            textBoxPrice.Text = row.Cells[nameof(ProductDto.Price)].Value?.ToString() ?? "";
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
            labelStatus.Text = $"ID {_selectedProductId} 선택됨";
        }
    }
}
