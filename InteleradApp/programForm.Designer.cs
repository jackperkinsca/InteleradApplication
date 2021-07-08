
namespace InteleradApp
{
    partial class programForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programForm));
            this.debugText = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.startImage = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.startImage)).BeginInit();
            this.SuspendLayout();
            // 
            // debugText
            // 
            this.debugText.BackColor = System.Drawing.SystemColors.Control;
            this.debugText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugText.Location = new System.Drawing.Point(339, 344);
            this.debugText.Name = "debugText";
            this.debugText.ReadOnly = true;
            this.debugText.Size = new System.Drawing.Size(150, 13);
            this.debugText.TabIndex = 2;
            this.debugText.Visible = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Control;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startButton.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(373, 273);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 30);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Load CSV\'s";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // startImage
            // 
            this.startImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startImage.Image = global::InteleradApp.Properties.Resources.logo_color_250;
            this.startImage.Location = new System.Drawing.Point(0, 0);
            this.startImage.Name = "startImage";
            this.startImage.Size = new System.Drawing.Size(800, 450);
            this.startImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.startImage.TabIndex = 0;
            this.startImage.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(276, 315);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(275, 23);
            this.progressBar.TabIndex = 4;
            // 
            // programForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.debugText);
            this.Controls.Add(this.startImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "programForm";
            this.Text = "CSV Tool";
            ((System.ComponentModel.ISupportInitialize)(this.startImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox startImage;
        private System.Windows.Forms.TextBox debugText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

