using UnityEngine;
using UnityWeld.Binding;

namespace Adapters {
	[Adapter(typeof(float), typeof(Color), typeof(NormalizedValueToColorAdapterOptions))]
	public class NormalizedValueToColorAdapter : IAdapter {
		public object Convert(object valueIn, AdapterOptions options) {
			var colorOptions = options as NormalizedValueToColorAdapterOptions;
			var fromColor    = colorOptions.FromColor;
			var toColor      = colorOptions.ToColor;
			return Color.Lerp(fromColor, toColor, (float)valueIn);
		}
	}
}
