using NetfixPOS.DataAccess.Interface;
using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess
{
    public class DamageDAL : DataControllerBase, IDamage
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetDamageList(DateTime dateTime)
        {
            Command = new SqlCommand("Damage_List", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                Command.Parameters.AddWithValue("Dmg_Date", dateTime);

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = Command;
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public void Insert(DamageModel damage)
        {
            string query = "INSERT tbl_Damage VALUES(@TableOrRoom, @Dmg_Description, @Dmg_Charges, @Dmg_Approver, @UserID, @Dmg_Date, 0, 1)";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.Text;

            try
            {
                Command.Parameters.AddWithValue("TableOrRoom", damage.TableOrRoom);
                Command.Parameters.AddWithValue("Dmg_Description", damage.Dmg_Description);
                Command.Parameters.AddWithValue("Dmg_Charges", damage.Dmg_Charges);
                Command.Parameters.AddWithValue("Dmg_Approver", damage.Dmg_Approver);
                Command.Parameters.AddWithValue("UserID", damage.UserID);
                Command.Parameters.AddWithValue("Dmg_Date", damage.Dmg_Date);
                //Command.Parameters.AddWithValue("CashReceiptId", damage.CashReceiptId);

                Connection.Open();
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }
        }

        public void Update(DamageModel damage)
        {
            string query = "UPDATE tbl_Damage SET TableOrRool = @TableOrRoom, Dmg_Description = @Dmg_Description, Dmg_Charges = @Dmg_Charges, " +
                "Dmg_Approver = @Dmg_Approver, UserID = @UserID, Dmg_Date = @Dmg_Date, CashReceiptId = @CashReceiptId WHERE DamageId = @DamageId";
            Command = new SqlCommand(query, Connection);
            Command.CommandType = CommandType.StoredProcedure;

            try
            {
                Command.Parameters.AddWithValue("DamageId", damage.DamageId);
                Command.Parameters.AddWithValue("TableOrRoom", damage.TableOrRoom);
                Command.Parameters.AddWithValue("Dmg_Description", damage.Dmg_Description);
                Command.Parameters.AddWithValue("Dmg_Charges", damage.Dmg_Charges);
                Command.Parameters.AddWithValue("Dmg_Approver", damage.Dmg_Approver);
                Command.Parameters.AddWithValue("UserID", damage.UserID);
                Command.Parameters.AddWithValue("Dmg_Date", damage.Dmg_Date);
                Command.Parameters.AddWithValue("CashReceiptId", damage.CashReceiptId);

                Connection.Open();
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }
        }
    }
}
