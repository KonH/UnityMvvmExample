using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityWeld.Binding;

namespace ViewModels {
	[Binding]
	public class TimeViewModel : MonoBehaviour, INotifyPropertyChanged {

		[Binding]
		public int Seconds {
			get { return _seconds; }
			set {
				if ( value != _seconds ) {
					_seconds = value;
					OnPropertyChanged();
				}
			}
		}

		int _seconds = -1;

		void Update() {
			if ( Time.timeSinceLevelLoad > Seconds + 1 ) {
				Seconds = (int)Time.timeSinceLevelLoad;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
