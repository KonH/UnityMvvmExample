using System.ComponentModel;
using System.Runtime.CompilerServices;
using Controllers;
using Models;
using Repositories;
using UnityEngine;
using UnityWeld.Binding;
using Zenject;

namespace ViewModels {
	[Binding]
	public class FuelViewModel : MonoBehaviour, INotifyPropertyChanged {

		[Binding] public float Value => _model.Value / _model.MaxValue;

		FuelModel      _model;
		FuelController _controller;

		[Inject]
		public void Init(FuelRepository repo, FuelController controller) {
			_model      = repo.Model;
			_controller = controller;
		}

		void OnEnable() {
			_model.PropertyChanged += PropertyChanged;
		}

		void OnDisable() {
			_model.PropertyChanged += PropertyChanged;
		}

		void Update() {
			_controller.Update(Time.deltaTime);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
