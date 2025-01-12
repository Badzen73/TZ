using UnityEngine;

public class LevelUp : MonoBehaviour
{
    private int lvl_1 = 50;

    public Mesh model_1;
    private SkinnedMeshRenderer modelPlayer;
    public Animator anim;

    private void Start()
    {
        modelPlayer = transform.GetComponent<SkinnedMeshRenderer>();
    }

    private void Update()
    {
        if(lvl_1 <= PlayerInfo.moneyPlayer)
        {
            modelPlayer.sharedMesh = model_1;
            PlayerInfo.level = 1;
            anim.SetBool("NewLevel", true);
            anim.SetBool("Model_1", true);
        }
    }
}
