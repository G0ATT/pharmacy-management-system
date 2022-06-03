
namespace project_4
{
    partial class suppliers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_bott = new System.Windows.Forms.Button();
            this.ext_bott = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supp_DGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.delete_text = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.add_bott = new System.Windows.Forms.Button();
            this.edit_bott = new System.Windows.Forms.Button();
            this.clear_bott = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supp_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.back_bott);
            this.panel1.Controls.Add(this.ext_bott);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 105);
            this.panel1.TabIndex = 38;
            // 
            // back_bott
            // 
            this.back_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_bott.BackColor = System.Drawing.Color.Transparent;
            this.back_bott.BackgroundImage = global::project_4.Properties.Resources.arrow_small_left;
            this.back_bott.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_bott.FlatAppearance.BorderSize = 0;
            this.back_bott.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_bott.Location = new System.Drawing.Point(3, 9);
            this.back_bott.Name = "back_bott";
            this.back_bott.Size = new System.Drawing.Size(42, 36);
            this.back_bott.TabIndex = 8;
            this.back_bott.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back_bott.UseVisualStyleBackColor = false;
            this.back_bott.Click += new System.EventHandler(this.back_bott_Click);
            // 
            // ext_bott
            // 
            this.ext_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ext_bott.BackgroundImage = global::project_4.Properties.Resources.cross;
            this.ext_bott.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ext_bott.FlatAppearance.BorderSize = 0;
            this.ext_bott.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ext_bott.Location = new System.Drawing.Point(656, 12);
            this.ext_bott.Name = "ext_bott";
            this.ext_bott.Size = new System.Drawing.Size(20, 30);
            this.ext_bott.TabIndex = 9;
            this.ext_bott.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ext_bott.UseVisualStyleBackColor = true;
            this.ext_bott.Click += new System.EventHandler(this.ext_bott_Click);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::project_4.Properties.Resources.banner11;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(228, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(212, 95);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(940, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 35);
            this.button3.TabIndex = 6;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.supp_DGV);
            this.panel2.Location = new System.Drawing.Point(303, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 367);
            this.panel2.TabIndex = 84;
            // 
            // supp_DGV
            // 
            this.supp_DGV.AllowUserToAddRows = false;
            this.supp_DGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supp_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supp_DGV.Location = new System.Drawing.Point(0, 0);
            this.supp_DGV.Name = "supp_DGV";
            this.supp_DGV.Size = new System.Drawing.Size(361, 367);
            this.supp_DGV.TabIndex = 47;
            this.supp_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supp_DGV_CellContentClick);
            this.supp_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supp_DGV_CellContentClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 83;
            this.label4.Text = "email";
            // 
            // email_text
            // 
            this.email_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email_text.Location = new System.Drawing.Point(48, 317);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(229, 22);
            this.email_text.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "phone";
            // 
            // phone_text
            // 
            this.phone_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phone_text.Location = new System.Drawing.Point(48, 242);
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(229, 22);
            this.phone_text.TabIndex = 2;
            // 
            // delete_text
            // 
            this.delete_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_text.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.delete_text.Location = new System.Drawing.Point(130, 500);
            this.delete_text.Name = "delete_text";
            this.delete_text.Size = new System.Drawing.Size(63, 36);
            this.delete_text.TabIndex = 7;
            this.delete_text.Text = "delete";
            this.delete_text.UseVisualStyleBackColor = true;
            this.delete_text.Click += new System.EventHandler(this.delete_text_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "name";
            // 
            // name_text
            // 
            this.name_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_text.Location = new System.Drawing.Point(48, 167);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(229, 22);
            this.name_text.TabIndex = 1;
            this.name_text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // add_bott
            // 
            this.add_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_bott.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.add_bott.Location = new System.Drawing.Point(48, 458);
            this.add_bott.Name = "add_bott";
            this.add_bott.Size = new System.Drawing.Size(63, 36);
            this.add_bott.TabIndex = 4;
            this.add_bott.Text = "ADD";
            this.add_bott.UseVisualStyleBackColor = true;
            this.add_bott.Click += new System.EventHandler(this.add_bott_Click);
            // 
            // edit_bott
            // 
            this.edit_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit_bott.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.edit_bott.Location = new System.Drawing.Point(130, 458);
            this.edit_bott.Name = "edit_bott";
            this.edit_bott.Size = new System.Drawing.Size(63, 36);
            this.edit_bott.TabIndex = 5;
            this.edit_bott.Text = "Edit";
            this.edit_bott.UseVisualStyleBackColor = true;
            this.edit_bott.Click += new System.EventHandler(this.edit_bott_Click);
            // 
            // clear_bott
            // 
            this.clear_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clear_bott.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.clear_bott.Location = new System.Drawing.Point(214, 458);
            this.clear_bott.Name = "clear_bott";
            this.clear_bott.Size = new System.Drawing.Size(63, 36);
            this.clear_bott.TabIndex = 6;
            this.clear_bott.Text = "clear";
            this.clear_bott.UseVisualStyleBackColor = true;
            this.clear_bott.Click += new System.EventHandler(this.clear_bott_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Junior", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.label5.Location = new System.Drawing.Point(244, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 32);
            this.label5.TabIndex = 99;
            this.label5.Text = "SUPPLIERS";
            // 
            // suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 571);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clear_bott);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phone_text);
            this.Controls.Add(this.edit_bott);
            this.Controls.Add(this.delete_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.add_bott);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("JUICY MILKY", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "suppliers";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supp_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_bott;
        private System.Windows.Forms.Button ext_bott;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView supp_DGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone_text;
        private System.Windows.Forms.Button delete_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Button add_bott;
        private System.Windows.Forms.Button edit_bott;
        private System.Windows.Forms.Button clear_bott;
        private System.Windows.Forms.Label label5;
    }
}