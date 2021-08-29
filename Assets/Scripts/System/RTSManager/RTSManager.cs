using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RTSManager : MonoBehaviour
{
    static RTSManager _instance;
    public static RTSManager Instance{
        get{
            if (_instance == null){
                _instance = FindObjectOfType(typeof(RTSManager)) as RTSManager;
                if (_instance == null){
                    GameObject go = new GameObject("RTSManager");
                    _instance = go.AddComponent<RTSManager>();
                }
            }
            return _instance;
        }
    }

    public void RTSControl(List<GameObject> moveObjects,GameObject moveToPositionObj,float[] ringDistance,int[] ringPositionCount,float moveTime,float angleOffset)
    {
        Vector3 moveToPosition=moveToPositionObj.transform.position;
        // Right Mouse Button Pressed
        //Vector3 moveToPosition = UtilsClass.GetMouseWorldPosition();

        //Vector3 worldPosition = Camera.main.ScreenToWorldPoint(moveToPosition);
        Vector3 worldPosition = moveToPosition;
        worldPosition.z=0;

        //List<Vector3> targetPositionList = GetPositionListAround(worldPosition, new float[] { 10f, 20f, 30f }, new int[] { 5, 10, 20 });
        List<Vector3> targetPositionList = GetPositionListAround(worldPosition,ringDistance,ringPositionCount,angleOffset);

        int targetPositionListIndex = 0;

        foreach (var unitRTS in moveObjects) {
            //unitRTS.MoveTo(targetPositionList[targetPositionListIndex]);
            if(unitRTS!=null)
            {
                unitRTS.transform.DOMove(targetPositionList[targetPositionListIndex],moveTime);
            }
            
            targetPositionListIndex = (targetPositionListIndex + 1) % targetPositionList.Count;
        }
    }

    public void RTSControl_NoStartPoint(List<GameObject> moveObjects,GameObject moveToPositionObj,float[] ringDistance,int[] ringPositionCount,float moveTime,float angleOffset)
    {
        
        //目標中心
        Vector3 worldPosition = moveToPositionObj.transform.position;   
        worldPosition.z=0;

        //計算環繞位置
        List<Vector3> targetPositionList = GetPositionListAround_NoStartPoint(worldPosition,ringDistance,ringPositionCount,angleOffset);

        //依序DOTWEEN移動
        int targetPositionListIndex = 0;
        foreach (var unitRTS in moveObjects) {
            if(unitRTS.activeSelf==true)
            {
                unitRTS.transform.DOMove(targetPositionList[targetPositionListIndex],moveTime);
            }
            targetPositionListIndex = (targetPositionListIndex + 1) % targetPositionList.Count;

            
        }
    }
    public void RTSRingRotateControl(List<GameObject> moveObjects,float rotateTime,float rotateAdd,List<Vector3> rotationVector)
    {
        //計算環繞位置
        List<Vector3> targetRotationList =rotationVector;

        for(int i=0;i<moveObjects.Count;i++)
        {
            targetRotationList[i]=rotationVector[i]+new Vector3(0,0,rotateAdd);
        }
        //依序DOTWEEN移動
        int targetRotationListIndex = 0;
        foreach (var unitRTS in moveObjects) {
            unitRTS.transform.DORotate(targetRotationList[targetRotationListIndex],rotateTime);
            targetRotationListIndex = (targetRotationListIndex + 1) % targetRotationList.Count;
        }
    }

    #region 含中心RING
    private List<Vector3> GetPositionListAround(Vector3 startPosition, float[] ringDistanceArray, int[] ringPositionCountArray,float angleOffset) {
        List<Vector3> positionList = new List<Vector3>();
        positionList.Add(startPosition);
        for (int i = 0; i < ringDistanceArray.Length; i++) {
            positionList.AddRange(GetPositionListAround(startPosition, ringDistanceArray[i], ringPositionCountArray[i],angleOffset));
            
        }
        return positionList;
    }

    private List<Vector3> GetPositionListAround(Vector3 startPosition, float distance, int positionCount,float angleOffset) {
        List<Vector3> positionList = new List<Vector3>();
        for (int i = 0; i < positionCount; i++) {
            float angle = i * (360f / positionCount)+angleOffset;
            Vector3 dir = ApplyRotationToVector(new Vector3(1, 0), angle);
            Vector3 position = startPosition + dir * distance;
            positionList.Add(position);
        }
        return positionList;
    }

    private Vector3 ApplyRotationToVector(Vector3 vec, float angle) {
        return Quaternion.Euler(0, 0, angle) * vec;
    }
    #endregion


    #region 不含中心RING
    private List<Vector3> GetPositionListAround_NoStartPoint(Vector3 startPosition, float[] ringDistanceArray, int[] ringPositionCountArray,float angleOffset) {
        List<Vector3> positionList = new List<Vector3>();
        //positionList.Add(startPosition);
        for (int i = 0; i < ringDistanceArray.Length; i++) {
            positionList.AddRange(GetPositionListAround(startPosition, ringDistanceArray[i], ringPositionCountArray[i],angleOffset));
            
        }
        return positionList;
    }
    //同 GetPositionListAround
    // private List<Vector3> GetPositionListAround_NoStartPoint(Vector3 startPosition, float distance, int positionCount,float angleOffset) {
    //     List<Vector3> positionList = new List<Vector3>();
    //     for (int i = 0; i < positionCount; i++) {
    //         float angle = i * (360f / positionCount)+angleOffset;
    //         Vector3 dir = ApplyRotationToVector(new Vector3(1, 0), angle);
    //         Vector3 position = startPosition + dir * distance;
    //         positionList.Add(position);
    //     }
    //     return positionList;
    // }

    //同 ApplyRotationToVector
    // private Vector3 ApplyRotationToVector(Vector3 vec, float angle) {
    //     return Quaternion.Euler(0, 0, angle) * vec;
    // }
    #endregion


    public void ToPlayerFront(List<GameObject> moveObjects,GameObject playerObject,float duration,Vector3 frontVector)
    {
        for(int i=0;i<moveObjects.Count;i++)
        {
            if(moveObjects[i]!=null&&playerObject!=null)
            {
                moveObjects[i].transform.DOMove(playerObject.transform.position+frontVector,duration);
            }
        }
    }
}
