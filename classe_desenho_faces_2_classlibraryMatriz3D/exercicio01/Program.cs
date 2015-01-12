// versão desenho faces  (com class library metodosMatriz3D.Matriz3D) - v2.0
// evolução da v1.0 abrangendo:
// -leitura da face a partir de ficheiro contendo os dados da face (coordenadas de vértices e índices)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace exercicio01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
