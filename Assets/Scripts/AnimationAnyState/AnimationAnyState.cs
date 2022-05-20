using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAnyState : MonoBehaviour
{
    private Animator animator;
    private AnimationClip[] clips;

    private void Start()
    {
        StartCoroutine(PlayRandomly());
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
        clips = animator.runtimeAnimatorController.animationClips;
    }

    private IEnumerator PlayRandomly()
    {
        while (true)
        {
            var randInd = Random.Range(0, clips.Length);
            var randClip = clips[randInd];

            animator.Play(randClip.name);

            yield return new WaitForSeconds(randClip.length);
        }
    }
}
