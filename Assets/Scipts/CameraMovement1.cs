using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement1 : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform moveThershold;

    // Update is called once per frame
    void Update()
    {
        if (player.position.x > moveThershold.position.x)
        {
            //camera follows the player
            transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(
            new Vector2(moveThershold.position.x, moveThershold.position.y + 10),
            new Vector2(moveThershold.position.x, moveThershold.position.y - 10));
    }
}
