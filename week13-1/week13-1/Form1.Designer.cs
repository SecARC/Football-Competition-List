
namespace week13_1
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.competition1 = new week13_1.Competition();
            this.roundButton1 = new week13_1.RoundButton();
            this.competition2 = new week13_1.Competition();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(205, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(149, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "0 - 0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Turkiye Superlig";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(188, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "25/05/2021 13:00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.competition1);
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Location = new System.Drawing.Point(13, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 435);
            this.panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(862, 320);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // competition1
            // 
            this.competition1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.competition1.AutoSize = true;
            this.competition1.BackColor = System.Drawing.SystemColors.Control;
            this.competition1.CompetitionDate = new System.DateTime(((long)(0)));
            this.competition1.Location = new System.Drawing.Point(371, 5);
            this.competition1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.competition1.MaximumSize = new System.Drawing.Size(495, 100);
            this.competition1.MinimumSize = new System.Drawing.Size(495, 100);
            this.competition1.Name = "competition1";
            this.competition1.Score = new System.Drawing.Point(0, 0);
            this.competition1.Size = new System.Drawing.Size(495, 100);
            this.competition1.TabIndex = 1;
            this.competition1.Team1 = "Team1";
            this.competition1.Team2 = "Team2";
            this.competition1.Tournament = "Turkiye Superlig";
            // 
            // roundButton1
            // 
            this.roundButton1.Location = new System.Drawing.Point(4, 5);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(169, 100);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "Load Data";
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // competition2
            // 
            this.competition2.AutoSize = true;
            this.competition2.BackColor = System.Drawing.SystemColors.Control;
            this.competition2.CompetitionDate = new System.DateTime(2021, 5, 26, 21, 52, 41, 0);
            this.competition2.Location = new System.Drawing.Point(485, 14);
            this.competition2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.competition2.MaximumSize = new System.Drawing.Size(495, 100);
            this.competition2.MinimumSize = new System.Drawing.Size(495, 100);
            this.competition2.Name = "competition2";
            this.competition2.Score = new System.Drawing.Point(0, 0);
            this.competition2.Size = new System.Drawing.Size(495, 100);
            this.competition2.TabIndex = 10;
            this.competition2.Team1 = "Team1";
            this.competition2.Team2 = "Team2";
            this.competition2.Tournament = "Turkiye Superlig";
            this.competition2.Load += new System.EventHandler(this.competition2_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.competition2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Competition competition2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Competition competition1;
        private RoundButton roundButton1;
    }
}

