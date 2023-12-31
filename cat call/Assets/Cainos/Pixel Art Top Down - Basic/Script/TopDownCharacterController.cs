﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;

        private Animator animator;


        public AudioClip[] footstepSounds;
        public float footstepInterval = 0.5f;
        float lastStepTime = 0;

        private void Start()
        {
            animator = GetComponent<Animator>();
        }


        private void Update()
        {
            Vector2 dir = Vector2.zero;
            if (Input.GetKey(KeyCode.A))
            {
                dir.x = -1;
                animator.SetInteger("Direction", 3);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir.x = 1;
                animator.SetInteger("Direction", 2);
            }

            if (Input.GetKey(KeyCode.W))
            {
                dir.y = 1;
                animator.SetInteger("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir.y = -1;
                animator.SetInteger("Direction", 0);
            }

            dir.Normalize();
            animator.SetBool("IsMoving", dir.magnitude > 0);

            GetComponent<Rigidbody2D>().velocity = speed * dir;
            //transform.position += (Vector3)dir * speed * Time.deltaTime;

            if (dir.magnitude > 0 && Time.time - lastStepTime > footstepInterval)
            {
                lastStepTime = Time.time;
                AudioBox.instance.PlayClip(footstepSounds[Random.Range(0, footstepSounds.Length)]);
            }
        }
    }
}
