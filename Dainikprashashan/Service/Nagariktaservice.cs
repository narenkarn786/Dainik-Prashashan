using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dainikprashashan.Service
{
    public class Nagariktaservice
    {
        //saving Nagarikta Praman Patra
        public string SaveNagariktapramanpatra(Nagarikta_Pramanpatra np)
        {
            var message = "";
            using (var context = new Entities())
            {
                var user = new Nagarikta_Pramanpatra()
                {

                    Aabedan_miti = np.Aabedan_miti,
                   karyalaya=np.karyalaya,
                   Pahilo_naam=np.Pahilo_naam,
                   Bichko_naam=np.Bichko_naam,
                   Thar=np.Thar,
                   First_name=np.First_name,
                   Middle_name=np.Middle_name,
                   Last_name=np.Last_name,
                   Dob=np.Dob,
                    Janma_Pradesh = np.Janma_Pradesh,
                    Janma_Jilla = np.Janma_Jilla,
                    Janma_Gabisa = np.Janma_Gabisa,
                    Janma_Ward = np.Janma_Ward,
                    Janma_Tole = np.Janma_Tole,
                    Permanent_Pradesh = np.Permanent_Pradesh,
                    Permanent_Jilla = np.Permanent_Jilla,
                    Permanent_Gabisa = np.Permanent_Gabisa,
                    Permanent_Ward = np.Permanent_Ward,
                    Permanent_Tole = np.Permanent_Tole,
                   Buwako_naam=np.Buwako_naam,
                   Buwako_nagariktano=np.Buwako_nagariktano,
                    Buwako_Pradesh = np.Buwako_Pradesh,
                    Buwako_Jilla = np.Buwako_Jilla,
                    Buwako_Gabisa = np.Buwako_Gabisa,
                    Buwako_Ward = np.Buwako_Ward,
                    Buwako_Tole = np.Buwako_Tole,
                    Amako_naam = np.Amako_naam,
                    Amako_nagariktano = np.Amako_nagariktano,
                    Amako_Pradesh = np.Amako_Pradesh,
                    Amako_Jilla = np.Amako_Jilla,
                    Amako_Gabisa = np.Amako_Gabisa,
                    Amako_Ward = np.Amako_Ward,
                    Amako_Tole = np.Amako_Tole,
                    Patipatniko_naam = np.Patipatniko_naam,
                    Patipatniko_nagariktano = np.Patipatniko_nagariktano,
                    Patipatniko_Pradesh = np.Patipatniko_Pradesh,
                    Patipatniko_Jilla = np.Patipatniko_Jilla,
                    Patipatniko_Gabisa = np.Patipatniko_Gabisa,
                    Patipatniko_Ward = np.Patipatniko_Ward,
                    Patipatniko_Tole = np.Patipatniko_Tole,
                    Protector_naam = np.Protector_naam,
                    Protector_Pradesh = np.Protector_Pradesh,
                    Protector_Jilla = np.Protector_Jilla,
                    Protector_Gabisa = np.Protector_Gabisa,
                    Protector_Ward = np.Protector_Ward,
                    Protector_Tole = np.Protector_Tole

                };
                context.Nagarikta_Pramanpatra.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //saving Nagarikta Praman Patra
        public string SaveNagariktapramanpatrapratilipi(Nagarikta_Pramanpatra_Pratilipi np)
        {
            var message = "";
            using (var context = new Entities())
            {
                var user = new Nagarikta_Pramanpatra_Pratilipi()
                {

                    Aabedan_miti = np.Aabedan_miti,
                    karyalaya = np.karyalaya,
                    Pahilo_naam = np.Pahilo_naam,
                    Bichko_naam = np.Bichko_naam,
                    Thar = np.Thar,
                    First_name = np.First_name,
                    Middle_name = np.Middle_name,
                    Last_name = np.Last_name,
                    Dob = np.Dob,
                    Nagarikta_no=np.Nagarikta_no,
                    Jari_miti=np.Jari_miti,
                    Nagarikta_kisim=np.Nagarikta_kisim,
                    Janma_Pradesh = np.Janma_Pradesh,
                    Janma_Jilla = np.Janma_Jilla,
                    Janma_Gabisa = np.Janma_Gabisa,
                    Janma_Ward = np.Janma_Ward,
                    Janma_Tole = np.Janma_Tole,
                    Permanent_Pradesh = np.Permanent_Pradesh,
                    Permanent_Jilla = np.Permanent_Jilla,
                    Permanent_Gabisa = np.Permanent_Gabisa,
                    Permanent_Ward = np.Permanent_Ward,
                    Permanent_Tole = np.Permanent_Tole,
                    Buwako_naam = np.Buwako_naam,
                    Buwako_nagariktano = np.Buwako_nagariktano,
                    Buwako_Pradesh = np.Buwako_Pradesh,
                    Buwako_Jilla = np.Buwako_Jilla,
                    Buwako_Gabisa = np.Buwako_Gabisa,
                    Buwako_Ward = np.Buwako_Ward,
                    Buwako_Tole = np.Buwako_Tole,
                    Amako_naam = np.Amako_naam,
                    Amako_nagariktano = np.Amako_nagariktano,
                    Amako_Pradesh = np.Amako_Pradesh,
                    Amako_Jilla = np.Amako_Jilla,
                    Amako_Gabisa = np.Amako_Gabisa,
                    Amako_Ward = np.Amako_Ward,
                    Amako_Tole = np.Amako_Tole,
                    Patipatniko_naam = np.Patipatniko_naam,
                    Patipatniko_nagariktano = np.Patipatniko_nagariktano,
                    Patipatniko_Pradesh = np.Patipatniko_Pradesh,
                    Patipatniko_Jilla = np.Patipatniko_Jilla,
                    Patipatniko_Gabisa = np.Patipatniko_Gabisa,
                    Patipatniko_Ward = np.Patipatniko_Ward,
                    Patipatniko_Tole = np.Patipatniko_Tole,
                    Protector_naam = np.Protector_naam,
                    Protector_Pradesh = np.Protector_Pradesh,
                    Protector_Jilla = np.Protector_Jilla,
                    Protector_Gabisa = np.Protector_Gabisa,
                    Protector_Ward = np.Protector_Ward,
                    Protector_Tole = np.Protector_Tole

                };
                context.Nagarikta_Pramanpatra_Pratilipi.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }
    }
}