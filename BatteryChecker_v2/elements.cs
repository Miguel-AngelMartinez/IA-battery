using IAupt.uptRNA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryChecker_v2
{
    public class elements
    {
        public bool check;
        public void training()
        {
          PerceptronMultiCapa rna = new PerceptronMultiCapa(@"InstructivoPerceptronMulticapa.pml");
          rna.entrenar();
        }
        public void recognize()
        {
          PerceptronMultiCapa rna = new PerceptronMultiCapa(@"PerceptronMultiCapa.ppm");

           double[] x = { 1, 0, 1 };
           rna.reconocer(x);

           double[,] y = rna.y;
           
        }
        public void checker(bool element)
        {

        }
        public bool checking(bool element) 
        {
            
            return this.check;
        }
    }
}
