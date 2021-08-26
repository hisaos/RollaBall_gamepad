using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
  public Vector3 offset;
  public Transform target;

  void Update()
  {
    this.transform.position = target.position + offset;
    this.transform.LookAt(target);
  }
}
