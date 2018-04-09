namespace App
{
    partial class CreditCardForm
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
            this.CardNumberBox = new System.Windows.Forms.TextBox();
            this.CreditCardUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit card number";
            // 
            // CardNumberBox
            // 
            this.CardNumberBox.Location = new System.Drawing.Point(17, 70);
            this.CardNumberBox.Name = "CardNumberBox";
            this.CardNumberBox.Size = new System.Drawing.Size(190, 31);
            this.CardNumberBox.TabIndex = 2;
            // 
            // CreditCardUpdateButton
            // 
            this.CreditCardUpdateButton.Location = new System.Drawing.Point(17, 128);
            this.CreditCardUpdateButton.Name = "CreditCardUpdateButton";
            this.CreditCardUpdateButton.Size = new System.Drawing.Size(190, 47);
            this.CreditCardUpdateButton.TabIndex = 3;
            this.CreditCardUpdateButton.Text = "Update Number";
            this.CreditCardUpdateButton.UseVisualStyleBackColor = true;
            this.CreditCardUpdateButton.Click += new System.EventHandler(this.CreditCardUpdateButton_Click);
            // 
            // CreditCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 230);
            this.Controls.Add(this.CreditCardUpdateButton);
            this.Controls.Add(this.CardNumberBox);
            this.Controls.Add(this.label1);
            this.Name = "CreditCardForm";
            this.Text = "CreditCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CardNumberBox;
        private System.Windows.Forms.Button CreditCardUpdateButton;
    }
}