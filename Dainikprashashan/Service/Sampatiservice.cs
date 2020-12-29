using Dainikprashashan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dainikprashashan.Service
{
    public class Sampatiservice
    {
        //saving Barsik Aaya Pramanikaran
        public string SaveBarsikpramanikaran(Barsik_Pramanikaran bpn)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Barsik_Pramanikaran()
                {

                   Applicated_date=bpn.Applicated_date,
                   Full_name=bpn.Full_name,
                   Pradesh=bpn.Pradesh,
                   Jilla=bpn.Jilla,
                   Gabisa= bpn.Gabisa,
                   Ward= bpn.Ward,
                   Relation_with_applicant= bpn.Relation_with_applicant,
                   Parties_name= bpn.Parties_name,
                   Annual_income= bpn.Annual_income,
                   Remarks= bpn.Remarks


                };
                context.Barsik_Pramanikaran.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //View Barsik Aaya Pramanikaran
        public List<GharkayamList> GetBarsikpramanikaranList(string loginId)
        {
            using (var context = new Entities2())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Barsik_Pramanikaran.Where(x => x.FormId == lgId).ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var bpl in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = bpl.FormId,
                        Aabedan_miti= bpl.Applicated_date,
                        Aabedak_name= bpl.Full_name,
                        Pradesh= bpl.Pradesh,
                        Jilla= bpl.Jilla,
                        Gabisa= bpl.Gabisa,
                        Ward= bpl.Ward,
                        Relationwithapplicant=bpl.Relation_with_applicant,
                        Partiesname=bpl.Parties_name,
                        Annualincome=bpl.Annual_income,
                        Remarks=bpl.Remarks,
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }


        //saving Sampati Mulyankan
        public string SaveSampatimulyankan(Sampati_Muluyankan smn)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Sampati_Muluyankan()
                {

                    Applicated_date = smn.Applicated_date,
                    Full_name = smn.Full_name,
                    Pradesh = smn.Pradesh,
                    Jilla = smn.Jilla,
                    Gabisa = smn.Gabisa,
                    Ward = smn.Ward,
                   Owners= smn.Owners,
                   Particular_plotno= smn.Particular_plotno,
                   Bigga= smn.Bigga,
                   Kattha= smn.Kattha,
                   Dhur= smn.Dhur,
                   Total_value= smn.Total_value,
                    Remarks = smn.Remarks


                };
                context.Sampati_Muluyankan.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }


        //View Sampati Mulyankan
        public List<GharkayamList> GetSampatimulyankanList(string loginId)
        {
            using (var context = new Entities2())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Sampati_Muluyankan.Where(x => x.FormId == lgId).ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var sml in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = sml.FormId,
                        Aabedan_miti = sml.Applicated_date,
                        Aabedak_name = sml.Full_name,
                        Pradesh = sml.Pradesh,
                        Jilla = sml.Jilla,
                        Gabisa = sml.Gabisa,
                        Ward = sml.Ward,
                        Owner = sml.Owners,
                        Particularplotno = sml.Particular_plotno,
                        Bigga = sml.Bigga,
                        Kattha = sml.Kattha,
                        Dhur = sml.Dhur,
                        TotalValue = sml.Total_value,
                        Remarks = sml.Remarks,
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }

        //saving Kar Sabdhani Pramanpatra
        public string SaveKarsabdhani(Kar_Sambandhi ksi)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Kar_Sambandhi()
                {

                    Applicated_date = ksi.Applicated_date,
                    Full_name = ksi.Full_name,
                    Pradesh = ksi.Pradesh,
                    Jilla = ksi.Jilla,
                    Gabisa = ksi.Gabisa,
                    Ward = ksi.Ward,
                   Plot_no= ksi.Plot_no,
                   Tax_amount= ksi.Tax_amount,
                   Property_wardno= ksi.Property_wardno

                };
                context.Kar_Sambandhi.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }


        //View Kar Sabdhani
        public List<GharkayamList> GetKarsabdhaniList(string loginId)
        {
            using (var context = new Entities2())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfData = context.Kar_Sambandhi.Where(x => x.FormId == lgId).ToList();
                GharkayamList Lastlistobj = null;
                var dataInfoList = new List<GharkayamList>();

                foreach (var ksl in selfData)
                {
                    Lastlistobj = new GharkayamList
                    {
                        FormId = ksl.FormId,
                        Aabedan_miti = ksl.Applicated_date,
                        Aabedak_name = ksl.Full_name,
                        Pradesh = ksl.Pradesh,
                        Jilla = ksl.Jilla,
                        Gabisa = ksl.Gabisa,
                        Ward = ksl.Ward,
                        Rakam = ksl.Tax_amount,
                        Kitta_no=ksl.Plot_no,
                        Wardno=ksl.Property_wardno
                    };
                    dataInfoList.Add(Lastlistobj);
                }
                return dataInfoList;
            }
        }


    }
}