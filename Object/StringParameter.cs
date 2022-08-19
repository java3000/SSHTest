
namespace SSHTest.Object
{
    internal sealed class StringParameter : Parameter
    {
        private string _value = string.Empty;

        internal StringParameter(SubdeviceModel model, string name)
            : base(model, name)
        { }

        #region Properties
        internal string Value
        {
            get { return _value; }
            set
            {
                _value = value ?? string.Empty;
            }
        }
        #endregion
    }
}
