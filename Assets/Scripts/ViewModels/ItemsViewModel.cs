using System;
using UnityEngine;
using UnityWeld.Binding;
using Zenject;

[Binding]
public class ItemsViewModel : MonoBehaviour, INotifyCollectionChanged {
	[Binding]
	public ObservableList<ItemModel> Items {
		get { return _items; }
	}
	
	public event EventHandler<NotifyCollectionChangedEventArgs> CollectionChanged;

	ObservableList<ItemModel> _items;

	[Inject]
	public void Init(ItemRepository repo) {
		_items = repo.Items;
		_items.CollectionChanged += OnCollectionChanged;
	}

	void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
		CollectionChanged?.Invoke(this, e);
	}
}