using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FuelModel : INotifyPropertyChanged {
	public float Value {
		get { return _value; }
		set {
			if ( Mathf.Abs(_value - value) > Mathf.Epsilon ) {
				_value = value;
				OnPropertyChanged();
			}
		}
	}
	
	public float MaxValue { get; }

	float _value;

	public FuelModel(float initialValue, float maxValue) {
		Value = initialValue;
		MaxValue = maxValue;

	}

	public void UpdateValue(float deltaTime) {
		Value = Mathf.Max(Value - deltaTime, 0.0f);
	}

	public event PropertyChangedEventHandler PropertyChanged;

	void OnPropertyChanged([CallerMemberName] string propertyName = null) {
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
