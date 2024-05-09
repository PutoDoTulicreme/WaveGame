using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public Transform Player;

    // Update is called once per frame
    void Update () {
        transform.position = Player.transform.position + new Vector3(0, 1, -5);
    }
}
