using System.Threading.Tasks;

namespace Components
{
	public interface IOperation<in T> : ISelect<T, ValueTask> {}

	public interface IOperation : IResult<ValueTask> {}
}