using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EasyTouchDemoLogic 
{
    public EasyTouchDemoLogic(GameObject tmpTarget,GameObject tmpDown,Transform tmpOwer,float tmpMoveSpeedMul,float tmpMinWidth,float tmpMaxWidth,float tmpMinHeight,float tmpMaxHeight)
    {
        this.target=tmpTarget;
        this.downImage=tmpDown;
        this.Ower=tmpOwer;
        this.MoveSpeedMul=tmpMoveSpeedMul;

        this.minWidth=tmpMinWidth;
        this.maxWidth=tmpMaxWidth;
        this.minHeight=tmpMinHeight;
        this.maxHeight=tmpMaxHeight;
    }
    Vector2 orginPos;
    public float radius=200;
    private GameObject target;
    public GameObject Target
    {
        set
        {
            target=value;
        }
    }
    private GameObject downImage;
    public GameObject DownImage
    {
        set
        {
            downImage=value;
        }
    }
    public float speed=3;
    private Transform ower;
    public Transform Ower
    {
        set
        {
            ower=value;
        }
    }

    private Vector2 saveOriginPos;
    public Vector2 SaveOriginPos
    {
        set
        {
            saveOriginPos=value;
        }
        get
        {
            return saveOriginPos;
        }
    }
    private float moveSpeedMul;
    public float MoveSpeedMul
    {
        set
        {
            moveSpeedMul=value;
        }
        get
        {
            return moveSpeedMul;
        }
    }
    private Vector3 moveVector=new Vector3();
    private bool isPress=false;
    Vector2 deltaPos;
    float minWidth;
    float maxWidth;
    float minHeight;
    float maxHeight;
    public void OnBeginDrag(BaseEventData eventData)
    {
        isPress=true;
    }

    public void OnDrag(BaseEventData eventData)
    {
        PointerEventData tmpData=(PointerEventData)eventData;
        orginPos=SaveOriginPos;  //這東東好像第一次後調用Drag會遺失或定值或跑值，讓角色一直朝同一方向移動，所以重新付值
        deltaPos=tmpData.position-orginPos; //downImage會動，原本是不會動的圓心變imagetransform
        if(deltaPos.magnitude<radius)
        {
            //ower.position=tmpData.position;
            ower.position=Input.mousePosition;
        }
        else
        {    //世界位置           //初始               //相對位置
            ower.position=orginPos+deltaPos.normalized*radius;
            
            // float myAngle=Mathf.Atan2(deltaPos.y,deltaPos.x)*Mathf.Rad2Deg;
            // if(target!=null)
            // {
            //     Vector3 tmpAngle=target.transform.localEulerAngles;
            //     //不可tmpAngle.y=myAngle
            //     tmpAngle.y=90-myAngle;
            //     target.transform.localEulerAngles=tmpAngle;
            // }
            
        }
        // if(deltaPos.magnitude>10f)
        //PlayerManager.Instance.PlayerCtl.DGMove(deltaPos.x,deltaPos.y);
        OnDragDetectSpeed();
        
    }
    public void OnEndDrag(BaseEventData eventData)
    {
        isPress=false;
        deltaPos=Vector2.zero;
        ower.position=SaveOriginPos;

        //PlayerManager.Instance.PlayerCtl.fSMManager.ChangeState((sbyte)RolerBase.AnimationEnum.Idle);

        
    }
    public void Start() {
        orginPos=ower.position;
        SaveOriginPos=orginPos;
    }
    private void OnDragDetectSpeed()
    {
        // if(PlayerDemoCtl.directionMagnitude>5.0f&&PlayerManager.Instance.PlayerCtl.fSMManager.CheckNotEqualState((sbyte)RolerBase.AnimationEnum.Run))
        // {
        //     PlayerManager.Instance.PlayerCtl.fSMManager.ChangeState((sbyte)RolerBase.AnimationEnum.Run);
        // }
        
        // if(PlayerDemoCtl.directionMagnitude<5.0f&&PlayerDemoCtl.directionMagnitude>0.08f&&PlayerManager.Instance.PlayerCtl.fSMManager.CheckNotEqualState((sbyte)RolerBase.AnimationEnum.Walk))
        // {
        //     PlayerManager.Instance.PlayerCtl.fSMManager.ChangeState((sbyte)RolerBase.AnimationEnum.Walk);
        // }

        // if(PlayerDemoCtl.directionMagnitude<0.08f&&PlayerManager.Instance.PlayerCtl.fSMManager.CheckNotEqualState((sbyte)RolerBase.AnimationEnum.Idle))
        // {
        //     PlayerManager.Instance.PlayerCtl.fSMManager.ChangeState((sbyte)RolerBase.AnimationEnum.Idle);
        // }
    }

    public void Update() {
        // if(isPress)
        // {
        //     PlayerManager.Instance.PlayerCtl.DGMove(deltaPos.x,deltaPos.y);
        // }
        
        if(isPress)
        {
            moveVector.x=deltaPos.x;
            moveVector.y=deltaPos.y;
            if(target!=null&&(target.transform.position.x<minWidth))
            {
                moveVector.x=Mathf.Clamp(moveVector.x,0,Mathf.Abs(moveVector.x));
            }
            if(target!=null&&(target.transform.position.x>maxWidth))
            {
                moveVector.x=Mathf.Clamp(moveVector.x,-Mathf.Abs(moveVector.x),0);
            }
            if(target!=null&&(target.transform.position.y<minHeight))
            {
                moveVector.y=Mathf.Clamp(moveVector.y,0,Mathf.Abs(moveVector.y));
            }
            if(target!=null&&(target.transform.position.y>maxHeight))
            {
                moveVector.y=Mathf.Clamp(moveVector.y,-Mathf.Abs(moveVector.y),0);
            }
            if(target!=null)
            {
                target.transform.Translate(moveVector* moveSpeedMul* Time.deltaTime, Space.World);
            }
            
            
        }
    }

    
    // public void Update() {
    //     downImage.transform.position=Vector3.Lerp(downImage.transform.position,ower.position,Time.deltaTime*speed);    
    // }

    public void SetInsideMoveSpeedMul(float value)
    {
        moveSpeedMul=value;
    }

}
