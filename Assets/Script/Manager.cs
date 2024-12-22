using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance { get; private set; }

    public GameObject input;
    public GameObject spawnPoint; 
    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
    }
    public void CreateInput()
    {
    GameObject newInput = Instantiate(input, spawnPoint.transform.position, Quaternion.identity);
    newInput.transform.SetParent(transform);

    }

    void Update()
    {
    }
}