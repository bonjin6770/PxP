namespace PxP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.parameter1TextBox = new System.Windows.Forms.TextBox();
            this.parameter2TextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "parameter1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "parameter2";
            // 
            // parameter1TextBox
            // 
            this.parameter1TextBox.Location = new System.Drawing.Point(37, 48);
            this.parameter1TextBox.Multiline = true;
            this.parameter1TextBox.Name = "parameter1TextBox";
            this.parameter1TextBox.Size = new System.Drawing.Size(148, 165);
            this.parameter1TextBox.TabIndex = 2;
            // 
            // parameter2TextBox
            // 
            this.parameter2TextBox.Location = new System.Drawing.Point(221, 48);
            this.parameter2TextBox.Multiline = true;
            this.parameter2TextBox.Name = "parameter2TextBox";
            this.parameter2TextBox.Size = new System.Drawing.Size(148, 165);
            this.parameter2TextBox.TabIndex = 3;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(37, 271);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(332, 165);
            this.resultTextBox.TabIndex = 4;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(294, 219);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 5;
            this.runButton.Text = "run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 448);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.parameter2TextBox);
            this.Controls.Add(this.parameter1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parameter1TextBox;
        private System.Windows.Forms.TextBox parameter2TextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button runButton;
    }
}

