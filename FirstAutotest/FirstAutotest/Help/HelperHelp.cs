using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAutotest.Helper
{
    class HelperHelp
    {
        public void Random (ref string randomWord)
        {
            bool digitOrLetter = false;
            Random random = new Random();
            for (int i = 0; i < 14; i++){
                if (digitOrLetter)
                {
                    randomWord += (char)random.Next(65, 90);
                }
                else
                {
                    randomWord += (char)random.Next(48, 57);
                }
                digitOrLetter = !digitOrLetter;
            }
        }
    }
}
