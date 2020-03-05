using System.Threading.Tasks;

namespace Components {
	public static class Extensions
	{
		public static Task Promote(this IOperation @this) => @this.Get().AsTask();

		public static Task Promote<T>(this IOperation<T> @this, T parameter) => @this.Get(parameter).AsTask();
	}
}