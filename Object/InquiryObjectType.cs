namespace SSHTest;

public enum InquiryObjectType : long
{
    Adapter = (long)1,
    Controller = (long)1 << 1 | Adapter,
    Motherboard = (long)1 << 2 | Adapter,
    MediaAccessDevice = (long)1 << 3 | Adapter,
    DisketteDrive = (long)1 << 4 | MediaAccessDevice,
    DiskDrive = (long)1 << 5 | MediaAccessDevice,
    CDDVDDrive = (long)1 << 6 | MediaAccessDevice,
    //CDDrive = (long)1 << 7 | MediaAccessDevice,
    Processor = (long)1 << 8 | Adapter,
    AuidioCard = (long)1 << 9 | Adapter,
    VideoAdapter = (long)1 << 10 | Adapter,
    Memory = (long)1 << 11 | Adapter,
    NetworkAdapter = (long)1 << 12 | Adapter,

    Peripheral = (long)1 << 22,
    StandartPeripheral = (long)1 << 23 | Peripheral,
    Monitor = (long)1 << 24 | Peripheral,
    Keyboard = (long)1 << 25 | Peripheral,
    Printer = (long)1 << 26 | Peripheral,
    PointingDevice = (long)1 << 27 | Peripheral,
    //Scanner = (long)1 << 28 | Peripheral,
    //Phone = (long)1 << 23 | Peripheral,

    ModemAdapter = (long)1 << 13 | Adapter,
    ModemPeripheral = (long)1 << 13 | Peripheral,
    Modem = ModemAdapter | ModemPeripheral,

    Software = (long)1 << 44,
    SoftwareUpdate = (long)1 << 45 | Software,
    SecurityLog = (long)1 << 46 | Software,

    LogicalDrive = (long)1 << 50,

    CatalogOnly = (long)1 << 51,

    AgentFiles = (long)1 << 52,

    All = long.MaxValue,
}