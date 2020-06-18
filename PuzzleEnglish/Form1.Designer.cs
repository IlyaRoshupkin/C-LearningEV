namespace PuzzleEnglish
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblRussian = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.picCard = new System.Windows.Forms.PictureBox();
            this.lblVideo = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrev.Location = new System.Drawing.Point(12, 190);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(105, 80);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(643, 190);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 80);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblRussian
            // 
            this.lblRussian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRussian.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRussian.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblRussian.Location = new System.Drawing.Point(123, 9);
            this.lblRussian.Name = "lblRussian";
            this.lblRussian.Size = new System.Drawing.Size(514, 66);
            this.lblRussian.TabIndex = 2;
            this.lblRussian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnglish
            // 
            this.lblEnglish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnglish.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnglish.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEnglish.Location = new System.Drawing.Point(123, 401);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(514, 66);
            this.lblEnglish.TabIndex = 3;
            this.lblEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCard
            // 
            this.picCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCard.Location = new System.Drawing.Point(123, 78);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(514, 320);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCard.TabIndex = 4;
            this.picCard.TabStop = false;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVideo.Location = new System.Drawing.Point(663, 87);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(67, 17);
            this.lblVideo.TabIndex = 5;
            this.lblVideo.Text = "+ video";
            this.lblVideo.Visible = false;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(123, 77);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(514, 321);
            this.player.TabIndex = 6;
            this.player.Visible = false;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 476);
            this.Controls.Add(this.player);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.picCard);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblRussian);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Name = "form";
            this.Text = "Puzzle English";
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblRussian;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.Label lblVideo;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

