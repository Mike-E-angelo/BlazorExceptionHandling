namespace Components {
	public interface ISelect<in TIn, out TOut>
	{
		TOut Get(TIn parameter);
	}
}