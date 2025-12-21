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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_VAE = new Panel();
            groupBoxInfoButtons_VAE = new GroupBox();
            buttonInfo_VAE = new Button();
            buttonGuide_VAE = new Button();
            groupBoxInsrtumentButtons_VAE = new GroupBox();
            splitContainerInOutPutData_VAE = new SplitContainer();
            groupBoxData_VAE = new GroupBox();
            groupBoxWorkData_VAE = new GroupBox();
            buttonLoadData_VAE = new Button();
            panelButtons_VAE.SuspendLayout();
            groupBoxInfoButtons_VAE.SuspendLayout();
            groupBoxInsrtumentButtons_VAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerInOutPutData_VAE).BeginInit();
            splitContainerInOutPutData_VAE.Panel1.SuspendLayout();
            splitContainerInOutPutData_VAE.Panel2.SuspendLayout();
            splitContainerInOutPutData_VAE.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons_VAE
            // 
            panelButtons_VAE.Controls.Add(groupBoxInfoButtons_VAE);
            panelButtons_VAE.Controls.Add(groupBoxInsrtumentButtons_VAE);
            panelButtons_VAE.Dock = DockStyle.Left;
            panelButtons_VAE.Location = new Point(0, 0);
            panelButtons_VAE.Name = "panelButtons_VAE";
            panelButtons_VAE.Size = new Size(190, 710);
            panelButtons_VAE.TabIndex = 0;
            // 
            // groupBoxInfoButtons_VAE
            // 
            groupBoxInfoButtons_VAE.Controls.Add(buttonInfo_VAE);
            groupBoxInfoButtons_VAE.Controls.Add(buttonGuide_VAE);
            groupBoxInfoButtons_VAE.Dock = DockStyle.Bottom;
            groupBoxInfoButtons_VAE.Location = new Point(0, 453);
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
            buttonInfo_VAE.UseVisualStyleBackColor = true;
            // 
            // buttonGuide_VAE
            // 
            buttonGuide_VAE.Image = (Image)resources.GetObject("buttonGuide_VAE.Image");
            buttonGuide_VAE.Location = new Point(10, 26);
            buttonGuide_VAE.Name = "buttonGuide_VAE";
            buttonGuide_VAE.Size = new Size(169, 99);
            buttonGuide_VAE.TabIndex = 0;
            buttonGuide_VAE.UseVisualStyleBackColor = true;
            // 
            // groupBoxInsrtumentButtons_VAE
            // 
            groupBoxInsrtumentButtons_VAE.Controls.Add(buttonLoadData_VAE);
            groupBoxInsrtumentButtons_VAE.Dock = DockStyle.Fill;
            groupBoxInsrtumentButtons_VAE.Location = new Point(0, 0);
            groupBoxInsrtumentButtons_VAE.Name = "groupBoxInsrtumentButtons_VAE";
            groupBoxInsrtumentButtons_VAE.Size = new Size(190, 710);
            groupBoxInsrtumentButtons_VAE.TabIndex = 0;
            groupBoxInsrtumentButtons_VAE.TabStop = false;
            groupBoxInsrtumentButtons_VAE.Text = "Панель инструментов";
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
            splitContainerInOutPutData_VAE.Size = new Size(1003, 710);
            splitContainerInOutPutData_VAE.SplitterDistance = 507;
            splitContainerInOutPutData_VAE.TabIndex = 1;
            // 
            // groupBoxData_VAE
            // 
            groupBoxData_VAE.Dock = DockStyle.Fill;
            groupBoxData_VAE.Location = new Point(0, 0);
            groupBoxData_VAE.Name = "groupBoxData_VAE";
            groupBoxData_VAE.Size = new Size(507, 710);
            groupBoxData_VAE.TabIndex = 0;
            groupBoxData_VAE.TabStop = false;
            groupBoxData_VAE.Text = "Данные";
            // 
            // groupBoxWorkData_VAE
            // 
            groupBoxWorkData_VAE.Dock = DockStyle.Fill;
            groupBoxWorkData_VAE.Location = new Point(0, 0);
            groupBoxWorkData_VAE.Name = "groupBoxWorkData_VAE";
            groupBoxWorkData_VAE.Size = new Size(492, 710);
            groupBoxWorkData_VAE.TabIndex = 0;
            groupBoxWorkData_VAE.TabStop = false;
            groupBoxWorkData_VAE.Text = "Работа с данными";
            // 
            // buttonLoadData_VAE
            // 
            buttonLoadData_VAE.Image = (Image)resources.GetObject("buttonLoadData_VAE.Image");
            buttonLoadData_VAE.Location = new Point(10, 36);
            buttonLoadData_VAE.Name = "buttonLoadData_VAE";
            buttonLoadData_VAE.Size = new Size(169, 99);
            buttonLoadData_VAE.TabIndex = 0;
            buttonLoadData_VAE.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 710);
            Controls.Add(splitContainerInOutPutData_VAE);
            Controls.Add(panelButtons_VAE);
            Name = "FormMain";
            Text = "Персональные ЭВМ";
            Load += Form1_Load;
            panelButtons_VAE.ResumeLayout(false);
            groupBoxInfoButtons_VAE.ResumeLayout(false);
            groupBoxInsrtumentButtons_VAE.ResumeLayout(false);
            splitContainerInOutPutData_VAE.Panel1.ResumeLayout(false);
            splitContainerInOutPutData_VAE.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerInOutPutData_VAE).EndInit();
            splitContainerInOutPutData_VAE.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}
