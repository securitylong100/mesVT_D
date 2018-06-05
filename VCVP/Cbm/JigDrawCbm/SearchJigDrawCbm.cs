using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao;


namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm
{
 public class SearchJigDrawCbm : CbmController
    {
        private static readonly DataAccessObject getDao = new SearchJigDrawDao();

        private readonly CommonLogger logger = CommonLogger.GetInstance(typeof(SearchJigDrawCbm));
        public ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            if (vo == null)
            {
                //throw ApplicationException
                MessageData msdata = new MessageData("vnce00001", Properties.Resources.vnce00001,typeof(SearchJigDrawCbm).FullName);
                logger.Error(msdata, new NullReferenceException());
                Framework.ApplicationException Appex = new Framework.ApplicationException(msdata, new NullReferenceException());
                throw Appex;
            }

            return getDao.Execute(trxContext, vo);
        }
    }

    
}
