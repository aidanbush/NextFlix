using System.Data.SqlClient;

namespace App
{
    public interface IQuery
    {
        bool Add(SqlConnection con);
        bool Edit(SqlConnection con);
        bool Delete(SqlConnection con);
    }  
    
    
}