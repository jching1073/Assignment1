using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BufferedCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
    [Range(1,10)][SerializeField] private float cameraOffsetX = 5.0f;
    [Range(1,10)][SerializeField] private float cameraOffsetY = 5.0f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        // check x trheshold
        if (player.position.x < transform.position.x - (0.5f * cameraOffsetX)) //Left
        {
            transform.position = new Vector3(
                player.position.x + (0.5f * cameraOffsetX),
                transform.position.y,
                transform.position.z);
        }
        else if (player.position.x > transform.position.x + (0.5f * cameraOffsetX))
        {
            transform.position = new Vector3(
                player.position.x - (0.5f * cameraOffsetX),
                transform.position.y,
                transform.position.z);
        }

        // check the y thershold

        if (player.position.y < transform.position.y - (0.5f * cameraOffsetX)) //up
        {
            transform.position = new Vector3(
                transform.position.x,
                player.position.y + (0.5f * cameraOffsetY),
                transform.position.z);
        }
        else if (player.position.y > transform.position.y + (0.5f * cameraOffsetY))
        {
            transform.position = new Vector3(

                transform.position.x,
                player.position.y - (0.5f * cameraOffsetY),
                transform.position.z);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position, new Vector3 (cameraOffsetX, cameraOffsetY, 0.0f));
    }

}
