/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiNodeAnim : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiNodeAnim(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiNodeAnim obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiNodeAnim() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AssimpPINVOKE.delete_aiNodeAnim(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiString mNodeName {
    set {
      AssimpPINVOKE.aiNodeAnim_mNodeName_set(swigCPtr, aiString.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiNodeAnim_mNodeName_get(swigCPtr);
      aiString ret = (cPtr == IntPtr.Zero) ? null : new aiString(cPtr, false);
      return ret;
    } 
  }

  public uint mNumPositionKeys {
    set {
      AssimpPINVOKE.aiNodeAnim_mNumPositionKeys_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiNodeAnim_mNumPositionKeys_get(swigCPtr);
      return ret;
    } 
  }

  public aiVectorKey mPositionKeys {
    set {
      AssimpPINVOKE.aiNodeAnim_mPositionKeys_set(swigCPtr, aiVectorKey.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiNodeAnim_mPositionKeys_get(swigCPtr);
      aiVectorKey ret = (cPtr == IntPtr.Zero) ? null : new aiVectorKey(cPtr, false);
      return ret;
    } 
  }

  public uint mNumRotationKeys {
    set {
      AssimpPINVOKE.aiNodeAnim_mNumRotationKeys_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiNodeAnim_mNumRotationKeys_get(swigCPtr);
      return ret;
    } 
  }

  public aiQuatKey mRotationKeys {
    set {
      AssimpPINVOKE.aiNodeAnim_mRotationKeys_set(swigCPtr, aiQuatKey.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiNodeAnim_mRotationKeys_get(swigCPtr);
      aiQuatKey ret = (cPtr == IntPtr.Zero) ? null : new aiQuatKey(cPtr, false);
      return ret;
    } 
  }

  public uint mNumScalingKeys {
    set {
      AssimpPINVOKE.aiNodeAnim_mNumScalingKeys_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiNodeAnim_mNumScalingKeys_get(swigCPtr);
      return ret;
    } 
  }

  public aiVectorKey mScalingKeys {
    set {
      AssimpPINVOKE.aiNodeAnim_mScalingKeys_set(swigCPtr, aiVectorKey.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiNodeAnim_mScalingKeys_get(swigCPtr);
      aiVectorKey ret = (cPtr == IntPtr.Zero) ? null : new aiVectorKey(cPtr, false);
      return ret;
    } 
  }

  public aiAnimBehaviour mPreState {
    set {
      AssimpPINVOKE.aiNodeAnim_mPreState_set(swigCPtr, (int)value);
    } 
    get {
      aiAnimBehaviour ret = (aiAnimBehaviour)AssimpPINVOKE.aiNodeAnim_mPreState_get(swigCPtr);
      return ret;
    } 
  }

  public aiAnimBehaviour mPostState {
    set {
      AssimpPINVOKE.aiNodeAnim_mPostState_set(swigCPtr, (int)value);
    } 
    get {
      aiAnimBehaviour ret = (aiAnimBehaviour)AssimpPINVOKE.aiNodeAnim_mPostState_get(swigCPtr);
      return ret;
    } 
  }

  public aiNodeAnim() : this(AssimpPINVOKE.new_aiNodeAnim(), true) {
  }

}
