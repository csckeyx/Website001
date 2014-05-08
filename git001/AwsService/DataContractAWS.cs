using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
namespace TMTech.AWS.WcfService
{
    [DataContract]
    public class AnalysisParameter_RMS
    {
        string serverName;
        string dbName;
        int analysisID;
        int analysisLevel;//1 port level; 0 account level
        string[] additionalPerspCodes;
        string analysisName;
        int treatyID;
        string treatyname;

        [DataMember]
        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }
        [DataMember]
        public string DBName
        {
            get { return dbName; }
            set { dbName = value; }
        }
        [DataMember]
        public string AnalysisName
        {
            get { return analysisName; }
            set { analysisName = value; }
        }
        [DataMember]
        public int AnalysisID
        {
            get { return analysisID; }
            set { analysisID = value; }
        }
        [DataMember]
        public int AnalysisLevel
        {
            get { return analysisLevel; }
            set { analysisLevel = value; }
        }
        [DataMember]
        public string[] AdditionalPerspCodes
        {
            get { return additionalPerspCodes; }
            set { additionalPerspCodes = value; }
        }
        [DataMember]
        public int TreatyID
        {
            get { return treatyID; }
            set { treatyID = value; }
        }
        [DataMember]
        public string TreatyName
        {
            get { return treatyname; }
            set { treatyname = value; }
        }

    }
    [DataContract]
    public class AnalysisParameter_AIR
    {
        string epPath;
        string eltPath;
        string perspCode;
        string serverName;
        string dbName;
        string resultsSetID;
        string resultsSetName;

        [DataMember]
        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }
        [DataMember]
        public string DBName
        {
            get { return dbName; }
            set { dbName = value; }
        }
        [DataMember]
        public string ResultsSetName
        {
            get { return resultsSetName; }
            set { resultsSetName = value; }
        }
        [DataMember]
        public string ResultsSetID
        {
            get { return resultsSetID; }
            set { resultsSetID = value; }
        }
        [DataMember]
        public string PerspCode
        {
            get { return perspCode; }
            set { perspCode = value; }
        }

        [DataMember]
        public string EPPath
        {
            get { return epPath; }
            set { epPath = value; }
        }
        [DataMember]
        public string ELTPath
        {
            get { return eltPath; }
            set { eltPath = value; }
        }
    }
    [DataContract]
    public class AnalysisParameter_ProprietaryEP
    {
        int modelid;
        string epPath;
        string epFileType;
        string aepLossColName;
        string oepLossColName;
        string epColName;
        string tableorsheetname;

        [DataMember]
        public int Modelid
        {
            get { return modelid; }
            set { modelid = value; }
        }
        [DataMember]
        public string EPPath
        {
            get { return epPath; }
            set { epPath = value; }
        }
        [DataMember]
        public string EpFileType
        {
            get { return epFileType; }
            set { epFileType = value; }
        }
        [DataMember]
        public string AepLossColName
        {
            get { return aepLossColName; }
            set { aepLossColName = value; }
        }
        [DataMember]
        public string OepLossColName
        {
            get { return oepLossColName; }
            set { oepLossColName = value; }
        }
        [DataMember]
        public string EpColName
        {
            get { return epColName; }
            set { epColName = value; }
        }
        [DataMember]
        public string Tableorsheetname
        {
            get { return tableorsheetname; }
            set { tableorsheetname = value; }
        }

    }
    [DataContract]
    public class AnalysisParameter_ProprietaryELT
    {
        int modelid;
        string eltPath;
        string eltFileType;
        string eventidColName;
        string tmrnetlossColName;
        string freqColName;
        string stddevColName;
        string descColName;
        string tableorsheetname;



        [DataMember]
        public int Modelid
        {
            get { return modelid; }
            set { modelid = value; }
        }
        [DataMember]
        public string EventidColName
        {
            get { return eventidColName; }
            set { eventidColName = value; }
        }
        [DataMember]
        public string TmrnetlossColName
        {
            get { return tmrnetlossColName; }
            set { tmrnetlossColName = value; }
        }
        [DataMember]
        public string FreqColName
        {
            get { return freqColName; }
            set { freqColName = value; }
        }
        [DataMember]
        public string StddevColName
        {
            get { return stddevColName; }
            set { stddevColName = value; }
        }
        [DataMember]
        public string DescColName
        {
            get { return descColName; }
            set { descColName = value; }
        }
        [DataMember]
        public string ELTPath
        {
            get { return eltPath; }
            set { eltPath = value; }
        }
        [DataMember]
        public string EltFileType
        {
            get { return eltFileType; }
            set { eltFileType = value; }
        }
        [DataMember]
        public string Tableorsheetname
        {
            get { return tableorsheetname; }
            set { tableorsheetname = value; }
        }
    }
    [DataContract]
    public class AnalysisParameter_EQE
    {
        string oepPath;
        string aepPath;
        string perspCode;
        
        //03/14/2013: Logic changed into quering RQE sql db instead of reading a flat file
        string eqedbserver;
        string eqedbname;
        int yltid;
        string eqeanalysisname;

        [DataMember]
        public string PerspCode
        {
            get { return perspCode; }
            set { perspCode = value; }
        }
        [DataMember]
        public string OEPPath
        {
            get { return oepPath; }
            set { oepPath = value; }
        }
        [DataMember]
        public string AEPPath
        {
            get { return aepPath; }
            set { aepPath = value; }
        }
        [DataMember]
        public string DBServer
        {
            get { return eqedbserver; }
            set { eqedbserver = value; }
        }

        [DataMember]
        public string DBName
        {
            get { return eqedbname; }
            set { eqedbname = value; }
        }
        [DataMember]
        public int YltID
        {
            get { return yltid; }
            set { yltid = value; }
        }

        [DataMember]
        public string EQEAnalysisName
        {
            get { return eqeanalysisname; }
            set { eqeanalysisname = value; }
        }

    }
    [DataContract]
    public class CedantParameter
    {
        string cendantID;
        [DataMember]
        public string CendantID
        {
            get { return cendantID; }
            set { cendantID = value; }
        }

        string name;
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int lobID;
        [DataMember]
        public int LobID
        {
            get { return lobID; }
            set { lobID = value; }
        }
        double unmodperfact;
        [DataMember]
        public double Unmodperfact
        {
            get { return unmodperfact; }
            set { unmodperfact = value; }
        }
        double uwqualfact;
        [DataMember]
        public double Uwqualfact
        {
            get { return uwqualfact; }
            set { uwqualfact = value; }
        }

        double othercdntfact;
        [DataMember]
        public double Othercdntfact
        {
            get { return othercdntfact; }
            set { othercdntfact = value; }
        }

        Boolean isNew = true;
        [DataMember]
        public Boolean IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        double lae;

        [DataMember]
        public double LAE
        {
            get { return lae; }
            set { lae = value; }
        }


    }
    [DataContract]
    public class SubmissionParameter
    {
        string submissionID;
        [DataMember]
        public string SubmissionID
        {
            get { return submissionID; }
            set { submissionID = value; }
        }

        string submissionname;
        [DataMember]
        public string SubmissionName
        {
            get { return submissionname; }
            set { submissionname = value; }
        }
        string policynumber;
        [DataMember]
        public string Policynumber
        {
            get { return policynumber; }
            set { policynumber = value; }
        }
        string reportfolder;
        [DataMember]
        public string Reportfolder
        {
            get { return reportfolder; }
            set { reportfolder = value; }
        }
        DateTime inceptiondate;
        [DataMember]
        public DateTime Inceptiondate
        {
            get { return inceptiondate; }
            set { inceptiondate = value; }
        }
       

    }
    [DataContract]
    public class AnalysisParameter
    {
        int analysisID;
        string submissionID;
        int snpID;
        string peril;
        int regionid;
        int identifierID;
        int lobID;
        int uwYear;
        string currcode;
        string analysisName;
        string analysisDescription;
        double weightRMS;
        double weightAIR;
        double weightEQE;
        double dRMSModelSpecificAdj;
        double dAIRModelSpecificAdj;
        double dEQEModelSpecificAdj;
        Boolean demandsurgeair;
        Boolean demandsurgeeqe;
        Boolean demandsurgerms;
        Boolean stormsurgeair;
        Boolean stormsurgeeqe;
        Boolean stormsurgerms;
        Boolean timedependair;
        Boolean timedependeqe;
        Boolean timedependrms;
        Boolean scndryunctair;
        Boolean scndryuncteqe;
        Boolean scndryunctrms;
        Boolean ffair;
        Boolean ffeqe;
        Boolean ffrms;
        Boolean slair;
        Boolean sleqe;
        Boolean slrms;
        string unkcdngtrtmt;
        string humanexp;
        string costsevscheme;
        string blendingbasevendor;
        string blendingperspcode;
        string usermodified;
        int certid;
        //02/12/2013: For AWS 1.3 add following 2 parameters
        String customriskname;
        String regionperil;
        //AWS 1.5 add default risk adjustments
        RiskAdjustmentsData riskAdjustmentsData;
        RiskAdjustmentsData riskAdjustmentsComparisonData;

        [DataMember]
        public RiskAdjustmentsData RiskAdjustments
        {
            get { return riskAdjustmentsData; }
            set { riskAdjustmentsData = value; }
        }

        [DataMember]
        public RiskAdjustmentsData RiskAdjustmentsComparison
        {
            get { return riskAdjustmentsComparisonData; }
            set { riskAdjustmentsComparisonData = value; }
        }

        AnalysisMisc analysisMiscDescription;

        [DataMember]
        public AnalysisMisc MiscDescription
        {
            get { return analysisMiscDescription; }
            set { analysisMiscDescription = value; }
        }

        long lastversion;
        [DataMember]
        public long LastVersion
        {
            get { return lastversion; }
            set { lastversion = value; }
        }

        [DataMember]
        public string Usermodified
        {
            get { return usermodified; }
            set { usermodified = value; }
        }

        //string rmsotherperspcodes;
        DateTime lastAdjusted;
        [DataMember]
        public DateTime LastAdjusted
        {
            get { return lastAdjusted; }
            set { lastAdjusted = value; }
        }

        DateTime lastBlended;
        [DataMember]
        public DateTime LastBlended
        {
            get { return lastBlended; }
            set { lastBlended = value; }
        }

        AnalysisParameter_RMS apr;
        AnalysisParameter_AIR apa;
        AnalysisParameter_EQE ape;
        AnalysisParameter_ProprietaryEP appEP;
        [DataMember]
        public AnalysisParameter_ProprietaryEP AppEP
        {
            get { return appEP; }
            set { appEP = value; }
        }
        AnalysisParameter_ProprietaryELT appELT;
        [DataMember]
        public AnalysisParameter_ProprietaryELT AppELT
        {
            get { return appELT; }
            set { appELT = value; }
        }

        AnalysisParameter_RMS apr1;
        [DataMember]
        public AnalysisParameter_RMS Apr1
        {
            get { return apr1; }
            set { apr1 = value; }
        }
        AnalysisParameter_AIR apa1;
        [DataMember]
        public AnalysisParameter_AIR Apa1
        {
            get { return apa1; }
            set { apa1 = value; }
        }
        AnalysisParameter_EQE ape1;
        [DataMember]
        public AnalysisParameter_EQE Ape1
        {
            get { return ape1; }
            set { ape1 = value; }
        }
        AnalysisParameter_ProprietaryEP appEP1;
        [DataMember]
        public AnalysisParameter_ProprietaryEP AppEP1
        {
            get { return appEP1; }
            set { appEP1 = value; }
        }
        AnalysisParameter_ProprietaryELT appELT1;
        [DataMember]
        public AnalysisParameter_ProprietaryELT AppELT1
        {
            get { return appELT1; }
            set { appELT1 = value; }
        }

        AnalysisParameter_RMS apr2;
        [DataMember]
        public AnalysisParameter_RMS Apr2
        {
            get { return apr2; }
            set { apr2 = value; }
        }
        AnalysisParameter_AIR apa2;
        [DataMember]
        public AnalysisParameter_AIR Apa2
        {
            get { return apa2; }
            set { apa2 = value; }
        }
        AnalysisParameter_EQE ape2;
        [DataMember]
        public AnalysisParameter_EQE Ape2
        {
            get { return ape2; }
            set { ape2 = value; }
        }
        AnalysisParameter_ProprietaryEP appEP2;
        [DataMember]
        public AnalysisParameter_ProprietaryEP AppEP2
        {
            get { return appEP2; }
            set { appEP2 = value; }
        }
        AnalysisParameter_ProprietaryELT appELT2;
        [DataMember]
        public AnalysisParameter_ProprietaryELT AppELT2
        {
            get { return appELT2; }
            set { appELT2 = value; }
        }

        AnalysisParameter_RMS apr3;
        [DataMember]
        public AnalysisParameter_RMS Apr3
        {
            get { return apr3; }
            set { apr3 = value; }
        }
        AnalysisParameter_AIR apa3;
        [DataMember]
        public AnalysisParameter_AIR Apa3
        {
            get { return apa3; }
            set { apa3 = value; }
        }
        AnalysisParameter_EQE ape3;
        [DataMember]
        public AnalysisParameter_EQE Ape3
        {
            get { return ape3; }
            set { ape3 = value; }
        }
        AnalysisParameter_ProprietaryEP appEP3;
        [DataMember]
        public AnalysisParameter_ProprietaryEP AppEP3
        {
            get { return appEP3; }
            set { appEP3 = value; }
        }
        AnalysisParameter_ProprietaryELT appELT3;
        [DataMember]
        public AnalysisParameter_ProprietaryELT AppELT3
        {
            get { return appELT3; }
            set { appELT3 = value; }
        }

        [DataMember]
        public string Peril
        {
            get { return peril; }
            set { peril = value; }
        }
        [DataMember]
        public int SnpID
        {
            get { return snpID; }
            set { snpID = value; }
        }
        [DataMember]
        public int Regionid
        {
            get { return regionid; }
            set { regionid = value; }
        }
        [DataMember]
        public int IdentifierID
        {
            get { return identifierID; }
            set { identifierID = value; }
        }
        [DataMember]
        public int LobID
        {
            get { return lobID; }
            set { lobID = value; }
        }
        [DataMember]
        public string Currcode
        {
            get { return currcode; }
            set { currcode = value; }
        }

        [DataMember]
        public double RMSModelSpecificAdj
        {
            get { return dRMSModelSpecificAdj; }
            set { dRMSModelSpecificAdj = value; }
        }

        [DataMember]
        public double AIRModelSpecificAdj
        {
            get { return dAIRModelSpecificAdj; }
            set { dAIRModelSpecificAdj = value; }
        }

        [DataMember]
        public double EQEModelSpecificAdj
        {
            get { return dEQEModelSpecificAdj; }
            set { dEQEModelSpecificAdj = value; }
        }
        
        [DataMember]
        public Boolean Demandsurgeair
        {
            get { return demandsurgeair; }
            set { demandsurgeair = value; }
        }
        [DataMember]
        public Boolean Demandsurgeeqe
        {
            get { return demandsurgeeqe; }
            set { demandsurgeeqe = value; }
        }
        [DataMember]
        public Boolean Demandsurgerms
        {
            get { return demandsurgerms; }
            set { demandsurgerms = value; }
        }
        [DataMember]
        public Boolean Stormsurgeair
        {
            get { return stormsurgeair; }
            set { stormsurgeair = value; }
        }

        [DataMember]
        public Boolean Stormsurgeeqe
        {
            get { return stormsurgeeqe; }
            set { stormsurgeeqe = value; }
        }

        [DataMember]
        public Boolean Stormsurgerms
        {
            get { return stormsurgerms; }
            set { stormsurgerms = value; }
        }

        [DataMember]
        public Boolean Timedependair
        {
            get { return timedependair; }
            set { timedependair = value; }
        }
        [DataMember]
        public Boolean Timedependeqe
        {
            get { return timedependeqe; }
            set { timedependeqe = value; }
        }
        [DataMember]
        public Boolean Timedependrms
        {
            get { return timedependrms; }
            set { timedependrms = value; }
        }
        [DataMember]
        public Boolean Scndryunctair
        {
            get { return scndryunctair; }
            set { scndryunctair = value; }
        }
        [DataMember]
        public Boolean Scndryuncteqe
        {
            get { return scndryuncteqe; }
            set { scndryuncteqe = value; }
        }
        [DataMember]
        public Boolean Scndryunctrms
        {
            get { return scndryunctrms; }
            set { scndryunctrms = value; }
        }
        [DataMember]
        public Boolean Ffair
        {
            get { return ffair; }
            set { ffair = value; }
        }
        [DataMember]
        public Boolean Ffeqe
        {
            get { return ffeqe; }
            set { ffeqe = value; }
        }
        [DataMember]
        public Boolean Ffrms
        {
            get { return ffrms; }
            set { ffrms = value; }
        }
        [DataMember]
        public Boolean Slair
        {
            get { return slair; }
            set { slair = value; }
        }
        [DataMember]
        public Boolean Sleqe
        {
            get { return sleqe; }
            set { sleqe = value; }
        }
        [DataMember]
        public Boolean Slrms
        {
            get { return slrms; }
            set { slrms = value; }
        }
        [DataMember]
        public string Unkcdngtrtmt
        {
            get { return unkcdngtrtmt; }
            set { unkcdngtrtmt = value; }
        }
        [DataMember]
        public string Humanexp
        {
            get { return humanexp; }
            set { humanexp = value; }
        }
        [DataMember]
        public string Costsevscheme
        {
            get { return costsevscheme; }
            set { costsevscheme = value; }
        }
        [DataMember]
        public string Blendingbasevendor
        {
            get { return blendingbasevendor; }
            set { blendingbasevendor = value; }
        }
        [DataMember]
        public string Blendingperspcode
        {
            get { return blendingperspcode; }
            set { blendingperspcode = value; }
        }
        //[DataMember]
        //public string Rmsotherperspcodes
        //{
        //  get { return rmsotherperspcodes; }
        //  set { rmsotherperspcodes = value; }
        //}
        [DataMember]
        public int AnalysisID
        {
            get { return analysisID; }
            set { analysisID = value; }
        }
        [DataMember]
        public string SubmissionID
        {
            get { return submissionID; }
            set { submissionID = value; }
        }
        [DataMember]
        public int UWwYear
        {
            get { return uwYear; }
            set { uwYear = value; }
        }
        [DataMember]
        public double WeightRMS
        {
            get { return weightRMS; }
            set { weightRMS = value; }
        }
        [DataMember]
        public double WeightAIR
        {
            get { return weightAIR; }
            set { weightAIR = value; }
        }
        [DataMember]
        public double WeightEQE
        {
            get { return weightEQE; }
            set { weightEQE = value; }
        }
        [DataMember]
        public string AnalysisName
        {
            get { return analysisName; }
            set { analysisName = value; }
        }
        [DataMember]
        public string AnalysisDescription
        {
            get { return analysisDescription; }
            set { analysisDescription = value; }
        }
        [DataMember]
        public AnalysisParameter_RMS APR
        {
            get { return apr; }
            set { apr = value; }
        }
        [DataMember]
        public AnalysisParameter_AIR APA
        {
            get { return apa; }
            set { apa = value; }
        }
        [DataMember]
        public AnalysisParameter_EQE APE
        {
            get { return ape; }
            set { ape = value; }
        }
        [DataMember]
        public AnalysisParameter_ProprietaryEP APP_EP
        {
            get { return appEP; }
            set { appEP = value; }
        }
        [DataMember]
        public AnalysisParameter_ProprietaryELT APP_ELT
        {
            get { return appELT; }
            set { appELT = value; }
        }
        DataSet tmrBlendedIEP;
        [DataMember]
        public DataSet TMRBlendedIEP
        {
            get { return tmrBlendedIEP; }
            set { tmrBlendedIEP = value; }
        }
        double[] adjustmentfactors;
        [DataMember]
        public double[] AdjustmentFactors
        {
            get { return adjustmentfactors; }
            set { adjustmentfactors = value; }
        }
        double[] adjustmentfactorrps;
        [DataMember]
        public double[] AdjustmentFactorRPs
        {
            get { return adjustmentfactorrps; }
            set { adjustmentfactorrps = value; }
        }

        string businesstype;
        [DataMember]
        public string Businesstype
        {
            get { return businesstype; }
            set { businesstype = value; }
        }
        [DataMember]
        public int CertId
        {
            get { return certid; }
            set { certid = value; }
        }
        [DataMember]
        public string CustomRiskName
        {
            get {return customriskname;}
            set {customriskname = value;}
        }
        [DataMember]
        public string RegionPeril
        {
            get{return regionperil;}
            set{ regionperil = value;}
        }

        #region "Broker curver portion"

        AnalysisParameter_Broker_RMS apbr1;
        [DataMember]
        public AnalysisParameter_Broker_RMS Apbr1
        {
            get { return apbr1; }
            set { apbr1 = value; }
        }
        AnalysisParameter_Broker_AIR apba1;
        [DataMember]
        public AnalysisParameter_Broker_AIR Apba1
        {
            get { return apba1; }
            set { apba1 = value; }
        }
        AnalysisParameter_Broker_EQE apbe1;
        [DataMember]
        public AnalysisParameter_Broker_EQE Apbe1
        {
            get { return apbe1; }
            set { apbe1 = value; }
        }

        #endregion
        ComparisonAnalysisParameter ca1;
        [DataMember]
        public ComparisonAnalysisParameter CA1
        {
            get { return ca1; }
            set { ca1 = value; }
        }
   
    }

    #region Broker curve portion
     [DataContract]
    public class AnalysisParameter_Broker_AIR : AnalysisParameter_AIR
    {
    }
     [DataContract]
    public class AnalysisParameter_Broker_EQE : AnalysisParameter_EQE
    {
    }
     [DataContract]
    public class AnalysisParameter_Broker_RMS : AnalysisParameter_RMS
    {
    }
    #endregion
