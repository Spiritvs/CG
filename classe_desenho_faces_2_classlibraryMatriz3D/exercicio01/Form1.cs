
// versão completa desenho faces 2 (com class library metodosMatriz3D.Matriz3D)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // para usar as streams

namespace exercicio01
{
    public partial class Form1 : Form
    {
        Objecto obj;
        Pen pen1;
        SolidBrush brush1;
        string nomeFicheiro;
 
        public Form1()
        {
            InitializeComponent();
           
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
                     
                obj.desenha(g, (float)(transX.Value), (float)(transY.Value), (float)(transZ.Value));
           
        }

        private void transX_ValueChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
        }

        private void transY_ValueChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
        }

        private void transZ_ValueChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
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
                }
            }


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.setCentroProjeccao(this.BoxDesenho.Width, this.BoxDesenho.Height);
                this.BoxDesenho.Invalidate();
            }
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.BoxDesenho.Invalidate();
        }

        private void espessuraLinha_ValueChanged(object sender, EventArgs e)
        {
            if (obj != null)
            {
                setCores();
                this.BoxDesenho.Invalidate();
            }


        }

     
        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(" Funcionalidade ainda nao implementada!\n");

            Stream str;
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
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
                            
                            this.BoxDesenho.Invalidate(); // voltar a redesenhar a picture box
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
            MessageBox.Show("Desenho de Faces \n" + " versao 2.0\n");
        }

        private void checkWireframe_CheckedChanged(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.setWireframe();
                this.BoxDesenho.Invalidate();
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
