
namespace SSHTest.Object
{
    internal class LogicalDrive
    {
        #region fields
        private char _caption;
        private LogicalDriveType _driveType;
        private string _label;
        private string _fileSystem;
        private string _serialNumber;
        private int _size;
        private int _freeSize;
        private readonly Device _device;
        #endregion

        #region constructor
        internal LogicalDrive(char caption, LogicalDriveType driveType, Device device)
        {
            if (device == null)
                throw new ArgumentNullException("device");
            //
            _caption = caption;
            _driveType = driveType;
            _device = device;
        }
        #endregion

        #region Properties
        internal char Caption
        {
            get { return _caption; }
        }

        internal LogicalDriveType DriveType
        {
            get { return _driveType; }
        }

        internal string SerialNumber
        {
            get { return _serialNumber; }
            set { _serialNumber = value; }
        }

        internal string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        internal string FileSystem
        {
            get { return _fileSystem; }
            set { _fileSystem = value; }
        }

        internal int Size
        {
            get { return _size; }
            set
            {
                _size = value;
                if (_size < 0)
                    _size = 0;
            }
        }

        internal int FreeSize
        {
            get { return _freeSize; }
            set
            {
                _freeSize = value;
                if (_freeSize < 0)
                    _freeSize = 0;
            }
        }
        #endregion
    }
}
