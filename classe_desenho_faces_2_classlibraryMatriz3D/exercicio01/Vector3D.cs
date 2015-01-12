using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio01
{
    public class Vector3D
    {
        //------DADOS da classe ----------------------
        float x, y, z, w;

        //--------- MÉTODOS --------------------------

        //construtor por omissão (sem parâmetros)
        public Vector3D()
        {
        }

        //construtor por cópia (o parâmetro é um objecto da mesma classe)
        public Vector3D(Vector3D v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        //construtor com parâmetros (x,y e z)
        public Vector3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = 1.0f;
        }
        //construtor com parâmetros (x,y,z e w) para representação em coordenadas homogéneas
        public Vector3D(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        //Retorna o clone object de um ponto
        public object clone()
        {
            return (object)new Vector3D(x, y, z, w);
        }
        /*
        //Retorna o clone object de um ponto 
        public Vector3D clone()
        {
            return new Vector3D(this.x, this.y, this.z, this.w);
        }
          */

        //Verifica se o ponto é igual a um objecto b
        public bool  equals(object b)
        {

            if (((Vector3D)b).x == this.x && ((Vector3D)b).y == this.y && ((Vector3D)b).z == this.z && ((Vector3D)b).w == this.w)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Verifica se o ponto é igual a um ponto v
        public bool Equals(Vector3D v)
        {
            if (v.x == this.x && v.y == this.y && v.z == this.z && v.w == this.w)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //+ do ponto
        public static Vector3D operator +(Vector3D v)
        {
            return v;
        }

        //Simétrico do ponto; operador unário
        public static Vector3D operator -(Vector3D v)
        {
            float x1, y1, z1, w1;
            x1 = -v.x;
            y1 = -v.y;
            z1 = -v.z;
            w1 = v.w;
            return new Vector3D(x1, y1, z1, w1);
        }

        //Multiplica por uma constante
        public static Vector3D operator *(Vector3D v, float c)
        {
            float x1, y1, z1, w1;
            x1 = c * v.x;
            y1 = c * v.y;
            z1 = c * v.z;
            w1 = v.w;
            return new Vector3D(x1, y1, z1, w1);
        }

        //Divide ponto por uma contante
        public static Vector3D operator /(Vector3D v, float c)
        {
            float x1, y1, z1, w1;
            x1 = v.x / c;
            y1 = v.y / c;
            z1 = v.z / c;
            w1 = v.w;
            return new Vector3D(x1, y1, z1, w1);
        }

        //Produto vectorial dos pontos
        public static Vector3D operator ^(Vector3D v1, Vector3D v2)
        {
            Vector3D r = new Vector3D();
            r.x = (v1.y * v2.z - v2.y * v1.z);
            r.y = r.y = (v1.z * v2.x - v1.x * v2.z);
            r.z = (v1.x * v2.y - v2.x * v1.y);
            return r;
        }

        //Produto escalar de um ponto
        public static float operator *(Vector3D v1, Vector3D v2)
        {
            float i;
            i = v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
            return i;
        }


        //Norma de um ponto
        public float norm()
        {
            //return (float)Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
            return (float)Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
        }

        //Normalização de um ponto
        public void normalize()
        {
            float n = norm();
            if (n != 0.0)
            {
                this.x = this.x / n;
                this.y = this.y / n;
                this.z = this.z / n;
            }
        }

        // Converte para string
        public override string ToString()
        {
            string res;
            res = "(" + this.x + ", " + this.y + ", " + this.z + ")";
            return res;
        }


        //Soma dois pontos em 3D;sobrecarga do operador +
        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w);
        }

        //Subtracção dos dois pontos em 3D;sobrecarga do operador -
        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z, v1.w);
        }

      
        public void geraCoordHomogeneas(metodosMatriz3D.Matriz3D m)
        {
            float[] resultado=m.multiplicaVector(new float[4]{this.x, this.y, this.z, this.w});
            this.x = resultado[0];
            this.y = resultado[1]; 
            this.z = resultado[2];
            this.w = resultado[3];
        }
        public void geraCoordCartesianas(metodosMatriz3D.Matriz3D m)
        {
            float[] resultado = m.multiplicaVector(new float[4] { this.x, this.y, this.z, this.w });
            this.x = resultado[0] / resultado[3];
            this.y = resultado[1] / resultado[3];
            this.z = resultado[2]; // não divide por w para preservar a informação sobre Z
            this.w = 1;
        }
        
        public PointF getPonto2D(float centroX, float centroY) 
        {
            // centroX e centroY são o ponto de referência do objecto
            // Aqui faz-se a conversão de coordenadas mundo  para coordenadas do dispositivo
            // xv= xvmin + (xw-xwmin)*Sx, com Sx= (xvmax-xvmin)/(xwmax-xwmin)
            // yv= yvmin - (yw-ywmin)*Sy, com Sy= (yvmax-yvmin)/(ywmax-ywmin), uma vez que o Y está orientado para cima no mundo, vem com o sinal -
            // neste caso o tamanho do mundo e da janela é o mesmo logo Sx e Sy são iguais a 1
            
            return new PointF(centroX/2+ this.x, centroY/2 -this.y);
           
        }
    }
}