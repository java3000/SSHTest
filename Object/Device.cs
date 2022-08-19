
namespace SSHTest.Object
{
    //Не забываем про отклонения, в которых сериализованы эти данные, см. Deviation
    internal class Device : InquiryObjectBase
    {
        #region fields
        private bool _isEmptyDevice;
        private DateTime _inquireDate;
        private string _name;
        private string _modelName;
        private string _modelExternalID;
        private string _manufacturerName;
        private string _typeName;
        private bool? _isLogical;
        private ProductCatalogue.ProductCatalogTemplate _template;
        private string _serialNumber;
        private string _externalID;
        private string _code;
        private string _smbiosAssetTag;
        private string _userName;
        private string _logonDomain;
        private string _defaultPrinterName;
        private string _description;
        private string _note;
        private DateTime? _dateReceived;
        private Decimal? _cost;
        private DateTime? _warranty;
        private string _agreement;
        private string _founding;
        private string _responsibleUser;
        private string _owningOrganization;
        private string _utilizerName;
        private string _supplierName;
        private string _supplierExternalID;
        private string _inventoryNumber;
        private string _userField1;
        private string _userField2;
        private string _userField3;
        private string _userField4;
        private string _userField5;
        private string _roomName;
        private string _buildingName;
        private string _locationString;
        private CacheContainer _cache;
        private readonly SubdeviceList _subdeviceList;
        private readonly LogicalDriveList _logicalDriveList;
        private readonly InstallationList _installationList;
        private readonly ConnectionList _connectionList;
        private readonly ProviderType _providerType;
        private readonly string _sourceName;
        private readonly List<AgentFileInfo> _agentFileInfoList;
        #endregion

        #region constructor
        internal Device(string name, DateTime inquireDate, ProviderType providerType, string sourceName, CacheContainer cache)
            : base()
        {
            if (name == null)
                throw new ArgumentNullException("name");
            if (cache == null)
                throw new ArgumentNullException("cache");
            //
            _isEmptyDevice = false;
            _inquireDate = inquireDate;
            _cache = cache;
            //
            _name = name;
            _defaultPrinterName = string.Empty;
            _subdeviceList = new SubdeviceList();
            _installationList = new InstallationList();
            _logicalDriveList = new LogicalDriveList();
            _connectionList = new ConnectionList();
            _providerType = providerType;
            _sourceName = sourceName;
            this.DeviceClassID = 0;
            _agentFileInfoList = new List<AgentFileInfo>();
        }
        #endregion

        #region Properities
        internal ProviderType ProviderType { get { return _providerType; } }
        internal override string SourceName { get { return _sourceName; } }

        internal bool IsEmptyDevice
        {
            get { return _isEmptyDevice; }
            set { _isEmptyDevice = true; }
        }

        internal int DeviceClassID { get; set; }

        internal DateTime InquireDate
        {
            get { return this._inquireDate; }
        }

        internal override string Name
        {
            get { return _name; }
            set
            {
                if (_cache.ValueIsInvalid(value))
                    return;
                _name = value;
            }
        }

        internal override string ModelName
        {
            get { return _modelName; }
            set
            {
                _modelName = value;
                //
                if (_cache.ValueIsInvalid(_modelName))
                    _modelName = null;
            }
        }

        internal override string ModelExternalID
        {
            get { return _modelExternalID; }
            set
            {
                _modelExternalID = value;
                //
                if (_cache.ValueIsInvalid(_modelExternalID))
                    _modelExternalID = null;
            }
        }

        internal ProductCatalogue.ProductCatalogTemplate Template
        {
            get { return _template; }
            set { _template = value; }
        }

        internal override string TypeName
        {
            get { return _typeName; }
            set
            {
                _typeName = value;
                //
                if (_cache.ValueIsInvalid(_typeName))
                    _typeName = null;
            }
        }

        internal bool? IsLogical
        {
            get { return _isLogical; }
            set { _isLogical = value; }
        }

        internal override string ManufacturerName
        {
            get { return _manufacturerName; }
            set
            {
                _manufacturerName = value;
                //
                if (_cache.ValueIsInvalid(_manufacturerName))
                    _manufacturerName = null;
            }
        }

        internal override string SerialNumber
        {
            get { return _serialNumber; }
            set
            {
                _serialNumber = value;
                //
                if (_cache.ValueIsInvalid(_serialNumber))
                    _serialNumber = String.Empty;
            }
        }

