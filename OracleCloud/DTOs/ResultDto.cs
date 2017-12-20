using System.Collections.Generic;

namespace OracleCloud.DTOs {
    public class ResultDto {
        public List<RecordDto> Records { get; set; }

        public string Message { get; set; }
    }
}