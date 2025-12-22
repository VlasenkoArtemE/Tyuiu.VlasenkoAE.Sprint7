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

        static int rows;
        static int columns;
        static string openFilePath;

        public static int[,] LoadFromFileData(string filePath)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSaveData_VAE_Click(object sender, EventArgs e)
        {

        }

        private void buttonPriceHistogram_VAE_Click(object sender, EventArgs e)
        {

        }

        private void dataGridInPut_VAE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLoadData_VAE_Click(object sender, EventArgs e)
        {
            openFileDialogData_VAE.ShowDialog();
            openFilePath = openFileDialogData_VAE.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_VAE.ColumnCount = columns;
            dataGridViewInPut_VAE.RowCount = rows;
            dataGridViewOutPut_VAE.ColumnCount = columns;
            dataGridViewOutPut_VAE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_VAE.Columns[i].Width = 100;
                dataGridViewOutPut_VAE.Columns[i].Width = 100;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_VAE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveData_VAE.Enabled = true;
            buttonMaxPrice_VAE.Enabled = true;
            buttonMinPrice_VAE.Enabled = true;
            buttonPriceHistogram_VAE.Enabled = true;
        }
    }
}
