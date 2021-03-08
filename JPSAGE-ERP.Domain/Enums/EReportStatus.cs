using System.ComponentModel;

namespace JPSAGE_ERP.Domain.Enums
{
    public enum EReportStatus
    {
        [Description("Open")]
        OPEN,

        [Description("Query")]
        QUERY,

        [Description("Approved")]
        APPROVED,

        [Description("Rejected")]
        REJECTED
    }
}
