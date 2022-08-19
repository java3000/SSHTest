namespace SSHTest.Object
{
    /// <summary>
    /// there is no analogue in CIM
    /// </summary>
    internal enum LogicalDriveType : byte
    {
        Unknown = 1,
        Removable_drive = 2,
        Local_hard_disk = 3,
        Network_disk = 4,
        Compact_disk = 5,
        RAM_disk = 6
    }

    internal class LogicalDriveTypeConverter
    {
        public static string GetName(LogicalDriveType type)
        {
            switch (type)
            {
                case LogicalDriveType.Compact_disk:
                    return "Компакт-диск";
                case LogicalDriveType.Local_hard_disk:
                    return "Локальный жесткий диск";
                case LogicalDriveType.Network_disk:
                    return "Сетевой диск";
                case LogicalDriveType.RAM_disk:
                    return "Виртуальный диск";
                case LogicalDriveType.Removable_drive:
                    return "Съемный диск";
                case LogicalDriveType.Unknown:
                    return "Неизвестно";
            }
            //
            return "Неизвестно";
        }
    }
}
