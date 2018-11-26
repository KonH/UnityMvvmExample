using UnityWeld.Binding;

[Binding]
public class ItemModel {
	[Binding]
	public string Name { get; }

	public ItemModel(string name) {
		Name = name;
	}
}