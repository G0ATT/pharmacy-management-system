
namespace project_4
{
    partial class billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billing));
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_bott = new System.Windows.Forms.Button();
            this.ext_bott = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bill_DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reset_bott = new System.Windows.Forms.Button();
            this.print_text = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prod_text = new System.Windows.Forms.TextBox();
            this.add_bott = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.qunt_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cname_text = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prod_DGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cphone_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Totallbl = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_DGV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prod_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::project_4.Properties.Resources.banner11;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(276, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(212, 95);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
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
            this.panel1.Size = new System.Drawing.Size(785, 105);
            this.panel1.TabIndex = 39;
            // 
            // back_bott
            // 
            this.back_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_bott.BackColor = System.Drawing.Color.Transparent;
            this.back_bott.BackgroundImage = global::project_4.Properties.Resources.arrow_small_left;
            this.back_bott.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_bott.FlatAppearance.BorderSize = 0;
            this.back_bott.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_bott.Location = new System.Drawing.Point(3, 6);
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
            this.ext_bott.Location = new System.Drawing.Point(751, 12);
            this.ext_bott.Name = "ext_bott";
            this.ext_bott.Size = new System.Drawing.Size(20, 30);
            this.ext_bott.TabIndex = 9;
            this.ext_bott.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ext_bott.UseVisualStyleBackColor = true;
            this.ext_bott.Click += new System.EventHandler(this.ext_bott_Click);
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
            this.panel2.Controls.Add(this.bill_DGV);
            this.panel2.Location = new System.Drawing.Point(392, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 347);
            this.panel2.TabIndex = 90;
            // 
            // bill_DGV
            // 
            this.bill_DGV.AllowUserToAddRows = false;
            this.bill_DGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bill_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bill_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.bill_DGV.Location = new System.Drawing.Point(0, 0);
            this.bill_DGV.Name = "bill_DGV";
            this.bill_DGV.Size = new System.Drawing.Size(360, 347);
            this.bill_DGV.TabIndex = 47;
            this.bill_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bill_DGV_CellContentClick);
            this.bill_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bill_DGV_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 52;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.Width = 95;
            // 
            // reset_bott
            // 
            this.reset_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reset_bott.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.reset_bott.Location = new System.Drawing.Point(286, 201);
            this.reset_bott.Name = "reset_bott";
            this.reset_bott.Size = new System.Drawing.Size(61, 30);
            this.reset_bott.TabIndex = 6;
            this.reset_bott.Text = "Reset";
            this.reset_bott.UseVisualStyleBackColor = true;
            this.reset_bott.Click += new System.EventHandler(this.button4_Click);
            // 
            // print_text
            // 
            this.print_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.print_text.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.print_text.Location = new System.Drawing.Point(393, 509);
            this.print_text.Name = "print_text";
            this.print_text.Size = new System.Drawing.Size(61, 36);
            this.print_text.TabIndex = 7;
            this.print_text.Text = "Print";
            this.print_text.UseVisualStyleBackColor = true;
            this.print_text.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "product";
            // 
            // prod_text
            // 
            this.prod_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prod_text.Enabled = false;
            this.prod_text.Location = new System.Drawing.Point(34, 156);
            this.prod_text.Name = "prod_text";
            this.prod_text.Size = new System.Drawing.Size(141, 22);
            this.prod_text.TabIndex = 1;
            // 
            // add_bott
            // 
            this.add_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_bott.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.add_bott.Location = new System.Drawing.Point(206, 201);
            this.add_bott.Name = "add_bott";
            this.add_bott.Size = new System.Drawing.Size(61, 30);
            this.add_bott.TabIndex = 5;
            this.add_bott.Text = "ADD";
            this.add_bott.UseVisualStyleBackColor = true;
            this.add_bott.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 92;
            this.label1.Text = "quantity";
            // 
            // qunt_text
            // 
            this.qunt_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.qunt_text.Location = new System.Drawing.Point(206, 156);
            this.qunt_text.Name = "qunt_text";
            this.qunt_text.Size = new System.Drawing.Size(141, 22);
            this.qunt_text.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 94;
            this.label3.Text = "Client_Name";
            // 
            // cname_text
            // 
            this.cname_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cname_text.Location = new System.Drawing.Point(34, 209);
            this.cname_text.Name = "cname_text";
            this.cname_text.Size = new System.Drawing.Size(141, 22);
            this.cname_text.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.prod_DGV);
            this.panel3.Location = new System.Drawing.Point(34, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 246);
            this.panel3.TabIndex = 95;
            // 
            // prod_DGV
            // 
            this.prod_DGV.AllowUserToAddRows = false;
            this.prod_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prod_DGV.Location = new System.Drawing.Point(0, 0);
            this.prod_DGV.Name = "prod_DGV";
            this.prod_DGV.Size = new System.Drawing.Size(322, 244);
            this.prod_DGV.TabIndex = 0;
            this.prod_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prod_DGV_CellContentClick);
            this.prod_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prod_DGV_CellContentClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JUICY MILKY", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 97;
            this.label4.Text = "Client_Phone";
            // 
            // cphone_text
            // 
            this.cphone_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cphone_text.Location = new System.Drawing.Point(34, 261);
            this.cphone_text.Name = "cphone_text";
            this.cphone_text.Size = new System.Drawing.Size(141, 22);
            this.cphone_text.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Junior", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.label5.Location = new System.Drawing.Point(329, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 32);
            this.label5.TabIndex = 98;
            this.label5.Text = "BILL";
            // 
            // Totallbl
            // 
            this.Totallbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Totallbl.AutoSize = true;
            this.Totallbl.Font = new System.Drawing.Font("Junior", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallbl.Location = new System.Drawing.Point(666, 517);
            this.Totallbl.Name = "Totallbl";
            this.Totallbl.Size = new System.Drawing.Size(55, 27);
            this.Totallbl.TabIndex = 99;
            this.Totallbl.Text = "Total";
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.Font = new System.Drawing.Font("Junior", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time.Location = new System.Drawing.Point(208, 261);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(139, 22);
            this.time.TabIndex = 70;
            this.time.Value = new System.DateTime(2022, 6, 3, 2, 10, 18, 0);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 571);
            this.Controls.Add(this.time);
            this.Controls.Add(this.Totallbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cphone_text);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cname_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qunt_text);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reset_bott);
            this.Controls.Add(this.print_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prod_text);
            this.Controls.Add(this.add_bott);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("JUICY MILKY", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "billing";
            this.Load += new System.EventHandler(this.billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bill_DGV)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prod_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_bott;
        private System.Windows.Forms.Button ext_bott;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView bill_DGV;
        private System.Windows.Forms.Button reset_bott;
        private System.Windows.Forms.Button print_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prod_text;
        private System.Windows.Forms.Button add_bott;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qunt_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cname_text;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView prod_DGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cphone_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Totallbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker time;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}