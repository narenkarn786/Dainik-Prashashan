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
            using (var context = new Entities1())
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

        //saving Arthikbarsa
        public string SaveArthikbarsa(Arthik_Barsa k)
        {
            var message = "";
            using (var context = new Entities1())
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

        //saving Faat
        public string SaveFaat(Faat k)
        {
            var message = "";
            using (var context = new Entities1())
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

        //saving Kagajaat
        public string SaveKagajaat(Kagajaat k)
        {
            var message = "";
            using (var context = new Entities1())
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

        //saving Kaamko Prakaar
        public string SaveKaam(Kaam k)
        {
            var message = "";
            using (var context = new Entities1())
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

        //saving Sewa
        public string SaveSewa(Sewa k)
        {
            var message = "";
            using (var context = new Entities1())
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

        //saving karyalaya
        public string SavePradesh(Pradesh k)
        {
            var message = "";
            using (var context = new Entities1())
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

        //saving Jilla
        public string SaveJilla(Jilla k)
        {
            var message = "";
            using (var context = new Entities1())
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

        //saving Gabisa
        public string SaveGabisa(Gabisa k)
        {
            var message = "";
            using (var context = new Entities1())
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

        //saving Ward
        public string SaveWard(Ward k)
        {
            var message = "";
            using (var context = new Entities1())
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

        //saving Sabikhegana
        public string SaveSabikthegana(Sabik_Thegana k)
        {
            var message = "";
            using (var context = new Entities1())
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

        //saving Paad
        public string SavePaad(Padd k)
        {
            var message = "";
            using (var context = new Entities1())
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

        //saving Faatkarmachari
        public string SaveFaatkarmachari(Faat_Karmachari k)
        {
            var message = "";
            using (var context = new Entities1())
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
    }
}