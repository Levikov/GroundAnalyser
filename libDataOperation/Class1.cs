#region 引用
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using GroundAnalyser;
using System.IO;
#endregion
namespace GroundAnalyser.Data
{


    #region 数据解包


    #endregion

    #region 数据解压


    #endregion


    #region 数据分包类

    public class Distribute
    {
        private string strFilePath;
        private OleDbConnection conn;
        public Distribute(string FilePath, string dbPath)
        {
            strFilePath = FilePath;
            string conString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Victor\OneDrive\Code\CSharp\GroundAnalyser\GroundAnalyser\data\db.mdb";
            conn = new OleDbConnection(conString);
            conn.Open();
        }

        public void importData()
        {
            FileStream fileData = new FileStream(strFilePath, FileMode.Open);
            byte[] bufFile = new byte[fileData.Length];
            byte[] row = new byte[280];
            fileData.Read(bufFile, 0, (int)fileData.Length);

            for (int i = 0; 280 * i < fileData.Length; i++)
            {
                Array.Copy(bufFile, 280 * i, row, 0, 280);
                insertData(row);
                
            }

            fileData.Close();
            


        }
        public void insertData(byte[] row)
        {

            //string strCommand = "INSERT INTO AuxData (FrmCnt) VALUES('" + BitConverter.ToUInt16(row, 48) + "')";
            if (row[4] == 0x08)
            {
                byte strip = row[5];
                Console.WriteLine("条带号:" + row[5].ToString());

                byte[] FrmNum = { row[7], row[6] };
                Console.WriteLine("包计数:" + BitConverter.ToUInt16(FrmNum,0).ToString()); 


                Console.WriteLine(row[6] * 256 + row[7]);
            }
            //OleDbCommand cmd = new OleDbCommand(strCommand, conn);
            //cmd.ExecuteScalar();
            
        }

    }
    #endregion

}
