using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
  public float moveSpeed = 1.0f;
  private Transform myTransform = null;

  public GameObject bullet = null;

  // Start is called before the first frame update
  void Start()
  {
    myTransform = GetComponent<Transform>();
  }

  // Update is called once per frame
  void Update()
  {
    if(myTransform == null)
    {
      return;
    }

    float horizontalInput = Input.GetAxis("Horizontal");
    myTransform.Translate(Vector3.right * horizontalInput * Time.deltaTime * moveSpeed);

    if(Input.GetKeyDown(KeyCode.Space))
    {
      Instantiate(bullet, myTransform.position, Quaternion.identity);
    }

    }
}
