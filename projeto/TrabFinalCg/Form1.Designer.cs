namespace TrabFinalCg
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
            this.rodaX = new System.Windows.Forms.TrackBar();
            this.rodaY = new System.Windows.Forms.TrackBar();
            this.rodaZ = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.camara = new System.Windows.Forms.TrackBar();
            this.escala = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.faces = new System.Windows.Forms.CheckBox();
            this.nomeTxt = new System.Windows.Forms.Label();
            this.nFacesVTxt = new System.Windows.Forms.Label();
            this.nVerticesTxt = new System.Windows.Forms.Label();
            this.nFacesTTxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nFacesVTxtP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDesenho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corContorno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espessuraLinha)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rodaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodaZ)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escala)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxDesenho
            // 
            this.BoxDesenho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxDesenho.BackColor = System.Drawing.SystemColors.Window;
            this.BoxDesenho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxDesenho.Location = new System.Drawing.Point(61, 280);
            this.BoxDesenho.Name = "BoxDesenho";
            this.BoxDesenho.Size = new System.Drawing.Size(368, 359);
            this.BoxDesenho.TabIndex = 0;
            this.BoxDesenho.TabStop = false;
            this.BoxDesenho.Paint += new System.Windows.Forms.PaintEventHandler(this.BoxDesenho_Paint);
            // 
            // transX
            // 
            this.transX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transX.Location = new System.Drawing.Point(45, 19);
            this.transX.Maximum = 150;
            this.transX.Minimum = -150;
            this.transX.Name = "transX";
            this.transX.Size = new System.Drawing.Size(120, 45);
            this.transX.TabIndex = 1;
            this.transX.TickFrequency = 30;
            this.transX.ValueChanged += new System.EventHandler(this.transX_ValueChanged);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(27, 21);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 14);
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
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translação";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(26, 98);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(14, 14);
            this.labelZ.TabIndex = 6;
            this.labelZ.Text = "Z";
            // 
            // transZ
            // 
            this.transZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transZ.Location = new System.Drawing.Point(45, 97);
            this.transZ.Maximum = 150;
            this.transZ.Minimum = -150;
            this.transZ.Name = "transZ";
            this.transZ.Size = new System.Drawing.Size(120, 45);
            this.transZ.TabIndex = 5;
            this.transZ.TickFrequency = 30;
            this.transZ.ValueChanged += new System.EventHandler(this.transZ_ValueChanged);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(26, 62);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 14);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y";
            // 
            // transY
            // 
            this.transY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transY.Location = new System.Drawing.Point(45, 59);
            this.transY.Maximum = 150;
            this.transY.Minimum = -150;
            this.transY.Name = "transY";
            this.transY.Size = new System.Drawing.Size(120, 45);
            this.transY.TabIndex = 3;
            this.transY.TickFrequency = 30;
            this.transY.ValueChanged += new System.EventHandler(this.transY_ValueChanged);
            // 
            // botCorContorno
            // 
            this.botCorContorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botCorContorno.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botCorContorno.Location = new System.Drawing.Point(621, 48);
            this.botCorContorno.Name = "botCorContorno";
            this.botCorContorno.Size = new System.Drawing.Size(149, 22);
            this.botCorContorno.TabIndex = 4;
            this.botCorContorno.Text = "Cor Arestas";
            this.botCorContorno.UseVisualStyleBackColor = true;
            this.botCorContorno.Click += new System.EventHandler(this.botCorContorno_Click);
            // 
            // botCorFundo
            // 
            this.botCorFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botCorFundo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botCorFundo.Location = new System.Drawing.Point(621, 74);
            this.botCorFundo.Name = "botCorFundo";
            this.botCorFundo.Size = new System.Drawing.Size(149, 22);
            this.botCorFundo.TabIndex = 5;
            this.botCorFundo.Text = "Cor Faces";
            this.botCorFundo.UseVisualStyleBackColor = true;
            this.botCorFundo.Click += new System.EventHandler(this.botCorFundo_Click);
            // 
            // corContorno
            // 
            this.corContorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.corContorno.BackColor = System.Drawing.Color.Black;
            this.corContorno.Location = new System.Drawing.Point(776, 48);
            this.corContorno.Name = "corContorno";
            this.corContorno.Size = new System.Drawing.Size(22, 22);
            this.corContorno.TabIndex = 6;
            this.corContorno.TabStop = false;
            // 
            // corFundo
            // 
            this.corFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.corFundo.BackColor = System.Drawing.Color.SteelBlue;
            this.corFundo.Location = new System.Drawing.Point(776, 74);
            this.corFundo.Name = "corFundo";
            this.corFundo.Size = new System.Drawing.Size(22, 22);
            this.corFundo.TabIndex = 7;
            this.corFundo.TabStop = false;
            // 
            // espessuraLinha
            // 
            this.espessuraLinha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.espessuraLinha.DecimalPlaces = 1;
            this.espessuraLinha.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espessuraLinha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.espessuraLinha.Location = new System.Drawing.Point(748, 144);
            this.espessuraLinha.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.espessuraLinha.Name = "espessuraLinha";
            this.espessuraLinha.Size = new System.Drawing.Size(40, 20);
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
            this.label4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(621, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Espessura Linha";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.abrirToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.abrirToolStripMenuItem.Text = "Ficheiro";
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.abrirToolStripMenuItem1.Text = "Abrir";
            this.abrirToolStripMenuItem1.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.aboutToolStripMenuItem.Text = "Sobre";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // check_wireframe
            // 
            this.check_wireframe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.check_wireframe.AutoSize = true;
            this.check_wireframe.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_wireframe.Location = new System.Drawing.Point(621, 125);
            this.check_wireframe.Name = "check_wireframe";
            this.check_wireframe.Size = new System.Drawing.Size(89, 18);
            this.check_wireframe.TabIndex = 19;
            this.check_wireframe.Text = "Wireframe";
            this.check_wireframe.UseVisualStyleBackColor = true;
            this.check_wireframe.CheckedChanged += new System.EventHandler(this.checkWireframe_CheckedChanged);
            // 
            // rodaX
            // 
            this.rodaX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rodaX.Location = new System.Drawing.Point(46, 19);
            this.rodaX.Maximum = 180;
            this.rodaX.Minimum = -180;
            this.rodaX.Name = "rodaX";
            this.rodaX.Size = new System.Drawing.Size(120, 45);
            this.rodaX.TabIndex = 21;
            this.rodaX.TickFrequency = 36;
            this.rodaX.Scroll += new System.EventHandler(this.rodaX_ValueChanged);
            // 
            // rodaY
            // 
            this.rodaY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rodaY.Location = new System.Drawing.Point(46, 62);
            this.rodaY.Maximum = 180;
            this.rodaY.Minimum = -180;
            this.rodaY.Name = "rodaY";
            this.rodaY.Size = new System.Drawing.Size(120, 45);
            this.rodaY.TabIndex = 22;
            this.rodaY.TickFrequency = 36;
            this.rodaY.Scroll += new System.EventHandler(this.rodaY_ValueChanged);
            // 
            // rodaZ
            // 
            this.rodaZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rodaZ.Location = new System.Drawing.Point(46, 97);
            this.rodaZ.Maximum = 180;
            this.rodaZ.Minimum = -180;
            this.rodaZ.Name = "rodaZ";
            this.rodaZ.Size = new System.Drawing.Size(120, 45);
            this.rodaZ.TabIndex = 23;
            this.rodaZ.TickFrequency = 36;
            this.rodaZ.Scroll += new System.EventHandler(this.rodaZ_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rodaZ);
            this.groupBox2.Controls.Add(this.rodaY);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rodaX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(249, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 150);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rotação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(618, 170);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(180, 23);
            this.reset.TabIndex = 25;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // camara
            // 
            this.camara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.camara.LargeChange = 50;
            this.camara.Location = new System.Drawing.Point(49, 20);
            this.camara.Maximum = 900;
            this.camara.Name = "camara";
            this.camara.Size = new System.Drawing.Size(120, 45);
            this.camara.TabIndex = 24;
            this.camara.TickFrequency = 90;
            this.camara.Scroll += new System.EventHandler(this.camara_ValueChanged);
            // 
            // escala
            // 
            this.escala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.escala.LargeChange = 1;
            this.escala.Location = new System.Drawing.Point(49, 19);
            this.escala.Maximum = 30;
            this.escala.Minimum = 1;
            this.escala.Name = "escala";
            this.escala.Size = new System.Drawing.Size(120, 45);
            this.escala.TabIndex = 24;
            this.escala.TickFrequency = 3;
            this.escala.Value = 1;
            this.escala.Scroll += new System.EventHandler(this.escala_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.escala);
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(435, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 71);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escala";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.camara);
            this.groupBox4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(435, 122);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 71);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Camara";
            // 
            // faces
            // 
            this.faces.AutoSize = true;
            this.faces.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faces.Location = new System.Drawing.Point(621, 101);
            this.faces.Name = "faces";
            this.faces.Size = new System.Drawing.Size(180, 18);
            this.faces.TabIndex = 29;
            this.faces.Text = "Desenhar Faces Ocultas";
            this.faces.UseVisualStyleBackColor = true;
            this.faces.CheckedChanged += new System.EventHandler(this.faces_CheckedChanged);
            // 
            // nomeTxt
            // 
            this.nomeTxt.AutoSize = true;
            this.nomeTxt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(364, 207);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(160, 16);
            this.nomeTxt.TabIndex = 30;
            this.nomeTxt.Text = "Nome Ficheiro: Cubo";
            // 
            // nFacesVTxt
            // 
            this.nFacesVTxt.AutoSize = true;
            this.nFacesVTxt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFacesVTxt.Location = new System.Drawing.Point(73, 642);
            this.nFacesVTxt.Name = "nFacesVTxt";
            this.nFacesVTxt.Size = new System.Drawing.Size(168, 16);
            this.nFacesVTxt.TabIndex = 31;
            this.nFacesVTxt.Text = "Nº Faces Visiveis: 1";
            // 
            // nVerticesTxt
            // 
            this.nVerticesTxt.AutoSize = true;
            this.nVerticesTxt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nVerticesTxt.Location = new System.Drawing.Point(364, 239);
            this.nVerticesTxt.Name = "nVerticesTxt";
            this.nVerticesTxt.Size = new System.Drawing.Size(120, 16);
            this.nVerticesTxt.TabIndex = 32;
            this.nVerticesTxt.Text = "Nº Vertices: 4";
            // 
            // nFacesTTxt
            // 
            this.nFacesTTxt.AutoSize = true;
            this.nFacesTTxt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFacesTTxt.Location = new System.Drawing.Point(364, 223);
            this.nFacesTTxt.Name = "nFacesTTxt";
            this.nFacesTTxt.Size = new System.Drawing.Size(144, 16);
            this.nFacesTTxt.TabIndex = 33;
            this.nFacesTTxt.Text = "Nº Faces Total: 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(435, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 359);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Projecção Perspectiva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Projecção Paralela";
            // 
            // nFacesVTxtP
            // 
            this.nFacesVTxtP.AutoSize = true;
            this.nFacesVTxtP.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFacesVTxtP.Location = new System.Drawing.Point(447, 642);
            this.nFacesVTxtP.Name = "nFacesVTxtP";
            this.nFacesVTxtP.Size = new System.Drawing.Size(168, 16);
            this.nFacesVTxtP.TabIndex = 37;
            this.nFacesVTxtP.Text = "Nº Faces Visiveis: 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 680);
            this.Controls.Add(this.nFacesVTxtP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nFacesTTxt);
            this.Controls.Add(this.nVerticesTxt);
            this.Controls.Add(this.nFacesVTxt);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.faces);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.groupBox2);
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
            this.Text = "Trabalho Pratico CG - Manuel Ricardo Sá";
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
            ((System.ComponentModel.ISupportInitialize)(this.rodaX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodaZ)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escala)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TrackBar rodaX;
        private System.Windows.Forms.TrackBar rodaY;
        private System.Windows.Forms.TrackBar rodaZ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TrackBar camara;
        private System.Windows.Forms.TrackBar escala;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox faces;
        private System.Windows.Forms.Label nomeTxt;
        private System.Windows.Forms.Label nFacesVTxt;
        private System.Windows.Forms.Label nVerticesTxt;
        private System.Windows.Forms.Label nFacesTTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nFacesVTxtP;


        public System.Windows.Forms.PaintEventHandler BoxDesenhoParalela_Paint { get; set; }
    }
}

