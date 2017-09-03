using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField]
	private int maxLife = 100;

	private int life;

	private void Start ()
	{
		life = maxLife;
	}

	private void OnCollisionEnter (Collision c)
	{
		Bullet b = c.gameObject.GetComponent <Bullet> ();
		if (c.collider.tag == "Player" && b)
		{
			DoDamage (b.Damage);
			Destroy (c.gameObject);
		}
	}

	private void DoDamage (int damage)
	{
		int nLife = life - damage;

		if (nLife <= 0)
			Destroy (this.gameObject);
		else 
			life = nLife;
	}
}
