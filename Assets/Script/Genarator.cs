using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.Animations;
using UnityEngine;
public class Genarator : MonoBehaviour
{
    [SerializeField]
    GameObject[] gameob;
    GameObject game;

    [SerializeField]
    private Transform left;

    int x;
    void Start()
    {
        StartCoroutine(spw());
    }

    
    void Update()
    {
        
    }

    IEnumerator spw()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2, 5));
            game = Instantiate(gameob[Random.Range(0, gameob.Length)]);
            
            game.transform.position = left.position;
        }
        


    }
}
