namespace SSHTest.Object
{
    internal sealed class ParameterList : List<Parameter>
    {
        #region Properties
        internal Parameter this[string name]
        {
            get
            {
                foreach (Parameter param in this)
                {
                    if (param.Name == name)
                    {
                        return param;
                    }
                }
                //
                throw new ArgumentException("No such parameter in list.", name);
            }
        }
        #endregion
    }
}
