using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI hub, msgVitoria;
    public int restantes;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<moeda>().Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}




