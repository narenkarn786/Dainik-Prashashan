using Dainikprashashan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dainikprashashan.Service
{
    public class Settingservice
    {
        //saving karyalaya
        public string SaveKaryalaya(Karyalaya k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Karyalaya()
                {
                    Karyalaya1 = k.Karyalaya1
                    
                };
                context.Karyalayas.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Karyalaya view
        public List<GharkayamList> KaryalayaList()
        {
            using (var context = new Entities2())
            {

                var data = context.Karyalayas.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId=bd.Karyalaya_Id,
                        karyalaya=bd.Karyalaya1

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Gharkoprakaar
        public string SaveGharkoprakaar(Gharko_prakaar gkp)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Gharko_prakaar()
                {
                    Gharkoprakaar = gkp.Gharkoprakaar

                };
                context.Gharko_prakaar.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Karyalaya view
        public List<GharkayamList> GharkoprakaarList()
        {
            using (var context = new Entities2())
            {

                var data = context.Gharko_prakaar.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Ghar_Id,
                        Gharko_prakaar = bd.Gharkoprakaar

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Arthikbarsa
        public string SaveArthikbarsa(Arthik_Barsa k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Arthik_Barsa()
                {
                    Barsa = k.Barsa

                };
                context.Arthik_Barsa.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Arthikbarsa view
        public List<GharkayamList> ArthikbarsaList()
        {
            using (var context = new Entities2())
            {

                var data = context.Arthik_Barsa.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Barsa_Id,
                        Barsa = bd.Barsa

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Faat
        public string SaveFaat(Faat k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Faat()
                {
                    Faat1 = k.Faat1

                };
                context.Faats.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Faat view
        public List<GharkayamList> FaatList()
        {
            using (var context = new Entities2())
            {

                var data = context.Faats.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Faat_Id,
                        Faat = bd.Faat1

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Kagajaat
        public string SaveKagajaat(Kagajaat k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Kagajaat()
                {
                    Kagajaat1 = k.Kagajaat1

                };
                context.Kagajaats.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Kagajaat view
        public List<GharkayamList> KagajaatList()
        {
            using (var context = new Entities2())
            {

                var data = context.Kagajaats.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Kagajaat_Id,
                        Kagajaat = bd.Kagajaat1

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Kaamko Prakaar
        public string SaveKaam(Kaam k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Kaam()
                {
                    Kaam1 = k.Kaam1

                };
                context.Kaams.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Kaamkoprakaar view
        public List<GharkayamList> KaamList()
        {
            using (var context = new Entities2())
            {

                var data = context.Kaams.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Kaam_Id,
                        Kaam = bd.Kaam1

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Sewa
        public string SaveSewa(Sewa k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Sewa()
                {
                    Sewa1 = k.Sewa1

                };
                context.Sewas.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Sewa view
        public List<GharkayamList> SewaList()
        {
            using (var context = new Entities2())
            {

                var data = context.Sewas.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Sewa_Id,
                        Sewa = bd.Sewa1

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Pradesh
        public string SavePradesh(Pradesh k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Pradesh()
                {
                    Pradesh1 = k.Pradesh1

                };
                context.Pradeshes.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Pradesh view
        public List<GharkayamList> PradeshList()
        {
            using (var context = new Entities2())
            {

                var data = context.Pradeshes.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Pradesh_Id,
                        Pradesh = bd.Pradesh1

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Jilla
        public string SaveJilla(Jilla k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Jilla()
                {
                    Jilla1 = k.Jilla1

                };
                context.Jillas.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Jilla view
        public List<GharkayamList> JillaList()
        {
            using (var context = new Entities2())
            {

                var data = context.Jillas.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Jilla_Id,
                        Jilla = bd.Jilla1

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Gabisa
        public string SaveGabisa(Gabisa k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Gabisa()
                {
                    Gabisa1 = k.Gabisa1

                };
                context.Gabisas.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Gabisa view
        public List<GharkayamList> GabisaList()
        {
            using (var context = new Entities2())
            {

                var data = context.Gabisas.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Gabisa_Id,
                        Gabisa = bd.Gabisa1

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Ward
        public string SaveWard(Ward k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Ward()
                {
                    Ward1 = k.Ward1

                };
                context.Wards.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Ward view
        public List<GharkayamList> WardList()
        {
            using (var context = new Entities2())
            {

                var data = context.Wards.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Ward_Id,
                        Ward = bd.Ward1

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Sabikhegana
        public string SaveSabikthegana(Sabik_Thegana k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Sabik_Thegana()
                {
                    Sabikthegana = k.Sabikthegana

                };
                context.Sabik_Thegana.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Sabikthegana view
        public List<GharkayamList> SabiktheganaList()
        {
            using (var context = new Entities2())
            {

                var data = context.Sabik_Thegana.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Sabik_Id,
                        Sabikthegana = bd.Sabikthegana

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Paad
        public string SavePaad(Padd k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Padd()
                {
                    Paad = k.Paad

                };
                context.Padds.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Paad view
        public List<GharkayamList> PaadList()
        {
            using (var context = new Entities2())
            {

                var data = context.Padds.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Paad_Id,
                        Paad = bd.Paad

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Faatkarmachari
        public string SaveFaatkarmachari(Faat_Karmachari k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Faat_Karmachari()
                {
                    Faatkarmachari = k.Faatkarmachari

                };
                context.Faat_Karmachari.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //FaatKarmachari view
        public List<GharkayamList> FaatkarmachariList()
        {
            using (var context = new Entities2())
            {

                var data = context.Faat_Karmachari.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.Faat_Id,
                        Faatkarmachari = bd.Faatkarmachari

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Biwahkoprakaar
        public string SaveBiwahkoprakaar(Biwahko_Prakaar k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Biwahko_Prakaar()
                {
                    Biwahkoprakaar = k.Biwahkoprakaar

                };
                context.Biwahko_Prakaar.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Biwahkoprakaar view
        public List<GharkayamList> BiwahkoprakaarList()
        {
            using (var context = new Entities2())
            {

                var data = context.Biwahko_Prakaar.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.BiwahId,
                        Biwahkoprakaar = bd.Biwahkoprakaar

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Nata
        public string SaveNata(Nata k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Nata()
                {
                    Nata1 = k.Nata1

                };
                context.Natas.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Nata view
        public List<GharkayamList> NataList()
        {
            using (var context = new Entities2())
            {

                var data = context.Natas.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.NataId,
                        Nata = bd.Nata1

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Batoko Prakaar
        public string SaveBatokoprakaar(Batoko_Prakaar k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Batoko_Prakaar()
                {
                    Batokoprakaar = k.Batokoprakaar

                };
                context.Batoko_Prakaar.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Batokoprakaar view
        public List<GharkayamList> BatokoprakaarList()
        {
            using (var context = new Entities2())
            {

                var data = context.Batoko_Prakaar.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.BatoId,
                        Batoko_prakaar = bd.Batokoprakaar

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }

        //saving Apangako Kisim
        public string SaveApangakokisim(Apangako_Kisim k)
        {
            var message = "";
            using (var context = new Entities2())
            {
                var user = new Apangako_Kisim()
                {
                    Apangakokisim = k.Apangakokisim

                };
                context.Apangako_Kisim.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Apangako kisim view
        public List<GharkayamList> ApangakokisimList()
        {
            using (var context = new Entities2())
            {

                var data = context.Apangako_Kisim.ToList();
                GharkayamList dataListObj = null;
                var dataListInfoList = new List<GharkayamList>();

                foreach (var bd in data)
                {
                    dataListObj = new GharkayamList
                    {
                        FormId = bd.ApangaId,
                        Apangakokisim = bd.Apangakokisim

                    };
                    dataListInfoList.Add(dataListObj);
                }
                return dataListInfoList;

            }
        }
    }
}