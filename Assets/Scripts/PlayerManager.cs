using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int health = 100;
    public GameObject dedScreen;
    public bool deadMan = false;

    void Update()
    {
        if (health < 0) { dead(); }
    }
    public void dead()
    {
        dedScreen.SetActive(true);
        deadMan = true;
    }
}
