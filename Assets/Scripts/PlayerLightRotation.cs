using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLightRotation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var player = SimplifiedPlayerController.player;
        var mousePosition = Input.mousePosition;
        var lightDirection = mousePosition - player.transform.position;
        Vector3 direction = (Input.mousePosition - player.transform.position - new Vector3(Camera.main.scaledPixelWidth / 2, Camera.main.scaledPixelHeight / 2)).normalized;
        float xdir = direction.x > 0 ? 90 : -90;
        var rotation = Quaternion.LookRotation(direction);
        print(rotation);
        transform.eulerAngles = new Vector3(rotation.x * 180, xdir, 0);
    }
}
