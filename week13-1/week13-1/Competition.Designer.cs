
namespace week13_1
{
    partial class Competition
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTournament = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTeam2 = new System.Windows.Forms.Label();
            this.labelTeam1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDate.Location = new System.Drawing.Point(179, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(147, 20);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "25/05/2021 13:00";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTournament
            // 
            this.labelTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTournament.Location = new System.Drawing.Point(0, 0);
            this.labelTournament.Name = "labelTournament";
            this.labelTournament.Size = new System.Drawing.Size(127, 20);
            this.labelTournament.TabIndex = 12;
            this.labelTournament.Text = "Turkiye Superlig";
            this.labelTournament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelScore.Location = new System.Drawing.Point(140, 37);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(50, 20);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "0 - 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTeam2
            // 
            this.labelTeam2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTeam2.Location = new System.Drawing.Point(196, 37);
            this.labelTeam2.Name = "labelTeam2";
            this.labelTeam2.Size = new System.Drawing.Size(130, 20);
            this.labelTeam2.TabIndex = 10;
            this.labelTeam2.Text = "Team2";
            this.labelTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTeam1
            // 
            this.labelTeam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTeam1.Location = new System.Drawing.Point(4, 37);
            this.labelTeam1.Name = "labelTeam1";
            this.labelTeam1.Size = new System.Drawing.Size(130, 20);
            this.labelTeam1.TabIndex = 9;
            this.labelTeam1.Text = "Team1";
            this.labelTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Competition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTournament);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTeam2);
            this.Controls.Add(this.labelTeam1);
            this.MaximumSize = new System.Drawing.Size(330, 65);
            this.MinimumSize = new System.Drawing.Size(330, 65);
            this.Name = "Competition";
            this.Size = new System.Drawing.Size(330, 65);
            this.Load += new System.EventHandler(this.Competition_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTournament;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTeam2;
        private System.Windows.Forms.Label labelTeam1;
    }
}
