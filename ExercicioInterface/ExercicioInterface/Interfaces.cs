using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    internal class Interfaces
    {
        public interface G1
        {
            void mymethod();
        }
        public interface G2
        {
            void mymethod();
        }
        public class Geeks : G1, G2
        {
            void G2.mymethod()
            {
                //todo
            }

            void G1.mymethod()
            {
                throw new NotImplementedException();
            }
        }
    }
}
