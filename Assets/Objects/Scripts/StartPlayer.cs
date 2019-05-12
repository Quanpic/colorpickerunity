using UnityEngine;
using Random = UnityEngine.Random;

public class StartPlayer : MonoBehaviour
{
    public GameObject player;
    public AnimationClip[] playerAnimations;
    public Sprite[] colors;
    private string[] animations = { "blue-rocket", "green-rocket", "lime-rocket", "orange-rocket", "pink-rocket", "purp-rocket", "red-rocket", "turq-rocket", "yellow-rocket" };
    //private Animator animator;
    public AnimationClip[] clip;
    public int randomInt;
    
    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
        int randColor = Random.Range(0, animations.Length);
        //player.GetComponent<Animator>().SetBool(animations[randColor], true);
        player.GetComponent<Animator>().Play(animations[randColor]);
        randomInt = randColor;
    }
}
