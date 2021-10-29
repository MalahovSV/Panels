using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WorkWithPanels
{
    public partial class WindowWithPanels : Form
    {
        public WindowWithPanels()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            byte[] imageBytes;
            Image image;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from Items", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    imageBytes = (byte[]) reader.GetValue(3);
                    Stream stream = new MemoryStream(imageBytes);
                    var bitmap = new Bitmap(stream);
                    image = bitmap;
                    SetPanels.Controls.Add(CreatePanel(reader.GetString(1), (double)reader.GetDecimal(2), image));
                }
            }



            //Просто череда вызова метода createPanel() который возвращает объект панель и помещает его в контейнер
            //SetPanels.Controls.Add(CreatePanel("Бэйби Йода", "Panel1", @"C:\Users\Sergey\Desktop\Images\1.jpg", 1200.32));
            //SetPanels.Controls.Add(CreatePanel("Шварцнигер", "Panel2", @"C:\Users\Sergey\Desktop\Images\2.jpg", 1999.99));
            //SetPanels.Controls.Add(CreatePanel("Пепсикольный", "Panel3", @"C:\Users\Sergey\Desktop\Images\3.jpg", 2100.00));
            //SetPanels.Controls.Add(CreatePanel("Ещё один бейби Йода", "Panel4", @"C:\Users\Sergey\Desktop\Images\4.jpg", 2000.00));
            //SetPanels.Controls.Add(CreatePanel("Стулкер", "Panel5", @"C:\Users\Sergey\Desktop\Images\5.jpg", 564.23));
            //SetPanels.Controls.Add(CreatePanel("АКУВА", "Panel6", @"C:\Users\Sergey\Desktop\Images\6.jpg", 330.20));
            //SetPanels.Controls.Add(CreatePanel("Лорд Вейпер", "Panel7", @"C:\Users\Sergey\Desktop\Images\7.jpg", 4999.99));
            //SetPanels.Controls.Add(CreatePanel("Интеллектуал", "Panel8", @"C:\Users\Sergey\Desktop\Images\8.jpg", 1500.00));
        }

        /// <summary>
        /// Создание панели
        /// </summary>
        /// <param name="NameItem">Текст размещающийся на панели</param>
        /// <param name="namePanel">Имя панели</param>
        /// <returns>Возвращает полностью собранную панель, которая даже имеет имя</returns>
        private Panel CreatePanel(string NameItem, double Cost, Image imageItem)
        {
            var newPanel = new Panel
            {
                Width = 200,
                Height = 200,
                BackColor = Color.Gray,
            };

            newPanel.Controls.Add(CreateHeaderPanel(newPanel, NameItem));

            newPanel.Controls.Add(CreatePictureBoxPanel(newPanel, imageItem));

            newPanel.Controls.Add(CreateFooterPanel(newPanel, Cost));
            InstallEventsPanel(newPanel);
            return newPanel;
        }
        /// <summary>
        /// Создаём Label который будет находится в Panel
        /// </summary>
        /// <param name="panel">Родительский Panel</param>
        /// <returns>Созданный текст который будет располагаться внутри Panel</returns>
        private Label CreateHeaderPanel(Panel panel, string Content)
        {
            var label = new Label()
            {
                Text = Content,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Consolas", 12, FontStyle.Bold),
                Dock = DockStyle.Top,
                ForeColor = Color.White
            };
            InstallEventsLabel(label, panel);
            return label;
        }

        private Label CreateFooterPanel(Panel panel, double Cost)
        {
            var label = new Label()
            {
                Text = Cost+" р.",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Consolas", 12, FontStyle.Bold),
                Dock = DockStyle.Bottom,
                ForeColor = Color.White
            };
            InstallEventsLabel(label, panel);
            return label;
        }


        private PictureBox CreatePictureBoxPanel(Panel panel, Image ImageItem)
        {
            var imageItem = new PictureBox()
            {
                Image = ImageItem,
                Dock = DockStyle.None,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(20, 40),
                Size = new Size(160, 120)
            };
            InstallEventsPictureBox(imageItem, panel);
            return imageItem;
        }

        /// <summary>
        /// Присваиваем события Panel
        /// </summary>
        /// <param name="panel">Объект присвоения</param>
        private void InstallEventsPanel(Panel panel)
        {
            panel.Click += (s, e) => { MessageBox.Show(panel.Name); };
            panel.MouseEnter += (s, e) => { panel.BackColor = Color.DarkOrange; };
            panel.MouseLeave += (s, e) => { panel.BackColor = Color.Gray; };
        }

        /// <summary>
        /// Присваиваем события дочернему Label
        /// </summary>
        /// <param name="label">Дочерний Label</param>
        /// <param name="panel">Родительский Panel</param>
        private void InstallEventsLabel (Label label, Panel panel)
        {
            label.Click += (s, e) => { MessageBox.Show(panel.Name); };
            label.MouseEnter += (s, e) => { panel.BackColor = Color.DarkOrange; };
            label.MouseLeave += (s, e) => { panel.BackColor = Color.Gray; };
        }
        private void InstallEventsPictureBox(PictureBox pictureBox, Panel panel)
        {
            pictureBox.Click += (s, e) => { MessageBox.Show(panel.Name); };
            pictureBox.MouseEnter += (s, e) => { panel.BackColor = Color.DarkOrange; };
            pictureBox.MouseLeave += (s, e) => { panel.BackColor = Color.Gray; };
        }

        private void OpenWindowAddedRecord_Click(object sender, System.EventArgs e)
        {
            AddRecord addRecord = new AddRecord();
            addRecord.ShowDialog();
        }
    }
}
