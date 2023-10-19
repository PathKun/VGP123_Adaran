using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    public List<GameObject> level;
    public void Fill()
    {
        GameObject c1 = Instantiate(level[0]);
        GameObject c2 = Instantiate(level[1]);
        GameObject c3 = Instantiate(level[2]);
        GameObject c4 = Instantiate(level[3]);
    }
    public Transform parent;
    public float height;
    public float time=3f;
    public int i;
    // Update is called once per frame
    private void Start()
    {
        for (i = 0; i < level.Count; i++)
        {
            Debug.Log("Level Number: " + i);
        }
    }
    void Update()
    {

        if (time > 0f)
        {
            time -= Time.deltaTime;
        }
        else
        {
            i = Random.Range(0, level.Count);
            height = -5f;
            Instantiate(level[i], new Vector2(0, height), Quaternion.identity, parent);
            time = 3f;
        }
    }
}