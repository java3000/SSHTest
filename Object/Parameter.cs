
namespace SSHTest.Object
{
    internal abstract class Parameter
    {
        #region Names
        internal const string CONTROLLER_PROTOCOLSUPPORTED = "ProtocolSupported";
        internal const string CONTROLLER_MAXNUMBERCONTROLLED = "MaxNumberControlled";

        internal const string MOTHERBOARD_CHIPSET = "Chipset";
        internal const string MOTHERBOARD_SOCKETTYPE = "SocketType";
        internal const string MOTHERBOARD_SOCKETTYPENAME = "SocketTypeName";
        internal const string MOTHERBOARD_PRIMARYBUSTYPE = "PrimaryBusType";
        internal const string MOTHERBOARD_SECONDARYBUSTYPE = "SecondaryBusType";

        internal const string DISKDRIVE_SIZE = "Size";
        internal const string DISKDRIVE_INTERFACETYPE = "InterfaceType";

        internal const string OPTICALDRIVE_MAXREADSPEED = "MaxReadSpeed";
        internal const string OPTICALDRIVE_MAXWRITESPEED = "MaxWriteSpeed";

        internal const string PROCESSOR_FAMILY = "Family";
        internal const string PROCESSOR_FAMILYNAME = "FamilyName";
        internal const string PROCESSOR_MAXCLOCKSPEED = "MaxClockSpeed";
        internal const string PROCESSOR_SOCKETTYPE = "SocketType";
        internal const string PROCESSOR_SOCKETTYPENAME = "SocketTypeName";
        internal const string PROCESSOR_ADDRESSWIDTH = "AddressWidth";
        internal const string PROCESSOR_L1CACHESIZE = "L1CacheSize";
        internal const string PROCESSOR_L2CACHESIZE = "L2CacheSize";

        internal const string VIDEOADAPTER_MEMORYSIZE = "MemorySize";
        internal const string VIDEOADAPTER_CHIP = "Chip";
        internal const string VIDEOADAPTER_DAC = "DAC";
        internal const string VIDEOADAPTER_BIOSSTRING = "BIOSString";

        internal const string MEMORY_FORMFACTOR = "FormFactor";
        internal const string MEMORY_MEMORYTYPE = "MemoryType";

        internal const string NETWORKADAPTER_MAXSPEED = "MaxSpeed";



        internal const string MONITOR_BANDWIDTH = "Bandwidth";
        internal const string MONITOR_SCREENHEIGHT = "ScreenHeight";
        internal const string MONITOR_SCREENWIDTH = "ScreenWidth";

        internal const string KEYBOARD_NUMBEROFFUNCTIONKEYS = "NumberOfFunctionKeys";

        internal const string PRINTER_COLORPRINTINGSUPPORTED = "ColorPrintingSupported";
        internal const string PRINTER_TWOSIDEPRINTINGSUPPORTED = "TwoSidePrintingSupported";
        internal const string PRINTER_HORIZONTALRESOLUTION = "HorizontalResolution";
        internal const string PRINTER_VERTICALRESOLUTION = "VerticalResolution";

        internal const string POINTINGDEVICE_POINTINGTYPE = "PointingType";
        internal const string POINTINGDEVICE_POINTINGTYPENAME = "PointingTypeName";
        internal const string POINTINGDEVICE_NUMBEROFBUTTONS = "NumberOfButtons";



        internal const string MODEM_DATARATE = "DataRate";
        internal const string MODEM_INTERNAL = "Internal";
        internal const string MODEM_MODEMTYPE = "ModemType";
        internal const string MODEM_MODEMTYPENAME = "ModemTypeName";
        #endregion


        #region fields
        private string _name;
        private readonly SubdeviceModel _model;
        #endregion

        #region constructor
        protected Parameter(SubdeviceModel model, string name)
        {
            if (model == null)
                throw new ArgumentNullException("model");
            if (name == null)
                throw new ArgumentNullException("name");
            //
            _model = model;
            _name = name;
        }
        #endregion


        #region Properties
        internal string Name
        {
            get { return _name; }
        }

        internal SubdeviceModel Model
        {
            get { return _model; }
        }
        #endregion
    }
}
