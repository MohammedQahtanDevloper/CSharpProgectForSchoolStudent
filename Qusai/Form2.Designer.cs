namespace Qusai
{
    partial class Form2
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.position = new System.Windows.Forms.Label();
            this.butPrevious = new System.Windows.Forms.Label();
            this.butNext = new System.Windows.Forms.Label();
            this.butLast = new System.Windows.Forms.Label();
            this.butFirst = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.position);
            this.groupBox4.Controls.Add(this.butPrevious);
            this.groupBox4.Controls.Add(this.butNext);
            this.groupBox4.Controls.Add(this.butLast);
            this.groupBox4.Controls.Add(this.butFirst);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(154, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 97);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "التنقل";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(77, 46);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(33, 22);
            this.position.TabIndex = 4;
            this.position.Text = "7/6";
            // 
            // butPrevious
            // 
            this.butPrevious.AutoSize = true;
            this.butPrevious.Location = new System.Drawing.Point(122, 46);
            this.butPrevious.Name = "butPrevious";
            this.butPrevious.Size = new System.Drawing.Size(28, 22);
            this.butPrevious.TabIndex = 3;
            this.butPrevious.Text = "<<";
            // 
            // butNext
            // 
            this.butNext.AutoSize = true;
            this.butNext.Location = new System.Drawing.Point(41, 46);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(28, 22);
            this.butNext.TabIndex = 2;
            this.butNext.Text = ">>";
            // 
            // butLast
            // 
            this.butLast.AutoSize = true;
            this.butLast.Location = new System.Drawing.Point(6, 46);
            this.butLast.Name = "butLast";
            this.butLast.Size = new System.Drawing.Size(33, 22);
            this.butLast.TabIndex = 1;
            this.butLast.Text = "|>>";
            // 
            // butFirst
            // 
            this.butFirst.AutoSize = true;
            this.butFirst.Location = new System.Drawing.Point(151, 46);
            this.butFirst.Name = "butFirst";
            this.butFirst.Size = new System.Drawing.Size(33, 22);
            this.butFirst.TabIndex = 0;
            this.butFirst.Text = "<<|";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 30);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form2";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label butPrevious;
        private System.Windows.Forms.Label butNext;
        private System.Windows.Forms.Label butLast;
        private System.Windows.Forms.Label butFirst;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}