using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace TMTech.AWS.WcfService
{
    // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
    [ServiceContract]
    public interface IServiceAWS
    {


        // TODO: Add your service operations here
        //[OperationContract]
        //DataSet  GetSQLServerList();

        [OperationContract]
        string[] GetSQLServerList();

        [OperationContract]
        string[] GetSQLServerListByType(string serverType);

        [OperationContract]
        DataSet GetCendantList();

        [OperationContract]
        DataSet GetActiveCendantList();

        [OperationContract]
        DataSet GetLOBList();

        [OperationContract]
        DataSet GetRiskIDList();

        [OperationContract]
        DataSet GetPerilList();

        [OperationContract]
        DataSet GetRegionList();

        [OperationContract]
        DataSet GetSnPList();

        [OperationContract]
        DataSet GetTMRRiskRegionWeightList();

        [OperationContract]
        DataSet GetAdditionalPersCodes();

        [OperationContract]
        DataSet GetProprietaryModels();

        [OperationContract]
        ArrayList GetRDMList(String svr);

        [OperationContract]
        ArrayList GetDatabaseNames(String svr, string type);

        [OperationContract]
        DataSet GetRMSAnalysisList(string svr, string rdm, int level);

        [OperationContract]
        DataSet GetAnalysisListByType(string serverName, string dbName, string type);

        [OperationContract]
        AnalysisParameter[] GetAnalysisListBySubmission(string sid);

        [OperationContract]
        AnalysisParameter GetAnalysisByID(Int32 aid);

        [OperationContract]
        CedantParameter GetCendantDataById(string cid);

        [OperationContract]
        void LoadAnalysis(AnalysisParameter ap);

        [OperationContract]
        void LoadCBAnalysis(AnalysisParameter ap);

        [OperationContract]
        AnalysisParameter CreateAnalysis(AnalysisParameter ap);

        [OperationContract]
        AnalysisParameter UpdateAnalysis(AnalysisParameter ap);

        [OperationContract]
        long DeleteAnalysis(Int32 AnalysisID, string UserModified, long LastVersion);

        [OperationContract]
        void UpdateOrInsertCendantData(CedantParameter cp);

        [OperationContract]
        void UpdateOrInsertSubmissionInfo(SubmissionParameter sp);

        //[OperationContract]
        //AnalysisParameter ProbeUSHUSubRegionModelWeights(AnalysisParameter ap);

        //[OperationContract]
        //AnalysisParameter ProbeNonUSHURMSRegionModelWeights(AnalysisParameter ap);


        //[OperationContract]
        //AnalysisParameter ProbeEUWSRMSRegionModelWeights(AnalysisParameter ap);

        [OperationContract]
        AnalysisParameter ProbeRegionModelWeightsByRMS(AnalysisParameter ap);

        [OperationContract]
        AnalysisParameter ProbeRegionModelWeightsByAIR(AnalysisParameter ap);

        [OperationContract]
        AnalysisParameter ProbeAnlsIdentifiers(AnalysisParameter ap);

        //[OperationContract]
        //DataSetVendorLossData GetVendorLossData(int anlsID, VendorLossType vlt);

        //[OperationContract]
        //DataSetVendorLossData GetVendorLossDataShort(int anlsID, VendorLossType vlt);

        //[OperationContract]
        //DataSetVendorLossData GetAvailableEPCurves(int anlsID);

        [OperationContract]
        DataSet GetAALsByAnlsID(int anlsID);

        [OperationContract]
        void BlendAnalysis(AnalysisParameter ap, double lossAdjustFactor, double freqAdjustFactor);

        [OperationContract]
        string Blend(int anlsID);

        [OperationContract]
        void SaveEPCurvesToAdj(AnalysisParameter ap);

        [OperationContract]
        bool AnalysisNameExist(string anlsName);

        [OperationContract]
        void ExportAnalysisByName(string anlsName, string submissionName, string submissionID);

        [OperationContract]
        bool ValidateUser(string UserName, string Password);
        [OperationContract]
        bool HasBlendedIEP(int anlsID);
        [OperationContract]
        void LogError(byte[] exc);
        [OperationContract]
        string GetRGConnStr();
        [OperationContract]
        string GetServiceAWS_BConnStr();
        [OperationContract]
        string GetAWS_DBConnStr();
        [OperationContract]
        string[] GetAdditionalPercCodeByRMSAnlsID(string svr, string rdm, int anlsID, int level);
        [OperationContract]
        DataSet GetCERT_GroupBySubmission(string submissionID);
        [OperationContract]
        string BlendCERT(int certID);
        //02/13/2013 htao: Get RegionPerilList
        [OperationContract]
        DataSet GetRegionPerilList();
        [OperationContract]
        DataSet GetTMROWLayerInfoByG4RIProgramMasterKey(String G4RIID);

        //03/07/2013 htao:Update EDM data to Data warehouse through AWS
        [OperationContract]
        DataSet GetEDMListByRDMName(String[] rmsservernames, String[] tmrrdmnames, string[] brokerrdmnames);
        [OperationContract]
        void UpLoadEDMDataToDataWarehouse(String[] rmsservername, String[] tmrrdmnames, string[] brokerrdmnames, int[] anlsIDs);

        //03/011/2013 htao:Get treatyID/treatyname list assuming both Server and RDM DB are specified
        [OperationContract]
        DataSet GetTreatyNames(String rmsservername, String tmrrdmname, int rdmanlsid );

        //03/014/2013 htao: Get EQE PortfolioNames/PortfolioID list if have a given combo of EQE server and EQE DBNAME
        [OperationContract]
        DataSet GetEQEAnalysisNumber(String eqedbname);

        [OperationContract]
        ArrayList GetEQEList();

        //Called by TMROW to retrieve raw unblended curves
        //[OperationContract]
        //DataSet GetLossCurve(int anlsID, CurveType type, double threshold);

        //Called by TMROW to retrieve blended curves
        [OperationContract]
        DataSet GetBlendedLossCurve(int anlsID, double w_rms, double w_air, double w_eqe, bool useCert, double threshold);

        [OperationContract]
        Boolean IsDataWarehouseDBReady();

        /// <summary>Create a new analysis by duplicating from existing one.</summary>
        /// <param name="BasedAnalysisID">source analysis ID to copy from</param>
        /// <param name="NewName">name of new analysis</param>
        /// <param name="NewSubmissionID">submission ID of new analysis</param>
        /// <param name="CustomRiskName">custom risk name of new analysis</param>
        /// <param name="UserModified">user name</param>
        /// <param name="LastAdjusted">date time of last adjusted</param>
        /// <param name="LastBlended">date time of last blended</param>
        /// <param name="IsCreatedDomesticMacro">indicator of Domestic Macro Analysis</param>
        /// <returns>new analysis ID</returns>
        [OperationContract]
        Int32 CopyAnalysisByID(Int32 BasedAnalysisID, string NewName, string NewSubmissionID, string CustomRiskName, 
                              string UserModified, DateTime LastAdjusted, DateTime LastBlended,Boolean IsCreatedDomesticMacro);

        [OperationContract]
        bool[] CheckModelCurrencyIsConsistent(int anlsid, ref string[] TMRCurs,ref string[] BrokerCurs);

        /// <summary>
        /// Get risk adjustments UI display infor 
        /// </summary>
        /// <param name="TMROWOrExcel">0 return both TMROW and excel data, 1 return TMROW data only, 2 return excel data only</param>
        /// <returns>a data table contains risk adjustment UI displaying fields</returns>
        /// <remarks></remarks>
        [OperationContract]
        DataSet GetAnalysisRiskAdjustmentFields(int TMROWOrExcel = 0);
    }
}


