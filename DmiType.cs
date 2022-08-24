namespace SSHTest;

public enum DmiType : int
{
    Bios = 0,
    System = 1,
    Motherboard,
    Chasis,
    Processor,
    MemoryController,
    MemoryModule,
    Cache,
    PortConnector,
    SystemSlot,
    OemBoardDevice,
    OemStrings,
    SystemConfigurationOption,
    BiosLanguage,
    GroupAssotiations,
    SystemEventLog,
    PhysicalMemoryArray,
    MemoryDevice,
    MemoryError32Bit,
    MemoryArrayMappedAddress,
    MemoryDeviceMappedAddress,
    BuiltInPointingDevice,
    PortableBattery,
    SystemReset,
    HardwareSecurity,
    SystemPowerControls,
    VoltageProbe,
    CoolingDevice,
    TemperatureProbe,
    ElectricalCurrentProbe,
    OutOfBandRemoteAccess,
    BootIntegrityServices,
    SystemBoot,
    MemoryError64Bit,
    ManagementDevice,
    ManagementDeviceComponent,
    ManagementDeviceThresholdData,
    MemoryChannel,
    IpmiDevice,
    PowerSupply,
    AdditionalInformation,
    OnboardDevice

}

internal class DmiConverter
{
    public static string GetName(DmiType type)
    {
        switch (type)
        {
            case DmiType.Bios:
                return "BIOS Information";
            case DmiType.System:
                return "System Information";
            case  DmiType.Motherboard:
                return "Base Board Information";
            case DmiType.Chasis:
                return "Chassis Information";
            case DmiType.Processor:
                return "Processor Information";
            case DmiType.MemoryController:
                return "Memory Controller Information";
            case DmiType.MemoryModule:
                return "Memory Module Information";
            case DmiType.Cache:
                return "Cache Information";
            case DmiType.PortConnector:
                return "Port Connector Information";
            case DmiType.SystemSlot:
                return "System Slot Information";
            case DmiType.OemBoardDevice:
                return "On Board Device Information"; //On Board Device X Information, X=1,2,3...
            case DmiType.OemStrings:
                return "OEM Strings";
            case DmiType.SystemConfigurationOption:
                return "";
            case DmiType.BiosLanguage:
                return "";
            case DmiType.GroupAssotiations:
                return "";
            case DmiType.SystemEventLog:
                return "System Event Log";
            case DmiType.PhysicalMemoryArray:
                return "Physical Memory Array";
            case DmiType.MemoryDevice:
                return "Memory Device";
            case DmiType.MemoryError32Bit:
                return "32-bit Memory Error Information";
            case DmiType.MemoryArrayMappedAddress:
                return "Memory Array Mapped Address";
            case DmiType.MemoryDeviceMappedAddress:
                return "Memory Device Mapped Address";
            case DmiType.BuiltInPointingDevice:
                return "";
            case DmiType.PortableBattery:
                return "";
            case DmiType.SystemReset:
                return "System Reset";
            case DmiType.HardwareSecurity:
                return "Hardware Security";
            case DmiType.SystemPowerControls:
                return "";
            case DmiType.VoltageProbe:
                return "";
            case DmiType.CoolingDevice:
                return "";
            case DmiType.TemperatureProbe:
                return "";
            case DmiType.ElectricalCurrentProbe:
                return "";
            case DmiType.OutOfBandRemoteAccess:
                return "Out-of-band Remote Access";
            case DmiType.BootIntegrityServices:
                return "";
            case DmiType.SystemBoot:
                return "System Boot Information";
            case DmiType.MemoryError64Bit:
                return "64-bit Memory Error Information";
            case DmiType.ManagementDevice:
                return "";
            case DmiType.ManagementDeviceComponent:
                return "";
            case DmiType.ManagementDeviceThresholdData:
                return "";
            case DmiType.MemoryChannel:
                return "";
            case DmiType.IpmiDevice:
                return "";
            case DmiType.PowerSupply:
                return "";
            case DmiType.AdditionalInformation:
                return "";
            case DmiType.OnboardDevice:
                return "";
            
        }
        return "Неизвестно";
    }
}