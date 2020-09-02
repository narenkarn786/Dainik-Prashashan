using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dainikprashashan.Service
{
    public class Jaggaservice
    {
        //saving Jaggadhani Pratilipi
        public string SaveJaggadhanipratilipi(Jaggadhani_Pratilipi jp)
        {
            var message = "";
            using (var context = new Entities())
            {
                var user = new Jaggadhani_Pratilipi()
                {

                    Aabedan_miti = jp.Aabedan_miti,
                   Naam=jp.Naam,
                   Nagarikta_no=jp.Nagarikta_no,
                   Nagarikta_miti=jp.Nagarikta_miti,
                   Buwako_naam=jp.Buwako_naam,
                   Bajeko_naam=jp.Bajeko_naam,
                   Aabedak_pradesh=jp.Aabedak_pradesh,
                   Aabedak_jilla=jp.Aabedak_jilla,
                   Aabedak_gabisa=jp.Aabedak_gabisa,
                   Aabedak_ward=jp.Aabedak_ward,
                   Aabedak_sabik_thegana=jp.Aabedak_sabik_thegana,
                   Jaggadhaniko_naam=jp.Jaggadhaniko_naam,
                   Kitta_no=jp.Kitta_no,
                   Bigga=jp.Bigga,
                   Kattha=jp.Kattha,
                   Dhur=jp.Dhur,
                   Jagga_pradesh=jp.Jagga_pradesh,
                   Jagga_jilla=jp.Jagga_jilla,
                   Jagga_gabisa=jp.Jagga_gabisa,
                   Jagga_ward=jp.Jagga_ward,
                   Jagga_sabik_thegana=jp.Jagga_sabik_thegana
                };
                context.Jaggadhani_Pratilipi.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //saving Bato Kayam
        public string SaveBatokayam(Bato_Kayam bkm)
        {
            var message = "";
            using (var context = new Entities())
            {
                var user = new Bato_Kayam()
                {

                    Aabedan_miti = bkm.Aabedan_miti,
                    Jagga_Dhaniko_Naam= bkm.Jagga_Dhaniko_Naam,
                    Kitta_no = bkm.Kitta_no,
                    Bigga = bkm.Bigga,
                    Kattha = bkm.Kattha,
                    Dhur = bkm.Dhur,
                    Pradesh= bkm.Pradesh,
                    Jilla=bkm.Jilla,
                    Gabisa= bkm.Gabisa,
                    Ward= bkm.Ward,
                    sabik_thegana=bkm.sabik_thegana,
                    Bato_Disa=bkm.Bato_Disa,
                    Sadak_Lambai= bkm.Sadak_Lambai,
                    Sadak_Chaudai=bkm.Sadak_Chaudai


                };
                context.Bato_Kayam.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //saving Jagga Ghar Kayam
        public string SaveJaggagharkayam(Jagga_Ghar_Kayam jgk)
        {
            var message = "";
            using (var context = new Entities())
            {
                var user = new Jagga_Ghar_Kayam()
                {

                    Aabedan_miti = jgk.Aabedan_miti,
                    Aabedak_naam= jgk.Aabedak_naam,
                    Bigga = jgk.Bigga,
                    Kattha = jgk.Kattha,
                    Dhur = jgk.Dhur,
                    Pradesh = jgk.Pradesh,
                    Jilla = jgk.Jilla,
                    Gabisa = jgk.Gabisa,
                    Ward = jgk.Ward,
                    sabik_thegana = jgk.sabik_thegana,
                   Kitta_no= jgk.Kitta_no


                };
                context.Jagga_Ghar_Kayam.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //saving Charkilla sambandhama
        public string SaveCharkilla(Charkilla_Sambandhama cs)
        {
            var message = "";
            using (var context = new Entities())
            {
                var user = new Charkilla_Sambandhama()
                {

                    Aabedan_miti = cs.Aabedan_miti,
                   Karyalaya= cs.Karyalaya,
                    Pradesh = cs.Pradesh,
                    Jilla = cs.Jilla,
                    Gabisa = cs.Gabisa,
                    Ward = cs.Ward,
                   Sabik_gabisa= cs.Sabik_gabisa,
                   Haal_gabisa= cs.Haal_gabisa,
                   Naksha_sheetno= cs.Naksha_sheetno,
                   Kitta_no= cs.Kitta_no,
                   Bigga= cs.Bigga,
                   Kattha= cs.Kattha,
                   Dhur= cs.Dhur,
                   Batoko_Prakaar= cs.Batoko_Prakaar,
                   East= cs.East,
                   West= cs.West,
                   North= cs.North,
                   South= cs.South,
                   Kaifiyat= cs.Kaifiyat



                };
                context.Charkilla_Sambandhama.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //saving Mohi Lagat Katta
        public string SaveMohilagatkatta(Mohi_Lagat_Katta mlk)
        {
            var message = "";
            using (var context = new Entities())
            {
                var user = new Mohi_Lagat_Katta()
                {

                    Aabedan_miti = mlk.Aabedan_miti,
                    Jaggadhaniko_naam= mlk.Jaggadhaniko_naam,
                    Mohiko_naam= mlk.Mohiko_naam,
                    Kitta_no= mlk.Kitta_no,
                    Sheet_no= mlk.Sheet_no  ,
                    Bigga = mlk.Bigga,
                    Kattha = mlk.Kattha,
                    Dhur = mlk.Dhur,
                    Pradesh= mlk.Pradesh,
                    Jilla= mlk.Jilla,
                    Gabisa= mlk.Gabisa,
                    Ward= mlk.Ward,
                    Sabik_thegana= mlk.Sabik_thegana,
                    Sarjamin_miti= mlk.Sarjamin_miti
                };
                context.Mohi_Lagat_Katta.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }
    }
}