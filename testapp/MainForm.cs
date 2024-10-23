
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestDesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateUI();
        }

        private void CreateUI()
        {
            this.Text = "Test Desktop App";
            this.Size = new Size(400, 300);

            // Welcome label
            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Welcome to the Test App!";
            welcomeLabel.Font = new Font("Arial", 14);
            welcomeLabel.Location = new Point(100, 50);
            welcomeLabel.AutoSize = true;
            this.Controls.Add(welcomeLabel);

            // Change background color button
            Button colorButton = new Button();
            colorButton.Text = "Change Background Color";
            colorButton.Location = new Point(100, 100);
            colorButton.Click += ChangeBackgroundColor;
            this.Controls.Add(colorButton);

            // Greet button
            Button greetButton = new Button();
            greetButton.Text = "Greet Me";
            greetButton.Location = new Point(100, 150);
            greetButton.Click += GreetUser;
            this.Controls.Add(greetButton);

            // Menu strip
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");
            exitMenuItem.Click += (sender, args) => this.Close();
            fileMenu.DropDownItems.Add(exitMenuItem);

            ToolStripMenuItem helpMenu = new ToolStripMenuItem("Help");
            ToolStripMenuItem aboutMenuItem = new ToolStripMenuItem("About");
            aboutMenuItem.Click += (sender, args) => MessageBox.Show("This is a simple test desktop app created with C# and Windows Forms.", "About");
            helpMenu.DropDownItems.Add(aboutMenuItem);

            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(helpMenu);
            this.Controls.Add(menuStrip);
            this.MainMenuStrip = menuStrip;
        }

        private void ChangeBackgroundColor(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void GreetUser(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! Welcome to the Test App.", "Greetings");
        }
    }
}
