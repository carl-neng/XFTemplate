using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace XfTemplate.AppSettings
{
    public class ConstantAppSetting
    {
        public static string AppSettings(string key)
        {
            foreach (Add t in GetSetting().Add)
            {
                var im = t.Key == key;
                if (im) return t.Value;
            }
            return key;
        }
        public static AppSettings GetSetting()
        {
            Assembly assembly = typeof(App).GetTypeInfo().Assembly;
            string[] resources = assembly.GetManifestResourceNames();
            foreach (string resource in resources)
            {
                #if Debug_Development || Release_Development || DEBUG
                                       string environment = RunSetting.Development;
                #elif Debug_Stagging || Release_Stagging
                                       string environment = RunSetting.Stagging;
                #elif Deubg_Production || Release_Production || RELEASE
                                      string environment = RunSetting.Production;
                #endif

                if (resource.EndsWith(environment, System.StringComparison.CurrentCulture))
                {
                    Stream stream = assembly.GetManifestResourceStream(resource);
                    if (stream != null)
                    {
                        using (TextReader reader = new StreamReader(stream))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
                            var xml = (Configuration)serializer.Deserialize(reader);
                            var appSetting = xml.AppSettings;
                            return appSetting;
                        }
                    }
                }
            }
            return null;
        }
    }
}
