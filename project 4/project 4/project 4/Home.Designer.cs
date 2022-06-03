
namespace project_4
{
    partial class Home
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
            this.user = new System.Windows.Forms.Label();
            this.ext_bott = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label_bill = new System.Windows.Forms.Label();
            this.label_supp = new System.Windows.Forms.Label();
            this.label_emp = new System.Windows.Forms.Label();
            this.label_med = new System.Windows.Forms.Label();
            this.bill_bott = new System.Windows.Forms.Button();
            this.emp_bott = new System.Windows.Forms.Button();
            this.supp_bott = new System.Windows.Forms.Button();
            this.med_bott = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ext_bott);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 105);
            this.panel1.TabIndex = 35;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(514, 119);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(27, 14);
            this.user.TabIndex = 7;
            this.user.Text = "user";
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // ext_bott
            // 
            this.ext_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ext_bott.BackgroundImage = global::project_4.Properties.Resources.cross;
            this.ext_bott.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ext_bott.FlatAppearance.BorderSize = 0;
            this.ext_bott.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ext_bott.Location = new System.Drawing.Point(568, 12);
            this.ext_bott.Name = "ext_bott";
            this.ext_bott.Size = new System.Drawing.Size(20, 30);
            this.ext_bott.TabIndex = 5;
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
            this.logo.Location = new System.Drawing.Point(195, 6);
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
            // label_bill
            // 
            this.label_bill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_bill.AutoSize = true;
            this.label_bill.Font = new System.Drawing.Font("JUICY MILKY", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.label_bill.Location = new System.Drawing.Point(339, 480);
            this.label_bill.Name = "label_bill";
            this.label_bill.Size = new System.Drawing.Size(67, 22);
            this.label_bill.TabIndex = 43;
            this.label_bill.Text = "billing";
            // 
            // label_supp
            // 
            this.label_supp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_supp.AutoSize = true;
            this.label_supp.Font = new System.Drawing.Font("JUICY MILKY", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.label_supp.Location = new System.Drawing.Point(59, 480);
            this.label_supp.Name = "label_supp";
            this.label_supp.Size = new System.Drawing.Size(88, 22);
            this.label_supp.TabIndex = 42;
            this.label_supp.Text = "suppliers";
            // 
            // label_emp
            // 
            this.label_emp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_emp.AutoSize = true;
            this.label_emp.Font = new System.Drawing.Font("JUICY MILKY", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.label_emp.Location = new System.Drawing.Point(337, 289);
            this.label_emp.Name = "label_emp";
            this.label_emp.Size = new System.Drawing.Size(85, 22);
            this.label_emp.TabIndex = 41;
            this.label_emp.Text = "employee";
            // 
            // label_med
            // 
            this.label_med.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_med.AutoSize = true;
            this.label_med.Font = new System.Drawing.Font("JUICY MILKY", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.label_med.Location = new System.Drawing.Point(58, 288);
            this.label_med.Name = "label_med";
            this.label_med.Size = new System.Drawing.Size(78, 22);
            this.label_med.TabIndex = 40;
            this.label_med.Text = "medicine";
            // 
            // bill_bott
            // 
            this.bill_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bill_bott.BackColor = System.Drawing.Color.Transparent;
            this.bill_bott.BackgroundImage = global::project_4.Properties.Resources.automated_invoicing;
            this.bill_bott.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bill_bott.Location = new System.Drawing.Point(338, 357);
            this.bill_bott.Name = "bill_bott";
            this.bill_bott.Size = new System.Drawing.Size(203, 146);
            this.bill_bott.TabIndex = 4;
            this.bill_bott.UseVisualStyleBackColor = false;
            this.bill_bott.Click += new System.EventHandler(this.bill_bott_Click);
            // 
            // emp_bott
            // 
            this.emp_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emp_bott.BackColor = System.Drawing.Color.Transparent;
            this.emp_bott.BackgroundImage = global::project_4.Properties.Resources.Top_60_Employee_Engagement_image43_1200x720;
            this.emp_bott.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emp_bott.Location = new System.Drawing.Point(338, 166);
            this.emp_bott.Name = "emp_bott";
            this.emp_bott.Size = new System.Drawing.Size(203, 146);
            this.emp_bott.TabIndex = 2;
            this.emp_bott.UseVisualStyleBackColor = false;
            this.emp_bott.Click += new System.EventHandler(this.emp_bott_Click);
            // 
            // supp_bott
            // 
            this.supp_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supp_bott.BackColor = System.Drawing.Color.Transparent;
            this.supp_bott.BackgroundImage = global::project_4.Properties.Resources.ecommerce_suppliers;
            this.supp_bott.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supp_bott.Location = new System.Drawing.Point(56, 357);
            this.supp_bott.Name = "supp_bott";
            this.supp_bott.Size = new System.Drawing.Size(203, 146);
            this.supp_bott.TabIndex = 3;
            this.supp_bott.UseVisualStyleBackColor = false;
            this.supp_bott.Click += new System.EventHandler(this.supp_bott_Click);
            // 
            // med_bott
            // 
            this.med_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.med_bott.BackColor = System.Drawing.Color.Transparent;
            this.med_bott.BackgroundImage = global::project_4.Properties.Resources._1;
            this.med_bott.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.med_bott.Location = new System.Drawing.Point(56, 166);
            this.med_bott.Name = "med_bott";
            this.med_bott.Size = new System.Drawing.Size(203, 146);
            this.med_bott.TabIndex = 1;
            this.med_bott.UseVisualStyleBackColor = false;
            this.med_bott.Click += new System.EventHandler(this.med_bott_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Junior", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.label1.Location = new System.Drawing.Point(253, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "HOME";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_bill);
            this.Controls.Add(this.label_supp);
            this.Controls.Add(this.label_emp);
            this.Controls.Add(this.label_med);
            this.Controls.Add(this.bill_bott);
            this.Controls.Add(this.emp_bott);
            this.Controls.Add(this.supp_bott);
            this.Controls.Add(this.med_bott);
            this.Font = new System.Drawing.Font("JUICY MILKY", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ext_bott;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_bill;
        private System.Windows.Forms.Label label_supp;
        private System.Windows.Forms.Label label_emp;
        private System.Windows.Forms.Label label_med;
        private System.Windows.Forms.Button bill_bott;
        private System.Windows.Forms.Button emp_bott;
        private System.Windows.Forms.Button supp_bott;
        private System.Windows.Forms.Button med_bott;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
    }
}