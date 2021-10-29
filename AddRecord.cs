using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithPanels
{
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
            priceItemBox.KeyPress += (s, e) =>
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number) && number != 8 && number != 44)
                {
                    e.Handled = true;
                }

            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.Cancel)
                return;
            SelectImage.Text = openImageDialog.FileName;
            FileStream file = File.Open(SelectImage.Text, FileMode.Open);
            imageItem.Image = Image.FromStream(file);
            file.Close();
        }

        async private void AddedRecord_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString()))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Items VALUES (@Name_Item, @Price, @ImageFile)";
                command.Parameters.Add("@Name_Item", SqlDbType.NVarChar);
                command.Parameters.Add("@Price", SqlDbType.Decimal);

                // массив для хранения бинарных данных файла
                byte[] imageData;
                using (FileStream fs = new FileStream(SelectImage.Text, FileMode.Open))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                    command.Parameters.Add("@ImageFile", SqlDbType.Image, Convert.ToInt32(imageData.Length));
                }
                // передаем данные в команду через параметры
                command.Parameters["@Name_Item"].Value = nameItemBox.Text;
                command.Parameters["@Price"].Value = priceItemBox.Text;

                command.Parameters["@ImageFile"].Value = imageData;
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Файл сохранен");
            }
        }
    }
}
