namespace Graphs
{
    partial class InformationForm
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
            this.txtbxLicens = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxLicens
            // 
            this.txtbxLicens.Location = new System.Drawing.Point(12, 12);
            this.txtbxLicens.Multiline = true;
            this.txtbxLicens.Name = "txtbxLicens";
            this.txtbxLicens.ReadOnly = true;
            this.txtbxLicens.Size = new System.Drawing.Size(500, 372);
            this.txtbxLicens.TabIndex = 0;
            this.txtbxLicens.Text = "Developed by Evgeniy \"Rakiiii\" Sudarskiy\r\nSudaru2@gmail.com\r\nBug reports https://" +
    "github.com/Rakiiii/Calcuator/issues \r\n©BSD 3-Clause \"New\" or \"Revised\" License";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(695, 361);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtbxLicens);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxLicens;
        private System.Windows.Forms.Button btnClose;
    }
}