using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
  private Transform myTransform;
  public float moveSpeed = 5f;
  public GameObject explosionPrefab = null;

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
    myTransform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

    if(myTransform.position.y < -7.0f)
    {
      initPosition();
    }
  }

  private void initPosition()
  {
    myTransform.position = new Vector3(Random.Range(-8.0f, 8.0f), 7.0f, 0.0f);
  }

  private void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.CompareTag("Bullet"))
    {
      GameManager.Score += 1;
      Instantiate(explosionPrefab, myTransform.position, Quaternion.identity);
      initPosition();
      Destroy(other.gameObject);
    }
  }
}
