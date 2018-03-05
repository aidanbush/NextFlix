using System;
using System.IO;
using System.Text;

namespace App
{
    internal static class DBEnvironment
    {
        public static string connectionString;

        public static void ConnectToDB()
        {
            getConnectionString();
            Console.Out.WriteLine(connectionString);
        }

        private static void getConnectionString()
        {
            System.IO.StreamReader fs = new System.IO.StreamReader(@".\conn.txt");
            connectionString = fs.ReadLine();
        }
    }
}