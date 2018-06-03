using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;


namespace IMIC.DATAACCESSLAYERS
{
    public class ConnectionEntities
    {        
        public static TrainingCenterEntities getTrainingCenter(Account oAccount)
        {
            Commons objCommon = new Commons(oAccount);
            TrainingCenterEntities objTraining = objCommon.getTrainingCenterInfo();
            return objTraining;
        }

        public static WebIMICEntities getWebIMICOnline(Account oAccount)
        {
            Commons objCommon = new Commons(oAccount);
            WebIMICEntities objWebIMIC = objCommon.getWebIMICEntitiesInfo();
            return objWebIMIC;
        }
    }
}
