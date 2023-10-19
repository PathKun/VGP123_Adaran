using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgSlider : MonoBehaviour
{
    private Vector2 StartPosition;
    [SerializeField] private float speed = 3f;

    void Start()
    {
         StartPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < -31.24f)
        {
            transform.position = StartPosition;
        }
    }
}
