using UnityEngine;
using UnityWeld.Binding;

[CreateAssetMenu(menuName = "Unity Weld/Adapter options/Normalized Value To Color Adapter Options")]
public class NormalizedValueToColorAdapterOptions : AdapterOptions {
	public Color FromColor;
	public Color ToColor;
}
