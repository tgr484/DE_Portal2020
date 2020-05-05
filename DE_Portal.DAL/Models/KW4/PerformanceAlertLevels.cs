using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class PerformanceAlertLevels
    {
        public int Id { get; set; }
        public int? Cpumin { get; set; }
        public int? Cpumax { get; set; }
        public int? Cpuwarning { get; set; }
        public int? Cpualert { get; set; }
        public int? MemMin { get; set; }
        public int? MemMax { get; set; }
        public int? MemWarning { get; set; }
        public int? MemAlert { get; set; }
        public int? CpuqueueMin { get; set; }
        public int? CpuqueueMax { get; set; }
        public int? CpuqueueWarning { get; set; }
        public int? CpuqueueAlert { get; set; }
        public int? DiskloadMin { get; set; }
        public int? DiskloadMax { get; set; }
        public int? DiskloadWarning { get; set; }
        public int? DiskloadAlert { get; set; }
        public int? VolumeUtilizationMin { get; set; }
        public int? VolumeUtilizationMax { get; set; }
        public int? VolumeUtilizationWarning { get; set; }
        public int? VolumeUtilizationAlert { get; set; }
        public int? DbvolumeUtilizationMin { get; set; }
        public int? DbvolumeUtilizationMax { get; set; }
        public int? DbvolumeUtilizationWarning { get; set; }
        public int? DbvolumeUtilizationAlert { get; set; }
        public DateTime Ts { get; set; }
        public int? NetworkLatencyWarning { get; set; }
        public int? NetworkLatencyAlert { get; set; }
    }
}
