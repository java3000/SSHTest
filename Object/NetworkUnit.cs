//using InfraManager.Core.Data;
//using InfraManager.Core.Extensions;
//using InfraManager.IM.BusinessLayer.Inquiry.Comparison;
//using InfraManager.IM.BusinessLayer.Inquiry.Comparison.Fields;
//using InfraManager.IM.BusinessLayer.Inquiry.Object.DeviceWorker;
//using InfraManager.IM.DAL.Asset;
//using InfraManager.IM.DAL.Configuration;
//using System;
//using System.Collections.Generic;

//namespace InfraManager.IM.BusinessLayer.Inquiry.Object
//{
//    //Не забываем про отклонения, в которых сериализованы эти данные, см. Deviation
//    //Пока не используется метод CreateNetworkUnit реализовали в Device
//    internal class NetworkUnit : InquiryObjectBase
//    {
//        #region fields
//        private DateTime _inquireDate;
//        private string _name;
//        private CacheContainer _cache;
//        private readonly ConnectionList _connectionList;
//        private readonly ProviderType _providerType;
//        private readonly string _sourceName;
//        #endregion

//        #region constructor
//        internal NetworkUnit(string name, DateTime inquireDate, ProviderType providerType, string sourceName, CacheContainer cache)
//            : base()
//        {
//            if (name == null)
//                throw new ArgumentNullException("name");
//            if (cache == null)
//                throw new ArgumentNullException("cache");
//            //
//            _inquireDate = inquireDate;
//            _cache = cache;
//            //
//            _name = name;
//            _connectionList = new ConnectionList();
//            _providerType = providerType;
//            _sourceName = sourceName;
//            this.DeviceClassID = 0;
//        }
//        #endregion


//        #region method Resolve
//        internal void Resolve()
//        {
//            //create manufacturer / model / type, search exists objects, search in synonyms
//        }
//        #endregion

//        #region internal method ToOldStructure
//        internal void ToOldStructure()
//        {
//            this.Resolve();
//            //
//            _cache.ExecuteCommitted((dataSource) =>
//            {
//                try
//                {
//                    //var undisposedDevice = new UndisposedDevice(this);
//                    //undisposedDevice.Insert(dataSource);
//                }
//                catch
//                {
//                    throw;
//                }
//            },
//                "Ошибка сохранения неразмещенного оборудования.");
//        }
//        #endregion

//        #region Properities
//        internal ProviderType ProviderType { get { return _providerType; } }
//        internal override string SourceName { get { return _sourceName; } }

//        internal int DeviceClassID { get; set; }

//        internal DateTime InquireDate
//        {
//            get { return this._inquireDate; }
//        }

//        internal override string Name
//        {
//            get { return _name; }
//            set
//            {
//                if (_cache.ValueIsInvalid(value))
//                    return;
//                _name = value;
//            }
//        }

//        internal CacheContainer ProcessCache
//        {
//            get { return _cache; }
//        }


//        internal ConnectionList ConnectionList
//        {
//            get { return this._connectionList; }
//        }

//        internal override string ModelExternalID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string ModelName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string ManufacturerName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string ExternalID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string SerialNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string InventoryNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string Code { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string Note { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override DateTime? DateReceived { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override decimal? Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override DateTime? Warranty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string Agreement { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string Founding { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string ResponsibleUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string OwningOrganization { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string UtilizerName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string SupplierName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string SupplierExternalID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string UserField1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string UserField2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string UserField3 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string UserField4 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string UserField5 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string RoomName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string BuildingName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string LocationString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        internal override string TypeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        #endregion


//        #region static method GetSourceIPAddress
//        internal static InfraManager.Net.IPAddress GetSourceIPAddress(Object.NetworkUnit source)
//        {
//            if (source.ConnectionList.Count == 0)
//                return null;
//            return source.ConnectionList[0].IPAddress;
//        }
//        #endregion

//        #region static method GetSourceSubnetAddress
//        internal static InfraManager.Net.IPAddress GetSourceSubnetAddress(Object.NetworkUnit source)
//        {
//            if (source.ConnectionList.Count == 0)
//                return null;
//            return source.ConnectionList[0].SubnetMask;
//        }
//        #endregion

//        #region SetPropertyByParameterTemplate
//        /// <summary>
//        /// анализ дополнительных параметров при snmp опросе. Только при снмп!
//        /// </summary>
//        /// <param name="sensor"></param>
//        internal void SetPropertyByParameterTemplate(InfraManager.IM.BusinessLayer.Inquiry.SnmpDevice.SnmpDeviceSensor sensor, String sensorResponce)
//        {
//            if (sensor == null)
//                throw new NullReferenceException("Sensor value is not valid");
//            //
//            DeviceParameterTemplate template = (DeviceParameterTemplate)sensor.Parameter;
//            if (template == DeviceParameterTemplate.Default)
//                return;
//            //
//            var type = typeof(DeviceParameterTemplate);
//            var memInfo = type.GetMember(template.ToString());
//            if (memInfo == null || memInfo.Length == 0)
//                throw new NotSupportedException(String.Format("Этот параметр не существует: {0}", template.ToString()));
//            //
//            var attributes = memInfo[0].GetCustomAttributes(typeof(ParameterResolve), false);
//            if (attributes == null || attributes.Length == 0)
//                throw new NotSupportedException(String.Format("Отсуствует атрибут ParameterResolve у параметра {0}", template.ToString()));
//            //
//            var worker = ((ParameterResolve)attributes[0]).Worker;
//            if (worker == null)
//                throw new NotSupportedException(String.Format("Отсуствует обработчик Worker у параметра {0}", template.ToString()));
//            //
//            //if (worker.IsValid(this, sensor, sensorResponce))
//            //    worker.ResolveAction(this, sensor, sensorResponce);
//        }
//        #endregion

