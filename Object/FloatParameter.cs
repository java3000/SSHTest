
namespace SSHTest.Object
{
    internal sealed class FloatParameter : Parameter
    {
        private float _value;

        internal FloatParameter(SubdeviceModel model, string name)
            : base(model, name)
        { }

        #region Properties
        internal float Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion
    }
}
