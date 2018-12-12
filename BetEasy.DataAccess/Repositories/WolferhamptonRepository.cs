using System.IO;
using System.Reflection;
using BetEasy.Core.Interfaces;
using BetEasy.Core.Model.Wolferhampton;
using Newtonsoft.Json;

namespace BetEasy.DataAccess.Repositories
{
    public class WolferhamptonRepository : IWolferhamptonRepository
    {
        public Fixture GetFixture()
        {
            var resourceName = "BetEasy.DataAccess.DataFiles.Wolferhampton_Race1.json";

            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                using (var streamReader = new StreamReader(stream))
                {
                    var jsonContent = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Fixture>(jsonContent);
                }
            }
        }
    }
}