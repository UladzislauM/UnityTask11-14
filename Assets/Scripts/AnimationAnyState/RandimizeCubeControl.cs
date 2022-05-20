using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandimizeCubeControl : MonoBehaviour
{
    private Animator animator;
    private int random;
    private int nowRandom;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        nowRandom = 0;
    }
    public void AnyStateRandon()
    {
        random = Random.Range(0, 3);
        
        if (random != nowRandom)
        {
            animator.SetInteger("CubeAnimationID", random);
            nowRandom = random;
        }
    }
}
