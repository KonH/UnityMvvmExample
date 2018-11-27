using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FuelModel : INotifyPropertyChanged {
	public float Value {
		get { return _value; }
		set {
			var newValue = Mathf.Clamp(value, 0.0f, MaxValue);
			if ( Mathf.Abs(_value - newValue) > Mathf.Epsilon ) {
				_value = newValue;
				OnPropertyChanged();
			}
		}
	}
	
	public float MaxValue { get; }

	float _value;

	public FuelModel(float initialValue, float maxValue) {
		MaxValue = maxValue;
		Value = initialValue;
	}

	public event PropertyChangedEventHandler PropertyChanged;

	void OnPropertyChanged([CallerMemberName] string propertyName = null) {
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
