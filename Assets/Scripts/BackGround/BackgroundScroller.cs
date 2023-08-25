using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField]
    private float scrollSpeed = 0.5f;
    private float offset;
    private Renderer mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset += (scrollSpeed * Time.deltaTime);
        mat.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
