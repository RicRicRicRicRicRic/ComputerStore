namespace Computer_Store
{
    partial class Confirm_button
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm_button));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Exit_button = new Button();
            panel1 = new Panel();
            Products_DGV = new DataGridView();
            label2 = new Label();
            Name_textBox = new TextBox();
            NewPrice_textbox = new TextBox();
            label1 = new Label();
            confirmation_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Products_DGV).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1582, 853);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Exit_button
            // 
            Exit_button.BackColor = Color.Crimson;
            Exit_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit_button.ForeColor = SystemColors.ButtonFace;
            Exit_button.Location = new Point(1509, 0);
            Exit_button.Name = "Exit_button";
            Exit_button.Size = new Size(73, 37);
            Exit_button.TabIndex = 2;
            Exit_button.Text = "Exit";
            Exit_button.UseVisualStyleBackColor = false;
            Exit_button.Click += Exit_button_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(Products_DGV);
            panel1.Location = new Point(291, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 500);
            panel1.TabIndex = 3;
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
            Products_DGV.CellContentClick += Products_DGV_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(291, 613);
            label2.Name = "label2";
            label2.Size = new Size(187, 28);
            label2.TabIndex = 8;
            label2.Text = "Product Name";
            // 
            // Name_textBox
            // 
            Name_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name_textBox.Location = new Point(484, 610);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.ReadOnly = true;
            Name_textBox.Size = new Size(184, 34);
            Name_textBox.TabIndex = 9;
            // 
            // NewPrice_textbox
            // 
            NewPrice_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewPrice_textbox.Location = new Point(857, 610);
            NewPrice_textbox.Name = "NewPrice_textbox";
            NewPrice_textbox.Size = new Size(184, 34);
            NewPrice_textbox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(674, 613);
            label1.Name = "label1";
            label1.Size = new Size(177, 28);
            label1.TabIndex = 11;
            label1.Text = "Product Price";
            // 
            // confirmation_button
            // 
            confirmation_button.BackColor = Color.DarkMagenta;
            confirmation_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmation_button.ForeColor = SystemColors.ButtonFace;
            confirmation_button.Location = new Point(1117, 607);
            confirmation_button.Name = "confirmation_button";
            confirmation_button.Size = new Size(174, 37);
            confirmation_button.TabIndex = 14;
            confirmation_button.Text = "Confirm";
            confirmation_button.UseVisualStyleBackColor = false;
            confirmation_button.Click += confirmation_button_Click;
            // 
            // Confirm_button
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(confirmation_button);
            Controls.Add(label1);
            Controls.Add(NewPrice_textbox);
            Controls.Add(Name_textBox);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(Exit_button);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Confirm_button";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += Confirm_button_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Products_DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button Exit_button;
        private Panel panel1;
        private DataGridView Products_DGV;
        private Label label2;
        private TextBox Name_textBox;
        private TextBox NewPrice_textbox;
        private Label label1;
        private Button confirmation_button;
    }
}