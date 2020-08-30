using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dainikprashashan.Service
{
    public class Basobasservice
    {
        //saving sthayi Basobas
        public string SaveSthayibasobas(Sthayi_Basobas sb)
        {
            var message = "";
            using (var context = new Entities())
            {
                var user = new Sthayi_Basobas()
                {

                    Aabedan_miti = sb.Aabedan_miti,
                    Nibedak_naam= sb.Nibedak_naam,
                    Naam= sb.Naam,
                    Nagarikta_no= sb.Nagarikta_no,
                    Nagarikta_Jilla= sb.Nagarikta_Jilla,
                    Nagarikta_miti= sb.Nagarikta_miti,
                    Pradesh = sb.Pradesh,
                    Jilla = sb.Jilla,
                    Gabisa = sb.Gabisa,
                    Ward = sb.Ward,
                    Sabik_thegana = sb.Sabik_thegana,
                    Basobas_miti= sb.Basobas_miti,
                    Tole= sb.Tole,
                    Batoko_naam= sb.Batoko_naam,
                    Ghar_no= sb.Ghar_no
                };
                context.Sthayi_Basobas.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //saving Asthayi Basobas
        public string SaveAsthayibasobas(Asthayi_Basobas ab)
        {
            var message = "";
            using (var context = new Entities())
            {
                var user = new Asthayi_Basobas()
                {

                    Aabedan_miti = ab.Aabedan_miti,
                    Aabedak_naam = ab.Aabedak_naam,
                    
                    Nagarikta_no = ab.Nagarikta_no,
                    Nagarikta_Jilla = ab.Nagarikta_Jilla,
                    Nagarikta_miti = ab.Nagarikta_miti,
                    Pradesh = ab.Pradesh,
                    Jilla = ab.Jilla,
                    Gabisa = ab.Gabisa,
                    Ward = ab.Ward,
                    Sabik_thegana = ab.Sabik_thegana,
                    Basobas_miti = ab.Basobas_miti,
                    Ghardhaniko_naam=ab.Ghardhaniko_naam,
                    Ghar_no = ab.Ghar_no,
                    Tole = ab.Tole,
                    Batoko_naam = ab.Batoko_naam
                    
                };
                context.Asthayi_Basobas.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //saving Antarik Basai Sarai
        public string SaveAntarikbasaisarai(Antarik_Basai_Sarai abs)
        {
            var message = "";
            using (var context = new Entities())
            {
                var user = new Antarik_Basai_Sarai()
                {

                    Aabedan_miti = abs.Aabedan_miti,
                    Aabedak_naam = abs.Aabedak_naam,
                    Purano_basobas_miti=abs.Purano_basobas_miti,
                    Buwako_naam=abs.Buwako_naam,
                    Amako_naam=abs.Amako_naam,
                    Purano_Pradesh = abs.Purano_Pradesh,
                    Purano_Jilla = abs.Purano_Jilla,
                    Purano_Gabisa = abs.Purano_Gabisa,
                    Purano_Ward = abs.Purano_Ward,
                    Purano_Tole = abs.Purano_Tole,
                    Haal_Pradesh = abs.Haal_Pradesh,
                    Haal_Jilla = abs.Haal_Jilla,
                    Haal_Gabisa = abs.Haal_Gabisa,
                    Haal_Ward = abs.Haal_Ward,
                    Haal_Tole = abs.Haal_Tole,
                   Pariwaarko_naam=abs.Pariwaarko_naam,
                   Nata=abs.Nata,
                   Nagarikta_janmadarta_no=abs.Nagarikta_janmadarta_no,
                    Ghar_no = abs.Ghar_no,
                    Batoko_naam = abs.Batoko_naam,
                    Umer=abs.Umer

                };
                context.Antarik_Basai_Sarai.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }
    
}
}