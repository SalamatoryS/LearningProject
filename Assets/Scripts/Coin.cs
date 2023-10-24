using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void Collected()
    {
        GameObject.Find("GameManager").gameObject.GetComponent<GameManager>().UpdateCoins();
        Destroy(gameObject);
    }
}
