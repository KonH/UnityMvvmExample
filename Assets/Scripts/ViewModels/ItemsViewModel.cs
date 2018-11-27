using UnityEngine;
using UnityWeld.Binding;
using Zenject;

[Binding]
public class ItemsViewModel : MonoBehaviour {
	[Binding] public ObservableList<ItemViewModel> Items { get; set; } = new ObservableList<ItemViewModel>();

	ObservableList<ItemModel> _items;

	[Inject]
	public void Init(ItemRepository repo) {
		_items = repo.Items;
		_items.CollectionChanged += OnCollectionChanged;
	}

	void OnDisable() {
		if ( _items != null ) {
			_items.CollectionChanged -= OnCollectionChanged;
		}
	}

	void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
		switch ( e.Action ) {
			case NotifyCollectionChangedAction.Add: {
				Items.Insert(e.NewStartingIndex, new ItemViewModel(e.NewItems[0] as ItemModel));
			}
			break;

			case NotifyCollectionChangedAction.Remove: {
				Items.RemoveAt(e.OldStartingIndex);
			}
			break;

			case NotifyCollectionChangedAction.Reset: {
				Items.Clear();
			}
			break;
		}
	}
}