namespace Airport.Plugins.Service.Settings
{
    using System.Configuration;

    public class PluginConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("Plugins")]
        public PluginsCollection Plugins => (PluginsCollection)base["Plugins"]; 
    }

    [ConfigurationCollection(typeof(PluginElement))]
    public class PluginsCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement() =>  new PluginElement();

        protected override object GetElementKey(ConfigurationElement element) => ((PluginElement)(element)).Key;
        public PluginElement this[int idx] => (PluginElement)BaseGet(idx);
    }
    public class PluginElement : ConfigurationElement
    {
        [ConfigurationProperty("key", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string Key => (string)base["key"];

        [ConfigurationProperty("objectType", DefaultValue = "", IsKey = false, IsRequired = true)]
        public string ObjectType => (string) base["objectType"];

        [ConfigurationProperty("name", DefaultValue = "", IsKey = false, IsRequired = false)]
        public string Name => (string)base["name"];

        [ConfigurationProperty("methodName", DefaultValue = "", IsKey = false, IsRequired = false)]
        public string MethodName => (string) base["methodName"];
    }
}
