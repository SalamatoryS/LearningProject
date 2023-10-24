using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI coins;
    [SerializeField] int _coins = 4;
    private void Start()
    {
        coins.text = "Осталось монет " + _coins;
    }

    public void UpdateCoins()
    {
        _coins--;
        coins.text = "Осталось монет: " + _coins;
        if (_coins == 0)
            coins.text = "Ты победил";
    }
}
