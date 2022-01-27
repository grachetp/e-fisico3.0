namespace E_Fisico
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCalculos = new System.Windows.Forms.PictureBox();
            this.pbMoodle = new System.Windows.Forms.PictureBox();
            this.pbSite = new System.Windows.Forms.PictureBox();
            this.pbConteudos = new System.Windows.Forms.PictureBox();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoodle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConteudos)).BeginInit();
            this.pPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::E_Fisico.Properties.Resources._1;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pbCalculos
            // 
            resources.ApplyResources(this.pbCalculos, "pbCalculos");
            this.pbCalculos.Image = global::E_Fisico.Properties.Resources.calculos;
            this.pbCalculos.Name = "pbCalculos";
            this.pbCalculos.TabStop = false;
            this.pbCalculos.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbMoodle
            // 
            resources.ApplyResources(this.pbMoodle, "pbMoodle");
            this.pbMoodle.Image = global::E_Fisico.Properties.Resources.moodle;
            this.pbMoodle.Name = "pbMoodle";
            this.pbMoodle.TabStop = false;
            // 
            // pbSite
            // 
            resources.ApplyResources(this.pbSite, "pbSite");
            this.pbSite.Image = global::E_Fisico.Properties.Resources.Gráfico__1_;
            this.pbSite.Name = "pbSite";
            this.pbSite.TabStop = false;
            this.pbSite.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pbConteudos
            // 
            resources.ApplyResources(this.pbConteudos, "pbConteudos");
            this.pbConteudos.Image = global::E_Fisico.Properties.Resources.Conteudos1;
            this.pbConteudos.Name = "pbConteudos";
            this.pbConteudos.TabStop = false;
            // 
            // pPrincipal
            // 
            resources.ApplyResources(this.pPrincipal, "pPrincipal");
            this.pPrincipal.Controls.Add(this.panel1);
            this.pPrincipal.Controls.Add(this.pictureBox1);
            this.pPrincipal.Name = "pPrincipal";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pbConteudos);
            this.panel1.Controls.Add(this.pbCalculos);
            this.panel1.Controls.Add(this.pbMoodle);
            this.panel1.Controls.Add(this.pbSite);
            this.panel1.Name = "panel1";
            // 
            // FrmInicial
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pPrincipal);
            this.Name = "FrmInicial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoodle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConteudos)).EndInit();
            this.pPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pbCalculos;
        private PictureBox pbMoodle;
        private PictureBox pbSite;
        private PictureBox pbConteudos;
        private Panel pPrincipal;
        private Panel panel1;
    }
}