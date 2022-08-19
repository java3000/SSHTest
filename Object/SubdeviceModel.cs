namespace SSHTest.Object
{
    internal sealed class SubdeviceModel
    {
        #region fields
        private string _name;
        private string _externalID;
        private string _typeName;
        private InquiryObjectType _inquiryObjectType;
        private Manufacturer _manufacturer;
        private readonly ParameterList _parameterList;
        private string _fullName;

        private CacheContainer _processCache;
        private ProductCatalogue.SubdeviceModel _imSubdeviceModel;
        private bool _isNewModel;

        private static Dictionary<Guid, Dictionary<string, SubdeviceModel>> __cache = new Dictionary<Guid, Dictionary<string, SubdeviceModel>>();
        #endregion

        #region constructor

        public SubdeviceModel(InquiryObjectType inquiryObjectType, string name, string externalID, string typeName, Manufacturer manufacturer, CacheContainer processCache)
        {
            if (name == null && externalID == null)
                throw new ArgumentNullException("name/externalID");
            if (processCache == null)
                throw new ArgumentNullException("processCache");
            if (manufacturer == null)
                throw new ArgumentNullException("manufacturer");
            //
            _inquiryObjectType = inquiryObjectType;
            _name = name;
            _externalID = externalID;
            _typeName = typeName;
            _manufacturer = manufacturer;
            _parameterList = new ParameterList();
            _processCache = processCache;
            _imSubdeviceModel = null;
            _isNewModel = false;
        }
        #endregion

        #region Properties
        internal string Name
        {
            get { return _name; }
        }

        internal string ExternalID
        {
            get { return _externalID; }
        }

        internal string TypeName
        {
            get { return _typeName; }
        }

        internal InquiryObjectType InquiryObjectType
        {
            get { return _inquiryObjectType; }
        }

        internal Manufacturer Manufacturer
        {
            get { return _manufacturer; }
        }

        internal ParameterList ParameterList
        {
            get { return _parameterList; }
        }

        internal ProductCatalogue.SubdeviceModel IMSubdeviceModel
        {
            get { return _imSubdeviceModel; }
        }

        internal bool IsNewModel
        {
            get { return _isNewModel; }
        }
        #endregion

        public static SubdeviceModel Get(object processor, string s, Manufacturer manufacturer, ProcessCache processCache, out bool @new)
        {
            @new = true;
            return new SubdeviceModel(new InquiryObjectType(), "", "", "", new Manufacturer("this", new CacheContainer()), new CacheContainer());
        }
    }
}
