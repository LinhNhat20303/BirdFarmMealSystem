using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.Utils;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace DevExpress.DentalClinic.Services
{
    public class PrintReportService : IConnectionProviderService
    {

        SqlDataConnection IConnectionProviderService.LoadConnection(string connectionName)
        {
            var dbPath = DBPathHelper.EnsureWriteable(Application.StartupPath, "Data\\DentalCabinet.db");
            return new SqlDataConnection("dental", new SQLiteConnectionParameters(dbPath, string.Empty));
        }
    }
}
