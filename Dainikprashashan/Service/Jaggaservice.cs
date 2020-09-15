using Dainikprashashan.Models;
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
            using (var context = new Entities1())
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

        //View Jaggadhani Pratilipi
        public List<GharkayamList> GetJaggadhanipratilipiList(string loginId)
        {
            using (var context = new Entities1())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Jaggadhani_Pratilipi.Where(x => x.Form_Id == lgId).ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var jp in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId=jp.Form_Id,
                        Aabedan_miti = jp.Aabedan_miti,
                        Aabedak_name = jp.Naam,
                        Nagariktano = jp.Nagarikta_no,
                        Nagariktamiti = jp.Nagarikta_miti,
                        Buwakonaam = jp.Buwako_naam,
                        Bajekonaam = jp.Bajeko_naam,
                        Aabedakpradesh = jp.Aabedak_pradesh,
                        Aabedakjilla = jp.Aabedak_jilla,
                        Aabedakgabisa = jp.Aabedak_gabisa,
                        Aabedakward = jp.Aabedak_ward,
                        Aabedaksabikthegana = jp.Aabedak_sabik_thegana,
                        Jaggadhanikonaam = jp.Jaggadhaniko_naam,
                        Kitta_no = jp.Kitta_no,
                        Bigga = jp.Bigga,
                        Kattha = jp.Kattha,
                        Dhur = jp.Dhur,
                        Jaggapradesh = jp.Jagga_pradesh,
                        Jaggajilla = jp.Jagga_jilla,
                        Jaggagabisa = jp.Jagga_gabisa,
                        Jaggaward = jp.Jagga_ward,
                        Jaggasabikthegana = jp.Jagga_sabik_thegana
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }

        //saving Bato Kayam
        public string SaveBatokayam(Bato_Kayam bkm)
        {
            var message = "";
            using (var context = new Entities1())
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

        //View Bato Kayam
        public List<GharkayamList> GetBatokayamList(string loginId)
        {
            using (var context = new Entities1())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Bato_Kayam.Where(x => x.FormId == lgId).ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var bkm in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = bkm.FormId,
                        Aabedan_miti = bkm.Aabedan_miti,
                        Jaggadhanikonaam = bkm.Jagga_Dhaniko_Naam,
                        Kitta_no = bkm.Kitta_no,
                        Bigga = bkm.Bigga,
                        Kattha = bkm.Kattha,
                        Dhur = bkm.Dhur,
                        Pradesh = bkm.Pradesh,
                        Jilla = bkm.Jilla,
                        Gabisa = bkm.Gabisa,
                        Ward = bkm.Ward,
                        Sabikthegana = bkm.sabik_thegana,
                        Batodisa = bkm.Bato_Disa,
                        Sadaklambai = bkm.Sadak_Lambai,
                        Sadakchaudai = bkm.Sadak_Chaudai
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }


        //saving Jagga Ghar Kayam
        public string SaveJaggagharkayam(Jagga_Ghar_Kayam jgk)
        {
            var message = "";
            using (var context = new Entities1())
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

        //View Jagga Ghar Kayam
        public List<GharkayamList> GetJaggagharkayamList(string loginId)
        {
            using (var context = new Entities1())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Jagga_Ghar_Kayam.Where(x => x.FormId == lgId).ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var jgk in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = jgk.FormId,
                        Aabedan_miti = jgk.Aabedan_miti,
                        Aabedak_name = jgk.Aabedak_naam,
                        Bigga = jgk.Bigga,
                        Kattha = jgk.Kattha,
                        Dhur = jgk.Dhur,
                        Pradesh = jgk.Pradesh,
                        Jilla = jgk.Jilla,
                        Gabisa = jgk.Gabisa,
                        Ward = jgk.Ward,
                        Sabikthegana = jgk.sabik_thegana,
                        Kitta_no = jgk.Kitta_no
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }

        //saving Charkilla sambandhama
        public string SaveCharkilla(Charkilla_Sambandhama cs)
        {
            var message = "";
            using (var context = new Entities1())
            {
                var user = new Charkilla_Sambandhama()
                {

                    Aabedan_miti = cs.Aabedan_miti,
                   Karyalaya= cs.Karyalaya,
                    Pradesh = cs.Pradesh,
                    Jaggadhaniko_naam=cs.Jaggadhaniko_naam,
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


        //View Charkilla sambandhama
        public List<GharkayamList> GetCharkillaList(string loginId)
        {
            using (var context = new Entities1())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Charkilla_Sambandhama.Where(x => x.Form_Id == lgId).ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var cs in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = cs.Form_Id,
                        Aabedan_miti = cs.Aabedan_miti,
                        karyalaya = cs.Karyalaya,
                        Jaggadhanikonaam=cs.Jaggadhaniko_naam,
                        Pradesh = cs.Pradesh,
                        Jilla = cs.Jilla,
                        Gabisa = cs.Gabisa,
                        Ward = cs.Ward,
                        Sabikgabisa = cs.Sabik_gabisa,
                        Haalgabisa = cs.Haal_gabisa,
                        Naksa_sheetno = cs.Naksha_sheetno,
                        Kitta_no = cs.Kitta_no,
                        Bigga = cs.Bigga,
                        Kattha = cs.Kattha,
                        Dhur = cs.Dhur,
                        Batoko_prakaar = cs.Batoko_Prakaar,
                        East = cs.East,
                        West = cs.West,
                        North = cs.North,
                        South = cs.South,
                        Kaifiyat = cs.Kaifiyat
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }

        //saving Mohi Lagat Katta
        public string SaveMohilagatkatta(Mohi_Lagat_Katta mlk)
        {
            var message = "";
            using (var context = new Entities1())
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

        //View Mohi Lagat Katta
        public List<GharkayamList> GetMohilagatkattaList(string loginId)
        {
            using (var context = new Entities1())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Mohi_Lagat_Katta.Where(x => x.Form_Id == lgId).ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var mlk in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = mlk.Form_Id,
                        Aabedan_miti = mlk.Aabedan_miti,
                        Jaggadhanikonaam = mlk.Jaggadhaniko_naam,
                        Mohikonaam = mlk.Mohiko_naam,
                        Kitta_no = mlk.Kitta_no,
                        Sheetno = mlk.Sheet_no,
                        Bigga = mlk.Bigga,
                        Kattha = mlk.Kattha,
                        Dhur = mlk.Dhur,
                        Pradesh = mlk.Pradesh,
                        Jilla = mlk.Jilla,
                        Gabisa = mlk.Gabisa,
                        Ward = mlk.Ward,
                        Sabikthegana = mlk.Sabik_thegana,
                        Sarjaminmiti = mlk.Sarjamin_miti
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }
    }
}