        internal override string ExternalID
        {
            get { return _externalID; }
            set
            {
                _externalID = value;
                //
                if (_cache.ValueIsInvalid(_externalID))
                    _externalID = String.Empty;
            }
        }

        internal override string Code
        {
            get { return _code; }
            set
            {
                _code = value;
                //
                if (_cache.ValueIsInvalid(_code))
                    _code = String.Empty;
            }
        }

        internal string SMBIOSAssetTag
        {
            get { return _smbiosAssetTag; }
            set
            {
                _smbiosAssetTag = value;
                //
                if (_cache.ValueIsInvalid(_smbiosAssetTag))
                    _smbiosAssetTag = String.Empty;
            }
        }

        internal string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        internal string LogonDomain
        {
            get { return _logonDomain; }
            set { _logonDomain = value; }
        }

        internal string DefaultPrinterName
        {
            get { return _defaultPrinterName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _defaultPrinterName = value;
            }
        }

        internal override string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                if (_cache.ValueIsInvalid(value))
                    return;
                //
                _description = value;
            }
        }

        internal override string Note
        {
            get { return _note; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                if (_cache.ValueIsInvalid(value))
                    return;
                //
                _note = value;
            }
        }

        internal override DateTime? DateReceived
        {
            get { return _dateReceived; }
            set { _dateReceived = value; }
        }

        internal override Decimal? Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        internal override DateTime? Warranty
        {
            get { return _warranty; }
            set { _warranty = value; }
        }

        internal override string Agreement
        {
            get { return _agreement; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _agreement = value;
            }
        }

        internal override string Founding
        {
            get { return _founding; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _founding = value;
            }
        }

        internal override string ResponsibleUser
        {
            get { return _responsibleUser; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _responsibleUser = value;
            }
        }

        internal override string OwningOrganization
        {
            get { return _owningOrganization; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _owningOrganization = value;
            }
        }

        internal override string UtilizerName
        {
            get { return _utilizerName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _utilizerName = value;
            }
        }

        internal override string SupplierName
        {
            get { return _supplierName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _supplierName = value;
            }
        }
        internal override string SupplierExternalID
        {
            get { return _supplierExternalID; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _supplierExternalID = value;
            }
        }

        internal override string InventoryNumber
        {
            get { return _inventoryNumber; }
            set
            {
                _inventoryNumber = value;
                //
                if (_cache.ValueIsInvalid(_inventoryNumber))
                    _inventoryNumber = String.Empty;
            }
        }

        internal override string UserField1
        {
            get { return _userField1; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _userField1 = value;
            }
        }

        internal override string UserField2
        {
            get { return _userField2; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _userField2 = value;
            }
        }

        internal override string UserField3
        {
            get { return _userField3; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _userField3 = value;
            }
        }

        internal override string UserField4
        {
            get { return _userField4; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _userField4 = value;
            }
        }

        internal override string UserField5
        {
            get { return _userField5; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _userField5 = value;
            }
        }

        internal override string BuildingName
        {
            get { return _buildingName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _buildingName = value;
            }
        }

        internal override string RoomName
        {
            get { return _roomName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _roomName = value;
            }
        }

        internal override string LocationString
        {
            get { return _locationString; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                //
                _locationString = value;
            }
        }

        internal CacheContainer ProcessCache
        {
            get { return _cache; }
        }

        internal SubdeviceList SubdeviceList
        {
            get { return _subdeviceList; }
        }

        internal LogicalDriveList LogicalDriveList
        {
            get { return _logicalDriveList; }
        }

        internal InstallationList InstallationList
        {
            get { return _installationList; }
        }

        internal ConnectionList ConnectionList
        {
            get { return this._connectionList; }
        }

        public List<AgentFileInfo> AgentFileInfoList { get { return _agentFileInfoList; } }
        #endregion
    }

    internal class AgentFileInfo
    {
    }

    internal class ProviderType
    {
    }

    internal class CacheContainer
    {
        public bool ValueIsInvalid(string value)
        {
            throw new NotImplementedException();
        }
    }

    internal class ProductCatalogue
    {
        public class ProductCatalogTemplate
        {
        }

        public class SubdeviceModel
        {
            public object? TypeName { get; set; }
            public object? Name { get; set; }
        }
    }
}

