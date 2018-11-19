public class FuelController {
	readonly FuelRepository _repo;
	
	public FuelController(FuelRepository repo) {
		_repo = repo;
	}

	public void Update(float deltaTime) {
		var model = _repo.Model;
		model.UpdateValue(deltaTime);
	}
}
