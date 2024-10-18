namespace Gestionbibliotecaa
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anadirNuevoLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anadirEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInfoDeEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.issueBooksToolStripMenuItem,
            this.estudianteToolStripMenuItem,
            this.detallesDeLibrosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anadirNuevoLibroToolStripMenuItem,
            this.verLibrosToolStripMenuItem});
            this.librosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("librosToolStripMenuItem.Image")));
            this.librosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(113, 54);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // anadirNuevoLibroToolStripMenuItem
            // 
            this.anadirNuevoLibroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anadirNuevoLibroToolStripMenuItem.Image")));
            this.anadirNuevoLibroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.anadirNuevoLibroToolStripMenuItem.Name = "anadirNuevoLibroToolStripMenuItem";
            this.anadirNuevoLibroToolStripMenuItem.Size = new System.Drawing.Size(245, 56);
            this.anadirNuevoLibroToolStripMenuItem.Text = "Anadir nuevo libro";
            this.anadirNuevoLibroToolStripMenuItem.Click += new System.EventHandler(this.anadirNuevoLibroToolStripMenuItem_Click);
            // 
            // verLibrosToolStripMenuItem
            // 
            this.verLibrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verLibrosToolStripMenuItem.Image")));
            this.verLibrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.verLibrosToolStripMenuItem.Name = "verLibrosToolStripMenuItem";
            this.verLibrosToolStripMenuItem.Size = new System.Drawing.Size(245, 56);
            this.verLibrosToolStripMenuItem.Text = "Ver libros";
            this.verLibrosToolStripMenuItem.Click += new System.EventHandler(this.verLibrosToolStripMenuItem_Click);
            // 
            // issueBooksToolStripMenuItem
            // 
            this.issueBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueBooksToolStripMenuItem.Image")));
            this.issueBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            this.issueBooksToolStripMenuItem.Size = new System.Drawing.Size(197, 54);
            this.issueBooksToolStripMenuItem.Text = "Prestamo de libros";
            this.issueBooksToolStripMenuItem.Click += new System.EventHandler(this.issueBooksToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anadirEstudianteToolStripMenuItem,
            this.verInfoDeEstudianteToolStripMenuItem});
            this.estudianteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("estudianteToolStripMenuItem.Image")));
            this.estudianteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(142, 54);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            // 
            // anadirEstudianteToolStripMenuItem
            // 
            this.anadirEstudianteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anadirEstudianteToolStripMenuItem.Image")));
            this.anadirEstudianteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.anadirEstudianteToolStripMenuItem.Name = "anadirEstudianteToolStripMenuItem";
            this.anadirEstudianteToolStripMenuItem.Size = new System.Drawing.Size(267, 56);
            this.anadirEstudianteToolStripMenuItem.Text = "Anadir estudiante";
            this.anadirEstudianteToolStripMenuItem.Click += new System.EventHandler(this.anadirEstudianteToolStripMenuItem_Click);
            // 
            // verInfoDeEstudianteToolStripMenuItem
            // 
            this.verInfoDeEstudianteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verInfoDeEstudianteToolStripMenuItem.Image")));
            this.verInfoDeEstudianteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.verInfoDeEstudianteToolStripMenuItem.Name = "verInfoDeEstudianteToolStripMenuItem";
            this.verInfoDeEstudianteToolStripMenuItem.Size = new System.Drawing.Size(267, 56);
            this.verInfoDeEstudianteToolStripMenuItem.Text = "Ver info de estudiante";
            this.verInfoDeEstudianteToolStripMenuItem.Click += new System.EventHandler(this.verInfoDeEstudianteToolStripMenuItem_Click);
            // 
            // detallesDeLibrosToolStripMenuItem
            // 
            this.detallesDeLibrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detallesDeLibrosToolStripMenuItem.Image")));
            this.detallesDeLibrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detallesDeLibrosToolStripMenuItem.Name = "detallesDeLibrosToolStripMenuItem";
            this.detallesDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(189, 54);
            this.detallesDeLibrosToolStripMenuItem.Text = "Detalles de libros";
            this.detallesDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.detallesDeLibrosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(102, 54);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 610);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anadirNuevoLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anadirEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInfoDeEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}