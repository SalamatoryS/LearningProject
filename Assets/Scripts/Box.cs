using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] GameObject _BrockenBox;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Instantiate(_BrockenBox,gameObject.transform.position,transform.rotation);
            Destroy(gameObject);
        }
    }
}
