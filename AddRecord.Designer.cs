namespace WorkWithPanels
{
    partial class AddRecord
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
            this.nameItemBox = new System.Windows.Forms.TextBox();
            this.priceItemBox = new System.Windows.Forms.TextBox();
            this.SelectImage = new System.Windows.Forms.Button();
            this.imageItem = new System.Windows.Forms.PictureBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.AddedRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageItem)).BeginInit();
            this.SuspendLayout();
            // 
            // nameItemBox
            // 
            this.nameItemBox.Location = new System.Drawing.Point(220, 60);
            this.nameItemBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameItemBox.Name = "nameItemBox";
            this.nameItemBox.Size = new System.Drawing.Size(266, 26);
            this.nameItemBox.TabIndex = 1;
            // 
            // priceItemBox
            // 
            this.priceItemBox.Location = new System.Drawing.Point(220, 98);
            this.priceItemBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceItemBox.Name = "priceItemBox";
            this.priceItemBox.Size = new System.Drawing.Size(266, 26);
            this.priceItemBox.TabIndex = 2;
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(205, 355);
            this.SelectImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(281, 48);
            this.SelectImage.TabIndex = 3;
            this.SelectImage.Text = "...";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageItem
            // 
            this.imageItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageItem.Location = new System.Drawing.Point(48, 140);
            this.imageItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageItem.Name = "imageItem";
            this.imageItem.Size = new System.Drawing.Size(438, 205);
            this.imageItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageItem.TabIndex = 20;
            this.imageItem.TabStop = false;
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "Image";
            this.openImageDialog.Filter = "Image files (*.jpg)|*.jpg|Gif files (*.gif)|*.gif|Bitmap files (*.bmp)|*.bmp";
            // 
            // AddedRecord
            // 
            this.AddedRecord.Location = new System.Drawing.Point(178, 455);
            this.AddedRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddedRecord.Name = "AddedRecord";
            this.AddedRecord.Size = new System.Drawing.Size(201, 49);
            this.AddedRecord.TabIndex = 21;
            this.AddedRecord.Text = "Добавить";
            this.AddedRecord.UseVisualStyleBackColor = true;
            this.AddedRecord.Click += new System.EventHandler(this.AddedRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Выбрать картинку";
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddedRecord);
            this.Controls.Add(this.imageItem);
            this.Controls.Add(this.SelectImage);
            this.Controls.Add(this.priceItemBox);
            this.Controls.Add(this.nameItemBox);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddRecord";
            this.Text = "Добавление записи";
            ((System.ComponentModel.ISupportInitialize)(this.imageItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameItemBox;
        private System.Windows.Forms.TextBox priceItemBox;
        private System.Windows.Forms.Button SelectImage;
        private System.Windows.Forms.PictureBox imageItem;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Button AddedRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}