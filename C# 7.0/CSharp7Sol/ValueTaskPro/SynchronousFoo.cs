using System.Threading.Tasks;

namespace ValueTaskPro
{
    class SynchronousFoo<T> : IFoo<T>
    {
        public ValueTask<T> BarAsync()
        {
            var value = default(T);
            return new ValueTask<T>(value);
        }
    }
}
