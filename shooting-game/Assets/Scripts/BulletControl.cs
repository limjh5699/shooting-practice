using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{

  public float moveSpeed = 15f;
  private Transform myTransform = null;

  // Start is called before the first frame update
  void Start()
  {
    myTransform = GetComponent<Transform>();
  }

  // Update is called once per frame
  void Update()
  {
    myTransform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

    if(myTransform.position.y >= 15f)
    {
      Destroy(gameObject);
    }

  }
}
