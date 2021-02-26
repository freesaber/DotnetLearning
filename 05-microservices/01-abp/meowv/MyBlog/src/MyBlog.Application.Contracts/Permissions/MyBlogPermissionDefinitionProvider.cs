using MyBlog.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyBlog.Permissions
{
    public class MyBlogPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MyBlogPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(MyBlogPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MyBlogResource>(name);
        }
    }
}
