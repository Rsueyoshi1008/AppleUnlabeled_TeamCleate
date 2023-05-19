using UnityEngine;

public class keyInput : MonoBehaviour
{
 public AudioClip sound1;
 AudioSource SE;

    // Start is called before the first frame update
    void Start()
    {
        SE = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.Return))
        {
            SE.PlayOneShot(sound1);
        }
    }
}