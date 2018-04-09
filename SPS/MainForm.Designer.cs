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
            this.folderPathTB = new System.Windows.Forms.TextBox();
            this.BrowseBT = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.fileNameL = new System.Windows.Forms.Label();
            this.fileIndexL = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // folderPathTB
            // 
            this.folderPathTB.BackColor = System.Drawing.SystemColors.Window;
            this.folderPathTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.folderPathTB.Location = new System.Drawing.Point(10, 10);
            this.folderPathTB.Name = "folderPathTB";
            this.folderPathTB.ReadOnly = true;
            this.folderPathTB.Size = new System.Drawing.Size(504, 26);
            this.folderPathTB.TabIndex = 1;
            this.folderPathTB.Text = "Path to the folder with pictures...";
            // 
            // BrowseBT
            // 
            this.BrowseBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrowseBT.Location = new System.Drawing.Point(520, 10);
            this.BrowseBT.Name = "BrowseBT";
            this.BrowseBT.Size = new System.Drawing.Size(92, 26);
            this.BrowseBT.TabIndex = 0;
            this.BrowseBT.Text = "Browse";
            this.BrowseBT.UseVisualStyleBackColor = true;
            this.BrowseBT.Click += new System.EventHandler(this.BrowseBT_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.Window;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Location = new System.Drawing.Point(272, 42);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(340, 340);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // fileNameL
            // 
            this.fileNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameL.Location = new System.Drawing.Point(10, 389);
            this.fileNameL.Name = "fileNameL";
            this.fileNameL.Size = new System.Drawing.Size(602, 23);
            this.fileNameL.TabIndex = 3;
            this.fileNameL.Text = "Filename: ";
            this.fileNameL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fileIndexL
            // 
            this.fileIndexL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileIndexL.Location = new System.Drawing.Point(10, 415);
            this.fileIndexL.Name = "fileIndexL";
            this.fileIndexL.Size = new System.Drawing.Size(602, 23);
            this.fileIndexL.TabIndex = 4;
            this.fileIndexL.Text = "File # out of #";
            this.fileIndexL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(10, 42);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(256, 340);
            this.listBox.TabIndex = 6;
            this.listBox.Click += new System.EventHandler(this.listBox_Click);
            this.listBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 41);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.fileIndexL);
            this.Controls.Add(this.fileNameL);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.BrowseBT);
            this.Controls.Add(this.folderPathTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Semiautomatic Picture Sorter";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderPathTB;
        private System.Windows.Forms.Button BrowseBT;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label fileNameL;
        private System.Windows.Forms.Label fileIndexL;
        private System.Windows.Forms.ListBox listBox;
    }
}

