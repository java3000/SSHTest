using System.Text;

namespace SSHTest.Object
{
    internal enum StatusType : byte
    {
        Ignored = 0,
        Created = 1,
        CreatedAsUndisposed = 2,
        Updated = 3,
        Error = 5,
    }

    internal abstract class InquiryObjectBase
    {
        #region fiedlds
        private StringBuilder _sb;
        #endregion

        #region constructor
        protected InquiryObjectBase()
        {
            _sb = new StringBuilder();
        }
        #endregion

        #region properties
        internal abstract string SourceName { get; }
        internal StatusType? Status { get; set; }
        internal string LogProtocol { get { return _sb.ToString(); } }

        internal abstract string Name { get; set; }
        internal abstract string ModelExternalID { get; set; }
        internal abstract string ModelName { get; set; }
        internal abstract string ManufacturerName { get; set; }
        internal abstract string TypeName { get; set; }

        internal abstract string ExternalID { get; set; }
        internal abstract string SerialNumber { get; set; }
        internal abstract string InventoryNumber { get; set; }
        internal abstract string Code { get; set; }
        internal abstract string Description { get; set; }
        internal abstract string Note { get; set; }
        internal abstract DateTime? DateReceived { get; set; }
        internal abstract Decimal? Cost { get; set; }
        internal abstract DateTime? Warranty { get; set; }
        internal abstract string Agreement { get; set; }
        internal abstract string Founding { get; set; }
        internal abstract string ResponsibleUser { get; set; }
        internal abstract string OwningOrganization { get; set; }
        internal abstract string UtilizerName { get; set; }
        internal abstract string SupplierName { get; set; }
        internal abstract string SupplierExternalID { get; set; }
        internal abstract string UserField1 { get; set; }
        internal abstract string UserField2 { get; set; }
        internal abstract string UserField3 { get; set; }
        internal abstract string UserField4 { get; set; }
        internal abstract string UserField5 { get; set; }
        internal abstract string RoomName { get; set; }
        internal abstract string BuildingName { get; set; }
        internal abstract string LocationString { get; set; }
        #endregion

        #region method Log
        internal void Log(string msg)
        {
            _sb.AppendLine(msg);
        }
        #endregion

        #region method AddCSVRow
        internal static string GetCSV(List<InquiryObjectBase> list, char separator)
        {
            var properties = typeof(InquiryObjectBase).
                GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.NonPublic);
            //
            var sb = new StringBuilder();
            for (int i = 0; i < properties.Length; i++)
            {
                var pi = properties[i];
                string name = pi.Name;
                sb.AppendFormat("\"{0}\"", name);
                if (i < properties.Length - 1)
                    sb.Append(separator);
            }
            //
            foreach (var obj in list)
            {
                sb.AppendLine();
                for (int i = 0; i < properties.Length; i++)
                {
                    var pi = properties[i];
                    object value = pi.GetValue(obj);
                    string valueString = value == null ? string.Empty : value.ToString();
                    sb.AppendFormat("\"{0}\"", valueString.Replace("\"", "'"));
                    if (i < properties.Length - 1)
                        sb.Append(separator);
                }
            }
            //
            return sb.ToString();
        }
        #endregion
    }
}
