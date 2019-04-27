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
        if (player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("blue-rocket"))
        {
            print("blue");
        }

        //print(playerAnimations[Random.Range(0, 8)].name);
        //player.GetComponent<Animation>().Play(playerAnimations[Random.Range(0, 8)].name);
        //if (_animation != null) {
        //    _animation.clip.legacy = true;
        //}
        //anim.SetInteger();
        //Color[] colors = { new Color(153, 0, 0, 1), Color.blue, new Color(0, 153, 153, 1), new Color(0, 153, 0, 1), new Color(255, 128, 0, 1), Color.magenta  };
        //int randColor = Random.Range(0, colors.Length);
        //player.GetComponent<Renderer>().material.color = colors[randColor];
        //player.GetComponent<SpriteRenderer>().sprite = colors[randColor];
    }
}
