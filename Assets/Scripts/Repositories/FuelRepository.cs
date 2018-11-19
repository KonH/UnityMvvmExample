using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelRepository {
	public FuelModel Model { get; }

	public FuelRepository(float initialValue, float maxValue) {
		Model = new FuelModel(initialValue, maxValue);
	}
}
