using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace test_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 f2;
        private void button1_Click(object sender, EventArgs e)
        {
            var person = new Person
            {
                Name = textBox1.Text,
                Namber = maskedTextBox1.Text,
                Pasport = maskedTextBox2.Text
            };
            string jsonString = JsonConvert.SerializeObject(person);
            //var person2 = JsonConvert.DeserializeObject<Person>(jsonString);

            File.AppendAllText("input.json", jsonString);

            MessageBox.Show("Запись добавлена");
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }
        
    }
}
