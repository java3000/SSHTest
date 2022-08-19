
namespace SSHTest.Object
{
    internal sealed class Installation
    {
        #region fields
        private readonly SoftwareModel _model;
        private readonly Device _device;
        private DateTime? _installDate;
        private String _productKey;

        private Software.SoftwareModel _softwareModelIM;
        private Software.SoftwareLicence _softwareLicenceIM;
        private Software.SoftwareLicenceSerialNumber _softwareLicenceSerialNumberIM;
        private Guid? _idIM;
        private readonly List<SecurityLogEvent> _securityLogEventList;
        private string _registryID;
        private DateTime? _lastDetectedDate;
        #endregion

        #region constructor
        internal Installation(SoftwareModel model, Device device, string registryID)
        {
            if (model == null)
                throw new ArgumentNullException("model");
            if (device == null)
                throw new ArgumentNullException("device");
            //
            _model = model;
            _device = device;
            //
            _softwareModelIM = null;
            _softwareLicenceIM = null;
            _softwareLicenceSerialNumberIM = null;
            _idIM = null;
            _registryID = registryID ?? string.Empty;
            //
            _securityLogEventList = new List<SecurityLogEvent>();
        }
        #endregion

        #region Properties
        internal DateTime? InstallDate
        {
            get { return _installDate; }
            set { _installDate = value; }
        }

        internal DateTime? LastDetectedDate
        {
            get { return _lastDetectedDate; }
            set { _lastDetectedDate = value; }
        }

        /// <summary>
        /// Ключ продукта
        /// </summary>
        internal String ProductKey
        {
            get { return _productKey; }
            set { _productKey = value; }
        }

        internal SoftwareModel Model
        {
            get { return _model; }
        }

        internal Software.SoftwareModel IMSoftwareModel
        {
            get { return _softwareModelIM; }
        }
        internal Software.SoftwareLicence IMSoftwareLicence
        {
            get { return _softwareLicenceIM; }
        }
        internal Software.SoftwareLicenceSerialNumber IMSoftwareLicenceSerialNumber
        {
            get { return _softwareLicenceSerialNumberIM; }
        }

        public string FullName
        {
            get
            {
                return _softwareModelIM.ShortFullName;
            }
        }

        internal Guid? IMID
        {
            get { return _idIM; }
        }

        internal string RegistryID
        {
            get { return _registryID; }
        }

        public List<SecurityLogEvent> SecurityLogEventList { get { return _securityLogEventList; } }
        #endregion
        
    }

    public class Software
    {
        public class SoftwareModel
        {
            public object ID;
            public string ShortFullName { get; set; }
        }

        public class SoftwareLicence
        {
            public object? FullName { get; set; }
            public class Asset
            {
                public static object? InvNumber { get; set; }

                public class AssetUser
                {
                    public Guid? ID;
                }

                public class Supplier
                {
                    public Guid? ID;
                }
            }
        }

        public class SoftwareLicenceSerialNumber
        {
        }
    }

    internal class SecurityLogEvent
    {
    }
}
