namespace WorkWithPanels
{
    partial class WindowWithPanels
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
            this.SetPanels = new System.Windows.Forms.FlowLayoutPanel();
            this.OpenWindowAddedRecord = new System.Windows.Forms.Button();
            this.SetPanels.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetPanels
            // 
            this.SetPanels.AutoScroll = true;
            this.SetPanels.Controls.Add(this.OpenWindowAddedRecord);
            this.SetPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetPanels.Location = new System.Drawing.Point(0, 0);
            this.SetPanels.Name = "SetPanels";
            this.SetPanels.Size = new System.Drawing.Size(800, 450);
            this.SetPanels.TabIndex = 0;
            // 
            // OpenWindowAddedRecord
            // 
            this.OpenWindowAddedRecord.BackColor = System.Drawing.Color.Gray;
            this.OpenWindowAddedRecord.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenWindowAddedRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenWindowAddedRecord.Location = new System.Drawing.Point(3, 3);
            this.OpenWindowAddedRecord.Name = "OpenWindowAddedRecord";
            this.OpenWindowAddedRecord.Size = new System.Drawing.Size(200, 200);
            this.OpenWindowAddedRecord.TabIndex = 0;
            this.OpenWindowAddedRecord.Text = "Добавить новую запись";
            this.OpenWindowAddedRecord.UseVisualStyleBackColor = false;
            this.OpenWindowAddedRecord.Click += new System.EventHandler(this.OpenWindowAddedRecord_Click);
            // 
            // WindowWithPanels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetPanels);
            this.Name = "WindowWithPanels";
            this.Text = "Работаю с панельками";
            this.SetPanels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SetPanels;
        private System.Windows.Forms.Button OpenWindowAddedRecord;
    }
}

