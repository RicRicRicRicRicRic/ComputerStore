namespace Computer_Store
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            pictureBox1 = new PictureBox();
            Exit_button = new Button();
            panel1 = new Panel();
            Products_DGV = new DataGridView();
            HighestPrice_button = new Button();
            LowestPrice_button = new Button();
            IntelOnly_button = new Button();
            AMDonly_Computers = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Products_DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Exit_button
            // 
            Exit_button.BackColor = Color.Crimson;
            Exit_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit_button.ForeColor = SystemColors.ButtonFace;
            Exit_button.Location = new Point(1509, 0);
            Exit_button.Name = "Exit_button";
            Exit_button.Size = new Size(73, 37);
            Exit_button.TabIndex = 3;
            Exit_button.Text = "Exit";
            Exit_button.UseVisualStyleBackColor = false;
            Exit_button.Click += Exit_button_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(Products_DGV);
            panel1.Location = new Point(291, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 500);
            panel1.TabIndex = 4;
            // 
            // Products_DGV
            // 
            Products_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Products_DGV.Dock = DockStyle.Fill;
            Products_DGV.Location = new Point(0, 0);
            Products_DGV.Name = "Products_DGV";
            Products_DGV.RowHeadersWidth = 51;
            Products_DGV.Size = new Size(1000, 500);
            Products_DGV.TabIndex = 1;
            // 
            // HighestPrice_button
            // 
            HighestPrice_button.BackColor = Color.DarkMagenta;
            HighestPrice_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HighestPrice_button.ForeColor = SystemColors.ButtonFace;
            HighestPrice_button.Location = new Point(291, 133);
            HighestPrice_button.Name = "HighestPrice_button";
            HighestPrice_button.Size = new Size(174, 37);
            HighestPrice_button.TabIndex = 5;
            HighestPrice_button.Text = "HighestPrice";
            HighestPrice_button.UseVisualStyleBackColor = false;
            HighestPrice_button.Click += HighestPrice_button_Click;
            // 
            // LowestPrice_button
            // 
            LowestPrice_button.BackColor = Color.DarkMagenta;
            LowestPrice_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LowestPrice_button.ForeColor = SystemColors.ButtonFace;
            LowestPrice_button.Location = new Point(471, 133);
            LowestPrice_button.Name = "LowestPrice_button";
            LowestPrice_button.Size = new Size(174, 37);
            LowestPrice_button.TabIndex = 6;
            LowestPrice_button.Text = "Lowest Price";
            LowestPrice_button.UseVisualStyleBackColor = false;
            LowestPrice_button.Click += LowestPrice_button_Click;
            // 
            // IntelOnly_button
            // 
            IntelOnly_button.BackColor = Color.DarkMagenta;
            IntelOnly_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IntelOnly_button.ForeColor = SystemColors.ButtonFace;
            IntelOnly_button.Location = new Point(1117, 133);
            IntelOnly_button.Name = "IntelOnly_button";
            IntelOnly_button.Size = new Size(174, 37);
            IntelOnly_button.TabIndex = 7;
            IntelOnly_button.Text = "INTEL computers";
            IntelOnly_button.UseVisualStyleBackColor = false;
            IntelOnly_button.Click += IntelOnly_button_Click;
            // 
            // AMDonly_Computers
            // 
            AMDonly_Computers.BackColor = Color.DarkMagenta;
            AMDonly_Computers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMDonly_Computers.ForeColor = SystemColors.ButtonFace;
            AMDonly_Computers.Location = new Point(937, 133);
            AMDonly_Computers.Name = "AMDonly_Computers";
            AMDonly_Computers.Size = new Size(174, 37);
            AMDonly_Computers.TabIndex = 8;
            AMDonly_Computers.Text = "AMD computers";
            AMDonly_Computers.UseVisualStyleBackColor = false;
            AMDonly_Computers.Click += AMDonly_Computers_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1582, 853);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(AMDonly_Computers);
            Controls.Add(IntelOnly_button);
            Controls.Add(LowestPrice_button);
            Controls.Add(HighestPrice_button);
            Controls.Add(panel1);
            Controls.Add(Exit_button);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Products_DGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Exit_button;
        private Panel panel1;
        private DataGridView Products_DGV;
        private Button HighestPrice_button;
        private Button LowestPrice_button;
        private Button IntelOnly_button;
        private Button AMDonly_Computers;
        private PictureBox pictureBox2;
    }
}