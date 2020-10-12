using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerBuffer : MonoBehaviour
{
    [SerializeField] private Transform player;

    [Range(1.0f, 10.0f)][SerializeField] private float cameraOffsexX = 5.0f;
    [Range(1.0f, 10.0f)][SerializeField] private float cameraOffsexY = 5.0f;

    
    // Update is called once per frame
    void Update()
    {
        //Check the x threshold
        if (player.position.x < transform.position.x - (0.5f * cameraOffsexX))
        {
            transform.position = new Vector3(
                player.position.x + (0.5f * cameraOffsexX),
                transform.position.y,
                transform.position.z);
        }
        else if (player.position.x > transform.position.x + (0.5f * cameraOffsexX))
        {
            transform.position = new Vector3(
                player.position.x - (0.5f * cameraOffsexX),
                transform.position.y,
                transform.position.z);
        }

        //check y theshold
        if (player.position.y < transform.position.y - (0.5f * cameraOffsexY))
        {
            transform.position = new Vector3(
                transform.position.y,
                player.position.y + (0.5f * cameraOffsexX),
                transform.position.z);
        }
        else if (player.position.y > transform.position.y + (0.5f * cameraOffsexY))
        {
            transform.position = new Vector3(
                transform.position.x,
                player.position.y - (0.5f * cameraOffsexX),
                transform.position.z);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(cameraOffsexX, cameraOffsexY, 0.0f));
    }
}
