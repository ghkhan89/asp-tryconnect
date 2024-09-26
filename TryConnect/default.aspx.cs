using System;
using System.Data.SqlClient;
using System.Text;

namespace TryConnect
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnTryConnect_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                if (ConString.Text != "")
                {
                    var connection = new SqlConnection(ConString.Text.ToString());
                    connection.Open();

                    var sql = "SELECT SERVERPROPERTY('MachineName') AS 'MachineName', SERVERPROPERTY('Edition') AS 'Edition', SERVERPROPERTY('ProductVersion') AS 'ProductVersion';";
                    var command = new SqlCommand(sql, connection);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        result.Append(reader.GetName(0) + ":" + reader.GetString(0) + Environment.NewLine);
                        result.Append(reader.GetName(1) + ":" + reader.GetString(1) + Environment.NewLine);
                        result.Append(reader.GetName(2) + ":" + reader.GetString(2) + Environment.NewLine);
                    }

                    ExTxtbox.Text = result.ToString();
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                }
                else
                {
                    ExTxtbox.Text = "Enter connection string please";
                }
            }
            catch (SqlException esql)
            {
                ExTxtbox.Text = "Exception while Querying SQL:" + " \n\n-------------------------\n\n "
                    + esql.Server.ToString() + " \n\n-------------------------\n\n "
                    + esql.Message.ToString() + " \n\n-------------------------\n\n "
                    + esql.ToString();
            }
        }
    }
}