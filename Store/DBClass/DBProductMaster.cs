using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace inventory.DBClass
{
    class DBProductMaster
    {
        public void addProduct(string ProductName,ref string Error)
        {
            SqlConnection conn = DBConnetion.getDBConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into productMaster(ProductName)values('"+ProductName+"')", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            finally
            {
                conn.Close();
            }

        }
        public DataTable getAllproduct(ref string Error)
        {
            try
            {
                SqlConnection conn=DBConnetion.getDBConnection();
                conn.Open();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from ProductMaster", conn);
                DataTable table = new DataTable();
                adpt.Fill(table);
                return table;

            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }

        public void addSellEntry(int ProductID,double qun,double price,string partyName,string date, ref string Error)
        {
            SqlConnection conn = DBConnetion.getDBConnection();
            try
            {
                conn.Open();
                string query="insert into SellMaster(ProductID,quantity,Price,SellDate,PartyName)values("+ProductID+","+qun+","+price+",'"+date+"','"+partyName+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
        public void addPurchaseEntry(int ProductID, double qun, double price, string partyName, string date, ref string Error)
        {
            SqlConnection conn = DBConnetion.getDBConnection();
            try
            {
                conn.Open();
                string query = "insert into PurchaseMaster(ProductID,quaNtity,Price,PurchaseDate,PartyName)values(" + ProductID + "," + qun + "," + price + ",'" + date + "','" + partyName + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable getAllPurchaseData(ref string Error)
        {
            try
            {
                SqlConnection conn = DBConnetion.getDBConnection();
                conn.Open();
                SqlDataAdapter adpt = new SqlDataAdapter("select pm.PurchaseID, pmas.ProductName,pm.Quantity,pm.Price,pm.PurchaseDate,pm.PartyName from PurchaseMaster pm inner join ProductMaster pmas on pmas.ProductId=pm.ProductID order by pm.PurchaseDate desc,pmas.ProductName", conn);
                DataTable table = new DataTable();
                adpt.Fill(table);
                return table;

            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }
        public DataTable getAllSellData(ref string Error)
        {
            try
            {
                SqlConnection conn = DBConnetion.getDBConnection();
                conn.Open();
                SqlDataAdapter adpt = new SqlDataAdapter("select pm.SellID, pmas.ProductName,pm.Quantity,pm.Price,pm.SellDate,pm.PartyName from SellMaster pm inner join ProductMaster pmas on pmas.ProductId=pm.ProductID order by pm.SellDate desc,pmas.ProductName", conn);
                DataTable table = new DataTable();
                adpt.Fill(table);
                return table;

            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }
        public double getPurchaseCount(int ProductID, ref string Error)
        {
            SqlConnection conn = DBConnetion.getDBConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select sum(Quantity) from PurchaseMaster where ProductID="+ProductID, conn);
               Object obj= cmd.ExecuteScalar();
               if (obj != null)
               {
                   return Int64.Parse(obj.ToString());
               }
               else
               {
                   return 0;
               }

            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
        public double getSellCount(int ProductID, ref string Error)
        {
            SqlConnection conn = DBConnetion.getDBConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select sum(Quantity) from SellMaster where ProductID=" + ProductID, conn);
                Object obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    return Int64.Parse(obj.ToString());
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
        
    }
    
}
