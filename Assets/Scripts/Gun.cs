using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _spawn;
    [SerializeField] float _timeToShot = 2f;
    [SerializeField] float _bulletSpeed = 20;
    [SerializeField] Animator _animator;
    [SerializeField] AudioSource _audio;

    float timerToShot;
    bool isShot = true;

    private void Start()
    {
        timerToShot = _timeToShot;
    }

    private void Update()
    {
        if (timerToShot > 0)
        {
            timerToShot -= Time.deltaTime;
        }
        else
        {
            isShot = true;
            timerToShot = _timeToShot;
        }      
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0) && isShot)
        {
            isShot = false;
            GameObject newBullet = Instantiate(_bullet, _spawn.position, _spawn.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = _spawn.forward * _bulletSpeed;
            _animator.SetTrigger("NewShot");
            _audio.Play();      
        }
    }
}
