
namespace аттестация_муниципальных_служащих
{
    partial class osnov
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.подготовительныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основнойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.участникиАттестацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вопросыИОтветыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.голосованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заключительныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подготовительныйToolStripMenuItem,
            this.основнойToolStripMenuItem,
            this.заключительныйToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(431, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // подготовительныйToolStripMenuItem
            // 
            this.подготовительныйToolStripMenuItem.Name = "подготовительныйToolStripMenuItem";
            this.подготовительныйToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.подготовительныйToolStripMenuItem.Text = "Подготовительный";
            this.подготовительныйToolStripMenuItem.Click += new System.EventHandler(this.подготовительныйToolStripMenuItem_Click);
            // 
            // основнойToolStripMenuItem
            // 
            this.основнойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.участникиАттестацииToolStripMenuItem,
            this.вопросыИОтветыToolStripMenuItem,
            this.голосованиеToolStripMenuItem});
            this.основнойToolStripMenuItem.Name = "основнойToolStripMenuItem";
            this.основнойToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.основнойToolStripMenuItem.Text = "Основной";
            // 
            // участникиАттестацииToolStripMenuItem
            // 
            this.участникиАттестацииToolStripMenuItem.Name = "участникиАттестацииToolStripMenuItem";
            this.участникиАттестацииToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.участникиАттестацииToolStripMenuItem.Text = "Участники аттестации";
            this.участникиАттестацииToolStripMenuItem.Click += new System.EventHandler(this.участникиАттестацииToolStripMenuItem_Click);
            // 
            // вопросыИОтветыToolStripMenuItem
            // 
            this.вопросыИОтветыToolStripMenuItem.Name = "вопросыИОтветыToolStripMenuItem";
            this.вопросыИОтветыToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.вопросыИОтветыToolStripMenuItem.Text = "Вопросы и ответы";
            this.вопросыИОтветыToolStripMenuItem.Click += new System.EventHandler(this.вопросыИОтветыToolStripMenuItem_Click);
            // 
            // голосованиеToolStripMenuItem
            // 
            this.голосованиеToolStripMenuItem.Name = "голосованиеToolStripMenuItem";
            this.голосованиеToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.голосованиеToolStripMenuItem.Text = "Голосование";
            this.голосованиеToolStripMenuItem.Click += new System.EventHandler(this.голосованиеToolStripMenuItem_Click);
            // 
            // заключительныйToolStripMenuItem
            // 
            this.заключительныйToolStripMenuItem.Name = "заключительныйToolStripMenuItem";
            this.заключительныйToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.заключительныйToolStripMenuItem.Text = "Заключительный";
            this.заключительныйToolStripMenuItem.Click += new System.EventHandler(this.заключительныйToolStripMenuItem_Click);
            // 
            // osnov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 461);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "osnov";
            this.Text = "osnov";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem подготовительныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основнойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заключительныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem участникиАттестацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вопросыИОтветыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem голосованиеToolStripMenuItem;
    }
}