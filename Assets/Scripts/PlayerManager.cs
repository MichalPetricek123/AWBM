using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    public int health = 100;
    public GameObject dedScreen;
    public bool deadMan = false;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        //Instance = GetComponent<GameManager>();
    }

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
