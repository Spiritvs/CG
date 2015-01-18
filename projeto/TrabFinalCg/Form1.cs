
// versão completa desenho faces 2 (com class library metodosMatriz3D.Matriz3D)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections; // para usar as streams

namespace TrabFinalCg
{
    public partial class Form1 : Form
    {
        Objecto obj;
        Pen pen1;
        SolidBrush brush1;
        string nomeFicheiro;
        int desenharOcultas = 0;
        ArrayList dados;

 
        public Form1()
        {
            InitializeComponent();
            camara.Value = 450;
           
            // criar e inicializar objecto
            int largura_box= this.BoxDesenho.Width;
            int altura_box = this.BoxDesenho.Height;
            obj = new Objecto(largura_box,altura_box);

            //criar e configurar a pen e o brush
            pen1 = new Pen(this.corContorno.BackColor, (float) this.espessuraLinha.Value);
            brush1 = new SolidBrush(this.corFundo.BackColor);

            // atrbuir a pen e o brush ao objecto
            obj.setCores(pen1, brush1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BoxDesenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (obj != null)
                dados = obj.desenha(g, (float)(transX.Value), (float)(transY.Value), (float)(transZ.Value),
                    (float)(rodaX.Value), (float)(rodaY.Value), (float)(rodaZ.Value),
                    (float)(camara.Value), (float)(escala.Value), 0, desenharOcultas);
            dadosTxt((int)dados[0], (int)dados[1], (int)dados[2], (int)dados[3]);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (obj != null)
                dados = obj.desenha(g, (float)(transX.Value), (float)(transY.Value), (float)(transZ.Value),
                    (float)(rodaX.Value), (float)(rodaY.Value), (float)(rodaZ.Value),
                    (float)(camara.Value), (float)(escala.Value), 1, desenharOcultas);
            dadosTxt((int)dados[0], (int)dados[1], (int)dados[2], (int)dados[3]);
        }

        public void dadosTxt(int nFacesV, int nVertices, int nFacesT, int cam)
        {
            nomeTxt.Text = "Nome do Ficheiro: " + nomeFicheiro;
            nVerticesTxt.Text = "Nº Vertices: " + nVertices;
            nFacesTTxt.Text = "Nº Faces Total: " + nFacesT;
            if(cam == 0)
            nFacesVTxt.Text = "Nº Faces Visiveis: " + nFacesV;
            if(cam == 1)
            nFacesVTxtP.Text = "Nº Faces Visiveis: " + nFacesV;
        }


        private void transX_ValueChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
            this.pictureBox1.Invalidate();
        }

        private void transY_ValueChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
            this.pictureBox1.Invalidate();
        }

        private void transZ_ValueChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
            this.pictureBox1.Invalidate();
        }

        private void rodaX_ValueChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
            this.pictureBox1.Invalidate();
        }

        private void rodaY_ValueChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
            this.pictureBox1.Invalidate();
        }

        private void rodaZ_ValueChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
            this.pictureBox1.Invalidate();
        }

        private void camara_ValueChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
            this.pictureBox1.Invalidate();
        }

        private void escala_ValueChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
            this.pictureBox1.Invalidate();
        }

        
        private void faces_CheckedChanged(object sender, EventArgs e)
        {
            if (faces.Checked)
            {
                desenharOcultas = 1;
            }
            else {
                desenharOcultas = 0;
            }
            this.BoxDesenho.Invalidate();
            this.pictureBox1.Invalidate();
        }

       private void botCorContorno_Click(object sender, EventArgs e)
        {
            ColorDialog dialogo = new ColorDialog();
            dialogo.Color = this.corContorno.BackColor;
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                this.corContorno.BackColor = dialogo.Color;
                if (obj != null)
                {
                    setCores();
                    this.BoxDesenho.Invalidate();
                    this.pictureBox1.Invalidate();
                }
            }

        }

        private void botCorFundo_Click(object sender, EventArgs e)
        {
            ColorDialog dialogo = new ColorDialog();
            dialogo.Color = this.corFundo.BackColor;
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                this.corFundo.BackColor = dialogo.Color;
                if (obj != null)
                {
                    setCores();
                    this.BoxDesenho.Invalidate();
                    this.pictureBox1.Invalidate();
                }
            }


        }

        private void reset_Click(object sender, EventArgs e)
        {
            transX.Value = 0;
            transY.Value = 0;
            transZ.Value = 0;
            rodaX.Value = 0;
            rodaY.Value = 0;
            rodaZ.Value = 0;
            this.BoxDesenho.Invalidate();
            this.pictureBox1.Invalidate();
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.setCentroProjeccao(this.BoxDesenho.Width, this.BoxDesenho.Height);
                this.BoxDesenho.Invalidate();
                this.pictureBox1.Invalidate();
            }
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
            this.pictureBox1.Invalidate();
        }

        private void espessuraLinha_ValueChanged(object sender, EventArgs e)
        {
            if (obj != null)
            {
                setCores();
                this.BoxDesenho.Invalidate();
                this.pictureBox1.Invalidate();
            }


        }

     
        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(" Funcionalidade ainda nao implementada!\n");

            Stream str;
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Obj files (*.obj)|*.obj|All files (*.*)|*.*";
            fileDialog.RestoreDirectory = true;
            
            if (fileDialog.ShowDialog()==DialogResult.OK)
                try
                {
                    if ((str = fileDialog.OpenFile()) != null)
                    {

                        using (str)
                        {
                            if (obj != null)
                            {
                                obj.getVertices3D().Clear(); // apagar as coordenadas dos vértices
                                obj.getIndicesFaces().Clear();// apagar os índices dos vértices
                                obj.getNumvPorFace().Clear();    // apagar o conteúdo do array numVPorFace                       
                                obj.setObjecto(this.BoxDesenho.Width, this.BoxDesenho.Height, str); // carregar novo objecto a partir de Ficheiro
                               
                            } 
                            nomeFicheiro = fileDialog.SafeFileName;
                                                      
                            setCores();
                            //if (check_wireframe.Checked)
                            //    obj.setWireframe();
                            
                            this.BoxDesenho.Invalidate();
                            this.pictureBox1.Invalidate();// voltar a redesenhar a picture box
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Não foi possível ler o ficheiro! \n Origem do Erro:" + ex.Message);
                }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trabalho realizado por \n" + " Manuel Ricardo Sá - 11228\n");
        }

        private void checkWireframe_CheckedChanged(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.setWireframe();
                this.BoxDesenho.Invalidate();
                this.pictureBox1.Invalidate();
            }
        }

        
        /* --------------------------------------------------- */
        /* --------- Auxiliares --------- */
        /* --------------------------------------------------- */
        // Configurar os atributos da pen e do brush
        private void setCores()
        {
            if (pen1 != null && brush1 != null)
            {
                pen1.Color = this.corContorno.BackColor;
                pen1.Width = (float)this.espessuraLinha.Value;

                brush1.Color = this.corFundo.BackColor;

                obj.setCores(pen1, brush1);
            }
        }
    }
}
