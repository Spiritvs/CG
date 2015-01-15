// versão desenho faces  (com class library metodosMatriz3D.Matriz3D) - v2.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
using System.IO; // para usar as streams

namespace exercicio01
{
    class Objecto
    {
        // Classe para desenho de objectos representados por faces poligonais; neste exemplo apenas está a desenhar uma face (cujos valores são inicializados no construtor)
        // mas pode ser estendida para mais faces
 
        ArrayList vertices; // array para guardar os vértices 3D do objecto
        ArrayList indicesFaces; // array para guardar os índices dos vértices do objecto
        ArrayList numvPorFace;  // array para guardar o número de vértices por face

        float centroProjeccaoX;// largura da janela usada para definir o centro da janela de desenho
        float centroProjeccaoY;// altura da janela usada para definir o centro da janela de desenho

        Pen penContorno; // pen usada para o contorno do objecto
        SolidBrush brushPreenchimento; // brush usado para a cor de fundo do objecto

        bool wireframe; // define se vai ser usado com preenchimento ou em linha de arame

        Stream s; // stream para carregar o ficheiro, para o caso do objecto ser lido a partir de um ficheiro 

        public Objecto()
        {
            inicializaObjecto();
        }

        void inicializaObjecto()
        {
            vertices = new ArrayList();
            indicesFaces = new ArrayList();
            numvPorFace = new ArrayList();

            // valores atribuídos manualmente

            // uma face quadrada
            //vértices
            vertices.Add(new Vector3D(-60, -60, 0.5f));
            vertices.Add(new Vector3D(60, -60, 0.5f));
            vertices.Add(new Vector3D(60, 60, 0.5f));
            vertices.Add(new Vector3D(-60, 60, 0.5f));


            //indices
            indicesFaces.Add(0);
            indicesFaces.Add(1);
            indicesFaces.Add(2);
            indicesFaces.Add(3);

  
            numvPorFace.Add(4);

        /*   
            // uma face triangular
            vertices.Add(new Vector3D(-30.0f, -30.0f, 1.0f,1.0f)); 
            vertices.Add(new Vector3D(30.0f, -30.0f, 1.0f, 1.0f));
            vertices.Add(new Vector3D(0.0f, 30.0f, 1.0f, 1.0f));

            indicesFaces.Add(0);
            indicesFaces.Add(1);
            indicesFaces.Add(2);

            numvPorFace.Add(3);
         */
            penContorno = new Pen(Color.Black, 3); // pen por omissão
            brushPreenchimento = new SolidBrush(Color.SteelBlue); // brush por omissão

            wireframe = false; //por omissão e' preenchido;
        }

        public Objecto(float centroX, float centroY)
        {   setCentroProjeccao(centroX, centroY);
            inicializaObjecto();
        }

        public Objecto(float centroX, float centroY, Stream s)
        {
            // construtor para criar objecto a partir de um ficheiro
            this.s = s;
            leFicheiro();  // função que lê a estrutura do objecto a partir de um ficheiro
            setCentroProjeccao(centroX, centroY);
       }

        public void setObjecto(float centroX, float centroY, Stream s) // construtor para criar objecto a partir de um ficheiro
        {
            this.s = s;
            leFicheiro();  // função que lê a estrutura do objecto a partir de um ficheiro
            setCentroProjeccao(centroX, centroY);
        }

        private void leFicheiro()
        {
            StreamReader readerObjecto = new StreamReader(this.s);
           
            // colocar aqui a leitura do ficheiro com a estrutura do objecto (coordenadas vértices, índices faces, ...) para as estruturas de dados da classe Objecto
                

            string linha = "";
            ArrayList pontos = new ArrayList();
            ArrayList indices = new ArrayList();

            while (linha != null)
            {
                linha = readerObjecto.ReadLine(); // lê uma linha do ficheiro
                if (linha != null)
                {
                    if (linha.StartsWith("v "))
                     // se a linha inicia por "v"
                        pontos.Add(linha);     // adiciona ao array para guardar os vértices

                    if (linha.StartsWith("f")) // se a linha inicia por "f"
                        indices.Add(linha);      // adiciona ao array para guardar os índices dos vértices das faces
                }


            }
            readerObjecto.Close();
            // agora que todas as linhas estão guardadas, é necessário extrair delas as coordenadas individuais

            char[] separador = { ' ' };// definir o separador: caracter espaço
            string[] coordenadas;
            foreach (string l in pontos)
            {
                coordenadas=l.Split(separador);
               // System.Windows.Forms.MessageBox.Show("" + float.Parse(coordenadas[1], System.Globalization.CultureInfo.InvariantCulture));
                this.vertices.Add(new Vector3D(float.Parse(coordenadas[1], System.Globalization.CultureInfo.InvariantCulture) ,
                float.Parse(coordenadas[2], System.Globalization.CultureInfo.InvariantCulture) ,
                float.Parse(coordenadas[3], System.Globalization.CultureInfo.InvariantCulture) )); //divide por 10 pois o ficheiro recebe coordenadas com 1 casa decimal
            }

            string[] indicesVert;
            foreach (string l in indices)
            {
                indicesVert = l.Split(separador);
                numvPorFace.Add(indicesVert.Length - 1);
                for (int i = 1; i < indicesVert.Length; i++)
                {
                    string ind = indicesVert[i].Split('/')[0];
                    int correcto = int.Parse(ind) - 1;
                    //System.Windows.Forms.MessageBox.Show("" + correcto);
                       this.indicesFaces.Add(correcto);
                }
            }
            //foreach (Vector3D vect in vertices)
            //System.Windows.Forms.MessageBox.Show("" +vect);

        }
 

