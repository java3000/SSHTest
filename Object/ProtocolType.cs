namespace SSHTest.Object
{
    /// <summary>
    /// should be updated from CIM.Device.CIM_Controller.ProtocolSupported
    /// </summary>
    internal enum ProtocolType : byte
    {
        Other = 1,
        Unknown = 2,
        EISA = 3,
        ISA = 4,
        PCI = 5,
        ATA_ATAPI = 6, //ATA/ATAPI
        Flexible_Diskette = 7, //Flexible Diskette 
        _1496 = 8, //1496
        SCSI_Parallel_Interface = 9, //SCSI Parallel Interface
        SCSI_Fibre_Channel_Protocol = 10, //SCSI Fibre Channel Protocol
        SCSI_Serial_Bus_Protocol = 11, //SCSI Serial Bus Protocol
        SCSI_Serial_Bus_Protocol_2_1394 = 12, //SCSI Serial Bus Protocol-2 (1394)
        SCSI_Serial_Storage_Architecture = 13, //SCSI Serial Storage Architecture
        VESA = 14,
        PCMCIA = 15,
        Universal_Serial_Bus = 16, //Universal Serial Bus
        Parallel_Protocol = 17, //Parallel Protocol
        ESCON = 18,
        Diagnostic = 19,
        I2C = 20,
        Power = 21,
        HIPPI = 22,
        MultiBus = 23,
        VME = 24,
        IPI = 25,
        IEEE_488 = 26, //IEEE-488
        RS232 = 27,
        IEEE_802_3_10BASE5 = 28, //IEEE 802.3 10BASE5
        IEEE_802_3_10BASE2 = 29, //IEEE 802.3 10BASE2
        IEEE_802_3_1BASE5 = 30, //IEEE 802.3 1BASE5
        IEEE_802_3_10BROAD36 = 31, //IEEE 802.3 10BROAD36
        IEEE_802_3_100BASEVG = 32, //IEEE 802.3 100BASEVG
        IEEE_802_5_Token_Ring = 33, //IEEE 802.5 Token-Ring
        ANSI_X3T9_5_FDDI = 34, //ANSI X3T9.5 FDDI
        MCA = 35,
        ESDI = 36,
        IDE = 37,
        CMD = 38,
        ST506 = 39,
        DSSI = 40,
        QIC2 = 41,
        Enhanced_ATA_IDE = 42, //Enhanced ATA/IDE 
        AGP = 43,
        TWIRP_two_way_infrared = 44, //TWIRP (two-way infrared)
        FIR_fast_infrared = 45, //FIR (fast infrared)
        SIR_serial_infrared = 46, //SIR (serial infrared)
        IrBus = 47,
        Serial_ATA = 48 //Serial ATA
    }

    internal static class ProtocolTypeConverter
    {
        private static readonly string[] __names;



        static ProtocolTypeConverter()
        {
            __names = new string[] { 
                "Other", "Unknown", "EISA", "ISA", "PCI", 
                "ATA/ATAPI", "Flexible Diskette", "1496", 
                "SCSI Parallel Interface", 
                // 10               
                "SCSI Fibre Channel Protocol", 
                "SCSI Serial Bus Protocol", 
                "SCSI Serial Bus Protocol-2 (1394)", 
                "SCSI Serial Storage Architecture", "VESA", "PCMCIA", 
                "Universal Serial Bus", "Parallel Protocol", "ESCON", 
                "Diagnostic", 
                // 20               
                "I2C", "Power", "HIPPI", "MultiBus", "VME", "IPI", "IEEE-488", 
                "RS232", "IEEE 802.3 10BASE5", "IEEE 802.3 10BASE2", 
                // 30               
                "IEEE 802.3 1BASE5", 
                "IEEE 802.3 10BROAD36", "IEEE 802.3 100BASEVG", 
                "IEEE 802.5 Token-Ring", "ANSI X3T9.5 FDDI", "MCA", 
                "ESDI", "IDE", "CMD", "ST506", 
                // 40               
                "DSSI", "QIC2", 
                "Enhanced ATA/IDE", "AGP", "TWIRP (two-way infrared)", 
                "FIR (fast infrared)", "SIR (serial infrared)", "IrBus", 
                "Serial ATA" 
            };
        }



        public static string GetName(ProtocolType protocolType)
        {
            return __names[(byte)protocolType - 1];
        }

        public static ProtocolType GetProtocolType(string protocolType)
        {
            for (int i = 0; i < __names.Length; i++)
            {
                if (string.Compare(__names[i], protocolType, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return (ProtocolType)(i+1);
                }
            }
            //
            return ProtocolType.Unknown;
        }
    }
}
