namespace TV
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonNEXT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonEXIT.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonEXIT.FlatAppearance.BorderSize = 0;
            this.buttonEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEXIT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEXIT.Location = new System.Drawing.Point(120, 296);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(82, 32);
            this.buttonEXIT.TabIndex = 1;
            this.buttonEXIT.Text = "ВЫХОД";
            this.buttonEXIT.UseVisualStyleBackColor = false;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Orange;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "КАНАЛ №1 - \"Рыжий\"",
            "КАНАЛ №2 - \"Смайлик ТВ\"",
            "КАНАЛ №3 - \"Song TV\"",
            "КАНАЛ №4 - \"Спорт-1\"",
            "КАНАЛ №5 - \"Мультиландия\"",
            "КАНАЛ №6 - \"Отдых\"",
            "КАНАЛ №7 - \"Моя Удмуртия\"",
            "КАНАЛ №8 - \"Телекафе\"",
            "КАНАЛ №9 - \"Cоюз Фильм\""});
            this.listBox1.Location = new System.Drawing.Point(64, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 176);
            this.listBox1.TabIndex = 2;
            // 
            // buttonNEXT
            // 
            this.buttonNEXT.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonNEXT.FlatAppearance.BorderSize = 0;
            this.buttonNEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNEXT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNEXT.Location = new System.Drawing.Point(291, 296);
            this.buttonNEXT.Name = "buttonNEXT";
            this.buttonNEXT.Size = new System.Drawing.Size(82, 32);
            this.buttonNEXT.TabIndex = 3;
            this.buttonNEXT.Text = "ДАЛЕЕ";
            this.buttonNEXT.UseVisualStyleBackColor = false;
            this.buttonNEXT.Click += new System.EventHandler(this.buttonNEXT_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Информация для пользователя";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(487, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNEXT);
            this.Controls.Add(this.buttonEXIT);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TV";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonEXIT;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonNEXT;
        private System.Windows.Forms.Label label1;
    }
}