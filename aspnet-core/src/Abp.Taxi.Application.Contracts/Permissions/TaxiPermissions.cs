namespace Abp.Taxi.Permissions;

public static class TaxiPermissions
{
    public const string GroupName = "Taxi";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public static class Passengers
    {
        public const string Default = GroupName + ".Passengers";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    public static class Cars
    {
        public const string Default = GroupName + ".Cars";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    public static class Manufacturers
    {
        public const string Default = GroupName + ".Manufacturers";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
