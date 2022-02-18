namespace AddNumbers
{
    partial class TxtNumber1
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
            this.txtFirstNumber = new System.Windows.Forms.Label();
            this.txtSecondNumber = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.AutoSize = true;
            this.txtFirstNumber.Location = new System.Drawing.Point(127, 48);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(66, 13);
            this.txtFirstNumber.TabIndex = 0;
            this.txtFirstNumber.Text = "First Number";
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.AutoSize = true;
            this.txtSecondNumber.Location = new System.Drawing.Point(127, 85);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(84, 13);
            this.txtSecondNumber.TabIndex = 1;
            this.txtSecondNumber.Text = "Second Number";
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(255, 177);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(43, 13);
            this.lblResult1.TabIndex = 4;
            this.lblResult1.Text = "Result1";
            this.lblResult1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(319, 177);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(43, 13);
            this.lblResult2.TabIndex = 5;
            this.lblResult2.Text = "Rusult2";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(255, 121);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Sum";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(229, 48);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(100, 20);
            this.TxtNum1.TabIndex = 7;
            // 
            // TxtNum2
            // 
            this.TxtNum2.Location = new System.Drawing.Point(230, 78);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(100, 20);
            this.TxtNum2.TabIndex = 8;
            this.TxtNum2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtNumber1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.TxtNum1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Name = "TxtNumber1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtFirstNumber;
        private System.Windows.Forms.Label txtSecondNumber;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.TextBox TxtNum2;
    }
}

