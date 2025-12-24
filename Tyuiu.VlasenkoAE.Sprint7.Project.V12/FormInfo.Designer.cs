namespace Tyuiu.VlasenkoAE.Sprint7.Project.V12
{
    partial class FormInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            pictureBoxAvatar_VAE = new PictureBox();
            labelInfo_VAE = new Label();
            buttonCloseInfo_VAE = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_VAE).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_VAE
            // 
            pictureBoxAvatar_VAE.Image = (Image)resources.GetObject("pictureBoxAvatar_VAE.Image");
            pictureBoxAvatar_VAE.Location = new Point(12, 12);
            pictureBoxAvatar_VAE.Name = "pictureBoxAvatar_VAE";
            pictureBoxAvatar_VAE.Size = new Size(481, 272);
            pictureBoxAvatar_VAE.TabIndex = 0;
            pictureBoxAvatar_VAE.TabStop = false;
            // 
            // labelInfo_VAE
            // 
            labelInfo_VAE.AutoSize = true;
            labelInfo_VAE.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo_VAE.Location = new Point(499, 26);
            labelInfo_VAE.Name = "labelInfo_VAE";
            labelInfo_VAE.Size = new Size(482, 50);
            labelInfo_VAE.TabIndex = 1;
            labelInfo_VAE.Text = "Программа разработана студентом группы ИСТНб-25-1 \r\nВласенко А. Е.\r\n";
            // 
            // buttonCloseInfo_VAE
            // 
            buttonCloseInfo_VAE.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCloseInfo_VAE.Location = new Point(865, 243);
            buttonCloseInfo_VAE.Name = "buttonCloseInfo_VAE";
            buttonCloseInfo_VAE.Size = new Size(116, 41);
            buttonCloseInfo_VAE.TabIndex = 2;
            buttonCloseInfo_VAE.Text = "Закрыть";
            buttonCloseInfo_VAE.UseVisualStyleBackColor = true;
            buttonCloseInfo_VAE.Click += buttonClose_VAE_Click;
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 296);
            Controls.Add(buttonCloseInfo_VAE);
            Controls.Add(labelInfo_VAE);
            Controls.Add(pictureBoxAvatar_VAE);
            Name = "FormInfo";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_VAE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_VAE;
        private Label labelInfo_VAE;
        private Button buttonCloseInfo_VAE;
    }
}