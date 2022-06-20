namespace DeskDock_Form
{
    partial class DeskDock
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
            this.Notebook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Notebook
            // 
            this.Notebook.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Notebook.BackgroundImage = global::DeskDock_Form.Properties.Resources.Notebook;
            this.Notebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Notebook.Dock = System.Windows.Forms.DockStyle.Left;
            this.Notebook.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Notebook.Location = new System.Drawing.Point(0, 0);
            this.Notebook.Name = "Notebook";
            this.Notebook.Size = new System.Drawing.Size(136, 142);
            this.Notebook.TabIndex = 0;
            this.Notebook.UseVisualStyleBackColor = false;
            // 
            // DeskDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 142);
            this.ControlBox = false;
            this.Controls.Add(this.Notebook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeskDock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.DeskDock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Notebook;
    }
}