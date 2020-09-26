using Dainikprashashan.Service;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Dainikprashashan.Controllers
{
    public class DashboardController : Controller
    {
        private Entities1 e = new Entities1();
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

            //var KARYALAYALIST = new List<string>();
            //KARYALAYALIST.Add("वडा कार्यालय  ");
            //KARYALAYALIST.Add("मालपोत  कार्यालय  ");
            //KARYALAYALIST.Add("जिल्ला प्रशासन  कार्यालय  ");
            //ViewBag.karyalaya = KARYALAYALIST;



            //ViewBag.Karyalaya = new SelectList(e.Karyalayas,"");
            IEnumerable<SelectListItem> Karyalaya = e.Karyalayas.Select(c => new SelectListItem
            {
                Value = c.Karyalaya_Id.ToString(),
                Text = c.Karyalaya1
            });
            ViewBag.Karyalaya = Karyalaya;

            var PRADESHLIST = new List<string>();
            PRADESHLIST.Add("प्रदेश नम्बर १   ");
            PRADESHLIST.Add("प्रदेश नम्बर २   ");
            PRADESHLIST.Add("प्रदेश नम्बर ३   ");
            PRADESHLIST.Add("प्रदेश नम्बर ४  ");
            PRADESHLIST.Add("प्रदेश नम्बर ५  ");
            PRADESHLIST.Add("प्रदेश नम्बर ६ ");
            PRADESHLIST.Add("प्रदेश नम्बर ७   ");
            ViewBag.Pradesh = PRADESHLIST;

            var DISTRICTLIST = new List<string>();
            DISTRICTLIST.Add("भोजपुर");
            DISTRICTLIST.Add("धनकुटा");
            DISTRICTLIST.Add("इलाम");
            DISTRICTLIST.Add("झापा ");
            DISTRICTLIST.Add("खोटाँग ");
            DISTRICTLIST.Add("मोरंग ");
            DISTRICTLIST.Add("ओखलढुंगा ");
            DISTRICTLIST.Add("पांचथर ");
            DISTRICTLIST.Add("संखुवासभा ");
            DISTRICTLIST.Add("सोलुखुम्बू ");
            DISTRICTLIST.Add("सुनसरी ");
            DISTRICTLIST.Add("ताप्लेजुंग ");
            DISTRICTLIST.Add("तेह्रथुम ");
            DISTRICTLIST.Add("उदयपुर ");
            DISTRICTLIST.Add("पर्सा ");
            DISTRICTLIST.Add("बारा ");
            DISTRICTLIST.Add("रौतहट ");
            DISTRICTLIST.Add("सर्लाही ");
            DISTRICTLIST.Add("धनुषा ");
            DISTRICTLIST.Add("सिराहा ");
            DISTRICTLIST.Add("महोत्तरी ");
            DISTRICTLIST.Add("सप्तरी ");
            DISTRICTLIST.Add("सिन्धुली ");
            DISTRICTLIST.Add("रामेछाप  ");
            DISTRICTLIST.Add("दोलखा ");
            DISTRICTLIST.Add("	भक्तपुर");
            DISTRICTLIST.Add("धादिङ ");
            DISTRICTLIST.Add("काठमाडौँ ");
            DISTRICTLIST.Add("काभ्रेपलान्चोक");
            DISTRICTLIST.Add("ललितपुर ");
            DISTRICTLIST.Add("नुवाकोट");
            DISTRICTLIST.Add("	रसुवा");
            DISTRICTLIST.Add("सिन्धुपाल्चोक ");
            DISTRICTLIST.Add("चितवन ");
            DISTRICTLIST.Add("मकवानपुर ");
            DISTRICTLIST.Add("बागलुङ ");
            DISTRICTLIST.Add("गोरखा ");
            DISTRICTLIST.Add("कास्की");
            DISTRICTLIST.Add("लमजुङ ");
            DISTRICTLIST.Add("मनाङ ");
            DISTRICTLIST.Add("मुस्ताङ ");
            DISTRICTLIST.Add("म्याग्दी ");
            DISTRICTLIST.Add("नवलपुर ");
            DISTRICTLIST.Add("पर्वत ");
            DISTRICTLIST.Add("स्याङग्जा ");
            DISTRICTLIST.Add("तनहुँ ");
            DISTRICTLIST.Add("कपिलवस्तु ");
            DISTRICTLIST.Add("परासी ");
            DISTRICTLIST.Add("रुपन्देही ");
            DISTRICTLIST.Add("अर्घाखाँची ");
            DISTRICTLIST.Add("गुल्मी ");
            DISTRICTLIST.Add("पाल्पा");
            DISTRICTLIST.Add("दाङ देउखुरी");
            DISTRICTLIST.Add("प्युठान ");
            DISTRICTLIST.Add("रोल्पा ");
            DISTRICTLIST.Add("पूर्वी रूकुम");
            DISTRICTLIST.Add("बाँके");
            DISTRICTLIST.Add("बर्दिया");
            ViewBag.District = DISTRICTLIST;

            var WARDLIST = new List<string>();
            WARDLIST.Add("१ नम्बर वडा कार्यालय ");
            WARDLIST.Add("२ नम्बर वडा कार्यालय ");
            WARDLIST.Add("३ नम्बर वडा कार्यालय ");
            WARDLIST.Add("४ नम्बर वडा कार्यालय ");
            WARDLIST.Add("५ नम्बर वडा कार्यालय ");
            WARDLIST.Add("६ नम्बर वडा कार्यालय ");
            WARDLIST.Add("७ नम्बर वडा कार्यालय ");
            WARDLIST.Add("८ नम्बर वडा कार्यालय ");
            WARDLIST.Add("९ नम्बर वडा कार्यालय ");
            WARDLIST.Add("१० नम्बर वडा कार्यालय ");
            WARDLIST.Add("११ नम्बर वडा कार्यालय ");
            WARDLIST.Add("१२ नम्बर वडा कार्यालय ");
            ViewBag.Ward = WARDLIST;

            var GHARPRAKARLIST = new List<string>();
            GHARPRAKARLIST.Add("अन्य फुसको कच्ची घर ");
            GHARPRAKARLIST.Add("काठको फुसको कच्ची घर ");
            GHARPRAKARLIST.Add("काठको  भुईतल्ले कच्ची घर  टीन वा टायल्को छाना");
            GHARPRAKARLIST.Add("काठको ताड घर ,टीन वा टायल्को छाना");
            GHARPRAKARLIST.Add("पक्की इटाको जोडाईमा टीनको छाना");
            GHARPRAKARLIST.Add("पक्की छत्को ढलान");
            GHARPRAKARLIST.Add("माटोको कच्ची घर ");
            ViewBag.Gharprakar = GHARPRAKARLIST;
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

            var KARYALAYALIST = new List<string>();
            //KARYALAYALIST.Add("वडा कार्यालय  ");
            //KARYALAYALIST.Add("मालपोत  कार्यालय  ");
            //KARYALAYALIST.Add("जिल्ला प्रशासन  कार्यालय  ");
            Entities1 e = new Entities1();

            ViewBag.karyalaya = new SelectList(e.Karyalayas, "Karyalaya1");


            var PRADESHLIST = new List<string>();
            PRADESHLIST.Add("प्रदेश नम्बर १   ");
            PRADESHLIST.Add("प्रदेश नम्बर २   ");
            PRADESHLIST.Add("प्रदेश नम्बर ३   ");
            PRADESHLIST.Add("प्रदेश नम्बर ४  ");
            PRADESHLIST.Add("प्रदेश नम्बर ५  ");
            PRADESHLIST.Add("प्रदेश नम्बर ६ ");
            PRADESHLIST.Add("प्रदेश नम्बर ७   ");
            ViewBag.Pradesh = PRADESHLIST;

            var DISTRICTLIST = new List<string>();
            DISTRICTLIST.Add("भोजपुर");
            DISTRICTLIST.Add("धनकुटा");
            DISTRICTLIST.Add("इलाम");
            DISTRICTLIST.Add("झापा ");
            DISTRICTLIST.Add("खोटाँग ");
            DISTRICTLIST.Add("मोरंग ");
            DISTRICTLIST.Add("ओखलढुंगा ");
            DISTRICTLIST.Add("पांचथर ");
            DISTRICTLIST.Add("संखुवासभा ");
            DISTRICTLIST.Add("सोलुखुम्बू ");
            DISTRICTLIST.Add("सुनसरी ");
            DISTRICTLIST.Add("ताप्लेजुंग ");
            DISTRICTLIST.Add("तेह्रथुम ");
            DISTRICTLIST.Add("उदयपुर ");
            DISTRICTLIST.Add("पर्सा ");
            DISTRICTLIST.Add("बारा ");
            DISTRICTLIST.Add("रौतहट ");
            DISTRICTLIST.Add("सर्लाही ");
            DISTRICTLIST.Add("धनुषा ");
            DISTRICTLIST.Add("सिराहा ");
            DISTRICTLIST.Add("महोत्तरी ");
            DISTRICTLIST.Add("सप्तरी ");
            DISTRICTLIST.Add("सिन्धुली ");
            DISTRICTLIST.Add("रामेछाप  ");
            DISTRICTLIST.Add("दोलखा ");
            DISTRICTLIST.Add("	भक्तपुर");
            DISTRICTLIST.Add("धादिङ ");
            DISTRICTLIST.Add("काठमाडौँ ");
            DISTRICTLIST.Add("काभ्रेपलान्चोक");
            DISTRICTLIST.Add("ललितपुर ");
            DISTRICTLIST.Add("नुवाकोट");
            DISTRICTLIST.Add("	रसुवा");
            DISTRICTLIST.Add("सिन्धुपाल्चोक ");
            DISTRICTLIST.Add("चितवन ");
            DISTRICTLIST.Add("मकवानपुर ");
            DISTRICTLIST.Add("बागलुङ ");
            DISTRICTLIST.Add("गोरखा ");
            DISTRICTLIST.Add("कास्की");
            DISTRICTLIST.Add("लमजुङ ");
            DISTRICTLIST.Add("मनाङ ");
            DISTRICTLIST.Add("मुस्ताङ ");
            DISTRICTLIST.Add("म्याग्दी ");
            DISTRICTLIST.Add("नवलपुर ");
            DISTRICTLIST.Add("पर्वत ");
            DISTRICTLIST.Add("स्याङग्जा ");
            DISTRICTLIST.Add("तनहुँ ");
            DISTRICTLIST.Add("कपिलवस्तु ");
            DISTRICTLIST.Add("परासी ");
            DISTRICTLIST.Add("रुपन्देही ");
            DISTRICTLIST.Add("अर्घाखाँची ");
            DISTRICTLIST.Add("गुल्मी ");
            DISTRICTLIST.Add("पाल्पा");
            DISTRICTLIST.Add("दाङ देउखुरी");
            DISTRICTLIST.Add("प्युठान ");
            DISTRICTLIST.Add("रोल्पा ");
            DISTRICTLIST.Add("पूर्वी रूकुम");
            DISTRICTLIST.Add("बाँके");
            DISTRICTLIST.Add("बर्दिया");
            ViewBag.District = DISTRICTLIST;

            var WARDLIST = new List<string>();
            WARDLIST.Add("१ नम्बर वडा कार्यालय ");
            WARDLIST.Add("२ नम्बर वडा कार्यालय ");
            WARDLIST.Add("३ नम्बर वडा कार्यालय ");
            WARDLIST.Add("४ नम्बर वडा कार्यालय ");
            WARDLIST.Add("५ नम्बर वडा कार्यालय ");
            WARDLIST.Add("६ नम्बर वडा कार्यालय ");
            WARDLIST.Add("७ नम्बर वडा कार्यालय ");
            WARDLIST.Add("८ नम्बर वडा कार्यालय ");
            WARDLIST.Add("९ नम्बर वडा कार्यालय ");
            WARDLIST.Add("१० नम्बर वडा कार्यालय ");
            WARDLIST.Add("११ नम्बर वडा कार्यालय ");
            WARDLIST.Add("१२ नम्बर वडा कार्यालय ");
            ViewBag.Ward = WARDLIST;

            var GHARPRAKARLIST = new List<string>();
            GHARPRAKARLIST.Add("अन्य फुसको कच्ची घर ");
            GHARPRAKARLIST.Add("काठको फुसको कच्ची घर ");
            GHARPRAKARLIST.Add("काठको  भुईतल्ले कच्ची घर  टीन वा टायल्को छाना");
            GHARPRAKARLIST.Add("काठको ताड घर ,टीन वा टायल्को छाना");
            GHARPRAKARLIST.Add("पक्की इटाको जोडाईमा टीनको छाना");
            GHARPRAKARLIST.Add("पक्की छत्को ढलान");
            GHARPRAKARLIST.Add("माटोको कच्ची घर ");
            ViewBag.Gharprakar = GHARPRAKARLIST;
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Gharsambandhit();
            var lastList = lbdService.GetSelfList(loginId);
            return View(lastList.LastOrDefault());
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
        [HttpGet]//संस्था दर्ता प्रमाणपत्र
        public ActionResult Sansthadartapramanpatra()
        {
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
            return View();
        }

        [HttpPost]//जग्गाधनी लाल पुर्जा प्रतिलिपि
        public ActionResult Jaggadhanipratilipi(Jaggadhani_Pratilipi j)
        {
            var lservice = new Jaggaservice();
            var lresponse = lservice.SaveJaggadhanipratilipi(j);
            return RedirectToAction("Jaggadhanipratilipi");
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
            return View();
        }

        [HttpPost]//बाटो कायम
        public ActionResult Batokayam(Bato_Kayam bk)
        {
            var lservice = new Jaggaservice();
            var lresponse = lservice.SaveBatokayam(bk);
            return RedirectToAction("Batokayam");
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
            return View();
        }

        [HttpPost]//पुर्जामा घर कायम
        public ActionResult Jaggagharkayam(Jagga_Ghar_Kayam jg)
        {
            var lservice = new Jaggaservice();
            var lresponse = lservice.SaveJaggagharkayam(jg);
            return RedirectToAction("Jaggagharkayam");
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
            return View();
        }

        [HttpPost]//चार किल्ला प्रमाणित
        public ActionResult Charkilla(Charkilla_Sambandhama c)
        {
            var lservice = new Jaggaservice();
            var lresponse = lservice.SaveCharkilla(c);
            return RedirectToAction("Charkilla");
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
            return View();
        }
        [HttpPost]//मोही लागत कट्टा
        public ActionResult Mohilagatkatta(Mohi_Lagat_Katta ml)
        {
            var lservice = new Jaggaservice();
            var lresponse = lservice.SaveMohilagatkatta(ml);
            return RedirectToAction("Mohilagatkatta");
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

        [HttpGet]//Asthayi Basobaas
        public ActionResult Asthayibasobas()
        {
            return View();
        }

        [HttpPost]//Asthayi Basobaas
        public ActionResult Asthayibasobas(Asthayi_Basobas a)
        {
            var lservice = new Basobasservice();
            var lresponse = lservice.SaveAsthayibasobas(a);
            return RedirectToAction("Asthayibasobas");
        }

        [HttpGet]//अस्थाई बसोबास /आवेदकको विवरण
        public ActionResult Asthayibasobasview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Basobasservice();
            var selfList = lbdService.GetAsthayibasobasList(loginId);
            return View(selfList);
        }

        [HttpGet] //Antarik Basobas
        public ActionResult Antarikbasaisarai()
        {
            return View();
        }

        [HttpPost]//Asthayi Basobaas
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

        //NAGARIKTA

        [HttpGet]//Nagarikta Sambandhi card
        public ActionResult Nagariktasambandhicard()
        {
            return View();
        }

        [HttpGet]//Nagarikta_Praman_Patra
        public ActionResult Nagariktapramanpatra()
        {
            return View();
        }

        [HttpPost]//Nagarikta Praman Patra
        public ActionResult Nagariktapramanpatra(Nagarikta_Pramanpatra n)
        {
            var lservice = new Nagariktaservice();
            var lresponse = lservice.SaveNagariktapramanpatra(n);
            return RedirectToAction("Nagariktapramanpatra");
        }

        [HttpGet]//नागरिकता प्रमाण पत्र/ आवेदकको विवरण
        public ActionResult Nagariktapramanpatraview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Nagariktaservice();
            var selfList = lbdService.GetNagariktapramanpatraList(loginId);
            return View(selfList);
        }

        [HttpGet]//Nagarikta_Praman_Patra_Pratilipi
        public ActionResult Nagariktapramanpatrapratilipi()
        {
            return View();
        }

        [HttpPost]//Nagarikta Praman Patra Pratilipi
        public ActionResult Nagariktapramanpatrapratilipi(Nagarikta_Pramanpatra_Pratilipi n)
        {
            var lservice = new Nagariktaservice();
            var lresponse = lservice.SaveNagariktapramanpatrapratilipi(n);
            return RedirectToAction("Nagariktapramanpatrapratilipi");
        }

        [HttpGet]//नागरिकता प्रमाण पत्र/ आवेदकको विवरण
        public ActionResult Nagariktapramanpatrapratilipiview()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new Nagariktaservice();
            var selfList = lbdService.GetNagariktapramanpatrapratilipiList(loginId);
            return View(selfList);
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
            return RedirectToAction("Karyalaya");
        }
    }

}