using Laboratory1.Concrete;

namespace Laboratory1
{
    public class Demo
    {
        public void Run()
        {
            var logger = new Logger();
            var emailNotifyer = new EmailNotifier();

            var mother = new User("Mother");
            var father = new User("Father");
            var bob = new User("Bob");
            var alice = new User("Alice");

            var homeworksProject = new Project(logger, emailNotifyer, "Homeworks completion", mother);
            var writeEssayTask = homeworksProject.CreateTask("Write essay", bob);
            var learnPoemTask = homeworksProject.CreateTask("Learn a poem", alice);

            homeworksProject.AddUser(father);

            writeEssayTask.ChangeState("Started");
            writeEssayTask.ChangeState("Verification", father);
            writeEssayTask.ChangeState("Accepted", mother);
        }
    }
}
