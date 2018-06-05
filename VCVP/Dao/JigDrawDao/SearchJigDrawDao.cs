using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using System.Data;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class SearchJigDrawDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            JigDrawVo inVo = (JigDrawVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<JigDrawVo> voList = new ValueObjectList<JigDrawVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append(@"SELECT a.jig_id, a.jig_cd, b.draw_cd, c.model_cd, d.process_name, 
a.time_receive, e.local_supplier_name, a.status, a.place, a.revision, a.registration_user_cd,a.registration_date_time,a.factory_cd
from t_ncvp_jig_draw a 

left join m_ncvp_draw b on b.draw_id = a.draw_id
left join m_ncvp_model c on c.model_id = a.model_id
left join m_process d on d.process_id = a.process_id
left join m_local_supplier e on e.local_supplier_id = a.local_supplier_id
 WHERE 1 = 1");


            //sql.Append(@"time_receive > :receivetime"); //
            //sqlParameter.AddParameterDateTime("receivetime", inVo.TimeReceive);

            if (!String.IsNullOrEmpty(inVo.ModelCode))
            {
                sql.Append(" and model_cd =:model_cd ");
                sqlParameter.AddParameterString("model_cd", inVo.ModelCode);
            }
            if (!String.IsNullOrEmpty(inVo.ProcessName))
            {
                sql.Append(" and process_name =:process_name ");
                sqlParameter.AddParameterString("process_name", inVo.ProcessName);
            }
            if (!String.IsNullOrEmpty(inVo.DrawCode))
            {
                sql.Append(" and draw_cd =:draw_cd ");
                sqlParameter.AddParameterString("draw_cd", inVo.DrawCode);
            }
            if (!String.IsNullOrEmpty(inVo.SupplierName))
            {
                sql.Append(" and local_supplier_name =:local_supplier_name ");
                sqlParameter.AddParameterString("local_supplier_name", inVo.SupplierName);
            }
            if (!String.IsNullOrEmpty(inVo.Status))
            {
                sql.Append(" and status =:status ");
                sqlParameter.AddParameterString("status", inVo.Status);
            }
            if (!String.IsNullOrEmpty(inVo.JigPlace))
            {
                sql.Append(" and place = :place ");
                sqlParameter.AddParameterString("place", inVo.JigPlace);
            }
            if (!String.IsNullOrEmpty(inVo.Revision))
            {
                sql.Append(" and revision=  :revision ");
                sqlParameter.AddParameterString("revision", inVo.Revision);
            }


            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());



            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                JigDrawVo outVo = new JigDrawVo
                {
                    //  , h., i., k., o.prodution_work_content_name
                    JigID = int.Parse(dataReader["jig_id"].ToString()),
                    JigBCode = dataReader["jig_cd"].ToString(),
                    ProcessName = dataReader["process_name"].ToString(),
                    DrawCode = dataReader["draw_cd"].ToString(),
                    SupplierName = dataReader["local_supplier_name"].ToString(),               
                    TimeReceive = DateTime.Parse(dataReader["time_receive"].ToString()),
                    ModelCode = dataReader["model_cd"].ToString(),
                    Status = dataReader["status"].ToString(),                  
                    Revision = dataReader["revision"].ToString(),
                    JigPlace = dataReader["place"].ToString(),
                   // RegistrationUserCode = dataReader["registration_user_cd"].ToString()
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }

    }


}
