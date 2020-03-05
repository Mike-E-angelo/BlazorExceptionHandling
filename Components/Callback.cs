using System.Threading.Tasks;

namespace Components {
	public delegate Task Callback<in T>(T parameter);
}