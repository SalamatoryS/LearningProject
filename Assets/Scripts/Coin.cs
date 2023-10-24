using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().UpdateCoins();
            Destroy(gameObject);
        }
    }
}
