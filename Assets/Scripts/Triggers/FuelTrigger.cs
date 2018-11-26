using UnityEngine;

[RequireComponent(typeof(Collider))]
public class FuelTrigger : MonoBehaviour {
	public float Value;

	public void Kill() {
		gameObject.SetActive(false);
	}
}