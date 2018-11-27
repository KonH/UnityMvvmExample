using UnityWeld.Binding;

[Binding]
public class ItemViewModel {
	[Binding]
	public string Name { get; }

	public ItemViewModel(ItemModel model) {
		Name = model.Name;
	}
}
