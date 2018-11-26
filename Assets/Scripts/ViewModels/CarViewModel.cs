using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using Zenject;

[RequireComponent(typeof(CarUserControl))]
public class CarViewModel : MonoBehaviour {
	CarUserControl _control;
	FuelModel _model;

	void Awake() {
		_control = GetComponent<CarUserControl>();
	}
	
	[Inject]
	public void Init(FuelRepository repo) {
		_model = repo.Model;
	}

	void Update() {
		if ( _model.Value <= 0.0f ) {
			_control.enabled = false;
		}
	}
}