using System.Threading.Tasks;

namespace ThreadingAmnesia
{
    public static class TaskExtensions
    {
        public static void Forget(this Task task)
        {
            // Consider it forgotten 
        }
    }
}
