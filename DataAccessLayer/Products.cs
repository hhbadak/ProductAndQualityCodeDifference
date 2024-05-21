using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Products
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public int ProductCode { get; set; }
        public string ProductCodeStr { get; set; }
        public DateTime CastDate { get; set; }
        public string CastDateStr { get; set; }
        public int CastPersonal { get; set; }
        public string CastPersonalStr { get; set; }
        public byte GlazingTerritory { get; set; }
        public byte Quality { get; set; }
        public string QualityStr { get; set; }
        public byte Fault { get; set; }
        public string FaultStr { get; set; }
        public DateTime ControlDate { get; set; }
        public string ControlDateStr { get; set; }
        public string ControlPersonal { get; set; }
        public byte Kiln { get; set; }
        public byte Firing { get; set; }
        public byte Color { get; set; }
        public string ColorStr { get; set; }
        public byte StockTerritory { get; set; }
        public string IsItTest { get; set; }
        public DateTime ControlTime { get; set; }
        public string ControlTimeStr { get; set; }
    }
}
