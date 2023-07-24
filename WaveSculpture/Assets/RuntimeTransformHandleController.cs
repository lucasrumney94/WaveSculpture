using System.Collections.Generic;
using RuntimeHandle;
using UnityEngine;

public class RuntimeTransformHandleController : MonoBehaviour
{
    public RuntimeTransformHandle localPosition;
    public RuntimeTransformHandle globalPosition;
    public RuntimeTransformHandle localRotation;
    public RuntimeTransformHandle globalRotation;
    public RuntimeTransformHandle localScale;
    public RuntimeTransformHandle globalScale;

    public bool handlesVisible = true;
    private List<RuntimeTransformHandle> handles;

    void Start()
    {
        handles = new List<RuntimeTransformHandle>();
        if (localPosition != null)
            handles.Add(localPosition);
        if (globalPosition != null)
            handles.Add(globalPosition);
        if(localRotation != null)
            handles.Add(localRotation);
        if(globalRotation != null)
            handles.Add(globalRotation);
        if (localScale != null)
            handles.Add(localScale);
        if (globalScale != null)
            handles.Add(globalScale);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            handlesVisible = !handlesVisible;
            if (handlesVisible)
            {
                HandlesOn();
            }
            else
            {
                HandlesOff();
            }
        }
    }

    void HandlesOff()
    {
        foreach (RuntimeTransformHandle handle in handles)
        {
            handle.autoScaleFactor = 0.0f;
        }
    }

    void HandlesOn()
    {
        foreach (RuntimeTransformHandle handle in handles)
        {
            if (handle.type == HandleType.POSITION)
            {
                handle.autoScaleFactor = 0.85f/100.0f;
            }
            else if (handle.type == HandleType.ROTATION)
            {
                handle.autoScaleFactor = 1.0f / 100.0f;
            }
            else if (handle.type == HandleType.SCALE)
            {
                handle.autoScaleFactor = 1.15f/100.0f;
            }

        }
    }
}
