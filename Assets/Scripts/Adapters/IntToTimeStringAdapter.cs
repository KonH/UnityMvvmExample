using UnityWeld.Binding;

[Adapter(typeof(int), typeof(string))]
public class IntToStringAdapter : IAdapter
{
	public object Convert(object valueIn, AdapterOptions options) {
		var intValue = (int)valueIn;
		var mins = intValue / 60;
		var secs = intValue % 60; 
		return string.Format("{0:00}:{1:00}", mins, secs);
	}
}
