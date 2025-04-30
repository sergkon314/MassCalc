using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dms.pages.Main
{
    public partial class MassCalc : MassFilling
    {

        /*float[, ,] PrecTable = new float[5, 4, 7]//A3
        {
             {// до 100
                // М         X         Y         Z        Mx        My        Mz
                  {0.001f,   0.01f,    0.001f,   0.001f,  0.1f,     0.1f,     0.1f },// тех.предложение
                  {0.01f,    0.01f,    0.01f,    0.01f,   0.1f,     0.1f,     0.1f },// эскиз.проект
                  {0.001f,   0.01f,    0.01f,    0.01f,   0.01f,    0.01f,    0.01f},// тех.проект
                  {0.001f,   0.01f,    0.01f,    0.01f,   0.01f,    0.01f,    0.01f} // раб.проект
             },
             {// от 100 до 1000
                // М         X         Y         Z        Mx        My        Mz
                  {0.1f,     0.1f,     0.01f,    0.01f,   1.0f,     0.1f,     0.1f },// тех.предложение
                  {0.01f,    0.1f,     0.01f,    0.01f,   1.0f,     0.1f,     0.1f },// эскиз.проект
                  {0.01f,    0.01f,    0.01f,    0.01f,   0.1f,     0.01f,    0.01f},// тех.проект
                  {0.01f,    0.01f,    0.01f,    0.01f,   0.1f,     0.01f,    0.01f} // раб.проект
             },
             {// от 1000 до 10 000
                // М         X         Y         Z        Mx        My        Mz
                  {0.1f,     0.1f,     0.1f,     0.1f,    1.0f,     1.0f,     1.0f },// тех.предложение
                  {0.1f,     0.1f,     0.01f,    0.01f,   1.0f,     0.1f,     0.1f },// эскиз.проект
                  {0.1f,     0.01f,    0.01f,    0.01f,   0.1f,     0.1f,     0.1f },// тех.проект
                  {0.1f,     0.01f,    0.01f,    0.01f,   0.1f,     0.1f,     0.1f } // раб.проект
             },
             {// от 10 000 до 100 000
                // М         X         Y         Z        Mx        My        Mz
                  {1.0f,     0.1f,     0.1f,     0.1f,    1.0f,     1.0f,     1.0f },// тех.предложение
                  {0.1f,     0.01f,    0.01f,    0.01f,   1.0f,     1.0f,     1.0f },// эскиз.проект
                  {0.1f,     0.01f,    0.01f,    0.01f,   1.0f,     0.1f,     0.1f },// тех.проект
                  {0.1f,     0.01f,    0.01f,    0.01f,   1.0f,     0.1f,     0.1f } // раб.проект
             },
             {// свыше 100 000
                // М         X         Y         Z        Mx        My        Mz
                  {1.0f,     1.0f,     0.1f,     0.1f,    10.0f,    1.0f,     1.0f },// тех.предложение
                  {1.0f,     0.1f,     0.01f,    0.01f,   10.0f,    1.0f,     1.0f },// эскиз.проект
                  {0.1f,     0.01f,     0.01f,   0.01f,   1.0f,     1.0f,     1.0f },// тех.проект
                  {0.1f,     0.01f,     0.01f,   0.01f,   1.0f,     1.0f,     1.0f } // раб.проект
             }
        };
        float[, ,] PrecTable2 = new float[5, 4, 7]//A4
        {
             {// до 100
                // М         X         Y         Z        Mx        My        Mz
                  {0.1f,     0.01f,    0.01f,    0.01f,   1.0f,      1f,       1f  },// тех.предложение
                  {0.1f,     0.01f,    0.01f,    0.01f,   1.0f,      0.1f,     0.1f},// эскиз.проект
                  {0.01f,    0.01f,    0.01f,    0.01f,   0.1f,      0.1f,     0.1f},// тех.проект
                  {0.01f,    0.01f,    0.01f,    0.01f,   0.1f,      0.1f,     0.1f} // раб.проект
             },
             {// от 100 до 1000
                // М         X         Y         Z        Mx        My        Mz
                  {0.1f,     0.1f,     0.01f,    0.01f,   10.0f,    1.0f,     1.0f },// тех.предложение
                  {0.1f,     0.01f,    0.01f,    0.01f,   10.0f,    1.0f,     1.0f },// эскиз.проект
                  {0.1f,     0.01f,    0.01f,    0.01f,   1.0f,     0.1f,     0.1f },// тех.проект
                  {0.1f,     0.01f,    0.01f,    0.01f,   1.0f,     0.1f,     0.1f } // раб.проект
             },
             {// от 1000 до 10 000
                // М         X         Y         Z        Mx        My        Mz
                  {1.0f,     0.1f,     0.01f,    0.01f,   10.0f,    1.0f,     1.0f },// тех.предложение
                  {1.0f,     0.1f,     0.01f,    0.01f,   10.0f,    1.0f,     1.0f },// эскиз.проект
                  {1.0f,     0.01f,    0.01f,    0.01f,   1.0f,     1.0f,     1.0f },// тех.проект
                  {1.0f,     0.01f,    0.01f,    0.01f,   1.0f,     1.0f,     1.0f } // раб.проект
             },
             {// от 10 000 до 100 000
                // М         X         Y         Z        Mx        My        Mz
                  {10.0f,    0.1f,     0.1f,     0.1f,    10.0f,    5.0f,     5.0f },// тех.предложение
                  {1.0f,     0.1f,     0.01f,    0.01f,   10.0f,    1.0f,     1.0f },// эскиз.проект
                  {1.0f,     0.01f,    0.01f,    0.01f,   10.0f,    1.0f,     1.0f  },// тех.проект
                  {1.0f,     0.01f,    0.01f,    0.01f,   10.0f,    1.0f,     1.0f  } // раб.проект
             },
             {// свыше 100 000
                // М         X         Y         Z        Mx        My        Mz
                  {10.0f,    0.1f,     0.1f,     0.1f,    100.0f,   10.0f,    10.0f },// тех.предложение
                  {10.0f,    0.1f,     0.01f,    0.01f,   100.0f,   10.0f,    10.0f },// эскиз.проект
                  {1.0f,     0.01f,    0.01f,    0.01f,   10.0f,    10.0f,    10.0f },// тех.проект
                  {1.0f,     0.01f,    0.01f,    0.01f,   10.0f,    10.0f,    10.0f } // раб.проект
             }
        };
        float[, ,] PrecTable3 = new float[5, 1, 7]//A5
        {
             {// до 100
                // М         X         Y         Z        Mx        My        Mz
                  {0.1f,     0.01f,    0.01f,    0.01f,   1f,       1f,       1f  }
             },
             {// от 100 до 1000
                // М         X         Y         Z        Mx        My        Mz
                  {1f,       0.01f,    0.01f,    0.01f,   1f,       1f,       1f  }
             },
             {// от 1000 до 10 000
                // М         X         Y         Z        Mx        My        Mz
                  {1f,       0.01f,    0.01f,    0.01f,   10f,      1f,       1f }
             },
             {// от 10 000 до 100 000
                // М         X         Y         Z        Mx        My        Mz
                  {10f,      0.01f,     0.01f,    0.01f,   10f,      10f,      10f  }
             },
             {// свыше 100 000
                // М         X         Y         Z        Mx        My        Mz
                  {10f,      0.01f,     0.01f,    0.01f,   100f,     10f,      10f }
             }
        };*/
        private string Format(float f, int m, int type, int field, string code = null)
        {
            if (type == 4) type = 0; // проработка=тех.предложение
            float prec = 0f;
            if (code == null)
            {
                prec = PrecTable3[m, 0, field];
                //prec = PrecTable2[m, 0, field];
            }
            else
            {
                if (code.IndexOf("000000") > 0)
                {
                    prec = PrecTable2[m, type, field];
                }
                else
                {
                    prec = PrecTable[m, type, field];
                }
            }
            string formatted_num = "";
            float round_num = (float)(Math.Round(f / prec) * prec);
            string str_prec = prec.ToString();
            string format = "";
            int comma_pos = str_prec.IndexOf(',');
            if (comma_pos > 0)
            {
                int dig = str_prec.Length - 2;
                format = "N" + dig;
            }

            formatted_num = round_num.ToString(format);

            if (Convert.ToDouble(formatted_num) == 0 && field == 0)
            {
                formatted_num = (Math.Round(f * 1000) / 1000).ToString("N3");
            }
            //formatted_num = formatted_num.Replace(" ", "");
            return formatted_num;
        }
    }
}
