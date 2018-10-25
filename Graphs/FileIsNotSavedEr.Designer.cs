namespace Graphs
{
    partial class FileIsNotSavedEr
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
            this.txtbxFileNotSaved = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbxFileNotSaved
            // 
            this.txtbxFileNotSaved.Location = new System.Drawing.Point(12, 12);
            this.txtbxFileNotSaved.Multiline = true;
            this.txtbxFileNotSaved.Name = "txtbxFileNotSaved";
            this.txtbxFileNotSaved.Size = new System.Drawing.Size(300, 200);
            this.txtbxFileNotSaved.TabIndex = 0;
            this.txtbxFileNotSaved.Text = "Error\r\nFile isn't saved\r\nPermition denied!";
            // 
            // FileIsNotSavedEr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 221);
            this.Controls.Add(this.txtbxFileNotSaved);
            this.Name = "FileIsNotSavedEr";
            this.Text = "FileIsNotSavedEr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxFileNotSaved;
    }
}