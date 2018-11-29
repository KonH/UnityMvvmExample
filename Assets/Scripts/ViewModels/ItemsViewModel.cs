using Controllers;
using Models;
using Repositories;
using UnityEngine;
using UnityWeld.Binding;
using Zenject;

namespace ViewModels {
	[Binding]
	public class ItemsViewModel : BaseListViewModel<ItemModel, ItemViewModel> {
		ItemController _controller;

		[Inject]
		public void Init(ItemRepository repo, ItemController controller) {
			base.Init(repo.Items);
			_controller = controller;
		}

		protected override ItemViewModel CreateView(ItemModel model) => new ItemViewModel(this, model);

		public void Use(ItemModel model) {
			_controller.Use(model);
		}
	}
}