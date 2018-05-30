using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAsmx
{
        public class TSS
        {

            public string MID { get; set; }
            public string UserID { get; set; }
            public string Password { get; set; }
            public string SortCode { get; set; }

           public List<Cards> Cards { get; set; }
          //  public Cards Cards { get; set; }
            public CostPlus CostPlus { get; set; }
            public DebitMrchRates DebitMrchRates { get; set; }
            public DebitMrchRatesCP DebitMrchRatesCP { get; set; }
            public FlexFee FlexFee { get; set; }
            public Mrch Mrch { get; set; }
            public NetIDs NetID { get; set; }
            public OtherFees OtherFees { get; set; }
            public PCIData PCIData { get; set; }
            public Risk Risk { get; set; }
            public Term Term { get; set; }
            public TSS()
            {
            // Cards = new Cards();
            Cards = new List<Cards>();
                 CostPlus = new CostPlus();
                DebitMrchRates = new DebitMrchRates();
                DebitMrchRatesCP = new DebitMrchRatesCP();
                FlexFee = new FlexFee();
                Mrch = new Mrch();
                NetID = new NetIDs();
                OtherFees = new OtherFees();
                PCIData = new PCIData();
                Risk = new Risk();
                Term = new Term();
            }
        }

        public class Cards
        {
            public string CardType { get; set; }
            public string DiscMethod { get; set; }
            public string DiscoverYN { get; set; }
            public string ItemDebit { get; set; }
            public string ItemMidQual { get; set; }
            public string ItemNonQual { get; set; }
            public string ItemQual { get; set; }
            public string MerchNo { get; set; }
            public string PayPalOptOut { get; set; }
            public string RateDebitQual { get; set; }
            public string RateMidQual { get; set; }
            public string RateNonQual { get; set; }
            public string RateQual { get; set; }
            public string SP { get; set; }
            public string SPDate { get; set; }
            public string SPID { get; set; }

        }


        public class CostPlus
        {
            public string Discover_Bpts { get; set; }
            public string Discover_PerTran { get; set; }
            public string MC_Bpts { get; set; }
            public string MC_PerTran { get; set; }
            public string Visa_Bpts { get; set; }
            public string Visa_PerTran { get; set; }
            public string Amex_PerTran { get; set; }
            public string Amex_Bpts { get; set; }

        

    }
        public class DebitMrchRates
        {
            public string GPS_BankMate_Bpts { get; set; }
            public string GPS_BankMate_PerTran { get; set; }
            public string GPS_BkMtDirect_Bpts { get; set; }
            public string GPS_BkMtDirect_PerTran { get; set; }
            public string GPS_Cactus_Bpts { get; set; }
            public string GPS_Cactus_PerTran { get; set; }
            public string GPS_CashStation_Bpts { get; set; }
            public string GPS_CashStation_PerTran { get; set; }
            public string GPS_Exchange_Bpts { get; set; }
            public string GPS_Exchange_PerTran { get; set; }
            public string GPS_HONOR_Bpts { get; set; }
            public string GPS_HONOR_PerTran { get; set; }
            public string GPS_Interlink_Bpts { get; set; }
            public string GPS_Interlink_PerTran { get; set; }
            public string GPS_Internet_Bpts { get; set; }
            public string GPS_Internet_PerTran { get; set; }
            public string GPS_Mac_Bpts { get; set; }
            public string GPS_Mac_PerTran { get; set; }
            public string GPS_Maestro_Bpts { get; set; }
            public string GPS_Maestro_PerTran { get; set; }
            public string GPS_MagicLine_Bpts { get; set; }
            public string GPS_MagicLine_PerTran { get; set; }
            public string GPS_MoneyStation_Bpts { get; set; }
            public string GPS_MoneyStation_PerTran { get; set; }
            public string GPS_Mpact_Bpts { get; set; }
            public string GPS_Mpact_PerTran { get; set; }
            public string GPS_NetworkOne_Bpts { get; set; }
            public string GPS_NetworkOne_PerTran { get; set; }
            public string GPS_Pulse_Bpts { get; set; }
            public string GPS_Pulse_PerTran { get; set; }
            public string GPS_Quest_Bpts { get; set; }
            public string GPS_Quest_PerTran { get; set; }
            public string GPS_SCS_Bpts { get; set; }
            public string GPS_SCS_PerTran { get; set; }
            public string PT_AccelExch_Bpts { get; set; }
            public string PT_AccelExch_PerTran { get; set; }
            public string PT_AFFN_Bpts { get; set; }
            public string PT_AFFN_PerTran { get; set; }
            public string PT_AlaskaOp_Bpts { get; set; }
            public string PT_AlaskaOP_PerTran { get; set; }
            public string PT_CU24_Bpts { get; set; }
            public string PT_CU24_PerTran { get; set; }
            public string PT_EBT_Bpts { get; set; }
            public string PT_EBT_PerTran { get; set; }
            public string PT_Interlink_Bpts { get; set; }
            public string PT_Interlink_PerTran { get; set; }
            public string PT_Jeanie_Bpts { get; set; }
            public string PT_Jennie_PerTran { get; set; }
            public string PT_Maestro_Bpts { get; set; }
            public string PT_Maestro_PerTran { get; set; }
            public string PT_NYCE_Bpts { get; set; }
            public string PT_NYCE_PerTran { get; set; }
            public string PT_Pulse_Bpts { get; set; }
            public string PT_Pulse_PerTran { get; set; }
            public string PT_Shazam_Bpts { get; set; }
            public string PT_Shazam_PerTran { get; set; }
            public string PT_Star_Bpts { get; set; }
            public string PT_Star_PerTran { get; set; }
            public string TSYS_AccelExch_Bpts { get; set; }
            public string TSYS_AccelExch_PerTran { get; set; }
            public string TSYS_AFFN_Bpts { get; set; }
            public string TSYS_AFFN_PerTran { get; set; }
            public string TSYS_AlaskaOp_Bpts { get; set; }
            public string TSYS_AlaskaOp_PerTran { get; set; }
            public string TSYS_EBT_Bpts { get; set; }
            public string TSYS_EBT_PerTran { get; set; }
            public string TSYS_Interlink_Bpts { get; set; }
            public string TSYS_Interlink_PerTran { get; set; }
            public string TSYS_Maestro_Bpts { get; set; }
            public string TSYS_Maestro_PerTran { get; set; }
            public string TSYS_NYCE_Bpts { get; set; }
            public string TSYS_NYCE_PerTran { get; set; }
            public string TSYS_Pulse_Bpts { get; set; }
            public string TSYS_Pulse_PerTran { get; set; }
            public string TSYS_Shazam_Bpts { get; set; }
            public string TSYS_Shazam_PerTran { get; set; }
            public string TSYS_Star_Bpts { get; set; }
            public string TSYS_Star_PerTran { get; set; }
        }

        public class DebitMrchRatesCP
        {
            public string GPS_CP_BankMate_Bpts { get; set; }
            public string GPS_CP_BankMate_PerTran { get; set; }
            public string GPS_CP_BkMtDirect_Bpts { get; set; }
            public string GPS_CP_BkMtDirect_PerTran { get; set; }
            public string GPS_CP_Cactus_Bpts { get; set; }
            public string GPS_CP_Cactus_PerTran { get; set; }
            public string GPS_CP_CashStation_Bpts { get; set; }
            public string GPS_CP_CashStation_PerTran { get; set; }
            public string GPS_CP_Exchange_Bpts { get; set; }
            public string GPS_CP_Exchange_PerTran { get; set; }
            public string GPS_CP_HONOR_Bpts { get; set; }
            public string GPS_CP_HONOR_PerTran { get; set; }
            public string GPS_CP_Interlink_Bpts { get; set; }
            public string GPS_CP_Interlink_PerTran { get; set; }
            public string GPS_CP_Internet_Bpts { get; set; }
            public string GPS_CP_Internet_PerTran { get; set; }
            public string GPS_CP_Mac_Bpts { get; set; }
            public string GPS_CP_Mac_PerTran { get; set; }
            public string GPS_CP_Maestro_Bpts { get; set; }
            public string GPS_CP_Maestro_PerTran { get; set; }
            public string GPS_CP_MagicLine_Bpts { get; set; }
            public string GPS_CP_MagicLine_PerTran { get; set; }
            public string GPS_CP_MoneyStation_Bpts { get; set; }
            public string GPS_CP_MoneyStation_PerTran { get; set; }
            public string GPS_CP_Mpact_Bpts { get; set; }
            public string GPS_CP_Mpact_PerTran { get; set; }
            public string GPS_CP_NetworkOne_Bpts { get; set; }
            public string GPS_CP_NetworkOne_PerTran { get; set; }
            public string GPS_CP_Pules_PerTran { get; set; }
            public string GPS_CP_Pulse_Bpts { get; set; }
            public string GPS_CP_Quest_Bpts { get; set; }
            public string GPS_CP_Quest_PerTran { get; set; }
            public string GPS_CP_SCS_Bpts { get; set; }
            public string GPS_CP_SCS_PerTran { get; set; }
            public string PT_CP_AccelExch_Bpts { get; set; }
            public string PT_CP_AccelExch_PerTran { get; set; }
            public string PT_CP_AFFN_Bpts { get; set; }
            public string PT_CP_AFFN_PerTran { get; set; }
            public string PT_CP_AlaskaOp_Bpts { get; set; }
            public string PT_CP_AlaskaOp_PerTran { get; set; }
            public string PT_CP_CU24_Bpts { get; set; }
            public string PT_CP_CU24_PerTran { get; set; }
            public string PT_CP_EBT_Bpts { get; set; }
            public string PT_CP_EBT_PerTran { get; set; }
            public string PT_CP_Interlink_Bpts { get; set; }
            public string PT_CP_Interlink_PerTran { get; set; }
            public string PT_CP_Jeanie_Bpts { get; set; }
            public string PT_CP_Jeanie_PerTran { get; set; }
            public string PT_CP_Maestro_Bpts { get; set; }
            public string PT_CP_Maestro_PerTran { get; set; }
            public string PT_CP_NYCE_Bpts { get; set; }
            public string PT_CP_NYCE_PerTran { get; set; }
            public string PT_CP_Pulse_Bpts { get; set; }
            public string PT_CP_Pulse_PerTran { get; set; }
            public string PT_CP_Shazam_Bpts { get; set; }
            public string PT_CP_Shazam_PerTran { get; set; }
            public string PT_CP_Star_Bpts { get; set; }
            public string PT_CP_Star_PerTran { get; set; }
            public string TSYS_CP_AccelExch_Bpts { get; set; }
            public string TSYS_CP_AccelExch_PerTran { get; set; }
            public string TSYS_CP_AFFN_Bpts { get; set; }
            public string TSYS_CP_AFFN_PerTran { get; set; }
            public string TSYS_CP_AlaskaOp_Bpts { get; set; }
            public string TSYS_CP_AlaskaOp_PerTran { get; set; }
            public string TSYS_CP_EBT_Bpts { get; set; }
            public string TSYS_CP_EBT_PerTran { get; set; }
            public string TSYS_CP_Interlink_Bpts { get; set; }
            public string TSYS_CP_Interlink_PerTran { get; set; }
            public string TSYS_CP_Maestro_Bpts { get; set; }
            public string TSYS_CP_Maestro_PerTran { get; set; }
            public string TSYS_CP_NYCE_Bpts { get; set; }
            public string TSYS_CP_NYCE_PerTran { get; set; }
            public string TSYS_CP_Pulse_Bpts { get; set; }
            public string TSYS_CP_Pulse_PerTran { get; set; }
            public string TSYS_CP_Shazam_Bpts { get; set; }
            public string TSYS_CP_Shazam_PerTran { get; set; }
            public string TSYS_CP_Star_Bpts { get; set; }
            public string TSYS_CP_Star_PerTran { get; set; }

        }

        public class FlexFee
        {
            public string Fee { get; set; }
            public string MiscDesc { get; set; }
            public string TranCode { get; set; }
            public string TranDesc { get; set; }
        }

        public class Mrch
        {
            public string Acct1Type { get; set; }
            public string Acct2Type { get; set; }
            public string ACHAdj { get; set; }
            public string ACHDelay { get; set; }
            public string AssocNo { get; set; }
            public string AuthCenter { get; set; }
            public string AuthTypeCode { get; set; }
            public string BusOrg { get; set; }
            public string CbkDestInd { get; set; }
            public string CellNo { get; set; }
            public string ChainYN { get; set; }
            public string ChargeOffDate { get; set; }
            public string ChargeOffFlag { get; set; }
            public string CharityID { get; set; }
            public string CloseDate { get; set; }
            public string CloseReason { get; set; }
            public string CombACH { get; set; }
            public string Contact { get; set; }
            public string CorpAddr { get; set; }
            public string CorpCity { get; set; }
            public string CorpFax { get; set; }
            public string CorpMID { get; set; }
            public string CorpName { get; set; }
            public string CorpPhone { get; set; }
            public string CorpState { get; set; }
            public string CorpZip { get; set; }
            public string CPStatus { get; set; }
            public string CustServPhone { get; set; }
            public string DBAaddr { get; set; }
            public string DBACity { get; set; }
            public string DBACountry { get; set; }
            public string DBAFax { get; set; }
            public string DBAName { get; set; }
            public string DBAPhone { get; set; }
            public string DBAState { get; set; }
            public string DBAZip { get; set; }
            public string DDA { get; set; }
            public string DealerID { get; set; }
            public string DebitCPStatus { get; set; }
            public string DiscountType { get; set; }
            public string DuesAssessments { get; set; }
            public string EMailAddr { get; set; }
            public string EnhancedCost { get; set; }
            public string FeeDDA { get; set; }
            public string FeeTR { get; set; }
            public string HoldFlg { get; set; }
            public string InterchangePlan { get; set; }
            public string irsName { get; set; }
            public string irsTaxID { get; set; }
            public string irsType { get; set; }
            public string MCC { get; set; }
            public string MCCNotes { get; set; }
            public string MCCtype { get; set; }
            public string MIDCon { get; set; }
            public string NDF { get; set; }
            public string NetACH { get; set; }
            public string Notes { get; set; }
            public string RetStmtInd { get; set; }
            public string RollResv { get; set; }
            public string RollResvDays { get; set; }
            public string SalesRep { get; set; }
            public string SeasonalFlg { get; set; }
            public string SeasonalMonths { get; set; }
            public string StartDate { get; set; }
            public string StmtDest { get; set; }
            public string StmtInd { get; set; }
            public string StoreNo { get; set; }
            public string TaxableState { get; set; }
            public string TR { get; set; }
            public string Tranzlogic { get; set; }
            public string CreditDDA { get; set; }
            public string CreditTR { get; set; }
            public string CreditAcctType { get; set; }
           public string AcctType { get; set; }
        


    }
        public class NetIDs
        {
            public string Net_ID { get; set; }
        }

        public class OtherFees
        {          
            public string APFRate { get; set; }
            public string DebAuthRate { get; set; }
            public string DiscARURate { get; set; }
            public string DiscAuthRate { get; set; }
            public string DiscDUC { get; set; }
            public string DiscIPF { get; set; }
            public string DiscNAF { get; set; }
            public string DiscVoiceRate { get; set; }
            public string McAcctInqRate { get; set; }
            public string MCARURate { get; set; }
            public string MCAuthRate { get; set; }
            public string McCrossBdr { get; set; }
            public string McCVC2 { get; set; }
            public string McMisuseRate { get; set; }
            public string MCVoiceRate { get; set; }
            public string NABURate { get; set; }
            public string TEARURate { get; set; }
            public string TEAuthRate { get; set; }
            public string TEVoiceRate { get; set; }
            public string VisaAPFDebitRate { get; set; }
            public string VisaARURate { get; set; }
            public string VisaAuthRate { get; set; }
            public string VisaFANFRate { get; set; }
            public string VisaFloorLimitRate { get; set; }
            public string VisaIAFRate { get; set; }
            public string VisaIntegrityRate { get; set; }
            public string VisaISARate { get; set; }
            public string VisaMisuseRate { get; set; }
            public string VisaVoiceRate { get; set; }

        public string AmexDQ { get; set; }
        public string MCLocation { get; set; }
        public string VisaXferRate { get; set; }
        public string AmexAuthRate { get; set; }
        public string AmexVoiceRate { get; set; }
        public string AmexARURate { get; set; }        
        public string AdminAuthRate { get; set; }
        public string AmexNF { get; set; }
        public string AmexNSF { get; set; }
        public string AmexIF { get; set; }

    }

        public class PCIData
        {

            public string DataStorage { get; set; }
            public string DateLevelDetermined { get; set; }
            public string DSEProvider { get; set; }
            public string InitialMRPRegistrationDate { get; set; }
            public string MerchantLevel { get; set; }
            public string MRPRegistrationStatus { get; set; }
            public string OnsiteAuditStatus { get; set; }
            public string OnsiteAuditTargetDate { get; set; }
            public string OnsiteAuditVendor { get; set; }
            public string PayAppVersion { get; set; }
            public string PCICompliant { get; set; }
            public string PCINotes { get; set; }
            public string PCIScanVendor { get; set; }
            public string PCITermType { get; set; }
            public string QuarterlyScanPastDue { get; set; }
            public string RemediationTargetDate { get; set; }
            public string ScanDate { get; set; }
            public string ScanPassed { get; set; }
            public string ScanReceived { get; set; }
            public string SelfAssessmentPassed { get; set; }
            public string SelfAssessmentReceived { get; set; }
            public string SelfAssessmentReceivedDate { get; set; }
            public string SentToScanVendor { get; set; }
            public string TPPPaymentApplication { get; set; }
        }
        public class Risk
        {
            public string AvgTickApv { get; set; }
            public string AvgTickReq { get; set; }
            public string ChargeBackFee { get; set; }
            public string CustServStmtFee { get; set; }
            public string DebitAccessCyberCash { get; set; }
            public string FedTaxNo { get; set; }
            public string HoldReserve { get; set; }
            public string LargeBatch { get; set; }
            public string LargeDupCard { get; set; }
            public string LargePA { get; set; }
            public string LargeRefund { get; set; }
            public string LargeSale { get; set; }
            public string MaxTickKeyEnt { get; set; }
            public string MaxTickSize { get; set; }
            public string MaxTickSwipe { get; set; }
            public string MCA_ID { get; set; }
            public string MCA_Pct { get; set; }
            public string MCAenabled { get; set; }
            public string MicroRisk { get; set; }
            public string MinMonthlyFee { get; set; }
            public string MonthlyVolApv { get; set; }
            public string MonthlyVolReq { get; set; }
            public string NoDupCard { get; set; }
            public string OrigReserve { get; set; }
            public string Owner1Addr { get; set; }
            public string Owner1City { get; set; }
            public string Owner1DLState { get; set; }
            public string Owner1DrvLisc { get; set; }
            public string Owner1First { get; set; }
            public string Owner1Last { get; set; }
            public string Owner1Phone { get; set; }
            public string Owner1SSN { get; set; }
            public string Owner1State { get; set; }
            public string Owner1Zip { get; set; }
            public string Owner2Addr { get; set; }
            public string Owner2City { get; set; }
            public string Owner2DLState { get; set; }
            public string Owner2DrvLisc { get; set; }
            public string Owner2First { get; set; }
            public string Owner2Last { get; set; }
            public string Owner2Phone { get; set; }
            public string Owner2SSN { get; set; }
            public string Owner2State { get; set; }
            public string Owner2Zip { get; set; }
            public string PctAnnualCBRatio { get; set; }
            public string PctBatchOverApp { get; set; }
            public string PctBatchOverHist { get; set; }
            public string PctKeyEntered { get; set; }
            public string PctMonthlyCBRatio { get; set; }
            public string PctTargetResrv { get; set; }
            public string PctTickOverApp { get; set; }
            public string PctTickOverHist { get; set; }
            public string PeakSeasVol { get; set; }
            public string Rating { get; set; }
            public string Reclassifications { get; set; }
            public string RiskRptDetail { get; set; }
            public string StateTaxNo { get; set; }
            public string TaxPayerID { get; set; }
            public string TMFflg { get; set; }
            public string UnmatchedRefund { get; set; }
            public string WirelessEqWarrFee { get; set; }



        }

        public class Term
        {
            public string Connectivity { get; set; }
            public string GateSoftMisc { get; set; }
            public string PCIValReq { get; set; }
            public string POSDevType { get; set; }
            public string TerminalType { get; set; }
            public string TID { get; set; }
        }

    }


