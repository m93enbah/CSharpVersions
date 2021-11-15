using System.Threading.Tasks;

namespace ValueTaskPro
{
    class AsynchronousFoo<T> : IFoo<T>
    {
        public async ValueTask<T> BarAsync()
        {
            var value = default(T);
            await Task.Delay(1);
            return value;
        }
    }
}
