using Projeto_teste.Entities.Enums;
namespace Projeto_teste.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departments Departments { get; set; }
        public Worker()
        {
        }
        public Worker(string name, WorkLevel level, double baseSalary)
        {
        }
        

         
    }
}
