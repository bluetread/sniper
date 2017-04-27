using System.Collections.ObjectModel;

namespace Sniper
{
    public class TargetProcessResponseWrapper<T>
    {
        public Collection<T> Items { get; set; }
    }
}