namespace metro_other_forms_with_sql
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
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.Home = new MetroFramework.Controls.MetroTile();
            this.Reg_cli = new MetroFramework.Controls.MetroTile();
            this.Del_cli = new MetroFramework.Controls.MetroTile();
            this.Upd_cli = new MetroFramework.Controls.MetroTile();
            this.Pro = new MetroFramework.Controls.MetroTile();
            this.mng_rep = new MetroFramework.Controls.MetroTile();
            this.New_user = new MetroFramework.Controls.MetroTile();
            this.Mng_dash = new MetroFramework.Controls.MetroTile();
            this.Search_cli = new MetroFramework.Controls.MetroTile();
            this.Comments = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(702, 26);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 0;
            this.metroLink1.Text = "Next >>";
            this.metroLink1.UseSelectable = true;
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(621, 26);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(75, 23);
            this.metroLink2.TabIndex = 1;
            this.metroLink2.Text = "<< Back";
            this.metroLink2.UseSelectable = true;
            // 
            // Home
            // 
            this.Home.ActiveControl = null;
            this.Home.BackColor = System.Drawing.Color.Lime;
            this.Home.Location = new System.Drawing.Point(23, 80);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(172, 108);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseSelectable = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Reg_cli
            // 
            this.Reg_cli.ActiveControl = null;
            this.Reg_cli.Location = new System.Drawing.Point(227, 80);
            this.Reg_cli.Name = "Reg_cli";
            this.Reg_cli.Size = new System.Drawing.Size(172, 108);
            this.Reg_cli.TabIndex = 3;
            this.Reg_cli.Text = "Register Client";
            this.Reg_cli.UseSelectable = true;
            this.Reg_cli.Click += new System.EventHandler(this.Reg_cli_Click);
            // 
            // Del_cli
            // 
            this.Del_cli.ActiveControl = null;
            this.Del_cli.Location = new System.Drawing.Point(227, 213);
            this.Del_cli.Name = "Del_cli";
            this.Del_cli.Size = new System.Drawing.Size(172, 108);
            this.Del_cli.TabIndex = 5;
            this.Del_cli.Text = "Delete Client";
            this.Del_cli.UseSelectable = true;
            this.Del_cli.Click += new System.EventHandler(this.Del_cli_Click);
            // 
            // Upd_cli
            // 
            this.Upd_cli.ActiveControl = null;
            this.Upd_cli.BackColor = System.Drawing.Color.Lime;
            this.Upd_cli.Location = new System.Drawing.Point(23, 213);
            this.Upd_cli.Name = "Upd_cli";
            this.Upd_cli.Size = new System.Drawing.Size(172, 108);
            this.Upd_cli.TabIndex = 4;
            this.Upd_cli.Text = "Update client";
            this.Upd_cli.UseSelectable = true;
            this.Upd_cli.Click += new System.EventHandler(this.Upd_cli_Click);
            // 
            // Pro
            // 
            this.Pro.ActiveControl = null;
            this.Pro.Location = new System.Drawing.Point(621, 80);
            this.Pro.Name = "Pro";
            this.Pro.Size = new System.Drawing.Size(172, 108);
            this.Pro.TabIndex = 7;
            this.Pro.Text = "Progress";
            this.Pro.UseSelectable = true;
            // 
            // mng_rep
            // 
            this.mng_rep.ActiveControl = null;
            this.mng_rep.BackColor = System.Drawing.Color.Lime;
            this.mng_rep.Location = new System.Drawing.Point(417, 80);
            this.mng_rep.Name = "mng_rep";
            this.mng_rep.Size = new System.Drawing.Size(172, 108);
            this.mng_rep.TabIndex = 6;
            this.mng_rep.Text = "Manage Reports";
            this.mng_rep.UseSelectable = true;
            // 
            // New_user
            // 
            this.New_user.ActiveControl = null;
            this.New_user.Location = new System.Drawing.Point(621, 213);
            this.New_user.Name = "New_user";
            this.New_user.Size = new System.Drawing.Size(172, 108);
            this.New_user.TabIndex = 9;
            this.New_user.Text = "Create User";
            this.New_user.UseSelectable = true;
            // 
            // Mng_dash
            // 
            this.Mng_dash.ActiveControl = null;
            this.Mng_dash.BackColor = System.Drawing.Color.Lime;
            this.Mng_dash.Location = new System.Drawing.Point(417, 213);
            this.Mng_dash.Name = "Mng_dash";
            this.Mng_dash.Size = new System.Drawing.Size(172, 108);
            this.Mng_dash.TabIndex = 8;
            this.Mng_dash.Text = "Management DashBoard";
            this.Mng_dash.UseSelectable = true;
            // 
            // Search_cli
            // 
            this.Search_cli.ActiveControl = null;
            this.Search_cli.Location = new System.Drawing.Point(66, 337);
            this.Search_cli.Name = "Search_cli";
            this.Search_cli.Size = new System.Drawing.Size(282, 122);
            this.Search_cli.TabIndex = 10;
            this.Search_cli.Text = "Veiw and Search Clients";
            this.Search_cli.UseSelectable = true;
            this.Search_cli.Click += new System.EventHandler(this.Search_cli_Click);
            // 
            // Comments
            // 
            this.Comments.ActiveControl = null;
            this.Comments.Location = new System.Drawing.Point(476, 337);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(282, 122);
            this.Comments.TabIndex = 11;
            this.Comments.Text = "comments";
            this.Comments.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 482);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.Search_cli);
            this.Controls.Add(this.New_user);
            this.Controls.Add(this.Mng_dash);
            this.Controls.Add(this.Pro);
            this.Controls.Add(this.mng_rep);
            this.Controls.Add(this.Del_cli);
            this.Controls.Add(this.Upd_cli);
            this.Controls.Add(this.Reg_cli);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Name = "Form1";
            this.Text = "Home Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroTile Home;
        private MetroFramework.Controls.MetroTile Reg_cli;
        private MetroFramework.Controls.MetroTile Del_cli;
        private MetroFramework.Controls.MetroTile Upd_cli;
        private MetroFramework.Controls.MetroTile Pro;
        private MetroFramework.Controls.MetroTile mng_rep;
        private MetroFramework.Controls.MetroTile New_user;
        private MetroFramework.Controls.MetroTile Mng_dash;
        private MetroFramework.Controls.MetroTile Search_cli;
        private MetroFramework.Controls.MetroTile Comments;
    }
}

