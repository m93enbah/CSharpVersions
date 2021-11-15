using System.Threading.Tasks;

namespace ValueTaskPro
{
    interface IFoo<T>
    {
        ValueTask<T> BarAsync();
    }
}
