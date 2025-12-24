namespace Tyuiu.VlasenkoAE.Sprint7.Project.V12
{
    partial class FormGuide
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
            buttonCloseGuide_VAE = new Button();
            SuspendLayout();
            // 
            // buttonCloseGuide_VAE
            // 
            buttonCloseGuide_VAE.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCloseGuide_VAE.Location = new Point(655, 391);
            buttonCloseGuide_VAE.Name = "buttonCloseGuide_VAE";
            buttonCloseGuide_VAE.Size = new Size(130, 43);
            buttonCloseGuide_VAE.TabIndex = 0;
            buttonCloseGuide_VAE.Text = "Закрыть";
            buttonCloseGuide_VAE.UseVisualStyleBackColor = true;
            buttonCloseGuide_VAE.Click += buttonCloseGuide_VAE_Click;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCloseGuide_VAE);
            Name = "FormGuide";
            Text = "Руководство пользователя";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCloseGuide_VAE;
    }
}