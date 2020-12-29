using Dainikprashashan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dainikprashashan.Service
{
    public class Sansthaservice
    {
        //संस्था दर्ता प्रमाणपत्र
        //Saving sanstha Darta Pramanpatra
        public string SaveSansthadartapramanpatra(Sanstha_Darta_Pramanpatra sdp)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Sanstha_Darta_Pramanpatra()
                {
                    Aabedan_miti = sdp.Aabedan_miti,
                    Sanstha_naam = sdp.Sanstha_naam,
                    Bisayagat_chetra = sdp.Bisayagat_chetra,
                    Darta_no = sdp.Darta_no,
                    Darta_miti = sdp.Darta_miti,
                    Sanstha_pradesh = sdp.Sanstha_pradesh,
                    Sanstha_jilla = sdp.Sanstha_jilla,
                    Sanstha_gabisa = sdp.Sanstha_gabisa,
                    Sanstha_ward = sdp.Sanstha_ward,
                    Sanchalak_pradesh = sdp.Sanchalak_pradesh,
                    Sanchalak_jilla = sdp.Sanchalak_jilla,
                    Sanchalak_gabisa = sdp.Sanchalak_gabisa,
                    Sanchalak_ward = sdp.Sanchalak_ward,
                    Sanstha_email = sdp.Sanstha_email,
                    Sanstha_phoneno = sdp.Sanstha_phoneno,
                    Swadesh_bidesh = sdp.Swadesh_bidesh,
                    Karobaar_miti = sdp.Karobaar_miti,
                    Sanchalak_naam = sdp.Sanchalak_naam,
                    Sanchalak_email = sdp.Sanchalak_email,
                    Sanchalak_phoneno = sdp.Sanchalak_phoneno,
                    ImagePath = sdp.ImagePath

                };
                context.Sanstha_Darta_Pramanpatra.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Sansthadartapramanpatra List

        public List<GharkayamList> GetSansthadartapramanpatraList(string loginId)
        {
            using (var context = new Entities2())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Sanstha_Darta_Pramanpatra/*.Where(x => x.FormId == lgId)*/.ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var sdp in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = sdp.FormId,
                        Aabedan_miti = sdp.Aabedan_miti,
                        Sanstha_naam = sdp.Sanstha_naam,
                        Bisayagat_chetra = sdp.Bisayagat_chetra,
                        Darta_no = sdp.Darta_no,
                        Darta_miti = sdp.Darta_miti,
                        Sanstha_pradesh = sdp.Sanstha_pradesh,
                        Sanstha_jilla = sdp.Sanstha_jilla,
                        Sanstha_gabisa = sdp.Sanstha_gabisa,
                        Sanstha_ward = sdp.Sanstha_ward,
                        Sanchalak_pradesh = sdp.Sanchalak_pradesh,
                        Sanchalak_jilla = sdp.Sanchalak_jilla,
                        Sanchalak_gabisa = sdp.Sanchalak_gabisa,
                        Sanchalak_ward = sdp.Sanchalak_ward,
                        Sanstha_email = sdp.Sanstha_email,
                        Sanstha_phoneno = sdp.Sanstha_phoneno,
                        Swadesh_bidesh = sdp.Swadesh_bidesh,
                        Karobaar_miti = sdp.Karobaar_miti,
                        Sanchalak_naam = sdp.Sanchalak_naam,
                        Sanchalak_email = sdp.Sanchalak_email,
                        Sanchalak_phoneno = sdp.Sanchalak_phoneno,
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }

        //व्यवसाय दर्ता प्रमाणपत्र
        //Saving व्यवसाय दर्ता प्रमाणपत्र
        public string SaveByawasayadarta(Byawasaya_Darta bd)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Byawasaya_Darta()
                {
                    Aabedan_miti = bd.Aabedan_miti,
                    Byawasaya_naam= bd.Byawasaya_naam,
                    Byawasayi_naam=bd.Byawasayi_naam,
                    Darta_no= bd.Darta_no,
                    Darta_miti= bd.Darta_miti,
                    Pan_no=bd.Pan_no,
                    Prakaar= bd.Prakaar,
                    Prakriti= bd.Prakriti,
                    Pradesh = bd.Pradesh,
                    Jilla = bd.Jilla,
                    Gabisa = bd.Gabisa,
                    Ward = bd.Ward,
                    Toleko_naam=bd.Toleko_naam,
                    Batoko_naam=bd.Batoko_naam,
                    Ghardhaniko_naam=bd.Ghardhaniko_naam,
                    Ghar_no=bd.Ghar_no,
                    Email=bd.Email,
                    Phoneno=bd.Phoneno,
                    Nikaya=bd.Nikaya,
                    Anya_dartano=bd.Anya_dartano,
                    Anya_dartamiti=bd.Anya_dartamiti,
                    ImagePath = bd.ImagePath

                };
                context.Byawasaya_Darta.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //व्यवसाय दर्ता प्रमाणपत्र List
        public List<GharkayamList> GetByawasayadartaList(string loginId)
        {
            using (var context = new Entities2())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Byawasaya_Darta/*.Where(x => x.FormId == lgId)*/.ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var bd in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = bd.FormId,
                        Aabedan_miti = bd.Aabedan_miti,
                        Byawasaya_naam = bd.Byawasaya_naam,
                        Byawasayi_naam = bd.Byawasayi_naam,
                        Darta_no = bd.Darta_no,
                        Darta_miti = bd.Darta_miti,
                        Pan_no = bd.Pan_no,
                        Prakaar = bd.Prakaar,
                        Prakriti = bd.Prakriti,
                        Pradesh = bd.Pradesh,
                        Jilla = bd.Jilla,
                        Gabisa = bd.Gabisa,
                        Ward = bd.Ward,
                        Tole = bd.Toleko_naam,
                        Batokonaam = bd.Batoko_naam,
                        Ghardhaniko_naam = bd.Ghardhaniko_naam,
                        Ghar_no = bd.Ghar_no,
                        Email = bd.Email,
                        Phoneno = bd.Phoneno,
                        Nikaya = bd.Nikaya,
                        Anya_dartano = bd.Anya_dartano,
                        Anya_dartamiti = bd.Anya_dartamiti,
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }

        //व्यवसाय बन्द बारे
        //Saving व्यवसाय बन्द बारे
        public string SaveByawasayabanda(Byawasaya_Banda_Barey bd)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Byawasaya_Banda_Barey()
                {
                    Aabedan_miti = bd.Aabedan_miti,
                    Byawasaya_naam = bd.Byawasaya_naam,
                    Byawasayi_naam = bd.Byawasayi_naam,
                    Darta_no = bd.Darta_no,                    
                    Prakaar = bd.Prakaar,
                    Prakriti = bd.Prakriti,
                    Pradesh = bd.Pradesh,
                    Jilla = bd.Jilla,
                    Gabisa = bd.Gabisa,
                    Ward = bd.Ward,
                    Sabik_thegana=bd.Sabik_thegana,
                    Haal_thegana=bd.Haal_thegana,
                    Toleko_naam = bd.Toleko_naam,
                    Batoko_naam = bd.Batoko_naam,
                    Gharno=bd.Gharno,
                    Byawasaya_Bandamiti=bd.Byawasaya_Bandamiti,
                    Sarjamin_miti=bd.Sarjamin_miti,                  
                    ImagePath = bd.ImagePath

                };
                context.Byawasaya_Banda_Barey.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //व्यवसाय बन्द बारे List
        public List<GharkayamList> GetByawasayabandaList(string loginId)
        {
            using (var context = new Entities2())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Byawasaya_Banda_Barey/*.Where(x => x.FormId == lgId)*/.ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var bd in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = bd.FormId,
                        Aabedan_miti = bd.Aabedan_miti,
                        Byawasaya_naam = bd.Byawasaya_naam,
                        Byawasayi_naam = bd.Byawasayi_naam,
                        Darta_no = bd.Darta_no,
                        Prakaar = bd.Prakaar,
                        Prakriti = bd.Prakriti,
                        Pradesh = bd.Pradesh,
                        Jilla = bd.Jilla,
                        Gabisa = bd.Gabisa,
                        Ward = bd.Ward,
                        Sabikthegana = bd.Sabik_thegana,
                        Haalthegana = bd.Haal_thegana,
                        Tole = bd.Toleko_naam,
                        Batokonaam = bd.Batoko_naam,
                        Ghar_no = bd.Gharno,
                        Byawasaya_Bandamiti = bd.Byawasaya_Bandamiti,
                        Sarjaminmiti = bd.Sarjamin_miti
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }

        //संस्था दर्ता Sifaris
        //Saving sanstha Darta Sifaris
        public string SaveSansthadartasifaris(Sanstha_Darta_Sifaris sd)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Sanstha_Darta_Sifaris()
                {
                    Aabedan_miti = sd.Aabedan_miti,
                    Naam = sd.Naam,
                    Pradesh = sd.Pradesh,
                    Jilla = sd.Jilla,
                    Gabisa = sd.Gabisa,
                    Ward = sd.Ward,
                    Sabik_thegana = sd.Sabik_thegana,
                    ImagePath = sd.ImagePath

                };
                context.Sanstha_Darta_Sifaris.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Sanstha Darta sifaris List

        public List<GharkayamList> GetSansthadartasifarisList(string loginId)
        {
            using (var context = new Entities2())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Sanstha_Darta_Sifaris/*.Where(x => x.FormId == lgId)*/.ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var sds in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = sds.FormId,
                        Aabedan_miti = sds.Aabedan_miti,
                        Naam = sds.Naam,
                        Pradesh = sds.Pradesh,
                        Jilla = sds.Jilla,
                        Gabisa = sds.Gabisa,
                        Ward = sds.Ward,
                        Sabikthegana = sds.Sabik_thegana
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }

        //संस्था Nawikaran
        //Saving sanstha Nawikaran
        public string SaveSansthanawikaran(Sanstha_Nawikaran s)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Sanstha_Nawikaran()
                {
                    Aabedan_miti = s.Aabedan_miti,
                    Naam = s.Naam,
                    Pradesh = s.Pradesh,
                    Jilla = s.Jilla,
                    Gabisa = s.Gabisa,
                    Ward = s.Ward,
                    Sabik_thegana = s.Sabik_thegana,
                    ImagePath = s.ImagePath

                };
                context.Sanstha_Nawikaran.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Sanstha Nawikaran List

        public List<GharkayamList> GetSansthanawikaranList(string loginId)
        {
            using (var context = new Entities2())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Sanstha_Nawikaran/*.Where(x => x.FormId == lgId)*/.ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var s in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = s.FormId,
                        Aabedan_miti = s.Aabedan_miti,
                        Naam = s.Naam,
                        Pradesh = s.Pradesh,
                        Jilla = s.Jilla,
                        Gabisa = s.Gabisa,
                        Ward = s.Ward,
                        Sabikthegana = s.Sabik_thegana
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }

    }
}