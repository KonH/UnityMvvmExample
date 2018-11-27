using Controllers;
using Models;
using Repositories;
using UnityEngine;
using UnityWeld.Binding;
using Zenject;

namespace ViewModels {
	[Binding]
	public class ItemsViewModel : MonoBehaviour {
		[Binding] public ObservableList<ItemViewModel> Items { get; set; } = new ObservableList<ItemViewModel>();

		ObservableList<ItemModel> _items;
		ItemController            _controller;

		[Inject]
		public void Init(ItemRepository repo, ItemController controller) {
			_items                   =  repo.Items;
			_items.CollectionChanged += OnCollectionChanged;
			_controller              =  controller;
		}

		void OnDisable() {
			if ( _items != null ) {
				_items.CollectionChanged -= OnCollectionChanged;
			}
		}

		void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
			switch ( e.Action ) {
				case NotifyCollectionChangedAction.Add: {
					Items.Insert(e.NewStartingIndex, new ItemViewModel(this, e.NewItems[0] as ItemModel));
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

		public void Use(ItemModel model) {
			_controller.Use(model);
		}
	}
}