//        #region static method GetSourceMACAddress
//        internal static InfraManager.Net.MACAddress GetSourceMACAddress(Object.NetworkUnit source)
//        {
//            if (source.ConnectionList.Count == 0)
//                return null;
//            return source.ConnectionList[0].MACAddress;
//        }
//        #endregion

//        #region static method GetSourceNote
//        internal static string GetSourceNote(string typeName, string modelName, string manufacturerName/*, string logonDomain, string userName*/)
//        {
//            var tmp = string.Format("{0} {1} {2}{3}",
//                        string.IsNullOrWhiteSpace(typeName) ? string.Empty : typeName,
//                        string.IsNullOrWhiteSpace(manufacturerName) ? string.Empty : manufacturerName,
//                        string.IsNullOrWhiteSpace(modelName) ? string.Empty : modelName).
//                        //string.IsNullOrWhiteSpace(logonDomain) || string.IsNullOrWhiteSpace(userName) ? string.Empty : string.Concat(", ", logonDomain, "\\", userName)).
//                        Trim();
//            if (tmp.StartsWith(", "))
//                tmp = tmp.Remove(0, 2);
//            return tmp;
//        }

//        internal static string GetSourceNote(Object.NetworkUnit source)
//        {
//            return GetSourceNote(source.TypeName, source.ModelName, source.ManufacturerName/*, source.LogonDomain, source.UserName*/);
//        }
//        #endregion

//        #region method CreateNetworkUnit
//        internal Configuration.ConfigurationUnit CreateNetworkUnit(DataSource dataSource)
//        {
//            Configuration.ConfigurationUnit retval = new Configuration.ConfigurationUnit();
//            //
//            retval.Type = ProductCatalogue.ProductCatalogType.Get(Guid.Parse("00000000-0000-0000-0000-000000000409"), dataSource);
//            //
//            return retval;
//        }
//        #endregion

//        #region static method GetBundleFields
//        internal static BundleFieldBase[] GetBundleFields(Configuration.IDevice target, NetworkUnit source)
//        {
//            if (target == null)
//                throw new ArgumentNullException("device");
//            if (source == null)
//                throw new ArgumentNullException("source");
//            //
//            List<BundleFieldBase> retval = new List<BundleFieldBase>();
//            //
//            retval.AddRange(new BundleFieldBase[]  {
//                new BundleFieldString(InquiryFieldType.Name, () => target.Name, (x) => target.Name = x, () => source.Name.Truncate(TerminalDeviceDescriptor.Name_MaxLength)),
//                new BundleFieldIP(InquiryFieldType.IP, () => target.IPAddress, (x) => target.IPAddress = x, () => GetSourceIPAddress(source)),
//            });
//            retval.AddRange(GetBundleFields(target.Asset, source));
//            //
//            return retval.ToArray();
//        }

//        internal static BundleFieldBase[] GetBundleFields(Configuration.IDevice target, Configuration.IDevice source, CacheContainer processCache)
//        {
//            if (target == null)
//                throw new ArgumentNullException("device");
//            if (source == null)
//                throw new ArgumentNullException("source");
//            if (processCache == null)
//                throw new ArgumentNullException("processCache");
//            //
//            List<BundleFieldBase> retval = new List<BundleFieldBase>();
//            Guid? csManufacturerID = source.CsManufacturerID;
//            int? csManufacturerIntID = source.CsManufacturerIntID;
//            string csManufacturerName = source.CsManufacturerName;
//            //
//            retval.AddRange(new BundleFieldBase[]  {
//                new BundleFieldString(InquiryFieldType.Name, () => target.Name, (x) => target.Name = x, () => source.Name),
//                new BundleFieldIP(InquiryFieldType.IP, () => target.IPAddress, (x) => target.IPAddress = x, () => source.IPAddress),
//            });
//            retval.AddRange(GetBundleFields(target.Asset, source.Asset, processCache));
//            //
//            return retval.ToArray();
//        }

//        private static BundleFieldBase[] GetBundleFields(Asset.AssetFields target, NetworkUnit source)
//        {
//            var processCache = source.ProcessCache;
//            //
//            return new BundleFieldBase[] {
//                new BundleFieldDateTimeNullable(InquiryFieldType.DateInquiry, () => target.DateInquiry, (x) => target.DateInquiry = x, () => source.InquireDate),
//            };
//        }

//        private static BundleFieldBase[] GetBundleFields(Asset.AssetFields target, Asset.AssetFields source, CacheContainer processCache)
//        {
//            return Subdevice.GetBundleFields(target, source, processCache);
//        }
//        #endregion
//    }
//}

