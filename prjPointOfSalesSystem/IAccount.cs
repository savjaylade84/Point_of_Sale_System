namespace prjPointOfSalesSystem
{
    public interface IAccount
    {
        string contact { get; set; }
        string email { get; set; }
        string firstname { get; set; }
        string lastname { get; set; }
        string password { get; set; }
        int userid { get; set; }
        string username { get; set; }
    }
}