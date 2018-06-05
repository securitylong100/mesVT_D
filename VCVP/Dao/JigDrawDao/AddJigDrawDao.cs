using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class AddJigDrawDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            JigDrawVo inVo = (JigDrawVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append(@"insert into t_ncvp_jig_draw(jig_cd, draw_id, model_id, process_id, 
                        local_supplier_id, time_receive, status, place, revision, registration_user_cd, 
                        registration_date_time, factory_cd)");
            sql.Append(@"values(:jig_cd, :draw_id, :model_id, :process_id, 
                       :local_supplier_id, now(), :status, :place, :revision, :registration_user_cd, 
                       now(), :factory_cd)");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameter("jig_id", inVo.JigID);
            sqlParameter.AddParameter("jig_cd", inVo.JigBCode);
            sqlParameter.AddParameter("draw_id", inVo.DrawId);
            sqlParameter.AddParameter("model_id", inVo.ModelId);
            sqlParameter.AddParameter("process_id", inVo.ProcessId);
            sqlParameter.AddParameter("local_supplier_id", inVo.SupplierId);
            sqlParameter.AddParameter("time_receive", inVo.TimeReceive);
            sqlParameter.AddParameter("status", inVo.Status);
            sqlParameter.AddParameter("place", inVo.JigPlace);
            sqlParameter.AddParameter("revision", inVo.Revision);
            sqlParameter.AddParameter("registration_user_cd", inVo.RegistrationUserCode);
            sqlParameter.AddParameter("registration_date_time", inVo.RegistrationDateTime);
            sqlParameter.AddParameter("factory_cd", inVo.FactoryCode);
            //execute SQL

            JigDrawVo outVo = new JigDrawVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
