namespace Computer_Store
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            Exit_button = new Button();
            User_button = new Button();
            Admin_button = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Exit_button
            // 
            Exit_button.BackColor = Color.Crimson;
            Exit_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit_button.ForeColor = SystemColors.ButtonFace;
            Exit_button.Location = new Point(1509, 0);
            Exit_button.Name = "Exit_button";
            Exit_button.Size = new Size(73, 37);
            Exit_button.TabIndex = 1;
            Exit_button.Text = "Exit";
            Exit_button.UseVisualStyleBackColor = false;
            Exit_button.Click += Exit_button_Click;
            // 
            // User_button
            // 
            User_button.BackColor = Color.MediumSeaGreen;
            User_button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User_button.ForeColor = SystemColors.ButtonFace;
            User_button.Location = new Point(452, 670);
            User_button.Name = "User_button";
            User_button.Size = new Size(312, 74);
            User_button.TabIndex = 2;
            User_button.Text = "USER";
            User_button.UseVisualStyleBackColor = false;
            User_button.Click += User_button_Click;
            // 
            // Admin_button
            // 
            Admin_button.BackColor = Color.DarkViolet;
            Admin_button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admin_button.ForeColor = SystemColors.ButtonFace;
            Admin_button.Location = new Point(817, 670);
            Admin_button.Name = "Admin_button";
            Admin_button.Size = new Size(312, 74);
            Admin_button.TabIndex = 3;
            Admin_button.Text = "ADMIN";
            Admin_button.UseVisualStyleBackColor = false;
            Admin_button.Click += Admin_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1582, 853);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Reference Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(553, 578);
            label1.Name = "label1";
            label1.Size = new Size(468, 49);
            label1.TabIndex = 6;
            label1.Text = "CHOOSE LOGIN TYPE";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(label1);
            Controls.Add(Admin_button);
            Controls.Add(User_button);
            Controls.Add(Exit_button);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Exit_button;
        private Button User_button;
        private Button Admin_button;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
