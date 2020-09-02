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
            using (var context = new Entities())
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

        //saving Sampati Mulyankan
        public string SaveSampatimulyankan(Sampati_Muluyankan smn)
        {
            var message = "";
            using (var context = new Entities())
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

        //saving Kar Sabdhani Pramanpatra
        public string SaveKarsabdhani(Kar_Sambandhi ksi)
        {
            var message = "";
            using (var context = new Entities())
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


    }
}