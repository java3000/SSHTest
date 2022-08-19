
namespace SSHTest.Object
{
    internal sealed class ByteParameter : Parameter
    {
        private byte _value;

        internal ByteParameter(SubdeviceModel model, string name)
            : base(model, name)
        { }

        #region Properties
        internal byte Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion
    }
}
