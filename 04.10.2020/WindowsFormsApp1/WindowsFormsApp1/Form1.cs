using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int n = 0;
        int m = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = int.Parse(nBox.Text);
            m = int.Parse(mBox.Text);

            grid.RowCount = n;
            grid.ColumnCount = m;

            var ran = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    grid.Rows[i].Cells[j].Value = ran.Next(-20, 21);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var k = int.Parse(kBox.Text) - 1;

            n = grid.RowCount;
            m = grid.ColumnCount;

            var arr = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(grid.Rows[i].Cells[j].Value);
                }
            }

            m -= 1;

            grid.RowCount = n;
            grid.ColumnCount = m;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j < k)
                    {
                        grid.Rows[i].Cells[j].Value = arr[i, j];
                    }
                    else
                    {
                        grid.Rows[i].Cells[j].Value = arr[i, j + 1];
                    }
                }
            }
        }
    }
}
