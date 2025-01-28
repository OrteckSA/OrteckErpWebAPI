using ERP_Integration.Domain.Entity.Integration;
using ERP_Integration.Domain.Enums.Integration;

namespace ERP_Integration.Domain.Services.Erp
{
    public interface IErpCommonService
    {
        Setting GetSetting(List<Setting> integrationSettings, SettingsEnum settingEnum, List<string> errors);
        string GetSetting(SettingsEnum settingEnum);
    }
}
