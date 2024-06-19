using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptComidas : MonoBehaviour
{
    public GameObject[] comidas;
    public int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ActivateAll();
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DeactivateAll();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentIndex < comidas.Length)
            {
                DeactivateAll();
                ActivateByIndex(currentIndex);
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
                DeactivateAll();
                ActivateByIndex(currentIndex);
                currentIndex++;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if(currentIndex >= 0)
            {
                DeactivateAll();
                ActivateByIndex(currentIndex);
            }
            else
            {
                currentIndex = comidas.Length - 1;
                DeactivateAll();
                ActivateByIndex(currentIndex);
            }
        }
    }

    void ActivateAll()
    {
        for(int i = 0; i < comidas.Length; i++)
        {
            comidas[i].SetActive(true);
        }
    }

    void DeactivateAll() 
    { 
        for(int i = 0; i < comidas.Length; i++)
        {
            comidas[i].SetActive(false);
        }
    }

    void ActivateByIndex(int index)
    {
        comidas[index].SetActive(true);
    }
}
