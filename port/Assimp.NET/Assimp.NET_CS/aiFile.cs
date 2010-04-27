/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiFile : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiFile(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiFile obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiFile() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AssimpPINVOKE.delete_aiFile(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_f_p_aiFile_p_char_size_t_size_t__size_t ReadProc {
    set {
      AssimpPINVOKE.aiFile_ReadProc_set(swigCPtr, SWIGTYPE_p_f_p_aiFile_p_char_size_t_size_t__size_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiFile_ReadProc_get(swigCPtr);
      SWIGTYPE_p_f_p_aiFile_p_char_size_t_size_t__size_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_aiFile_p_char_size_t_size_t__size_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_aiFile_p_q_const__char_size_t_size_t__size_t WriteProc {
    set {
      AssimpPINVOKE.aiFile_WriteProc_set(swigCPtr, SWIGTYPE_p_f_p_aiFile_p_q_const__char_size_t_size_t__size_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiFile_WriteProc_get(swigCPtr);
      SWIGTYPE_p_f_p_aiFile_p_q_const__char_size_t_size_t__size_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_aiFile_p_q_const__char_size_t_size_t__size_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_aiFile__size_t TellProc {
    set {
      AssimpPINVOKE.aiFile_TellProc_set(swigCPtr, SWIGTYPE_p_f_p_aiFile__size_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiFile_TellProc_get(swigCPtr);
      SWIGTYPE_p_f_p_aiFile__size_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_aiFile__size_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_aiFile__size_t FileSizeProc {
    set {
      AssimpPINVOKE.aiFile_FileSizeProc_set(swigCPtr, SWIGTYPE_p_f_p_aiFile__size_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiFile_FileSizeProc_get(swigCPtr);
      SWIGTYPE_p_f_p_aiFile__size_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_aiFile__size_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_aiFile_size_t_enum_aiOrigin__aiReturn SeekProc {
    set {
      AssimpPINVOKE.aiFile_SeekProc_set(swigCPtr, SWIGTYPE_p_f_p_aiFile_size_t_enum_aiOrigin__aiReturn.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiFile_SeekProc_get(swigCPtr);
      SWIGTYPE_p_f_p_aiFile_size_t_enum_aiOrigin__aiReturn ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_aiFile_size_t_enum_aiOrigin__aiReturn(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_aiFile__void FlushProc {
    set {
      AssimpPINVOKE.aiFile_FlushProc_set(swigCPtr, SWIGTYPE_p_f_p_aiFile__void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiFile_FlushProc_get(swigCPtr);
      SWIGTYPE_p_f_p_aiFile__void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_aiFile__void(cPtr, false);
      return ret;
    } 
  }

  public string UserData {
    set {
      AssimpPINVOKE.aiFile_UserData_set(swigCPtr, value);
    } 
    get {
      string ret = AssimpPINVOKE.aiFile_UserData_get(swigCPtr);
      return ret;
    } 
  }

  public aiFile() : this(AssimpPINVOKE.new_aiFile(), true) {
  }

}
