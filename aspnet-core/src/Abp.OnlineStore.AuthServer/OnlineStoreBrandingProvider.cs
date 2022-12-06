using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abp.OnlineStore;

[Dependency(ReplaceServices = true)]
public class OnlineStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "OnlineStore";
}
