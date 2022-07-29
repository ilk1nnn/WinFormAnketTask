namespace WinFormAnketTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.surname_txtbox = new System.Windows.Forms.TextBox();
            this.age_lbl = new System.Windows.Forms.Label();
            this.age_txtbox = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.nameshould = new System.Windows.Forms.Label();
            this.surnameshould = new System.Windows.Forms.Label();
            this.ageshould = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registershould = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(250, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // nametxtbox
            // 
            this.nametxtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxtbox.Location = new System.Drawing.Point(231, 123);
            this.nametxtbox.Multiline = true;
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(238, 27);
            this.nametxtbox.TabIndex = 1;
            this.nametxtbox.TextChanged += new System.EventHandler(this.nametxtbox_TextChanged);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.name_lbl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.name_lbl.Location = new System.Drawing.Point(227, 99);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(55, 21);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "Name:";
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.BackColor = System.Drawing.Color.Transparent;
            this.surname_label.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.surname_label.Location = new System.Drawing.Point(227, 185);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(76, 21);
            this.surname_label.TabIndex = 4;
            this.surname_label.Text = "Surname:";
            // 
            // surname_txtbox
            // 
            this.surname_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.surname_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_txtbox.Location = new System.Drawing.Point(231, 209);
            this.surname_txtbox.Multiline = true;
            this.surname_txtbox.Name = "surname_txtbox";
            this.surname_txtbox.Size = new System.Drawing.Size(238, 27);
            this.surname_txtbox.TabIndex = 3;
            this.surname_txtbox.TextChanged += new System.EventHandler(this.surname_txtbox_TextChanged);
            // 
            // age_lbl
            // 
            this.age_lbl.AutoSize = true;
            this.age_lbl.BackColor = System.Drawing.Color.Transparent;
            this.age_lbl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.age_lbl.Location = new System.Drawing.Point(227, 272);
            this.age_lbl.Name = "age_lbl";
            this.age_lbl.Size = new System.Drawing.Size(79, 21);
            this.age_lbl.TabIndex = 6;
            this.age_lbl.Text = "Speciality:";
            // 
            // age_txtbox
            // 
            this.age_txtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.age_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_txtbox.Location = new System.Drawing.Point(231, 296);
            this.age_txtbox.Multiline = true;
            this.age_txtbox.Name = "age_txtbox";
            this.age_txtbox.Size = new System.Drawing.Size(238, 27);
            this.age_txtbox.TabIndex = 5;
            this.age_txtbox.TextChanged += new System.EventHandler(this.age_txtbox_TextChanged);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.register_btn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(296, 365);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(102, 35);
            this.register_btn.TabIndex = 7;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // nameshould
            // 
            this.nameshould.AutoSize = true;
            this.nameshould.BackColor = System.Drawing.Color.Transparent;
            this.nameshould.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameshould.ForeColor = System.Drawing.Color.Red;
            this.nameshould.Location = new System.Drawing.Point(227, 153);
            this.nameshould.Name = "nameshould";
            this.nameshould.Size = new System.Drawing.Size(0, 15);
            this.nameshould.TabIndex = 8;
            // 
            // surnameshould
            // 
            this.surnameshould.AutoSize = true;
            this.surnameshould.BackColor = System.Drawing.Color.Transparent;
            this.surnameshould.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameshould.ForeColor = System.Drawing.Color.Red;
            this.surnameshould.Location = new System.Drawing.Point(228, 239);
            this.surnameshould.Name = "surnameshould";
            this.surnameshould.Size = new System.Drawing.Size(0, 15);
            this.surnameshould.TabIndex = 9;
            // 
            // ageshould
            // 
            this.ageshould.AutoSize = true;
            this.ageshould.BackColor = System.Drawing.Color.Transparent;
            this.ageshould.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageshould.ForeColor = System.Drawing.Color.Red;
            this.ageshould.Location = new System.Drawing.Point(227, 326);
            this.ageshould.Name = "ageshould";
            this.ageshould.Size = new System.Drawing.Size(0, 15);
            this.ageshould.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(342, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 11;
            // 
            // registershould
            // 
            this.registershould.AutoSize = true;
            this.registershould.BackColor = System.Drawing.Color.Transparent;
            this.registershould.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registershould.ForeColor = System.Drawing.Color.Red;
            this.registershould.Location = new System.Drawing.Point(244, 68);
            this.registershould.Name = "registershould";
            this.registershould.Size = new System.Drawing.Size(0, 21);
            this.registershould.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormAnketTask.Properties.Resources._1_U9lFekOUPmtzDQVMQOpchw;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.registershould);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageshould);
            this.Controls.Add(this.surnameshould);
            this.Controls.Add(this.nameshould);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.age_lbl);
            this.Controls.Add(this.age_txtbox);
            this.Controls.Add(this.surname_label);
            this.Controls.Add(this.surname_txtbox);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label surname_label;
        private System.Windows.Forms.TextBox surname_txtbox;
        private System.Windows.Forms.Label age_lbl;
        private System.Windows.Forms.TextBox age_txtbox;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label nameshould;
        private System.Windows.Forms.Label surnameshould;
        private System.Windows.Forms.Label ageshould;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label registershould;
    }
}

