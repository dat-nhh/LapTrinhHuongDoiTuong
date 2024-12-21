namespace Lab6
{
    partial class Form6_1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.buttonCong = new System.Windows.Forms.Button();
            this.buttonTru = new System.Windows.Forms.Button();
            this.buttonNhan = new System.Windows.Forms.Button();
            this.buttonChia = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(200, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁC PHÉP TOÁN SỐ HỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(181, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập vào số a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(181, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập vào số b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(181, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả:";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(317, 138);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(292, 22);
            this.txtSoA.TabIndex = 4;
            this.txtSoA.Leave += new System.EventHandler(this.txtA_Leave);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(317, 203);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(292, 22);
            this.txtSoB.TabIndex = 5;
            this.txtSoB.Leave += new System.EventHandler(this.txtB_Leave);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(317, 266);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(292, 22);
            this.txtKetQua.TabIndex = 6;
            // 
            // buttonCong
            // 
            this.buttonCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCong.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonCong.Location = new System.Drawing.Point(139, 333);
            this.buttonCong.Name = "buttonCong";
            this.buttonCong.Size = new System.Drawing.Size(46, 45);
            this.buttonCong.TabIndex = 7;
            this.buttonCong.Text = "+";
            this.buttonCong.UseVisualStyleBackColor = true;
            this.buttonCong.Click += new System.EventHandler(this.congClick);
            // 
            // buttonTru
            // 
            this.buttonTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTru.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonTru.Location = new System.Drawing.Point(222, 333);
            this.buttonTru.Name = "buttonTru";
            this.buttonTru.Size = new System.Drawing.Size(46, 45);
            this.buttonTru.TabIndex = 8;
            this.buttonTru.Text = "-";
            this.buttonTru.UseVisualStyleBackColor = true;
            this.buttonTru.Click += new System.EventHandler(this.truClick);
            // 
            // buttonNhan
            // 
            this.buttonNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhan.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonNhan.Location = new System.Drawing.Point(305, 333);
            this.buttonNhan.Name = "buttonNhan";
            this.buttonNhan.Size = new System.Drawing.Size(46, 45);
            this.buttonNhan.TabIndex = 9;
            this.buttonNhan.Text = "*";
            this.buttonNhan.UseVisualStyleBackColor = true;
            this.buttonNhan.Click += new System.EventHandler(this.nhanClick);
            // 
            // buttonChia
            // 
            this.buttonChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChia.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonChia.Location = new System.Drawing.Point(393, 333);
            this.buttonChia.Name = "buttonChia";
            this.buttonChia.Size = new System.Drawing.Size(46, 45);
            this.buttonChia.TabIndex = 10;
            this.buttonChia.Text = "/";
            this.buttonChia.UseVisualStyleBackColor = true;
            this.buttonChia.Click += new System.EventHandler(this.chiaClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonClear.Location = new System.Drawing.Point(480, 333);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(46, 45);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.clearClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonClose.Location = new System.Drawing.Point(565, 333);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(96, 45);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.closeClick);
            // 
            // Form6_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonChia);
            this.Controls.Add(this.buttonNhan);
            this.Controls.Add(this.buttonTru);
            this.Controls.Add(this.buttonCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6_1";
            this.Text = "Form6_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button buttonCong;
        private System.Windows.Forms.Button buttonTru;
        private System.Windows.Forms.Button buttonNhan;
        private System.Windows.Forms.Button buttonChia;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
    }
}