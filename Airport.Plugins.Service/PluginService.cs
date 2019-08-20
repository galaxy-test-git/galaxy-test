namespace Airport.Plugins.Service
{
    using System;
    using System.IO;
    using System.Configuration;
    using System.Reflection;
    using Settings;

    public class PluginService
    {
        public bool Check(object model)
        {
            var types = model.GetType().ToString().Split('.');
            var section = (PluginConfigurationSection)ConfigurationManager.GetSection("DllPlugins"); ;

            if (section?.Plugins.Count > 0 && types.Length > 0)
            {
                var type = types[types.Length - 1] + "Plugin";

                for (var i = 0; i < section.Plugins.Count; i++)
                {
                    var pluginName = section.Plugins[i].Name.Trim();

                    if (pluginName.Equals(type))
                    {
                        var pathToDll =
                            Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)
                                ?.Replace("file:\\", "") + $"\\{pluginName}.dll";

                        if (!File.Exists(pathToDll))
                            return true;

                        var dll = Assembly.LoadFile(pathToDll);
                        var theType = dll.GetType($"{pluginName}.{pluginName}");
                        var c = Activator.CreateInstance(theType);
                        var method = theType.GetMethod(section.Plugins[i].MethodName);

                        if (method == null)
                            return true;
                        
                        if(!(bool)method.Invoke(c, new[] { model }))
                            return false;
                    }
                }
            }

            return true;
        }
    }
}
