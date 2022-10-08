using Laboratory1.Interfaces;

namespace Laboratory1
{
    public class Project
    {
        private ILogger _logger;
        private INotifier _notifier;
        private string _projectName;
        private User _admin;
        private List<User> _users;
        private List<Task> _tasks;

        public Task CreateTask(string task, User owner)
        {
            var newTask = new Task(_logger, task, owner);
            _tasks.Add(newTask);
            _notifier.Notify($"You have been assigned to task: {task}", owner);

            return newTask;
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            _notifier.Notify($"{user.Name} was added to the project", _admin);
        }

        public void AddUser(User user, INotifier notifier)
        {
            _users.Add(user);
            notifier.Notify($"{user.Name} was added to the project", _admin);
        }

        public Project(ILogger logger, INotifier notifier, string projectName, User admin)
        {
            _logger = logger;
            _notifier = notifier;
            _projectName = projectName;
            _admin = admin;
            _users = new List<User>();
            _tasks = new List<Task>();
        }
    }
}
