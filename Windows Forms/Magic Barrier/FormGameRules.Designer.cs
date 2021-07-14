
namespace PatrykKaczynskiLab1ZadDom
{
    partial class FormGameRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameRules));
            this.panelGameDescription = new System.Windows.Forms.Panel();
            this.labelGameDescriptionContent = new System.Windows.Forms.Label();
            this.labelGameDescriptionHeader = new System.Windows.Forms.Label();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.panelGameDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGameDescription
            // 
            this.panelGameDescription.BackColor = System.Drawing.Color.Transparent;
            this.panelGameDescription.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGameDescription.BackgroundImage")));
            this.panelGameDescription.Controls.Add(this.labelGameDescriptionContent);
            this.panelGameDescription.Controls.Add(this.labelGameDescriptionHeader);
            this.panelGameDescription.Location = new System.Drawing.Point(21, 31);
            this.panelGameDescription.Name = "panelGameDescription";
            this.panelGameDescription.Size = new System.Drawing.Size(421, 554);
            this.panelGameDescription.TabIndex = 0;
            // 
            // labelGameDescriptionContent
            // 
            this.labelGameDescriptionContent.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelGameDescriptionContent.Location = new System.Drawing.Point(58, 86);
            this.labelGameDescriptionContent.Name = "labelGameDescriptionContent";
            this.labelGameDescriptionContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGameDescriptionContent.Size = new System.Drawing.Size(309, 428);
            this.labelGameDescriptionContent.TabIndex = 1;
            this.labelGameDescriptionContent.Text = "Opis gry";
            this.labelGameDescriptionContent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGameDescriptionHeader
            // 
            this.labelGameDescriptionHeader.AutoSize = true;
            this.labelGameDescriptionHeader.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelGameDescriptionHeader.Location = new System.Drawing.Point(149, 31);
            this.labelGameDescriptionHeader.Name = "labelGameDescriptionHeader";
            this.labelGameDescriptionHeader.Size = new System.Drawing.Size(137, 41);
            this.labelGameDescriptionHeader.TabIndex = 0;
            this.labelGameDescriptionHeader.Text = "Opis gry";
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCloseWindow.BackgroundImage")));
            this.buttonCloseWindow.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCloseWindow.Location = new System.Drawing.Point(331, 601);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(140, 48);
            this.buttonCloseWindow.TabIndex = 1;
            this.buttonCloseWindow.Text = "Zamknij okno";
            this.buttonCloseWindow.UseVisualStyleBackColor = true;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // FormGameRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(483, 661);
            this.Controls.Add(this.buttonCloseWindow);
            this.Controls.Add(this.panelGameDescription);
            this.Name = "FormGameRules";
            this.Text = "Opis gry Magiczna Bariera";
            this.Load += new System.EventHandler(this.FormGameRules_Load);
            this.panelGameDescription.ResumeLayout(false);
            this.panelGameDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGameDescription;
        private System.Windows.Forms.Label labelGameDescriptionContent;
        private System.Windows.Forms.Label labelGameDescriptionHeader;
        private System.Windows.Forms.Button buttonCloseWindow;
    }
}