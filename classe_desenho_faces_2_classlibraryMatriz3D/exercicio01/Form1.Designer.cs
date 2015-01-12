namespace exercicio01
{
    partial class Form1
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
            this.BoxDesenho = new System.Windows.Forms.PictureBox();
            this.transX = new System.Windows.Forms.TrackBar();
            this.labelX = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.transZ = new System.Windows.Forms.TrackBar();
            this.labelY = new System.Windows.Forms.Label();
            this.transY = new System.Windows.Forms.TrackBar();
            this.botCorContorno = new System.Windows.Forms.Button();
            this.botCorFundo = new System.Windows.Forms.Button();
            this.corContorno = new System.Windows.Forms.PictureBox();
            this.corFundo = new System.Windows.Forms.PictureBox();
            this.espessuraLinha = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.check_wireframe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDesenho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corContorno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espessuraLinha)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxDesenho
            // 
            this.BoxDesenho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxDesenho.BackColor = System.Drawing.SystemColors.Window;
            this.BoxDesenho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxDesenho.Location = new System.Drawing.Point(8, 27);
            this.BoxDesenho.Name = "BoxDesenho";
            this.BoxDesenho.Size = new System.Drawing.Size(600, 294);
            this.BoxDesenho.TabIndex = 0;
            this.BoxDesenho.TabStop = false;
            this.BoxDesenho.Paint += new System.Windows.Forms.PaintEventHandler(this.BoxDesenho_Paint);
            // 
            // transX
            // 
            this.transX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transX.Location = new System.Drawing.Point(37, 19);
            this.transX.Maximum = 150;
            this.transX.Minimum = -150;
            this.transX.Name = "transX";
            this.transX.Size = new System.Drawing.Size(161, 45);
            this.transX.TabIndex = 1;
            this.transX.TickFrequency = 10;
            this.transX.ValueChanged += new System.EventHandler(this.transX_ValueChanged);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(27, 21);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelZ);
            this.groupBox1.Controls.Add(this.transZ);
            this.groupBox1.Controls.Add(this.labelY);
            this.groupBox1.Controls.Add(this.transY);
            this.groupBox1.Controls.Add(this.transX);
            this.groupBox1.Controls.Add(this.labelX);
            this.groupBox1.Location = new System.Drawing.Point(620, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translação";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(27, 113);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(14, 13);
            this.labelZ.TabIndex = 6;
            this.labelZ.Text = "Z";
            // 
            // transZ
            // 
            this.transZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transZ.Location = new System.Drawing.Point(34, 111);
            this.transZ.Maximum = 50;
            this.transZ.Minimum = -50;
            this.transZ.Name = "transZ";
            this.transZ.Size = new System.Drawing.Size(161, 45);
            this.transZ.TabIndex = 5;
            this.transZ.TickFrequency = 10;
            this.transZ.ValueChanged += new System.EventHandler(this.transZ_ValueChanged);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(27, 71);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y";
            // 
            // transY
            // 
            this.transY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transY.Location = new System.Drawing.Point(38, 66);
            this.transY.Maximum = 150;
            this.transY.Minimum = -150;
            this.transY.Name = "transY";
            this.transY.Size = new System.Drawing.Size(161, 45);
            this.transY.TabIndex = 3;
            this.transY.TickFrequency = 10;
            this.transY.ValueChanged += new System.EventHandler(this.transY_ValueChanged);
            // 
            // botCorContorno
            // 
            this.botCorContorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botCorContorno.Location = new System.Drawing.Point(620, 195);
            this.botCorContorno.Name = "botCorContorno";
            this.botCorContorno.Size = new System.Drawing.Size(158, 36);
            this.botCorContorno.TabIndex = 4;
            this.botCorContorno.Text = "Cor Contorno";
            this.botCorContorno.UseVisualStyleBackColor = true;
            this.botCorContorno.Click += new System.EventHandler(this.botCorContorno_Click);
            // 
            // botCorFundo
            // 
            this.botCorFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botCorFundo.Location = new System.Drawing.Point(620, 242);
            this.botCorFundo.Name = "botCorFundo";
            this.botCorFundo.Size = new System.Drawing.Size(158, 36);
            this.botCorFundo.TabIndex = 5;
            this.botCorFundo.Text = "Cor Fundo";
            this.botCorFundo.UseVisualStyleBackColor = true;
            this.botCorFundo.Click += new System.EventHandler(this.botCorFundo_Click);
            // 
            // corContorno
            // 
            this.corContorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.corContorno.BackColor = System.Drawing.Color.Black;
            this.corContorno.Location = new System.Drawing.Point(784, 195);
            this.corContorno.Name = "corContorno";
            this.corContorno.Size = new System.Drawing.Size(36, 35);
            this.corContorno.TabIndex = 6;
            this.corContorno.TabStop = false;
            // 
            // corFundo
            // 
            this.corFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.corFundo.BackColor = System.Drawing.Color.SteelBlue;
            this.corFundo.Location = new System.Drawing.Point(786, 242);
            this.corFundo.Name = "corFundo";
            this.corFundo.Size = new System.Drawing.Size(36, 35);
            this.corFundo.TabIndex = 7;
            this.corFundo.TabStop = false;
            // 
            // espessuraLinha
            // 
            this.espessuraLinha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.espessuraLinha.DecimalPlaces = 1;
            this.espessuraLinha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.espessuraLinha.Location = new System.Drawing.Point(770, 294);
            this.espessuraLinha.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.espessuraLinha.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.espessuraLinha.Name = "espessuraLinha";
            this.espessuraLinha.Size = new System.Drawing.Size(52, 20);
            this.espessuraLinha.TabIndex = 16;
            this.espessuraLinha.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.espessuraLinha.ValueChanged += new System.EventHandler(this.espessuraLinha_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(712, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Espessura";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.abrirToolStripMenuItem.Text = "Ficheiro";
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem1.Text = "Abrir";
            this.abrirToolStripMenuItem1.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.aboutToolStripMenuItem.Text = "Sobre";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // check_wireframe
            // 
            this.check_wireframe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.check_wireframe.AutoSize = true;
            this.check_wireframe.Location = new System.Drawing.Point(625, 296);
            this.check_wireframe.Name = "check_wireframe";
            this.check_wireframe.Size = new System.Drawing.Size(74, 17);
            this.check_wireframe.TabIndex = 19;
            this.check_wireframe.Text = "Wireframe";
            this.check_wireframe.UseVisualStyleBackColor = true;
            this.check_wireframe.CheckedChanged += new System.EventHandler(this.checkWireframe_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 333);
            this.Controls.Add(this.check_wireframe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.espessuraLinha);
            this.Controls.Add(this.corFundo);
            this.Controls.Add(this.corContorno);
            this.Controls.Add(this.botCorFundo);
            this.Controls.Add(this.botCorContorno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BoxDesenho);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(850, 371);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Desenho de Faces";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BoxDesenho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corContorno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espessuraLinha)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoxDesenho;
        private System.Windows.Forms.TrackBar transX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.TrackBar transZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TrackBar transY;
        private System.Windows.Forms.Button botCorContorno;
        private System.Windows.Forms.Button botCorFundo;
        private System.Windows.Forms.PictureBox corContorno;
        private System.Windows.Forms.PictureBox corFundo;
        private System.Windows.Forms.NumericUpDown espessuraLinha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox check_wireframe;

    }
}

