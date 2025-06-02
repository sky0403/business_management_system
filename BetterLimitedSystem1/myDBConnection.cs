using MySql.Data.MySqlClient;

namespace BetterLimitedSystem1
{
    class myDBConnection
    {
        public MySqlConnection cn;
        public void Connect()
        {
            cn = new MySqlConnection("datasource = localhost;port=3307; username = root; password = ; database = betterlimited");
        }

    }
}
