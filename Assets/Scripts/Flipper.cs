using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public GameObject postCardBack;
    public GameObject Hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ItsFlipTime()
    {
        postCardBack.SetActive(true);
        gameObject.SetActive(false);

    }
    public void Hide()
    {
        Hand.SetActive(false);
    }
}
