using System;

namespace BookService
{
    class SimpleDI
    {
        /// <summary>
        /// Name of the registered service.
        /// </summary>
        private static string serviceName;

        /// <summary>
        /// Constructor that registers a service from the configuration file.
        /// </summary>
        static SimpleDI()
        {
            RegisterService(BookService.Configuration.IBookService);
        }

        /// <summary>
        /// Register the name of the service
        /// </summary>
        /// <param name="name">name.</param>
        public static void RegisterService(string name)
        {
            serviceName = name;
        }

        /// <summary>
        /// Gets an instance of the registered service.
        /// </summary>
        /// <returns></returns>
        public static IBookService GetService()
        {
            if (serviceName == "InMemoryBookService")
                return new InMemoryBookService();
            if (serviceName == "DataBookService")
                return new DataBookService();

            throw new InvalidOperationException("No matching service!");
        }
    }
}
