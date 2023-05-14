namespace Apriori_Algorith_Implementation
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addField = new System.Windows.Forms.Button();
            this.readyBtn = new System.Windows.Forms.Button();
            this.getResultBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 27);
            this.textBox1.TabIndex = 10;
            // 
            // addField
            // 
            this.addField.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addField.Location = new System.Drawing.Point(368, 51);
            this.addField.Name = "addField";
            this.addField.Size = new System.Drawing.Size(94, 29);
            this.addField.TabIndex = 11;
            this.addField.Text = "Add Field";
            this.addField.UseVisualStyleBackColor = false;
            this.addField.Click += new System.EventHandler(this.addField_Click);
            // 
            // readyBtn
            // 
            this.readyBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.readyBtn.Location = new System.Drawing.Point(93, 403);
            this.readyBtn.Name = "readyBtn";
            this.readyBtn.Size = new System.Drawing.Size(127, 37);
            this.readyBtn.TabIndex = 12;
            this.readyBtn.Text = "Ready";
            this.readyBtn.UseVisualStyleBackColor = false;
            this.readyBtn.Click += new System.EventHandler(this.readyBtn_Click);
            // 
            // getResultBtn
            // 
            this.getResultBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getResultBtn.Location = new System.Drawing.Point(438, 403);
            this.getResultBtn.Name = "getResultBtn";
            this.getResultBtn.Size = new System.Drawing.Size(127, 37);
            this.getResultBtn.TabIndex = 13;
            this.getResultBtn.Text = "Get Values";
            this.getResultBtn.UseVisualStyleBackColor = false;
            this.getResultBtn.Click += new System.EventHandler(this.getResultBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 491);
            this.Controls.Add(this.getResultBtn);
            this.Controls.Add(this.readyBtn);
            this.Controls.Add(this.addField);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Apriori Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private Button addField;
        private Button readyBtn;
        private Button getResultBtn;
    }
}