        public ArrayList getVertices3D()
        {
            return this.vertices;
        }

        public ArrayList getIndicesFaces()
        {
            return this.indicesFaces;
        }

        public ArrayList getNumvPorFace()
        {
            return this.numvPorFace;
        }

        public void setCores(Pen penContorno, SolidBrush brushPreenchimento)
        {
            this.penContorno = penContorno;
            this.brushPreenchimento = brushPreenchimento;
        }

        public void setWireframe()
        {
            this.wireframe = !this.wireframe;

        }

        public void setCentroProjeccao(float centroX, float centroY)
        {
            this.centroProjeccaoX = centroX;
            this.centroProjeccaoY = centroY;
        }

        //aplicar transformações de translação ao objecto
        private ArrayList transforma(float translacaoX, float translacaoY, float translacaoZ, float rodaX, float rodaY, float rodaZ, float camara, float escala, int cam)
        {
           ArrayList res = new ArrayList(vertices.Count);

                     
           foreach (Vector3D p in this.vertices) // para não alterar os vértices originais, cria uma cópia
              {

                  //System.Windows.Forms.MessageBox.Show("" + p);
                  res.Add(p.clone());
                
              }
            metodosMatriz3D.Matriz3D mTrans = metodosMatriz3D.Matriz3D.translacao(translacaoX, translacaoY, translacaoZ);
            metodosMatriz3D.Matriz3D mRodaX = metodosMatriz3D.Matriz3D.rotacaoX(rodaX);
            metodosMatriz3D.Matriz3D mRodaY = metodosMatriz3D.Matriz3D.rotacaoY(rodaY);
            metodosMatriz3D.Matriz3D mRodaZ = metodosMatriz3D.Matriz3D.rotacaoZ(rodaZ);
            metodosMatriz3D.Matriz3D mEscala = metodosMatriz3D.Matriz3D.escala(escala, escala, escala);
            metodosMatriz3D.Matriz3D mProj = new metodosMatriz3D.Matriz3D();
            if (cam == 1)
            {
                mProj = metodosMatriz3D.Matriz3D.projParalela();
            }
            if (cam == 0)
            {
                mProj = metodosMatriz3D.Matriz3D.projPerspectiva(camara);
            } // a câmara está em Z=-3

            for (int i = 0; i < res.Count; i++)
            {
                Vector3D p = (Vector3D)res[i];
                p.geraCoordHomogeneas(mTrans);
                p.geraCoordHomogeneas(mRodaX);
                p.geraCoordHomogeneas(mRodaY);
                p.geraCoordHomogeneas(mRodaZ);
                p.geraCoordHomogeneas(mEscala);
                p.geraCoordCartesianas(mProj);
            }
            
          return res;
        }
        
        private ArrayList geraFaces(ArrayList verticesTransf)
        {

            ArrayList faces = new ArrayList();
            int k = 0;
           
            for (int i = 0; i < numvPorFace.Count; i++)
            {
                Face f = new Face();
               
                for (int j = 0; j < (int)numvPorFace[i]; j++)
                {
                    Vector3D p = (Vector3D)verticesTransf[(int)indicesFaces[k++]];
                    f.saveVertice(p);
                }
                faces.Add(f);
               
            }
            return faces;
        } 

        // desenha as faces do objecto
        public void desenha(Graphics g, float translacaoX, float translacaoY, float translacaoZ, float rodaX, float rodaY, float rodaZ, float camara, float escala, int cam)
        {

           
          ArrayList vTransf=transforma(translacaoX, translacaoY, translacaoZ, rodaX, rodaY, rodaZ, camara, escala, cam); // calcula os novos vértices
          ArrayList faces=geraFaces(vTransf); // gera as novas faces com base nos novos vértices
            
          for (int i = 0; i < faces.Count; i++) // percorre face a face e desenha 
          {
            Face f = (Face)faces[i];
            if (!this.wireframe) 
                 g.FillPolygon(brushPreenchimento, (PointF[])f.getVertices2D(centroProjeccaoX,centroProjeccaoY)); // se escolheu wireframe não preenche
            g.DrawPolygon(penContorno, (PointF[])f.getVertices2D(centroProjeccaoX,centroProjeccaoY)); //desenha sempre a linha
         }

 
        }
        
    }//fecha classe
}//fecha namespace
