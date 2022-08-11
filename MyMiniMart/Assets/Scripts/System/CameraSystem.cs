using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    private Camera mainCam;
    private Transform player;

    void Start()
    {
        mainCam = Camera.main;
        player = PlayerController.Instance.transform;
    }

    private void FixedUpdate()
    {
        mainCam.transform.LookAt(player.position, Vector3.zero);
        mainCam.transform.position = new Vector3(player.position.x, mainCam.transform.position.y, (player.transform.position.z - 17.6f));
    }

}
