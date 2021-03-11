namespace JPSAGE_ERP.Application.Services
{
    public interface IEmailTemplate
    {
        string GetEmailTemplate(string link, string htmlPath, string username, string password, string name);
    }
}
