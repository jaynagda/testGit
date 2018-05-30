using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace testAsmx
{
    class Program
    {
        static void Main(string[] args)
        {   
                createEmptyXML();            

        }
        private static void PostXml(string data)
        {
            string testXmlPath = @"E:\job\XML_Sample_Boarding_File.xml";
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                //com.trisourcesolutions.legacy.TSS_Load loadtss = new com.trisourcesolutions.legacy.TSS_Load();
                testAsmx.com.trisourcesolutions.legacy.TSS_Load loadtss= new com.trisourcesolutions.legacy.TSS_Load();
                string results = loadtss.Board(data);
            }
            catch (Exception e)
            {
                Console.WriteLine("Message :{0} ", e.Message);
                Console.ReadKey();
            }
        }
        public static void createEmptyXML()
        {
            TSS model = new TSS();
            model.MID = "601181450000013"; //601181450005012
            model.UserID = "mbnapi";
            model.Password = "hOHGb6Hwel6#";
            model.SortCode = "63060000000000";         
            
             /*//Cards cardsModel = new Cards();
            model.Cards.CardType = "4";
            model.Cards.DiscMethod = "G";
            model.Cards.DiscoverYN = "N";
            // model.Cards.ItemDebit = "0";
            model.Cards.ItemMidQual = "0.05";
            model.Cards.ItemNonQual = "0.05";
            model.Cards.ItemQual = ".00";
            model.Cards.MerchNo = "601181450000013";
            model.Cards.RateMidQual = "2.44";
            model.Cards.RateNonQual = "3.44";
            model.Cards.RateQual = "1.49";
          */

            
          Cards cr = new Cards();
           List<Cards> listCards = new List<Cards>();
          cr.CardType = "4";
          cr.DiscMethod = "G";
          cr.DiscoverYN = "N";
          cr.ItemDebit = "0";
          cr.ItemMidQual = "0.05";
          cr.ItemNonQual = "0.05";
          cr.ItemQual = ".00";
          //cr.MerchNo = "601181450000013";
          cr.PayPalOptOut = "N";
          cr.RateDebitQual = "0";
          cr.RateMidQual = "2.44";
          cr.RateNonQual = "3.44";
          cr.RateQual = "1.49";
          cr.SP = "";
          cr.SPDate = "";
          cr.SPID = "";
          listCards.Add(cr);
          model.Cards = listCards;

         /*   Cards c1Credit = new Cards();
            c1Credit.CardType = "4";
            c1Credit.DiscMethod = "G";
            c1Credit.DiscoverYN = "N";
            c1Credit.ItemDebit = "0";
            c1Credit.ItemMidQual = ".00";
            c1Credit.ItemNonQual = ".00";
            c1Credit.ItemQual = ".00";
            c1Credit.MerchNo = "601181450000013";
            c1Credit.PayPalOptOut = "N";
            c1Credit.RateDebitQual = "0";
            c1Credit.RateMidQual = "0.00";
            c1Credit.RateNonQual = "0.00";
            c1Credit.RateQual = "0.00";
            c1Credit.SP = "";
            c1Credit.SPDate = "";
            c1Credit.SPID = "";
            listCards.Add(c1Credit);
            model.Cards = listCards;
            */
            Cards c2 = new Cards();
          c2.CardType = "5";
          c2.DiscMethod = "G";
          c2.DiscoverYN = "";
          c2.ItemMidQual = "0.05";
          c2.ItemNonQual = "0.05";
          c2.ItemQual = "0.00";
          //c2.MerchNo = "601181450000013";
          c2.RateMidQual = "2.44";
          c2.RateNonQual = "3.44";
          c2.RateQual = "1.49";
          listCards.Add(c2);
          model.Cards = listCards;
         /* Cards c2Credit = new Cards();

          c2Credit.CardType = "5";
          c2Credit.DiscMethod = "G";
          c2Credit.DiscoverYN = "N";
          c2Credit.ItemMidQual = ".00";
          c2Credit.ItemNonQual = ".00";
          c2Credit.ItemQual = ".00";
          c2Credit.MerchNo = "601181450000013";          
          c2Credit.RateMidQual = "0.00";
          c2Credit.RateNonQual = "0.00";
          c2Credit.RateQual = "0.00";
          listCards.Add(c2Credit);
          model.Cards = listCards;
          */
          Cards dcDebit = new Cards();
          dcDebit.CardType = "6";
          dcDebit.DiscMethod = "G";
          dcDebit.DiscoverYN = "N";           
          dcDebit.ItemMidQual = ".00";
          dcDebit.ItemNonQual = "0.00";
          dcDebit.ItemQual = ".00";
          //dcDebit.MerchNo = "601181450000013";
          dcDebit.RateMidQual = "2.44";
          dcDebit.RateNonQual = "3.44";
          dcDebit.RateQual = "1.49";
          listCards.Add(dcDebit);
          model.Cards = listCards;
            /*
                      Cards dcCredit = new Cards();
                      dcCredit.CardType = "6";
                      dcCredit.DiscMethod = "G";
                      dcCredit.DiscoverYN = "N";
                      dcCredit.ItemMidQual = ".00";
                      dcCredit.ItemNonQual = ".05";
                      dcCredit.ItemQual = ".00";
                      dcCredit.MerchNo = "601181450000013";
                      dcCredit.RateMidQual = "0.00";
                      dcCredit.RateNonQual = "0.00";
                      dcCredit.RateQual = "0.00";
                      listCards.Add(dcCredit);
                      model.Cards = listCards;
                      */
            Cards amex = new Cards();
            amex.CardType = "3";
            amex.DiscMethod = "G";
            amex.DiscoverYN = "N";
            amex.ItemMidQual = "0";
            amex.ItemNonQual = "0";
            amex.ItemQual = "0";
           // amex.MerchNo = "6011814500";
            amex.RateMidQual = "0";
            amex.RateNonQual = "0";
            amex.RateQual = "0";
            listCards.Add(amex);
            model.Cards = listCards;

            //CostPlus costplusModel = new CostPlus();
            model.CostPlus.Discover_Bpts = "0";
            model.CostPlus.Discover_PerTran = "0";
            model.CostPlus.MC_Bpts = "0";
            model.CostPlus.MC_PerTran = "0";
            model.CostPlus.Visa_Bpts = "0";
            model.CostPlus.Visa_PerTran = "0";
            model.CostPlus.Amex_PerTran = ".20";//give missing field and values curt .20
            model.CostPlus.Amex_Bpts = "0020";//give missing field and values curt .0020
            //DebitMrchRates debitmrchModel = new DebitMrchRates();
            model.DebitMrchRates.GPS_BankMate_Bpts = "0.00";
            model.DebitMrchRates.GPS_BankMate_PerTran = ".00";
            model.DebitMrchRates.GPS_BkMtDirect_Bpts = "0.00";
            model.DebitMrchRates.GPS_BkMtDirect_PerTran = ".00";
            model.DebitMrchRates.GPS_Cactus_Bpts = "0.00";
            model.DebitMrchRates.GPS_Cactus_PerTran = ".00";
            model.DebitMrchRates.GPS_CashStation_Bpts = "0.00";
            model.DebitMrchRates.GPS_CashStation_PerTran = ".00";
            model.DebitMrchRates.GPS_Exchange_Bpts = "0.00";
            model.DebitMrchRates.GPS_Exchange_PerTran = ".00";
            model.DebitMrchRates.GPS_HONOR_Bpts = "0.00";
            model.DebitMrchRates.GPS_HONOR_PerTran = ".00";
            model.DebitMrchRates.GPS_Interlink_Bpts = "0.00";
            model.DebitMrchRates.GPS_Interlink_PerTran = ".00";
            model.DebitMrchRates.GPS_Internet_Bpts = "0.00";
            model.DebitMrchRates.GPS_Internet_PerTran = ".00";
            model.DebitMrchRates.GPS_Mac_Bpts = "0.00";
            model.DebitMrchRates.GPS_Mac_PerTran = ".00";
            model.DebitMrchRates.GPS_Maestro_Bpts = "0.00";
            model.DebitMrchRates.GPS_Maestro_PerTran = ".00";
            model.DebitMrchRates.GPS_MagicLine_Bpts = "0.00";
            model.DebitMrchRates.GPS_MagicLine_PerTran = ".00";
            model.DebitMrchRates.GPS_MoneyStation_Bpts = "0.00";
            model.DebitMrchRates.GPS_MoneyStation_PerTran = ".00";
            model.DebitMrchRates.GPS_Mpact_Bpts = "0.00";
            model.DebitMrchRates.GPS_Mpact_PerTran = ".00";
            model.DebitMrchRates.GPS_NetworkOne_Bpts = "0.00";
            model.DebitMrchRates.GPS_NetworkOne_PerTran = ".00";
            model.DebitMrchRates.GPS_Pulse_Bpts = "0.00";
            model.DebitMrchRates.GPS_Pulse_PerTran = ".00";
            model.DebitMrchRates.GPS_Quest_Bpts = "0.00";
            model.DebitMrchRates.GPS_Quest_PerTran = ".00";
            model.DebitMrchRates.GPS_SCS_Bpts = "0.00";
            model.DebitMrchRates.GPS_SCS_PerTran = ".00";
            model.DebitMrchRates.PT_AccelExch_Bpts = "0.00";
            model.DebitMrchRates.PT_AccelExch_PerTran = ".00";
            model.DebitMrchRates.PT_AFFN_Bpts = "0.00";
            model.DebitMrchRates.PT_AFFN_PerTran = ".00";
            model.DebitMrchRates.PT_AlaskaOp_Bpts = "0.00";
            model.DebitMrchRates.PT_AlaskaOP_PerTran = ".00";
            model.DebitMrchRates.PT_CU24_Bpts = "0.00";
            model.DebitMrchRates.PT_CU24_PerTran = ".00";
            model.DebitMrchRates.PT_EBT_Bpts = "0.00";
            model.DebitMrchRates.PT_EBT_PerTran = ".00";
            model.DebitMrchRates.PT_Interlink_Bpts = "0.00";
            model.DebitMrchRates.PT_Interlink_PerTran = ".00";
            model.DebitMrchRates.PT_Jeanie_Bpts = "0.00";
            model.DebitMrchRates.PT_Jennie_PerTran = ".00";
            model.DebitMrchRates.PT_Maestro_Bpts = "0.00";
            model.DebitMrchRates.PT_Maestro_PerTran = ".00";
            model.DebitMrchRates.PT_NYCE_Bpts = "0.00";
            model.DebitMrchRates.PT_NYCE_PerTran = ".00";
            model.DebitMrchRates.PT_Pulse_Bpts = "0.00";
            model.DebitMrchRates.PT_Pulse_PerTran = ".00";
            model.DebitMrchRates.PT_Shazam_Bpts = "0.00";
            model.DebitMrchRates.PT_Shazam_PerTran = ".00";
            model.DebitMrchRates.PT_Star_Bpts = "0.00";
            model.DebitMrchRates.PT_Star_PerTran = ".00";
            model.DebitMrchRates.TSYS_AccelExch_Bpts = "0.00";
            model.DebitMrchRates.TSYS_AccelExch_PerTran = ".00";
            model.DebitMrchRates.TSYS_AFFN_Bpts = "0.00";
            model.DebitMrchRates.TSYS_AFFN_PerTran = ".00";
            model.DebitMrchRates.TSYS_AlaskaOp_Bpts = "0.00";
            model.DebitMrchRates.TSYS_AlaskaOp_PerTran = ".00";
            model.DebitMrchRates.TSYS_EBT_Bpts = "0.00";
            model.DebitMrchRates.TSYS_EBT_PerTran = ".00";
            model.DebitMrchRates.TSYS_Interlink_Bpts = "0.00";
            model.DebitMrchRates.TSYS_Interlink_PerTran = ".00";
            model.DebitMrchRates.TSYS_Maestro_Bpts = "0.00";
            model.DebitMrchRates.TSYS_Maestro_PerTran = ".00";
            model.DebitMrchRates.TSYS_NYCE_Bpts = "0.00";
            model.DebitMrchRates.TSYS_NYCE_PerTran = ".00";
            model.DebitMrchRates.TSYS_Pulse_Bpts = "0.00";
            model.DebitMrchRates.TSYS_Pulse_PerTran = ".00";
            model.DebitMrchRates.TSYS_Shazam_Bpts = "0.00";
            model.DebitMrchRates.TSYS_Shazam_PerTran = ".00";
            model.DebitMrchRates.TSYS_Star_Bpts = "0.00";
            model.DebitMrchRates.TSYS_Star_PerTran = ".00";

            // DebitMrchRatesCP debitmrchcpModel = new DebitMrchRatesCP();
            model.DebitMrchRatesCP.GPS_CP_BankMate_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_BankMate_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_BkMtDirect_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_BkMtDirect_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_Cactus_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_Cactus_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_CashStation_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_CashStation_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_Exchange_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_Exchange_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_HONOR_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_HONOR_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_Interlink_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_Interlink_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_Internet_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_Internet_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_Mac_Bpts = ".00";
            model.DebitMrchRatesCP.GPS_CP_Mac_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_Maestro_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_Maestro_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_MagicLine_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_MagicLine_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_MoneyStation_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_MoneyStation_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_Mpact_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_Mpact_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_NetworkOne_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_NetworkOne_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_Pules_PerTran = "0.00";
            model.DebitMrchRatesCP.GPS_CP_Pulse_Bpts = ".00";
            model.DebitMrchRatesCP.GPS_CP_Quest_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_Quest_PerTran = ".00";
            model.DebitMrchRatesCP.GPS_CP_SCS_Bpts = "0.00";
            model.DebitMrchRatesCP.GPS_CP_SCS_PerTran = ".00";
            model.DebitMrchRatesCP.PT_CP_AccelExch_Bpts = "0.00";
            model.DebitMrchRatesCP.PT_CP_AccelExch_PerTran = ".00";
            model.DebitMrchRatesCP.PT_CP_AFFN_Bpts = "0.00";
            model.DebitMrchRatesCP.PT_CP_AFFN_PerTran = ".00";
            model.DebitMrchRatesCP.PT_CP_AlaskaOp_Bpts = "0.00";
            model.DebitMrchRatesCP.PT_CP_AlaskaOp_PerTran = ".00";
            model.DebitMrchRatesCP.PT_CP_CU24_Bpts = "0.00";
            model.DebitMrchRatesCP.PT_CP_CU24_PerTran = ".00";
            model.DebitMrchRatesCP.PT_CP_EBT_Bpts = "0.00";
            model.DebitMrchRatesCP.PT_CP_EBT_PerTran = ".00";
            model.DebitMrchRatesCP.PT_CP_Interlink_Bpts = "0.00";
            model.DebitMrchRatesCP.PT_CP_Interlink_PerTran = ".00";
            model.DebitMrchRatesCP.PT_CP_Jeanie_Bpts = "0.00";
            model.DebitMrchRatesCP.PT_CP_Jeanie_PerTran = ".00";
            model.DebitMrchRatesCP.PT_CP_Maestro_Bpts = "0.00";
            model.DebitMrchRatesCP.PT_CP_Maestro_PerTran = ".00";
            model.DebitMrchRatesCP.PT_CP_NYCE_Bpts = "0.00";
            model.DebitMrchRatesCP.PT_CP_NYCE_PerTran = ".00";
            model.DebitMrchRatesCP.PT_CP_Pulse_Bpts = "0.00";
            model.DebitMrchRatesCP.PT_CP_Pulse_PerTran = ".00";
            model.DebitMrchRatesCP.PT_CP_Shazam_Bpts = "0.00";
            model.DebitMrchRatesCP.PT_CP_Shazam_PerTran = ".00";
            model.DebitMrchRatesCP.PT_CP_Star_Bpts = "0.00";
            model.DebitMrchRatesCP.PT_CP_Star_PerTran = ".00";
            model.DebitMrchRatesCP.TSYS_CP_AccelExch_Bpts = "0.00";
            model.DebitMrchRatesCP.TSYS_CP_AccelExch_PerTran = ".00";
            model.DebitMrchRatesCP.TSYS_CP_AFFN_Bpts = "0.00";
            model.DebitMrchRatesCP.TSYS_CP_AFFN_PerTran = ".00";
            model.DebitMrchRatesCP.TSYS_CP_AlaskaOp_Bpts = "0.00";
            model.DebitMrchRatesCP.TSYS_CP_AlaskaOp_PerTran = ".00";
            model.DebitMrchRatesCP.TSYS_CP_EBT_Bpts = "0.00";
            model.DebitMrchRatesCP.TSYS_CP_EBT_PerTran = ".00";
            model.DebitMrchRatesCP.TSYS_CP_Interlink_Bpts = "0.00";
            model.DebitMrchRatesCP.TSYS_CP_Interlink_PerTran = ".00";
            model.DebitMrchRatesCP.TSYS_CP_Maestro_Bpts = "0.00";
            model.DebitMrchRatesCP.TSYS_CP_Maestro_PerTran = ".00";
            model.DebitMrchRatesCP.TSYS_CP_NYCE_Bpts = "0.00";
            model.DebitMrchRatesCP.TSYS_CP_NYCE_PerTran = ".00";
            model.DebitMrchRatesCP.TSYS_CP_Pulse_Bpts = "0.00";
            model.DebitMrchRatesCP.TSYS_CP_Pulse_PerTran = ".00";
            model.DebitMrchRatesCP.TSYS_CP_Shazam_Bpts = "0.00";
            model.DebitMrchRatesCP.TSYS_CP_Shazam_PerTran = ".00";
            model.DebitMrchRatesCP.TSYS_CP_Star_Bpts = "0.00";
            model.DebitMrchRatesCP.TSYS_CP_Star_PerTran = ".00";

            //FlexFee flexfeeModel = new FlexFee();
            model.FlexFee.Fee = "0.25";
            model.FlexFee.MiscDesc = "";
            model.FlexFee.TranCode = "066";
            model.FlexFee.TranDesc = "Annual Fee";

            //Mrch mrchModel = new Mrch();
           // model.Mrch.Acct1Type = "C";//ART Account type in lup: meanings  of T, E or M ?
            model.Mrch.Acct2Type = "";
            model.Mrch.ACHAdj = "Y";
            model.Mrch.ACHDelay = "0";
            //model.Mrch.AssocNo = "";
            model.Mrch.AuthCenter = "TSYS";//omaha//give missing values curt TSYS
            model.Mrch.AuthTypeCode = "E";//p//give missing values curt P (Caps)// default value is E
            model.Mrch.BusOrg = "3";
            model.Mrch.CbkDestInd = "";//ART giving YES or NO
            model.Mrch.CellNo = "";//not in sample file xml 
            model.Mrch.ChainYN = "";
            model.Mrch.ChargeOffDate = "";//not in sample file xml 
            model.Mrch.ChargeOffFlag = "";
            model.Mrch.CharityID = "";//not in sample file xml 
            model.Mrch.CloseDate = ""; //not in sample file xml 
            model.Mrch.CloseReason = ""; //not in sample file xml 
            model.Mrch.CombACH = "Y";
            model.Mrch.Contact = "JASON GARWOOD";
            model.Mrch.CorpAddr = "3102 S PARKER RD SUITE #A3";
            model.Mrch.CorpCity = "AURORA";
            model.Mrch.CorpFax = "";
            model.Mrch.CorpName = "GARWOOD CHIROPRACTIC PC";
            model.Mrch.CorpPhone = "3039231102";//303-923-1102
            model.Mrch.CorpState = "CO";
            model.Mrch.CorpZip = "80014";
            model.Mrch.CPStatus = "N";
            model.Mrch.CustServPhone = "";//not in sample file xml
            model.Mrch.DBAaddr = "3102 S PARKER RD SUITE #A3";
            model.Mrch.DBACity = "AURORA";
            model.Mrch.DBACountry = "840";
            model.Mrch.DBAFax = "";
            model.Mrch.DBAName = "GARWOOD CHIROPRACTIC PC";
            model.Mrch.DBAPhone = "3039231102";//303-923-1102
            model.Mrch.DBAState = "CO";
            model.Mrch.DBAZip = "80014";
            model.Mrch.DDA = "";//103675495925
            model.Mrch.DealerID = "";//not in sample file xml
            model.Mrch.DebitCPStatus = "Y";
            model.Mrch.DiscountType = "M";
            model.Mrch.DuesAssessments = "Y";
            model.Mrch.EMailAddr = "jatendra@techdharma.com";
            model.Mrch.EnhancedCost = "N";//ART give 
            model.Mrch.FeeDDA = "";//not in sample file xml
           // model.Mrch.FeeTR = "122235821";//not in sample file xml//102000021  //give missing values curt 322271627
            model.Mrch.HoldFlg = "Y";
            model.Mrch.InterchangePlan = "";
            model.Mrch.irsName = "GARWOOD CHIROPRACTIC PC";
            model.Mrch.irsTaxID = "30540765";
            model.Mrch.irsType = "S";
            model.Mrch.MCC = "8041";
            model.Mrch.MCCNotes = "Notify and Make Memo Visible to Agent";
            model.Mrch.MCCtype = "E";
            model.Mrch.MIDCon = "";//not in sample file xml
            model.Mrch.NDF = "N"; //not in sample file xml
            model.Mrch.NetACH = "N";
            model.Mrch.Notes = "";  //not in sample file xml
            model.Mrch.RetStmtInd = ""; //not in sample file xml
            model.Mrch.RollResv = "Y";
            model.Mrch.RollResvDays = "1";
            model.Mrch.SalesRep = "1161";//not in sample file xml
            model.Mrch.SeasonalFlg = "0";
            model.Mrch.SeasonalMonths = "";
            model.Mrch.StartDate = "5/30/2018";//give missing values curt 3/15/2018
            model.Mrch.StmtDest = "M";
            model.Mrch.StmtInd = "E";
            model.Mrch.StoreNo = "";//not in sample file xml
            model.Mrch.TaxableState = "AA";
            //model.Mrch.TR = "122235821";//102000021//give missing values curt 322271627
            model.Mrch.Tranzlogic = ""; //not in sample file xml
            model.Mrch.CreditDDA = "4290129999";//give missing field and values curt 4290129999
            model.Mrch.CreditTR = "322271627";//give missing values curt 322271627
            model.Mrch.CreditAcctType = "C";//give missing field and values curt Try "T", "E" or "M"

            // NetIDs netiDModel = new NetIDs();
            model.NetID.Net_ID = "02";

            // OtherFees otherfeesModel = new OtherFees();
            model.OtherFees.AdminAuthRate = "";
            model.OtherFees.APFRate = "0.02";
            model.OtherFees.DebAuthRate = "0.35";
            model.OtherFees.DiscARURate = "0.35";
            model.OtherFees.DiscAuthRate = "0.35";
            model.OtherFees.DiscDUC = "0.02";
            model.OtherFees.DiscIPF = "1.3";
            model.OtherFees.DiscNAF = "0.0025";
            model.OtherFees.DiscVoiceRate = "0.95";
            model.OtherFees.McAcctInqRate = "0.025";
            model.OtherFees.MCARURate = "0.35";
            model.OtherFees.MCAuthRate = "0.35";
            model.OtherFees.McCrossBdr = "1.45";
            model.OtherFees.McCVC2 = "0.0025";
            model.OtherFees.McMisuseRate = "0.045";
            model.OtherFees.MCVoiceRate = "0.95";
            model.OtherFees.NABURate = "0.03";
            model.OtherFees.TEARURate = "";
            model.OtherFees.TEAuthRate = "";
            model.OtherFees.TEVoiceRate = "";
            model.OtherFees.VisaAPFDebitRate = "0.02";
            model.OtherFees.VisaARURate = "0.35";
            model.OtherFees.VisaAuthRate = "0.35";
            model.OtherFees.VisaFANFRate = "0";
            model.OtherFees.VisaFloorLimitRate = "0.2";
            model.OtherFees.VisaIAFRate = "0.45";
            model.OtherFees.VisaIntegrityRate = "0.1";
            model.OtherFees.VisaISARate = "0.8";
            model.OtherFees.VisaMisuseRate = "0.09";
            model.OtherFees.VisaVoiceRate = "0.95";    

            model.OtherFees.AmexDQ = "0.75";
            model.OtherFees.MCLocation = "1.25";
            model.OtherFees.VisaXferRate = "0.0018";
            model.OtherFees.AmexAuthRate = ".050";
            model.OtherFees.AmexVoiceRate = ".050";
            model.OtherFees.AmexARURate = ".050";
            model.OtherFees.AdminAuthRate = "0.030";
            model.OtherFees.AmexNF = "0.15";
            model.OtherFees.AmexNSF = "0.30";
            model.OtherFees.AmexIF = "0.40";

        //PCIData pcidataModel = new PCIData();

        model.PCIData.DataStorage = "N";
            model.PCIData.DateLevelDetermined = "";
            model.PCIData.DSEProvider = "";
            model.PCIData.InitialMRPRegistrationDate = "";
            model.PCIData.MerchantLevel = "4";
            model.PCIData.MRPRegistrationStatus = "N";
            model.PCIData.OnsiteAuditStatus = "N";
            model.PCIData.OnsiteAuditTargetDate = "";
            model.PCIData.OnsiteAuditVendor = "";
            model.PCIData.PayAppVersion = "";
            model.PCIData.PCICompliant = "";
            model.PCIData.PCINotes = "";
            model.PCIData.PCIScanVendor = "";
            model.PCIData.PCITermType = "";
            model.PCIData.QuarterlyScanPastDue = "N";
            model.PCIData.RemediationTargetDate = "";
            model.PCIData.ScanDate = "";
            model.PCIData.ScanPassed = "N";
            model.PCIData.ScanReceived = "N";
            model.PCIData.SelfAssessmentPassed = "N";
            model.PCIData.SelfAssessmentReceived = "N";
            model.PCIData.SelfAssessmentReceivedDate = "1/2/2018 "; //give missing values curt 1/2/2018 
            model.PCIData.SentToScanVendor = "N";
            model.PCIData.TPPPaymentApplication = "N";

            // Risk riskModel = new Risk();
            model.Risk.AvgTickApv = "50";
            model.Risk.AvgTickReq = "";
            model.Risk.ChargeBackFee = "";
            model.Risk.CustServStmtFee = "10";
            model.Risk.DebitAccessCyberCash = "";
            model.Risk.FedTaxNo = "215544533"; //30540765//give missing values curt 215544533
            model.Risk.HoldReserve = "";
            model.Risk.LargeBatch = "";
            model.Risk.LargeDupCard = "";
            model.Risk.LargePA = "";
            model.Risk.LargeRefund = "";
            model.Risk.LargeSale = "";
            model.Risk.MaxTickKeyEnt = "";
            model.Risk.MaxTickSize = "200";
            model.Risk.MaxTickSwipe = "";
            model.Risk.MCA_ID = "";
            model.Risk.MCA_Pct = "";
            model.Risk.MCAenabled = "";
            model.Risk.MicroRisk = "";
            model.Risk.MinMonthlyFee = "0";
            model.Risk.MonthlyVolApv = "42000";
            model.Risk.MonthlyVolReq = "";
            model.Risk.NoDupCard = "";
            model.Risk.OrigReserve = "";
            model.Risk.Owner1Addr = "8041 S WILLIAMS CIRCLE";
            model.Risk.Owner1City = "CANTENNIAL";
            model.Risk.Owner1DLState = "CO";
            model.Risk.Owner1DrvLisc = "940561285";
            model.Risk.Owner1First = "JASON";
            model.Risk.Owner1Last = "GARWOOD";
            model.Risk.Owner1Phone = "3037948620";
            model.Risk.Owner1SSN = "153766672";
            model.Risk.Owner1State = "CO";
            model.Risk.Owner1Zip = "80122";
            model.Risk.Owner2Addr = "";
            model.Risk.Owner2City = "";
            model.Risk.Owner2DLState = "";
            model.Risk.Owner2DrvLisc = "";
            model.Risk.Owner2First = "";
            model.Risk.Owner2Last = "";
            model.Risk.Owner2Phone = "";
            model.Risk.Owner2SSN = "";
            model.Risk.Owner2State = "";
            model.Risk.Owner2Zip = "";
            model.Risk.PctAnnualCBRatio = "";
            model.Risk.PctBatchOverApp = "";
            model.Risk.PctBatchOverHist = "";
            model.Risk.PctKeyEntered = "100";
            model.Risk.PctMonthlyCBRatio = "";
            model.Risk.PctTargetResrv = "";
            model.Risk.PctTickOverApp = "";
            model.Risk.PctTickOverHist = "";
            model.Risk.PeakSeasVol = "5000";
            model.Risk.Rating = "";
            model.Risk.Reclassifications = "";
            model.Risk.RiskRptDetail = "";
            model.Risk.StateTaxNo = "";
            model.Risk.TaxPayerID = "215544533";//30540765//give missing values curt 215544533
            model.Risk.TMFflg = "";
            model.Risk.UnmatchedRefund = "";
            model.Risk.WirelessEqWarrFee = "";

            //Term termModel = new Term();
            model.Term.Connectivity = "";
            model.Term.GateSoftMisc = "";
            model.Term.PCIValReq = "";
            model.Term.POSDevType = "";
            model.Term.TerminalType = "Hypercom T4205";//Hypercom T7P(IMPACT)//give missing values curt Hypercom T4205
            model.Term.TID = "39951001";

            //then serailize this   


            string BlankXmlPath = @"E:\job\testAsmx.xml";

            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(TSS));
            System.IO.TextWriter abc = new System.IO.StreamWriter(BlankXmlPath);
            //for without xmlns:xsi
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            //Add an empty namespace and empty value
            ns.Add("", "");
            xs.Serialize(abc, model, ns);            
                       

            string rbeJson2 = JsonConvert.SerializeObject(model);
            string rbeXML2 = JsonConvert.DeserializeXmlNode("{\"TSS\":" + rbeJson2 + "}").InnerXml;
            string data = rbeXML2;
            PostXml(data);

        }
    }
}
