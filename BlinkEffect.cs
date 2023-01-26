using UnityEngine;
 
public class BlinkEffect : MonoBehaviour
{
    public Color startColor = Color.green;
    public Color scndColor = Color.black;
    public Color trdcolor = Color.blue;
    public Color frthcolor = Color.red;
    [Range(0,10)]
    public float speed = 1;
 
    Renderer ren;
 
    void Awake()
    {
        ren = GetComponent<Renderer>();
    }
 
    void Update()
    {
        ren.material.color = Color.Lerp(startColor, scndColor, Mathf.PingPong(Time.time * speed, 1));
    }
    
}