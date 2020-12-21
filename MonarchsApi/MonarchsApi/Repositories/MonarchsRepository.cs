using System;
using System.IO;



namespace MonarchsApi.Repositories
{
    public class MonarchsRepository : IMonarchsRepository
    {
        private String _dataLocation;

        public MonarchsRepository(String dataLocation)
        {
            _dataLocation = dataLocation;
        }

        public String GetMonarchs()
        {
            return GetMonarchsData();
        }

        private String GetMonarchsData()
        {
            try
            {
                // Monarchs data is stored in a json file.
                var stringMonarchs = File.ReadAllText(_dataLocation);

                return stringMonarchs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not get data: " + ex);
            }
            return null;
        }

    }
}
