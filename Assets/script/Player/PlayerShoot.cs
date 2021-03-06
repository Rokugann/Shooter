﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
	[SerializeField]
	private int totalAmmo;

	[SerializeField]
	private float baseShootTime, rateModifierOverTime, heatTime = 2f;

	[SerializeField]
	private float reloadTime = 2f;

	[SerializeField]
	private GameObject bulletPrefab = null;

	[SerializeField]
	private Transform shootPositionA, shootPositionB; // Where the bullets are instancied

	private bool canShoot = true, isReady = false, gun = true;

	private int ammo = 0;

	private float curHeat = 0f, shootTime = 0f;

	private void Start ()
	{
		ammo = totalAmmo;
	}

	private void Update ()
	{
		if (Input.GetAxis ("Fire1") > 0) //When we shoot
		{
			if (canShoot)
				Shoot ();
		}
		else
		{
			if (shootTime <= 0f) // We decrease heat by 1/2
			{
				curHeat = Mathf.Clamp (curHeat, 0f, heatTime);
				shootTime = 0f;
				curHeat -= Time.deltaTime /2;
			}
			else
			{
				shootTime -= Time.deltaTime;
			}
		}
	}

	private void Shoot ()
	{
		if (ammo > 0 && isReady)
		{
			shootTime += Time.deltaTime;
			gun = gun ? gun = false : gun = true; //used to toggle canon that actually shooting
			StartCoroutine (IShoot (baseShootTime - shootTime * rateModifierOverTime));
			ammo --;
		}
		else if (!isReady)
		{
			if (curHeat >= heatTime)
				isReady = true;
			else curHeat += Time.deltaTime;
		}
		else Reload ();	
	}

	private void Reload ()
	{
		StartCoroutine (ILock ());
		ammo = totalAmmo;
		shootTime = 0f;
	}

	private IEnumerator ILock ()
	{
		canShoot = false;
		yield return new WaitForSeconds (reloadTime);
		canShoot = true;	
	}

	private IEnumerator IShoot (float shootTime)
	{
		canShoot = false;
		Instantiate
		(
			bulletPrefab,
			gun
				? shootPositionA.position
				: shootPositionB.position,
			transform.GetChild (0).rotation
		);

		yield return new WaitForSeconds (shootTime);
		canShoot = true;
	}
}