#region Comparison AnalysisParameter
     [DataContract]
     public class ComparisonAnalysisParameter   //Comparison analysis parameters
     {    
         int analysisID;
         int comparisonanalysismode;
         string cedant;
         string submissionname;
         string submissionid;
         string analysisname;
         string workbookname;
         string worksheetname;
         Boolean isupdateAWS;
         string cedantid;
         int refanalysisid;

         double dRMSModelSpecificAdj;
         double dAIRModelSpecificAdj;
         double dEQEModelSpecificAdj;

         string riskAdjustmentsWorkBookName;
         string riskAdjustmentsWorkSheetName;

         ComparisonAnalysisParameter_Data capa;

         [DataMember]
         public int AnalysisID
         {
             get { return analysisID; }
             set { analysisID = value; }
         }

         [DataMember]
         public int ComparsionAnalysisMode
         {
             get { return comparisonanalysismode; }
             set { comparisonanalysismode = value; }
         }
         [DataMember]
         public string Cedant
         {
             get { return cedant; }
             set { cedant= value; }
         }
         [DataMember]
         public string SubmssionName
         {
             get { return submissionname; }
             set { submissionname = value; }
         }
         [DataMember]
         public string SubmissionID
         {
             get { return submissionid; }
             set { submissionid = value; }
         }
         [DataMember]
         public string AnalysisName
         {
             get { return analysisname; }
             set { analysisname = value; }
         }
         [DataMember]
         public string WorkBookName
         {
             get { return workbookname; }
             set { workbookname= value; }
         }

         [DataMember]
         public string WorkSheetName
         {
             get { return worksheetname; }
             set { worksheetname = value; }
         }

         [DataMember]
         public string RiskAdjustmentsWorkBookName
         {
             get { return riskAdjustmentsWorkBookName; }
             set { riskAdjustmentsWorkBookName = value; }
         }

         [DataMember]
         public string RiskAdjustmentsWorkSheetName
         {
             get { return riskAdjustmentsWorkSheetName; }
             set { riskAdjustmentsWorkSheetName = value; }
         }

         [DataMember]
         public Boolean IsUpdateAWS
         {
             get { return isupdateAWS; }
             set { isupdateAWS = value; }
         }

         [DataMember]
         public double RMSModelSpecificAdj
         {
             get { return dRMSModelSpecificAdj; }
             set { dRMSModelSpecificAdj = value; }
         }

         [DataMember]
         public double AIRModelSpecificAdj
         {
             get { return dAIRModelSpecificAdj; }
             set { dAIRModelSpecificAdj = value; }
         }

         [DataMember]
         public double EQEModelSpecificAdj
         {
             get { return dEQEModelSpecificAdj; }
             set { dEQEModelSpecificAdj = value; }
         }

         [DataMember]
         public ComparisonAnalysisParameter_Data CAPA
         {
             get { return capa; }
             set { capa = value; }
         }

         [DataMember]
         public string CedantID
         {
             get { return cedantid; }
             set { cedantid = value; }
         }
         [DataMember]
         public int RefANLSID
         {
             get { return refanalysisid; }
             set { refanalysisid = value; }
         }
     }
    [DataContract]
     public class ComparisonAnalysisParameter_Data
     {
         string[] ep;      //Data inside AWS is the ones after interpretation that has fixed 27 rows
         string[] rmsloss;
         string[] airloss;
         string[] eqeloss;
        
         [DataMember]
         public string[] EP
         {
             get { return ep; }
             set { ep = value; }
         }

         [DataMember]
         public string[] RMSLoss
         {
             get { return rmsloss; }
             set { rmsloss = value; }
         }
         [DataMember]
         public string[] AIRLoss
         {
             get { return airloss; }
             set { airloss = value; }
         }
         [DataMember]
         public string[] EQELoss
         {
             get { return eqeloss; }
             set { eqeloss = value; }
         }
     }

    [DataContract]
    public class RiskAdjustmentsData
    {
        double _COC;
        double _LAE;
        double _EQCLUSTER;

        double dMulActualCashValue;
        double dMulAtmosphericClustering;
        double dMulBrokerModel;
        double dMulCostOfConstruction;
        double dCropHail;
        double dMulDataCapture;
        double dMulDataQuality;
        double dMulGrowth;
        double dMulHoursClause;
        double dMulInsuranceToValue;
        double dMulLossAdjustmentExpense;
        double dMulMiscellaneous;
        double dMulModelUpdateCalibration;
        double dMulProgramComplexity;
        double dMulResidualMarket;
        double dMulTimeDependencyStressTransfer;
        double dMulUnmodeledRisk;
        double dMCO;

        //DB row version for tracking updates
        long lLastVersion;

        [DataMember]
        public double COC
        {
            get { return _COC; }
            set { _COC = value; }
        }

        [DataMember]
        public double LAE
        {
            get { return _LAE; }
            set { _LAE = value; }
        }

        [DataMember]
        public double EQCLUSTER
        {
            get { return _EQCLUSTER; }
            set { _EQCLUSTER = value; }
        }

        [DataMember]
        public long LastVersion
        {
            get { return lLastVersion; }
            set { lLastVersion = value; }
        }

        [DataMember]
        public double MulActualCashValue
        {
            get { return dMulActualCashValue; }
            set { dMulActualCashValue = value; }
        }
        [DataMember]
        public double MulAtmosphericClustering
        {
            get { return dMulAtmosphericClustering; }
            set { dMulAtmosphericClustering = value; }
        }
        [DataMember]
        public double MulBrokerModel
        {
            get { return dMulBrokerModel; }
            set { dMulBrokerModel = value; }
        }
        [DataMember]
        public double MulCostOfConstruction
        {
            get { return dMulCostOfConstruction; }
            set { dMulCostOfConstruction = value; }
        }
        [DataMember]
        public double CropHail
        {
            get { return dCropHail; }
            set { dCropHail = value; }
        }
        [DataMember]
        public double MulDataCapture
        {
            get { return dMulDataCapture; }
            set { dMulDataCapture = value; }
        }
        [DataMember]
        public double MulDataQuality
        {
            get { return dMulDataQuality; }
            set { dMulDataQuality = value; }
        }
        [DataMember]
        public double MulGrowth
        {
            get { return dMulGrowth; }
            set { dMulGrowth = value; }
        }
        [DataMember]
        public double MulHoursClause
        {
            get { return dMulHoursClause; }
            set { dMulHoursClause = value; }
        }
        [DataMember]
        public double MulInsuranceToValue
        {
            get { return dMulInsuranceToValue; }
            set { dMulInsuranceToValue = value; }
        }

        [DataMember]
        public double MulLossAdjustmentExpense
        {
            get { return dMulLossAdjustmentExpense; }
            set { dMulLossAdjustmentExpense = value; }
        }

        [DataMember]
        public double MulMiscellaneous
        {
            get { return dMulMiscellaneous; }
            set { dMulMiscellaneous = value; }
        }

        [DataMember]
        public double MulModelUpdateCalibration
        {
            get { return dMulModelUpdateCalibration; }
            set { dMulModelUpdateCalibration = value; }
        }

        [DataMember]
        public double MulProgramComplexity
        {
            get { return dMulProgramComplexity; }
            set { dMulProgramComplexity = value; }
        }

        [DataMember]
        public double MulResidualMarket
        {
            get { return dMulResidualMarket; }
            set { dMulResidualMarket = value; }
        }

        [DataMember]
        public double MulTimeDependencyStressTransfer
        {
            get { return dMulTimeDependencyStressTransfer; }
            set { dMulTimeDependencyStressTransfer = value; }
        }

        [DataMember]
        public double MulUnmodeledRisk
        {
            get { return dMulUnmodeledRisk; }
            set { dMulUnmodeledRisk = value; }
        }

        [DataMember]
        public double MCO
        {
            get { return dMCO; }
            set { dMCO = value; }
        }
    }

    [DataContract]
    public class AnalysisMisc
    {
        string strName;
        string strValue;      

        //DB row version for tracking updates
        long lLastVersion;

        [DataMember]
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        [DataMember]
        public string Value
        {
            get { return strValue; }
            set { strValue = value; }
        }

        [DataMember]
        public long LastVersion
        {
            get { return lLastVersion; }
            set { lLastVersion = value; }
        }
    }

#endregion

}