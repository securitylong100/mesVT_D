using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo
{
    public class JigDrawVo : ValueObject
    {
        public int JigID { get; set; }
        public string JigBCode { get; set; }
        public DateTime TimeReceive { get; set; }
        public string Status { get; set; }
        public string JigPlace { get; set; }
        public string Revision { get; set; }

        /// <summary>
        //
        /// from m_ncvp_model table
        public int ModelId { get; set; }
        public string ModelCode { get; set; }
        public string ModelName { get; set; }

        /// <summary>
        //
        /// from m_ncvp_jig_draw table
        public int DrawId { get; set; }
        public string DrawCode { get; set; }
        public string DrawName { get; set; }

        //From m_local_supplier tabel
        public int SupplierId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }

        //From m_process table
        public int ProcessId { get; set; }
        public string ProcessCode { get; set; }
        public string ProcessName { get; set; }

        //common
        public string RegistrationUserCode { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public string FactoryCode { get; set; }
        public int AffectedCount { get; set; }
    }
}