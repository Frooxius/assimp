/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiRay : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiRay(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiRay obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiRay() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AssimpPINVOKE.delete_aiRay(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiRay() : this(AssimpPINVOKE.new_aiRay__SWIG_0(), true) {
  }

  public aiRay(aiVector3D _pos, aiVector3D _dir) : this(AssimpPINVOKE.new_aiRay__SWIG_1(aiVector3D.getCPtr(_pos), aiVector3D.getCPtr(_dir)), true) {
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiRay(aiRay o) : this(AssimpPINVOKE.new_aiRay__SWIG_2(aiRay.getCPtr(o)), true) {
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiVector3D pos {
    set {
      AssimpPINVOKE.aiRay_pos_set(swigCPtr, aiVector3D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiRay_pos_get(swigCPtr);
      aiVector3D ret = (cPtr == IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
      return ret;
    } 
  }

  public aiVector3D dir {
    set {
      AssimpPINVOKE.aiRay_dir_set(swigCPtr, aiVector3D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiRay_dir_get(swigCPtr);
      aiVector3D ret = (cPtr == IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
      return ret;
    } 
  }

}
