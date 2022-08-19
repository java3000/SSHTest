namespace SSHTest.Object
{
    internal sealed class Slot
    {
        #region fields
        private int _number;
        private Subdevice _base;
        private Subdevice _plugin;
        #endregion

        #region constructor
        internal Slot(int number, Subdevice @base)
        {
            if (@base == null)
                throw new ArgumentNullException("@base");
            //
            _number = number;
            _base = @base;
        }
        #endregion

        #region Properties
        internal int Number
        {
            get { return _number; }
        }

        internal Subdevice Plugin
        {
            get { return _plugin; }
            set { _plugin = value; }
        }
        #endregion
    }
}
