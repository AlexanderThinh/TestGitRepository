
namespace TestGit
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cộng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số B";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(255, 92);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(128, 38);
            this.txtSoA.TabIndex = 2;
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(255, 147);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(128, 38);
            this.txtSoB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kết quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(255, 205);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(128, 38);
            this.txtKQ.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 518);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

