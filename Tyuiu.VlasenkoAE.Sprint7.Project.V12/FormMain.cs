using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.VlasenkoAE.Sprint7.Project.V12.Lib;
using System.IO;

namespace Tyuiu.VlasenkoAE.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogData_VAE.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogData_VAE.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        private int rows;
        private int columns;
        private string openFilePath;

        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(";").Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonLoadData_VAE_Click(object sender, EventArgs e)
        {
            openFileDialogData_VAE.ShowDialog();
            openFilePath = openFileDialogData_VAE.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_VAE.ColumnCount = columns;
            dataGridViewInPut_VAE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_VAE.Columns[i].Width = 100;
                dataGridViewInPut_VAE.Columns[0].Width = 100;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_VAE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            foreach (DataGridViewColumn column in dataGridViewInPut_VAE.Columns)
            {
                column.ValueType = typeof(int);
            }

            buttonDeleteRow_VAE.Enabled = true;
            buttonMaxPrice_VAE.Enabled = true;
            buttonMinPrice_VAE.Enabled = true;
            buttonPriceHistogram_VAE.Enabled = true;
            buttonSaveData_VAE.Enabled = true;
        }

        private int[,] GetDataFromGridView()
        {
            int rowCount = dataGridViewInPut_VAE.Rows.Count;
            int colCount = dataGridViewInPut_VAE.Columns.Count;

            int[,] arrayValues = new int[rowCount, colCount];

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < colCount; c++)
                {
                    var cellValue = dataGridViewInPut_VAE.Rows[r].Cells[c].Value;
                    if (cellValue != null && int.TryParse(cellValue.ToString(), out int value))
                    {
                        arrayValues[r, c] = value;
                    }
                    else
                    {
                        arrayValues[r, c] = 0;
                    }
                }
            }
            return arrayValues;
        }

        private void buttonGuide_VAE_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void buttonInfo_VAE_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void buttonLoadData_VAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Открыть файл";
        }

        private void buttonSaveData_VAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Сохранить файл";
        }

        private void buttonGuide_VAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Руководство пользователя";
        }

        private void buttonInfo_VAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "О программе";
        }

        private void buttonMaxPrice_VAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Максимальная цена";
        }

        private void buttonMinPrice_VAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Минимальная цена";
        }

        private void buttonPriceHistogram_VAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Гистограмма цен";
        }

        private void buttonMaxPrice_VAE_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = GetDataFromGridView();

            int value = 0;
            value = ds.GetMaxPrice(arrayValues);

            textBoxResult_VAE.Text = value.ToString();
        }

        private void buttonMinPrice_VAE_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = GetDataFromGridView();

            int value = 0;
            value = ds.GetMinPrice(arrayValues);

            textBoxResult_VAE.Text = value.ToString();
        }

        private void buttonPriceHistogram_VAE_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = GetDataFromGridView();

            chartResult_VAE.Series.Clear();
            chartResult_VAE.Titles.Clear();
            chartResult_VAE.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainArea");
            chartResult_VAE.ChartAreas.Add(chartArea);

            chartResult_VAE.Titles.Add("Гистограмма цен");

            Series series = new Series("Цены");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.Color = Color.Blue;

            int rows = arrayValues.GetLength(0);
            int priceColumn = 4;

            for (int i = 0; i < rows; i++)
            {
                int price = arrayValues[i, priceColumn];
                DataPoint point = new DataPoint();                // Для отображения каждого столбца отдельно
                point.SetValueXY(i, price);                       // Указываем индекс как X значение
                point.AxisLabel = $"Проц. {arrayValues[i, 0]}";   // Отдельно задаём подпись
                point.Label = price.ToString();                   // Значение над столбцом
                series.Points.Add(point);
            }

            chartResult_VAE.Series.Add(series);

            chartResult_VAE.ChartAreas[0].AxisX.Title = "Процессоры";
            chartResult_VAE.ChartAreas[0].AxisY.Title = "Цена";
            chartResult_VAE.ChartAreas[0].AxisX.Interval = 1;
            chartResult_VAE.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chartResult_VAE.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chartResult_VAE.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

            chartResult_VAE.ChartAreas[0].RecalculateAxesScale();
        }

        private void buttonAddRow_VAE_Click(object sender, EventArgs e)
        {
            dataGridViewInPut_VAE.Rows.Add(new object[dataGridViewInPut_VAE.Columns.Count]);
        }

        private void buttonDeleteRow_VAE_Click(object sender, EventArgs e)
        {
            if (dataGridViewInPut_VAE.Rows.Count > 1)
            {
                int lastIndex = dataGridViewInPut_VAE.Rows.Count - 1;

                if (lastIndex >= 0)   // Проверяем, что индекс валидный
                {
                    dataGridViewInPut_VAE.Rows.RemoveAt(lastIndex);
                }
            }
        }

        private void buttonAddRow_VAE_MouseHover(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Добавить строку";
        }

        private void buttonDeleteRow_VAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Удалить строку";
        }
    }
}
