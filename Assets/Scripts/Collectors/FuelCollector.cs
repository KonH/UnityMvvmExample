using UnityEngine;
using Zenject;

public class FuelCollector : MonoBehaviour {
	FuelModel _model;
	
	[Inject]
	public void Init(FuelRepository repo) {
		_model = repo.Model;
	}
	
	void OnTriggerEnter(Collider other) {
		var fuel = other.GetComponent<FuelTrigger>();
		if ( fuel ) {
			_model.IncreaseValue(fuel.Value);
			fuel.Kill();
		}
	}
}