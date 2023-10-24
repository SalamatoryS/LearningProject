using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _coins;
    [SerializeField] AnimationCurve _curve;
    [SerializeField] Transform _coinCollecter;

    int coins = 0;
    private void Start()
    {
        _coins.text =coins.ToString();
    }

    public void UpdateCoins()
    {
        coins++;
        _coins.text = coins.ToString();
        StartCoroutine(ScaleProcess());
    }

    IEnumerator ScaleProcess()
    {
        for (float t = 0; t < 1f; t += Time.deltaTime)
        {
            float scale = _curve.Evaluate(t);
            _coinCollecter.transform.localScale = Vector3.one * scale;
            yield return null;

        }
    }
}
