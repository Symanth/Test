using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializedField] private bool state;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start scene");
        Method(state);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }
    }

    private void Method(bool state)
    {
        if (state)
        {
            Debug.Log("State: True");
        }
    }
}
