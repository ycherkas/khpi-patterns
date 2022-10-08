using Laboratory1.Interfaces;

namespace Laboratory1
{
    public class Task
    {
        private ILogger _logger;
        private string _state;
        private string _task;
        private User _owner;


        public void ChangeState(string state)
        {
            _state = state;
            _logger.Log($"{_owner.Name} has changed task state to: {state}.");
        }

        public void ChangeState(string state, User user)
        {
            _state = state;
            _logger.Log($"{user.Name} has changed task state to: {state}.");
        }

        public Task(ILogger logger, string task, User owner)
        {
            _logger = logger;
            _task = task;
            _owner = owner;
        }
    }
}
