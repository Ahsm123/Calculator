using Calculator.ClassLibrary;
namespace Calculator.GUI
{
    public partial class Form1 : Form
    {
        private CalculatorLogic _calculator;
        private float _operand1;
        private float _operand2;
        private string _operator;

        public Form1()
        {
            InitializeComponent();
            _calculator = new CalculatorLogic();
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (txtboxDisplay.Text != string.Empty)
            {
                _operand1 = float.Parse(txtboxDisplay.Text);
                Button btn = sender as Button;
                _operator = btn.Text;
                txtboxDisplay.Clear();

            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                if (button.Text == ".")
                {
                    if (!txtboxDisplay.Text.Contains("."))
                    {
                        txtboxDisplay.Text += ",";
                    }
                }
                else
                {
                    txtboxDisplay.Text += button.Text;
                }

                txtboxDisplay.Refresh();
            }
        }



        private void btbClear_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Clear();
            _operand1 = 0;
            _operand2 = 0;
            _operator = string.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            _operand2 = float.Parse(txtboxDisplay.Text);

            float result = 0;

            switch (_operator)
            {
                case "+":
                    result = _calculator.Add(_operand1, _operand2);
                    break;
                case "-":
                    result = _calculator.Subtract(_operand1, _operand2);
                    break;
                case "*":
                    result = _calculator.Multiply(_operand1, _operand2);
                    break;
                case "/":
                    if (_operand2 != 0)
                    {
                        result = _calculator.Divide(_operand1, _operand2);
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("Invalid operator");
                    break;
            }
            txtboxDisplay.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
