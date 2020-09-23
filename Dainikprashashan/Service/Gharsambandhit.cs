using Dainikprashashan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dainikprashashan.Service
{
    public class Gharsambandhit
    {
        //Ghar sifarisko Bibaran
        //Saving Ghar sifarisko Bibaran
        public string SaveGharkayamkosifaris(Ghar_kayamko_sifaris gks)
        {
            var message = "";
            using (var context = new Entities1())
            {
                var user = new Ghar_kayamko_sifaris()
                {

                    Aabedan_miti = gks.Aabedan_miti,
                    karyalaya = gks.karyalaya,
                    Aabedak_name = gks.Aabedak_name,
                    Pradesh = gks.Pradesh,
                    Jilla = gks.Jilla,
                    Gabisa = gks.Gabisa,
                    Ward = gks.Ward,
                    Gajjako_sabikthegana = gks.Gajjako_sabikthegana,
                    Naksa_sheetno = gks.Naksa_sheetno,
                    Kitta_no = gks.Kitta_no,
                    Bigga = gks.Bigga,
                    Kattha = gks.Kattha,
                    Dhur = gks.Dhur,
                    Ghar_no = gks.Ghar_no,
                    Gharko_prakaar = gks.Gharko_prakaar,
                    Gharnirmaan_saal = gks.Gharnirmaan_saal
                };
                context.Ghar_kayamko_sifaris.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Aabedan Biwaran

        public List<GharkayamList> GetSelfList(string loginId)
        {
            using (var context = new Entities1())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Ghar_kayamko_sifaris/*.Where(x => x.FormId == lgId)*/.ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var lbd in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = lbd.FormId,
                        Aabedan_miti=lbd.Aabedan_miti,
                        Aabedak_name = lbd.Aabedak_name,
                        Pradesh = lbd.Pradesh,
                        Jilla = lbd.Jilla,
                        Gabisa = lbd.Gabisa,
                        Ward = lbd.Ward,
                        Gajjako_sabikthegana = lbd.Gajjako_sabikthegana,
                        Naksa_sheetno = lbd.Naksa_sheetno,
                        Kitta_no = lbd.Kitta_no,
                        Bigga = lbd.Bigga,
                        Kattha = lbd.Kattha,
                        Dhur = lbd.Dhur,
                        Ghar_no = lbd.Ghar_no,
                        Gharko_prakaar = lbd.Gharko_prakaar,
                        Gharnirmaan_saal = lbd.Gharnirmaan_saal
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }
        //Edit Aabedan Biwaran
        public string UpdateData(Ghar_kayamko_sifaris bd, string loginId)
        {

            var message = "";

            using (var context = new Entities1())
            {
                var decId = Convert.ToDecimal(loginId);
                var dataToUpdate = context.Ghar_kayamko_sifaris.Where(x => x.FormId == decId).FirstOrDefault();
                dataToUpdate.Aabedan_miti = bd.Aabedan_miti;
                dataToUpdate.karyalaya = bd.karyalaya;
                dataToUpdate.Aabedak_name = bd.Aabedak_name;
                dataToUpdate.Pradesh = bd.Pradesh;
                dataToUpdate.Jilla = bd.Jilla;
                dataToUpdate.Gabisa = bd.Gabisa;
                dataToUpdate. Ward= bd.Ward;
                dataToUpdate.Gajjako_sabikthegana = bd.Gajjako_sabikthegana;
                dataToUpdate.Naksa_sheetno = bd.Naksa_sheetno;
                dataToUpdate. Kitta_no= bd.Kitta_no;
                dataToUpdate.Bigga = bd.Bigga;
                dataToUpdate.Kattha = bd.Kattha;
                dataToUpdate.Dhur = bd.Dhur;
                dataToUpdate.Ghar_no = bd.Ghar_no;
                    dataToUpdate.Gharko_prakaar = bd.Gharko_prakaar;
                dataToUpdate. Gharnirmaan_saal= bd.Gharnirmaan_saal;

                context.SaveChanges();
                message = "Update successfull";
            }
            return message;

        }

        //Ghar Bato Pramanit
        //saving Ghar Bato Pramanit
        public string SaveGharbatopramanit(Ghar_Bato_Pramanit gbp)
        {
            var message = "";
            using (var context = new Entities1())
            {
                var user = new Ghar_Bato_Pramanit()
                {

                    Aabedan_miti = gbp.Aabedan_miti,
                    karyalaya = gbp.karyalaya,
                    Jagga_Dhaniko_Naam = gbp.Jagga_Dhaniko_Naam,
                    Pradesh = gbp.Pradesh,
                    Jilla = gbp.Jilla,
                    Gabisa = gbp.Gabisa,
                    Ward = gbp.Ward,
                    sabik_Gabisa = gbp.sabik_Gabisa,
                    Haal_Gabisa = gbp.Haal_Gabisa,
                    Naksa_sheetno = gbp.Naksa_sheetno,
                    Kitta_no = gbp.Kitta_no,
                    Bigga = gbp.Bigga,
                    Kattha = gbp.Kattha,
                    Dhur = gbp.Dhur,
                   
                    Gharko_prakaar = gbp.Gharko_prakaar,
                    Anumanit_Mulya = gbp.Anumanit_Mulya,
                    Batoko_Prakar= gbp.Batoko_Prakar,
                    Kaifiyat= gbp.Kaifiyat,
                    ImagePath = gbp.ImagePath
                };
                context.Ghar_Bato_Pramanit.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Ghar Jagga Naamsari
        //saving Ghar Jagga Naamsari
        public string SaveGharjagganaamsari(Ghar_Jagga_Naamsari gjn)
        {
            var message = "";
            using (var context = new Entities1())
            {
                var user = new Ghar_Jagga_Naamsari()
                {

                    Aabedan_miti = gjn.Aabedan_miti,
                    Nibedak_naam = gjn.Nibedak_naam,
                    Nibedak_nata= gjn.Nibedak_nata,
                    Jagga_Dhaniko_Naam= gjn.Jagga_Dhaniko_Naam,
                    Mirtyu_miti= gjn.Mirtyu_miti,
                    Hakdaarko_naam= gjn.Hakdaarko_naam,
                    Mritak_nata= gjn.Mritak_nata,
                    Buwa_patiko_naam= gjn.Buwa_patiko_naam,
                    Nagarikta_no= gjn.Nagarikta_no,
                    Ghar_no= gjn.Ghar_no,
                    Kitta= gjn.Kitta,
                    Bigga= gjn.Bigga,
                    Kattha= gjn.Kattha,
                    Dhur= gjn.Dhur,
                    Naksha_sheetno= gjn.Naksha_sheetno,
                    Kitta_no= gjn.Kitta_no,
                    Batoko_naam= gjn.Batoko_naam,
                    Batoko_prakar= gjn.Batoko_prakar,
                    Ward_no= gjn.Ward_no,
                    Kaifiyat=gjn.Kaifiyat
                };
                context.Ghar_Jagga_Naamsari.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Ghar Jagga Naamsari /आवेदकको विवरण
        public List<GharkayamList> GetGharjagganaamsariList(string loginId)
        {
            using (var context = new Entities1())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Ghar_Jagga_Naamsari/*.Where(x => x.FormId == lgId)*/.ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var gjn in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = gjn.FormId,
                        Aabedan_miti = gjn.Aabedan_miti,
                        Nibedaknaam = gjn.Nibedak_naam,
                        Nibedaknata = gjn.Nibedak_nata,
                        Jaggadhanikonaam = gjn.Jagga_Dhaniko_Naam,
                        Mirtyumiti = gjn.Mirtyu_miti,
                        Hakdaarkonaam = gjn.Hakdaarko_naam,
                        Mritaknata = gjn.Mritak_nata,
                        Buwapatikonaam = gjn.Buwa_patiko_naam,
                        Nagariktano = gjn.Nagarikta_no,
                        Ghar_no = gjn.Ghar_no,
                        Kitta = gjn.Kitta,
                        Bigga = gjn.Bigga,
                        Kattha = gjn.Kattha,
                        Dhur = gjn.Dhur,
                        Naksa_sheetno = gjn.Naksha_sheetno,
                        Kitta_no = gjn.Kitta_no,
                        Batokonaam = gjn.Batoko_naam,
                        Batoko_prakaar = gjn.Batoko_prakar,
                        Wardno = gjn.Ward_no,
                        Kaifiyat = gjn.Kaifiyat
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }

        //Kittakat Sifaris
        //saving Kittakat Sifaris

        public string SaveKittakatsifaris(Kittakat_Sifaris ks)
        {
            var message = "";
            using (var context = new Entities1())
            {
                var user = new Kittakat_Sifaris()
                {

                    Aabedan_miti = ks.Aabedan_miti,
                   Jagga_Dhaniko_Naam= ks.Jagga_Dhaniko_Naam,
                   Chetrafal= ks.Chetrafal,
                   Pradesh= ks.Pradesh,
                   Jilla= ks.Jilla,
                   Gabisa= ks.Gabisa,
                   Ward= ks.Ward,
                   Sabik_thegana= ks.Sabik_thegana,
                   Disa= ks.Disa,
                   Bigga=ks.Bigga,
                   Kattha= ks.Kattha,
                   Dhur=ks.Dhur,
                   Sheet_no= ks.Sheet_no,
                   Kitta_no=ks.Kitta_no,
                   Jamma_chetrafal= ks.Jamma_chetrafal,
                   Bhui_talako_chetrafal= ks.Bhui_talako_chetrafal,
                   Paune_faar= ks.Paune_faar,
                   Karan= ks.Karan,
                   Prabidhik_naam=ks.Prabidhik_naam


                };
                context.Kittakat_Sifaris.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Kittakat Sifaris /आवेदकको विवरण
        public List<GharkayamList> GetKittakatsifarisList(string loginId)
        {
            using (var context = new Entities1())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Kittakat_Sifaris/*.Where(x => x.FormId == lgId)*/.ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var ks in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = ks.FormId,
                        Aabedan_miti = ks.Aabedan_miti,
                        Jaggadhanikonaam = ks.Jagga_Dhaniko_Naam,
                        Chetrafal = ks.Chetrafal,
                        Pradesh = ks.Pradesh,
                        Jilla = ks.Jilla,
                        Gabisa = ks.Gabisa,
                        Ward = ks.Ward,
                        Sabikthegana = ks.Sabik_thegana,
                        Disa = ks.Disa,
                        Bigga = ks.Bigga,
                        Kattha = ks.Kattha,
                        Dhur = ks.Dhur,
                        Sheetno = ks.Sheet_no,
                        Kitta = ks.Kitta_no,
                        Jammachetrafal = ks.Jamma_chetrafal,
                        Bhuitalakochetrafal = ks.Bhui_talako_chetrafal,
                        Paunefaar = ks.Paune_faar,
                        Karan = ks.Karan,
                        Prabidhiknaam = ks.Prabidhik_naam
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }
    }
}