using prjPointOfSalesSystem;

namespace prjPointOfSalesSystem
{
    public class Account : IAccount
    {
        public int userid { get; set; } = 0;
        public string username { get; set; } = "";
        public string password { get; set; } = "";
        public string firstname { get; set; } = "";
        public string lastname { get; set; } = "";
        public string email { get; set; } = "";
        public string contact { get; set; } = "";

    }
}
