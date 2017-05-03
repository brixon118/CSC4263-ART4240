using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkingShip : MonoBehaviour
{
    private float counter;
    public int scrapTotal;
    public GameObject scrapNodePrefab;
    public GameObject scrapNode;
    public bool ship1 = true;
    public Sprite sprite1;
    public Sprite sprite2;
    // Use this for initialization
    void Start ()
    {
        counter = 1;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
        Invoke("SpawnNode", 3.0f);
        Invoke("DeleteSelf", 6.0f);
        if (ship1)
        {
            GetComponent<SpriteRenderer>().sprite = sprite1;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = sprite2;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, counter);
        counter = counter - (Time.deltaTime/3);
    }

    private void SpawnNode()
    {
        Vector3 outsideVector = GetComponent<Transform>().position;
        scrapNode = Instantiate(scrapNodePrefab, outsideVector, GetComponent<Transform>().rotation);
        scrapNode.GetComponent<AddScrap>().total = scrapTotal;
       
    }
    private void DeleteSelf()
    {
        Destroy(this.gameObject);
    }

}
