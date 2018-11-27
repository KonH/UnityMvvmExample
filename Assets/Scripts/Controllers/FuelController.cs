using Models;
using Repositories;

namespace Controllers {
	public class FuelController {
		readonly FuelModel _model;

		public FuelController(FuelRepository repo) {
			_model = repo.Model;
		}

		public void Update(float deltaTime) {
			_model.Value -= deltaTime;
		}

		public void Increase(float addition) {
			_model.Value += addition;
		}
	}
}
