using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

public class Shoot : MonoBehaviour
 {
 public KeyCode shootKey = KeyCode.Space;
 public GameObject projectile;
 public float shootForce;

// Use this for initialization
 void Start () {

}

// Update is called once per frame
 void Update ()
 {
 if (Input.GetKeyDown(shootKey))
 {
 GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
 shot.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);
 }
 }
 }
