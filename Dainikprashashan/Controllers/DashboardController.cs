using Dainikprashashan.Service;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Dainikprashashan.Controllers
{
    public class DashboardController : Controller
    {
        public Entities2 e = new Entities2();
        
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        //Ghar Sambandhi
        [HttpGet]//Gharsambandhicard
        public ActionResult Gharsambandhicard()
        {
            return View();
        }

        [HttpGet]//Ghar kayamko sifaris
        public ActionResult Gharkayamkosifaris()
        {

            List<SelectListItem> Karyalaya = e.Karyalayas.Select(c => new SelectListItem
            {
                Value = c.Karyalaya_Id.ToString(),
                Text = c.Karyalaya1
            }).ToList();
            ViewBag.Karyalaya = Karyalaya;



            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;

            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Gharkoprakaar = e.Gharko_prakaar.Select(c => new SelectListItem
            {
                Value = c.Ghar_Id.ToString(),
                Text = c.Gharkoprakaar
            }).ToList();
            ViewBag.Gharkoprakaar = Gharkoprakaar;
            return View();

           
        }
        [HttpPost]//Gharkayamkosifaris
        public ActionResult Gharkayamkosifaris(Ghar_kayamko_sifaris gk)
        {
            //var loginId = Session["LoginId"].ToString();
            var lservice = new Gharsambandhit();
            var response = lservice.SaveGharkayamkosifaris(gk);
            return RedirectToAction("AabedanBiwaran");
        }

        [HttpGet]//Aabedanko Biwaran
        public ActionResult AabedanBiwaran()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var selfList = lbdService.GetSelfList(loginId);
            return View(selfList);

        }

        [HttpGet]//Final view
        public ActionResult Finalview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var selfList = lbdService.GetSelfList(loginId);
            return View(selfList);
        }

        [HttpGet]//Final Biwaran View
        public ActionResult Finalbiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var selfList = lbdService.GetSelfList(loginId);
            return View(selfList);
        }

        [HttpGet]//Edit Aabedanko Biwaran
        public ActionResult Editabedanniwaran()
        {

        
            List<SelectListItem> Karyalaya = e.Karyalayas.Select(c => new SelectListItem
            {
                Value = c.Karyalaya_Id.ToString(),
                Text = c.Karyalaya1
            }).ToList();
            ViewBag.Karyalaya = Karyalaya;



            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;

            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Gharkoprakaar = e.Gharko_prakaar.Select(c => new SelectListItem
            {
                Value = c.Ghar_Id.ToString(),
                Text = c.Gharkoprakaar
            }).ToList();
            ViewBag.Gharkoprakaar = Gharkoprakaar;
            return View();
            
        }

        [HttpPost]
        public ActionResult Editabedanniwaran(Ghar_kayamko_sifaris u)
        {

            var loginId = Session["LoginId"].ToString();
            var dservice = new Gharsambandhit();
            var response = dservice.UpdateData(u, loginId);
            return RedirectToAction("AabedanBiwaran");

        }

        [HttpGet]//Ghar Bato Pramanit
        public ActionResult Gharbatopramanit()
        {
            List<SelectListItem> Karyalaya = e.Karyalayas.Select(c => new SelectListItem
            {
                Value = c.Karyalaya_Id.ToString(),
                Text = c.Karyalaya1
            }).ToList();
            ViewBag.Karyalaya = Karyalaya;



            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;

            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Sabikthegana = e.Sabik_Thegana.Select(c => new SelectListItem
            {
                Value = c.Sabik_Id.ToString(),
                Text = c.Sabikthegana
            }).ToList();
            ViewBag.Sabikthegana = Sabikthegana;

            List<SelectListItem> Gharkoprakaar = e.Gharko_prakaar.Select(c => new SelectListItem
            {
                Value = c.Ghar_Id.ToString(),
                Text = c.Gharkoprakaar
            }).ToList();
            ViewBag.Gharkoprakaar = Gharkoprakaar;

            List<SelectListItem> Batokoprakaar = e.Batoko_Prakaar.Select(c => new SelectListItem
            {
                Value = c.BatoId.ToString(),
                Text = c.Batokoprakaar
            }).ToList();
            ViewBag.Batokoprakaar = Batokoprakaar;

            return View();
        }

        [HttpPost]//Ghar Bato Pramanit
        public ActionResult Gharbatopramanit(Ghar_Bato_Pramanit gp)
        {
            var lresponse = new Gharsambandhit();
            var lservice = lresponse.SaveGharbatopramanit(gp);
            return RedirectToAction("Gharbatopramanitview");
        }

        [HttpGet]//Gharbatopramanitview
        public ActionResult Gharbatopramanitview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var selfList = lbdService.GetGharbatopramanitList(loginId);
            return View(selfList);

        }

        [HttpGet]//Final Gharbatopramanitview
        public ActionResult FinalGharbatopramanitview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var selfList = lbdService.GetGharbatopramanitList(loginId);
            return View(selfList);
        }

        [HttpGet]//Final Biwaran Gharbatopramanitview
        public ActionResult FinalGharbatopramanitviewbiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var selfList = lbdService.GetGharbatopramanitList(loginId);
            return View(selfList);
        }

        //Ghar Jagga Naamsari
        [HttpGet]
        public ActionResult Gharjagganaamsari()
        {
            List<SelectListItem> Nata = e.Natas.Select(c => new SelectListItem
            {
                Value = c.NataId.ToString(),
                Text = c.Nata1
            }).ToList();
            ViewBag.Nata = Nata;

            List<SelectListItem> Batokoprakaar = e.Batoko_Prakaar.Select(c => new SelectListItem
            {
                Value = c.BatoId.ToString(),
                Text = c.Batokoprakaar
            }).ToList();
            ViewBag.Batokoprakaar = Batokoprakaar;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;
            return View();
        }

        [HttpPost]
        public ActionResult Gharjagganaamsari(Ghar_Jagga_Naamsari gn)
        {
            var lservice = new Gharsambandhit();
            var lresponse = lservice.SaveGharjagganaamsari(gn);
            return RedirectToAction("Gharjagganaamsariview");
        }

        [HttpGet]//Ghar Jagga Naamsari /आवेदकको विवरण
        public ActionResult Gharjagganaamsariview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var selfList = lbdService.GetGharjagganaamsariList(loginId);
            return View(selfList);
        }

        [HttpGet]//Final Gharjagganaamsariview
        public ActionResult FinalGharjagganaamsariview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var selfList = lbdService.GetGharjagganaamsariList(loginId);
            return View(selfList);
        }

        [HttpGet]//Final Biwaran Gharjagganaamsariview
        public ActionResult FinalGharjagganaamsaribiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var selfList = lbdService.GetGharjagganaamsariList(loginId);
            return View(selfList);
        }

        //Kittakat Sifaris
        [HttpGet]
        public ActionResult Kittakatsifaris()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;
          

            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Sabikthegana = e.Sabik_Thegana.Select(c => new SelectListItem
            {
                Value = c.Sabik_Id.ToString(),
                Text = c.Sabikthegana
            }).ToList();
            ViewBag.Sabikthegana = Sabikthegana;
            return View();
        }

        [HttpPost]
        public ActionResult Kittakatsifaris(Kittakat_Sifaris k)
        {
            var lservice = new Gharsambandhit();
            var lresponse = lservice.SaveKittakatsifaris(k);
            return RedirectToAction("Kittakatsifaris");
        }

        [HttpGet]//Kittakat Sifaris /आवेदकको विवरण
        public ActionResult Kittakatsifarisview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var selfList = lbdService.GetKittakatsifarisList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalKittakatsifarisview
        public ActionResult FinalKittakatsifarisview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var selfList = lbdService.GetKittakatsifarisList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalKittakatsifarisbiwaranview
        public ActionResult FinalKittakatsifarisbiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var selfList = lbdService.GetKittakatsifarisList(loginId);
            return View(selfList);
        }

        //संस्था/व्यवसाय सम्बन्धित
        [HttpGet]//Sansthadartacard
        public ActionResult Sansthadartacard()
        {
            return View();
        }

        [HttpGet]//संस्था दर्ता प्रमाणपत्र
        public ActionResult Sansthadartapramanpatra()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;
            return View();
        }

        [HttpPost]//संस्था दर्ता प्रमाणपत्र
        public ActionResult Sansthadartapramanpatra(Sanstha_Darta_Pramanpatra sd)
        {
            var lservice = new Sansthaservice();
            var lresponse = lservice.SaveSansthadartapramanpatra(sd);
            return RedirectToAction("Sansthadartapramanpatraview");
        }

        [HttpGet]//संस्था दर्ता प्रमाणपत्र/आवेदकको विवरण
        public ActionResult Sansthadartapramanpatraview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetSansthadartapramanpatraList(loginId);
            return View(selfList);
        }

        [HttpGet]//संस्था दर्ता प्रमाणपत्र/Final View
        public ActionResult FinalSansthadartapramanpatraview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetSansthadartapramanpatraList(loginId);
            return View(selfList);
        }

        [HttpGet]//संस्था दर्ता प्रमाणपत्र /Final Biwaran View
        public ActionResult FinalSansthadartapramanpatrabiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetSansthadartapramanpatraList(loginId);
            return View(selfList);
        }

        [HttpGet]//व्यवसाय दर्ता प्रमाणपत्र
        public ActionResult Byawasyadarta()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;
            return View();
        }

        [HttpPost]//व्यवसाय दर्ता प्रमाणपत्र
        public ActionResult Byawasyadarta(Byawasaya_Darta b)
        {
            var lservice = new Sansthaservice();
            var lresponse = lservice.SaveByawasayadarta(b);
            return RedirectToAction("Byawasayadartaview");
        }

        [HttpGet]//व्यवसाय दर्ता प्रमाणपत्र/आवेदकको विवरण
        public ActionResult Byawasayadartaview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetByawasayadartaList(loginId);
            return View(selfList);
        }

        [HttpGet]//व्यवसाय दर्ता प्रमाणपत्र/Final View
        public ActionResult FinalByawasayadartaview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetByawasayadartaList(loginId);
            return View(selfList);
        }

        [HttpGet]//व्यवसाय दर्ता प्रमाणपत्र/Final Biwaran View
        public ActionResult FinalByawasayadartabiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetByawasayadartaList(loginId);
            return View(selfList);
        }

        //व्यवसाय बन्द बारे
        public ActionResult Byawasayabanda()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Sabikthegana = e.Sabik_Thegana.Select(c => new SelectListItem
            {
                Value = c.Sabik_Id.ToString(),
                Text = c.Sabikthegana
            }).ToList();
            ViewBag.Sabikthegana = Sabikthegana;
            return View();
        }

        [HttpPost]//व्यवसाय बन्द बारे
        public ActionResult Byawasayabanda(Byawasaya_Banda_Barey sds)
        {
            var lservice = new Sansthaservice();
            var lresponse = lservice.SaveByawasayabanda(sds);
            return RedirectToAction("Byawasayabandaview");
        }

        [HttpGet]//व्यवसाय बन्द बारे/आवेदकको विवरण
        public ActionResult Byawasayabandaview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetByawasayabandaList(loginId);
            return View(selfList);
        }

        [HttpGet]//व्यवसाय बन्द बारे/Final View
        public ActionResult FinalByawasayabandaview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetByawasayabandaList(loginId);
            return View(selfList);
        }

        [HttpGet]//व्यवसाय बन्द बारे/Fial Biwaran View
        public ActionResult FinalByawasayabandadartaview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetByawasayabandaList(loginId);
            return View(selfList);
        }

        [HttpGet]// संस्था दर्ता सिफारिस
        public ActionResult Sansthadartasifaris()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Sabikthegana = e.Sabik_Thegana.Select(c => new SelectListItem
            {
                Value = c.Sabik_Id.ToString(),
                Text = c.Sabikthegana
            }).ToList();
            ViewBag.Sabikthegana = Sabikthegana;
            return View();
        }
        [HttpPost]//संस्था दर्ता सिफारिस
        public ActionResult Sansthadartasifaris(Sanstha_Darta_Sifaris sds)
        {
            var lservice = new Sansthaservice();
            var lresponse = lservice.SaveSansthadartasifaris(sds);
            return RedirectToAction("Sansthadartasifarisview");
        }

        [HttpGet]//संस्था दर्ता Sifaris/आवेदकको विवरण
        public ActionResult Sansthadartasifarisview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetSansthadartasifarisList(loginId);
            return View(selfList);
        }

        [HttpGet]//संस्था दर्ता Sifaris/Final view
        public ActionResult FinalSansthadartasifarisview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetSansthadartasifarisList(loginId);
            return View(selfList);
        }

        [HttpGet]//संस्था दर्ता Sifaris/Final Biwaran
        public ActionResult FinalSansthadartasifarisbiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetSansthadartasifarisList(loginId);
            return View(selfList);
        }

        [HttpGet]// संस्था Nawikaran
        public ActionResult Sansthanawikaran()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Sabikthegana = e.Sabik_Thegana.Select(c => new SelectListItem
            {
                Value = c.Sabik_Id.ToString(),
                Text = c.Sabikthegana
            }).ToList();
            ViewBag.Sabikthegana = Sabikthegana;
            return View();
        }
        [HttpPost]//संस्था Nawikaran
        public ActionResult Sansthanawikaran(Sanstha_Nawikaran sn)
        {
            var lservice = new Sansthaservice();
            var lresponse = lservice.SaveSansthanawikaran(sn);
            return RedirectToAction("Sansthanawikaranview");
        }

        [HttpGet]//संस्था Nawikaran/आवेदकको विवरण
        public ActionResult Sansthanawikaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetSansthanawikaranList(loginId);
            return View(selfList);
        }

        [HttpGet]//संस्था Nawikaran/Final View
        public ActionResult FinalSansthanawikaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetSansthanawikaranList(loginId);
            return View(selfList);
        }

        [HttpGet]//संस्था Nawikaran/Final Biwaran View
        public ActionResult FinalSansthanawikaranbiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sansthaservice();
            var selfList = lbdService.GetSansthanawikaranList(loginId);
            return View(selfList);
        }

        //Sampati sambandhi

        [HttpGet]//Sampati Sambandhi card
        public ActionResult Sampatisambandhicard()
        {
            return View();
        }

        [HttpGet]//वार्षिक आय प्रमाणिकरण

        public ActionResult Barsikpramanikaran()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Nata = e.Natas.Select(c => new SelectListItem
            {
                Value = c.NataId.ToString(),
                Text = c.Nata1
            }).ToList();
            ViewBag.Nata = Nata;
            return View();
        }

        [HttpPost]//वार्षिक आय प्रमाणिकरण
        public ActionResult Barsikpramanikaran(Barsik_Pramanikaran bp)
        {
            var lservice = new Sampatiservice();
            var lresponse = lservice.SaveBarsikpramanikaran(bp);
            return RedirectToAction("Barsikpramanikaranview");
        }

        [HttpGet]//वार्षिक आय प्रमाणिकरण /आवेदकको विवरण
        public ActionResult Barsikpramanikaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sampatiservice();
            var selfList = lbdService.GetBarsikpramanikaranList(loginId);
            return View(selfList);
        }

        [HttpGet]//Final Barsikpramanikaranview
        public ActionResult FinalBarsikpramanikaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sampatiservice();
            var selfList = lbdService.GetBarsikpramanikaranList(loginId);
            return View(selfList);
        }

        [HttpGet]//Final Barsikpramanikaranbiwaranview
        public ActionResult FinalBarsikpramanikaranbiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sampatiservice();
            var selfList = lbdService.GetBarsikpramanikaranList(loginId);
            return View(selfList);
        }

        [HttpGet]//सम्पत्ति मूल्यांकन
        public ActionResult Sampatimulyankan()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;
            return View();
        }

        [HttpPost]//सम्पत्ति मूल्यांकन
        public ActionResult Sampatimulyankan(Sampati_Muluyankan sm)
        {
            var lservice = new Sampatiservice();
            var lresponse = lservice.SaveSampatimulyankan(sm);
            return RedirectToAction("Sampatimulyankanview");
        }

        [HttpGet]//सम्पत्ति मूल्यांकन/आवेदकको विवरण
        public ActionResult Sampatimulyankanview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sampatiservice();
            var selfList = lbdService.GetSampatimulyankanList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalSampatimulyankanview
        public ActionResult FinalSampatimulyankanview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sampatiservice();
            var selfList = lbdService.GetSampatimulyankanList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalSampatimulyankanbiwaranview
        public ActionResult FinalSampatimulyankanbiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sampatiservice();
            var selfList = lbdService.GetSampatimulyankanList(loginId);
            return View(selfList);
        }


        [HttpGet] //कर सावधानी प्रमाणपत्र
        public ActionResult Karsabdhani()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            
            return View();
        }

        [HttpPost]//कर सावधानी प्रमाणपत्र
        public ActionResult Karsabdhani(Kar_Sambandhi ks)
        {
            var lservice = new Sampatiservice();
            var lresponse = lservice.SaveKarsabdhani(ks);
            return RedirectToAction("Karsabdhaniview");
        }

        [HttpGet]//कर सावधानी प्रमाणपत्र/आवेदकको विवरण
        public ActionResult Karsabdhaniview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sampatiservice();
            var selfList = lbdService.GetKarsabdhaniList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalKarsabdhaniview
        public ActionResult FinalKarsabdhaniview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sampatiservice();
            var selfList = lbdService.GetKarsabdhaniList(loginId);
            return View(selfList);
        }

        [HttpGet]//कर सावधानी प्रमाणपत्र/आवेदकको विवरण
        public ActionResult FinalKarsabdhanibiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Sampatiservice();
            var selfList = lbdService.GetKarsabdhaniList(loginId);
            return View(selfList);
        }

        //Jagga

        [HttpGet]//Jagga Sambandhi card
        public ActionResult Jaggasambandhicard()
        {
            return View();
        }

        [HttpGet]//जग्गाधनी लाल पुर्जा प्रतिलिपि
        public ActionResult Jaggadhanipratilipi()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Sabikthegana = e.Sabik_Thegana.Select(c => new SelectListItem
            {
                Value = c.Sabik_Id.ToString(),
                Text = c.Sabikthegana
            }).ToList();
            ViewBag.Sabikthegana = Sabikthegana;
            return View();
        }

        [HttpPost]//जग्गाधनी लाल पुर्जा प्रतिलिपि
        public ActionResult Jaggadhanipratilipi(Jaggadhani_Pratilipi j)
        {
            var lservice = new Jaggaservice();
            var lresponse = lservice.SaveJaggadhanipratilipi(j);
            return RedirectToAction("Jaggadhanipratilipiview");
        }

        [HttpGet]//जग्गाधनी लाल पुर्जा प्रतिलिपि/आवेदकको विवरण
        public ActionResult Jaggadhanipratilipiview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetJaggadhanipratilipiList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalJaggadhanipratilipiview
        public ActionResult FinalJaggadhanipratilipiview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetJaggadhanipratilipiList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalJaggadhanipratilipibiwaranview
        public ActionResult FinalJaggadhanipratilipibiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetJaggadhanipratilipiList(loginId);
            return View(selfList);
        }


        [HttpGet]//बाटो कायम
        public ActionResult Batokayam()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Sabikthegana = e.Sabik_Thegana.Select(c => new SelectListItem
            {
                Value = c.Sabik_Id.ToString(),
                Text = c.Sabikthegana
            }).ToList();
            ViewBag.Sabikthegana = Sabikthegana;
            return View();
        }

        [HttpPost]//बाटो कायम
        public ActionResult Batokayam(Bato_Kayam bk)
        {
            var lservice = new Jaggaservice();
            var lresponse = lservice.SaveBatokayam(bk);
            return RedirectToAction("Batokayamview");
        }

        [HttpGet]//बाटो कायम/आवेदकको विवरण
        public ActionResult Batokayamview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetBatokayamList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalBatokayamview
        public ActionResult FinalBatokayamview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetBatokayamList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalBatokayambiwaranview
        public ActionResult FinalBatokayambiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetBatokayamList(loginId);
            return View(selfList);
        }

        [HttpGet]//पुर्जामा घर कामय
        public ActionResult Jaggagharkayam()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Sabikthegana = e.Sabik_Thegana.Select(c => new SelectListItem
            {
                Value = c.Sabik_Id.ToString(),
                Text = c.Sabikthegana
            }).ToList();
            ViewBag.Sabikthegana = Sabikthegana;
            return View();
        }

        [HttpPost]//पुर्जामा घर कायम
        public ActionResult Jaggagharkayam(Jagga_Ghar_Kayam jg)
        {
            var lservice = new Jaggaservice();
            var lresponse = lservice.SaveJaggagharkayam(jg);
            return RedirectToAction("Jaggagharkayamview");
        }

        [HttpGet]//पुर्जामा घर कामय/आवेदकको विवरण
        public ActionResult Jaggagharkayamview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetJaggagharkayamList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalJaggagharkayamview
        public ActionResult FinalJaggagharkayamview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetJaggagharkayamList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalJaggagharkayambiwaranview
        public ActionResult FinalJaggagharkayambiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetJaggagharkayamList(loginId);
            return View(selfList);
        }

        [HttpGet]//चार किल्ला प्रमाणित
        public ActionResult Charkilla()
        {
            List<SelectListItem> Karyalaya = e.Karyalayas.Select(c => new SelectListItem
            {
                Value = c.Karyalaya_Id.ToString(),
                Text = c.Karyalaya1
            }).ToList();
            ViewBag.Karyalaya = Karyalaya;

            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Sabikthegana = e.Sabik_Thegana.Select(c => new SelectListItem
            {
                Value = c.Sabik_Id.ToString(),
                Text = c.Sabikthegana
            }).ToList();
            ViewBag.Sabikthegana = Sabikthegana;
            return View();
        }

        [HttpPost]//चार किल्ला प्रमाणित
        public ActionResult Charkilla(Charkilla_Sambandhama c)
        {
            var lservice = new Jaggaservice();
            var lresponse = lservice.SaveCharkilla(c);
            return RedirectToAction("Charkillaview");
        }

        [HttpGet]//चार किल्ला प्रमाणित/आवेदकको विवरण
        public ActionResult Charkillaview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetCharkillaList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalCharkillaview
        public ActionResult FinalCharkillaview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetCharkillaList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalCharkillabiwaranview
        public ActionResult FinalCharkillabiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetCharkillaList(loginId);
            return View(selfList);
        }

        [HttpGet]//मोही लागत कट्टा
        public ActionResult Mohilagatkatta()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Sabikthegana = e.Sabik_Thegana.Select(c => new SelectListItem
            {
                Value = c.Sabik_Id.ToString(),
                Text = c.Sabikthegana
            }).ToList();
            ViewBag.Sabikthegana = Sabikthegana;
            return View();
        }
        [HttpPost]//मोही लागत कट्टा
        public ActionResult Mohilagatkatta(Mohi_Lagat_Katta ml)
        {
            var lservice = new Jaggaservice();
            var lresponse = lservice.SaveMohilagatkatta(ml);
            return RedirectToAction("Mohilagatkattaview");
        }

        [HttpGet]//मोही लागत कट्टा/आवेदकको विवरण
        public ActionResult Mohilagatkattaview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetMohilagatkattaList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalMohilagatkattaview
        public ActionResult FinalMohilagatkattaview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetMohilagatkattaList(loginId);
            return View(selfList);
        }

        [HttpGet]//FinalMohilagatkattabiwaranview
        public ActionResult FinalMohilagatkattabiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Jaggaservice();
            var selfList = lbdService.GetMohilagatkattaList(loginId);
            return View(selfList);
        }


        //BASOBAAS

        [HttpGet]//Basobaas Sambandhi card
        public ActionResult Basobaassambandhicard()
        {
            return View();
        }

        [HttpGet]//Sthayi Basobaas
        public ActionResult Sthayibasobas()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Sabikthegana = e.Sabik_Thegana.Select(c => new SelectListItem
            {
                Value = c.Sabik_Id.ToString(),
                Text = c.Sabikthegana
            }).ToList();
            ViewBag.Sabikthegana = Sabikthegana;
            return View();
        }

        [HttpPost]//Sthayi Basobaas
        public ActionResult Sthayibasobas(Sthayi_Basobas b)
        {
            var lservice = new Basobasservice();
            var lresponse = lservice.SaveSthayibasobas(b);
            return RedirectToAction("Sthayibasobasview");
        }

        [HttpGet]//स्थायी बसोबास/आवेदकको विवरण
        public ActionResult Sthayibasobasview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Basobasservice();
            var selfList = lbdService.GetSthayibasobasList(loginId);
            return View(selfList);
        }

        [HttpGet]//स्थायी बसोबास/Final view
        public ActionResult FinalSthayibasobasview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Basobasservice();
            var selfList = lbdService.GetSthayibasobasList(loginId);
            return View(selfList);
        }

        [HttpGet]//स्थायी बसोबास/Biwaran View
        public ActionResult FinalSthayibasobasbiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Basobasservice();
            var selfList = lbdService.GetSthayibasobasList(loginId);
            return View(selfList);
        }

        [HttpGet]//Asthayi Basobaas
        public ActionResult Asthayibasobas()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Sabikthegana = e.Sabik_Thegana.Select(c => new SelectListItem
            {
                Value = c.Sabik_Id.ToString(),
                Text = c.Sabikthegana
            }).ToList();
            ViewBag.Sabikthegana = Sabikthegana;
            return View();
        }

        [HttpPost]//Asthayi Basobaas
        public ActionResult Asthayibasobas(Asthayi_Basobas a)
        {
            var lservice = new Basobasservice();
            var lresponse = lservice.SaveAsthayibasobas(a);
            return RedirectToAction("Asthayibasobasview");
        }

        [HttpGet]//अस्थाई बसोबास /आवेदकको विवरण
        public ActionResult Asthayibasobasview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Basobasservice();
            var selfList = lbdService.GetAsthayibasobasList(loginId);
            return View(selfList);
        }

        [HttpGet]//अस्थाई बसोबास /Final View
        public ActionResult FinalAsthayibasobasview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Basobasservice();
            var selfList = lbdService.GetAsthayibasobasList(loginId);
            return View(selfList);
        }

        [HttpGet]//अस्थाई बसोबास /Biwaran View
        public ActionResult FinalAsthayibasobasbiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Basobasservice();
            var selfList = lbdService.GetAsthayibasobasList(loginId);
            return View(selfList);
        }

        [HttpGet] //Antarik Basobas
        public ActionResult Antarikbasaisarai()
        {
            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;

            List<SelectListItem> Nata = e.Natas.Select(c => new SelectListItem
            {
                Value = c.NataId.ToString(),
                Text = c.Nata1
            }).ToList();
            ViewBag.Nata = Nata;
            return View();
        }

        [HttpPost]//Antarik Basobaas
        public ActionResult Antarikbasaisarai(Antarik_Basai_Sarai ab)
        {
            var lservice = new Basobasservice();
            var lresponse = lservice.SaveAntarikbasaisarai(ab);
            return RedirectToAction("Antarikbasaisaraiview");
        }

        [HttpGet]//आन्तरिक बसाई सराई /आवेदकको विवरण
        public ActionResult Antarikbasaisaraiview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Basobasservice();
            var selfList = lbdService.GetAsthayibasobasList(loginId);
            return View(selfList);
        }

        [HttpGet]//आन्तरिक बसाई सराई /आवेदकको विवरण
        public ActionResult FinalAntarikbasaisaraiview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Basobasservice();
            var selfList = lbdService.GetAsthayibasobasList(loginId);
            return View(selfList);
        }

        [HttpGet]//आन्तरिक बसाई सराई /आवेदकको विवरण
        public ActionResult FinalAntarikbasaisaraibiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Basobasservice();
            var selfList = lbdService.GetAsthayibasobasList(loginId);
            return View(selfList);
        }

        //NAGARIKTA

        [HttpGet]//Nagarikta Sambandhi card
        public ActionResult Nagariktasambandhicard()
        {
            return View();
        }

        [HttpGet]//Nagarikta_Praman_Patra
        public ActionResult Nagariktapramanpatra()
        {
            List<SelectListItem> Karyalaya = e.Karyalayas.Select(c => new SelectListItem
            {
                Value = c.Karyalaya_Id.ToString(),
                Text = c.Karyalaya1
            }).ToList();
            ViewBag.Karyalaya = Karyalaya;

            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;
            return View();
        }

        [HttpPost]//Nagarikta Praman Patra
        public ActionResult Nagariktapramanpatra(Nagarikta_Pramanpatra n)
        {
            var lservice = new Nagariktaservice();
            var lresponse = lservice.SaveNagariktapramanpatra(n);
            return RedirectToAction("Nagariktapramanpatraview");
        }

        [HttpGet]//नागरिकता प्रमाण पत्र/ आवेदकको विवरण
        public ActionResult Nagariktapramanpatraview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Nagariktaservice();
            var selfList = lbdService.GetNagariktapramanpatraList(loginId);
            return View(selfList);
        }
        [HttpGet]//नागरिकता प्रमाण पत्र/Final View
        public ActionResult FinalNagariktapramanpatraview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Nagariktaservice();
            var selfList = lbdService.GetNagariktapramanpatraList(loginId);
            return View(selfList);
        }

        [HttpGet]//नागरिकता प्रमाण पत्र/ Biwaran View
        public ActionResult FinalNagariktapramanpatrabiwaranview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Nagariktaservice();
            var selfList = lbdService.GetNagariktapramanpatraList(loginId);
            return View(selfList);
        }

        [HttpGet]//Nagarikta_Praman_Patra_Pratilipi
        public ActionResult Nagariktapramanpatrapratilipi()
        {
            List<SelectListItem> Karyalaya = e.Karyalayas.Select(c => new SelectListItem
            {
                Value = c.Karyalaya_Id.ToString(),
                Text = c.Karyalaya1
            }).ToList();
            ViewBag.Karyalaya = Karyalaya;

            List<SelectListItem> Pradesh = e.Pradeshes.Select(c => new SelectListItem
            {
                Value = c.Pradesh_Id.ToString(),
                Text = c.Pradesh1
            }).ToList();
            ViewBag.Pradesh = Pradesh;


            List<SelectListItem> Jilla = e.Jillas.Select(c => new SelectListItem
            {
                Value = c.Jilla_Id.ToString(),
                Text = c.Jilla1
            }).ToList();
            ViewBag.Jilla = Jilla;

            List<SelectListItem> Gabisa = e.Gabisas.Select(c => new SelectListItem
            {
                Value = c.Gabisa_Id.ToString(),
                Text = c.Gabisa1
            }).ToList();
            ViewBag.Gabisa = Gabisa;

            List<SelectListItem> Ward = e.Wards.Select(c => new SelectListItem
            {
                Value = c.Ward_Id.ToString(),
                Text = c.Ward1
            }).ToList();
            ViewBag.Ward = Ward;
            return View();
        }

        [HttpPost]//Nagarikta Praman Patra Pratilipi
        public ActionResult Nagariktapramanpatrapratilipi(Nagarikta_Pramanpatra_Pratilipi n)
        {
            var lservice = new Nagariktaservice();
            var lresponse = lservice.SaveNagariktapramanpatrapratilipi(n);
            return RedirectToAction("Nagariktapramanpatrapratilipiview");
        }

        [HttpGet]//नागरिकता प्रमाण पत्र/ आवेदकको विवरण
        public ActionResult Nagariktapramanpatrapratilipiview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Nagariktaservice();
            var selfList = lbdService.GetNagariktapramanpatrapratilipiList(loginId);
            return View(selfList);
        }

        [HttpGet]//Arthik Barsa
        public ActionResult Arthikbarsa()
        {
            return View();
        }

        [HttpPost]//Arthikbarsa
        public ActionResult Arthikbarsa(Arthik_Barsa ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveArthikbarsa(ka);
            return RedirectToAction("Arthikbarsaview");
        }

        //Arthikbarsa View
        public ActionResult Arthikbarsaview()
        {
            var lService = new Settingservice();
            var dataList = lService.ArthikbarsaList();
            return View(dataList);
        }

        [HttpGet]//Faat
        public ActionResult Faat()
        {
            return View();
        }

        [HttpPost]//Faat
        public ActionResult Faat(Faat ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveFaat(ka);
            return RedirectToAction("Faatview");
        }

        //Faat View
        public ActionResult Faatview()
        {
            var lService = new Settingservice();
            var dataList = lService.FaatList();
            return View(dataList);
        }

        [HttpGet]//Karyalaya
        public ActionResult Karyalaya()
        {
            return View();
        }

        [HttpPost]//Karyalaya
        public ActionResult Karyalaya(Karyalaya ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveKaryalaya(ka);
            return RedirectToAction("Karyalayaview");
        }

        //Karyalaya View
        public ActionResult Karyalayaview()
        {
            var lService = new Settingservice();
            var dataList = lService.KaryalayaList();
            return View(dataList);
        }

        [HttpGet]//Ghar ko Prakaar
        public ActionResult Gharkoprakaar()
        {
            return View();
        }

        [HttpPost]//Karyalaya
        public ActionResult Gharkoprakaar(Gharko_prakaar gp)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveGharkoprakaar(gp);
            return RedirectToAction("Gharkoprakaarview");
        }

        //Karyalaya View
        public ActionResult Gharkoprakaarview()
        {
            var lService = new Settingservice();
            var dataList = lService.GharkoprakaarList();
            return View(dataList);
        }



        [HttpGet]//Kagajaat
        public ActionResult Kagajaat()
        {
            return View();
        }

        [HttpPost]//Kagajaat
        public ActionResult Kagajaat(Kagajaat ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveKagajaat(ka);
            return RedirectToAction("Kagajaatview");
        }

        //Kagajaat View
        public ActionResult Kagajaatview()
        {
            var lService = new Settingservice();
            var dataList = lService.KagajaatList();
            return View(dataList);
        }

        [HttpGet]//Kaamko Prakaar
        public ActionResult Kaam()
        {
            return View();
        }

        [HttpPost]//Kaamko Prakaar
        public ActionResult Kaam(Kaam ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveKaam(ka);
            return RedirectToAction("Kaamkoprakaarview");
        }

        //Kaamko Prakaar View
        public ActionResult Kaamkoprakaarview()
        {
            var lService = new Settingservice();
            var dataList = lService.KaamList();
            return View(dataList);
        }


        [HttpGet]//Sewako Prakaar
        public ActionResult Sewa()
        {
            return View();
        }

        [HttpPost]//Sewako Prakaar
        public ActionResult Sewa(Sewa ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveSewa(ka);
            return RedirectToAction("Sewaview");
        }

        //Sewako Prakaar View
        public ActionResult Sewaview()
        {
            var lService = new Settingservice();
            var dataList = lService.SewaList();
            return View(dataList);
        }

        [HttpGet]//Pradesh
        public ActionResult Pradesh()
        {
            return View();
        }

        [HttpPost]//Pradesh
        public ActionResult Pradesh(Pradesh ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SavePradesh(ka);
            return RedirectToAction("Pradeshview");
        }

        //Pradesh View
        public ActionResult Pradeshview()
        {
            var lService = new Settingservice();
            var dataList = lService.PradeshList();
            return View(dataList);
        }


        [HttpGet]//Jilla
        public ActionResult Jilla()
        {
            return View();
        }

        [HttpPost]//Jilla
        public ActionResult Jilla(Jilla ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveJilla(ka);
            return RedirectToAction("Jillaview");
        }

        //Jilla View
        public ActionResult Jillaview()
        {
            var lService = new Settingservice();
            var dataList = lService.JillaList();
            return View(dataList);
        }

        [HttpGet]//Gabisa
        public ActionResult Gabisa()
        {
            return View();
        }

        [HttpPost]//Gabisa
        public ActionResult Gabisa(Gabisa ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveGabisa(ka);
            return RedirectToAction("Gabisaview");
        }

        //Gabisa View
        public ActionResult Gabisaview()
        {
            var lService = new Settingservice();
            var dataList = lService.GabisaList();
            return View(dataList);
        }

        [HttpGet]//Ward
        public ActionResult Ward()
        {
            return View();
        }

        [HttpPost]//Ward
        public ActionResult Ward(Ward ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveWard(ka);
            return RedirectToAction("Wardview");
        }

        //Ward View
        public ActionResult Wardview()
        {
            var lService = new Settingservice();
            var dataList = lService.WardList();
            return View(dataList);
        }

        [HttpGet]//Sabik Thegana
        public ActionResult Sabikthegana()
        {
            return View();
        }

        [HttpPost]//Sabikthegana
        public ActionResult Sabikthegana(Sabik_Thegana ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveSabikthegana(ka);
            return RedirectToAction("Sabiktheganaview");
        }

        //Sabikthegana View
        public ActionResult Sabiktheganaview()
        {
            var lService = new Settingservice();
            var dataList = lService.SabiktheganaList();
            return View(dataList);
        }

        [HttpGet]//Paad
        public ActionResult Paad()
        {
            return View();
        }

        [HttpPost]//Paad
        public ActionResult Paad(Padd ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SavePaad(ka);
            return RedirectToAction("Paadview");
        }

        //Paad View
        public ActionResult Paadview()
        {
            var lService = new Settingservice();
            var dataList = lService.PaadList();
            return View(dataList);
        }

        [HttpGet]//Faat Karmachari
        public ActionResult Faatkarmachari()
        {
            return View();
        }

        [HttpPost]//Faatkarmachari
        public ActionResult Faatkarmachari(Faat_Karmachari ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveFaatkarmachari(ka);
            return RedirectToAction("Faatkarmachariview");
        }

        //Faatkarmachari View
        public ActionResult Faatkarmachariview()
        {
            var lService = new Settingservice();
            var dataList = lService.FaatkarmachariList();
            return View(dataList);
        }

        

        [HttpGet]//Biwahko Prakaar
        public ActionResult Biwahkoprakaar()
        {
            return View();
        }



        [HttpPost]//Biwahko Prakaar
        public ActionResult Biwahkoprakaar(Biwahko_Prakaar ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveBiwahkoprakaar(ka);
            return RedirectToAction("Biwahkoprakaarview");
        }

        //Biwahkoprakaar View
        public ActionResult Biwahkoprakaarview()
        {
            var lService = new Settingservice();
            var dataList = lService.BiwahkoprakaarList();
            return View(dataList);
        }

        [HttpGet]//Nata
        public ActionResult Nata()
        {
            return View();
        }

        [HttpPost]//Nata
        public ActionResult Nata(Nata ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveNata(ka);
            return RedirectToAction("Nataview");
        }

        //Nata View
        public ActionResult Nataview()
        {
            var lService = new Settingservice();
            var dataList = lService.NataList();
            return View(dataList);
        }

        [HttpGet]//Batoko Prakaar
        public ActionResult Batokoprakaar()
        {
            return View();
        }

        [HttpPost]//Batokoprakaar
        public ActionResult Batokoprakaar(Batoko_Prakaar ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveBatokoprakaar(ka);
            return RedirectToAction("Batokoprakaarview");
        }

        //Batokoprakaar View
        public ActionResult Batokoprakaarview()
        {
            var lService = new Settingservice();
            var dataList = lService.BatokoprakaarList();
            return View(dataList);
        }

        [HttpGet]//Apangako Kisim
        public ActionResult Apangakokisim()
        {
            return View();
        }

        [HttpPost]//Apangakokisim
        public ActionResult Apangakokisim(Apangako_Kisim ka)
        {
            var lservice = new Settingservice();
            var lresponse = lservice.SaveApangakokisim(ka);
            return RedirectToAction("Apangakokisimview");
        }

        //Apangakokisim View
        public ActionResult Apangakokisimview()
        {
            var lService = new Settingservice();
            var dataList = lService.ApangakokisimList();
            return View(dataList);
        }

    }

}