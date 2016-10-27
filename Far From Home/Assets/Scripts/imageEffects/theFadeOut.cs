using UnityEngine;
using System.Collections;

public class theFadeOut : MonoBehaviour {

    public SpriteRenderer sprite;

    // Use this for initialization
    void Start () {
        StartCoroutine("FadeOut");

    }

    IEnumerator FadeOut()
    {
        while (sprite.color.a > 0.01f)
        {
            sprite.color = new Color(1f, 1f, 1f, sprite.color.a - (Time.deltaTime / 4));
            yield return new WaitForSeconds(Time.deltaTime / 4);
        }
    }
}
