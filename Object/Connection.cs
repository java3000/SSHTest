using System.Net;

namespace SSHTest.Object
{
    internal sealed class Connection
    {
        #region fields
        private readonly Device _device;
        private bool _isPrimary;
        //
        private IPAddress _ipAddress;
        private IPAddress _subnetMask;
        private MACAddress _macAddress;
        //
        private IPAddress _defaultGateway;
        private IPAddress _preferredDNSServer;
        private IPAddress _alternateDNSServer;
        private IPAddress _preferredWINSServer;
        private IPAddress _alternateWINSServer;
        private IPAddress _DHCP;
        //
        private String _connectionName;
        private int _connectionSpeed; //Mbps
        #endregion

        #region constructor
        internal Connection(IPAddress ipAddress, IPAddress subnetMask, MACAddress macAddress, Device device)
        {
            //if (ipAddress == null) дефект 5825 
            //    throw new ArgumentNullException("ipAddress");
            if (subnetMask == null)
                throw new ArgumentNullException("subnetMask");
            if (device == null)
                throw new ArgumentNullException("device");
            //
            _device = device;
            //
            _ipAddress = ipAddress;
            _subnetMask = subnetMask;
            _macAddress = macAddress;
            _isPrimary = false;
        }
        #endregion

        #region Properties
        internal IPAddress IPAddress
        {
            get { return this._ipAddress; }
        }

        internal IPAddress SubnetMask
        {
            get { return this._subnetMask; }
        }

        internal MACAddress MACAddress
        {
            get { return _macAddress; }
        }

        internal IPAddress DefaultGateway
        {
            get { return this._defaultGateway; }
            set { this._defaultGateway = value; }
        }

        internal IPAddress PreferredDNSServer
        {
            get { return this._preferredDNSServer; }
            set { this._preferredDNSServer = value; }
        }

        internal IPAddress AlternateDNSServer
        {
            get { return this._alternateDNSServer; }
            set { this._alternateDNSServer = value; }
        }

        internal IPAddress PreferredWINSServer
        {
            get { return this._preferredWINSServer; }
            set { this._preferredWINSServer = value; }
        }

        internal IPAddress AlternateWINSServer
        {
            get { return this._alternateWINSServer; }
            set { this._alternateWINSServer = value; }
        }

        internal IPAddress DHCP
        {
            get { return this._DHCP; }
            set { this._DHCP = value; }
        }

        internal String ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        internal int ConnectionSpeed
        {
            get { return this._connectionSpeed; }
            set { this._connectionSpeed = value; }
        }

        internal bool IsPrimary
        {
            get { return _isPrimary; }
            set { _isPrimary = value; }
        }
        #endregion
    }

    internal class MACAddress
    {
        public MACAddress? Zero { get; set; }
    }
}
