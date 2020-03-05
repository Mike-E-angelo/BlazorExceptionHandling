namespace Components {
	public interface IResult<out T>
	{
		T Get();
	}
}