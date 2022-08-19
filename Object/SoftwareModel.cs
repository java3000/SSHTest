namespace SSHTest.Object
{
    internal sealed class SoftwareModel
    {
        #region fields
        private Guid _id;
        private string _name;
        private string _version;
        private InquiryObjectType _inquiryObjectType;
        private readonly Manufacturer _manufacturer;

        private CacheContainer _processCache;
        private Software.SoftwareModel _imSoftwareModel;

        private static Dictionary<Guid, Dictionary<string, SoftwareModel>> __cache = new Dictionary<Guid, Dictionary<string, SoftwareModel>>();
        #endregion

        #region constructor
        private SoftwareModel(InquiryObjectType inquiryObjectType, string name, string version, Manufacturer manufacturer, CacheContainer processCache)
        {
            if (name == null)
                throw new ArgumentNullException("name");
            if (version == null)
                throw new ArgumentNullException("version");
            if (processCache == null)
                throw new ArgumentNullException("processCache");
            if (manufacturer == null)
                throw new ArgumentNullException("manufacturer");
            //
            _id = Guid.NewGuid();
            _inquiryObjectType = inquiryObjectType;
            _name = name;
            _version = version;
            _manufacturer = manufacturer;
            _processCache = processCache;
            _imSoftwareModel = null;
        }
        #endregion

        #region Properties
        internal Guid ID
        {
            get { return _id; }
        }

        internal string Name
        {
            get { return _name; }
        }

        internal string Version
        {
            get { return _version; }
        }

        internal Manufacturer Manufacturer
        {
            get { return _manufacturer; }
        }

        internal InquiryObjectType ObjectType
        {
            get { return _inquiryObjectType; }
        }

        internal Software.SoftwareModel IMSoftwareModel
        {
            get { return _imSoftwareModel; }
        }
        #endregion

    }

    internal class InquiryObjectType
    {
        public static object Processor { get; set; }
    }
}
