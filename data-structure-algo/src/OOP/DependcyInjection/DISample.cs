namespace data_structure_algo.src.OOP.DependcyInjection
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine("From Logger => {0}", message);
        }
    }

    public class UserService
    {
        private readonly Logger logger;

        public UserService(Logger logger)
        {
            this.logger = logger;
        }

        public string GetUser(string id)
        {
            logger.Log("Fetching user with" + id);
            return "Thuta";
        }
    }

    // ---------------------------- RealLife Sample (Inventory Service) 🚀 ----------------------------
    public class IProduct
    {
        public required string Name { get; set; }
        public int Quantity { get; set; }
    }

    public interface IInventoryService<T>
    {
        void AdditemToInvendotry(T item);
    }

    public class DatabaseService<T>
    {
        public void SaveItemToInventory(T item)
        {
            Console.WriteLine("Save item to database {0}", item);
        }
    }

    public class LoggingService
    {
        public void Log(string message)
        {
            Console.WriteLine("From Logging Service {0}", message);
        }
    }

    public class NotificationService
    {
        public void SendAlert(string message)
        {
            Console.WriteLine("Sending Alert : {0}", message);
        }
    }

    /// <summary>
    /// Inventory Service 
    /// </summary>
    public class InventoryService : IInventoryService<IProduct>
    {
        private readonly DatabaseService<IProduct> _databaseService;
        private readonly LoggingService _loggingService;
        private readonly NotificationService _notificationService;

        public InventoryService(DatabaseService<IProduct> databaseService, LoggingService loggingService, NotificationService notificationService)
        {
            _databaseService = databaseService;
            _loggingService = loggingService;
            _notificationService = notificationService;
        }

        public void AdditemToInvendotry(IProduct item)
        {
            _databaseService.SaveItemToInventory(item);
            _loggingService.Log($"Add item to inventory {item.Name}");
            _notificationService.SendAlert($"new item added to inventory {item.Name}");
        }
    }


}