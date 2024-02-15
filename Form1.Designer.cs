namespace PrimeNumberIXF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.CheckButton = new System.Windows.Forms.Button();
            this.PrimeNumberTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckButton.Location = new System.Drawing.Point(324, 156);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(214, 104);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "CHECK";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // PrimeNumberTextbox
            // 
            this.PrimeNumberTextbox.Location = new System.Drawing.Point(288, 101);
            this.PrimeNumberTextbox.Name = "PrimeNumberTextbox";
            this.PrimeNumberTextbox.Size = new System.Drawing.Size(280, 22);
            this.PrimeNumberTextbox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.PrimeNumberTextbox);
            this.Controls.Add(this.CheckButton);
            this.Name = "Form1";
            this.Text = "CHECK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox PrimeNumberTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

