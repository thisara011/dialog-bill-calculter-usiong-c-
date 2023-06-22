namespace dialog_bill_calculter
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.txt_4 = new System.Windows.Forms.TextBox();
            this.cmb_1 = new System.Windows.Forms.ComboBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(99, 41);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(73, 13);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "data package";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(99, 96);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(65, 13);
            this.lbl_2.TabIndex = 1;
            this.lbl_2.Text = "Units at Day";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Location = new System.Drawing.Point(99, 149);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(71, 13);
            this.lbl_3.TabIndex = 1;
            this.lbl_3.Text = "Units at Night";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Location = new System.Drawing.Point(99, 203);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(45, 13);
            this.lbl_4.TabIndex = 1;
            this.lbl_4.Text = "total  bill";
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(230, 96);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(148, 20);
            this.txt_2.TabIndex = 2;
            // 
            // txt_3
            // 
            this.txt_3.Location = new System.Drawing.Point(230, 149);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(148, 20);
            this.txt_3.TabIndex = 2;
            // 
            // txt_4
            // 
            this.txt_4.Location = new System.Drawing.Point(230, 203);
            this.txt_4.Name = "txt_4";
            this.txt_4.Size = new System.Drawing.Size(148, 20);
            this.txt_4.TabIndex = 2;
            // 
            // cmb_1
            // 
            this.cmb_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_1.FormattingEnabled = true;
            this.cmb_1.Items.AddRange(new object[] {
            "day blaster",
            "night blaster"});
            this.cmb_1.Location = new System.Drawing.Point(230, 41);
            this.cmb_1.Name = "cmb_1";
            this.cmb_1.Size = new System.Drawing.Size(148, 21);
            this.cmb_1.TabIndex = 3;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(36, 270);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(90, 24);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "calculate";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(164, 270);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(90, 24);
            this.btn_2.TabIndex = 4;
            this.btn_2.Text = "clear";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(288, 270);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(90, 24);
            this.btn_3.TabIndex = 4;
            this.btn_3.Text = "exit";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::dialog_bill_calculter.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 344);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.cmb_1);
            this.Controls.Add(this.txt_4);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.TextBox txt_4;
        private System.Windows.Forms.ComboBox cmb_1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
    }
}

