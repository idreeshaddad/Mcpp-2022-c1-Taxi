using Abp.Taxi.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Taxi.Permissions;

public class TaxiPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TaxiPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TaxiPermissions.MyPermission1, L("Permission:MyPermission1"));

        var booksPermission = myGroup.AddPermission(TaxiPermissions.Passengers.Default, L("Permission:Passengers"));
        booksPermission.AddChild(TaxiPermissions.Passengers.Create, L("Permission:Passengers.Create"));
        booksPermission.AddChild(TaxiPermissions.Passengers.Edit, L("Permission:Passengers.Edit"));
        booksPermission.AddChild(TaxiPermissions.Passengers.Delete, L("Permission:Passengers.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TaxiResource>(name);
    }
}
