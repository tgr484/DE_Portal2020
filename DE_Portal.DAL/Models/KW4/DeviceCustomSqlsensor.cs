using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceCustomSqlsensor
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int CustomSqlsensorId { get; set; }
        public string ConnectionName { get; set; }
        public float WarnLevel { get; set; }
        public float CriticalLevel { get; set; }
        public int Enabled { get; set; }
        public byte RiseAlertIfMore { get; set; }
    }
}
