using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    private Vector3 offset1 = new Vector3(0, 4.18f, -0.86f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //переместите камеру за игроком, увеличив положение игрока
        transform.position = player.transform.position + offset;
        //if (Input.GetKey(KeyCode.Mouse0))
        //{
        //    transform.position = player.transform.position + offset1;
        //}
    }
}
