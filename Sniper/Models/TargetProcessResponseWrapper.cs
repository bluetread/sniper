using System.Collections.ObjectModel;

namespace Sniper
{
    public class TargetProcessReadResponseWrapper<T>
    {
        public Collection<T> Items { get; set; }
    }

    public class TargetProcessDeleteResponseWrapper
    {
        public string ResourceType { get; set; }
        public int Id { get; set; }
    }
}