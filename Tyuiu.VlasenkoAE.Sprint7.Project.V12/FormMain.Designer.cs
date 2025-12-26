namespace Tyuiu.VlasenkoAE.Sprint7.Project.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelButtons_VAE = new Panel();
            groupBoxInfoButtons_VAE = new GroupBox();
            buttonInfo_VAE = new Button();
            buttonGuide_VAE = new Button();
            groupBoxInsrtumentButtons_VAE = new GroupBox();
            buttonDeleteRow_VAE = new Button();
            buttonAddRow_VAE = new Button();
            buttonSaveData_VAE = new Button();
            buttonLoadData_VAE = new Button();
            splitContainerInOutPutData_VAE = new SplitContainer();
            groupBoxData_VAE = new GroupBox();
            dataGridViewInPut_VAE = new DataGridView();
            groupBoxWorkData_VAE = new GroupBox();
            chartResult_VAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxResult_VAE = new TextBox();
            buttonPriceHistogram_VAE = new Button();
            buttonMaxPrice_VAE = new Button();
            buttonMinPrice_VAE = new Button();
            openFileDialogData_VAE = new OpenFileDialog();
            saveFileDialogData_VAE = new SaveFileDialog();
            toolTipButtons = new ToolTip(components);
            panelButtons_VAE.SuspendLayout();
            groupBoxInfoButtons_VAE.SuspendLayout();
            groupBoxInsrtumentButtons_VAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerInOutPutData_VAE).BeginInit();
            splitContainerInOutPutData_VAE.Panel1.SuspendLayout();
            splitContainerInOutPutData_VAE.Panel2.SuspendLayout();
            splitContainerInOutPutData_VAE.SuspendLayout();
            groupBoxData_VAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_VAE).BeginInit();
            groupBoxWorkData_VAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_VAE).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_VAE
            // 
            panelButtons_VAE.Controls.Add(groupBoxInfoButtons_VAE);
            panelButtons_VAE.Controls.Add(groupBoxInsrtumentButtons_VAE);
            panelButtons_VAE.Dock = DockStyle.Left;
            panelButtons_VAE.Location = new Point(0, 0);
            panelButtons_VAE.Name = "panelButtons_VAE";
            panelButtons_VAE.Size = new Size(190, 784);
            panelButtons_VAE.TabIndex = 0;
            // 
            // groupBoxInfoButtons_VAE
            // 
            groupBoxInfoButtons_VAE.Controls.Add(buttonInfo_VAE);
            groupBoxInfoButtons_VAE.Controls.Add(buttonGuide_VAE);
            groupBoxInfoButtons_VAE.Dock = DockStyle.Bottom;
            groupBoxInfoButtons_VAE.Location = new Point(0, 527);
            groupBoxInfoButtons_VAE.Name = "groupBoxInfoButtons_VAE";
            groupBoxInfoButtons_VAE.Size = new Size(190, 257);
            groupBoxInfoButtons_VAE.TabIndex = 1;
            groupBoxInfoButtons_VAE.TabStop = false;
            groupBoxInfoButtons_VAE.Text = "Справочные данные";
            // 
            // buttonInfo_VAE
            // 
            buttonInfo_VAE.Image = (Image)resources.GetObject("buttonInfo_VAE.Image");
            buttonInfo_VAE.Location = new Point(10, 147);
            buttonInfo_VAE.Name = "buttonInfo_VAE";
            buttonInfo_VAE.Size = new Size(169, 98);
            buttonInfo_VAE.TabIndex = 1;
            toolTipButtons.SetToolTip(buttonInfo_VAE, "О разработчике программы");
            buttonInfo_VAE.UseVisualStyleBackColor = true;
            buttonInfo_VAE.Click += buttonInfo_VAE_Click;
            buttonInfo_VAE.MouseEnter += buttonInfo_VAE_MouseEnter;
            // 
            // buttonGuide_VAE
            // 
            buttonGuide_VAE.Image = (Image)resources.GetObject("buttonGuide_VAE.Image");
            buttonGuide_VAE.Location = new Point(10, 26);
            buttonGuide_VAE.Name = "buttonGuide_VAE";
            buttonGuide_VAE.Size = new Size(169, 99);
            buttonGuide_VAE.TabIndex = 0;
            toolTipButtons.SetToolTip(buttonGuide_VAE, "Краткое руководство по работе с программой");
            buttonGuide_VAE.UseVisualStyleBackColor = true;
            buttonGuide_VAE.Click += buttonGuide_VAE_Click;
            buttonGuide_VAE.MouseEnter += buttonGuide_VAE_MouseEnter;
            // 
            // groupBoxInsrtumentButtons_VAE
            // 
            groupBoxInsrtumentButtons_VAE.Controls.Add(buttonDeleteRow_VAE);
            groupBoxInsrtumentButtons_VAE.Controls.Add(buttonAddRow_VAE);
            groupBoxInsrtumentButtons_VAE.Controls.Add(buttonSaveData_VAE);
            groupBoxInsrtumentButtons_VAE.Controls.Add(buttonLoadData_VAE);
            groupBoxInsrtumentButtons_VAE.Dock = DockStyle.Fill;
            groupBoxInsrtumentButtons_VAE.Location = new Point(0, 0);
            groupBoxInsrtumentButtons_VAE.Name = "groupBoxInsrtumentButtons_VAE";
            groupBoxInsrtumentButtons_VAE.Size = new Size(190, 784);
            groupBoxInsrtumentButtons_VAE.TabIndex = 0;
            groupBoxInsrtumentButtons_VAE.TabStop = false;
            groupBoxInsrtumentButtons_VAE.Text = "Панель инструментов";
            // 
            // buttonDeleteRow_VAE
            // 
            buttonDeleteRow_VAE.Enabled = false;
            buttonDeleteRow_VAE.Image = (Image)resources.GetObject("buttonDeleteRow_VAE.Image");
            buttonDeleteRow_VAE.Location = new Point(10, 267);
            buttonDeleteRow_VAE.Name = "buttonDeleteRow_VAE";
            buttonDeleteRow_VAE.Size = new Size(169, 99);
            buttonDeleteRow_VAE.TabIndex = 3;
            toolTipButtons.SetToolTip(buttonDeleteRow_VAE, "Удалить последнюю строку");
            buttonDeleteRow_VAE.UseVisualStyleBackColor = true;
            buttonDeleteRow_VAE.Click += buttonDeleteRow_VAE_Click;
            buttonDeleteRow_VAE.MouseEnter += buttonDeleteRow_VAE_MouseEnter;
            // 
            // buttonAddRow_VAE
            // 
            buttonAddRow_VAE.Image = (Image)resources.GetObject("buttonAddRow_VAE.Image");
            buttonAddRow_VAE.Location = new Point(10, 152);
            buttonAddRow_VAE.Name = "buttonAddRow_VAE";
            buttonAddRow_VAE.Size = new Size(169, 99);
            buttonAddRow_VAE.TabIndex = 2;
            toolTipButtons.SetToolTip(buttonAddRow_VAE, "Добавить новую пустую строку");
            buttonAddRow_VAE.UseVisualStyleBackColor = true;
            buttonAddRow_VAE.Click += buttonAddRow_VAE_Click;
            buttonAddRow_VAE.MouseHover += buttonAddRow_VAE_MouseHover;
            // 
            // buttonSaveData_VAE
            // 
            buttonSaveData_VAE.Enabled = false;
            buttonSaveData_VAE.Image = (Image)resources.GetObject("buttonSaveData_VAE.Image");
            buttonSaveData_VAE.Location = new Point(10, 385);
            buttonSaveData_VAE.Name = "buttonSaveData_VAE";
            buttonSaveData_VAE.Size = new Size(169, 99);
            buttonSaveData_VAE.TabIndex = 1;
            toolTipButtons.SetToolTip(buttonSaveData_VAE, "Сохранить файл в формате CSV");
            buttonSaveData_VAE.UseVisualStyleBackColor = true;
            buttonSaveData_VAE.Click += buttonSaveData_VAE_Click;
            buttonSaveData_VAE.MouseEnter += buttonSaveData_VAE_MouseEnter;
            // 
            // buttonLoadData_VAE
            // 
            buttonLoadData_VAE.Image = (Image)resources.GetObject("buttonLoadData_VAE.Image");
            buttonLoadData_VAE.Location = new Point(10, 36);
            buttonLoadData_VAE.Name = "buttonLoadData_VAE";
            buttonLoadData_VAE.Size = new Size(169, 99);
            buttonLoadData_VAE.TabIndex = 0;
            toolTipButtons.SetToolTip(buttonLoadData_VAE, "Открыть файл для обработки данных в фомате CSV");
            buttonLoadData_VAE.UseVisualStyleBackColor = true;
            buttonLoadData_VAE.Click += buttonLoadData_VAE_Click;
            buttonLoadData_VAE.MouseEnter += buttonLoadData_VAE_MouseEnter;
            // 
            // splitContainerInOutPutData_VAE
            // 
            splitContainerInOutPutData_VAE.Dock = DockStyle.Fill;
            splitContainerInOutPutData_VAE.Location = new Point(190, 0);
            splitContainerInOutPutData_VAE.Name = "splitContainerInOutPutData_VAE";
            // 
            // splitContainerInOutPutData_VAE.Panel1
            // 
            splitContainerInOutPutData_VAE.Panel1.Controls.Add(groupBoxData_VAE);
            // 
            // splitContainerInOutPutData_VAE.Panel2
            // 
            splitContainerInOutPutData_VAE.Panel2.Controls.Add(groupBoxWorkData_VAE);
            splitContainerInOutPutData_VAE.Size = new Size(1304, 784);
            splitContainerInOutPutData_VAE.SplitterDistance = 693;
            splitContainerInOutPutData_VAE.TabIndex = 1;
            // 
            // groupBoxData_VAE
            // 
            groupBoxData_VAE.Controls.Add(dataGridViewInPut_VAE);
            groupBoxData_VAE.Dock = DockStyle.Fill;
            groupBoxData_VAE.Location = new Point(0, 0);
            groupBoxData_VAE.Name = "groupBoxData_VAE";
            groupBoxData_VAE.Size = new Size(693, 784);
            groupBoxData_VAE.TabIndex = 0;
            groupBoxData_VAE.TabStop = false;
            groupBoxData_VAE.Text = "Данные (Номер процессора | Частота (МГц) | Макс. Частота (МГц) | Кол-во ядер | Цена)";
            // 
            // dataGridViewInPut_VAE
            // 
            dataGridViewInPut_VAE.AllowUserToAddRows = false;
            dataGridViewInPut_VAE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInPut_VAE.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewInPut_VAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_VAE.Dock = DockStyle.Fill;
            dataGridViewInPut_VAE.Location = new Point(3, 23);
            dataGridViewInPut_VAE.Name = "dataGridViewInPut_VAE";
            dataGridViewInPut_VAE.RowHeadersWidth = 51;
            dataGridViewInPut_VAE.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewInPut_VAE.Size = new Size(687, 758);
            dataGridViewInPut_VAE.TabIndex = 0;
            // 
            // groupBoxWorkData_VAE
            // 
            groupBoxWorkData_VAE.Controls.Add(chartResult_VAE);
            groupBoxWorkData_VAE.Controls.Add(textBoxResult_VAE);
            groupBoxWorkData_VAE.Controls.Add(buttonPriceHistogram_VAE);
            groupBoxWorkData_VAE.Controls.Add(buttonMaxPrice_VAE);
            groupBoxWorkData_VAE.Controls.Add(buttonMinPrice_VAE);
            groupBoxWorkData_VAE.Dock = DockStyle.Fill;
            groupBoxWorkData_VAE.Location = new Point(0, 0);
            groupBoxWorkData_VAE.Name = "groupBoxWorkData_VAE";
            groupBoxWorkData_VAE.Size = new Size(607, 784);
            groupBoxWorkData_VAE.TabIndex = 0;
            groupBoxWorkData_VAE.TabStop = false;
            groupBoxWorkData_VAE.Text = "Работа с данными";
            // 
            // chartResult_VAE
            // 
            chartResult_VAE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartResult_VAE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult_VAE.Legends.Add(legend1);
            chartResult_VAE.Location = new Point(13, 214);
            chartResult_VAE.Name = "chartResult_VAE";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_VAE.Series.Add(series1);
            chartResult_VAE.Size = new Size(582, 544);
            chartResult_VAE.TabIndex = 5;
            // 
            // textBoxResult_VAE
            // 
            textBoxResult_VAE.Location = new Point(13, 152);
            textBoxResult_VAE.Multiline = true;
            textBoxResult_VAE.Name = "textBoxResult_VAE";
            textBoxResult_VAE.ReadOnly = true;
            textBoxResult_VAE.Size = new Size(356, 31);
            textBoxResult_VAE.TabIndex = 4;
            // 
            // buttonPriceHistogram_VAE
            // 
            buttonPriceHistogram_VAE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPriceHistogram_VAE.Enabled = false;
            buttonPriceHistogram_VAE.Image = (Image)resources.GetObject("buttonPriceHistogram_VAE.Image");
            buttonPriceHistogram_VAE.Location = new Point(426, 36);
            buttonPriceHistogram_VAE.Name = "buttonPriceHistogram_VAE";
            buttonPriceHistogram_VAE.Size = new Size(169, 147);
            buttonPriceHistogram_VAE.TabIndex = 3;
            toolTipButtons.SetToolTip(buttonPriceHistogram_VAE, "Вывести гистограмму цен");
            buttonPriceHistogram_VAE.UseVisualStyleBackColor = true;
            buttonPriceHistogram_VAE.Click += buttonPriceHistogram_VAE_Click;
            buttonPriceHistogram_VAE.MouseEnter += buttonPriceHistogram_VAE_MouseEnter;
            // 
            // buttonMaxPrice_VAE
            // 
            buttonMaxPrice_VAE.Enabled = false;
            buttonMaxPrice_VAE.Image = (Image)resources.GetObject("buttonMaxPrice_VAE.Image");
            buttonMaxPrice_VAE.Location = new Point(200, 36);
            buttonMaxPrice_VAE.Name = "buttonMaxPrice_VAE";
            buttonMaxPrice_VAE.Size = new Size(169, 99);
            buttonMaxPrice_VAE.TabIndex = 2;
            toolTipButtons.SetToolTip(buttonMaxPrice_VAE, "Вывести максимальную цену из предложенных вариантов");
            buttonMaxPrice_VAE.UseVisualStyleBackColor = true;
            buttonMaxPrice_VAE.Click += buttonMaxPrice_VAE_Click;
            buttonMaxPrice_VAE.MouseEnter += buttonMaxPrice_VAE_MouseEnter;
            // 
            // buttonMinPrice_VAE
            // 
            buttonMinPrice_VAE.Enabled = false;
            buttonMinPrice_VAE.Image = (Image)resources.GetObject("buttonMinPrice_VAE.Image");
            buttonMinPrice_VAE.Location = new Point(13, 36);
            buttonMinPrice_VAE.Name = "buttonMinPrice_VAE";
            buttonMinPrice_VAE.Size = new Size(169, 99);
            buttonMinPrice_VAE.TabIndex = 2;
            toolTipButtons.SetToolTip(buttonMinPrice_VAE, "Вывести минимальную цену из предложеныых вариантов");
            buttonMinPrice_VAE.UseVisualStyleBackColor = true;
            buttonMinPrice_VAE.Click += buttonMinPrice_VAE_Click;
            buttonMinPrice_VAE.MouseEnter += buttonMinPrice_VAE_MouseEnter;
            // 
            // toolTipButtons
            // 
            toolTipButtons.IsBalloon = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 784);
            Controls.Add(splitContainerInOutPutData_VAE);
            Controls.Add(panelButtons_VAE);
            Name = "FormMain";
            Text = "Персональные ЭВМ";
            panelButtons_VAE.ResumeLayout(false);
            groupBoxInfoButtons_VAE.ResumeLayout(false);
            groupBoxInsrtumentButtons_VAE.ResumeLayout(false);
            splitContainerInOutPutData_VAE.Panel1.ResumeLayout(false);
            splitContainerInOutPutData_VAE.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerInOutPutData_VAE).EndInit();
            splitContainerInOutPutData_VAE.ResumeLayout(false);
            groupBoxData_VAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_VAE).EndInit();
            groupBoxWorkData_VAE.ResumeLayout(false);
            groupBoxWorkData_VAE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_VAE).EndInit();
            ResumeLayout(false);
        }

        private void ButtonPriceHistogram_VAE_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelButtons_VAE;
        private SplitContainer splitContainerInOutPutData_VAE;
        private GroupBox groupBoxInsrtumentButtons_VAE;
        private GroupBox groupBoxInfoButtons_VAE;
        private GroupBox groupBoxData_VAE;
        private GroupBox groupBoxWorkData_VAE;
        private Button buttonInfo_VAE;
        private Button buttonGuide_VAE;
        private Button buttonLoadData_VAE;
        private Button buttonSaveData_VAE;
        private DataGridView dataGridViewInPut_VAE;
        private Button buttonMinPrice_VAE;
        private Button buttonMaxPrice_VAE;
        private Button buttonPriceHistogram_VAE;
        private OpenFileDialog openFileDialogData_VAE;
        private SaveFileDialog saveFileDialogData_VAE;
        private ToolTip toolTipButtons;
        private TextBox textBoxResult_VAE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_VAE;
        private Button buttonAddRow_VAE;
        private Button buttonDeleteRow_VAE;
    }
}
