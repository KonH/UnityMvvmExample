using System.Collections.Generic;
using Models;
using Repositories;

namespace Controllers {
	public class ItemController {
		readonly IList<ItemModel> _items;
		readonly FuelController   _fuel;

		public ItemController(ItemRepository repo, FuelController fuel) {
			_items = repo.Items;
			_fuel  = fuel;
		}

		public void Use(ItemModel item) {
			_items.Remove(item);
			_fuel.Increase(item.Value);
		}
	}
}
