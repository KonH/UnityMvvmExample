using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ItemTrigger : MonoBehaviour {
	public string Name;

	public void Kill() {
		gameObject.SetActive(false);
	}
}