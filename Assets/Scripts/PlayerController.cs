using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _speed = 1f;
    [SerializeField] float _sencetivityHorizontal = 1f;
    [SerializeField] float _sencetivityVertical = 1f;
    [SerializeField] float _jumpPower = 3f;

    [SerializeField] Rigidbody _rb;
    [SerializeField] Transform _cameraTransform;

    float inputHorizontal;
    float inputVertical;
    float xRotation;
    bool isJump = true;

    private void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _speed *= 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _speed /= 2;
        }
    }
    private void FixedUpdate()
    {
        Vector3 forwardSpeed = inputVertical * transform.forward * _speed;
        Vector3 rightSpeed = inputHorizontal * transform.right * _speed;
        Vector3 summ = forwardSpeed + rightSpeed;

        _rb.velocity = new Vector3(summ.x, _rb.velocity.y, summ.z);

        float rotationInputHorizontal = Input.GetAxis("Mouse X");
        float rotationInputVertical = Input.GetAxis("Mouse Y");

        _rb.angularVelocity = new Vector3(0, rotationInputHorizontal * _sencetivityHorizontal, 0);
        xRotation += -rotationInputVertical * _sencetivityVertical;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        _cameraTransform.localEulerAngles = new Vector3(xRotation, 0, 0);

        if (Input.GetKey(KeyCode.Space) && isJump)
        {
            _rb.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
            isJump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJump = true;
        }
    }
}
