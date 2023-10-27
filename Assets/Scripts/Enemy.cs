using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] NavMeshAgent _agent;
    [SerializeField] GameObject _coin;

    Transform _target;
    Animator _animator;

    private void Start()
    {
        _target = GameObject.Find("Player").GetComponent<Transform>();
        _animator = gameObject.GetComponentInChildren<Animator>();
    }
    private void Update()
    {
        _agent.SetDestination(_target.transform.position); 
    }

    public void Die()
    {
        _target = gameObject.transform;
        _animator.SetTrigger("Fall");
        StartCoroutine(DieProcess());
    }

    IEnumerator DieProcess()
    {
        yield return new WaitForSeconds(2);
        Instantiate(_coin, gameObject.transform.position + Vector3.up/2f , transform.rotation);
        
        //if (_coin.GetComponent<Coin>() is Coin coin) 
        //{
        //    GameObject.Find("Player").gameObject.GetComponent<CoinCollecter>().CollectCoin(coin);
        //}

        Destroy(gameObject);
    }


}
