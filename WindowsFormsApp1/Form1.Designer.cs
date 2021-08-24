
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtDaySo = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.txtTongle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dãy số vừa nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng các phần tử trong dãy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng chẵn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng lẻ:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(133, 24);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(99, 27);
            this.txtNhap.TabIndex = 5;
            this.txtNhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDaySo
            // 
            this.txtDaySo.Location = new System.Drawing.Point(158, 80);
            this.txtDaySo.Name = "txtDaySo";
            this.txtDaySo.Size = new System.Drawing.Size(125, 27);
            this.txtDaySo.TabIndex = 6;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(238, 146);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(100, 27);
            this.txtTong.TabIndex = 7;
            // 
            // txtTongChan
            // 
            this.txtTongChan.Location = new System.Drawing.Point(133, 217);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(125, 27);
            this.txtTongChan.TabIndex = 8;
            // 
            // txtTongle
            // 
            this.txtTongle.Location = new System.Drawing.Point(133, 294);
            this.txtTongle.Name = "txtTongle";
            this.txtTongle.Size = new System.Drawing.Size(125, 27);
            this.txtTongle.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTongle);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtDaySo);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtDaySo;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.TextBox txtTongle;
        private System.Windows.Forms.Button button1;
    }
}

