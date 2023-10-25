using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework
{
    public class PrivatKundMaxbelopp
    {
        private static PrivatKundMaxbelopp instance;

        // Define your global variables here
        private int globalVariable;

        private PrivatKundMaxbelopp()
        {
            // Initialize your global variables here
            globalVariable = 12000;
        }

        public static PrivatKundMaxbelopp Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PrivatKundMaxbelopp();
                }
                return instance;
            }
        }

        public int GlobalVariable
        {
            get { return globalVariable; }
            set { globalVariable = value; }
        }
    }
}
