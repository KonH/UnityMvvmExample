using UnityEngine;
using Zenject;

public class ItemCollector : MonoBehaviour {
	ItemRepository _repo;
	
	[Inject]
	public void Init(ItemRepository repo) {
		_repo = repo;
	}
	
	void OnTriggerEnter(Collider other) {
		var item = other.GetComponent<ItemTrigger>();
		if ( item ) {
			_repo.Items.Add(new ItemModel(item.Name, item.Value));
			item.Kill();
		}
	}
}