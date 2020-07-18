namespace SPS
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderPathTbox = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.fileIndexLbl = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.skipBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // folderPathTbox
            // 
            this.folderPathTbox.BackColor = System.Drawing.SystemColors.Window;
            this.folderPathTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.folderPathTbox.Location = new System.Drawing.Point(10, 10);
            this.folderPathTbox.Name = "folderPathTbox";
            this.folderPathTbox.ReadOnly = true;
            this.folderPathTbox.Size = new System.Drawing.Size(446, 26);
            this.folderPathTbox.TabIndex = 1;
            this.folderPathTbox.Text = "Path to the folder with files...";
            // 
            // browseBtn
            // 
            this.browseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseBtn.Location = new System.Drawing.Point(462, 10);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(92, 26);
            this.browseBtn.TabIndex = 0;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(216, 42);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(338, 338);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameLbl.Location = new System.Drawing.Point(10, 417);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(544, 23);
            this.fileNameLbl.TabIndex = 3;
            this.fileNameLbl.Text = "Filename: ";
            this.fileNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fileIndexLbl
            // 
            this.fileIndexLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileIndexLbl.Location = new System.Drawing.Point(10, 441);
            this.fileIndexLbl.Name = "fileIndexLbl";
            this.fileIndexLbl.Size = new System.Drawing.Size(544, 23);
            this.fileIndexLbl.TabIndex = 4;
            this.fileIndexLbl.Text = "File # out of #";
            this.fileIndexLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(10, 42);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(200, 372);
            this.listBox.TabIndex = 6;
            this.listBox.Click += new System.EventHandler(this.listBox_Click);
            this.listBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox_KeyPress);
            // 
            // openBtn
            // 
            this.openBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openBtn.Location = new System.Drawing.Point(216, 386);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(111, 28);
            this.openBtn.TabIndex = 7;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(330, 386);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(110, 28);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // skipBtn
            // 
            this.skipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skipBtn.Location = new System.Drawing.Point(443, 386);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(111, 28);
            this.skipBtn.TabIndex = 9;
            this.skipBtn.Text = "Skip";
            this.skipBtn.UseVisualStyleBackColor = true;
            this.skipBtn.Click += new System.EventHandler(this.loadNextPicture);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(564, 471);
            this.Controls.Add(this.skipBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.fileIndexLbl);
            this.Controls.Add(this.fileNameLbl);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.folderPathTbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semiautomatic Picture Sorter";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderPathTbox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.Label fileIndexLbl;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button skipBtn;
    }
}

