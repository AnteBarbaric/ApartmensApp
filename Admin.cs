using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace INF
{
    public static class Admin
    {
        public static List<string> pregled_gostiju(string apartman)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("podaci.txt");
            }
            catch
            {
                return null;
            }
            
            List<string> lista = new List<string>();
            string linija;
            bool kraj = false;
            while(!sr.EndOfStream)
            {
                linija = sr.ReadLine();
                if(linija.StartsWith(apartman))
                {
                    lista.Add(linija);
                }
            }
            sr.Close();
            return lista;
        }
        public static bool slobodan_app(DateTime novid1, DateTime novid2, string apartman)
        {

            DateTime starid1 = new DateTime();
            DateTime starid2 = new DateTime();
            int x = 0;
            string[] nesto = null;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("podaci.txt");
            }
            catch
            {
                return false;
            }
            
            string linija;
            while (!sr.EndOfStream)
            {

                linija = sr.ReadLine();
                x++;
                nesto = linija.Split('|');
                if (nesto[0].Equals(apartman))
                {
                    starid1 = Convert.ToDateTime(nesto[3]);
                    starid2 = Convert.ToDateTime(nesto[4]);
                    if ((starid1 < novid2 && novid1 < starid2)||(novid1>novid2))
                    {
                        sr.Close();
                        return true;
                    }
                }

            }
            sr.Close();
            return false;
        }

        public static int raspon_dana(DateTime pocetni,DateTime zavrsni)
        {
            
            TimeSpan razlika = zavrsni - pocetni;
            int brojDana = razlika.Days;
            return razlika.Days;
        }
        
    
        
    }
}
