using NetfixPOS.DataAccess.Interface;
using NetfixPOS.Models;
using NetfixPOS.Query;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess
{
    public class StockMasterDAL : DataControllerBase, IStock
    {
		StockQuery query;
		public StockMasterDAL()
        {
			query = new StockQuery();
		}
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(StockModel stock, dsNewSetup.ConversionDataTable conversions)
        {
			if (Connection.State == ConnectionState.Closed) Connection.Open();

			SqlTransaction transaction = Connection.BeginTransaction();
			Command = new SqlCommand("Stock_Insert", Connection, transaction);
			Command.CommandType = CommandType.StoredProcedure;

			Command.Parameters.AddWithValue("StockCode", stock.StockCode);
			Command.Parameters.AddWithValue("StockName", stock.StockName);
			Command.Parameters.AddWithValue("CategoryId", stock.CategoryId);
			Command.Parameters.AddWithValue("Minqty", stock.Minqty);
			Command.Parameters.AddWithValue("Maxqty", stock.Maxqty);
			Command.Parameters.AddWithValue("MinUnitId", stock.MinUnitId);
			Command.Parameters.AddWithValue("MaxUnitId", stock.MaxUnitId);
			Command.Parameters.AddWithValue("SaleCurrencyId", stock.SaleCurrencyId);
			Command.Parameters.AddWithValue("Discontinue", stock.Discontinue);
			Command.Parameters.AddWithValue("DefaultUnit", stock.DefaultUnit);

			Command.Parameters.AddWithValue("PurchasePrice", stock.PurchasePrice);
			Command.Parameters.AddWithValue("SellingPrice", stock.SellingPrice);
			Command.Parameters.AddWithValue("StockIcon", stock.StockIcon);
			Command.Parameters.AddWithValue("ModifiedDate", stock.ModifiedDate);
			Command.Parameters.AddWithValue("InQty", stock.InQty);
			Command.Parameters.AddWithValue("IsStore", stock.IsStore);

			try
			{
				string key = Command.ExecuteScalar().ToString();

				if (conversions.Rows.Count > 0)
				{
					/*Insert Unit Conversion*/
					ConversionDAL _conversion = new ConversionDAL();
					_conversion.InsertConvension(key, conversions, Connection, transaction);
				}

			}
			catch (Exception ex)
			{
				transaction.Rollback();
				throw ex;
			}
			finally
			{
				if (Connection.State == ConnectionState.Open)
				{
					transaction.Commit();
					Connection.Close();
				}
			}
		}

        public void Update(StockModel stock, dsNewSetup.ConversionDataTable conversions)
        {

			if (Connection.State == ConnectionState.Closed) Connection.Open();
			Transaction = Connection.BeginTransaction();
			Command = new SqlCommand("Stock_Update", Connection, Transaction);
			Command.CommandType = CommandType.StoredProcedure;

			Command.Parameters.AddWithValue("StockId", stock.StockId);
			Command.Parameters.AddWithValue("StockCode", stock.StockCode);
			Command.Parameters.AddWithValue("StockName", stock.StockName);
			Command.Parameters.AddWithValue("CategoryId", stock.CategoryId);
			Command.Parameters.AddWithValue("Minqty", stock.Minqty);
			Command.Parameters.AddWithValue("Maxqty", stock.Maxqty);
			Command.Parameters.AddWithValue("MinUnitId", stock.MinUnitId);
			Command.Parameters.AddWithValue("MaxUnitId", stock.MaxUnitId);
			Command.Parameters.AddWithValue("SaleCurrencyId", stock.SaleCurrencyId);
			Command.Parameters.AddWithValue("Discontinue", stock.Discontinue);
			Command.Parameters.AddWithValue("DefaultUnit", stock.DefaultUnit);

			Command.Parameters.AddWithValue("PurchasePrice", stock.PurchasePrice);
			Command.Parameters.AddWithValue("SellingPrice", stock.SellingPrice);
			Command.Parameters.AddWithValue("StockIcon", stock.StockIcon);
			Command.Parameters.AddWithValue("ModifiedDate", stock.ModifiedDate);
			Command.Parameters.AddWithValue("InQty", stock.InQty);
			Command.Parameters.AddWithValue("IsStore", stock.IsStore);

			try
			{
				Command.ExecuteNonQuery();

				if (conversions.Rows.Count > 0)
				{
					/*Insert Unit Conversion*/
					ConversionDAL _conversion = new ConversionDAL();
					_conversion.UpdateConvension(conversions, Connection, Transaction);
				}

			}
			catch (Exception ex)
			{
				Transaction.Rollback();
				throw ex;
			}
			finally
			{
				if (Connection.State == ConnectionState.Open)
				{
					Transaction.Commit();
					Connection.Close();
				}
			}
		}
		public void Delete(string stockId)
        {
			if (Connection.State == ConnectionState.Closed) Connection.Open();
			Transaction = Connection.BeginTransaction();
			Command = new SqlCommand(query.Delete(), Connection, Transaction);
			Command.CommandType = CommandType.Text;

			Command.Parameters.AddWithValue("StockId", stockId);
			

			try
			{
				Command.ExecuteNonQuery();
				ConversionDAL _conversion = new ConversionDAL();
				_conversion.DeleteConvension(stockId, Connection, Transaction);

			}
			catch (Exception ex)
			{
				Transaction.Rollback();
				throw ex;
			}
			finally
			{
				if (Connection.State == ConnectionState.Open)
				{
					Transaction.Commit();
					Connection.Close();
				}
			}
		}
		public dsNewSetup.StockMasterRow SelectStockByStockID(string key)
		{
			string sqlcmd = "Stock_SelectbyId";

			dsNewSetup.StockMasterDataTable dataTable = new dsNewSetup.StockMasterDataTable();

			Command = new SqlCommand(sqlcmd, Connection);
			Command.CommandType = CommandType.StoredProcedure;

			Command.Parameters.AddWithValue("StockId", key);

			try
			{
				if (Connection.State == ConnectionState.Closed) Connection.Open();
				SqlDataAdapter adapter = new SqlDataAdapter(Command);

				adapter.Fill(dataTable);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (Connection.State == ConnectionState.Open) Connection.Close();
			}

			return dataTable[0];
		}

		public dsNewSetup.StockMasterDataTable GetStockList(string stockId)
		{
			string sqlcmd = "Stock_SelectbyId";

			dsNewSetup.StockMasterDataTable dataTable = new dsNewSetup.StockMasterDataTable();

			Command = new SqlCommand(sqlcmd, Connection);
			Command.CommandType = CommandType.StoredProcedure;

			Command.Parameters.AddWithValue("StockId", stockId);

			try
			{
				if (Connection.State == ConnectionState.Closed) Connection.Open();
				SqlDataAdapter adapter = new SqlDataAdapter(Command);

				adapter.Fill(dataTable);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (Connection.State == ConnectionState.Open) Connection.Close();
			}

			return dataTable;
		}

		public DataTable GetStockByCategoryId(int id)
        {
			string sqlcmd = "Stock_SelectByCategoryID";

			DataTable dataTable = new DataTable();

			Command = new SqlCommand(sqlcmd, Connection);
			Command.CommandType = CommandType.StoredProcedure;

			Command.Parameters.AddWithValue("CategoryId", id);

			try
			{
				if (Connection.State == ConnectionState.Closed) Connection.Open();
				SqlDataAdapter adapter = new SqlDataAdapter(Command);

				adapter.Fill(dataTable);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (Connection.State == ConnectionState.Open) Connection.Close();
			}

			return dataTable;
		}
	}
}
