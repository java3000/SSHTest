namespace SSHTest.Object
{
    internal sealed class Motherboard : Subdevice
    {
        #region fields
        private string _biosString;
        private string _biosVersion;
        private DateTime? _biosDate;
        private readonly SlotList _slotList;
        #endregion

        #region constructor
        internal Motherboard(SubdeviceModel model, Device device)
            : this(model, device, null)
        { }

        internal Motherboard(SubdeviceModel model, Device device, string sourceName)
            : base(model, device, sourceName)
        {
            _slotList = new SlotList();
        }
        #endregion


        #region internal method AddSlot
        internal void AddSlot()
        {
            _slotList.Add(new Slot(_slotList.Count, this));
        }
        #endregion

        #region Properties
        internal string BIOSString
        {
            get { return _biosString; }
            set { _biosString = value; }
        }

        internal string BIOSVersion
        {
            get { return _biosVersion; }
            set { _biosVersion = value; }
        }

        internal DateTime? BIOSDate
        {
            get { return _biosDate; }
            set { _biosDate = value; }
        }

        internal SlotList SlotList
        {
            get { return _slotList; }
        }
        #endregion
    }
}
