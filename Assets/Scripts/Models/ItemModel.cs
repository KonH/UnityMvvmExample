namespace Models {
	public class ItemModel {
		public string Name  { get; }
		public float  Value { get; }

		public ItemModel(string name, float value) {
			Name  = name;
			Value = value;
		}
	}
}