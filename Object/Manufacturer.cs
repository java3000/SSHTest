namespace SSHTest.Object
{
    internal sealed class Manufacturer
    {
        #region fields
        private string _name;

        private CacheContainer _processCache;
        private Catalogue.Manufacturer _imManufacturer;

        private static Dictionary<Guid, Dictionary<string, Manufacturer>> __cache = new Dictionary<Guid, Dictionary<string, Manufacturer>>();
        #endregion

        #region constructor

        public Manufacturer(string name, CacheContainer processCache)
        {
            if (name == null)
                throw new ArgumentNullException("name");
            if (processCache == null)
                throw new ArgumentNullException("processCache");
            //
            _name = name;
            _processCache = processCache;
            _imManufacturer = null;
        }
        #endregion

        #region Properties
        internal String Name
        {
            get { return this._name; }
        }
        #endregion

        public static Manufacturer Get(string s, CacheContainer processCache)
        {
            return new Manufacturer("this", new CacheContainer());
        }
    }

    internal class Catalogue
    {
        public class Manufacturer
        {
        }
    }
}
