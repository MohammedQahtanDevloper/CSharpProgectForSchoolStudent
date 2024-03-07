namespace Qusai.Form_school
{
    partial class Classroom
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
            this.butFirst = new System.Windows.Forms.Label();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.Label();
            this.butPrevious = new System.Windows.Forms.Label();
            this.butNext = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.butLast = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.but_add = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butFirst
            // 
            this.butFirst.AutoSize = true;
            this.butFirst.Location = new System.Drawing.Point(151, 46);
            this.butFirst.Name = "butFirst";
            this.butFirst.Size = new System.Drawing.Size(35, 26);
            this.butFirst.TabIndex = 0;
            this.butFirst.Text = "<<|";
            this.butFirst.Click += new System.EventHandler(this.butFirst_Click);
            // 
            // dgList
            // 
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.dgList.Location = new System.Drawing.Point(6, 25);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(527, 185);
            this.dgList.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tufuli Arabic DEMO Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم الصف الدرسي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tufuli Arabic DEMO Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "معرف الصف الدرسي";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgList);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 355);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لائحة الصف الدرسي";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.but_add);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.but_edit);
            this.groupBox3.Controls.Add(this.but_delete);
            this.groupBox3.Controls.Add(this.but_new);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 136);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات المتاحة";
            // 
            // textid
            // 
            this.textid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textid.Location = new System.Drawing.Point(60, 54);
            this.textid.Multiline = true;
            this.textid.Name = "textid";
            this.textid.ReadOnly = true;
            this.textid.Size = new System.Drawing.Size(110, 20);
            this.textid.TabIndex = 1;
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(76, 46);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(39, 26);
            this.position.TabIndex = 4;
            this.position.Text = "7/6";
            // 
            // butPrevious
            // 
            this.butPrevious.AutoSize = true;
            this.butPrevious.Location = new System.Drawing.Point(122, 46);
            this.butPrevious.Name = "butPrevious";
            this.butPrevious.Size = new System.Drawing.Size(30, 26);
            this.butPrevious.TabIndex = 3;
            this.butPrevious.Text = "<<";
            this.butPrevious.Click += new System.EventHandler(this.butPrevious_Click);
            // 
            // butNext
            // 
            this.butNext.AutoSize = true;
            this.butNext.Location = new System.Drawing.Point(41, 46);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(30, 26);
            this.butNext.TabIndex = 2;
            this.butNext.Text = ">>";
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.position);
            this.groupBox4.Controls.Add(this.butPrevious);
            this.groupBox4.Controls.Add(this.butNext);
            this.groupBox4.Controls.Add(this.butLast);
            this.groupBox4.Controls.Add(this.butFirst);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 107);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "التنقل";
            // 
            // butLast
            // 
            this.butLast.AutoSize = true;
            this.butLast.Location = new System.Drawing.Point(6, 46);
            this.butLast.Name = "butLast";
            this.butLast.Size = new System.Drawing.Size(35, 26);
            this.butLast.TabIndex = 1;
            this.butLast.Text = "|>>";
            this.butLast.Click += new System.EventHandler(this.butLast_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textid);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tufuli Arabic DEMO Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(557, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أدارة الصف الدرسي";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(9, 97);
            this.textname.Multiline = true;
            this.textname.Name = "textname";
            this.textname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textname.Size = new System.Drawing.Size(161, 101);
            this.textname.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5252F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.4748F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 361);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // but_add
            // 
            this.but_add.Enabled = false;
            this.but_add.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.but_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add.Font = new System.Drawing.Font("Tufuli Arabic DEMO Medium", 12F, System.Drawing.FontStyle.Bold);
            this.but_add.ForeColor = System.Drawing.Color.Black;
            this.but_add.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.but_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_add.Location = new System.Drawing.Point(268, 29);
            this.but_add.Name = "but_add";
            this.but_add.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.but_add.Size = new System.Drawing.Size(108, 43);
            this.but_add.TabIndex = 18;
            this.but_add.Text = "إضافة";
            this.but_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tufuli Arabic DEMO Medium", 12F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(113, 82);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button5.Size = new System.Drawing.Size(193, 43);
            this.button5.TabIndex = 17;
            this.button5.Text = "طباعة كل المدارس";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tufuli Arabic DEMO Medium", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(3, 82);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button4.Size = new System.Drawing.Size(104, 43);
            this.button4.TabIndex = 16;
            this.button4.Text = "طباعة";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // but_edit
            // 
            this.but_edit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.but_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_edit.Font = new System.Drawing.Font("Tufuli Arabic DEMO Medium", 12F, System.Drawing.FontStyle.Bold);
            this.but_edit.ForeColor = System.Drawing.Color.Black;
            this.but_edit.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.but_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_edit.Location = new System.Drawing.Point(40, 29);
            this.but_edit.Name = "but_edit";
            this.but_edit.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.but_edit.Size = new System.Drawing.Size(108, 43);
            this.but_edit.TabIndex = 15;
            this.but_edit.Text = "تعديل";
            this.but_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // but_delete
            // 
            this.but_delete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.but_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_delete.Font = new System.Drawing.Font("Tufuli Arabic DEMO Medium", 12F, System.Drawing.FontStyle.Bold);
            this.but_delete.ForeColor = System.Drawing.Color.Black;
            this.but_delete.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.but_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_delete.Location = new System.Drawing.Point(154, 29);
            this.but_delete.Name = "but_delete";
            this.but_delete.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.but_delete.Size = new System.Drawing.Size(108, 43);
            this.but_delete.TabIndex = 14;
            this.but_delete.Text = "حذف";
            this.but_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_new
            // 
            this.but_new.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.but_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_new.Font = new System.Drawing.Font("Tufuli Arabic DEMO Medium", 12F, System.Drawing.FontStyle.Bold);
            this.but_new.ForeColor = System.Drawing.Color.Black;
            this.but_new.Image = global::Qusai.Properties.Resources.refresh_arrows_14418;
            this.but_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_new.Location = new System.Drawing.Point(382, 29);
            this.but_new.Name = "but_new";
            this.but_new.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.but_new.Size = new System.Drawing.Size(100, 43);
            this.but_new.TabIndex = 12;
            this.but_new.Text = "جديد";
            this.but_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_new.UseVisualStyleBackColor = true;
            this.but_new.Click += new System.EventHandler(this.but_new_Click);
            // 
            // Classroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Classroom";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom";
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label butFirst;
        public System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_new;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label butPrevious;
        private System.Windows.Forms.Label butNext;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label butLast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textname;
    }
}