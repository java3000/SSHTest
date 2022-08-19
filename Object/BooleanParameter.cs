
namespace SSHTest.Object
{
    internal sealed class BooleanParameter : Parameter
    {
        private bool _value;

        internal BooleanParameter(SubdeviceModel model, string name)
            : base(model, name)
        { }


        #region Properties
        internal bool Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion
    }
}
