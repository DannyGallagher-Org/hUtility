using hUtility.Extensions;
using RSG;

namespace hUtility
{
	public static class Validate 
	{
		public static void Do(Tuple<bool, System.Action>[] tuples)
		{
			var index = tuples.FindIndex(item => item.Item1.Equals(true));
			tuples[index].Item2.Invoke();
		}
	}
}