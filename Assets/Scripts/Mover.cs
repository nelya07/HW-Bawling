using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Mover : MonoBehaviour
{
 [SerializeField] private float _force;

 private void Start()
 {
  GetComponent<Rigidbody>().AddForce(Vector3.forward * _force);
 }
}

 
