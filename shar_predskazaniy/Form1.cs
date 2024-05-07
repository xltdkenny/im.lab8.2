using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shar_predskazaniy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AddDataToDataGridView();
        }

        private void AddDataToDataGridView()
        {
            // Добавление строк с данными
            string[] row0 = { "Все будет отлично", "0,20" };
            string[] row1 = { "Все будет хорошо", "0,20" };
            string[] row2 = { "Все будет неплохо", "0,10" };
            string[] row3 = { "Все будет плохо", "0,10" };
            string[] row4 = { "Все будет отвратительно", "0,25" };
            string[] row5 = { "Все будет ужасно отвратительно", "0,15" };

            probabilitiesDataGridView.Rows.Add(row0);
            probabilitiesDataGridView.Rows.Add(row1);
            probabilitiesDataGridView.Rows.Add(row2);
            probabilitiesDataGridView.Rows.Add(row3);
            probabilitiesDataGridView.Rows.Add(row4);
            probabilitiesDataGridView.Rows.Add(row5);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            List<double> probabilities = new List<double>();
            double sum = 0;

            // Считываем вероятности из DataGridView и проверяем их корректность
            foreach (DataGridViewRow row in probabilitiesDataGridView.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    double p = Convert.ToDouble(row.Cells[1].Value);
                    if (p < 0 || p > 1)
                    {
                        MessageBox.Show("Вероятности должны быть в диапазоне от 0 до 1");
                        return;
                    }
                    probabilities.Add(p);
                    sum += p;
                }
            }

            // Проверяем, что сумма вероятностей равна 1
            if (Math.Abs(sum - 1.0) > 0.01) // небольшой допуск на погрешность
            {
                MessageBox.Show("Сумма вероятностей должна быть равна 1");
                return;
            }

            // Генерация случайного числа и определение события
            Random rand = new Random();
            double r = rand.NextDouble();
            double cumulative = 0;
            for (int i = 0; i < probabilities.Count; i++)
            {
                cumulative += probabilities[i];
                if (r <= cumulative)
                {
                    resultTextBox.Text = "Произошло событие: " + probabilitiesDataGridView.Rows[i].Cells[0].Value.ToString();
                    break;
                }
            }
        }
    }
}
