using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D()
    {
        PlayerManager.Instance.dead();
    }
}
