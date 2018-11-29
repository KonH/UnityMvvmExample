using Controllers;
using Models;
using Repositories;
using UnityEngine;
using UnityWeld.Binding;
using Zenject;

namespace ViewModels {
	[Binding]
	public class FuelViewModel : BaseViewModel<FuelModel> {
		[Binding] public float Value => Model.Value / Model.MaxValue;

		FuelController _controller;

		[Inject]
		public void Init(FuelRepository repo, FuelController controller) {
			base.Init(repo.Model);
			_controller = controller;
		}

		void Update() {
			_controller.Update(Time.deltaTime);
		}
	}
}
