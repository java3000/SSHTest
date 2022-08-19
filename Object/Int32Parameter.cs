
namespace SSHTest.Object
{
    internal sealed class Int32Parameter : Parameter
    {
        private int _value;

        internal Int32Parameter(SubdeviceModel model, string name)
            : base(model, name)
        { }
        
        #region Properties
        internal int Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion
    }
}
