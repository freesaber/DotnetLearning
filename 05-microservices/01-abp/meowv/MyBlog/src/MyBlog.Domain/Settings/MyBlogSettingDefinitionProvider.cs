using Volo.Abp.Settings;

namespace MyBlog.Settings
{
    public class MyBlogSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MyBlogSettings.MySetting1));
        }
    }
}
