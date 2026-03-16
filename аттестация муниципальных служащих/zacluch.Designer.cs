
namespace аттестация_муниципальных_служащих
{
    partial class zacluch
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
            this.заключительныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протоколЗаседанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кадровыеРешенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приказыИРаспоряженияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
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
            this.основнойToolStripMenuItem.Name = "основнойToolStripMenuItem";
            this.основнойToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.основнойToolStripMenuItem.Text = "Основной";
            this.основнойToolStripMenuItem.Click += new System.EventHandler(this.основнойToolStripMenuItem_Click);
            // 
            // заключительныйToolStripMenuItem
            // 
            this.заключительныйToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.протоколЗаседанияToolStripMenuItem,
            this.кадровыеРешенияToolStripMenuItem,
            this.приказыИРаспоряженияToolStripMenuItem});
            this.заключительныйToolStripMenuItem.Name = "заключительныйToolStripMenuItem";
            this.заключительныйToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.заключительныйToolStripMenuItem.Text = "Заключительный";
            // 
            // протоколЗаседанияToolStripMenuItem
            // 
            this.протоколЗаседанияToolStripMenuItem.Name = "протоколЗаседанияToolStripMenuItem";
            this.протоколЗаседанияToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.протоколЗаседанияToolStripMenuItem.Text = "Протокол заседания";
            this.протоколЗаседанияToolStripMenuItem.Click += new System.EventHandler(this.протоколЗаседанияToolStripMenuItem_Click);
            // 
            // кадровыеРешенияToolStripMenuItem
            // 
            this.кадровыеРешенияToolStripMenuItem.Name = "кадровыеРешенияToolStripMenuItem";
            this.кадровыеРешенияToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.кадровыеРешенияToolStripMenuItem.Text = "Кадровые решения";
            this.кадровыеРешенияToolStripMenuItem.Click += new System.EventHandler(this.кадровыеРешенияToolStripMenuItem_Click);
            // 
            // приказыИРаспоряженияToolStripMenuItem
            // 
            this.приказыИРаспоряженияToolStripMenuItem.Name = "приказыИРаспоряженияToolStripMenuItem";
            this.приказыИРаспоряженияToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.приказыИРаспоряженияToolStripMenuItem.Text = "Приказы и распоряжения";
            this.приказыИРаспоряженияToolStripMenuItem.Click += new System.EventHandler(this.приказыИРаспоряженияToolStripMenuItem_Click);
            // 
            // zacluch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "zacluch";
            this.Text = "zacluch";
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
        private System.Windows.Forms.ToolStripMenuItem протоколЗаседанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кадровыеРешенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приказыИРаспоряженияToolStripMenuItem;
    }
}