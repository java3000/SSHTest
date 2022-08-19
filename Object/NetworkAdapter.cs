namespace SSHTest.Object
{
    internal sealed class NetworkAdapter : Subdevice
    {
        private MACAddress _macAddress;

        internal NetworkAdapter(SubdeviceModel model, Device device)
            : this(model, device, null)
        { }

        internal NetworkAdapter(SubdeviceModel model, Device device, string sourceName)
            : base(model, device, sourceName)
        {
            _macAddress = MACAddress.Zero;
        }

        #region Properties
        internal MACAddress MACAddress
        {
            get { return this._macAddress; }
            set { this._macAddress = value; }
        }
        #endregion
    }
}
