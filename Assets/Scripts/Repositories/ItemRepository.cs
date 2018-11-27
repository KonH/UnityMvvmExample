using Models;
using UnityWeld.Binding;

namespace Repositories {
	public class ItemRepository {
		public ObservableList<ItemModel> Items { get; set; } = new ObservableList<ItemModel>();
	}
}