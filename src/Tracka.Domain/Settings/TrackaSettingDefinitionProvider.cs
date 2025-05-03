using Volo.Abp.Settings;

namespace Tracka.Settings;

public class TrackaSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TrackaSettings.MySetting1));
    }
}
