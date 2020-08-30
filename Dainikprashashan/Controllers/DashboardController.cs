using Dainikprashashan.Models;
using Dainikprashashan.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Dainikprashashan.Controllers
{
    public class DashboardController : Controller
    {
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
        [HttpGet]//Ghar kayamko sifaris
        public ActionResult Gharkayamkosifaris()
        {

            var KARYALAYALIST = new List<string>();
            KARYALAYALIST.Add("वडा कार्यालय  ");
            KARYALAYALIST.Add("मालपोत  कार्यालय  ");
            KARYALAYALIST.Add("जिल्ला प्रशासन  कार्यालय  ");
            ViewBag.karyalaya = KARYALAYALIST;


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

        [HttpGet]//Edit Aabedanko Biwaran
        public ActionResult Editabedanniwaran()
        {

            var KARYALAYALIST = new List<string>();
            KARYALAYALIST.Add("वडा कार्यालय  ");
            KARYALAYALIST.Add("मालपोत  कार्यालय  ");
            KARYALAYALIST.Add("जिल्ला प्रशासन  कार्यालय  ");
            ViewBag.karyalaya = KARYALAYALIST;


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
            return RedirectToAction("Gharbatopramanit");
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
            return RedirectToAction("Gharjagganaamsari");
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


        //BASOBAAS
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
            return RedirectToAction("Sthayibasobas");
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
            return RedirectToAction("Antarikbasaisarai");
        }

    }
}