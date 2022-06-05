
namespace QuestionsForKids
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ogrencibtn = new System.Windows.Forms.Button();
            this.cocukbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ogrencibtn
            // 
            this.ogrencibtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ogrencibtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ogrencibtn.Location = new System.Drawing.Point(13, 72);
            this.ogrencibtn.Name = "ogrencibtn";
            this.ogrencibtn.Size = new System.Drawing.Size(196, 63);
            this.ogrencibtn.TabIndex = 0;
            this.ogrencibtn.Text = "Okuma Yazma Bilenler İçin";
            this.ogrencibtn.UseVisualStyleBackColor = true;
            this.ogrencibtn.Click += new System.EventHandler(this.ogrencibtn_Click);
            // 
            // cocukbtn
            // 
            this.cocukbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cocukbtn.ForeColor = System.Drawing.Color.Firebrick;
            this.cocukbtn.Location = new System.Drawing.Point(13, 151);
            this.cocukbtn.Name = "cocukbtn";
            this.cocukbtn.Size = new System.Drawing.Size(196, 63);
            this.cocukbtn.TabIndex = 1;
            this.cocukbtn.Text = "Okuma Yazma Bilmeyenler İçin";
            this.cocukbtn.UseVisualStyleBackColor = true;
            this.cocukbtn.Click += new System.EventHandler(this.cocukbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minikler İçin Eğitim";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Sienna;
            this.button1.Location = new System.Drawing.Point(13, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Soru Ekle/Çıkar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(568, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cocukbtn);
            this.Controls.Add(this.ogrencibtn);
            this.Name = "Form1";
            this.Text = "Minikler İçin Eğitim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ogrencibtn;
        private System.Windows.Forms.Button cocukbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

