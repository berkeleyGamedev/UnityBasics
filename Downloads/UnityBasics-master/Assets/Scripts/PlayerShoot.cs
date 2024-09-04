using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject laserPrefab;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            Shoot();
        }
    }

    private void Shoot() {
        GameObject bullet = Instantiate(laserPrefab, transform.position, transform.parent.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(transform.up * 320);
    }
}
