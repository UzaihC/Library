namespace Library
{
    partial class Form3
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            Button4 = new Guna.UI2.WinForms.Guna2RadioButton();
            Button3 = new Guna.UI2.WinForms.Guna2RadioButton();
            Button2 = new Guna.UI2.WinForms.Guna2RadioButton();
            Button1 = new Guna.UI2.WinForms.Guna2RadioButton();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Diagon_Alley;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1346, 105);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(Button4);
            panel1.Controls.Add(Button3);
            panel1.Controls.Add(Button2);
            panel1.Controls.Add(Button1);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(10, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(1326, 429);
            panel1.TabIndex = 1;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(40, 362);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(141, 52);
            guna2Button1.TabIndex = 9;
            guna2Button1.Text = "DONE";
            // 
            // Button4
            // 
            Button4.AutoSize = true;
            Button4.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Button4.CheckedState.BorderThickness = 0;
            Button4.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Button4.CheckedState.InnerColor = Color.White;
            Button4.CheckedState.InnerOffset = -4;
            Button4.Location = new Point(755, 282);
            Button4.Name = "Button4";
            Button4.Size = new Size(131, 19);
            Button4.TabIndex = 8;
            Button4.Text = "Purchase Hufflepuff";
            Button4.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Button4.UncheckedState.BorderThickness = 2;
            Button4.UncheckedState.FillColor = Color.Transparent;
            Button4.UncheckedState.InnerColor = Color.Transparent;
            // 
            // Button3
            // 
            Button3.AutoSize = true;
            Button3.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Button3.CheckedState.BorderThickness = 0;
            Button3.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Button3.CheckedState.InnerColor = Color.White;
            Button3.CheckedState.InnerOffset = -4;
            Button3.Location = new Point(526, 282);
            Button3.Name = "Button3";
            Button3.Size = new Size(122, 19);
            Button3.TabIndex = 7;
            Button3.Text = "Purchase Slytherin";
            Button3.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Button3.UncheckedState.BorderThickness = 2;
            Button3.UncheckedState.FillColor = Color.Transparent;
            Button3.UncheckedState.InnerColor = Color.Transparent;
            Button3.CheckedChanged += guna2RadioButton3_CheckedChanged;
            // 
            // Button2
            // 
            Button2.AutoSize = true;
            Button2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Button2.CheckedState.BorderThickness = 0;
            Button2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Button2.CheckedState.InnerColor = Color.White;
            Button2.CheckedState.InnerOffset = -4;
            Button2.Location = new Point(282, 282);
            Button2.Name = "Button2";
            Button2.Size = new Size(132, 19);
            Button2.TabIndex = 6;
            Button2.Text = "Purchase Ravenclaw";
            Button2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Button2.UncheckedState.BorderThickness = 2;
            Button2.UncheckedState.FillColor = Color.Transparent;
            Button2.UncheckedState.InnerColor = Color.Transparent;
            // 
            // Button1
            // 
            Button1.AutoSize = true;
            Button1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Button1.CheckedState.BorderThickness = 0;
            Button1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Button1.CheckedState.InnerColor = Color.White;
            Button1.CheckedState.InnerOffset = -4;
            Button1.Location = new Point(40, 282);
            Button1.Name = "Button1";
            Button1.Size = new Size(130, 19);
            Button1.TabIndex = 5;
            Button1.Text = "Purchase Gryffindor";
            Button1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Button1.UncheckedState.BorderThickness = 2;
            Button1.UncheckedState.FillColor = Color.Transparent;
            Button1.UncheckedState.InnerColor = Color.Transparent;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.book4;
            pictureBox5.Location = new Point(755, 97);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(153, 179);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._6138686479048754367;
            pictureBox4.Location = new Point(526, 97);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(153, 179);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.book2;
            pictureBox3.Location = new Point(282, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(153, 179);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.book1;
            pictureBox2.Location = new Point(40, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 179);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 561);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2RadioButton Button4;
        private Guna.UI2.WinForms.Guna2RadioButton Button3;
        private Guna.UI2.WinForms.Guna2RadioButton Button2;
        private Guna.UI2.WinForms.Guna2RadioButton Button1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}