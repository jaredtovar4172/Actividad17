using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Ej17._NumerosEntradas
{
    class PositivoNegativo
    {
        public string CuentaNumeros(int cantidad)
        {
            int contpositivo = 0, contnegativo = 0, contcero = 0;
            DialogBoxCaptura captura = new DialogBoxCaptura();
            for (int i = 1; i <= cantidad; i++)
            {    
            if (captura.ShowDialog() == DialogResult.OK)
            {
              if (int.Parse(captura.numero) > 0)
            {
               contpositivo++;
            }
              if (int.Parse(captura.numero) < 0)
                    {
                        contnegativo++;
                    }
              if(int.Parse(captura.numero) == 0)
                    {
                        contcero++;
               }
            }
          }
            return ("Cantidad de numeros positios: " + contpositivo + "\n" + "Cantidad de numeros negativos: " + contnegativo + "\n" + "Cantidad de ceros: " + contcero);
        }
    }
}
