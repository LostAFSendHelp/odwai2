namespace ODWai2.ODWaiCore.Controllers
{
    public class Helper
    {
        public static string get_path_argument(string raw_string)
        {
            return "\"" + raw_string.Replace("\\", "/") + "\"";
        }
    }
}
