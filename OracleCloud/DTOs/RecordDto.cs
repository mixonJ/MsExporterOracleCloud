namespace OracleCloud.DTOs {
    public class RecordDto {
        public string TableName { get; set; }
        public int RecordCount { get; set; }
        public int RecordsProcessed { get; set; }
        public string Message { get; set; }
    }
}