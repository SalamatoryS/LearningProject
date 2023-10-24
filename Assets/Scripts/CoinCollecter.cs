using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollecter : MonoBehaviour
{
    [SerializeField] Transform _coinTarget;
    [SerializeField] Camera _camera;

    public void CollectCoin(Coin coinFromBullet)
    {
        StartCoroutine(CoinMoveProcess(coinFromBullet));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>() is Coin coin)
        {
            StartCoroutine(CoinMoveProcess(coin));
        }
    }

    private IEnumerator CoinMoveProcess(Coin coin)
    {
        Vector3 startPosition = coin.transform.position;

        for (float t = 0; t < 2f; t += Time.deltaTime)
        {
            Vector3 screenPosition = _coinTarget.position;
            screenPosition.z = 3f;
            Vector3 wordPosition = _camera.ScreenToWorldPoint(screenPosition);

            Vector3 position = Vector3.Lerp(startPosition, wordPosition, t * t);
            coin.transform.position = position;

            float scale = Mathf.Lerp(1f, 0.2f, t * t);
            coin.transform.localScale = Vector3.one * scale;

            yield return null;
        }

        coin.Collected();
    }
}
