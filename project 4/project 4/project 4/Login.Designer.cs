
namespace project_4
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_text = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.Log_bott = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.ext_bott = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::project_4.Properties.Resources.banner1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(71, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // user_text
            // 
            this.user_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_text.Location = new System.Drawing.Point(71, 232);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(248, 22);
            this.user_text.TabIndex = 1;
            this.user_text.TextChanged += new System.EventHandler(this.user_text_TextChanged);
            // 
            // pass_text
            // 
            this.pass_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass_text.Location = new System.Drawing.Point(71, 291);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(248, 22);
            this.pass_text.TabIndex = 2;
            // 
            // Log_bott
            // 
            this.Log_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Log_bott.Font = new System.Drawing.Font("JUICY MILKY", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_bott.Location = new System.Drawing.Point(129, 352);
            this.Log_bott.Name = "Log_bott";
            this.Log_bott.Size = new System.Drawing.Size(135, 36);
            this.Log_bott.TabIndex = 3;
            this.Log_bott.Text = "Log in";
            this.Log_bott.UseVisualStyleBackColor = true;
            this.Log_bott.Click += new System.EventHandler(this.Log_botton_Click);
            // 
            // label_user
            // 
            this.label_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("JUICY MILKY", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.label_user.Location = new System.Drawing.Point(73, 210);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(62, 16);
            this.label_user.TabIndex = 4;
            this.label_user.Text = "username";
            // 
            // label_pass
            // 
            this.label_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("JUICY MILKY", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.label_pass.Location = new System.Drawing.Point(73, 272);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(66, 16);
            this.label_pass.TabIndex = 5;
            this.label_pass.Text = "password";
            // 
            // ext_bott
            // 
            this.ext_bott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ext_bott.BackgroundImage = global::project_4.Properties.Resources.cross;
            this.ext_bott.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ext_bott.FlatAppearance.BorderSize = 0;
            this.ext_bott.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ext_bott.Location = new System.Drawing.Point(378, 7);
            this.ext_bott.Name = "ext_bott";
            this.ext_bott.Size = new System.Drawing.Size(10, 15);
            this.ext_bott.TabIndex = 14;
            this.ext_bott.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ext_bott.UseVisualStyleBackColor = true;
            this.ext_bott.Click += new System.EventHandler(this.ext_bott_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 481);
            this.Controls.Add(this.ext_bott);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.Log_bott);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("JUICY MILKY", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.Button Log_bott;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Button ext_bott;
    }
}

