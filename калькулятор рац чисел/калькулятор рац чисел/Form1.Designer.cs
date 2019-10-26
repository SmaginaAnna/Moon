namespace калькулятор_рац_чисел
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ravno = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.otv = new System.Windows.Forms.TextBox();
            this.ch2 = new System.Windows.Forms.TextBox();
            this.z2 = new System.Windows.Forms.TextBox();
            this.z1 = new System.Windows.Forms.TextBox();
            this.ch1 = new System.Windows.Forms.TextBox();
            this.minus = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.umnog = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.deistvie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ravno
            // 
            this.ravno.AutoSize = true;
            this.ravno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ravno.Location = new System.Drawing.Point(350, 81);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(66, 69);
            this.ravno.TabIndex = 26;
            this.ravno.Text = "=";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(681, 283);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(98, 49);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.clear_Click);
            // 
            // otv
            // 
            this.otv.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otv.Location = new System.Drawing.Point(451, 93);
            this.otv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otv.Name = "otv";
            this.otv.Size = new System.Drawing.Size(287, 57);
            this.otv.TabIndex = 24;
            // 
            // ch2
            // 
            this.ch2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch2.Location = new System.Drawing.Point(243, 34);
            this.ch2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(87, 57);
            this.ch2.TabIndex = 23;
            // 
            // z2
            // 
            this.z2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z2.Location = new System.Drawing.Point(243, 139);
            this.z2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(87, 57);
            this.z2.TabIndex = 22;
            // 
            // z1
            // 
            this.z1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z1.Location = new System.Drawing.Point(12, 139);
            this.z1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(87, 57);
            this.z1.TabIndex = 21;
            // 
            // ch1
            // 
            this.ch1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch1.Location = new System.Drawing.Point(12, 34);
            this.ch1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(87, 57);
            this.ch1.TabIndex = 20;
            this.ch1.Click += new System.EventHandler(this.sum_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.minus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(135, 259);
            this.minus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(92, 73);
            this.minus.TabIndex = 19;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.del.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del.Location = new System.Drawing.Point(388, 259);
            this.del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(92, 73);
            this.del.TabIndex = 18;
            this.del.Text = "/";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // umnog
            // 
            this.umnog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.umnog.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umnog.Location = new System.Drawing.Point(262, 259);
            this.umnog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.umnog.Name = "umnog";
            this.umnog.Size = new System.Drawing.Size(92, 73);
            this.umnog.TabIndex = 17;
            this.umnog.Text = "*";
            this.umnog.UseVisualStyleBackColor = false;
            this.umnog.Click += new System.EventHandler(this.umnog_Click);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sum.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(12, 259);
            this.sum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(92, 73);
            this.sum.TabIndex = 16;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = false;
            // 
            // deistvie
            // 
            this.deistvie.AutoSize = true;
            this.deistvie.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.deistvie.Location = new System.Drawing.Point(159, 93);
            this.deistvie.Name = "deistvie";
            this.deistvie.Size = new System.Drawing.Size(0, 49);
            this.deistvie.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.deistvie);
            this.Controls.Add(this.ravno);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.otv);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.del);
            this.Controls.Add(this.umnog);
            this.Controls.Add(this.sum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Калькулятор рациональных чисел";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ravno;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox otv;
        private System.Windows.Forms.TextBox ch2;
        private System.Windows.Forms.TextBox z2;
        private System.Windows.Forms.TextBox z1;
        private System.Windows.Forms.TextBox ch1;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button umnog;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Label deistvie;
    }
}

