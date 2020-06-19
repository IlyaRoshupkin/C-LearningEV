namespace Passwords
{
    partial class FormPassword
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPassword));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPassword3 = new System.Windows.Forms.Button();
            this.llSite3 = new System.Windows.Forms.LinkLabel();
            this.tbLogin2 = new System.Windows.Forms.TextBox();
            this.btnPassword2 = new System.Windows.Forms.Button();
            this.llSite2 = new System.Windows.Forms.LinkLabel();
            this.tbLogin3 = new System.Windows.Forms.TextBox();
            this.btnPassword1 = new System.Windows.Forms.Button();
            this.llSite1 = new System.Windows.Forms.LinkLabel();
            this.tbLogin1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnPassword3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.llSite3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbLogin2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPassword2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.llSite2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbLogin3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPassword1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.llSite1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbLogin1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 372);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPassword3
            // 
            this.btnPassword3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassword3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPassword3.Location = new System.Drawing.Point(527, 251);
            this.btnPassword3.Name = "btnPassword3";
            this.btnPassword3.Size = new System.Drawing.Size(258, 118);
            this.btnPassword3.TabIndex = 12;
            this.btnPassword3.Tag = "483723Spartak794499SKUBJS792160";
            this.btnPassword3.Text = "Password";
            this.btnPassword3.UseVisualStyleBackColor = true;
            this.btnPassword3.Click += new System.EventHandler(this.btnPassword1_Click);
            // 
            // llSite3
            // 
            this.llSite3.AutoSize = true;
            this.llSite3.BackColor = System.Drawing.Color.LawnGreen;
            this.llSite3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llSite3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llSite3.Location = new System.Drawing.Point(3, 248);
            this.llSite3.Name = "llSite3";
            this.llSite3.Size = new System.Drawing.Size(256, 124);
            this.llSite3.TabIndex = 11;
            this.llSite3.TabStop = true;
            this.llSite3.Text = "VK";
            this.llSite3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llSite3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSite1_LinkClicked);
            // 
            // tbLogin2
            // 
            this.tbLogin2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbLogin2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogin2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin2.Location = new System.Drawing.Point(265, 127);
            this.tbLogin2.Multiline = true;
            this.tbLogin2.Name = "tbLogin2";
            this.tbLogin2.ReadOnly = true;
            this.tbLogin2.Size = new System.Drawing.Size(256, 118);
            this.tbLogin2.TabIndex = 10;
            this.tbLogin2.Text = "roshupkin.ilya2012@yandex.ru";
            this.tbLogin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLogin2.Click += new System.EventHandler(this.tbLogin1_Click);
            // 
            // btnPassword2
            // 
            this.btnPassword2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassword2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPassword2.Location = new System.Drawing.Point(527, 127);
            this.btnPassword2.Name = "btnPassword2";
            this.btnPassword2.Size = new System.Drawing.Size(258, 118);
            this.btnPassword2.TabIndex = 9;
            this.btnPassword2.Tag = "483723Spartak794499SKUBJS792160";
            this.btnPassword2.Text = "Password";
            this.btnPassword2.UseVisualStyleBackColor = true;
            this.btnPassword2.Click += new System.EventHandler(this.btnPassword1_Click);
            // 
            // llSite2
            // 
            this.llSite2.AutoSize = true;
            this.llSite2.BackColor = System.Drawing.Color.LawnGreen;
            this.llSite2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llSite2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llSite2.Location = new System.Drawing.Point(3, 124);
            this.llSite2.Name = "llSite2";
            this.llSite2.Size = new System.Drawing.Size(256, 124);
            this.llSite2.TabIndex = 8;
            this.llSite2.TabStop = true;
            this.llSite2.Text = "Yandex";
            this.llSite2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llSite2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSite1_LinkClicked);
            // 
            // tbLogin3
            // 
            this.tbLogin3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbLogin3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogin3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin3.Location = new System.Drawing.Point(265, 251);
            this.tbLogin3.Multiline = true;
            this.tbLogin3.Name = "tbLogin3";
            this.tbLogin3.ReadOnly = true;
            this.tbLogin3.Size = new System.Drawing.Size(256, 118);
            this.tbLogin3.TabIndex = 6;
            this.tbLogin3.Text = "roshupkin.ilya2012@yandex.ru";
            this.tbLogin3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLogin3.Click += new System.EventHandler(this.tbLogin1_Click);
            // 
            // btnPassword1
            // 
            this.btnPassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassword1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPassword1.Location = new System.Drawing.Point(527, 3);
            this.btnPassword1.Name = "btnPassword1";
            this.btnPassword1.Size = new System.Drawing.Size(258, 118);
            this.btnPassword1.TabIndex = 3;
            this.btnPassword1.Tag = "483723Spartak";
            this.btnPassword1.Text = "Password";
            this.btnPassword1.UseVisualStyleBackColor = true;
            this.btnPassword1.Click += new System.EventHandler(this.btnPassword1_Click);
            // 
            // llSite1
            // 
            this.llSite1.AutoSize = true;
            this.llSite1.BackColor = System.Drawing.Color.LawnGreen;
            this.llSite1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llSite1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llSite1.Location = new System.Drawing.Point(3, 0);
            this.llSite1.Name = "llSite1";
            this.llSite1.Size = new System.Drawing.Size(256, 124);
            this.llSite1.TabIndex = 1;
            this.llSite1.TabStop = true;
            this.llSite1.Tag = "https://www.videosharp.info/";
            this.llSite1.Text = "Site www.VideoSharp.info";
            this.llSite1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llSite1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSite1_LinkClicked);
            // 
            // tbLogin1
            // 
            this.tbLogin1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogin1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin1.Location = new System.Drawing.Point(265, 3);
            this.tbLogin1.Multiline = true;
            this.tbLogin1.Name = "tbLogin1";
            this.tbLogin1.ReadOnly = true;
            this.tbLogin1.Size = new System.Drawing.Size(256, 118);
            this.tbLogin1.TabIndex = 4;
            this.tbLogin1.Text = "roshupkin.ilya2012@yandex.ru";
            this.tbLogin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLogin1.Click += new System.EventHandler(this.tbLogin1_Click);
            // 
            // FormPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 372);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Passwords";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPassword1;
        private System.Windows.Forms.LinkLabel llSite1;
        private System.Windows.Forms.TextBox tbLogin1;
        private System.Windows.Forms.LinkLabel llSite2;
        private System.Windows.Forms.TextBox tbLogin3;
        private System.Windows.Forms.Button btnPassword3;
        private System.Windows.Forms.LinkLabel llSite3;
        private System.Windows.Forms.TextBox tbLogin2;
        private System.Windows.Forms.Button btnPassword2;
        private System.Windows.Forms.Timer timer1;
    }
}

