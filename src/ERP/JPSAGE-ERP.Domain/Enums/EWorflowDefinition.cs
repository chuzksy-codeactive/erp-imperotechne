using System.ComponentModel;

namespace JPSAGE_ERP.Domain.Enums
{
    public enum EWorflowDefinition
    {
        [Description("GeneralSummary")]
        GENERALSUMMARY = 1,

        [Description("HSEReport")]
        HSEREPORT = 2,

        [Description("OtherSite")]
        OTHERSITE = 3,

        [Description("ProgessPictures")]
        PROGRESSPICTURES = 4,

        [Description("ConstructionTechnicalQuery")]
        CONSTRUCTIONTECHNICALQUERY = 5,

        [Description("NonConformanceReport")]
        NONCONFORMANCEREPORT = 6,

        [Description("ConstructionActivity")]
        CONSTRUCTIONACTIVITY = 7,

        [Description("DailyPgMeasurement")]
        DAILYPGMEASUREMENT = 8
    }
}
