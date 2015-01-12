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
        

        
        
        
    }
}
