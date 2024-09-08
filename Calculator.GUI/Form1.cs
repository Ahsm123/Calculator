using CalcLib = Calculator.ClassLibrary;
namespace Calculator.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtBox1.Text);
                float number2 = float.Parse(txtBox2.Text);
                string operation = comboBoxOperation.SelectedItem.ToString();

                var _calculator = new CalcLib.Calculator();
                float result = PerformOperation(_calculator, number1, number2, operation);

                lblResult.Text = $"{result}";
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error parsing numbers: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}");
            }
        }

        private float PerformOperation(CalcLib.Calculator calculator, float number1, float number2, string operation)
        {
            return operation switch
            {
                "+" => calculator.Add(number1, number2),
                "-" => calculator.Subtract(number1, number2),
                "*" => calculator.Multiply(number1, number2),
                "/" => calculator.Divide(number1, number2),
                _ => throw new InvalidOperationException("Invalid operator")
            };
        }

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
