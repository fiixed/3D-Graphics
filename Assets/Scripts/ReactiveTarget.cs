﻿using UnityEngine;
using System.Collections;

public class ReactiveTarget : MonoBehaviour {

	// Use this for initialization
	public void ReactToHit() {
		WanderingAI behaviour = GetComponent<WanderingAI>();
		if (behaviour != null) {
			behaviour.SetAlive(false);
		}
		StartCoroutine(Die());
	}
	
	private IEnumerator Die() {
		this.transform.Rotate(-75, 0, 0);

		yield return new WaitForSeconds(1.5f);

		Destroy(this.gameObject);
	}


}
