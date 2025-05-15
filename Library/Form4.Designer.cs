namespace Library
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2TileButton1
            // 
            resources.ApplyResources(guna2TileButton1, "guna2TileButton1");
            guna2TileButton1.CustomizableEdges = customizableEdges1;
            guna2TileButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2TileButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2TileButton1.FillColor = Color.DimGray;
            guna2TileButton1.ForeColor = Color.White;
            guna2TileButton1.Name = "guna2TileButton1";
            guna2TileButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TileButton1.Click += guna2TileButton1_Click;
            // 
            // guna2TileButton2
            // 
            resources.ApplyResources(guna2TileButton2, "guna2TileButton2");
            guna2TileButton2.CustomizableEdges = customizableEdges3;
            guna2TileButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2TileButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2TileButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2TileButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2TileButton2.FillColor = Color.DimGray;
            guna2TileButton2.ForeColor = Color.White;
            guna2TileButton2.Name = "guna2TileButton2";
            guna2TileButton2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TileButton2.Click += guna2TileButton2_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.Diagon_Alley;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(guna2TileButton2);
            Controls.Add(guna2TileButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private PictureBox pictureBox1;
    }
}