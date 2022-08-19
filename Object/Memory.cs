
namespace SSHTest.Object
{
    internal sealed class Memory : Subdevice
    {
        private int _speed;
        private int _capacity;

        internal Memory(SubdeviceModel model, Device device)
           : this(model, device, null)
        { }

        internal Memory(SubdeviceModel model, Device device, string sourceName)
            : base(model, device, sourceName)
        { }

        #region Properties
        internal int Speed
        {
            get { return _speed; }
            set
            {
                _speed = value;
                if (_speed < 0)
                {
                    _speed = 0;
                }
            }
        }

        internal int Capacity
        {
            get { return _capacity; }
            set
            {
                _capacity = value;
                if (_capacity < 0)
                {
                    _capacity = 0;
                }
            }
        }
        #endregion
    }
}
