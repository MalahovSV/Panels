using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithPanels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Просто череда вызова метода createPanel() который возвращает объект панель и помещает его в контейнер
            SetPanels.Controls.Add(createPanel("Панель 1", "Panel1"));
            SetPanels.Controls.Add(createPanel("Панель 2", "Panel2"));
            SetPanels.Controls.Add(createPanel("Панель 3", "Panel3"));
            SetPanels.Controls.Add(createPanel("Панель 4", "Panel4"));
            SetPanels.Controls.Add(createPanel("Панель 5", "Panel5"));
            SetPanels.Controls.Add(createPanel("Панель 6", "Panel6"));
            SetPanels.Controls.Add(createPanel("Панель 7", "Panel7"));

        }

        /// <summary>
        /// Создание панели
        /// </summary>
        /// <param name="text">Текст размещающийся на панели</param>
        /// <param name="namePanel">Имя панели</param>
        /// <returns>Возвращает полностью собранную панель, которая даже имеет имя</returns>
        private Panel createPanel(string text, string namePanel)
        {
            var newPanel = new Panel
            {
                Width = 200,
                Height = 200,
                BackColor = Color.Gray,
                Name = $"{namePanel}"
            };
            newPanel.Controls.Add(createHeaderPanel(newPanel));
            installEventsPanel(newPanel);
            return newPanel;
        }

        private Label createHeaderPanel(Panel panel)
        {
            var label = new Label()
            {
                Text = panel.Name,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Consolas", 12, FontStyle.Bold),
                Dock = DockStyle.Fill,
                ForeColor = Color.White
            };
            installEventsLabel(label, panel);
            return label;
        }

        private void installEventsPanel(Panel panel)
        {
            panel.Click += (s, e) => { MessageBox.Show(panel.Name); };
            panel.MouseEnter += (s, e) => { panel.BackColor = Color.Aqua; };
            panel.MouseLeave += (s, e) => { panel.BackColor = Color.Gray; };
        }

        /// <summary>
        /// Присваиваем события дочернему Label
        /// </summary>
        /// <param name="label">Дочерний Label</param>
        /// <param name="panel">Родительский Panel</param>
        private void installEventsLabel (Label label, Panel panel)
        {
            label.Click += (s, e) => { MessageBox.Show(panel.Name); };
            label.MouseEnter += (s, e) => { panel.BackColor = Color.Aqua; };
            label.MouseLeave += (s, e) => { panel.BackColor = Color.Gray; };
        }
    }
}
