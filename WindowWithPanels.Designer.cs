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
            this.SuspendLayout();
            // 
            // SetPanels
            // 
            this.SetPanels.AutoScroll = true;
            this.SetPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetPanels.Location = new System.Drawing.Point(0, 0);
            this.SetPanels.Name = "SetPanels";
            this.SetPanels.Size = new System.Drawing.Size(800, 450);
            this.SetPanels.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetPanels);
            this.Name = "Form1";
            this.Text = "Работаю с панельками";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SetPanels;
    }
}

