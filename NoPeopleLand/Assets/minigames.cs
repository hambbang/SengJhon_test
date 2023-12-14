using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class minigames : MonoBehaviour
{
    [SerializeField] Transform topPivot;
    [SerializeField] Transform bottomPivot;

    [SerializeField] Transform fish;

    float fishposition;
    float fishDestination;

    float fishTimer;
    [SerializeField] float timerMultiplicator = 3f;

    float fishSpeed;
    [SerializeField] float smoothMotion = 1f;

    [SerializeField] Transform hook;
    public float hookPosition;
    [SerializeField] float hookSize = 0.1f;
    [SerializeField] float hookPower = 0.5f;
    public static float hookProgress;
    public float hookPullVelocity;
    [SerializeField] float hookPullPower = 1f;
    [SerializeField] float hookGravitypower = 0.005f;
    [SerializeField] float hookProgressDegradationPower = 1f;
    [SerializeField] SpriteRenderer hookSpriteRenderer;

    [SerializeField] Transform progressBarCOntainer;
    public static bool pause = false;
    [SerializeField] public static float failTimer = 10f;
    public static bool stop=false;


    private void Start()
    {
        Resize();
    }
    
    private void Resize()
    {
        Bounds b = hookSpriteRenderer.bounds;
        float ySize = b.size.y;
        Vector3 ls = hook.localScale;
        float distance = Vector3.Distance(topPivot.position,bottomPivot.position);
        ls.y = (distance / ySize * hookSize);
        hook.localScale = ls;
    }

    private void Update()
    {
        if(pause) 
        {
            gameObject.SetActive(false);
        }

        Fish();
        Hook();
        ProgressCheck();
    }

    private void ProgressCheck()
    {
        Vector3 ls = progressBarCOntainer.localScale;
        ls.y = hookProgress;
        progressBarCOntainer.localScale = ls;

        float min = hookPosition - hookSize / 2;
        float max = hookPosition + hookSize / 2;

        if(min < fishposition && fishposition < max)
        {
            hookProgress += hookPower * Time.deltaTime;
        }
        else
        {
            hookProgress -= hookProgressDegradationPower * Time.deltaTime;

            failTimer -= Time.deltaTime;
            if(failTimer < 0f)
            {
                Lose();
            }
        }

        if(hookProgress >= 1f)
        {
            Win();
        }
        hookProgress = Mathf.Clamp(hookProgress, 0f, 1f);
        
       
       
    }

    private void Win()
    {
        pause = true;
        if (stop ==false)
        {
            Debug.Log("YOU WIN!");
            stop = true;
        }

    }
    private void Lose()
    {
        pause = true;
        if (stop == false)
        {
            Debug.Log("YOU LOSE");
            stop = true;
        }
    }
    void Hook()
    {
        if(Input.GetMouseButton(0))
        {
            hookPullVelocity += hookPullPower * Time.deltaTime;
        }
        hookPullVelocity -= hookGravitypower * Time.deltaTime;
        hookPosition += hookPullVelocity;
        hookPosition = Mathf.Clamp(hookPosition, hookSize / 2 , 1 - hookSize/2);

        if(hookPosition - hookSize / 2 <= 0f && hookPullVelocity < 0f)
        {
            hookPullVelocity = 0f;
        }
        if(hookPosition + hookSize / 2 >= 1f && hookPullVelocity > 0f)
        {
            hookPullVelocity = 0f;
        }
        hook.position = Vector3.Lerp(bottomPivot.position, topPivot.position, hookPosition);
        hook.position = new Vector3(hook.position.x, hook.position.y, -0.5f);

       
       
    }

   void Fish()
    {
        fishTimer -= Time.deltaTime;
        if (fishTimer < 0f)
        {
            fishTimer = UnityEngine.Random.value * timerMultiplicator;

            fishDestination = UnityEngine.Random.value;
        }

        fishposition = Mathf.SmoothDamp(fishposition, fishDestination, ref fishSpeed, smoothMotion);
        fish.position = Vector3.Lerp(bottomPivot.position, topPivot.position, fishposition);
        fish.position = new Vector3(fish.position.x, fish.position.y, -1f);
    }
}

