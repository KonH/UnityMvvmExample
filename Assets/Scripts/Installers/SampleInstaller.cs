using Zenject;

public class SampleInstaller : MonoInstaller {
	public float StartFuel = 100;
	public float MaxFuel = 100;
	
	public override void InstallBindings() {
		Container.BindInstance(new FuelRepository(StartFuel, MaxFuel)).AsSingle();
		Container.Bind<ItemRepository>().ToSelf().AsSingle();
		Container.Bind<FuelController>().ToSelf().AsSingle();
		Container.Bind<ItemController>().ToSelf().AsSingle();
	}
}
