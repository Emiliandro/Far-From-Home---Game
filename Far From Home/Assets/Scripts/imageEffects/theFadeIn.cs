using UnityEngine;
using System.Collections;

public class theFadeIn : MonoBehaviour {
    public SpriteRenderer sprite;

    // Use this for initialization
    void Start()
    {
        sprite.color = Color.clear;

        StartCoroutine("FadeIn");

    }

    IEnumerator FadeIn()
    {
        while (sprite.color.a < 0.99f)
        {
            sprite.color = new Color(1f, 1f, 1f, sprite.color.a + (Time.deltaTime / 2));
            yield return new WaitForSeconds(Time.deltaTime / 2);
        }
    }
}
