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
        coins.text = "�������� ����� " + _coins;
    }

    public void UpdateCoins()
    {
        _coins--;
        coins.text = "�������� �����: " + _coins;
        if (_coins == 0)
            coins.text = "�� �������";
    }
}
