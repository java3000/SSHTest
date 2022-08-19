
namespace SSHTest.Object
{
    internal class Subdevice : InquiryObjectBase
    {
        #region fields
        private string _externalID;
        private string _serialNumber;
        private string _inventoryNumber;
        private string _code;
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
        private string _userField1;
        private string _userField2;
        private string _userField3;
        private string _userField4;
        private string _userField5;
        private bool _isIntegrated;
        private string _roomName;
        private string _buildingName;
        private string _locationString;
        private string _sourceName;

        private readonly SubdeviceModel _model;
        private readonly Device _device;

        private Guid? _id;
        private ProductCatalogue.SubdeviceModel _subdeviceModelIM;
        private Software.SoftwareLicence.Asset.AssetUser _owner;
        private Software.SoftwareLicence.Asset.AssetUser _utilizer;
        private User _user;
        private Software.SoftwareLicence.Asset.Supplier _supplier;
        #endregion

        #region constructor
        internal Subdevice(SubdeviceModel model, Device device)
            : this(model, device, null)
        { }

        internal Subdevice(SubdeviceModel model, Device device, string sourceName)
            :base()
        {
            if (model == null)
                throw new ArgumentNullException("model");
            if (device == null)
                throw new ArgumentNullException("device");
            //
            _isIntegrated = false;
            _model = model;
            _device = device;
            _sourceName = sourceName ?? device.SourceName;
            _subdeviceModelIM = null;
            _id = null;
            _owner = null;
            _utilizer = null;
            _user = null;
            _supplier = null;
        }
        #endregion

        #region Properties
        internal Guid? IMID
        {
            get { return _id; }
        }

        internal Guid? IMResponsibilityUserID
        {
            get { return _user == null ? null : (Guid?)_user.ID; }
        }

        internal Guid? IMUtilizerID
        {
            get { return _utilizer == null ? null : (Guid?)_utilizer.ID; }
        }

        internal Guid? IMOwnerID
        {
            get { return _owner == null ? null : (Guid?)_owner.ID; }
        }

        internal Guid? IMSupplierID
        {
            get { return _supplier == null ? null : (Guid?)_supplier.ID; }
        }

        internal ProductCatalogue.SubdeviceModel IMSubdeviceModel
        {
            get { return _subdeviceModelIM; }
        }

        internal string IMFullName
        {
            get
            {
                if (_subdeviceModelIM == null)
                    throw new NotSupportedException("model not resolved");
                //
                return string.Format("{0} {1} {2}", _subdeviceModelIM.TypeName, _subdeviceModelIM.Name, _inventoryNumber ?? string.Empty).Trim();
            }
        }

        internal override string SerialNumber
        {
            get { return _serialNumber; }
            set
            {
                _serialNumber = value;
                //
                if (_device.ProcessCache.ValueIsInvalid(_serialNumber))
                    _serialNumber = String.Empty;
            }
        }

        internal override string InventoryNumber
        {
            get { return _inventoryNumber; }
            set
            {
                _inventoryNumber = value;
                //
                if (_device.ProcessCache.ValueIsInvalid(_inventoryNumber))
                    _inventoryNumber = String.Empty;
            }
        }

        internal override string Code
        {
            get { return _code; }
            set
            {
                _code = value;
                //
                if (_device.ProcessCache.ValueIsInvalid(_code))
                    _code = String.Empty;
            }
        }

        internal override string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        internal override string Note
        {
            get { return _note; }
            set { _note = value; }
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

        internal override string ExternalID
        {
            get { return _externalID; }
            set
            {
                _externalID = value;
                //
                if (_device.ProcessCache.ValueIsInvalid(_code))
                    _code = String.Empty;
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

        internal bool IsIntegrated
        {
            get { return _isIntegrated; }
            set { _isIntegrated = value; }
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

        internal SubdeviceModel Model
        {
            get { return _model; }
        }
        internal override string Name { get { return string.Empty; } set { } }
        internal override string ModelExternalID { get { return _model.ExternalID; } set { } }
        internal override string ModelName { get { return _model.Name; } set { } }
        internal override string ManufacturerName { get { return _model.Manufacturer.Name; } set { } }
        internal override string TypeName { get { return _model.TypeName; } set { } }
        

        internal Device Device
        {
            get { return _device; }
        }

        internal override string SourceName
        {
            get { return _sourceName; }
        }
        #endregion

    }

    internal class User
    {
        public Guid? ID;
    }
}
