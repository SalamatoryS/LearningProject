using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBrocken : MonoBehaviour
{
    [SerializeField] float _exploisionForce = 5f;
    [SerializeField] float _exploisionRadius = 5f;
    [SerializeField] AudioSource _explosionAudioSource;
    private void Start()  
    {
        gameObject.GetComponent<Rigidbody>().AddExplosionForce(_exploisionForce, gameObject.transform.position, _exploisionRadius);
        _explosionAudioSource.Play();
    }
    
}
