namespace PxP
{
    partial class AddParameter
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
            this.parameter1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parameter1TextBox
            // 
            this.parameter1TextBox.Location = new System.Drawing.Point(12, 25);
            this.parameter1TextBox.Multiline = true;
            this.parameter1TextBox.Name = "parameter1TextBox";
            this.parameter1TextBox.Size = new System.Drawing.Size(148, 165);
            this.parameter1TextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "parameter1";
            // 
            // AddParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 322);
            this.Controls.Add(this.parameter1TextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddParameter";
            this.Text = "AddParameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox parameter1TextBox;
        private System.Windows.Forms.Label label1;
    }
}