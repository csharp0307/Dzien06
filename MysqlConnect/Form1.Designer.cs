
namespace MysqlConnect
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
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbDBName = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbSql = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lvGrid = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(48, 29);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(100, 20);
            this.tbHost.TabIndex = 0;
            this.tbHost.Text = "127.0.0.1";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(48, 73);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 1;
            this.tbUser.Text = "root";
            // 
            // tbDBName
            // 
            this.tbDBName.Location = new System.Drawing.Point(48, 158);
            this.tbDBName.Name = "tbDBName";
            this.tbDBName.Size = new System.Drawing.Size(100, 20);
            this.tbDBName.TabIndex = 3;
            this.tbDBName.Text = "classicmodels";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(48, 114);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 2;
            this.tbPass.Text = "root";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(48, 213);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 60);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Połącz";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbSql
            // 
            this.tbSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSql.Location = new System.Drawing.Point(173, 29);
            this.tbSql.Multiline = true;
            this.tbSql.Name = "tbSql";
            this.tbSql.Size = new System.Drawing.Size(575, 105);
            this.tbSql.TabIndex = 5;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(769, 29);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(163, 105);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Wykonaj SQL";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lvGrid
            // 
            this.lvGrid.HideSelection = false;
            this.lvGrid.Location = new System.Drawing.Point(173, 158);
            this.lvGrid.Name = "lvGrid";
            this.lvGrid.Size = new System.Drawing.Size(759, 370);
            this.lvGrid.TabIndex = 7;
            this.lvGrid.UseCompatibleStateImageBehavior = false;
            this.lvGrid.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 556);
            this.Controls.Add(this.lvGrid);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbSql);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbDBName);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbHost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbDBName;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbSql;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListView lvGrid;
    }
}

