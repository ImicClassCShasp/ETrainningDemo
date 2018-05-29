using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace IMIC.OnlineDB
{
    public class ConnectionEntities
    {
        SqlConnection m_objConnection;

        //public TrainingCenterEntities getTrainingCenter()
        //{
        //    Common objCommon = new Common();
        //    TrainingCenterEntities objTraining = objCommon.getTrainingCenterInfo();
        //    return objTraining;
        //}
        public eTrainingOnlineEntities getTrainingCenterOn()
        {
            Common objCommon = new Common();
            eTrainingOnlineEntities objTraining = objCommon.getTrainingOnlineCenterInfo();
            return objTraining;
        }
        
        public SqlConnection OpenConection(string server, string database, string username, string password)
        {

            String connectString = String.Format("Data Source={0};Initial Catalog={1};"
                        + "Persist Security Info=True;User ID={2};Password={3}", server, database, username, password);
            m_objConnection = new SqlConnection(connectString);

            try
            {
                //2. Mở kết nối
                m_objConnection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return m_objConnection;
        }
    }
}
