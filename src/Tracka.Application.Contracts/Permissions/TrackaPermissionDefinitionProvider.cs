using Tracka.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Tracka.Permissions;

public class TrackaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TrackaPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(TrackaPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(TrackaPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(TrackaPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(TrackaPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TrackaPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TrackaResource>(name);
    }
}
