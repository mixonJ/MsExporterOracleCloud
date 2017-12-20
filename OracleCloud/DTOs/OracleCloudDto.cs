using OracleCloud.Interfaces;
using System;

namespace OracleCloud.DTOs {
    public class OracleCloudDto {
        public IOracleRepository OracleRepository { get; set; }
        public bool LimitRecords { get; set; }
        public int CompanyId { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
        public bool UnitTesting { get; set; }
    }
}