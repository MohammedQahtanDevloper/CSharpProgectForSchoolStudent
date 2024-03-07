namespace Qusai.FORM
{
    partial class login
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.text_re = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.but_uptate = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.but_up = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 475);
            this.dataGridView1.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.groupBox2.Controls.Add(this.text_re);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 70);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "البحث عن المستخدمين";
            // 
            // text_re
            // 
            this.text_re.BackColor = System.Drawing.Color.White;
            this.text_re.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_re.Location = new System.Drawing.Point(251, 29);
            this.text_re.Name = "text_re";
            this.text_re.Size = new System.Drawing.Size(322, 19);
            this.text_re.TabIndex = 0;
            this.text_re.TextChanged += new System.EventHandler(this.text_re_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.but_uptate);
            this.groupBox1.Controls.Add(this.but_delete);
            this.groupBox1.Controls.Add(this.but_add);
            this.groupBox1.Controls.Add(this.but_up);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 236);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العمليات المتاحة";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(54, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 50);
            this.button5.TabIndex = 15;
            this.button5.Text = "ادارة الصف المدرسي";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(228, 78);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button4.Size = new System.Drawing.Size(262, 43);
            this.button4.TabIndex = 14;
            this.button4.Text = "حفظ اللأئحة في ملف اكسل";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(496, 78);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button3.Size = new System.Drawing.Size(262, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "طباعة كل المستخدمين";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(32, 29);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button2.Size = new System.Drawing.Size(128, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "طباعة";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(54, 78);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(176, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "صورة المستخدم";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // but_uptate
            // 
            this.but_uptate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.but_uptate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_uptate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_uptate.ForeColor = System.Drawing.Color.White;
            this.but_uptate.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.but_uptate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_uptate.Location = new System.Drawing.Point(166, 29);
            this.but_uptate.Name = "but_uptate";
            this.but_uptate.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.but_uptate.Size = new System.Drawing.Size(128, 43);
            this.but_uptate.TabIndex = 10;
            this.but_uptate.Text = "تعديل";
            this.but_uptate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_uptate.UseVisualStyleBackColor = true;
            this.but_uptate.Click += new System.EventHandler(this.but_uptate_Click);
            // 
            // but_delete
            // 
            this.but_delete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.but_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_delete.ForeColor = System.Drawing.Color.White;
            this.but_delete.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.but_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_delete.Location = new System.Drawing.Point(469, 29);
            this.but_delete.Name = "but_delete";
            this.but_delete.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.but_delete.Size = new System.Drawing.Size(128, 43);
            this.but_delete.TabIndex = 9;
            this.but_delete.Text = "حذف";
            this.but_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_add
            // 
            this.but_add.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.but_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add.ForeColor = System.Drawing.Color.White;
            this.but_add.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.but_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_add.Location = new System.Drawing.Point(603, 29);
            this.but_add.Name = "but_add";
            this.but_add.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.but_add.Size = new System.Drawing.Size(128, 43);
            this.but_add.TabIndex = 8;
            this.but_add.Text = "اضافة";
            this.but_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_up
            // 
            this.but_up.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.but_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_up.ForeColor = System.Drawing.Color.White;
            this.but_up.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.but_up.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_up.Location = new System.Drawing.Point(317, 29);
            this.but_up.Name = "but_up";
            this.but_up.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.but_up.Size = new System.Drawing.Size(128, 43);
            this.but_up.TabIndex = 7;
            this.but_up.Text = "تحديث";
            this.but_up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_up.UseVisualStyleBackColor = true;
            this.but_up.Click += new System.EventHandler(this.but_up_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 554);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لائحة المستخدمين";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox text_re;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_up;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_uptate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}