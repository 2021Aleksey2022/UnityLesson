using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Частные переменные
    private float speed = 10.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Вот где мы получаем информацию от игрока
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Мы двигаем транспортное средство вперед
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Мы поворачиваем транспортное средство
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }

    }
}
