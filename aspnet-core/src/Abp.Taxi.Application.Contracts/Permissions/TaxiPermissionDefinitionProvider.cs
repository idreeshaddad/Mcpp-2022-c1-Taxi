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

        var passengerPermission = myGroup.AddPermission(TaxiPermissions.Passengers.Default, L("Permission:Passengers"));
        passengerPermission.AddChild(TaxiPermissions.Passengers.Create, L("Permission:Passengers.Create"));
        passengerPermission.AddChild(TaxiPermissions.Passengers.Edit, L("Permission:Passengers.Edit"));
        passengerPermission.AddChild(TaxiPermissions.Passengers.Delete, L("Permission:Passengers.Delete"));

        var carPermission = myGroup.AddPermission(TaxiPermissions.Cars.Default, L("Permission:Cars"));
        carPermission.AddChild(TaxiPermissions.Cars.Create, L("Permission:Cars.Create"));
        carPermission.AddChild(TaxiPermissions.Cars.Edit, L("Permission:Cars.Edit"));
        carPermission.AddChild(TaxiPermissions.Cars.Delete, L("Permission:Cars.Delete"));

        var ManufacturerPermission = myGroup.AddPermission(TaxiPermissions.Manufacturers.Default, L("Permission:Manufacturers"));
        ManufacturerPermission.AddChild(TaxiPermissions.Manufacturers.Create, L("Permission:Manufacturers.Create"));
        ManufacturerPermission.AddChild(TaxiPermissions.Manufacturers.Edit, L("Permission:Manufacturers.Edit"));
        ManufacturerPermission.AddChild(TaxiPermissions.Manufacturers.Delete, L("Permission:Manufacturers.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TaxiResource>(name);
    }
}
