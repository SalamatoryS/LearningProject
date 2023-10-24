using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>() is Coin coin)
        {
            GameObject.Find("Player").gameObject.GetComponent<CoinCollecter>().CollectCoin(coin);
        }
    }
}
