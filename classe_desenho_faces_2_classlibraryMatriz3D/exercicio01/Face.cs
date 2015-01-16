using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
namespace exercicio01
{
    class Face
    {
        ArrayList vertices3D = new ArrayList();
        Vector3D normal;
        
        public Face()
        {
        }

        public Face(ArrayList vertices3D)
        {
            this.vertices3D= vertices3D;
        }

        public ArrayList getVerticesFace()
        {
            return vertices3D;
        }
        public void saveVertice(Vector3D vertice3D)
        {
            this.vertices3D.Add(vertice3D);
        }

        public PointF[] getVertices2D(float centroProjX, float centroProjY)
        {
            PointF[] pontos2D = new PointF[vertices3D.Count];
            for (int i = 0; i < vertices3D.Count; i++)
            {
                Vector3D p = (Vector3D)vertices3D[i];
                pontos2D[i]=p.getPonto2D(centroProjX,centroProjY);

            }
            return pontos2D;
        }

        public Vector3D calcNormal(){
            Vector3D a = new Vector3D();
            Vector3D b = new Vector3D();
            a = (Vector3D)vertices3D[0] - (Vector3D)vertices3D[1];
            b = (Vector3D)vertices3D[2] - (Vector3D)vertices3D[1];
            this.normal = b ^ a;
            this.normal.normalize();
            return this.normal;
        }

        public float calcZMedio() {
            float resultado = 0;
            Vector3D v = new Vector3D();
            float temp;
            for (int i = 0; i < vertices3D.Count; i++ ){
                v = (Vector3D)vertices3D[i];
                temp = v.z;
                resultado = resultado + temp;
            }
            resultado = resultado / vertices3D.Count;
            return resultado;
        }
        

        
        
        
    }
}
