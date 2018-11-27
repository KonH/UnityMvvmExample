using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ItemTrigger : MonoBehaviour {
	public string Name;
	public float Value;

	public void Kill() {
		gameObject.SetActive(false);
	}
}