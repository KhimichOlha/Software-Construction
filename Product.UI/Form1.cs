using Product.Logic;

namespace Product.UI
{
    
    using ProductClass = Product.Logic.Product;

    public partial class MainForm : Form
    {
        private readonly Warehouse _warehouse;
        private readonly Reporting _reporting;
        public MainForm()
        {
            _warehouse = new Warehouse();
            _reporting = new Reporting(_warehouse);
            InitializeComponent();
        }



        private void btAddProduct_Click(object sender, EventArgs e)
        {
            string[] parts = tbPriceProduct.Text.Split(',');
            Logic.Money money = null;
            if (parts.Length == 2)
            {
                if (int.TryParse(parts[0], out int whole) && int.TryParse(parts[1], out int fraction))
                {
                    money = new Logic.Money(whole, fraction);
                }
            }
            ProductClass product = new ProductClass(tbNameProduct.Text, money, DateOnly.FromDateTime(dtDate.Value), tbunitOfMeasurement.Text);
            lbRegisterIncoming.Text += $"{_reporting.RegisterIncoming(product)}\n";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
