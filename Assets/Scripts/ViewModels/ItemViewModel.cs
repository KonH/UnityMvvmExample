using UnityWeld.Binding;

[Binding]
public class ItemViewModel {
	[Binding] public string Name => _model.Name;

	ItemsViewModel _parent;
	ItemModel _model;

	public ItemViewModel(ItemsViewModel parent, ItemModel model) {
		_parent = parent;
		_model = model;
	}

	[Binding]
	public void Use() {
		_parent.Use(_model);
	}
}
