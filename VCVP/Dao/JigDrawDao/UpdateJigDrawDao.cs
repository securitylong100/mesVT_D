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
    public class UpdateJigDrawDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            JigDrawVo inVo = (JigDrawVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append(@"update t_ncvp_jig_draw set jig_cd=:jig_cd,
                                                        model_id=:model_id,
                                                        process_id=:process_id,
                                                        draw_id=:draw_id,
                                                        time_receive=:time_receive,
                                                        status=:status,
                                                        local_supplier_id=:local_supplier_id,
                                                        place=:place,
                                                        revision=:revision,
                                                        ");
            sql.Append(" where jig_id =:jig_id");




            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameter("jig_id", inVo.JigID);
            sqlParameter.AddParameter("jig_cd", inVo.JigBCode);
            sqlParameter.AddParameter("model_id", inVo.ModelId);
            sqlParameter.AddParameter("process_id", inVo.ProcessId);
            sqlParameter.AddParameter("draw_id", inVo.DrawId);
            sqlParameter.AddParameter("time_receive", inVo.TimeReceive);
            sqlParameter.AddParameter("status", inVo.Status);
            sqlParameter.AddParameter("local_supplier_id", inVo.SupplierName);
            sqlParameter.AddParameter("revision", inVo.Revision);
            sqlParameter.AddParameter("place", inVo.JigPlace);
            sqlParameter.AddParameter("registration_user_cd", inVo.RegistrationUserCode);
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