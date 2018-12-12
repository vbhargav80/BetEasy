using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using BetEasy.Core.Interfaces;
using BetEasy.Core.Model.Caulfield;

namespace BetEasy.DataAccess.Repositories
{
    public class CaulfieldRepository : ICaulfieldRepository
    {
        public Meeting GetMeeting()
        {
            var resourceName = "BetEasy.DataAccess.DataFiles.Caulfield_Race1.xml";

            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    string xmlContent = streamReader.ReadToEnd();

                    var serializer = new XmlSerializer(typeof(Meeting), new XmlRootAttribute("meeting"));
                    Meeting meeting;

                    using (TextReader textReader = new StringReader(xmlContent))
                    {
                        meeting = serializer.Deserialize(textReader) as Meeting;
                    }

                    return meeting;
                }
            }
            
        }
    }
}
