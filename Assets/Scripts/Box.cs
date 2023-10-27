using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] GameObject _brockenBox;
    [SerializeField] GameObject _coin;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Instantiate(_brockenBox,gameObject.transform.position,transform.rotation);
            Instantiate(_coin,gameObject.transform.position,transform.rotation);
            
            Destroy(gameObject);
        }
    }
}
