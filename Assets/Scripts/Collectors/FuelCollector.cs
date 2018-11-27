using Controllers;
using Triggers;
using UnityEngine;
using Zenject;

namespace Collectors {
	public class FuelCollector : MonoBehaviour {
		FuelController _controller;

		[Inject]
		public void Init(FuelController controller) {
			_controller = controller;
		}

		void OnTriggerEnter(Collider other) {
			var fuel = other.GetComponent<FuelTrigger>();
			if ( fuel ) {
				_controller.Increase(fuel.Value);
				fuel.Kill();
			}
		}
	}
}