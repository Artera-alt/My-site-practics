namespace Практика_ASP.NET.Models
{
    public class Workforce
    {
        public Workforce(int id, string fullName, WorkerRole workerRole)
        {
            Id = id;
            FullName = fullName;
            this.workerRole = workerRole;
        }

        public enum WorkerRole
        {
            CEO,
            Frontend,
            Backend,
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public WorkerRole workerRole{ get; set; }
    }
}
