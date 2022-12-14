// ---- C# II (Dor Ben Dor) ----
//          Roee Tal
// -----------------------------
namespace DelegatesForms
{
    public partial class Form1 : Form
    {
        public Func<float, float, float> DoMath;
        public Form1()
        {
            InitializeComponent();
        }
        private float Add(float num1, float num2)
        {
            return num1 + num2;
        }
        private float Substract(float num1, float num2)
        {
            return num1 - num2;
      
        }
        private float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
        private float Percentage(float num1, float num2)
        {
            return (num1/num2) * 100;
        }
        private float Multiply(float num1,float num2)
        {
            return num1 * num2;
        }
        private float Power(float num, float power)
        {
            float value = 0;
            for (int i = 0; i < power; i++)
            {
                value += (num * num);
            }
            return value;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) DoMath = Add; 
            if (comboBox1.SelectedIndex == 1) DoMath = Substract;  
            if (comboBox1.SelectedIndex == 2) DoMath = Multiply; 
            if (comboBox1.SelectedIndex == 3) DoMath = Power;
            if (comboBox1.SelectedIndex == 4) DoMath = Divide;
            if (comboBox1.SelectedIndex == 5) DoMath = Percentage;
            else label2.Text = "Error, didn't choose Action";


            if (textBox1.Text != "" && textBox2.Text != "")
            {
                //if (float.Parse(textBox1.Text).GetType() == typeof(float) && float.Parse(textBox2.Text).GetType() == typeof(float))
                //{
                //}
                //else
                //{
                //    label2.Text = "Error, please use Numbers";
                //}
                    float userNam1 = float.Parse(textBox1.Text);
                    float userNam2 = float.Parse(textBox2.Text);
                    label2.Text = DoMath(userNam1, userNam2).ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}